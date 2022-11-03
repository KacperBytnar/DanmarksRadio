using DanmarksRadio.Managers;
using DanmarksRadio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;


namespace DanmarksRadio.Controllers
{
    [Route("Records")]
    [EnableCors("AllowAll")]
    [ApiController]
    public class MusicRecordsController : ControllerBase
    {

        private readonly IMusicRecordsManager _manager;

        public MusicRecordsController(MusicRecordsContext context)
        {
            _manager = new MusicRecordsManagerDB(context);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpGet]
        public IEnumerable<MusicRecords> GetRecords([FromQuery] string? title)
        {   
            return _manager.GetAll(title);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult<MusicRecords> Post([FromBody] MusicRecords value)
        {
            try
            {
                MusicRecords createdRecord = _manager.Add(value);

                return Created("/" + createdRecord.Id, createdRecord);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
