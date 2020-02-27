using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcolaLibraryTests;
namespace CalcolaLibraryTests
{
    [TestClass]
    public class CalcolaTests
    {
        [DataTestMethod]
        [DataRow(35,70)]
        [DataRow(50,100)]
        [DataRow(-6,-12)]
        public void RaddoppiaTest(double num ,double risposta_aspettata)
        {
            double risposta_effettiva = CalcolaLibrary.Calcola.Raddoppia(num);
            Assert.AreEqual(risposta_aspettata, risposta_effettiva);
        }

        [TestMethod]
        public void TestSommaMonete()
        {
            double[] monete = new double[5] { 20, 30, 5, 2, 4 };
            double somma_aspettata = 61;
            double somma_ricevuta = CalcolaLibrary.Calcola.SommaMonete(monete);
            Assert.AreEqual(somma_aspettata, somma_ricevuta);
        } 
    }
}
