using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Projects
{
    class Signup_By_Id
    {
        static void Main(string[] args)
        {
            //assignment 4--- locate by id

            Console.WriteLine("Hello World");
            //Launch Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\HP\\Desktop\\c# notes\\selenium\\chromedriver_win32");
            //Maximize the Browser
            driver.Manage().Window.Maximize();
            //Launch Url
            driver.Url ="https://accounts.google.com/signup/v2/webcreateaccount?continue=https%3A%2F%2Fmyaccount.google.com%3Futm_source%3Daccount-marketing-page%26utm_medium%3Dcreate-account-button&flowName=GlifWebSignIn&flowEntry=SignUp";
            //write Username
            driver.FindElement(By.Id("firstName")).SendKeys("Karishma");
            driver.FindElement(By.Id("lastName")).SendKeys("Kate");
            //driver.FindElement(By.CssSelector("#firstName")).SendKeys("karishma");
            //driver.FindElement(By.ClassName("VfPpkd-vQzf8d")).Click();
            // Close the Browser
             //driver.Close();
        }
    }
}
