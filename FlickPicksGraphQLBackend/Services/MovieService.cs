using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlickPicksGraphQLBackend.Models;

namespace FlickPicksGraphQLBackend.Services
{
    public class MovieService : IMovieService
    {
        private readonly List<Movie> _movies;

        public MovieService()
        {
            _movies = new List<Movie>();
        }

        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            // You can implement logic to fetch movies from a database or another data source here
            return await Task.FromResult(_movies);
        }

        public async Task<Movie> GetMovieById(int id)
        {
            // You can implement logic to fetch a movie by its id from a database or another data source here
            return await Task.FromResult(_movies.FirstOrDefault(movie => movie.Id == id));
        }

        public async Task<Movie> CreateMovie(Movie movie)
        {
            movie.Id = GenerateUniqueId();
            _movies.Add(movie);

            // You can implement logic to save the created movie to a database or another data source here
            return await Task.FromResult(movie);
        }

        public async Task<Movie> UpdateMovie(int id, Movie updatedMovie)
        {
            var existingMovie = _movies.FirstOrDefault(movie => movie.Id == id);
            if (existingMovie != null)
            {
                existingMovie.Title = updatedMovie.Title;
                existingMovie.Director = updatedMovie.Director;
                existingMovie.Year = updatedMovie.Year;
                // Update other properties as needed

                // You can implement logic to update the movie in a database or another data source here
            }

            return await Task.FromResult(existingMovie);
        }

        public async Task<bool> DeleteMovie(int id)
        {
            var movieToRemove = _movies.FirstOrDefault(movie => movie.Id == id);
            if (movieToRemove != null)
            {
                _movies.Remove(movieToRemove);

                // You can implement logic to delete the movie from a database or another data source here
                return await Task.FromResult(true);
            }

            return await Task.FromResult(false);
        }

        // Helper method to generate a unique id for a new movie (you can replace this with your own implementation)
        private int GenerateUniqueId()
        {
            return _movies.Count > 0 ? _movies.Max(movie => movie.Id) + 1 : 1;
        }
    }
}

