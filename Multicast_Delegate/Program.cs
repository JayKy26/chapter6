using System;


delegate void MyDelegate(string message);

class Program
{
    static void Main(string[] args)
    {
        // create multicast delegate and add các method vào danh sách
        MyDelegate multicastDelegate = Method1;
        multicastDelegate += Method2;
        multicastDelegate += Method3;

        // gọi multicast delegate khi đó các phương thức sẽ được gọi theo thứ tự
        multicastDelegate("Hello from Multicast Delegate!");
    }

    static void Method1(string message)
    {
        Console.WriteLine("Method1: " + message);
    }

    static void Method2(string message)
    {
        Console.WriteLine("Method2: " + message);
    }

    static void Method3(string message)
    {
        Console.WriteLine("Method3: " + message);
    }
}
