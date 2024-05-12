using System;

public delegate void MyDele(int value);
// sử dụng thêm biến số vào delegate

class Program
{
    static int globalValue = 100; 

    static void Main(string[] args)
    {
        MyDele printValue = delegate (int val)
        {
            Console.WriteLine("Đây là số. Value: {0}", val);
            // sẽ in ra delegate và có biến số vla lalf 100
        };

        printValue += delegate
        {
            
            Console.WriteLine("Không có. Value: {0}", globalValue);
            // in ra biến số 200
        };

        printValue(200);
    }
}
