using Models;

namespace SandwichApp.Builder;

public class SandwichBuilder
{
    private String Name;
    private Dictionary<Ingredients, float> Ingredients;
    private float Price;
    private bool Error;
    private String ErrorMessage;
    
    public SandwichBuilder()
    {
    }
    
    public SandwichBuilder WithName(String name)
    {
        this.Name = name;
        return this;
    }
    
    public SandwichBuilder WithIngredients(Dictionary<Ingredients, float> ingredients)
    {
        this.Ingredients = ingredients;
        return this;
    }
    
    public SandwichBuilder WithPrice(float price)
    {
        this.Price = price;
        return this;
    }
    
    public SandwichBuilder WithError(bool error)
    {
        this.Error = error;
        return this;
    }
    
    public SandwichBuilder WithErrorMessage(String errorMessage)
    {
        this.ErrorMessage = errorMessage;
        return this;
    }
    
    public Sandwich Build()
    {
        return new Sandwich(this.Name, this.Ingredients, this.Price, this.Error, this.ErrorMessage);
    }
}