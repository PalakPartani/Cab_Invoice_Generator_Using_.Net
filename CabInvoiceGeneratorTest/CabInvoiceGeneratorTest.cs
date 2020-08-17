// <copyright file="CabInvoiceGeneratorTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CabInvoiceGeneratorTest
{
    using CabInvoiceGeneratorProblem;
    using NUnit.Framework;

    /// <summary>
    /// Testing Cab Invoice Generator.
    /// </summary>
    public class CabInvoiceGeneratorTest
    {
       private CabInvoiceGenerator cabInvoiceGenerator;

        /// <summary>
        /// Ititialize CabInvoiceGenerator class.
        /// </summary>
       [SetUp]
       public void Setup()
        {
            cabInvoiceGenerator = new CabInvoiceGenerator();
        }

        /// <summary>
        /// Calculate total fare through distance and time.
        /// </summary>
       [Test]
       public void GivenDistanceAndTime_ShouldReturnCorrectTotalFare()
        {
            double fare = cabInvoiceGenerator.CalculateFare(2.0, 5);
            Assert.AreEqual(25, fare, 0.0);
        }
    }
}