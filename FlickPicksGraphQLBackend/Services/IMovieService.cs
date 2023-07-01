using System.Collections.Generic;
using System.Threading.Tasks;
using FlickPicksGraphQLBackend.Models;

namespace FlickPicksGraphQLBackend.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAllMovies();
        Task<Movie> GetMovieById(int id);
        Task<Movie> CreateMovie(Movie movie);
        Task<Movie> UpdateMovie(int id, Movie updatedMovie);
        Task<bool> DeleteMovie(int id);
    }
}
