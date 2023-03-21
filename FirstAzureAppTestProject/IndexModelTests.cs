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
            Assert.IsTrue(result.Equals($"Login succeeded for user {userName}"));

            //Assert.Fail();
        }

        [TestMethod()]
        public void AuthenticateTest_when_I_Provide_wrong_credentials_it_should_fail_or_return_null()
        {
            //Assert.Fail();
            string userName = "test";
            string password = "passcode_abc!!";

            var result = _indexModel.Authenticate(userName, password);

            Assert.IsNull(result);

        }
    }
}