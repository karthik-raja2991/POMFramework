﻿using OpenQA.Selenium;
using POMFramework.PageObjects.Base;

namespace POMFramework.PageObjects
{
    // This class stores the locators to all of the elements that can be interacted with on the page


    public class HomepageMap : BasePage
    {
        public HomepageMap(IWebDriver driver) : base(driver)
        {
        }


        public IWebElement ContactUsLink => Driver.FindElement(By.Id("contact-link"));
    }
}
