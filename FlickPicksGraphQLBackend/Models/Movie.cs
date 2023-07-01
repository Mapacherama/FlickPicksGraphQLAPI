namespace FlickPicksGraphQLBackend.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Director { get; set; }
        public int Year { get; set; }
        // Add additional properties as needed

        // Optional: Add navigation properties for relationships
        // public List<Rating> Ratings { get; set; }
    }
}
