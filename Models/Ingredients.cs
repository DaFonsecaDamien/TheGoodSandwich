namespace Models;

public class Ingredients
{
    public String Name { get;}
    public Boolean IsWeigth { get;}

    public Ingredients(string name, bool isWeigth)
    {
        Name = name;
        IsWeigth = isWeigth;
    }
}