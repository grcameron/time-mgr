using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using time_mgrApi.Services;
using time_mgrApi.Models;

namespace time_mgr.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimeLogEntryController : ControllerBase
    {
       private readonly TimeEntryService _timeEntryService;

        public TimeLogEntryController(TimeEntryService timeEntryService)
        {
            _timeEntryService = timeEntryService;
        }

        [HttpGet]
        public ActionResult<List<TimeLogEntry>> Get() =>
            _timeEntryService.Get();

        [HttpGet("{id:length(24)}", Name = "GetLog")]
        public ActionResult<TimeLogEntry> Get(string id)
        {
            var log = _timeEntryService.Get(id);

            if (log == null)
            {
                return NotFound();
            }

            return log;
        }

        [HttpPost]
        public ActionResult<TimeLogEntry> Create(TimeLogEntry log)
        {
            _timeEntryService.Create(log);

            return CreatedAtRoute("GetLogEntry", new { id = log.Id.ToString() }, log);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, TimeLogEntry logEntryIn)
        {
            var log = _timeEntryService.Get(id);

            if (log == null)
            {
                return NotFound();
            }

            _timeEntryService.Update(id, logEntryIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var log = _timeEntryService.Get(id);

            if (log == null)
            {
                return NotFound();
            }

            _timeEntryService.Remove(log.Id);

            return NoContent();
        }
    }
}