using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Projects
{
    class Assigmnet_1
    {
        static void Main(string[] args)
        {
            // Assignment 1 -----open browesr and maximize screen

            Console.WriteLine("Hello World");
            //Launch Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\HP\\Desktop\\c# notes\\selenium\\chromedriver_win32");
            //Maximize the Browser
            driver.Manage().Window.Maximize();
            //Launch Url
            driver.Url=("https://www.google.co.in/");
            //Search selenium in search box
          
            // Close the Browser
            driver.Close();

            

           
        }
    }
}
