namespace WeightliftingTrackerGraphQLAPI.Configuration
{
    public static class ApplicationConfigurations
    {
        public static string GetConnectionString(WebApplicationBuilder app)
        {
            return app.Configuration.GetConnectionString("DefaultConnection");
        }

        
    }
}
