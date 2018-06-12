using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LastSunday.Business;

namespace LastSunday.Test
{
    [TestFixture]
    public class LastSundayTest
    {
        [Test]
        //[Ignore("Check it later")]
        public void GetLastSundayForEachMonth_GivenYear2013_ShouldReturnYear()
        {
            //Arrange
            var sut = new DateProcessor();
            var year = 2013;
            var expected = 2013;

            //Act
            var actual = sut.GetLastSundayForEachMonth(year);

            //Assert
            Assert.AreEqual(expected, actual.FirstOrDefault().Year);
        }
        [Test]
        public void GetLastSundayForEachMonth_GivenYear2013_ShouldReturnNumberOfMonths()
        {
            //Arrange
            var sut = new DateProcessor();
            var year = 2013;
            var expected = 12;

            //Act
            var actual = sut.GetLastSundayForEachMonth(year);

            //Assert
            Assert.AreEqual(expected, actual.Count );
        }
        [Test]
        [Ignore("Check it later")]
        public void GetLastSundayForEachMonth_GivenYear2013_ShouldReturnFirstdateOfEachMonth()
        {
            //Arrange
            var sut = new DateProcessor();
            var year = 2013;
            var expected = new List<DateTime>()
            {
                new DateTime(year, 1, 1),
                new DateTime(year, 2, 1),
                new DateTime(year, 3, 1),
                new DateTime(year, 4, 1),
                new DateTime(year, 5, 1),
                new DateTime(year, 6, 1),
                new DateTime(year, 7, 1),
                new DateTime(year, 8, 1),
                new DateTime(year, 9, 1),
                new DateTime(year, 10, 1),
                new DateTime(year, 11, 1),
                new DateTime(year, 12, 1)

            };

            //Act
            var actual = sut.GetLastSundayForEachMonth(year);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetLastSundayForEachMonth_GivenYear2013_ShouldReturnLastSundayDateForEachMonth()
        {
            //Arrange
            var sut = new DateProcessor();
            const int year = 2013;
            var expected = new List<DateTime>()
            {
                new DateTime(year, 1, 27),
                new DateTime(year, 2, 24),
                new DateTime(year, 3, 31),
                new DateTime(year, 4, 28),
                new DateTime(year, 5, 26),
                new DateTime(year, 6, 30),
                new DateTime(year, 7, 28),
                new DateTime(year, 8, 25),
                new DateTime(year, 9, 29),
                new DateTime(year, 10, 27),
                new DateTime(year, 11, 24),
                new DateTime(year, 12, 29)

            };

            //Act
            var actual = sut.GetLastSundayForEachMonth(year);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetLastSundayForEachMonth_GivenYear2017_ShouldReturnLastSundayDateForEachMonth()
        {
            //Arrange
            var sut = new DateProcessor();
            const int year = 2017;
            var expected = new List<DateTime>()
            {
                new DateTime(year, 1, 29),
                new DateTime(year, 2, 26),
                new DateTime(year, 3, 26),
                new DateTime(year, 4, 30),
                new DateTime(year, 5, 28),
                new DateTime(year, 6, 25),
                new DateTime(year, 7, 30),
                new DateTime(year, 8, 27),
                new DateTime(year, 9, 24),
                new DateTime(year, 10, 29),
                new DateTime(year, 11, 26),
                new DateTime(year, 12, 31)

            };

            //Act
            var actual = sut.GetLastSundayForEachMonth(year);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
