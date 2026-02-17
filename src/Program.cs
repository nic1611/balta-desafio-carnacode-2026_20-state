public static class Program
{
    public static void Main(string[] args)
    {
        var order = new Order("123", 100);
        order.ProcessPayment();
        order.ProcessPayment();
        order.Ship("123");
        order.Deliver();
        order.Cancel();
        order.Return();
    }
}