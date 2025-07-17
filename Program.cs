namespace Game_Tracking;

class Program
{
    static void Main(string[] args)
    {
        General_Messages general_Messages = new General_Messages();  //Establishing instances of objects to call outside
        Employee_Ui employee_Ui = new Employee_Ui();                 //of the static method (fix this wording)
        User_Info user_Info = new User_Info();
        Employee_Info employee_Info = new Employee_Info();
        
        general_Messages.WelcomeMessage();
        general_Messages.DescribeProgramMessage();
        general_Messages.WelcomeMessage();
        general_Messages.AreYouAnEmployeeOrViewer();
        
        if (general_Messages.AreYouAnEmployeeOrViewer() == "employee")
        {
            if (general_Messages.DoYouHaveAnAccountMessage() == "yes")
            {
              //add later
            }
            if (general_Messages.DoYouHaveAnAccountMessage() == "no")
            {
                employee_Ui.EmployeeCreateAccount(user_Info);
            }
        }

        if (general_Messages.AreYouAnEmployeeOrViewer() == "viewer")
        {
            if (general_Messages.DoYouHaveAnAccountMessage() == "yes")
            {
                
            }
            if (general_Messages.DoYouHaveAnAccountMessage() == "no")
            {
                
            }
        }
        
        
    }
}