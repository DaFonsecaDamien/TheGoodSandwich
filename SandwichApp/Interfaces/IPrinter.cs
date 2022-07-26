namespace SandwichApp.Interfaces;

public interface IPrinter
{
    void PrintInvoice(Order order);
    void PrintReceipt(Order order, string paymentMethod);
}