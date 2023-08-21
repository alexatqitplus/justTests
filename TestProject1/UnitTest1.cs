using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;


namespace TestProject1
{
   


       public class Tests
        {
            IWebDriver driver;
            [SetUp]
            public void Setup()
            {
                //  WebDriverManager.Chromedriver().setup();
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--no-sandbox");
                options.AddArguments("--disable-dev-shm-usage");
                options.AddArgument("--headless");
               // new DriverManager().SetUpDriver(new WebDriverManager.DriverConfigs.Impl.ChromeConfig());
               // driver = new ChromeDriver(options);

                string path = Directory.GetParent(Environment.CurrentDirectory).FullName;
                ////  TestContext.Progress.WriteLine(Environment.CurrentDirectory);

                driver = new ChromeDriver(path + @"\drivers\", options);

            }

            [Test]
            public void Test1()
            {
                driver.Navigate().GoToUrl("https://training.guardianims.com/QIMS/Landing");

                Assert.IsTrue(driver.FindElement(By.Id("gn-menu")).Displayed);
            }
        }
    
}