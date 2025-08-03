namespace Game_Tracking;

public class Employee_Info : User_Info
{
    
    public string employeeJobTitle;
    
    public int hoursWorkedThisYear;  
    
    public List<string> possibleJobTitles = new List<string> { "ceo", "manager", "referee" };
    
    Random random = new Random();
    
    public void SetEmployeeJobTitle()
    {
        int index = random.Next(possibleJobTitles.Count);
        this.employeeJobTitle =  possibleJobTitles[index];
    }
    
    public string GetEmployeeJobTitle()
    {

        return employeeJobTitle;
    }

    public void SetHoursWorkedThisYear(int hoursWorkedThisYear)
    {
        this.hoursWorkedThisYear = hoursWorkedThisYear;
    }

    public int GetHoursWorkedThisYear()
    {
        return hoursWorkedThisYear;
    }

    public void WriteUsernameAndPassword()
    {
        string filePath = "Username_Password.txt";
        
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine($"Username: {GetUsername()}");
            writer.WriteLine($"Password: {GetPassword()}");
        }
    }
    
    
}