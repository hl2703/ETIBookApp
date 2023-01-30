using Microsoft.AspNetCore.Mvc;

namespace BookWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
       "Showing up for your community, your family, and your loved ones is not always easy. It can actually be quite terrifying if you aren’t fully comfortable with yourself",
            "Pulitzer Prize-winning science journalist Ed Yong has been one of the must-read voices throughout the COVID-19 pandemic. In An Immense World: How Animal Senses Reveal the Hidden Realms Around ",
            "Had to cancel your dream vacation due to the pandemic? This posthumous collection of essays and reflections captures the late travel and food writer and TV host Anthony Bourdains favorite places on the planet—and may j",
            "In her debut collection of nine original essays, the popular NewYorker.com writer interrogates everything from millennial scammers to the Internet. I",
            "n 24/6, filmmaker and popular speaker Shlain introduces readers to what she calls"
    };

        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetBook")]
        public IEnumerable<Book> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Book
            {
               Name = "An Immense world",
               Author = "Ed Yong",
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}