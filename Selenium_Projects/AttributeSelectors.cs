using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Projects
{
    class AttributeSelectors
    {
        static void Main(string[] args)
        {
            //Assigmnet 2---- locate by name

            Console.WriteLine("Hello World");
            //Launch Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\HP\\Desktop\\c# notes\\selenium\\chromedriver_win32");
            //Maximize the Browser
            driver.Manage().Window.Maximize();
            //Launch Url
            driver.Url = ("https://www.google.co.in/");
            //Search selenium in search box
           // driver.FindElement(By.CssSelector("input[role='combobox']")).SendKeys("selenium");
            //driver.FindElement(By.CssSelector("input[role^='comb']")).SendKeys("selenium");
            //driver.FindElement(By.CssSelector("input[role*='bob']")).SendKeys("selenium");
            driver.FindElement(By.CssSelector("input[role$='box']")).SendKeys("selenium");
            // Close the Browser
            Thread.Sleep(3000);
            //driver.Close();
        }
    }
}
