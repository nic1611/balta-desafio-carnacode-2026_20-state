public interface IOrderState
{
    void ProcessPayment();
    void Ship(string trackingCode);
    void Deliver();
    void Cancel();
    void Return();
}
