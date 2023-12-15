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


        //Adding weblinks
        public static IResult AddWebLink(ApplicationContext context, InterestWebLink interestWebLink, int personId, int interestId)
        {
            //fetching the person with matching id
            var person = context.Persons.FirstOrDefault(p => p.Id == personId);
            if (person == null)
            {
                return Results.NotFound();
            }
            //fetching the interest with matching id
            var interest = context.Interests.FirstOrDefault(i => i.Id == interestId);
            if (interest == null)
            {
                return Results.NotFound();
            }
            //adding the link connected to the person and interest.
            var link = new InterestWebLink { Link = interestWebLink.Link, Interests = interest, Persons = person };
            context.InterestWebLinks.Add(link);
            context.SaveChanges();
            return Results.StatusCode((int)HttpStatusCode.Created);
        }


        //Showing all links
        public static IResult ShowAllWebLinks(ApplicationContext context)
        {
            return Results.Json(context.InterestWebLinks.Select(p => new { p.Id, p.Link }).ToArray());
        }
    }
}
