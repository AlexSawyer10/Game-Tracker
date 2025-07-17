namespace Game_Tracking;

public class Employee_Ui
{
    public User_Info EmployeeCreateAccount(User_Info user_Info)
    {
        Console.WriteLine("Lets start by making an account!");
        
        Console.WriteLine("Enter your desired username: ");

        string user_username = Console.ReadLine()!;
        
        
        user_Info.SetUsername(user_username);
        
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
            
            user_Info.SetPassword(user_password);

        }
        
        return user_Info;
        
    } //test validation loop for later

    public Employee_Info EmployeeWelcomeScreen(Employee_Info employee_Info, User_Info user_Info)
    {
        Console.WriteLine($"Welcome {user_Info.GetUsername()}!");
        Console.WriteLine($"Your current job title is: {employee_Info.GetEmployeeJobTitle()}");
        
        return employee_Info;
    }
}