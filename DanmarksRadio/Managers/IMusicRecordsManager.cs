using DanmarksRadio.Models;

namespace DanmarksRadio.Managers
{
    public interface IMusicRecordsManager
    {
        IEnumerable<MusicRecords> GetAll();

        MusicRecords Add(MusicRecords newRecord);
    }
}
