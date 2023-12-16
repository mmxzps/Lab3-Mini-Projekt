namespace Lab3_Mini_Projekt.Model
{
    //Created to be able to show all the information for this class
    public class PersonView
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public  ICollection<InterestView> Interest { get; set; }
        public  ICollection<InterestWebLinkView> InterestWebLinks { get; set; }
    }
}
