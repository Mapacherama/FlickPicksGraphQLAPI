namespace FlickPicksGraphQLBackend.Graphql
{
    public class Rating
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public int Value { get; set; }
        // Add additional properties as needed

        // Optional: Add navigation properties for relationships
        // public Movie Movie { get; set; }
        // public User User { get; set; }
    }
}

