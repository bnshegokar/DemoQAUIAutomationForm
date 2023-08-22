using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIToolQAApp.Drivers;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;

namespace UIToolQAApp.Pages
{
    public class DemoQAPage : Driver
    {
        [FindsBy(How = How.Id, Using = "firstName")]
        private IWebElement firstName;

        [FindsBy(How = How.Id, Using = "lastName")]
        private IWebElement lastName;

        [FindsBy(How = How.Id, Using = "userEmail")]
        public IWebElement emailid;

        [FindsBy(How = How.XPath, Using = "//input[@id=\"gender-radio-1\"]")]
        public IWebElement gender;

        [FindsBy(How = How.Id, Using = "userNumber")]
        public IWebElement mobilenumber;

        [FindsBy(How = How.Id, Using = "dateOfBirthInput")]
        public IWebElement DOB;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"dateOfBirth\"]/div[2]/div[2]/div/div/div[2]/div[2]/div[4]/div[3]")]
        public IWebElement DateSelected;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[2]/div[2]/div[2]/form/div[6]/div[2]/div/div/div[1]")]
        public IWebElement Subject;
        [FindsBy(How = How.Id, Using = "hobbies-checkbox-1")]
        public IWebElement Ehobbies;

        [FindsBy(How = How.Id, Using = "uploadPicture")]
        public IWebElement uploadFil;

        [FindsBy(How = How.Id, Using = "currentAddress")]
        public IWebElement currentAdd;

        [FindsBy(How = How.Id, Using = "react-select-3-input")]
        public IWebElement Sates;
        [FindsBy(How = How.Id, Using = "react-select-4-input")]
        public IWebElement Citys;

        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement btnsubmit;

        [FindsBy(How = How.Id, Using = "uploadPicture")]
        public IWebElement uploadPic;

        public DemoQAPage()
        {
            PageFactory.InitElements(_driver, this);
        }
        public void fillDetails()
        {
            firstName.SendKeys("Nilesh");
            lastName.SendKeys("shegokar");
            emailid.SendKeys("bnshegokar@gmail.com");
            Actions action = new Actions(_driver);
            action.MoveToElement(gender).Click().Perform();           
            mobilenumber.SendKeys("9822688817");
            DOB.Click();
            Thread.Sleep(1000);
           // DateSelected.Click();
            action.MoveToElement(DateSelected).Click().Perform();
            Subject.SendKeys("maths and English");
            Ehobbies.Click();
            uploadPic.SendKeys("C:/Users/Nilesh/Desktop/upload.png");
            //IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            //js.ExecuteScript("document.getElementById('dateOfBirthInput').setAttribute('value', '22 Aug 2023')");
            // DOB.SendKeys("22 Aug 2023");
            currentAdd.SendKeys("BHEL Hyderabad");
            Sates.SendKeys("Telangana");
            Citys.SendKeys("Hyderabad");
            // Click on Submit button 
            btnsubmit.Click();
        }
    }
}
