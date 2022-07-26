// See https://aka.ms/new-console-template for more information

using SandwichApp;

namespace SandwichApp
{
    class Program
    {
        static void Main(string[] args)
        { 
            String input = "A Jambon Beurre, B Dieppois, C Dieppois";
            Machina machina = new Machina(new InputParser(), new InvoicePrinter());
            CLI cli = new CLI(machina);
            cli.Launch();
        }
    }
}