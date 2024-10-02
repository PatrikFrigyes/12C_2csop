using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace testproject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string vartErdem = "Fáter heló";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleApp3.Program.Main();
                var kapottEredm = sw.ToString().Trim();

                Assert.AreEqual(vartErdem, kapottEredm);

                
            }
            
        }
    }
}
