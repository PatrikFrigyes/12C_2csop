using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Atvaltoop;

namespace Altvalt_Unittest
{
    [TestClass]
    public class UnitTest1
    {
        Altvalt atvalt = new Altvalt();

        [TestMethod]
        public void isDecimal_True()
        {
            string szoveg = "21";
            bool vartEredm = true,
                kapottEredm = false;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);


        }
        [TestMethod]
        public void isDecimal_False()
        {
            string szoveg = "!";
            bool vartEredm = false,
                kapottEredm = true;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);


        }
        [TestMethod]

        public void iSbinar_true()
        {
            string szoveg = "01010101";
            bool vartEredm = true,
                kapottEredm = false;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);

        }
        [TestMethod]
        public void iSbinar_false()
        {
            string szoveg = "!";
            bool vartEredm = false,
                kapottEredm = true;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);
        }


    }
}
