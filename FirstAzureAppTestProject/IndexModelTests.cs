using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstAzureWebApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAzureWebApp.Pages.Tests
{
    [TestClass()]
    public class IndexModelTests
    {
        private readonly IndexModel _indexModel;

        public IndexModelTests()
        {
            _indexModel = new IndexModel(null);
        }

        [TestMethod()]
        public void AuthenticateTest_with_correct_credentials_results_successful()
        {
 
            string userName = "test";
            string password = "passcode";

            var result = _indexModel.Authenticate(userName, password);  

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Equals($"Login succeded for user {userName}"));

             //Assert.Fail();
        }
    }
}