namespace SandwichApp;

public class InvoicePrinter
{
    public void PrintInvoice(Order order)
    {
        for (int i = 0; i < order.Sandwiches!.Count; i++)
        {
            Console.WriteLine(order.Sandwiches[i].Item1.Name + "            x" + order.Sandwiches[i].Item2 +"\n" + order.Sandwiches[i].Item1.ToString());
        }
        Console.WriteLine("Prix total : " + order.CalulateTotal() + "€");
    }
}