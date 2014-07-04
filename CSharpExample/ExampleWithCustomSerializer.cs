using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Hazelcast.Config;
using Hazelcast.Client;
using Hazelcast.Core;
using Hazelcast.IO;
using Hazelcast.IO.Serialization;

namespace Hazelcast.Client.Example
{
    public class ExampleWithCustomSerializer
    {

        static void Main(string[] args)
        {
            var clientConfig = new ClientConfig();
            clientConfig.GetNetworkConfig().AddAddress("127.0.0.1");
            //clientConfig.GetNetworkConfig().AddAddress("10.0.0.2:5702");

            var sc = new SerializerConfig()
                .SetImplementation(new CustomSerializer())
                .SetTypeClass(typeof(Person));

            //Custom Serialization setup up for Person Class
            clientConfig.GetSerializationConfig().AddSerializerConfig(sc);


            IHazelcastInstance client = HazelcastClient.NewHazelcastClient(clientConfig);
            //All cluster operations that you can do with ordinary HazelcastInstance
            IMap<string, Person> mapCustomers = client.GetMap<string, Person>("persons");
            mapCustomers.Put("1", new Person("Joe", "Smith"));
            mapCustomers.Put("2", new Person("Ali", "Selam"));
            mapCustomers.Put("3", new Person("Avi", "Noyan"));

            ICollection<Person> persons = mapCustomers.Values();
            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }

            HazelcastClient.ShutdownAll();
            Console.ReadKey();
        }
    }

    class CustomSerializer : IStreamSerializer<Person>
    {
        public int GetTypeId()
        {
            return 10;
        }

        public void Destroy()
        {
            //NOOP
        }

        public void Write(IObjectDataOutput output, Person t)
        {
            byte[] array;
            var bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, t);
                array = ms.ToArray();                
            }

            output.WriteInt(array.Length);
            output.Write(array);
        }

        public Person Read(IObjectDataInput input)
        {
            var bf = new BinaryFormatter();
            var len = input.ReadInt();

            var buffer = new byte[len];
            input.ReadFully(buffer);

            Person result = null;
            using (var ms = new MemoryStream(buffer))
            {
                result = (Person)bf.Deserialize(ms);
            }
            return result;
        }
    }

    [Serializable]
    public class Person
    {
        private string name;
        private string surname;

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public override string ToString()
        {
            return "Person{ name:" + name + ", surname:"+surname + " }";
        }
    }
}
