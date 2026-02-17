
public class Order
{
    public string OrderId { get; set; }
    public decimal TotalAmount { get; set; }
    public string TrackingCode { get; set; }
    public DateTime? ShippedDate { get; set; }
    public DateTime? DeliveredDate { get; set; }
    public DateTime? ReturnedDate { get; set; }

    public IOrderState State { get; private set; }

    public Order(string orderId, decimal totalAmount)
    {
        OrderId = orderId;
        TotalAmount = totalAmount;
        State = new PendingState(this);
    }

    public void SetState(IOrderState state)
    {
        State = state;
    }

    public void ProcessPayment()
    {
        State.ProcessPayment();
    }

    public void Ship(string trackingCode)
    {
        State.Ship(trackingCode);
    }

    public void Deliver()
    {
        State.Deliver();
    }

    public void Cancel()
    {
        State.Cancel();
    }

    public void Return()
    {
        State.Return();
    }
}