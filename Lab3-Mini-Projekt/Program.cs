using Lab3_Mini_Projekt.Data;
using Lab3_Mini_Projekt.Model;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Lab3_Mini_Projekt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //Fetching our connectionstring from "settings"
            string connectionString = builder.Configuration.GetConnectionString("ApplicationContext");
            //↓ opens up the opportunity to create DbContext when its needed
            builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connectionString));
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");


            //--------------------PERSON
            //Creating a person.
            app.MapPost("/Person", Person.AddPerson);
            //Showing all objects in "Person" with their firstname
            app.MapGet("/Person", Person.ShowAllObjects);
            //Showing all information of person only
            app.MapGet("/Person/{id}", Person.OnePersonAllInfo);


            //----------------------INTEREST
            //Adding interests
            app.MapPost("/Interest", Interest.AddInterest);
            //Adding interests
            app.MapPost("/Interest/{personId}", Interest.AddInterestToPerson);
            //Showing all interesets
            app.MapGet("/Interest", Interest.ShowAllObjects);


            //--------------------- Links
            //Adding weblinks
            app.MapPost("/InterestWebLink/{personId}/{interestId}", InterestWebLink.AddWebLink);
            //Showing all webblinks
            app.MapGet("/InterestWebLink", InterestWebLink.ShowAllWebLinks);

            app.Run();
        }
    }


}