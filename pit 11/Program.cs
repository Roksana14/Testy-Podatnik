using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
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
	static IWebElement walidator;
	private static object losowaLiczba;

	static void Main()
	{

		string url = "https://pit.podatnik.info/Home/WizFormMode";

		driver.Navigate().GoToUrl(url);
		driver.Manage().Window.Maximize();

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
		// wprowadzic zaczytywaniw co jest w textboxie
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
		//scroll down

		Actions builder = new Actions(driver);
		builder.SendKeys(Keys.PageDown).Build().Perform();

		Thread.Sleep(1000);
		checkbox = driver.FindElement(By.Id("Przychody:DzialalnoscGospodarcza"));
		checkbox.Click();
		Thread.Sleep(1000);
		Console.WriteLine(checkbox.GetAttribute("checked"));
		informator = driver.FindElement(By.Id("hPrzychody:DzialalnoscGospodarcza"));
		informator.Click();
		Thread.Sleep(1000);
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
		checkbox.Click();
		

		checkbox = driver.FindElement(By.Id("Przychody:RentyEmerytury"));
		checkbox.Click();
		Thread.Sleep(1000);
		Console.WriteLine(checkbox.GetAttribute("checked"));
		informator = driver.FindElement(By.Id("hPrzychody:RentyEmerytury"));
		informator.Click();
		Thread.Sleep(1000);
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
		checkbox.Click();
		
		

		checkbox = driver.FindElement(By.Id("Przychody:PapieryWartosciowe"));
		checkbox.Click();
		Thread.Sleep(1000);
		Console.WriteLine(checkbox.GetAttribute("checked"));
		informator = driver.FindElement(By.Id("hPrzychody:PapieryWartosciowe"));
		informator.Click();
		Thread.Sleep(1000);
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
		checkbox.Click();
		
		

		checkbox = driver.FindElement(By.Id("Przychody:RyczaltDzialalnosc"));
		checkbox.Click();
		Thread.Sleep(1000);
		Console.WriteLine(checkbox.GetAttribute("checked"));
		informator = driver.FindElement(By.Id("hPrzychody:RyczaltDzialalnosc"));
		informator.Click();
		Thread.Sleep(1000);
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
		checkbox.Click();
		


		checkbox = driver.FindElement(By.Id("Przychody:SprzedazNieruchomosciDo2009"));
		checkbox.Click();
		Thread.Sleep(1000);
		Console.WriteLine(checkbox.GetAttribute("checked"));
		informator = driver.FindElement(By.Id("hPrzychody:SprzedazNieruchomosciDo2009"));
		informator.Click();
		Thread.Sleep(1000);
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
		checkbox.Click();


		Thread.Sleep(1000);
		checkbox = driver.FindElement(By.Id("Przychody:SprzedazNieruchomosciOd2009"));
		checkbox.Click();
		Thread.Sleep(1000);
		Console.WriteLine(checkbox.GetAttribute("checked"));
		informator = driver.FindElement(By.Id("hPrzychody:SprzedazNieruchomosciOd2009"));
		informator.Click();
		Thread.Sleep(1000);
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
		checkbox.Click();
		
		

		checkbox = driver.FindElement(By.Id("Przychody:NajemDzierzawaOgolne"));
		checkbox.Click();
		Thread.Sleep(1000);
		Console.WriteLine(checkbox.GetAttribute("checked"));
		informator = driver.FindElement(By.Id("hPrzychody:NajemDzierzawaOgolne"));
		informator.Click();
		Thread.Sleep(1000);
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
		checkbox.Click();

		Thread.Sleep(1000);
		checkbox = driver.FindElement(By.Id("Przychody:NajemDzierzawaRyczalt"));
		checkbox.Click();
		Thread.Sleep(1000);
		Console.WriteLine(checkbox.GetAttribute("checked"));
		informator = driver.FindElement(By.Id("hPrzychody:NajemDzierzawaRyczalt"));
		informator.Click();
		Thread.Sleep(1000);
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
		checkbox.Click();
		
		

		checkbox = driver.FindElement(By.Id("Przychody:DzialySpecjalne"));
		checkbox.Click();
		Thread.Sleep(1000);
		Console.WriteLine(checkbox.GetAttribute("checked"));
		informator = driver.FindElement(By.Id("hPrzychody:DzialySpecjalne"));
		informator.Click();
		Thread.Sleep(1000);
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
		checkbox.Click();
		Thread.Sleep(2000);
		

		checkbox = driver.FindElement(By.Id("Przychody:MaloletnieDzieci"));
		checkbox.Click();
		Thread.Sleep(1000);
		Console.WriteLine(checkbox.GetAttribute("checked"));
		informator = driver.FindElement(By.Id("hPrzychody:MaloletnieDzieci"));
		informator.Click();
		Thread.Sleep(1000);
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
		checkbox.Click();
		Thread.Sleep(2000);
		

		checkbox = driver.FindElement(By.Id("Przychody:ZbycieRzeczy"));
		checkbox.Click();
		Thread.Sleep(1000);
		Console.WriteLine(checkbox.GetAttribute("checked"));
		checkbox.Click();
		Thread.Sleep(2000);
		
		checkbox = driver.FindElement(By.Id("Przychody:InneZPIT8C"));
		checkbox.Click();
		Thread.Sleep(1000);
		Console.WriteLine(checkbox.GetAttribute("checked"));

		informator = driver.FindElement(By.Id("hPrzychody:InneZPIT8C"));
		informator.Click();
		Thread.Sleep(1000);
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
		checkbox.Click();
		Thread.Sleep(2000);

		checkbox = driver.FindElement(By.Id("Przychody:Inne"));
		checkbox.Click();
		Thread.Sleep(1000);
		Console.WriteLine(checkbox.GetAttribute("checked"));
		informator = driver.FindElement(By.Id("hPrzychody:Inne"));
		informator.Click();
		Thread.Sleep(1000);
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
		checkbox.Click();
		Thread.Sleep(2000);

		checkbox = driver.FindElement(By.Id("Przychody:Zagranica"));
		checkbox.Click();
		Thread.Sleep(1000);
		Console.WriteLine(checkbox.GetAttribute("checked"));
		informator = driver.FindElement(By.Id("hPrzychody:Zagranica"));
		informator.Click();
		Thread.Sleep(1000);
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
		checkbox.Click();
		Thread.Sleep(2000);

		checkbox = driver.FindElement(By.Id("ZmianaDanychIdentyfikacyjnych:Tak"));
		checkbox.Click();
		Thread.Sleep(2000);
		checkbox.Click();

		

		//ZAZNACZAM JESZCZE RAZ: czy podatnik uzyskal inne przychody niz uzyskane

		radioButton = driver.FindElement(By.Id("Przychody:Nie"));
		radioButton.Click();
		Console.WriteLine(radioButton.GetAttribute("checked"));

		radioButton = driver.FindElement(By.Id("PIT11:1"));
		radioButton.Click();
		Thread.Sleep(2000);

		button = driver.FindElement(By.CssSelector("#forward_btn"));
		button.Click();


		//trzecia strona
		//zaznacz odliczenia dotyczace podatnika


		//ULGA PRORODZINNA
		checkbox = driver.FindElement(By.Id("Odliczenia:UlgaProrodzinna"));
		checkbox.Click();
		Thread.Sleep(2000);
		checkbox.Click();

		informator = driver.FindElement(By.Id("hOdliczenia:UlgaProrodzinna"));
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

		


		//INTERNET
		checkbox = driver.FindElement(By.Id("Odliczenia:Internet"));
		checkbox.Click();
		Thread.Sleep(2000);
		checkbox.Click();

		informator = driver.FindElement(By.Id("hOdliczenia:Internet"));
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
	
		


		//IKZE
		checkbox = driver.FindElement(By.Id("Odliczenia:IKZE"));
		checkbox.Click();
		Thread.Sleep(2000);
		checkbox.Click();

		informator = driver.FindElement(By.Id("hOdliczenia:IKZE"));
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
	
		
		//ULGA ODSETKOWA

		checkbox = driver.FindElement(By.Id("Odliczenia:OdsetkowaKontynuacja"));
		checkbox.Click();
		Thread.Sleep(2000);
		checkbox.Click();

		informator = driver.FindElement(By.Id("hOdliczenia:OdsetkowaKontynuacja"));
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
	
	

		//ULGA ODSETKOWA 2

		checkbox = driver.FindElement(By.Id("Odliczenia:OdsetkowaKontynuacja"));
		checkbox.Click();
		Thread.Sleep(2000);
		checkbox.Click();

		informator = driver.FindElement(By.Id("hOdliczenia:OdsetkowaKontynuacja"));
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
		
		

		//DAROWIZNY

		checkbox = driver.FindElement(By.Id("Odliczenia:Darowizny"));
		checkbox.Click();
		Thread.Sleep(2000);
		checkbox.Click();

		informator = driver.FindElement(By.Id("hOdliczenia:Darowizny"));
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
		
		

		//REHABILITACJA

		checkbox = driver.FindElement(By.Id("Odliczenia:Rehabilitacja"));
		checkbox.Click();
		Thread.Sleep(2000);
		checkbox.Click();

		informator = driver.FindElement(By.Id("hOdliczenia:Rehabilitacja"));
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
	

		//zwrot nienależnie pobranych świadczeń

		checkbox = driver.FindElement(By.Id("Odliczenia:ZwrotSwiadczen"));
		checkbox.Click();
		Thread.Sleep(2000);
		checkbox.Click();

		informator = driver.FindElement(By.Id("hOdliczenia:ZwrotSwiadczen"));
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
	

		//ulga na wyszkolenie uczniów 

		checkbox = driver.FindElement(By.Id("Odliczenia:WyszkolenieUczniow"));
		checkbox.Click();
		Thread.Sleep(2000);
		checkbox.Click();

		informator = driver.FindElement(By.Id("hOdliczenia:WyszkolenieUczniow"));
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
	
		
		//ulga na pomoc domową

		checkbox = driver.FindElement(By.Id("Odliczenia:PomocDomowa"));
		checkbox.Click();
		Thread.Sleep(2000);
		checkbox.Click();

		informator = driver.FindElement(By.Id("hOdliczenia:PomocDomowa"));
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
		
		

		//inne ulgi od dochodu

		checkbox = driver.FindElement(By.Id("Odliczenia:PomocDomowa"));
		checkbox.Click();
		Thread.Sleep(2000);
		checkbox.Click();
		

		//inne ulgi od podatku

		checkbox = driver.FindElement(By.Id("Odliczenia:InneOdPodatku"));
		checkbox.Click();
		Thread.Sleep(2000);
		checkbox.Click();
		
		button = driver.FindElement(By.CssSelector("#forward_btn"));
		button.Click();

		//Formularz pit 11
		//tu chcialabym zeby sprawdzic czy wyswietla sie naglowek
		id = driver.FindElement(By.CssSelector("#infoBoxContent > span:nth-child(1)"));
		Console.WriteLine(id.Text);
		

		//wpisanie wartosci liczbowej

		for (int i = 29; i < 76; i++)
		{
			if (i == 39) // omijam niedziałające pola aby przejsc droge, trzeba poprawic
			{
				i = 43;
			}
			textbox = driver.FindElement(By.Name("" + i + ""));
			textbox.SendKeys("1234,12");
			Console.WriteLine(textbox.GetAttribute("value"));
			textbox.Clear();
		}

		//wpisanie kropki
		Thread.Sleep(2000);
		builder.SendKeys(Keys.PageUp).Build().Perform();
		for (int i = 29; i < 76; i++)
		{
			if (i == 39) // omijam niedziałające pola aby przejsc droge, trzeba poprawic
			{
				i = 43;
				builder.SendKeys(Keys.PageDown).Build().Perform();
			}
			
			textbox = driver.FindElement(By.Name("" + i + ""));
			textbox.SendKeys(".");
			Console.WriteLine(textbox.GetAttribute("value"));
			Thread.Sleep(2000);
			
		}

		// sprawdzenie walidatora
		Thread.Sleep(2000);
		builder.SendKeys(Keys.PageUp).Build().Perform();
		for (int i = 29; i < 76; i++)
		{
			if (i == 39) // omijam niedziałające pola aby przejsc droge, trzeba poprawic
			{
				i = 43;
				builder.SendKeys(Keys.PageDown).Build().Perform();
			}

			Thread.Sleep(2000);
			walidator = driver.FindElement(By.Id("V" + i + ""));
			walidator.Click();
			Thread.Sleep(2000);
			walidator = driver.FindElement(By.ClassName("popper_body"));
			Console.WriteLine(walidator.Text);
			walidator = driver.FindElement(By.ClassName("s_close_btn"));
			walidator.Click();
			Thread.Sleep(2000);
		}

		//usuwanie walidatora
		Thread.Sleep(2000);
		builder.SendKeys(Keys.PageUp).Build().Perform();
		for (int i = 29; i < 76; i++)
		{
			if (i == 39) // omijam niedziałające pola aby przejsc droge, trzeba poprawic
			{
				i = 43;
				builder.SendKeys(Keys.PageDown).Build().Perform();
			}
			
			textbox = driver.FindElement(By.Name("" + i + ""));
			textbox.Clear();
		}

		//kolejna strona

		button = driver.FindElement(By.CssSelector("#forward_btn"));
		button.Click();

		

		
		textbox = driver.FindElement(By.ClassName("wizardInput"));
		Random randomizer = new Random();
		int liczbaLosowa;
		liczbaLosowa = randomizer.Next(2000);
		textbox.SendKeys(liczbaLosowa.ToString());
		Console.WriteLine(textbox.Text);

		//kolejna strona

		button = driver.FindElement(By.CssSelector("#forward_btn"));
		button.Click();

		textbox = driver.FindElement(By.Id("txbPierwszeImie"));















		//walidator = driver.FindElement(By.ClassName("popper_text error"));
		//Console.WriteLine(walidator.Text);
		//builder.MoveToElement(driver.FindElement(By.CssSelector("#V"+ i +" > img"))).Click();





	}
	class losuj
	{
	}
}

