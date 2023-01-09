using Microsoft.AspNetCore.Mvc;
using MovieSite.Model;

namespace MovieSite.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private static readonly IEnumerable<MovieModel> Movies = new[]
        {
            new MovieModel{Id=1,Title="No Country for Old Men",Description="Violence and mayhem ensue after a hunter stumbles upon a drug deal gone wrong and more than two million dollars in cash near the Rio Grande.",Author="The Coen Brothers", ImageId=1, Ranking=10,MovieType=1},
            new MovieModel{Id=2, Title="Inception", Description="A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.", Author="Christopher Nolan", ImageId=2,Ranking=9,MovieType=2},
            new MovieModel{Id=3, Title="The Conjuring 2", Description="Ed and Lorraine Warren travel to North London to help a single mother raising four children alone in a house plagued by a supernatural spirit",Author="James Wan",ImageId=3,Ranking=8,MovieType=3}

        };

        [HttpGet("{itemType:int}")]
        public MovieModel[] Get(int MovieType)
        {
            MovieModel[] movies = Movies.Where(i => i.MovieType== MovieType).ToArray();
            return movies;
        }

    }

}
