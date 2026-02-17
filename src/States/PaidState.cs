
public class PaidState : IOrderState
{
    private readonly Order _order;

    public PaidState(Order order)
    {
        _order = order;
    }

    public void ProcessPayment()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Pedido já foi pago.");
    }

    public void Ship(string trackingCode)
    {
        Console.WriteLine($"\n[{_order.OrderId}] Enviando pedido...");
        _order.SetState(new ShippedState(_order));
        _order.TrackingCode = trackingCode;
        _order.ShippedDate = DateTime.Now;
        Console.WriteLine($"✅ Pedido enviado! Código: {trackingCode}");
    }

    public void Deliver()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Não é possível entregar pedido não enviado.");
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
