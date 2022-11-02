using DanmarksRadio.Managers;
using DanmarksRadio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DanmarksRadio.Controllers
{
    [Route("Records")]
    [ApiController]
    public class MusicRecordsController : ControllerBase
    {

        private readonly IMusicRecordsManager _manager;

        public MusicRecordsController(MusicRecordsContext context)
        {
            _manager = new MusicRecordsManagerDB(context);
        }


        [HttpGet]
        public IEnumerable<MusicRecords> GetRecords()
        {   
            return _manager.GetAll();
        }

        [HttpPost]
        public MusicRecords Post([FromBody] MusicRecords value)
        {
            return _manager.Add(value);
        }

    }
}
