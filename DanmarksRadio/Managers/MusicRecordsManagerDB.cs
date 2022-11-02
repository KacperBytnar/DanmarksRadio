using DanmarksRadio.Models;
using Microsoft.EntityFrameworkCore;

namespace DanmarksRadio.Managers
{
    public class MusicRecordsManagerDB : IMusicRecordsManager
    {
        private MusicRecordsContext _musicRecordsContext;
        public MusicRecordsManagerDB(MusicRecordsContext context)
        {
            _musicRecordsContext = context;
        }

        public IEnumerable<MusicRecords> GetAll()
        {
            return _musicRecordsContext.MusicRecords.ToList();
        }

        public MusicRecords Add(MusicRecords newRecord)
        {
            _musicRecordsContext.MusicRecords.Add(newRecord);
            _musicRecordsContext.SaveChanges();
            return newRecord;
        }


    }
}
