
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;

class Program
{
	static IWebDriver driver = new ChromeDriver();
	static IWebElement login;
	static IWebElement password;
	static IWebElement zalogowanie;
	static Actions bot = new Actions(driver);
	static void Main()
	{
		string url = "https://www.podatnik.info/login";
		

		driver.Navigate().GoToUrl(url);
		driver.Manage().Window.Maximize();

		login = driver.FindElement(By.Name("login"));

		login.SendKeys("testes1996.1996@wp.pl");

		password = driver.FindElement(By.Name("password"));

		password.SendKeys("tester1");

		zalogowanie = driver.FindElement(By.ClassName("cta"));

		zalogowanie.Click();

		bot.SendKeys(Keys.PageDown).Build().Perform();

		bot.Click(driver.FindElement(By.ClassName("ws-form-print")));



		Thread.Sleep(5000);

		driver.Quit();

	}
}

