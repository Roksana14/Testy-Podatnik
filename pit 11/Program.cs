
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
	static IWebElement szukajUrząd;
	static IWebElement id;
	static IWebElement textbox;
	static IWebElement urzędy;
	static IWebElement button;
	static IWebElement checkbox;


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
<<<<<<< HEAD
=======
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
>>>>>>> db5f900ab29f19c7cca20ff0e1ee39775890c311
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

		textbox = driver.FindElement(By.Name("reason"));
		textbox.Clear();
		textbox.SendKeys("KOREKTA");
		Thread.Sleep(2000);





		//Urzad Skarbowy
		//Sprawdzenie boxu tekstowego czy mozna cos wpisac

		//szukajUrząd = driver.FindElement(By.Name("SelectedOfficeString"));
		//szukajUrząd.SendKeys("Urząd Skarbowy w Jaworze");
		//Thread.Sleep(2000);
		//szukajUrząd.Clear();

		//test wybrania urzedu i sprawdzenie czy to samo sie wyswietlilo u gory i czy jest fajka zielona

		szukajUrząd = driver.FindElement(By.CssSelector("#TaxOfficesSelect"));
		for (int i = 1; i < 5; i++)
		{
			urzędy = driver.FindElement(By.CssSelector("#TaxOfficesSelect > option:nth-child(" + i + ")"));
			urzędy.Click();
			Thread.Sleep(2000);
			id = driver.FindElement(By.CssSelector("#selected_us"));
			if (id.Displayed)

			{
				Console.WriteLine("zaznaczony urząd " + urzędy.GetAttribute("value"));
			}
			else
			{
				Console.WriteLine("Brak wyswietlenia");
			}
			zielonaFajka = driver.FindElement(By.CssSelector("#USpipe"));
			if (zielonaFajka.Displayed)
			{
				Console.WriteLine("Pojawiła się zielona fajka");
			}
			else
			{
				Console.WriteLine("Nie pojawiła się zielona fajka");
			}
		}

		button = driver.FindElement(By.CssSelector("#forward_btn"));
		button.Click();

		//Druga strona

		//Wybor ilosci pit-11

		radioButton = driver.FindElement(By.Id("PIT11:-1"));
		radioButton.Click();
		Thread.Sleep(3000);
		for (int i = 1; i < 9; i++)
		{
			radioButton = driver.FindElement(By.Id("PIT11:" + i + ""));
			radioButton.Click();
			Console.WriteLine(radioButton.GetAttribute("checked"));
		}

		//czy podatnik uzyskal inne przychody niz uzyskane

		radioButton = driver.FindElement(By.Id("Przychody:Nie"));
		radioButton.Click();
		Console.WriteLine(radioButton.GetAttribute("checked"));

		radioButton = driver.FindElement(By.Id("Przychody:Tak"));
		radioButton.Click();
		Console.WriteLine(radioButton.GetAttribute("checked"));

		//inne przychody

		checkbox = driver.FindElement(By.CssSelector("Przychody3a DzialalnoscGospodarcza"));
		checkbox.Click();
		Console.WriteLine(checkbox.GetAttribute("value"));
		
		checkbox = driver.FindElement(By.Id("Przychody:RentyEmerytury"));
		checkbox.Click();
		checkbox.Click();
		checkbox = driver.FindElement(By.Id("Przychody:PapieryWartosciowe"));
		checkbox.Click();
		checkbox.Click();
		checkbox = driver.FindElement(By.Id("Przychody:RyczaltDzialalnosc"));
		checkbox.Click();
		checkbox.Click();
		checkbox = driver.FindElement(By.Id("Przychody:SprzedazNieruchomosciDo2009"));
		checkbox.Click();
		checkbox.Click();
		checkbox = driver.FindElement(By.Id("Przychody:SprzedazNieruchomosciOd2009"));
		checkbox.Click();
		checkbox.Click();
		checkbox = driver.FindElement(By.Id("Przychody:NajemDzierzawaOgolne"));
		checkbox.Click();
		checkbox.Click();
		checkbox = driver.FindElement(By.Id("Przychody:NajemDzierzawaRyczalt"));
		checkbox.Click();
		checkbox.Click();
		checkbox = driver.FindElement(By.Id("Przychody:DzialySpecjalne"));
		checkbox.Click();
		checkbox.Click();
		checkbox = driver.FindElement(By.Id("Przychody:MaloletnieDzieci"));
		checkbox.Click();
		checkbox.Click();
		checkbox = driver.FindElement(By.Id("Przychody:ZbycieRzeczy"));
		checkbox.Click();
		checkbox.Click();
		checkbox = driver.FindElement(By.Id("Przychody:InneZPIT8C"));
		checkbox.Click();
		checkbox.Click();
		checkbox = driver.FindElement(By.Id("Przychody:Inne"));
		checkbox.Click();
		checkbox.Click();
		checkbox = driver.FindElement(By.Id("Przychody:Zagranica"));
		checkbox.Click();
		checkbox.Click();









		Thread.Sleep(2000);

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




	}
}

