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
    class Multiselect
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //Launch Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\HP\\Desktop\\c# notes\\selenium\\chromedriver_win32");
            //Maximize the Browser
            driver.Manage().Window.Maximize();
            //Launch Url
            driver.Url = ("https://formstone.it/components/dropdown/demo/");
            IWebElement select_box = driver.FindElement(By.Name("demo_multiple"));
            SelectElement select = new SelectElement(select_box);
            Boolean stutus_multiselct = select.IsMultiple;
            Console.WriteLine(stutus_multiselct);
            select.SelectByIndex(1);
            select.SelectByValue("2");
            select.SelectByText("Two");
            //select.SelectByText("One");
        }

    }
}
