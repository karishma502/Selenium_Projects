using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Projects
{
    class CssSellector
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello World");
            //Launch Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\HP\\Desktop\\c# notes\\selenium\\chromedriver_win32");

            //Maximize the Browser
            driver.Manage().Window.Maximize();
            //Launch Url
            driver.Url = ("https://www.google.co.in/");
            //driver.Url = "http://www.microsoft.com";
            //Search selenium in search box
            driver.FindElement(By.CssSelector("input.gLFyf")).SendKeys("Selenium");
            // Close the Browser
            //driver.Close();




        }
    }
}
