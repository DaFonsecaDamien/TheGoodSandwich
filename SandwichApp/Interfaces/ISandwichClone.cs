using Models;

namespace SandwichApp.Interfaces;

public interface ISandwichClone
{
    public Sandwich CloneSandwich(Sandwich sandwich);
}