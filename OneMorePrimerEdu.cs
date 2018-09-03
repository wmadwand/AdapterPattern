using System;
namespace Adapter
{
    public class OneMorePrimerEdu
    {
        public OneMorePrimerEdu()
        {
        }
    }

    public interface ITransport
    {
        void Drive();
    }

    public class Car : ITransport
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }
    }

    public class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }

    public interface IAnimal
    {
        void Move();
    }

    public class Camel : IAnimal
    {
        public void Move()
        {
            throw new NotImplementedException();
        }
    }

    public class CamelToTransportAdapter : ITransport
    {
        private Camel _camel;

        public CamelToTransportAdapter(Camel camel)
        {
            _camel = camel;
        }

        public void Drive()
        {
            _camel.Move();
        }
    }

    public class Main
    {
        public void Start()
        {
            Driver driver = new Driver();
            Car car = new Car();

            driver.Travel(car);

            Camel camel = new Camel();
            ITransport camelTransport = new CamelToTransportAdapter(camel);

            driver.Travel(camelTransport);

        }
    }
}
