using PracaDomowa_1.Models;

namespace PracaDomowa_1.Repositories
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAll();

        Movie GetMovie(int id);

        Movie GetRandomMovie();




    }
}
