//Inside SeleniumTest.cs

using NUnit.Framework;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Firefox;

using System;

using System.Collections.ObjectModel;

using System.IO;

namespace SelenuiumTestProjecct
{
	public class Tests

	{

		IWebDriver driver;

		[OneTimeSetUp]

		public void Setup()

		{

			//Below code is to get the drivers folder path dynamically.

			//You can also specify chromedriver.exe path dircly ex: C:/MyProject/Project/drivers

			string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

			//Creates the ChomeDriver object, Executes tests on Google Chrome

			driver = new ChromeDriver(path + @"\drivers\");

			//If you want to Execute Tests on Firefox uncomment the below code

			// Specify Correct location of geckodriver.exe folder path. Ex: C:/Project/drivers

			//driver= new FirefoxDriver(path + @"\drivers\");

		}

		//[Test]

		//public void verifyLogo()

		//{

		//	driver.Navigate().GoToUrl("https://www.browserstack.com/");
		//	Assert.IsTrue(driver.FindElement(By.Id("logo")).Displayed);

		//}

		//[Test]

		//public void verifyMenuItemcount()

		//{

		//	ReadOnlyCollection<IWebElement> menuItem = driver.FindElements(By.XPath("//ul[contains(@class,'horizontal-list product-menu')]/li"));
		//	Assert.AreEqual(menuItem.Count, 4);

		//}

		[Test]

		public void verifystudent()
		{
			driver.Url = "https://mawaz.azurewebsites.net/";
			IWebElement emailField = driver.FindElement(By.Id("name"));
			IWebElement passwordField = driver.FindElement(By.Id("semester"));
			emailField.SendKeys("Mawaz");
			passwordField.SendKeys("1");

			// Submit the form
			passwordField.Submit();

		}



		[OneTimeTearDown]

		public void TearDown()

		{

			driver.Quit();

		}

	}

}