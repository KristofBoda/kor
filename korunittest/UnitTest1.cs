using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using kor1;

namespace korunittest
{
    [TestClass]
    public class KorTeszteles
    {
        [TestMethod]
        public void TeruletTeszt()
        {
            // Arrange - Környezet beállítása
            //Példányosítom az osztályt
            KorClass kr = new KorClass(3);
            //kr.setKerulet();
            kr.setTerulet();
            // Act - Futtatás
            double vartEredm = 28.27;
            double kapottEredm = Math.Round(kr.getTerulet(), 2);
            // Assert - Kiértékelés
            Assert.AreEqual(vartEredm, kapottEredm);
        }
        [TestMethod]
        public void KeruletTeszt()
        {
            KorClass kr = new KorClass(3);
            kr.setKerulet();
            double vartEredm1 = 18.85;
            double kapottEredm1 = Math.Round(kr.getKerulet(), 2);
            Assert.AreEqual(vartEredm1, kapottEredm1);
        }
        [TestMethod]
        public void SugarTeszt()
        {
            KorClass kr = new KorClass(3);
            kr.getSugar();
            double vartEredm2 = 3;
            double kapottEredm2 = kr.getSugar();
            Assert.AreEqual(vartEredm2, kapottEredm2);
        }
    }
}
