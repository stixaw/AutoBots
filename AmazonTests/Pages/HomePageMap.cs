using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonTests.Pages
{

	public class HomePageMap
	{
		readonly IWebDriver Driver;

		public HomePageMap(IWebDriver driver)
		{
			Driver = driver;
		}

		public IWebElement HomePageSearchBar => Driver.FindElement(By.Id("twotabsearchtextbox"));
		public IWebElement HomePageSearchBarDropDownList => Driver.FindElement(By.Id("searchDropdownBox"));

	}
}
