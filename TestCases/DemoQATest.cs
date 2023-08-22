using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIToolQAApp.Drivers;
using UIToolQAApp.Pages;

namespace UIToolQAApp.TestCases
{
    public class DemoQATest :Driver
    {

        [Test]
        public void FormFill()
        {
            DemoQAPage demoQAPage = new DemoQAPage();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            _driver.Manage().Window.Maximize();
             demoQAPage.fillDetails();
        }

    }
}
