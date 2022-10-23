using BasePage;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace CheckBoxPerrasymas.Page
{
    public class CheckboxSimplifierInputPage : Base
    {
        //private static IWebDriver chromeDriver = new ChromeDriver();
        private static IWebElement oneCheckBox = chromeDriver.FindElement(By.Id("isAgeSelected"));
        private static IWebElement resultElement = chromeDriver.FindElement(By.Id("txtAge"));
        private static IWebElement button = chromeDriver.FindElement(By.CssSelector("#check1"));

        public void ClickCheckbox()
        {
            if (!oneCheckBox.Selected)
            {
                oneCheckBox.Click();
            }
        }
        public void VerifyIfCheckboxIsChecked()
        {
            Assert.AreEqual("Success - Check box is checked", resultElement.Text, "Result text is wrong");
        }
        public void VerifyIfAllCheckboxesChecked()
        {

            Assert.IsTrue("Uncheck All".Equals(button.GetAttribute("value")),
                "Button value is not correct");
        }
        private static IReadOnlyCollection<IWebElement> GetCheckboxesCollection()
        {
            return chromeDriver.FindElements(By.CssSelector(".cb1-element"));
        }

        public void CheckAllCheckboxes()
        {
            IReadOnlyCollection<IWebElement> checkboxesCollection
               = GetCheckboxesCollection();

            foreach (IWebElement checkbox in checkboxesCollection)
            {
                if (!checkbox.Selected)
                {
                    checkbox.Click();
                }
            }
        }
        public void ClickButton()
        {
            button.Click();
        }
        public void VerifyIfAllCheckboxesAreUnchecked()
        {
            Assert.IsTrue("Check All".Equals(button.GetAttribute("value")),
                "Button value is not correct");

            foreach (IWebElement checkbox in GetCheckboxesCollection())
            {
                Assert.That(!checkbox.Selected, "Check box was not unselected");
            }
        }
    }
}
