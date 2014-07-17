using Hazelcast.IO.Serialization;

namespace HazelCarNet
{
    class PortableFactory : IPortableFactory
    {
        public const int FactoryId = 1;

        public IPortable Create(int classId)
        {
            if (Car.Id == classId)
            {
                return new Car();
            }
            if (CarKey.Id == classId)
            {
                return new CarKey();
            }
            return null;
        }
    }
}
