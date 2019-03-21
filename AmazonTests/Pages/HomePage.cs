using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonTests.Pages
{
	public class HomePage
	{

		readonly IWebDriver Driver;
		readonly WebDriverWait Wait;
		public readonly HomePageMap Map;

		public HomePage(IWebDriver driver, WebDriverWait wait)
		{
			Driver = driver;
			Wait = wait;
			Map = new HomePageMap(driver);

		}

		public void GoTo(string url)
		{
			Driver.Navigate().GoToUrl(url);
			WaitForHomePageToLoad();
		}

		public void SwitchDept()
		{
			Map.HomePageSearchBar.Click();
		}

		internal void WaitForHomePageToLoad()
		{
			Wait.Until(driver => Map.HomePageSearchBar.Displayed);
			Console.WriteLine("amazon.com loaded");
		}

		//public void GoTo()
		//{
		//	IWebDriver driver = new ChromeDriver();
		//	driver.Url = "https://amazon.com";
		//}

	}
}
