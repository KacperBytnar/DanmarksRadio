using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DanmarksRadio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicRecordsController : ControllerBase
    {

        private readonly MusicRecordsManager _manager = new MusicRecordsManager();


        [HttpGet]
        public IEnumerable<MusicRecords> GetRecords()
        {
            return _manager.GetAllRecords();
        }



        


    }
}
