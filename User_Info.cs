namespace Game_Tracking;

public class User_Info
{
    public string username;
    public string password;
    
    public void SetUsername(string username)
    {
        this.username = username;
    }

    public string GetUsername()
    {
        return username;
    }
    
    public void SetPassword(string password)
    {
        this.password = password;
    }

    public string GetPassword()
    {
        return password;
    }
}