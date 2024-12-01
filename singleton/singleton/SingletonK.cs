using System;
public class MySingleton
{
    private static MySingleton instance;

    private MySingleton()
    {
        // Приватный конструктор
    }

    public static MySingleton getInstance()
    {
        if (instance == null)
        {
            instance = new MySingleton();
        }
        return instance;
    }
}