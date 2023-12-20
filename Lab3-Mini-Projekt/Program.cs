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
            //Creating a person
            app.MapPost("/person", Person.AddPerson);
            //Showing all objects in "Person" with their firstname
            app.MapGet("/person/persons", Person.ShowAllObjects);
            //Showing all information of one person
            app.MapGet("/person/{personId}", Person.OnePersonAllInfo);
            //Adding interests to one person
            app.MapPost("/person/{personId}/interest", Interest.AddInterestToPerson);
            //Showing all interesets of one person
            app.MapGet("/person/{personId}/interests", Interest.ShowInterestOfOnePerson);
            //adding webLink connected to the person and interest.
            app.MapPost("/person/{personId}/{interestId}/interest-web-link", InterestWebLink.AddWebLink);
            //Showing all links of one person
            app.MapGet("/person/{personId}/interest-web-link/links", InterestWebLink.ShowLinksOfOnePerson);


            //----------------------INTEREST
            //Adding interests
            app.MapPost("/interest", Interest.AddInterest);

            //Showing all interesets
            app.MapGet("/interest/interests", Interest.ShowAllObjects);

            //--------------------- Links
            //Showing all webblinks
            app.MapGet("/interest-web-links", InterestWebLink.ShowAllWebLinks);

            app.Run();
        }
    }
}