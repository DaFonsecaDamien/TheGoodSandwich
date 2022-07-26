namespace Models;

public class Sandwich
{
    public String Name { get;}
    public Dictionary<Ingredients, float> Ingredients { get;}
    public float Price { get;}
    public bool Error { get;}
    public String ErrorMessage { get;}

    public Sandwich(string name, Dictionary<Ingredients, float> ingredients, float price, bool error, String errorMessage)
    {
        Name = name;
        Ingredients = ingredients;
        Price = price;
        Error = error;
        ErrorMessage = errorMessage;
    }

    public override string ToString()
    {
        // string toString = "Name : " + Name + "\n";
        String toString = "";
        foreach (var ingredient in Ingredients)
        {
            if (ingredient.Key.IsWeigth)
            {
                toString += ("   " + ingredient.Key.Name + " : " + ingredient.Value + "gr \n");
            }
            else
            {
                toString += ("   " + ingredient.Key.Name + " : " + ingredient.Value + "\n");
            }
        }

        return toString;
    }
}