using Hazelcast.IO.Serialization;

namespace HazelCarNet
{
    public class Car : IPortable
    {
        public const int Id = 5;

        private string model_body;
        private string model_engine_position;
        private int model_engine_cc;
        private int model_engine_cyl;
        private string model_engine_type;

        private int model_engine_valves_per_cyl;
        private int model_engine_power_ps;
        private int model_engine_power_rpm;
        private int model_engine_torque_nm;
        private int model_engine_torque_rpm;
        private int model_engine_bore_mm;
        private int model_engine_stroke_mm;
        private string model_engine_compression;
        private string model_engine_fuel;

        private int model_top_speed_kph;
        private float model_0_to_100_kph;
        private string model_drive;
        private string model_transmission_type;
        private int model_seats;
        private int model_doors;
        private int model_weight_kg;
        private int model_length_mm;
        private int model_height_mm;
        private int model_width_mm;
        private int model_wheelbase_mm;

        private float model_lkm_hwy;
        private float model_lkm_mixed;
        private float model_lkm_city;
        private int model_fuel_cap_l;
        private bool model_sold_in_us;
        private float model_co2;
        private string model_make_display;
        private string make_display;
        private string make_country;

        public Car() { }

        public Car(string modelBody, int modelEngineCc, int modelEngineCyl, string modelEngineType, 
            int modelEngineValvesPerCyl, int modelEnginePowerPs, string modelEngineCompression, 
            string modelEngineFuel, int modelTopSpeedKph, float model0To100Kph, string modelTransmissionType, int modelWeightKg)
        {
            model_body = modelBody;
            model_engine_cc = modelEngineCc;
            model_engine_cyl = modelEngineCyl;
            model_engine_type = modelEngineType;
            model_engine_valves_per_cyl = modelEngineValvesPerCyl;
            model_engine_power_ps = modelEnginePowerPs;
            model_engine_compression = modelEngineCompression;
            model_engine_fuel = modelEngineFuel;
            model_top_speed_kph = modelTopSpeedKph;
            model_0_to_100_kph = model0To100Kph;
            model_transmission_type = modelTransmissionType;
            model_weight_kg = modelWeightKg;
        }

        public string MakeCountry
        {
            get { return make_country; }
            set { make_country = value; }
        }

        public string MakeDisplay
        {
            get { return make_display; }
            set { make_display = value; }
        }

        public float Model0To100Kph
        {
            get { return model_0_to_100_kph; }
            set { model_0_to_100_kph = value; }
        }

        public string ModelBody
        {
            get { return model_body; }
            set { model_body = value; }
        }

        public float ModelCo2
        {
            get { return model_co2; }
            set { model_co2 = value; }
        }

        public int ModelDoors
        {
            get { return model_doors; }
            set { model_doors = value; }
        }

        public string ModelDrive
        {
            get { return model_drive; }
            set { model_drive = value; }
        }

        public int ModelEngineBoreMm
        {
            get { return model_engine_bore_mm; }
            set { model_engine_bore_mm = value; }
        }

        public int ModelEngineCc
        {
            get { return model_engine_cc; }
            set { model_engine_cc = value; }
        }

        public string ModelEngineCompression
        {
            get { return model_engine_compression; }
            set { model_engine_compression = value; }
        }

        public int ModelEngineCyl
        {
            get { return model_engine_cyl; }
            set { model_engine_cyl = value; }
        }

        public string ModelEngineFuel
        {
            get { return model_engine_fuel; }
            set { model_engine_fuel = value; }
        }

        public string ModelEnginePosition
        {
            get { return model_engine_position; }
            set { model_engine_position = value; }
        }

        public int ModelEnginePowerPs
        {
            get { return model_engine_power_ps; }
            set { model_engine_power_ps = value; }
        }

        public int ModelEnginePowerRpm
        {
            get { return model_engine_power_rpm; }
            set { model_engine_power_rpm = value; }
        }

        public int ModelEngineStrokeMm
        {
            get { return model_engine_stroke_mm; }
            set { model_engine_stroke_mm = value; }
        }

        public int ModelEngineTorqueNm
        {
            get { return model_engine_torque_nm; }
            set { model_engine_torque_nm = value; }
        }

        public int ModelEngineTorqueRpm
        {
            get { return model_engine_torque_rpm; }
            set { model_engine_torque_rpm = value; }
        }

        public string ModelEngineType
        {
            get { return model_engine_type; }
            set { model_engine_type = value; }
        }

        public int ModelEngineValvesPerCyl
        {
            get { return model_engine_valves_per_cyl; }
            set { model_engine_valves_per_cyl = value; }
        }

        public int ModelFuelCapL
        {
            get { return model_fuel_cap_l; }
            set { model_fuel_cap_l = value; }
        }

        public int ModelHeightMm
        {
            get { return model_height_mm; }
            set { model_height_mm = value; }
        }

        public int ModelLengthMm
        {
            get { return model_length_mm; }
            set { model_length_mm = value; }
        }

        public float ModelLkmCity
        {
            get { return model_lkm_city; }
            set { model_lkm_city = value; }
        }

        public float ModelLkmHwy
        {
            get { return model_lkm_hwy; }
            set { model_lkm_hwy = value; }
        }

