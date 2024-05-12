using System;

//delegate có kiểu là void và nó không có tham số
delegate void MyDelegate(string message);

class Program
{
    static void Main(string[] args)
    {
        // crt phương thức TestMethod và truyền delegate làm tham số
        TestMethod(PrintMessage);
    }

    // nhận một delegate làm tham số
    static void TestMethod(MyDelegate del)
    {
        // gọi ra delegate và truyền vào đoạn tin
        del("Hello from TestMethod!");
    }


    static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}
