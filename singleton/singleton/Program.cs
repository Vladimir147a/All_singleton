namespace singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var singleton1 = Singleton.Singleton.Instance;
            singleton1.DoSomething();

            var singleton2 = Singleton.Singleton.Instance;
            singleton2.DoSomething();

            Console.WriteLine("проверяем: " + (singleton1 == singleton2));

            Console.ReadLine();
        }
    }
}
