using Models;

namespace SandwichApp;

public class Order
{
    public List<(Sandwich, short)>? Sandwiches { get;  set; }
    public bool IsCompliant { get; set; }
    
    public Order(bool isCompliant, List<(Sandwich, short)>? sandwiches)
    {
        IsCompliant = isCompliant;
        Sandwiches = sandwiches;
    }

    public float CalulateTotal()
    {
        float total = 0; 
        foreach (var sandwich in Sandwiches!)
        {
            total += sandwich.Item1.Price * sandwich.Item2; 
        }
        return total; 
    }
}