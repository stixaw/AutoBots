using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonTests.Pages
{
	public class HomePage
	{

		readonly IWebDriver driver;

		public HomePage(IWebDriver driver)
		{
			this.driver = driver;
		}

		public void GoTo()
		{
			driver.Navigate().GoToUrl("https://amazon.com");
		}

	}
}
