using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonTests.Pages
{
	public class HomePage
	{

		readonly IWebDriver _driver;
		readonly WebDriverWait _wait;
		readonly HomePageMap map;

		public HomePage(IWebDriver driver, WebDriverWait wait)
		{
			_driver = driver;
			_wait = wait;
			map = new HomePageMap(driver);

		}

		public void GoTo()
		{
			_driver.Navigate().GoToUrl("https://amazon.com");
			WaitForPageToLoad();
		}

		internal void WaitForPageToLoad()
		{
			_wait.Until(driver => map.HomePageSearchBar.Displayed);
			Console.WriteLine("amazon.com loaded");
		}

		//public void GoTo()
		//{
		//	IWebDriver driver = new ChromeDriver();
		//	driver.Url = "https://amazon.com";
		//}

	}
}
