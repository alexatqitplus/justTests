using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace TestProject1
{
   


       public class Tests
        {
            IWebDriver driver;
            [SetUp]
            public void Setup()
            {
                FirefoxOptions op = new FirefoxOptions();
                //  WebDriverManager.Chromedriver().setup();
               // ChromeOptions options = new ChromeOptions();
              //  options.AddArguments("--no-sandbox");
             //   options.AddArguments("--disable-dev-shm-usage");
                  op.AddArguments("--no-sandbox");
             //   op.AddArguments("--disable-dev-shm-usage");
               
               op.AddArgument("--headless");
               // options.AddArgument("--headless");
               new DriverManager().SetUpDriver(new FirefoxConfig());
             //  new DriverManager().SetUpDriver(new ChromeConfig());
             //  driver = new ChromeDriver(options);//
               driver = new FirefoxDriver(op);

               // string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                ////  TestContext.Progress.WriteLine(Environment.CurrentDirectory);

                //driver = new ChromeDriver(path + @"/drivers/", options);

            }

            [Test]
            public void Test1()
            {
                driver.Navigate().GoToUrl("https://training.guardianims.com/QIMS/Landing");

                Assert.IsTrue(driver.FindElement(By.Id("gn-menu")).Displayed);
            }
        }
    
}
