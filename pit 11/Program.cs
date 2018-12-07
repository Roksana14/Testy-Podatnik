
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
		Thread.Sleep(200);
		Console.WriteLine(radioButton.GetAttribute("value"));
		zielonaFajka = driver.FindElement(By.CssSelector("#rd1pipe"));
		if (zielonaFajka.Displayed)
		{
			Console.WriteLine("Pojawiła się zielona fajka");
		}
		else
		{
			Console.WriteLine("Nie pojawiła się zielona fajka");
		}
		//wspolnie z malzonkiem
		radioButton = driver.FindElement(By.CssSelector("#rd2"));
		radioButton.Click();
		Thread.Sleep(200);
		Console.WriteLine(radioButton.GetAttribute("value"));
		zielonaFajka = driver.FindElement(By.CssSelector("#rd2pipe"));
		if (zielonaFajka.Displayed)
		{
			Console.WriteLine("Pojawiła się zielona fajka");
		}
		else
		{
			Console.WriteLine("Nie pojawiła się zielona fajka");
		}
		informator = driver.FindElement(By.CssSelector("#frame_1_1 > fieldset:nth-child(2) > div:nth-child(3) > a > img"));
		informator.Click();
		Thread.Sleep(200);
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
		Thread.Sleep(200);
		Console.WriteLine(radioButton.GetAttribute("value"));
		zielonaFajka = driver.FindElement(By.CssSelector("#rd3pipe"));
		if (zielonaFajka.Displayed)
		{
			Console.WriteLine("Pojawiła się zielona fajka");
		}
		else
		{
			Console.WriteLine("Nie pojawiła się zielona fajka");
		}
		informator = driver.FindElement(By.CssSelector("fieldset.form_group:nth-child(2) > div:nth-child(4) > a:nth-child(3) > img:nth-child(1)"));
		informator.Click();
		Thread.Sleep(2000);
		if (informator.Enabled)
		{
			Console.WriteLine("Okienko z infromacja otworzyło się");
			informator = driver.FindElement(By.CssSelector(".s_close_btn > img:nth-child(1)"));
			informator.Click();
		}
		else
		{
			Console.WriteLine("Brak dostępu");
		}
		//w sposob przewidziany dla ....
		radioButton = driver.FindElement(By.CssSelector("#rd4"));
		radioButton.Click();
		Thread.Sleep(200);
		Console.WriteLine(radioButton.GetAttribute("value"));
		zielonaFajka = driver.FindElement(By.CssSelector("#rd4pipe"));
		if (zielonaFajka.Displayed)
		{
			Console.WriteLine("Pojawiła się zielona fajka");
		}
		else
		{
			Console.WriteLine("Nie pojawiła się zielona fajka");
		}
		informator = driver.FindElement(By.CssSelector("fieldset.form_group:nth-child(2) > div:nth-child(4) > a:nth-child(3) > img:nth-child(1)"));
		informator.Click();
		if (informator.Enabled)
		{
			Console.WriteLine("Okienko z informacją otworzyło się");
			informator = driver.FindElement(By.CssSelector(".s_close_btn > img:nth-child(1)"));
			informator.Click();

		}
		else
		{
			Console.WriteLine("Brak dostępu");
		}


		//czy chcesz zlozyc zeznanie

		radioButton = driver.FindElement(By.CssSelector("#zeznanie"));
		radioButton.Click();
		Thread.Sleep(2000);
		Console.WriteLine("zlozenie zeznania");
		zielonaFajka = driver.FindElement(By.CssSelector("#correctPipe"));
		if (zielonaFajka.Displayed)
		{
			Console.WriteLine("Pojawiła się zielona fajka");
		}
		else
		{
			Console.WriteLine("Nie pojawiła się zielona fajka");
		}
		
		// zlozenie korekty

		radioButton = driver.FindElement(By.CssSelector("#correct"));
		radioButton.Click();
		Thread.Sleep(2000);
		Console.WriteLine("zlozenie korekty zeznania");
		zielonaFajka = driver.FindElement(By.CssSelector("#correctPipe"));
		if (zielonaFajka.Displayed)
		{
			Console.WriteLine("Pojawiła się zielona fajka");
		}
		else
		{
			Console.WriteLine("Nie pojawila sie zielona fajka");
		}
		informator = driver.FindElement(By.CssSelector("fieldset.form_group:nth-child(3) > div:nth-child(2) > a:nth-child(5) > img:nth-child(1)"));
		informator.Click();
		if (informator.Enabled)
		{
			Console.WriteLine("Pojawiła się informacja");
			informator = driver.FindElement(By.CssSelector(".s_close_btn > img:nth-child(1)"));
			informator.Click();
		}
		else
		{
			Console.WriteLine("Brak dostępu");
		}

		Thread.Sleep(20000);
		driver.Quit();



	}
}

