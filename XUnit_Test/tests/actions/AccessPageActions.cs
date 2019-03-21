using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using Xunit;

namespace Automacao_xUnit.tests.steps
{
    class AcessPageActions : AccessElementsMap
    {
        private ClassUtilities util = new ClassUtilities();
        private IWebDriver Driver;

        public bool AccessPage(string url)
        {
            bool _result = false;

            var currentPath = Directory.GetCurrentDirectory();
            string path = $"{currentPath}/../../../WebDriverLinux";


            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                path = $"{currentPath}\\..\\..\\..\\WebDriverWindows";
            }
            else
            {
                path = $"{currentPath}/../../../WebDriverLinux";
            }

            try
            {
                Driver = new ChromeDriver(path);

                Driver.Navigate().GoToUrl(url);
                _result = true;
            }
            catch
            {

            }
            return _result;
        }


        public bool ValidAccessPage()
        {
            bool _result = false;
            try
            {
                IWebElement LogoHome = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div//a[@class='logo']"));
                util.WaitForElementVisible(LogoHome, 25);
                if (LogoHome.Displayed)
                {
                    _result = true;
                }
                else
                {

                }
            }
            catch (Exception)
            {
            }
            return _result;
        }

        public bool ValidarAcessoIes()
        {
            bool _result = false;
            try
            {
                Thread.Sleep(10000);
                IWebElement formLogin = ClassDriver.GetInstance().Driver.FindElement(By.Id("formLogin"));
                util.WaitForElementVisible(formLogin, 15);
                if (formLogin.Displayed)
                {
                    _result = true;
                }
                else
                {

                }
            }
            catch (Exception)
            {
            }
            return _result;
        }
    }
}
