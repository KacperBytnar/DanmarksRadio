using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace DanmarksRadio.Models
{
    public class MusicRecords
    {
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public int Duration { get; set; }
        public int PublicationYear { get; set; }
        public int Id { get; set; }



        public override string ToString()
        {
            return Title + " " + Artist + " " + Duration + " " + PublicationYear;
        }


        public void TitleValidator()
        {
            if (Title == null || Title == "")
            {
                throw new ArgumentNullException("Title is null");
            }
            if (Title.Length < 2)
            {
                throw new Exception("Title must be more than 2 characters long");
            }
        }


        public void ArtistValidator()
        {
            if (Artist == null || Artist == "")
            {
                throw new ArgumentNullException("Artist is null");
            }
            if (Artist.Length < 2)
            {
                throw new Exception("Artist must be more than 2 characters long");
            }
        }

        public void DurationValidator()
        {
            if (Duration < 10 || Duration > 300)
            {
                throw new Exception("Duration must be from 10 seconds to 5 minutes(300sec) long ");
            }
        }

        public void PublicationYearValidator()
        {
            if (PublicationYear < 1900 || PublicationYear > 2022)
            {
                throw new Exception("Publication year must be between 1900 and 2022");
            }
        }

        public void Validator()
        {
            TitleValidator();
            ArtistValidator();
            DurationValidator();
            PublicationYearValidator();

        }

    }






}
