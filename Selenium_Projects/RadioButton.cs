using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Projects
{
    class RadioButton
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //Launch Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\HP\\Desktop\\c# notes\\selenium\\chromedriver_win32");
            //Maximize the Browser
            driver.Manage().Window.Maximize();
            //Launch Url
            driver.Url = "https://www.seleniumeasy.com/test/basic-radiobutton-demo.html";
            IReadOnlyCollection<IWebElement> Radiobtn = driver.FindElements(By.Name("optradio"));
            Radiobtn.[1].click();
            Radiobtn.[1].click();
           
           
        }

    }
}
