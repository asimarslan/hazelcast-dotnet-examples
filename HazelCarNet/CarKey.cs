using System;
using Hazelcast.IO.Serialization;

namespace HazelCarNet
{
    public class CarKey : IPortable
    {
        public const int Id = 6;

        public CarKey() { }

        private  long model_id;
        private  string model_make_id;
        private  string model_trim;
        private  int model_year;
        private string model_name;

        public CarKey(long model_id, string model_make_id, string model_name, string model_trim, int model_year)
        {
            this.model_id = model_id;
            this.model_make_id = model_make_id;
            this.model_name = model_name;
            this.model_trim = model_trim;
            this.model_year = model_year;
        }

        public long ModelId
        {
            get { return model_id; }
            set { model_id = value; }
        }

        public string ModelMakeId
        {
            get { return model_make_id; }
            set { model_make_id = value; }
        }

        public string ModelName
        {
            get { return model_name; }
            set { model_name = value; }
        }

        public string ModelTrim
        {
            get { return model_trim; }
            set { model_trim = value; }
        }

        public int ModelYear
        {
            get { return model_year; }
            set { model_year = value; }
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
            writer.WriteLong("mi", model_id);
            writer.WriteUTF("mm", model_make_id);
            writer.WriteUTF("mt", model_trim);
            writer.WriteInt("my", model_year);
            writer.WriteUTF("mn", model_name);
        }

        public void ReadPortable(IPortableReader reader)
        {
            model_id = reader.ReadLong("mi");
            model_make_id = reader.ReadUTF("mm");
            model_trim = reader.ReadUTF("mt");
            model_year = reader.ReadInt("my");
            model_name = reader.ReadUTF("mn");
        }

        public override string ToString()
        {
            return model_id + "/" + model_name;
        }
    }
}
