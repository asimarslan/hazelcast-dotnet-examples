using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Hazelcast.Client;
using Hazelcast.Config;
using Hazelcast.Core;
using Metrics;
using Metrics.Utils;
using Metrics.Reporters;
using Timer = Metrics.Timer;

namespace ClientPerformance
{
    class Performance
    {
        
    //    public File cvsDir = new File( System.getProperty("cvsDir", "/Users/danny") );
 
    //public String clientHzFile = System.getProperty("clientHzFile", "client-hazelcast.xml");
    //public String baseMapName= System.getProperty("baseMapName", "m");
    //public int totalMaps =  Integer.parseInt(System.getProperty("totalMaps", "10"));
    //public int totalKeys = Integer.parseInt(System.getProperty("totalKeys", "10"));
    //public int valueByteArraySize = Integer.parseInt(System.getProperty("valueByteArraySize", "10"));
 
    //public double putProb=Double.parseDouble(System.getProperty("putProb", "0.5"));
    //public double getProb=Double.parseDouble(System.getProperty("getProb", "0.5"));
    //public double setProb=Double.parseDouble(System.getProperty("setProb", "0.0"));
 
    //public int threadCount = Integer.parseInt(System.getProperty("threadCount", "8"));;
    //public boolean sharedMetrics = Boolean.parseBoolean(System.getProperty("sharedMetrics", "true"));;
 
    //private HazelcastInstance client;
    //private ExecutorService executor;
    //private Set<MyTask> tasks;
    //private int durationSeconds=0;

        public static string cvsDir = ReadEnvVar("cvsDir", ".\\csv");//TODO MAKE IT WINDOWS LOCATION

        public String clientHzFile = ReadEnvVar("clientHzFile", "client-hazelcast.xml");
        public static String baseMapName = ReadEnvVar("baseMapName", "m");
        public static int totalMaps = (int)ReadEnvironmentVar("totalMaps", 10);
        public static int totalKeys = (int)ReadEnvironmentVar("totalKeys", 10);
        public static int valueByteArraySize = (int)ReadEnvironmentVar("valueByteArraySize", 10);

        public static double putProb = ReadEnvironmentVar("putProb", 0.5);
        public static double getProb = ReadEnvironmentVar("getProb", 0.5);
        public static double setProb = ReadEnvironmentVar("setProb", 0.0);

        public static int threadCount = (int)ReadEnvironmentVar("threadCount", 8);
        public static int sharedMetrics = (int)ReadEnvironmentVar("sharedMetrics", 1);

        private static IHazelcastInstance client;
        private LimitedConcurrencyLevelTaskScheduler executor;
        private ISet<MyTask> tasks;
        private int durationSeconds=0;

        private TaskFactory factory;

        public Performance()
        {
            executor = new LimitedConcurrencyLevelTaskScheduler(threadCount);
            factory = new TaskFactory(executor);
            //client = HazelcastClient.NewHazelcastClient(clientHzFile);

            var clientConfig = new ClientConfig();
            clientConfig.GetNetworkConfig().AddAddress("192.168.2.39");
            clientConfig.GetNetworkConfig().SetConnectionAttemptLimit(1000);
            client = HazelcastClient.NewHazelcastClient(clientConfig);

            tasks = new HashSet<MyTask>();
            for (int i = 0; i < threadCount; i++)
            {
                tasks.Add(new MyTask());
            }

        }

        static String ReadEnvVar(String var, String defaultVal)
        {
            var clientHzFile = Environment.GetEnvironmentVariable(var);
            return clientHzFile ?? defaultVal;
        }

        static double ReadEnvironmentVar(string var, double defaultVal)
        {
            double p = 0;
            var param = Environment.GetEnvironmentVariable(var);
            if (param != null)
            {
                p = Convert.ToDouble(param);
            }
            return param!= null? p :defaultVal;
        }

        static void Main(string[] args)
        {
            int jitWarmUpSec = (int)ReadEnvironmentVar("jitWarmUpSec", 10);
            int durationSec = (int)ReadEnvironmentVar("durationSec", 30);

            Performance p = new Performance();
            p.run(jitWarmUpSec);

            p.run(durationSec);
            p.printResults();

            
            
        }

        public void printResults()
        {
            var csvFileAppender = new CSVFileAppender(cvsDir, ",");
            foreach(MyTask t in tasks)
            {
                var report = new CSVReport(csvFileAppender);

                report.RunReport(t.metrics.DataProvider.CurrentMetricsData, () => { return new Metrics.HealthStatus(); }, new CancellationToken());

                //ConsoleReport reporter = ConsoleReport.forRegistry(t.metrics).build();
                //CSVReport csv = CSVReport.forRegistry(t.metrics).build(cvsDir);

                //csv.RunReport();
                //reporter.RunReport();

                if(sharedMetrics>0)
                {
                    break;
                }
            }
        }


        public void run(int seconds)
        {
            durationSeconds = seconds;
            var metrics = Metric.Context("shared");
            foreach (var t in tasks)
            {
                t.Duration = durationSeconds;

                if (sharedMetrics == 0)
                {
                    t.metrics = metrics;
                }
                else
                {
                    t.metrics = Metric.Context(t.ToString());
                }
                factory.StartNew(() => t.Call());
            }
        }

        class MyTask
        {
            public MetricsContext metrics;

            private Random random = new Random();
            private int duration;


            private byte[] value;

            private Timer getTimer;
            private Timer putTimer;
            private Timer setTimer;

            public MyTask()
            {
                this.value = new byte[valueByteArraySize];
                random.NextBytes(value);
            }

            public int Duration
            {
                get { return duration; }
                set { duration = value; }
            }


            public void Call()
            {

                getTimer = metrics.Timer("getTimer", Unit.Requests);
                putTimer = metrics.Timer("putTimer", Unit.Requests);
                setTimer = metrics.Timer("setTimer", Unit.Requests);

                var endTime = DateTime.Now.AddSeconds(duration);
                while (DateTime.Now.CompareTo(endTime) < 0)
                {
                    var map = client.GetMap<object,object>(baseMapName + random.Next(totalMaps));

                    double chance = random.NextDouble();

                    if ((chance -= putProb) <= 0)
                    {
                        using (putTimer.NewContext())
                        {
                            map.Put(random.Next(totalKeys), value);
                        }
                     }
                    else if ((chance -= getProb) <= 0)
                    {
                        using (getTimer.NewContext())
                        {
                            map.Get(random.Next(totalKeys));
                        }
                    }
                    else
                    {
                        using (setTimer.NewContext())
                        {
                            map.Set(random.Next(totalKeys), value);
                        }
                    }
                }
            }
        }
    }
}
