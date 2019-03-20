using AmazonTests.Helpers;
using AmazonTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AmazonTests
{
	[TestClass]
    public class AmazonTests
    {
        public void GoTo()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://amazon.com";
        }



        [TestMethod]
        public void User_can_create_account()
        {
            // Go To Amazon.com
            IWebDriver driver = new ChromeDriver(@"_drivers_");
			var home = new HomePage(driver);
			//driver.Navigate().GoToUrl("https://amazon.com");
			home.GoTo();
            
			//Hover "Hello, Sign in. Account & Lists" to reveal menu
            IWebElement hover = driver.FindElement(By.CssSelector("#nav-link-accountList"));
			ElementHelper.Hover(driver, hover);
			//Actions actions = new Actions(driver);
			//actions.MoveToElement(signinHover);
			//actions.Build().Perform();

			//Click Sign-in
			IWebElement signinButton = driver.FindElement(By.CssSelector(".nav-action-button"));
			signinButton.Click();

			//Click Create your Amazon Account
			driver.FindElement(By.Id("createAccountSubmit")).Click();

			//Fill out the form(Do not submit)
			driver.FindElement(By.Id("ap_customer_name")).SendKeys("name");
			driver.FindElement(By.Id("ap_email")).SendKeys("email");
			//IWebElement passworldField = driver.FindElement(By.Id("ap_password"));
			//IWebElement passwordCheck = driver.FindElement(By.Id("ap_password_check"));

			//enter password in app-password
			IWebElement passworldField = driver.FindElement(By.Id("ap_password"));
			passworldField.SendKeys("password");
			string passwordInput = ElementHelper.GetElementInput(passworldField);

			//enter password check
			IWebElement passwordCheck = driver.FindElement(By.Id("ap_password_check"));
			passwordCheck.SendKeys("password");
			string passwordCheckInput = ElementHelper.GetElementInput(passwordCheck);

			//Assert the re - enter password field's value matches the password field's value

			Assert.AreEqual(passwordCheckInput, passworldField);

        }

		[TestMethod]
		public void Harry_potter_tho()
		{

		}

		

    }
}
