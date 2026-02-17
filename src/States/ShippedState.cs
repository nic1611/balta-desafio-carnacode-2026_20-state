
public class ShippedState : IOrderState
{
    private readonly Order _order;

    public ShippedState(Order order)
    {
        _order = order;
    }

    public void ProcessPayment()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Não é possível processar pagamento. Pedido já foi enviado.");
    }

    public void Ship(string trackingCode)
    {
        Console.WriteLine($"\n[{_order.OrderId}] Pedido já foi enviado. Código: {_order.TrackingCode}");
    }

    public void Deliver()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Entregando pedido...");
        _order.SetState(new DeliveredState(_order));
        _order.DeliveredDate = DateTime.Now;
        Console.WriteLine($"✅ Pedido entregue em {_order.DeliveredDate:dd/MM/yyyy HH:mm}");
    }

    public void Cancel()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Cancelando pedido e processando reembolso...");
        _order.SetState(new CancelledState(_order));
        Console.WriteLine($"✅ Pedido cancelado. Reembolso de R$ {_order.TotalAmount:N2} será processado.");
    }

    public void Return()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Não é possível devolver pedido não entregue.");
    }
}
