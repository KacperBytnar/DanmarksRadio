using DanmarksRadio.Models;
using Microsoft.EntityFrameworkCore;

namespace DanmarksRadio
{
    public class MusicRecordsContext : DbContext
    {
        public MusicRecordsContext(DbContextOptions<MusicRecordsContext> options) :base(options)
        {

        }

        public DbSet<MusicRecords> MusicRecords { get; set; }
    }
}
