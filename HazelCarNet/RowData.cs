using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace HazelCarNet
{
    public class RowData : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private long model_id;
        private string model_make_id;
        private int model_year;
        private string model_name;

        private string model_body;
        private int model_engine_cc;
        private int model_engine_cyl;
        private string model_engine_type;
        private int model_engine_valves_per_cyl;
        private int model_engine_power_ps;
        private string model_engine_compression;
        private string model_engine_fuel;
        private int model_top_speed_kph;
        private float model_0_to_100_kph;
        private string model_transmission_type;
        private int model_weight_kg;


        public RowData(CarKey key, Car car)
        {
            model_id = key.ModelId;
            model_make_id = key.ModelMakeId;
            model_year = key.ModelYear;
            model_name = key.ModelName;
            model_body = car.ModelBody;
            model_engine_cc = car.ModelEngineCc;
            model_engine_cyl = car.ModelEngineCyl;
            model_engine_type = car.ModelEngineType;
            model_engine_valves_per_cyl = car.ModelEngineValvesPerCyl;
            model_engine_power_ps = car.ModelEnginePowerPs;
            model_engine_compression = car.ModelEngineCompression;
            model_engine_fuel = car.ModelEngineFuel;
            model_top_speed_kph = car.ModelTopSpeedKph;
            model_0_to_100_kph = car.Model0To100Kph;
            model_transmission_type = car.ModelTransmissionType;
            model_weight_kg = car.ModelWeightKg;
        }

        private void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }


        public long ModelId
        {
            get { return model_id; }
            set
            {
                model_id = value;
                NotifyPropertyChanged("ModelId");
            }
        }

        public string ModelMakeId
        {
            get { return model_make_id; }
            set
            {
                model_make_id = value;
                NotifyPropertyChanged("ModelMakeId");
            }
        }

        public int ModelYear
        {
            get { return model_year; }
            set
            {
                model_year = value;
                NotifyPropertyChanged("ModelYear");

            }
        }

        public string ModelName
        {
            get { return model_name; }
            set
            {
                model_name = value;
                NotifyPropertyChanged("ModelName");


            }
        }

        public string ModelBody
        {
            get { return model_body; }
            set
            {
                model_body = value; NotifyPropertyChanged("ModelBody");
            }
        }

        public int ModelEngineCc
        {
            get { return model_engine_cc; }
            set
            {
                model_engine_cc = value; NotifyPropertyChanged("ModelEngineCc");
            }
        }

        public int ModelEngineCyl
        {
            get { return model_engine_cyl; }
            set
            {
                model_engine_cyl = value; NotifyPropertyChanged("ModelEngineCyl");
            }
        }

        public string ModelEngineType
        {
            get { return model_engine_type; }
            set
            {
                model_engine_type = value; NotifyPropertyChanged("ModelEngineType");
            }
        }

        public int ModelEngineValvesPerCyl
        {
            get { return model_engine_valves_per_cyl; }
            set
            {
                model_engine_valves_per_cyl = value; NotifyPropertyChanged("ModelEngineValvesPerCyl");
            }
        }

        public int ModelEnginePowerPs
        {
            get { return model_engine_power_ps; }
            set
            {
                model_engine_power_ps = value; NotifyPropertyChanged("ModelEnginePowerPs");
            }
        }

        public string ModelEngineCompression
        {
            get { return model_engine_compression; }
            set
            {
                model_engine_compression = value; NotifyPropertyChanged("ModelEngineCompression");
            }
        }

        public string ModelEngineFuel
        {
            get { return model_engine_fuel; }
            set
            {
                model_engine_fuel = value; NotifyPropertyChanged("ModelEngineFuel");
            }
        }

        public int ModelTopSpeedKph
        {
            get { return model_top_speed_kph; }
            set
            {
                model_top_speed_kph = value; NotifyPropertyChanged("ModelTopSpeedKph");
            }
        }

        public float Model0To100Kph
        {
            get { return model_0_to_100_kph; }
            set { model_0_to_100_kph = value; NotifyPropertyChanged("Model0To100Kph"); }
        }

        public string ModelTransmissionType
        {
            get { return model_transmission_type; }
            set
            {
                model_transmission_type = value; NotifyPropertyChanged("ModelTransmissionType");
            }
        }

        public int ModelWeightKg
        {
            get { return model_weight_kg; }
            set
            {
                model_weight_kg = value; NotifyPropertyChanged("ModelWeightKg");
            }
        }

        public void Update(CarKey key, Car car)
        {
            ModelId = key.ModelId;
            ModelMakeId = key.ModelMakeId;
            ModelYear = key.ModelYear;
            ModelName = key.ModelName;
            ModelBody = car.ModelBody;
            ModelEngineCc = car.ModelEngineCc;
            ModelEngineCyl = car.ModelEngineCyl;
            ModelEngineType = car.ModelEngineType;
            ModelEngineValvesPerCyl = car.ModelEngineValvesPerCyl;
            ModelEnginePowerPs = car.ModelEnginePowerPs;
            ModelEngineCompression = car.ModelEngineCompression;
            ModelEngineFuel = car.ModelEngineFuel;
            ModelTopSpeedKph = car.ModelTopSpeedKph;
            Model0To100Kph = car.Model0To100Kph;
            ModelTransmissionType = car.ModelTransmissionType;
            ModelWeightKg = car.ModelWeightKg;
        }
    }
}
