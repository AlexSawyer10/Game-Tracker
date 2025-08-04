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
        app.MapGet("/getUser", () =>
        {

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

        });
    
    }

/* public void Insert_User_Info(User_Info user_Info)
 {

     app.MapPost("/Game_Tracker",() =>
         {
             using var conn = new NpgsqlConnection(connString);

             string username_Insert = user_Info.GetUsername();
             string password_Insert = user_Info.GetPassword();

             using var cmd = new NpgsqlCommand(
                 @"INSERT INTO ""USER"" (username, password)
           VALUES (@username_Insert, @password_Insert)",
                 conn);
         })
         .WithName("Game_Tracker");

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
 }

}*/