        public float ModelLkmMixed
        {
            get { return model_lkm_mixed; }
            set { model_lkm_mixed = value; }
        }

        public string ModelMakeDisplay
        {
            get { return model_make_display; }
            set { model_make_display = value; }
        }

        public int ModelSeats
        {
            get { return model_seats; }
            set { model_seats = value; }
        }

        public bool ModelSoldInUs
        {
            get { return model_sold_in_us; }
            set { model_sold_in_us = value; }
        }

        public int ModelTopSpeedKph
        {
            get { return model_top_speed_kph; }
            set { model_top_speed_kph = value; }
        }

        public string ModelTransmissionType
        {
            get { return model_transmission_type; }
            set { model_transmission_type = value; }
        }

        public int ModelWeightKg
        {
            get { return model_weight_kg; }
            set { model_weight_kg = value; }
        }

        public int ModelWheelbaseMm
        {
            get { return model_wheelbase_mm; }
            set { model_wheelbase_mm = value; }
        }

        public int ModelWidthMm
        {
            get { return model_width_mm; }
            set { model_width_mm = value; }
        }

        public int GetFactoryId()
        {
            return PortableFactory.FactoryId;
        }

        public int GetClassId()
        {
            return Id;
        }

        public void WritePortable(IPortableWriter writer)
        {
            writer.WriteUTF("f0", model_body);
            writer.WriteUTF("f1", model_engine_position);
            writer.WriteInt("f2", model_engine_cc);
            writer.WriteInt("f3", model_engine_cyl);
            writer.WriteUTF("f4", model_engine_type);

            writer.WriteInt("f5", model_engine_valves_per_cyl);
            writer.WriteInt("f6", model_engine_power_ps);
            writer.WriteInt("f7", model_engine_power_rpm);
            writer.WriteInt("f8", model_engine_torque_nm);
            writer.WriteInt("f9", model_engine_torque_rpm);
            writer.WriteInt("f10", model_engine_bore_mm);
            writer.WriteInt("f11", model_engine_stroke_mm);
            writer.WriteUTF("f12", model_engine_compression);
            writer.WriteUTF("f13", model_engine_fuel);

            writer.WriteInt("f14", model_top_speed_kph);
            writer.WriteFloat("f15", model_0_to_100_kph);
            writer.WriteUTF("f16", model_drive);
            writer.WriteUTF("f17", model_transmission_type);
            writer.WriteInt("f18", model_seats);
            writer.WriteInt("f19", model_doors);
            writer.WriteInt("f20", model_weight_kg);
            writer.WriteInt("f21", model_length_mm);
            writer.WriteInt("f22", model_height_mm);
            writer.WriteInt("f23", model_width_mm);
            writer.WriteInt("f24", model_wheelbase_mm);

            writer.WriteFloat("f25", model_lkm_hwy);
            writer.WriteFloat("f26", model_lkm_mixed);
            writer.WriteFloat("f27", model_lkm_city);
            writer.WriteInt("f28", model_fuel_cap_l);
            writer.WriteBoolean("f29", model_sold_in_us);
            writer.WriteFloat("f30", model_co2);
            writer.WriteUTF("f31", model_make_display);
            writer.WriteUTF("f32", make_display);
            writer.WriteUTF("f33", make_country);
        }

        public void ReadPortable(IPortableReader reader)
        {
            model_body = reader.ReadUTF("f0");
            model_engine_position = reader.ReadUTF("f1");
            model_engine_cc = reader.ReadInt("f2");
            model_engine_cyl = reader.ReadInt("f3");
            model_engine_type = reader.ReadUTF("f4");

            model_engine_valves_per_cyl = reader.ReadInt("f5");
            model_engine_power_ps = reader.ReadInt("f6");
            model_engine_power_rpm = reader.ReadInt("f7");
            model_engine_torque_nm = reader.ReadInt("f8");
            model_engine_torque_rpm = reader.ReadInt("f9");
            model_engine_bore_mm = reader.ReadInt("f10");
            model_engine_stroke_mm = reader.ReadInt("f11");
            model_engine_compression = reader.ReadUTF("f12");
            model_engine_fuel = reader.ReadUTF("f13");

            model_top_speed_kph = reader.ReadInt("f14");
            model_0_to_100_kph = reader.ReadFloat("f15");
            model_drive = reader.ReadUTF("f16");
            model_transmission_type = reader.ReadUTF("f17");
            model_seats = reader.ReadInt("f18");
            model_doors = reader.ReadInt("f19");
            model_weight_kg = reader.ReadInt("f20");
            model_length_mm = reader.ReadInt("f21");
            model_height_mm = reader.ReadInt("f22");
            model_width_mm = reader.ReadInt("f23");
            model_wheelbase_mm = reader.ReadInt("f24");

            model_lkm_hwy = reader.ReadFloat("f25");
            model_lkm_mixed = reader.ReadFloat("f26");
            model_lkm_city = reader.ReadFloat("f27");
            model_fuel_cap_l = reader.ReadInt("f28");
            model_sold_in_us = reader.ReadBoolean("f29");
            model_co2 = reader.ReadFloat("f30");
            model_make_display = reader.ReadUTF("f31");
            make_display = reader.ReadUTF("f32");
            make_country = reader.ReadUTF("f33");
        }
    }
}
