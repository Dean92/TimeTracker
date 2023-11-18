using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeTracker.Shared.Entities;

namespace TimeTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeEntryController : ControllerBase
    {
        private static List<TimeEntry> _timeEntries = new List<TimeEntry>
        {
            new TimeEntry
            { Id = 1, Project = "TimeTracker app", End = DateTime.Now.AddHours(1) },
        };

        [HttpGet]
        public ActionResult<List<TimeEntry>> GetAlTimeEntries()
        {
            return Ok(_timeEntries);
        }
    }

    
}
