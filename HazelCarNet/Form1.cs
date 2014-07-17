using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hazelcast.Client;
using Hazelcast.Config;
using Hazelcast.Core;

namespace HazelCarNet
{
    public partial class Form1 : Form
    {
        private IHazelcastInstance client;

        private IMap<CarKey, Car> map;

        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            //CONNNECT CODE
            ConnectToHZ();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            //DOISCONNECT CODE
            if (client != null)
            {
                client.Shutdown();
            }
        }

        private void ConnectToHZ()
        {
            var clientConfig = new ClientConfig();
            clientConfig.GetNetworkConfig().AddAddress("127.0.0.1");
            clientConfig.GetSerializationConfig().AddPortableFactory(PortableFactory.FactoryId, new PortableFactory());
            client = HazelcastClient.NewHazelcastClient(clientConfig);

            map = client.GetMap<CarKey, Car>("cars");

            //if (map != null && map.Size() == 0)
            //{
            //    //FILL
            //    for (int i = 1; i <= 100; i++)
            //    {
            //        CarKey key = new CarKey(i,"", "CAR_BRAND-"+i, "Model"+i, 1900+ i);
                    
            //        Car car = new Car();
            //        car.ModelBody = "";
            //        car.ModelEngineCc = 1000+ i * 10;
            //        car.ModelEngineCyl = i % 12;
            //        car.ModelEngineType = "type"+i;
            //        car.ModelEngineValvesPerCyl = 2;
            //        car.ModelEnginePowerPs = 50 % i;
            //        car.ModelEngineCompression = "";
            //        car.ModelEngineFuel = "Gas";
            //        car.ModelTopSpeedKph = 150 + i;
            //        car.Model0To100Kph = i;
            //        car.ModelTransmissionType = "type"+i;
            //        car.ModelWeightKg = 800 + i*2;

            //        map.Put(key, car);
            //    }
            //}

            bindDataSet();

        }

        private void bindDataSet()
        {

            var bindingList = new BindingList<RowData>();

            foreach (var entry in map.EntrySet())
            {
                bindingList.Add(new RowData(entry.Key, entry.Value));
            }
            bindingSource.DataSource = bindingList;

            rowDataView.DataSource = null;
            rowDataView.DataSource = bindingSource;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DOISCONNECT CODE
            if (client != null)
            {
                client.Shutdown();
            }

        }

        private void refreshDataButtom_Click(object sender, EventArgs e)
        {
            rowDataView.Rows.Clear();
            bindDataSet();
        }

        private void listenButton_Click(object sender, EventArgs e)
        {
            if (map != null)
            {
                IEntryListener<CarKey, Car> listener = new EntryAdapter<CarKey, Car>(EntryAdded,EntryRemoved,EntryUpdated,EntryEvicted);
                map.AddEntryListener(listener, true);
            }
        }

        void EntryAdded(EntryEvent<CarKey, Car> _event)
        {

            if (this.InvokeRequired)
            {
                this.Invoke(
                    new MethodInvoker(
                    delegate() { EntryAdded(_event); }));
            }
            else
            {
                BindingList<RowData> list = bindingSource.DataSource as BindingList<RowData>;

                CarKey key = _event.GetKey();
                Car car = _event.GetValue();

                list.Add(new RowData(key, car));
            }

        }

        void EntryRemoved(EntryEvent<CarKey, Car> _event)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    new MethodInvoker(
                    delegate() { EntryRemoved(_event); }));
            }
            else
            {
                long modelId = _event.GetKey().ModelId;

                BindingList<RowData> list = bindingSource.DataSource as BindingList<RowData>;

                for (int i = 0; i < list.Count; i++)
                {
                    if (modelId == list[i].ModelId)
                    {
                        list.RemoveAt(i);
                    }
                }
            }
        }

        void EntryUpdated(EntryEvent<CarKey, Car> _event)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    new MethodInvoker(
                    delegate() { EntryUpdated(_event); }));
            }
            else
            {
                Console.WriteLine("UPDATE RECEIVED");
                long modelId = _event.GetKey().ModelId;

                BindingList<RowData> list = bindingSource.DataSource as BindingList<RowData>;

                for (int i = 0; i < list.Count; i++)
                {
                    if (modelId == list[i].ModelId)
                    {
                        CarKey key = _event.GetKey();
                        Car car = _event.GetValue();

                        var row = list[i];
                        row.Update(key, car);
                        list[i] = row;
                    }
                }
               
            }           
        }

        void EntryEvicted(EntryEvent<CarKey, Car> _event)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    new MethodInvoker(
                    delegate() { EntryEvicted(_event); }));
            }
            else
            {
                long modelId = _event.GetKey().ModelId;

                BindingList<RowData> list = bindingSource.DataSource as BindingList<RowData>;

                for (int i = 0; i < list.Count; i++)
                {
                    if (modelId == list[i].ModelId)
                    {
                        list.RemoveAt(i);
                    }
                }
            }          
        }

        private void rowDataView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (rowDataView.Rows.Count > 0)
            {
                rowDataView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                rowDataView.Refresh();
                rowDataView.Update();
            }

        }

    }

 
}
