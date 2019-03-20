using AmazonTests.Helpers;
using AmazonTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AmazonTests
{
	[TestClass]
    public class AmazonTests
    {

		IWebDriver Driver;
		WebDriverWait Wait;

		[TestInitialize]
		public void SetUp()
		{
			Driver = new ChromeDriver(@"/Source/autobots/AmazonTests/AmazonTests/driver");
			Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));

			var home = new HomePage(Driver, Wait);
			home.GoTo();

		}

		[TestCleanup]
		public void CleanUp()
		{
			Driver.Quit();
			Driver.Dispose();
		}

        [TestMethod]
        public void User_can_create_account()
        {
            // Go To Amazon.com
			//driver.Navigate().GoToUrl("https://amazon.com");

            
			//Hover "Hello, Sign in. Account & Lists" to reveal menu
            IWebElement hover = Driver.FindElement(By.CssSelector("#nav-link-accountList"));
			ElementHelper.Hover(Driver, hover);
			//Actions actions = new Actions(driver);
			//actions.MoveToElement(signinHover);
			//actions.Build().Perform();

			//Click Sign-in
			IWebElement signinButton = Driver.FindElement(By.CssSelector(".nav-action-button"));
			signinButton.Click();

			//Click Create your Amazon Account
			Driver.FindElement(By.Id("createAccountSubmit")).Click();

			//Fill out the form(Do not submit)
			Driver.FindElement(By.Id("ap_customer_name")).SendKeys("name");
			Driver.FindElement(By.Id("ap_email")).SendKeys("email");
			//IWebElement passworldField = driver.FindElement(By.Id("ap_password"));
			//IWebElement passwordCheck = driver.FindElement(By.Id("ap_password_check"));

			//enter password in app-password
			IWebElement passworldField = Driver.FindElement(By.Id("ap_password"));
			passworldField.SendKeys("password");
			string passwordInput = ElementHelper.GetElementInput(passworldField);

			//enter password check
			IWebElement passwordCheck = Driver.FindElement(By.Id("ap_password_check"));
			passwordCheck.SendKeys("password");
			string passwordCheckInput = ElementHelper.GetElementInput(passwordCheck);

			//Assert the re - enter password field's value matches the password field's value

			Assert.AreEqual(passwordCheckInput, passworldField);

        }

		[TestMethod]
		public void Harry_potter()
		{

		}

		

    }
}
