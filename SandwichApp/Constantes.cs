using Models;

namespace SandwichApp;

public static class Constantes
{
    private static readonly Ingredients Bread = new Ingredients("Pain", false); 
    private static readonly Ingredients SliceOfHam = new Ingredients("Tranche de jambon", false); 
    private static readonly Ingredients Butter = new Ingredients("Beurre", true); 
    private static readonly Ingredients Egg = new Ingredients("Oeuf", false); 
    private static readonly Ingredients Tomato = new Ingredients("Tomate", false); 
    private static readonly Ingredients SliceOfChicken = new Ingredients("Tranche de poulet", false); 
    private static readonly Ingredients Mayonnaise = new Ingredients("Mayonnaise", true); 
    private static readonly Ingredients Salad = new Ingredients("Salade", true); 
    private static readonly Ingredients Tuna = new Ingredients("Thon", true); 
    
    private static readonly Dictionary<Ingredients, float> JambonBeurreRecipe = new Dictionary<Ingredients, float>()
    {
        { Bread, 1 }, 
        { SliceOfHam, 1},
        { Butter, 10f}
    };
    
    private static readonly Dictionary<Ingredients, float> PouletCruditesRecipe = new Dictionary<Ingredients, float>()
    {
        { Bread, 1 }, 
        { Egg, 1},
        { Tomato, 0.5f},
        { SliceOfChicken, 1f},
        { Mayonnaise, 10f},
        { Salad, 10f},
    };

    private static readonly Dictionary<Ingredients, float> DieppoisRecipe = new Dictionary<Ingredients, float>()
    {
        { Bread, 1f }, 
        { Tuna, 50f},
        { Tomato, 0.5f},
        { Mayonnaise, 10f},
        { Salad, 10f},
    };

    public static readonly Sandwich JambonBeurre = new Sandwich("Jambon Beurre", JambonBeurreRecipe, 3.5f, false, "");
    public static readonly Sandwich PouletCrudites = new Sandwich("Poulet Crudités", PouletCruditesRecipe, 5f, false, "");
    public static readonly Sandwich Dieppois = new Sandwich("Dieppois", DieppoisRecipe, 4.5f, false, "");
    
    public static readonly List<Sandwich> AvailableSandwiches = new List<Sandwich>()
    {
        JambonBeurre,
        PouletCrudites,
        Dieppois
    };
}