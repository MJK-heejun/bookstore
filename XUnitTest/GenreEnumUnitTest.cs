using bookstore.Enum;
using System;
using Xunit;

namespace XUnitTest
{
    public class GenreEnumUnitTest
    {
        [Fact]
        public void GenreEnum_ConvertFromEnumToString_ExpectSame()
        {
            Assert.Equal("Travel", GenreEnum.Travel.ToString());
            Assert.Equal("Any", GenreEnum.Any.ToString());
            Assert.Equal("Action", GenreEnum.Action.ToString());
            Assert.Equal("Comics", GenreEnum.Comics.ToString());
            Assert.Equal("Fantasy", GenreEnum.Fantasy.ToString());
            Assert.Equal("Fiction", GenreEnum.Fiction.ToString());
            Assert.Equal("History", GenreEnum.History.ToString());
            Assert.Equal("Mystery", GenreEnum.Mystery.ToString());
            Assert.Equal("Poetry", GenreEnum.Poetry.ToString());
            Assert.Equal("Romance", GenreEnum.Romance.ToString());
        }

        [Fact]
        public void GenreEnum_ConvertFromStringToEnum_ExpectSame()
        {
            Assert.Equal(GenreEnum.Travel, (GenreEnum)Enum.Parse(typeof(GenreEnum), "Travel"));
            Assert.Equal(GenreEnum.Any, (GenreEnum)Enum.Parse(typeof(GenreEnum), "Any"));
            Assert.Equal(GenreEnum.Action, (GenreEnum)Enum.Parse(typeof(GenreEnum), "Action"));
            Assert.Equal(GenreEnum.Comics, (GenreEnum)Enum.Parse(typeof(GenreEnum), "Comics"));
            Assert.Equal(GenreEnum.Fantasy, (GenreEnum)Enum.Parse(typeof(GenreEnum), "Fantasy"));
            Assert.Equal(GenreEnum.Fiction, (GenreEnum)Enum.Parse(typeof(GenreEnum), "Fiction"));
            Assert.Equal(GenreEnum.History, (GenreEnum)Enum.Parse(typeof(GenreEnum), "History"));
            Assert.Equal(GenreEnum.Mystery, (GenreEnum)Enum.Parse(typeof(GenreEnum), "Mystery"));
            Assert.Equal(GenreEnum.Poetry, (GenreEnum)Enum.Parse(typeof(GenreEnum), "Poetry"));
            Assert.Equal(GenreEnum.Romance, (GenreEnum)Enum.Parse(typeof(GenreEnum), "Romance"));
        }
    }
}
