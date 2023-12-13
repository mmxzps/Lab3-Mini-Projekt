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
    }
}
