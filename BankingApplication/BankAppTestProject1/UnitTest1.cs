using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;


namespace BankAppTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        //once for all the whole test cases
        [TestFixtureSetUp]
        public void fixtureSetup()
        {

        }

        // runs for each testcase
        // Need to initialize variable used across all methods
        [SetUp]
        public void setup()
        {

        }

        // test case
        [TestCase]
        public void testMethod3()
        {
            //CustomerDetailsBL custDetails = new CustomerDetailsBL();
            //int CustomerCount = custDetails.GetNumberOfcustomer("ICICI");
            NUnit.Framework.Assert.GreaterOrEqual(50, 50);
        }

        // test case
        [TestCase]
        public void testMethod4()
        {
            //CustomerDetailsBL custDetails = new CustomerDetailsBL();
            //int CustomerCount = custDetails.GetNumberOfcustomer("ICICI");
            NUnit.Framework.Assert.GreaterOrEqual(60, 50);
        }

        [TestCase]
        public void testMethod5()
        {
            //CustomerDetailsBL custDetails = new CustomerDetailsBL();
            //int CustomerCount = custDetails.GetNumberOfcustomer("ICICI");
            NUnit.Framework.Assert.GreaterOrEqual(10, 50);
        }
        // runs for each testcase
        [TearDown]
        public void teardown()
        {
        }

        [TestFixtureTearDown]
        public void fixtureteardown()
        { }

    }
}
