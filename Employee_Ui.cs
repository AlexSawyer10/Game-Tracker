using System.Text.RegularExpressions;

namespace Game_Tracking;

public class Employee_Ui
{
    public User_Info EmployeeCreateAccount(User_Info user_Info)
    {
        Console.WriteLine("Lets start by making an account!");
        
        Console.WriteLine("Enter your desired username: ");

        string user_username = Console.ReadLine()!;
        
        
        user_Info.username = user_username;
        
        bool passwordValidationLoop = true;

        bool haveUpperCharacterCheck = true;
        
        while (passwordValidationLoop)
        {
            string user_password = string.Empty;
            
            while (haveUpperCharacterCheck)
            {
                haveUpperCharacterCheck = true;

                Console.WriteLine("Your password must have at-least one upper case letter, at-least one number, and at-least 6 characters long.");

                Console.WriteLine("Enter your desired password: ");

                 user_password = Console.ReadLine()!;


                if (user_password.Length > 6)
                {
                    Console.WriteLine("Your password must be at least 6 characters long.");
                }

                else if (!user_password.Any(char.IsDigit))
                {
                    Console.WriteLine("Your password must contain at least one number.");
                }

                else if (user_password.Any(char.IsUpper))
                {
                    haveUpperCharacterCheck = false;
                }

                else
                {
                    passwordValidationLoop = true;
                }
            }

            user_Info.password = user_password;

        }
        
        return user_Info;
        
    } //test validation loop for later

    public void EmployeeWelcomeScreen(Employee_Info employee_Info)
    {
        Console.WriteLine($"Welcome {employee_Info.username}!");
        Console.WriteLine($"Your current job title is: {employee_Info.GetEmployeeJobTitle()}");
        
    }
   
    public void ChoiceScreen(Team_Info team_Info)
    {
        bool choice_screen_validation = true;
     
        while (choice_screen_validation)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. View existing standings");
            Console.WriteLine("2. Modify existing standings");
            Console.WriteLine("3. Add a new team");
            Console.WriteLine("4. Delete existing team");
            Console.WriteLine("5. Exit");
            
            string employee_choice = Console.ReadLine()!;
            
            switch (employee_choice)
            {
                case "1":
                    ViewStandings();
                    break;
                case "2":
                    ModifyTeam(team_Info);
                    break;
                case "3":
                    AddTeam(team_Info);
                    break;
                case "4":
                    DeleteTeam(team_Info);
                    break;
                case "5":
                    choice_screen_validation = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
                    
            }
        }
      
    }

    public void ViewStandings()
    {
        Team_Info team_Info = new Team_Info();
    }

    public Team_Info ModifyTeam(Team_Info team_Info)
    {
        bool team_validation = true;
        while (team_validation)
        { 
            Console.WriteLine("Please use this format 0-0-0 (Win, loss, Tie)");
            Console.WriteLine("Enter the teams records: ");
            string input  = Console.ReadLine()!.Trim();
            string pattern = @"^\d{1,3}-\d{1,3}-\d{1,3}$";
            
            bool hasNoLetters = Regex.IsMatch(input, pattern);
        
            if (hasNoLetters)
            {
                Console.WriteLine("Valid input");
                team_validation = false;
            }

            if (!hasNoLetters)
            {
                Console.WriteLine("Invalid input.");
            }
        
        }
        
        return team_Info;
    }
    
   /* public Team_Info ModifyTeam(Team_Info team_Info)
    {
        bool ModifyTeam_validation = true;

        string team_record = string.Empty;
        
        while (ModifyTeam_validation)
        {

            Console.WriteLine("Please use this format 0-0-0 (Win, loss, Tie)");
            Console.WriteLine(
                "Enter the teams records: "); //loop through until hit each dash .AnyLetter, check after dashes, // string input = "1234!@#"; // string pattern = @"^[^a-zA-Z]*$";
            // // 
            // // bool hasNoLetters = Regex.IsMatch(input, pattern)
            team_record = Console.ReadLine()!.Trim();

            if (team_record.Any(char.IsLetter))
            {
                Console.WriteLine("Invalid team record format! Please try again.");
                continue;
            }

            string[] checkSplit = team_record.Split("-");

            if (checkSplit.Length != 3)
            {
                Console.WriteLine("Invalid team format! Either too many dashes or a number is negative.");
                break;
            }

            bool allValid = true;
            foreach (string validNumber in checkSplit)
            {
                if (!int.TryParse(validNumber, out int valid_number) || valid_number < 0)
                {
                    Console.WriteLine("Invalid team record format! You cannot have any negative numbers!");
                    allValid = false;
                    break;
                }
            }

            if (allValid)
            {
                ModifyTeam_validation = false; 
            }
            
            
        }
        Console.WriteLine("Valid team check!");
        
        team_Info.Team_Record = team_record;
        
        return team_Info;
    }
    */

    public Team_Info AddTeam(Team_Info team_Info)
    {
        Console.WriteLine("Enter the team's name: ");
        string team_name = Console.ReadLine()!;
        team_Info.Team_Name = team_name;
        Console.WriteLine("Enter the team's description: ");
        string team_description = Console.ReadLine()!;
        team_Info.Team_Description = team_description;
        Console.WriteLine("Enter the team's primary color worn: ");
        string team_primaryColor = Console.ReadLine()!;
        team_Info.Team_Primary_Color = team_primaryColor;
        Console.WriteLine("Enter the team's secondary color worn: ");
        string team_secondaryColor = Console.ReadLine()!;
        team_Info.Team_Secondary_Color = team_secondaryColor;
        
        return team_Info;
    }

    public Team_Info DeleteTeam(Team_Info team_Info)
    {
       Console.WriteLine("Enter the team's name you would like to delete: "); 
       Console.WriteLine(team_Info.Team_Name);
       return team_Info;
       
       //fix later
    }
    
}