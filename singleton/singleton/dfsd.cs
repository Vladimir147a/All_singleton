using System;

public class Singleton
{
    private static Singleton _instance;
    private static readonly object _lock = new object();
    public string Value { get; private set; }
    private Singleton(string value)
    {
        Value = value;
    }
    public static Singleton GetInstance(string value)
    {
        if (_instance == null)
        {
            lock (_lock) 
            {
                if (_instance == null)
                {
                    _instance = new Singleton(value);
                }
            }
        }
        return _instance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Singleton s1 = Singleton.GetInstance("1");
        Singleton s2 = Singleton.GetInstance("2");

        Console.WriteLine(s1.Value);  
        Console.WriteLine(s2.Value);  

        Console.WriteLine(ReferenceEquals(s1, s2));  
    }
}