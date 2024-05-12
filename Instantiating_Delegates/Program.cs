using System;

// Định nghĩa một delegate có kiểu void và không có tham số
delegate void MyDelegate();

class Program
{
    static void Main(string[] args)
    {
        // tạo delegate và trỏ nó tới phương thức Method1
        MyDelegate delegateInstance = new MyDelegate(Method1);

        // Gọi delegate same như gọi Method1
        delegateInstance();
    }

    static void Method1()
    {
        Console.WriteLine("This is Method1.");
    }
}

