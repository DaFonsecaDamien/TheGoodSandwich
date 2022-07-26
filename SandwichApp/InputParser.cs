using Models;

namespace SandwichApp;

public class InputParser
{
    public Order ParseInput(String input)
    {
        Order order = new Order(true, null);
        String[] inputSplit;
        
        inputSplit = input.Split(',');

        order.Sandwiches = _ConvertInputToOrder(inputSplit);
        if (order.Sandwiches == null)
        {
            order.IsCompliant = false;
        }

        return order; 
    }

    private List<(Sandwich, short)>? _ConvertInputToOrder(String[] order)
    {
        List<(Sandwich, short)>? sandwiches = new List<(Sandwich, short)>();
        Sandwich sandwich = null;
        
        for (int i = 0; i < order.Length; i++)
        {
            sandwich = _getSandwichFromOrderLine(order[i]);
            if ( sandwich.Error )
            {
                Console.WriteLine(sandwich.ErrorMessage);
                Console.WriteLine("Vérifiez la commande");
                return null; 
            }
            
            Console.WriteLine(sandwich.Name);
            
            int position = sandwiches.FindIndex(item => item.Item1.Name == sandwich.Name);
            if( position == -1)
            {
                sandwiches.Add((sandwich, 1));
            }
            else
            {
                var valueTuple = sandwiches[position];
                sandwiches[position] = (valueTuple.Item1, ++valueTuple.Item2);
            }
        }
        Console.WriteLine("ici : " + sandwiches);
        return sandwiches; 
    }

    private static Sandwich _getSandwichFromOrderLine(String line)
    {
        line = line.Trim(' ');
        
        String sandwichName = null;
        try
        {
            sandwichName = (line.Split(' ',2))[1];
        }
        catch (Exception e)
        {
            return new Sandwich("", new Dictionary<Ingredients, float>(), 5f,true,"Commande Mal Formatté !");
        }
        
        Console.WriteLine(sandwichName);
        
        foreach (var sandwich in Constantes.AvailableSandwiches)
        { 
            if (sandwich.Name == sandwichName)
            {
                return sandwich;
            }
        }
        return new Sandwich("", new Dictionary<Ingredients, float>(), 5f,true,"Le sandwich '" + sandwichName + "' pas Sur le Menu !");
    }
}