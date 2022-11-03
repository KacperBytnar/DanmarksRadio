using DanmarksRadio.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace DanmarksRadio.Managers
{
    public class MusicRecordsManagerDB : IMusicRecordsManager
    {
        private MusicRecordsContext _musicRecordsContext;
        public MusicRecordsManagerDB(MusicRecordsContext context)
        {
            _musicRecordsContext = context;
        }

        public IEnumerable<MusicRecords> GetAll(string? title = null)
        {
            List<MusicRecords> books = _musicRecordsContext.MusicRecords.ToList();
            // copy constructor
            // Callers should no get a reference to the Data object, but rather get a copy

            if (title != null)
            {
                books = books.FindAll(book => book.Artist != null && book.Artist.StartsWith(title));
            }
            return books;
        }

        public MusicRecords Add(MusicRecords newRecord)
        {
            _musicRecordsContext.MusicRecords.Add(newRecord);
            _musicRecordsContext.SaveChanges();
            return newRecord;
        }


    }
}
