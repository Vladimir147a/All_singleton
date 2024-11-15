using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Singleton.cs
namespace Singleton
{
    public class Singleton
    {
        // Статическое поле для хранения единственного экземпляра
        private static Singleton _instance;

        // Объект для синхронизации
        private static readonly object _lock = new object();

        // Приватный конструктор для предотвращения создания экземпляра извне
        private Singleton()
        {
            Console.WriteLine("создали Singleton.");
        }

        // Статическое свойство для получения экземпляра Singleton
        public static Singleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }

        // Пример метода, который можно вызвать у Singleton
        public void DoSomething()
        {
            Console.WriteLine("делаем что-то в Singleton");
        }
    }
}
