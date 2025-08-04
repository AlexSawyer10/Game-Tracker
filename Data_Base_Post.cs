using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Game_Tracking;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Npgsql;


[ApiController]
[Route("api/Game_Tracker")]
public class Data_Base_Post : ControllerBase
{
    string connString = "Host=localhost;Port=5432;Username=alexsawyer;Database=Game_Tracker";

    [HttpGet("getUser")]
    public void GET_USER_INFO()
    {

        using var conn = new NpgsqlConnection(connString);
        conn.Open();

        using var cmd = new NpgsqlCommand("SELECT * FROM TBL_USER", conn);
        using var reader = cmd.ExecuteReader();

        List<int> idList = new List<int>();

        while (reader.Read())
        {
            Console.WriteLine(reader.GetValue(1));

            //idList.Add(reader.GetInt32(0));
        }

    }
    
    
    [HttpPost("createUser")] //IActionResult helps return errors
    public IActionResult Insert_User_Info([FromBody]User_Info user_Info)
    {
        using var conn = new NpgsqlConnection(connString);
        conn.Open();
        Console.WriteLine($"INSERT INTO TBL_USER(username, password) VALUES('{user_Info.username}','{user_Info.password}')");
        try
        {
            using var cmd =
                new NpgsqlCommand(
                    $"INSERT INTO TBL_USER(username, password) VALUES({user_Info.username},{user_Info.password})",
                    conn);
            cmd.ExecuteNonQuery();
            return Ok(user_Info);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            conn.Close();
        }
        
    }
   /* public void saveForLater()
    {
        app.MapGet("/getUser", () =>
        {
            string connString = "Host=localhost;Port=5432;Username=alexsawyer;Database=Game_Tracker";

            using var conn = new NpgsqlConnection(connString);
            conn.Open();

            using var cmd = new NpgsqlCommand("SELECT * FROM USER", conn);
            using var reader = cmd.ExecuteReader();

            List<int> idList = new List<int>();

            while (reader.Read())
            {
                Console.WriteLine(reader.GetValue(3));

                idList.Add(reader.GetInt32(0));
            }

            return idList;
        }).WithName("getUser");
    }*/
}





