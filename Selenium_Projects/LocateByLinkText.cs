using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Projects
{
    class LocateByLinkText
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
            //Open Link
            //driver.Url = ("https://web.whatsapp.com/");
            IReadOnlyCollection<IWebElement> links = driver.FindElements(By.TagName("style"));
            Console.WriteLine(links.Count);
            foreach (IWebElement link in links)
            {
                Console.WriteLine(link.Text);
            }
            // Close the Browser
            // driver.Close();
        }

    }
}

