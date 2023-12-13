namespace Lab3_Mini_Projekt.Model
{
    public class InterestWebLink
    {
        public int Id { get; set; }
        public string Link { get; set; }

        public virtual Interest Interest { get; set; }
        public virtual Person Persons { get; set; }
    }
}
