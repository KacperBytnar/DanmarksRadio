using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanmarksRadio.Models;

namespace DanmarksRadio.Tests
{
    [TestClass()]
    public class MusicRecordsTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            MusicRecords record1 = new MusicRecords() { Artist = "art1", Title = "tit1", Duration = 123, PublicationYear = 2011 };
            string str = record1.ToString();
            Assert.AreEqual(str, record1.ToString());
        }

        [TestMethod()]
        public void TitleValidatorTest()
        {
            MusicRecords record1 = new MusicRecords() { Artist = "art1", Title = null, Duration = 123, PublicationYear = 2011 };
            Assert.ThrowsException<ArgumentNullException>(() => record1.TitleValidator());

            MusicRecords record2 = new MusicRecords() { Artist = "art1", Title = "G", Duration = 123, PublicationYear = 2011 };
            Assert.ThrowsException<Exception>(() => record2.TitleValidator());

            MusicRecords record3 = new MusicRecords() { Artist = "art1", Title = "", Duration = 123, PublicationYear = 2011 };
            Assert.ThrowsException<ArgumentNullException>(() => record1.TitleValidator());


        }

        [TestMethod()]
        public void ArtistValidatorTest()
        {
            MusicRecords record1 = new MusicRecords() { Artist = null, Title = "tit1", Duration = 123, PublicationYear = 2011 };
            Assert.ThrowsException<ArgumentNullException>(() => record1.ArtistValidator());

            MusicRecords record2 = new MusicRecords() { Artist = "X", Title = "tit1", Duration = 123, PublicationYear = 2011 };
            Assert.ThrowsException<Exception>(() => record2.ArtistValidator());

            MusicRecords record3 = new MusicRecords() { Artist = "", Title = "tit1", Duration = 123, PublicationYear = 2011 };
            Assert.ThrowsException<ArgumentNullException>(() => record1.ArtistValidator());
        }

        [TestMethod()]
        public void DurationValidatorTest()
        {
            MusicRecords record1 = new MusicRecords() { Artist = "art1", Title = "tit1", Duration = 9, PublicationYear = 2011 };
            Assert.ThrowsException<Exception>(() => record1.DurationValidator());

            MusicRecords record2 = new MusicRecords() { Artist = "art1", Title = "tit1", Duration = 315, PublicationYear = 2011 };
            Assert.ThrowsException<Exception>(() => record2.DurationValidator());
        }

        [TestMethod()]
        public void PublicationYearValidatorTest()
        {
            MusicRecords record1 = new MusicRecords() { Artist = "art1", Title = "tit1", Duration = 123, PublicationYear = 1654 };
            Assert.ThrowsException<Exception>(() => record1.PublicationYearValidator());

            MusicRecords record2 = new MusicRecords() { Artist = "art1", Title = "tit1", Duration = 123, PublicationYear = 2023 };
            Assert.ThrowsException<Exception>(() => record2.PublicationYearValidator());
        }

       
    }
}