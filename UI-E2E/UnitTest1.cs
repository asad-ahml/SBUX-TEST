using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UI_E2E
{
    [TestClass]
    public class UnitTest1
    {
        ChromeDriver driver;

       // [TestMethod]
        public void VerifyPageTitle()
        {
 
            ChromeDriver driver = new ChromeDriver(@"C:\Users\AHML\source\repos\SBUX-E2E\MSTESTUI");
            driver.Navigate().GoToUrl("https://www.starbucks.com/");
            var actualPageTitle = driver.Title;
            var expectedPageTitle = "Starbucks Coffee Company";
            Assert.IsTrue(actualPageTitle.Equals(expectedPageTitle),"Title Does Not Match");
            driver.Close();
            driver.Quit();
        }

        //[TestMethod]
        public void VerifyPageUrl()
        {
            ChromeDriver driver = new ChromeDriver(@"C:\Users\AHML\source\repos\SBUX-E2E\MSTESTUI");
            driver.Navigate().GoToUrl("https://www.starbucks.com/");
            string actualUrl = driver.Url;
            string expectedUrl = "https://www.starbucks.com/";
            Assert.IsTrue(actualUrl.Equals(expectedUrl), "URL Doesnt Match");
            driver.Close();
            driver.Quit();
        }

        //[TestMethod]
        public void WhenClickSignIn_ThenVerifyLinkForgotYourUserName()
        {
            ChromeDriver driver = new ChromeDriver(@"C:\Users\AHML\source\repos\SBUX-E2E\MSTESTUI");
            driver.Navigate().GoToUrl("https://www.starbucks.com/");
            driver.FindElement(By.XPath("//*[@class='sb-globalNav__links ']//a[text()='Sign in']")).Click();
            var actualForgotYourUserNameText = driver.FindElement(By.XPath("//button[@data-e2e='forgotUsernameLink']")).Text;
            var expectedForgotYourUserNameText = "Forgot your username?";
            Assert.IsTrue(actualForgotYourUserNameText.Equals(expectedForgotYourUserNameText), "Forgot Your User Name Not Found on Page");
            driver.Close();
            driver.Quit();
        }

        //[TestMethod]
        public void WhenClickSignIn_ThenVerifyLinkForgotYourPassword()
        {
            ChromeDriver driver = new ChromeDriver(@"C:\Users\AHML\source\repos\SBUX-E2E\MSTESTUI");
            driver.Navigate().GoToUrl("https://www.starbucks.com/");
            driver.FindElement(By.XPath("//*[@class='sb-globalNav__links ']//a[text()='Sign in']")).Click();
            var actualForgotYourPassword = driver.FindElement(By.XPath("//a[@data-e2e='forgotPasswordLink']")).Text;
            var expectedForgotYourPassword = "Forgot your password?";
            Assert.IsTrue(actualForgotYourPassword.Equals(expectedForgotYourPassword), "Forgot Your Password Link No Found on Page");
            driver.Close();
            driver.Quit();
        }

        //[TestMethod]
        public void VerifyOurCoffeeLink()
        {
            ChromeDriver driver = new ChromeDriver(@"C:\Users\AHML\source\repos\SBUX-E2E\MSTESTUI");
            driver.Navigate().GoToUrl("https://www.starbucks.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement link = driver.FindElement(By.XPath("//*[@id='caretExpander1']//a[text()='Our Coffee']"));
            Assert.IsNotNull(link, "The link Our Cofee was found");
            driver.Close();
            driver.Quit();
            //IWebElement link = driver.FindElement(By.XPath("//*[@id='caretExpander1']")).FindElement(By.LinkText("Our Coffee"));
        }

        //[TestMethod]
        public void WhenUserEntersLoginId()
        {
            ChromeDriver driver = new ChromeDriver(@"C:\Users\AHML\source\repos\SBUX-E2E\MSTESTUI");
            driver.Navigate().GoToUrl("https://www.starbucks.com/");
            driver.FindElement(By.XPath("//*[@class='sb-globalNav__links ']//a[text()='Sign in']")).Click();
            driver.FindElement(By.XPath("//input[@id='username']")).SendKeys("asad.ahml@gmail.com");
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("Starbucks24#");
            driver.FindElement(By.XPath("//button[@data-e2e='signInButton']")).Click();
            driver.Close();
            driver.Quit();
        }

        [TestMethod]

        public void WhenUserAddsAnItemToShoppingBag()
        {
            ChromeDriver driver = new ChromeDriver(@"C:\Users\AHML\source\repos\SBUX-E2E\MSTESTUI");
            driver.Navigate().GoToUrl("https://www.starbucks.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.FindElement(By.XPath("//*[@class='sb-globalNav__links ']//a[text()='Sign in']")).Click();
            driver.FindElement(By.XPath("//input[@id='username']")).SendKeys("asad.ahml@gmail.com");
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("Starbucks24#");            
            driver.FindElement(By.XPath("//button[@data-e2e='signInButton']")).Click();
            driver.FindElement(By.XPath("//a[text()='Menu']")).Click();
            driver.FindElement(By.XPath("//*[@data-e2e='Hot Coffees']")).Click();
            driver.FindElement(By.XPath("//*[@data-e2e='Pike Place® Roast']")).Click();
            driver.FindElement(By.XPath("//*[@data-e2e='add-to-order-button']")).Click();
            //driver.FindElement(By.XPath("//a[text()='Menu']")).Click();
            //driver.FindElement(By.XPath("//*[text()='Food']/following-sibling::ul//*[text()='Bakery']")).Click();
            driver.Close();
            driver.Quit();
   
        }
        


        


        //[TestInitialize] //annotation or binding or attributes
        //public  void TearDown()
        //{
        //    driver.Close();
        //    driver.Quit();
        //}
        //[TestCleanup]
        //public  void SetUp()
        //{
        //     driver = new ChromeDriver(@"C:\Users\AHML\source\repos\SBUX-E2E\MSTESTUI");//Launching the browser
        //}
    }
}

