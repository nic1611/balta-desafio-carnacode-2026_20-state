
public class ReturnedState : IOrderState
{
    private readonly Order _order;

    public ReturnedState(Order order)
    {
        _order = order;
    }

    public void ProcessPayment()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Não é possível processar pagamento. Pedido foi devolvido.");
    }

    public void Ship(string trackingCode)
    {
        Console.WriteLine($"\n[{_order.OrderId}] Não é possível enviar pedido devolvido.");
    }

    public void Deliver()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Não é possível entregar pedido devolvido.");
    }

    public void Cancel()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Não é possível cancelar pedido devolvido.");
    }

    public void Return()
    {
        Console.WriteLine($"\n[{_order.OrderId}] Pedido já foi devolvido em {_order.ReturnedDate:dd/MM/yyyy HH:mm}.");
    }
}
