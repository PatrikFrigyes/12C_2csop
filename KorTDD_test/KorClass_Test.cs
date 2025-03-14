﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

using KorTDD;

namespace KorTDD_Test

{

    [TestClass]

    public class KorClass_Test

    {

        //Inicializáljuk a teszt környezetet

        KorClass kor = new KorClass(4.0);

        [TestMethod]

        public void setKerulet_teszt_True()

        {

            //Arange

            double sugar = kor.getSugar();

            double vartEredm = 25.12,

                kapottEredm;


            //Act

            kapottEredm = kor.SetKerulet(sugar);

            //Assert

            Assert.AreEqual(kapottEredm, vartEredm);

        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]

        public void setKerulet_teszt_False_Alatt()

        {

            //Arange

            kor.setSugar(0);

            double sugar = kor.getSugar();

            double vartEredm = 25.11,

                kapottEredm;


            //Act

            kapottEredm = kor.SetKerulet(sugar);

            //Assert

            Assert.AreNotEqual(kapottEredm, vartEredm);

        }

        [TestMethod]

        public void setKerulet_teszt_False_Felett()

        {

            //Arange

            double sugar = kor.getSugar();

            double vartEredm = 25.13,

                kapottEredm;


            //Act

            kapottEredm = kor.SetKerulet(sugar);

            //Assert

            Assert.AreNotEqual(kapottEredm, vartEredm);

        }

        [TestMethod]

        public void setTerulet_teszt_True()

        {

            //Arange 

            double sugar = kor.getSugar();

            double vartEredm = 50.24,

                kapottEredm;

            //Act

            kapottEredm = kor.SetTerulet(sugar);

            //Assert

            Assert.AreEqual(kapottEredm, vartEredm);

        }

        [TestMethod]

        public void setTerulet_teszt_False_alatta()

        {

            //Arange 

            double sugar = kor.getSugar();

            double vartEredm = 50.23,

                kapottEredm;

            //Act

            kapottEredm = kor.SetTerulet(sugar);

            //Assert

            Assert.AreNotEqual(kapottEredm, vartEredm);

        }

        [TestMethod]

        public void setTerulet_teszt_False_felette()

        {

            //Arange 

            double sugar = kor.getSugar();

            double vartEredm = 50.25,

                kapottEredm;

            //Act

            kapottEredm = kor.SetTerulet(sugar);

            //Assert

            Assert.AreNotEqual(kapottEredm, vartEredm);

        }

        [TestMethod]

        public void setSugar_teszt()

        {

            //Arange

            double sugar = kor.getSugar();

            double vartEredm = 4.0

                , kapottEredm;

            //Act

            kapottEredm = kor.getSugar();

            //Assert

            Assert.AreEqual(kapottEredm, vartEredm);

        }

        [TestMethod]

        public void setSugar_teszt_false_alatt()

        {

            //Arange

            double sugar = kor.getSugar();

            double vartEredm = 3.9

                , kapottEredm;

            //Act

            kapottEredm = kor.getSugar();

            //Assert

            Assert.AreNotEqual(kapottEredm, vartEredm);

        }

        [TestMethod]

        public void setSugar_teszt_false_felett()

        {

            //Arange

            double sugar = kor.getSugar();

            double vartEredm = 4.1

                , kapottEredm;

            //Act

            kapottEredm = kor.getSugar();

            //Assert

            Assert.AreNotEqual(kapottEredm, vartEredm);

        }

    }

}

