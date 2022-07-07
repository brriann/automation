using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace selenium;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        using (var driver = new ChromeDriver("/PATH/TO/CHROMEDRIVER"))
        {
            driver.Navigate().GoToUrl("STARTING_URL");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement loginPageLink = wait.Until(e => e.FindElement(By.CssSelector("#loginLink")));
            loginPageLink.Click();
            
            IWebElement emailTextField = wait.Until(e => e.FindElement(By.CssSelector("#Email")));
            emailTextField.SendKeys("TEST_EMAIL");

            IWebElement passwordTextField = wait.Until(e => e.FindElement(By.CssSelector("#Password")));
            passwordTextField.SendKeys("TEST_PASSWORD");

            IWebElement loginButton = wait.Until(e => e.FindElement(By.CssSelector("#loginForm .btn-default:nth-of-type(1)")));
            loginButton.Click();
        }
    }
}