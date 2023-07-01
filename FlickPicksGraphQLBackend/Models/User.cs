namespace FlickPicksGraphQLBackend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        // Add additional properties as needed

        // Optional: Add navigation properties for relationships
        // public List<Rating> Ratings { get; set; }
    }
}