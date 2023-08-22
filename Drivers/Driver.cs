using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;

namespace UIToolQAApp.Drivers
{
    public class Driver
    {
        public static IWebDriver _driver;

        [SetUp]
        public void initScript()
        {
            // auto update chrome version 
            new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeConfig options = new ChromeConfig();
            _driver = new ChromeDriver();
        }
        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }
    }
}
