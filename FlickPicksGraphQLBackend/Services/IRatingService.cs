using System.Collections.Generic;
using System.Threading.Tasks;
using FlickPicksGraphQLBackend.Graphql;
using FlickPicksGraphQLBackend.Models;

namespace FlickPicksGraphQLBackend.Services
{
    public interface IRatingService
    {
        Task<IEnumerable<Rating>> GetAllRatings();
        Task<Rating> GetRatingById(int id);
        Task<Rating> CreateRating(Rating rating);
        Task<Rating> UpdateRating(int id, Rating updatedRating);
        Task<bool> DeleteRating(int id);
    }
}
