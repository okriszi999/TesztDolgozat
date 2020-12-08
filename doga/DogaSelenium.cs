using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace doga
{
    [TestClass]
    public class DogaSelenium
    {
        static IWebDriver FFDriver;
        static String web;

        [TestMethod]
        public void elsoTest()
        {
            //1.
            web = "http://atthy4.atspace.cc/seleniumdoga/Hivatalosdoga.html";
            FFDriver = new FirefoxDriver();
            FFDriver.Navigate().GoToUrl(web);
            String link = FFDriver.FindElement(By.LinkText("DevOps 1")).GetAttribute("href");
            Assert.IsTrue(link == "https://aaskmeabout.com/question/true-or-false-devops-automation-tools-rely-on-coding-skills/");
            //2.
            var dropdown = FFDriver.FindElement(By.Name("visitor[b]"));
            var select = new SelectElement(dropdown);
            var dropdown2 = FFDriver.FindElement(By.Name("visitor[a]"));
            var select2 = new SelectElement(dropdown2);
            select.SelectByIndex(3);
            select2.SelectByIndex(4);
            //3.
            FFDriver.FindElement(By.Name("eredmeny[home][0][1]")).Click();
            FFDriver.FindElement(By.Name("eredmeny[visitor][0][1]")).Click();
            //4.
            IWebElement checkbox = FFDriver.FindElement(By.Id("checkbox_car"));
            if (!checkbox.Selected)
            {
                checkbox.Click();
            }
            Assert.IsTrue(checkbox.Selected);
            //5.
            var radio = FFDriver.FindElement(By.Id("radio_kivalo"));
            radio.Click();
            Assert.IsFalse(FFDriver.FindElement(By.Id("radio_jeles")).Selected);
            //6.
            FFDriver.FindElement(By.TagName("button")).Click();
            int imgs = FFDriver.FindElements(By.TagName("img")).Count;
            Assert.IsTrue(imgs == 2);
        }
    }
}
