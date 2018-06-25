using bookstore.Helper;
using System.Collections.Generic;
using Xunit;

namespace XUnitTest
{
    public class AuthHelperUnitTest
    {
        [Fact]
        public void AuthHelper_CreateToken_ExpectLength()
        {
            string token3 = AuthHelper.CreateToken(3);
            string token30 = AuthHelper.CreateToken(30);
            string token57 = AuthHelper.CreateToken(57);
            string token99 = AuthHelper.CreateToken(99);

            Assert.True(token3.Length == 3);
            Assert.True(token30.Length == 30);
            Assert.True(token57.Length == 57);
            Assert.True(token99.Length == 99);
        }


        [Fact]
        public void AuthHelper_ConvertToHashedString_ExpectNonEmpty()
        {
            List<string> list = new List<string> {
                "EG&E^&^B&E^E",
                "$%#&^*$&^*",
                "helloIamFabulous",
                "TrumpLovesKimJungEun",
                "O O L A L A"
            };
            foreach(string str in list)
            {
                string hashed = AuthHelper.ConvertToHashedString(str);
                Assert.NotEmpty(hashed);
            }
        }
        
        
    }
}
