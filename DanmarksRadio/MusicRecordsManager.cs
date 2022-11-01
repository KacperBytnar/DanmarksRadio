namespace DanmarksRadio
{
    public class MusicRecordsManager
    {
        private static int _nextId = 1;
        private static readonly List<MusicRecords> Data = new List<MusicRecords>
        {
            new MusicRecords {Id = _nextId++, Artist = "Bon Jovi", Title = "Livin on a prayer", Duration = 138, PublicationYear = 1998},
            new MusicRecords {Id = _nextId++, Artist = "Jon Bovi", Title = "Pavin on a layer", Duration = 145, PublicationYear = 2001},
            new MusicRecords {Id = _nextId++, Artist = "Karlos", Title = "Karlito & Son", Duration = 167, PublicationYear = 2007},
            new MusicRecords {Id = _nextId++, Artist = "5 Cent", Title = "Brandy shop", Duration = 189, PublicationYear = 2009},
            new MusicRecords {Id = _nextId ++, Artist = "Zealand Band", Title = "ToDoDoo", Duration = 147, PublicationYear = 2012},
            new MusicRecords {Id = _nextId++, Artist = "Pineapple", Title = "Pen", Duration = 202, PublicationYear = 2018},
            new MusicRecords {Id = _nextId++, Artist = "Din Viesel", Title = "Cold Pursuit", Duration = 223, PublicationYear = 2015},
        };


        public List<MusicRecords> GetAllRecords()
        {
            return new List<MusicRecords>(Data);

            
        }

        public List<MusicRecords> GetAll(string title = null, string artist = null)
       
        {
            List<MusicRecords> records = new List<MusicRecords>(Data);
            // copy constructor
            // Callers should no get a reference to the Data object, but rather get a copy

            if (title != null)
            {
                records = records.FindAll(records => records.Title != null && records.Title.StartsWith(title));
            }
            if (artist != null)
            {
                records = records.FindAll(records => records.Artist != null && records.Artist.StartsWith(artist));
            }
            return records;
        }

        public MusicRecords? GetRecordById(int id)
        {
            return Data.Find(records => records.Id == id);
        }

        

        public MusicRecords Add(MusicRecords newRecord)
        {
            newRecord.Id = _nextId++;
            Data.Add(newRecord);
            return newRecord;
        }

        public MusicRecords? DeleteRecord(int id)
        {
            MusicRecords? record = Data.Find(record1 => record1.Id == id);
            if (record == null) return null;
            Data.Remove(record);
            return record;
        }

        public MusicRecords? UpdateRecord(int id, MusicRecords update)
        {
            MusicRecords? record = Data.Find(record1 => record1.Id == id);
            if (record == null) return null;
            record.Title = update.Title;
            record.Artist = update.Artist;
            record.Duration = update.Duration;
            record.PublicationYear = update.PublicationYear;
            return record;
        }


    }
}
