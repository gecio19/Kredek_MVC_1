using PracaDomowa_1.Models;

namespace PracaDomowa_1.Repositories
{
    public class FakeMovieRepository : IMovieRepository
    {
        private static readonly ICollection<Movie> _movies = new List<Movie>()
        {
            new(1,"Skazani na Shawshank", "Adaptacja opowiadania Stephena Kinga. Niesłusznie skazany na dożywocie bankier, stara się przetrwać w brutalnym, więziennym świecie.", 8.8, "SkazaninaShawshank.png"),
            new(2,"Nietykalni", "Sparaliżowany milioner zatrudnia do opieki młodego chłopaka z przedmieścia, który właśnie wyszedł z więzienia.", 8.6, "NIETYKALNI.png"),
            new(3,"Ojciec chrzestny", "Opowieść o nowojorskiej rodzinie mafijnej. Starzejący się Don Corleone pragnie przekazać władzę swojemu synowi.", 8.6, "OJCIECCHRZESTNY.png"),
            new(4,"Władca Pierścieni: Powrót króla", "Zwieńczenie filmowej trylogii wg powieści Tolkiena. Aragorn jednoczy siły Śródziemia, szykując się do bitwy, która ma odwrócić uwagę Saurona od podążających w kierunku Góry Przeznaczenia hobbitów.", 8.4, "wladcy.png"),
            new(5,"Chłopcy z ferajny", "Kilkunastoletni Henry i Tommy DeVito trafiają pod opiekę potężnego gangstera. Obaj szybko uczą się panujących w mafii reguł.", 8.3, "CHŁOPCYZFERAJNY.png"),
        };






        public IEnumerable<Movie> GetAll()
        {
            return _movies.ToList();
        }

        public Movie GetMovie(int id)
        {
            return _movies.FirstOrDefault(x => x.Id == id);
        }

        public Movie GetRandomMovie()
        {
            Random r = new Random();
            int number = r.Next(1, _movies.Count+1);
            return _movies.FirstOrDefault(x => x.Id == number);
        }
    }
}
