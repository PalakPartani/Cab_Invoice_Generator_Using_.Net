namespace CabInvoiceGeneratorTest
{
    using CabInvoiceGeneratorProblem;
    using NUnit.Framework;
    public class Tests
    {
        CabInvoiceGenerator cabInvoiceGenerator;
        [SetUp]
        public void Setup()
        {
            cabInvoiceGenerator = new CabInvoiceGenerator();
        }

        [Test]
        public void givenDistanceAndTime_ShouldReturnCorrectTotalFare()
        {
            CabInvoiceGenerator invoiceService = new CabInvoiceGenerator();
            double fare = invoiceService.CalculateFare(2.0, 5);
            Assert.AreEqual(25, fare, 0.0);
        }

    }
}