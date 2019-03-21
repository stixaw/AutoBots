using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonTests.Helpers
{
	public static class ElementHelper
	{

		public static void Hover(IWebDriver driver, IWebElement element)
		{
			Actions actions = new Actions(driver);
			actions.MoveToElement(element);
			actions.Build().Perform();
		}

		public static string GetElementInput(IWebElement element)
		{
			var input = element.GetProperty("value");
			Console.WriteLine(input);
			return input;

		}
	}
}
