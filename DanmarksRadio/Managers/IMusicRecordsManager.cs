using DanmarksRadio.Models;

namespace DanmarksRadio.Managers
{
    public interface IMusicRecordsManager
    {
        IEnumerable<MusicRecords> GetAll(string? title);

        MusicRecords Add(MusicRecords newRecord);
    }
}
