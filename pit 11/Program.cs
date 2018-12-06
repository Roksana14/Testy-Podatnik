
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Pit11
{

	static IWebDriver driver = new ChromeDriver();
	static IWebElement radioButton;
	static IWebElement zielonaFajka;
	static IWebElement informator;


	static void Main()
	{

		string url = "https://pit.podatnik.info/Home/WizFormMode";

		driver.Navigate().GoToUrl(url);

		//indywidualnie
		radioButton = driver.FindElement(By.CssSelector("#rd1"));
		radioButton.Click();
		Console.WriteLine(radioButton.GetAttribute("value"));
		zielonaFajka = driver.FindElement(By.CssSelector("#rd1pipe"));
		if (zielonaFajka.Displayed)
		{
			Console.WriteLine("Pojawiłą się zielona fajka");
		}
		else
		{
			Console.WriteLine("Nie pojawiła się zielona fajka");
		}
		//wspolnie z malzonkiem
		radioButton = driver.FindElement(By.CssSelector("#rd2"));
		radioButton.Click();
		Console.WriteLine(radioButton.GetAttribute("value"));
		zielonaFajka = driver.FindElement(By.CssSelector("#rd2pipe"));
		if (zielonaFajka.Displayed)
		{
			Console.WriteLine("Pojawiłą się zielona fajka");
		}
		else
		{
			Console.WriteLine("Nie pojawiła się zielona fajka");
		}
		informator = driver.FindElement(By.CssSelector("#frame_1_1 > fieldset:nth-child(2) > div:nth-child(3) > a > img"));
		informator.Click();
		if (informator.Enabled)
		{
			Console.WriteLine("Okienko z informacja się otworzyło");
			informator = driver.FindElement(By.CssSelector("body > div.popper_overlay > div > a > img"));
			informator.Click();
		}
		else
		{
			Console.WriteLine("NIE OTWIERA SIĘ");
		}
		
		//wspolnie ze zmarlym malzonkiem
		radioButton = driver.FindElement(By.CssSelector("#rd3"));
		radioButton.Click();
		Console.WriteLine(radioButton.GetAttribute("value"));
		zielonaFajka = driver.FindElement(By.CssSelector("#rd3pipe"));
		if (zielonaFajka.Displayed)
		{
			Console.WriteLine("Pojawiłą się zielona fajka");
		}
		else
		{
			Console.WriteLine("Nie pojawiła się zielona fajka");
		}

		//w sposob przewidziany dla ....
		radioButton = driver.FindElement(By.CssSelector("#rd4"));
		radioButton.Click();
		Console.WriteLine(radioButton.GetAttribute("value"));
		zielonaFajka = driver.FindElement(By.CssSelector("#rd4pipe"));
		if (zielonaFajka.Displayed)
		{
			Console.WriteLine("Pojawiłą się zielona fajka");
		}
		else
		{
			Console.WriteLine("Nie pojawiła się zielona fajka");
		}




		Thread.Sleep(20000);
		driver.Quit();



	}
}

