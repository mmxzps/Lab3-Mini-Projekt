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
            //Showing all information of one person
            app.MapGet("/Person/{personId}", Person.OnePersonAllInfo);


            //----------------------INTEREST
            //Adding interests
            app.MapPost("/Interest", Interest.AddInterest);
            //Adding interests to one person
            app.MapPost("/Interest/{personId}", Interest.AddInterestToPerson);
            //Showing all interesets
            app.MapGet("/Interest", Interest.ShowAllObjects);
            //Showing all interesets of one person
            app.MapGet("/Interest/Interests/{personId}", Interest.ShowInterestOfOnePerson);


            //--------------------- Links
            //adding webLink connected to the person and interest.
            app.MapPost("/InterestWebLink/{personId}/{interestId}", InterestWebLink.AddWebLink);
            //Showing all webblinks
            app.MapGet("/InterestWebLink", InterestWebLink.ShowAllWebLinks);
            //Showing all links of one person
            app.MapGet("/InterestWebLink/Links/{personId}", InterestWebLink.ShowLinksOfOnePerson);

            app.Run();
        }
    }
}