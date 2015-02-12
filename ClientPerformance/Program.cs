using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Hazelcast.Client;
using Hazelcast.Core;
using Metrics;
using Timer = Metrics.Timer;

namespace ClientPerformance
{
    class Performance
    {
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
        //private LimitedConcurrencyLevelTaskScheduler executor;
        private ISet<MyTask> tasks;
        private int durationSeconds=0;

        private TaskFactory factory;

        public Performance()
        {
            client = HazelcastClient.NewHazelcastClient(clientHzFile);

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
            Console.WriteLine(Directory.GetCurrentDirectory());
            Metric.Config.WithReporting(report => report.WithCSVReports(cvsDir, TimeSpan.FromSeconds(15)));

            Metric.Config.WithReporting(report => report.WithConsoleReport(TimeSpan.FromSeconds(10)));

	    Metric.Config.WithReporting(report => report.WithTextFileReport(@"metrics.txt", TimeSpan.FromSeconds(1));

            int jitWarmUpSec = (int)ReadEnvironmentVar("jitWarmUpSec", 10);
            int durationSec = (int)ReadEnvironmentVar("durationSec", 30);

            Performance p = new Performance();
            p.run(jitWarmUpSec);

            p.run(durationSec);  
  
            client.Shutdown();
        }

        public void run(int seconds)
        {
            var tsks = new HashSet<Task>();
            durationSeconds = seconds;
            var metrics = Metric.Context("shared");
            foreach (var t in tasks)
            {
                t.Duration = durationSeconds;

                if (sharedMetrics > 0)
                {
                    t.metrics = metrics;
                }
                else
                {
                    t.metrics = Metric.Context(t.ToString());
                }
                var task = new Task(() => t.Call(),TaskCreationOptions.LongRunning);
                task.Start();
                tsks.Add(task);
            }
            try
            {

                Task.WaitAll(tsks.ToArray());
            }
            catch (Exception)
            {
            }
            Console.WriteLine("=TASKS-COMPLETE=");
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
                    var map = client.GetMap<object, object>(baseMapName + random.Next(totalMaps));
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
                //Console.WriteLine("Call DONE...");
            }
        }
    }
}
