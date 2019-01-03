using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAppWeb.BL;
using System.Data;
using BankAppWeb.DataManagementService;

namespace BabkAppTest
{
    [TestClass]
    public class MSUnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    Assert.Fail("failing a test");
        //}

        [TestMethod]
        public void CustomerThresholdValueTest()
        {
            try
            {
                BusinessLogic blCustomerData = new BusinessLogic();
                //check now
                //DataTable dt = new DataTable();
                bool bSucess = blCustomerData.MinCustomerCountCheck(10);
                Assert.AreEqual(bSucess, true);
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception has been thrown: Error Details : " + ex.Message);
            }
        }
        [TestMethod]
        public void BalanceCheckMethodTest()
        {
            try
            {
                BusinessLogic blCustomerData = new BusinessLogic();
                bool bsucess = blCustomerData.MinBalanceCheck(500);
                Assert.AreEqual(bsucess, false);
                bsucess = blCustomerData.MinBalanceCheck(1500);
                Assert.AreEqual(bsucess, true);
            }
            catch (Exception ex)
            {
                Assert.Fail("Exception has been thrown: Error Details : " + ex.Message);
            }
        }

    }
}
