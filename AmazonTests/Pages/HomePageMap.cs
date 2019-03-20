using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonTests.Pages
{

	class HomePageMap
	{
		readonly IWebDriver _driver;

		public HomePageMap(IWebDriver driver)
		{
			_driver = driver;
		}

		public IWebElement HomePageSearchBar => _driver.FindElement(By.Id("twotabsearchtextbox"));
		public IWebElement MenuSignInLink => _driver.FindElement(By.CssSelector("#nav-link-accountList"));
		public IWebElement SigninButton => _driver.FindElement(By.CssSelector(".nav-action-button"));
		public IWebElement CreateAccountSubmit => _driver.FindElement(By.Id("createAccountSubmit"));
		public IWebElement CustomerNameField => _driver.FindElement(By.Id("ap_customer_name"));
		public IWebElement CustomerEmailField => _driver.FindElement(By.Id("ap_email"));



	}
}
