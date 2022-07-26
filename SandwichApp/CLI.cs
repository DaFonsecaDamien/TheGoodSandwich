using Models;

namespace SandwichApp;

public class CLI
{
    private Machina _machina;

    public CLI(Machina machina)
    {
        _machina = machina;
    }
    public void Launch()
    {
        // improve this
        Console.WriteLine("/////////////////");
        Console.WriteLine("/// BIENVENUE ///");
        Console.WriteLine("/////////////////");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("- Appuyer sur 1 pour lancer TheGoodMachina ");
        Console.WriteLine("- Appuyer sur 2 pour quitter :/ ");

        var answer = Console.ReadLine();
        answer = (String)answer;
        if (answer.Equals("1"))
        {
            LaunchMachina();
        }
        return;
    }

    public void LaunchMachina()
    {
        ResponseCode? run = null;
        while (run != ResponseCode.ErrorFatal && run != ResponseCode.Quit)
        {
            run = Home();
        }
    }

    public ResponseCode Home()
    {
        Console.WriteLine("Saisissez une commande ou 'Q()' pour quitter");
        var answer = Console.ReadLine();
        answer = (String)answer!;
        if (!answer!.Equals("Q()"))
        {
            return _machina.ProcessCommand(answer);
        }
        return ResponseCode.Quit;
    }
    
}