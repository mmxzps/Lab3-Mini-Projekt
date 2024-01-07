using Lab3_Mini_Projekt.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace Lab3_Mini_Projekt.Model
{
    public class InterestWebLink
    {
        public int Id { get; set; }
        public string Link { get; set; }

        public virtual Interest Interests { get; set; }
        public virtual Person Persons { get; set; }

        public static IResult AddWebLink(ApplicationContext context, InterestWebLink interestWebLink, int personId, int interestId)
        {
            //fetching the person with matching id
            Person? person = context.Persons.SingleOrDefault(p => p.Id == personId);
            if (person == null)
            {
                return Results.NotFound($"Person with id:{personId} not found!");
            }
            //fetching the interest with matching id
            Interest? interest = context.Interests.SingleOrDefault(i => i.Id == interestId);
            if (interest == null)
            {
                return Results.NotFound($"Interest with id:{interestId} not found!");
            }
            //adding the link connected to the person and interest.
            var link = new InterestWebLink { Link = interestWebLink.Link, Interests = interest, Persons = person };
            context.InterestWebLinks.Add(link);
            context.SaveChanges();
            return Results.StatusCode((int)HttpStatusCode.Created);
        }
        public static IResult ShowAllWebLinks(ApplicationContext context)
        {
            return Results.Json(context.InterestWebLinks.Select(p => new { p.Id, p.Link }).ToArray());
        }
        public static IResult ShowLinksOfOnePerson(ApplicationContext context, int personId)
        {   //Fetching the person with given id and include its weblinks
            Person? person = context.Persons.Where(p=>p.Id == personId).Include(p=>p.InterestWebLinks).SingleOrDefault();
            if (person == null)
            {
                return Results.NotFound($"Person with id:{personId} not found!");
            }
            //fetching persons weblinks and creating a view of them.
            var intersetWebLinkView = person.InterestWebLinks.Select(theLink => new InterestWebLinkView()
            {
                Id = theLink.Id,
                Link = theLink.Link,
            }).ToArray();
            return Results.Json(intersetWebLinkView);
        }
    }
}
