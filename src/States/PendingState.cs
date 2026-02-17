
public class PendingState : IOrderState
{
    private readonly Order _order;

    public PendingState(Order order)
    {
        _order = order;
    }

    public void ProcessPayment()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Processando pagamento...");
        _order.SetState(new PaidState(_order));
        Console.WriteLine($"✅ Pagamento confirmado! Total: R$ {_order.TotalAmount:N2}");
    }

    public void Ship(string trackingCode)
    {
        Console.WriteLine($"\n[{_order.OrderId}] Não é possível enviar pedido não pago.");
    }

    public void Deliver()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Não é possível entregar pedido não enviado.");
    }

    public void Cancel()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Cancelando pedido...");
        _order.SetState(new CancelledState(_order));
        Console.WriteLine($"✅ Pedido cancelado. Nenhuma cobrança realizada.");
    }

    public void Return()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Não é possível devolver pedido não entregue.");
    }
}
