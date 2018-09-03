class Program
{
    static void Main(string[] args)
    {
        // путешественник
        Driver driver = new Driver();
        // машина
        Auto auto = new Auto();
        // отправляемся в путешествие
        driver.Travel(auto);
        // встретились пески, надо использовать верблюда
        Camel camel = new Camel();
        // используем адаптер
        ITransport camelTransport = new CamelToTransportAdapter(camel);
        // продолжаем путь по пескам пустыни
        driver.Travel(camelTransport);
    }
}
interface ITransport
{
    void Drive();
}

class Auto : ITransport
{
    public void Drive()
    {
        //Console.WriteLine("Машина едет по дороге");
    }
}
class Driver
{
    public void Travel(ITransport transport)
    {
        transport.Drive();
    }
}

interface IAnimal
{
    void Move();
}

class Camel : IAnimal
{
    public void Move()
    {
        //Console.WriteLine("Верблюд идет по пескам пустыни");
    }
}

class CamelToTransportAdapter : ITransport
{
    Camel camel;
    public CamelToTransportAdapter(Camel c)
    {
        camel = c;
    }

    public void Drive()
    {
        camel.Move();
    }
}