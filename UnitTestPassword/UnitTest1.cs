using System;
using Check;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPassword
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void Invalid_Length_Password()
        {
            var dll = new Password();
            
            var res = dll.TestPassword("uy");
            Assert.AreEqual("Неподходящая длина пароля", res);
       
        }
        [TestMethod]
        public void Password_Without_Numbers()
        {
            var dll = new Password();
            var res = dll.TestPassword("retyu");
            Assert.AreEqual("Пароль не содержит цифр", res);
        }
        [TestMethod]
        public void Password_Without_Letters()
        {
            var dll = new Password();
            var res = dll.TestPassword("1234#@D5");
            Assert.AreEqual("Пароль не содержит букв", res);
        }
        [TestMethod]
        public void Password_Without_SpecialChar()
        {
            var dll = new Password();
            var res = dll.TestPassword("fdjgn23");
            Assert.AreEqual("Пароль не содержит специальных символов", res);
        }
        [TestMethod]
        public void Password_Without_СapitalLetters()
        {
            var dll = new Password();
            var res = dll.TestPassword("ffd2456#");
            Assert.AreEqual("Пароль не содержит заглавных букв", res);
        }

    }
}
