using Lab3_Mini_Projekt.Data;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Lab3_Mini_Projekt.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Interest> Interests { get; set; }
        public virtual ICollection<InterestWebLink> InterestWebLinks { get; set; }
        //question
        public Person()
        {
            Interests = new List<Interest>();
            InterestWebLinks = new List<InterestWebLink>();
        }

        public static IResult ShowAllObjects(ApplicationContext context)
        {
            return Results.Json(context.Persons.Select(p => new { p.Id, p.FirstName }).ToArray());
        }
        public static IResult AddPerson(ApplicationContext context, Person person)
        {
            context.Persons.Add(person);
            context.SaveChanges();
            return Results.StatusCode((int)HttpStatusCode.Created);
        }
        public static IResult OnePersonAllInfo(ApplicationContext context, int personId)
        {   //Fetching the person with given id and include its interests and weblinks
            Person? person = context.Persons.Where(p => p.Id == personId).Include(p=> p.Interests).Include(p => p.InterestWebLinks).FirstOrDefault();
            if (person == null)
            {
                return Results.NotFound();
            }
            //fetching all the info of the person and creating a view of them.
            var personView = new PersonView()
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName,
                PhoneNumber = person.PhoneNumber,
                Interest = person.Interests.Select(i => new InterestView { Id = i.Id, InterestName = i.InterestName, InterestDescription = i.InterestDescription }).ToArray(),
                InterestWebLinks = person.InterestWebLinks.Select(i => new InterestWebLinkView { Id = i.Id, Link = i.Link }).ToArray()
            };
            return Results.Json(personView);
        }
    }
}
