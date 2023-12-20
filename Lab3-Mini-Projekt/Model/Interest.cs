using Lab3_Mini_Projekt.Data;
using Microsoft.EntityFrameworkCore;
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

        public static IResult AddInterest(ApplicationContext context, Interest interest)
        {
            context.Interests.Add(interest);
            context.SaveChanges();
            return Results.StatusCode((int)HttpStatusCode.Created);
        }
        public static IResult ShowAllObjects(ApplicationContext context)
        {
            return Results.Json(context.Interests.Select(p => new { p.Id, p.InterestName }).ToArray());
        }
        public static IResult AddInterestToPerson(ApplicationContext context, Interest interest, int personId)
        {
            //fetching the person with matching id
            var person = context.Persons.Include(p => p.Interests).FirstOrDefault(p => p.Id == personId);
            if (person == null)
            {
                return Results.NotFound();
            }

            //adding the link connected to the person and interest.
            var theInterest = new Interest { InterestName = interest.InterestName, InterestDescription = interest.InterestDescription };
            //context.Interests.Add(theInterest);

            //adding the interest to the person.
            person.Interests.Add(theInterest);
            context.SaveChanges();
            return Results.StatusCode((int)HttpStatusCode.Created);
        }
        public static IResult ShowInterestOfOnePerson(ApplicationContext context, int personId)
        {   //Fetching the person with given id and include its interests
            Person? person = context.Persons.Where(p=>p.Id == personId).Include(p=>p.Interests).FirstOrDefault();
            if (person == null)
            {
                return Results.NotFound();
            }
            //fetching persons interests and creating a view of them with their Id, interestName and description.
            var interestView = person.Interests.Select(theInterest => new InterestView()
            {
                Id = theInterest.Id,
                InterestName = theInterest.InterestName,
                InterestDescription = theInterest.InterestDescription,
            }).ToArray();
            return Results.Json(interestView);
        }  
    }
}
