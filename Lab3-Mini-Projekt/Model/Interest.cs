using Lab3_Mini_Projekt.Data;
using System.Net;

namespace Lab3_Mini_Projekt.Model
{
    public class Interest
    {
        public int Id { get; set; }
        public string InterestName { get; set; }
        public string? InterestDescription { get; set; }

        //Navigation properties
        public virtual ICollection<Person> Persons { get; set; }
        public virtual ICollection<InterestWebLink> InterestWebLinks { get; set; }

        //Adding interest
        public static IResult AddInterest(ApplicationContext context, Interest interest)
        {
            context.Interests.Add(interest);
            context.SaveChanges();
            return Results.StatusCode((int)HttpStatusCode.Created);
        }

        //Showing objects in interest
        public static IResult ShowAllObjects(ApplicationContext context)
        {
            return Results.Json(context.Interests.Select(p => new { p.Id, p.InterestName }).ToArray());
        }
    }
}
