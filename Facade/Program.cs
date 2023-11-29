namespace Facade
{
    public class Client
    {
        public static void Main()
        {
            Facade _facade = new Facade(new DVD(), new TV(), new Audio());
            _facade.On();
            _facade.Off();
        }
    }
}

