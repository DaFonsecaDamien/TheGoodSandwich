namespace SandwichApp.Interfaces;

public interface IParser
{
    Order ParseInput(string input);
}