using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Projects
{
    class Locate_By_Link
    {
        static void Main(string[] args)
        {
            //Assignment 3 ---- LinkText

            Console.WriteLine("Hello World");
            //Launch Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\HP\\Desktop\\c# notes\\selenium\\chromedriver_win32");
            //Maximize the Browser
            driver.Manage().Window.Maximize();
            //Launch Url
            driver.Url = ("https://www.google.co.in/");
            //Open Link
            driver.FindElement(By.LinkText("Gmail")).Click();
            // Close the Browser
            // driver.Close();
        }

    }
}
