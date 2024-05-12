using System;

// Khai báo Sự kiện
class EventPublisher
{
    // Định nghĩa Delegate Xử lý Sự kiện
    public delegate void CustomEventHandler(object sender, CustomEventArgs e);

    // Khai báo Sự kiện
    public event CustomEventHandler CustomEvent;

    // Kích hoạt Sự kiện
    public void RaiseEvent(string message)
    {
        // Kiểm tra xem có bất kỳ người đăng ký nào không
        if (CustomEvent != null)
        {
            // Kích hoạt sự kiện bằng cách gọi tất cả các người đăng ký
            CustomEvent(this, new CustomEventArgs(message));
        }
    }
}

// Định nghĩa Đối số của Sự kiện
class CustomEventArgs : EventArgs
{
    public string Message { get; }

    public CustomEventArgs(string message)
    {
        Message = message;
    }
}

class Program
{
    static void Main(string[] args)
    {
        EventPublisher publisher = new EventPublisher();

        // Đăng ký để nhận Sự kiện
        publisher.CustomEvent += HandleCustomEvent;

        // Kích hoạt Sự kiện
        publisher.RaiseEvent("Hello from EventPublisher!");
    }

    // Phương thức Xử lý Sự kiện
    static void HandleCustomEvent(object sender, CustomEventArgs e)
    {
        Console.WriteLine("Received message: " + e.Message);
    }
}
