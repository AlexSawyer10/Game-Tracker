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

    public string AreYouAnEmployeeOrViewer()
    {
        bool inputValidationBool = true;
       

        while (inputValidationBool)
        {
            Console.WriteLine("Are you an employee or viewer? -> ");
        
            string employeeOrViewerInput = Console.ReadLine()!;
            
            switch (employeeOrViewerInput.ToLower())
            {
                case "employee":
                    return "employee";
                case "viewer":
                    return "viewer";
                default:
                    Console.WriteLine("Please enter a valid input!");
                    inputValidationBool = true;
                    break;
                
            }
        }

        return null!; // all the ! does is tell the compiler that it cant return null to matter what. Just put it to make the warning go away.
    }

    public string DoYouHaveAnAccountMessage()
    {
        bool inputValidationBool = true;
        while (inputValidationBool)
        {
            Console.WriteLine("Do you already have an account? -> ");
            
            string doYouHaveAnAccountInput = Console.ReadLine()!;

            switch (doYouHaveAnAccountInput.ToLower())
            {
                case "yes":
                    return "yes";
                case "no":
                    return "no";
                default:
                    Console.WriteLine("Please enter a valid input!");
                    break;
            }
        }

        return null!;
    }
    
    
}