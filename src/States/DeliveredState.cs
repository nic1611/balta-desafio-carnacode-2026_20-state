
public class DeliveredState : IOrderState
{
    private readonly Order _order;

    public DeliveredState(Order order)
    {
        _order = order;
    }

    public void ProcessPayment()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Não é possível processar pagamento. Pedido já foi entregue.");
    }

    public void Ship(string trackingCode)
    {
        Console.WriteLine($"\n[{_order.OrderId}] Não é possível enviar pedido entregue.");
    }

    public void Deliver()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Pedido já foi entregue em {_order.DeliveredDate:dd/MM/yyyy HH:mm}.");
    }

    public void Cancel()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Não é possível cancelar pedido entregue.");
    }

    public void Return()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Iniciando devolução...");
        _order.SetState(new ReturnedState(_order));
        Console.WriteLine($"✅ Pedido movido para estado Devolvido.");
    }
}
