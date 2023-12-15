using Lab3_Mini_Projekt.Data;
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

        public static IResult OnePersonAllInfo(ApplicationContext context, int id)
        {
            Person? person = context.Persons.Where(p => p.Id == id).FirstOrDefault();
            if (person == null)
            {
                return Results.NotFound();
            }
            return Results.Json(person);
        }
    }
}
