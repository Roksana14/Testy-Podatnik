
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class Program
{
	static IWebDriver driver = new ChromeDriver();
	static IWebElement login;
	static IWebElement password;
	static IWebElement zalogowanie;
	static void Main()
	{
		string url = "https://www.podatnik.info/login";
		

		driver.Navigate().GoToUrl(url);

		login = driver.FindElement(By.Name("login"));

		login.SendKeys("testes1996.1996@wp.pl");

		password = driver.FindElement(By.Name("password"));

		password.SendKeys("tester1");

		zalogowanie = driver.FindElement(By.ClassName("cta"));

		zalogowanie.Click();

		Thread.Sleep(5000);

		driver.Quit();

	}
}

