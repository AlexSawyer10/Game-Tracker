namespace Game_Tracking;

public class General_Messages
{
    // All probably excessive being in different methods but whatever lol
    
    public void WelcomeMessage()
    {
        Console.WriteLine("Welcome to Alex's game tracker!");
    }

    public void DescribeProgramMessage()
    {
        Console.WriteLine("In this program, you can create and track teams for your soccer league!");
    }

    public void PressAnyKeyToContinue()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}