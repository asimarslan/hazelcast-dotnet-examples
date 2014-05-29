﻿using System;
using System.Collections.Generic;
using Hazelcast.Config;
using Hazelcast.Client;
using Hazelcast.Core;
using Hazelcast.IO.Serialization;

namespace Hazelcast.Client.Example
{
    public class SimpleExample1
    {

        static void Main(string[] args)
        {
            var clientConfig = new ClientConfig();
            clientConfig.GetNetworkConfig().AddAddress("127.0.0.1");
            //clientConfig.GetNetworkConfig().AddAddress("10.0.0.2:5702");

            //Portable Serialization setup up for Customer CLass
            clientConfig.GetSerializationConfig().AddPortableFactory(MyPortableFactory.FactoryId, new MyPortableFactory());


            IHazelcastInstance client = HazelcastClient.NewHazelcastClient(clientConfig);
            //All cluster operations that you can do with ordinary HazelcastInstance
            IMap<string, Customer> mapCustomers = client.GetMap<string, Customer>("customers");
            mapCustomers.Put("1", new Customer("Joe", "Smith"));
            mapCustomers.Put("2", new Customer("Ali", "Selam"));
            mapCustomers.Put("3", new Customer("Avi", "Noyan"));


            Customer customer1 = mapCustomers.Get("1");
            Console.WriteLine(customer1);

            //ICollection<Customer> customers = mapCustomers.Values();
            //foreach (var customer in customers)
            //{
            //    //customer
            //}

            HazelcastClient.ShutdownAll();
            Console.ReadKey();
        }
    }

    public class MyPortableFactory : IPortableFactory
    {
        public const int FactoryId = 1;

        public IPortable Create(int classId) {
            if (Customer.Id == classId)
                return new Customer();
            else return null;
        }
    }

    public class Customer: IPortable
    {
        private string name;
        private string surname;

        public const int Id = 5;

        public Customer(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public Customer(){}


        public int GetFactoryId()
        {
            return MyPortableFactory.FactoryId;
        }

        public int GetClassId()
        {
            return Id;
        }

        public void WritePortable(IPortableWriter writer)
        {
            writer.WriteUTF("n", name);
            writer.WriteUTF("s", surname);
        }

        public void ReadPortable(IPortableReader reader)
        {
            name = reader.ReadUTF("n");
            surname = reader.ReadUTF("s");
        }


    }
}
