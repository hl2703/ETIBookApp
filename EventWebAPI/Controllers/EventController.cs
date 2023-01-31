using Microsoft.AspNetCore.Mvc;

namespace EventWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Borrow 5 books during the event period and stand a chance to win a StarBucks gift card!", 
            "Give these books a second life. Grab a free book during this period"
    };

        private readonly ILogger<EventController> _logger;

        public EventController(ILogger<EventController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetEvent")]
        public IEnumerable<Event> Get()
        {
            return Enumerable.Range(1, 2).Select(index => new Event
            {
                EventName = "Book Buffet",
                StartDate = DateTime.Now.AddDays(index),
                EndDate = DateTime.Now.AddDays(index),

                Description = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}