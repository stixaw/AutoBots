using AmazonTests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AmazonTests.Pages
{
	public class SignInPageMap
	{
		readonly IWebDriver Driver;

		public SignInPageMap(IWebDriver driver)
		{
			Driver = driver;
		}

		//IWebElement hover = Driver.FindElement(By.CssSelector("#nav-link-accountList"));
		public IWebElement MenuSignInLink => Driver.FindElement(By.CssSelector("#nav-link-accountList"));
		//IWebElement signinButton = Driver.FindElement(By.CssSelector(".nav-action-button"));
		public IWebElement SigninButton => Driver.FindElement(By.CssSelector(".nav-action-button"));

		//Create Account
		public IWebElement CreateAccountSubmitButton => Driver.FindElement(By.Id("createAccountSubmit"));
		public IWebElement CustomerNameField => Driver.FindElement(By.Id("ap_customer_name"));
		public IWebElement CustomerEmailField => Driver.FindElement(By.Id("ap_email"));
		//IWebElement passworldField = Driver.FindElement(By.Id("ap_password"));
		public IWebElement PasswordField => Driver.FindElement(By.Id("ap_password"));
		//IWebElement passwordCheck = Driver.FindElement(By.Id("ap_password_check"));
		public IWebElement PasswordCheck => Driver.FindElement(By.Id("ap_password_check"));

	}

	public class SignInPage
	{
		readonly IWebDriver Driver;
		readonly WebDriverWait Wait;
		public readonly SignInPageMap Map;

		public SignInPage(IWebDriver driver, WebDriverWait wait)
		{
			Driver = driver;
			Wait = wait;
			Map = new SignInPageMap(driver);
		}

		public void WaitForCreateAccountPageLoad()
		{
			Wait.Until(driver => Map.CustomerNameField.Displayed);
		}

		public void WaitForSignInPageLoad()
		{
			Wait.Until(driver => Map.SigninButton.Displayed);
		}

		public void GoToSignIn()
		{	

			//Actions actions = new Actions(driver);
			//actions.MoveToElement(signinHover);
			//actions.Build().Perform();
			ElementHelper.Hover(Driver, Map.MenuSignInLink);
			Map.SigninButton.Click();

		}

		public void CreateAccount(string name, string email, string password)
		{
			Map.CreateAccountSubmitButton.Click();
			WaitForCreateAccountPageLoad();

			//enter name and email
			Map.CustomerNameField.SendKeys(name);
			Map.CustomerEmailField.SendKeys(email);
			Map.PasswordField.SendKeys(password);
			Map.PasswordCheck.SendKeys(password);


		}

	}
}
