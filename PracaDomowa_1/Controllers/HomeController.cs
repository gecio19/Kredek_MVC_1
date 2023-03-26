using Microsoft.AspNetCore.Mvc;
using PracaDomowa_1.Models;
using PracaDomowa_1.Repositories;
using System.Diagnostics;

namespace PracaDomowa_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieRepository _moviesRepository;

        public HomeController(IMovieRepository moviesRepository)
        {
            _moviesRepository = moviesRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AllMovies()
        {
            var movies = _moviesRepository.GetAll();
            return View(movies);
        }

        public IActionResult MoveDetails(string id)
        {
            int numberMovie = Int32.Parse(id);

            //var film = _moviesRepository.GetMovie(numberMovie);
            return PartialView("Modal", _moviesRepository.GetMovie(numberMovie));
        }



        public IActionResult RandomMovie()
        {

            return View(_moviesRepository.GetRandomMovie());
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}