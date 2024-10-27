namespace PokemonReviewApp.Models
{
    public class Reviewer
    {
        public int id { get; set; }
        public String FirstName { get; set; }
        public string LastName { get; set; } 
        public ICollection<Review> Reviews { get; set; }

    }
}
