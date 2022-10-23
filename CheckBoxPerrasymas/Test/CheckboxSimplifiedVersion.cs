using BasePage;
using CheckBoxPerrasymas.Page;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace CheckBoxPerrasymas.Test
{
    public class CheckboxSimplifiedVersionTest
    {
        class CheckboxDemo : Base
        {


            [OneTimeSetUp]
            public static void OneTimeSetup()
            {
                chromeDriver = new ChromeDriver();
                chromeDriver.Url = "http://demo.seleniumeasy.com/basic-checkbox-demo.html";
                chromeDriver.Manage().Window.Maximize();
                chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            }

            [OneTimeTearDown]
            public static void OneTimeTearDown()
            {
                chromeDriver.Quit();
            }
            [Test]
            public static void TestFirstCheckbox()
            {
                CheckboxSimplifierInputPage page = new CheckboxSimplifierInputPage();
                page.ClickCheckbox();
                page.VerifyIfCheckboxIsChecked();
            }
            [Test]
            public static void CheckboxesTest()
            {
                CheckboxSimplifierInputPage page = new CheckboxSimplifierInputPage();
                page.CheckAllCheckboxes();
                page.VerifyIfAllCheckboxesChecked();
            }
            [Test]
            public static void UncheckCheckboxesTest()
            {
                CheckboxSimplifierInputPage page = new CheckboxSimplifierInputPage();
                page.CheckAllCheckboxes();
                page.ClickButton();
                page.VerifyIfAllCheckboxesAreUnchecked();
            }
        }
    }
}
