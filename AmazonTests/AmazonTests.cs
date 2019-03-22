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

			// Go To Amazon.com
			//driver.Navigate().GoToUrl("https://amazon.com");
			var home = new HomePage(Driver, Wait);
			home.GoTo("https://amazon.com");
			home.WaitForHomePageToLoad();

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
			var signInPage = new SignInPage(Driver, Wait);
			//Hover "Hello, Sign in. Account & Lists" to reveal menu
			//Click Sign-in
			signInPage.GoToSignIn();
			//Click Create your Amazon Account
			signInPage.CreateAccount("John Doe", "pc@user.com", "P@ssword1");

			//enter password in app-password
			//var passwordInput = signInPage.Map.PassworldField.GetProperty("value");
			var password1 = signInPage.Map.PasswordField.GetProperty("value");
			Console.WriteLine(password1);

			//enter password check
			//var passwordCheck = ElementHelper.GetElementInput(signInPage.Map.PasswordCheck);
			var password2 = signInPage.Map.PasswordCheck.GetProperty("value");
			Console.WriteLine(password2);

			//Assert the re - enter password field's value matches the password field's value
			Assert.AreEqual(password1, password2);

        }

		[TestMethod]
		public void Harry_potter()
		{

		}

    }
}
