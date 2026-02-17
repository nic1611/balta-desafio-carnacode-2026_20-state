
public class CancelledState : IOrderState
{
    private readonly Order _order;

    public CancelledState(Order order)
    {
        _order = order;
    }

    public void ProcessPayment()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Não é possível processar pagamento. Pedido foi cancelado.");
    }

    public void Ship(string trackingCode)
    {
        Console.WriteLine($"\n[{_order.OrderId}] Não é possível enviar pedido cancelado.");
    }

    public void Deliver()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Não é possível entregar pedido cancelado.");
    }

    public void Cancel()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Pedido já foi cancelado.");
    }

    public void Return()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Não é possível devolver pedido cancelado.");
    }
}
