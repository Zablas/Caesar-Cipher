using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caesar_Cipher;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StartStringEqualsDecrypted()
        {
            string toEncrypt = "Hello, World!";
            int shift = 3;
            string encrypted = Caesar.Encipher(toEncrypt, shift);
            string decrypted = Caesar.Decipher(encrypted, shift);
            Assert.AreEqual(toEncrypt, decrypted);
        }
    }
}
