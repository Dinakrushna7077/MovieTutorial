using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MovieTutorial.MovieDB.Pages;

[PageAuthorize(typeof(MovieRow))]
public class MoviePage : Controller
{
    [Route("MovieDB/Movie")]
    public ActionResult Index()
    {
        return this.GridPage<MovieRow>("@/MovieDB/Movie/MoviePage");
    }
}