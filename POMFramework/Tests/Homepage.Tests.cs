﻿using NUnit.Framework;
using POMFramework.PageObjects;

namespace POMFramework
{
    // Main test class

    [TestFixture]
    public class Homepage : BaseTest
    {

        [Test]
        [Description("Login Test")]
        [Author("karthik raja")]

        public void Valid_Login()
        {
            Pages.Home.GoTo();
            Pages.Home.Login();
            Pages.Inventory.LogOut();
            Pages.Inventory.LogOut();

            Assert.IsTrue(Pages.Home.Map.LoginButton.Displayed);

        }

        [Test]
        [Description("Checkout test")]
        [Author("karthik raja")]

        public void Buy_Most_Expensive_Item()
        {
            Pages.Home.GoTo();
            Pages.Home.Login();
            Pages.Inventory.SortByMostExpensive();
            Pages.Inventory.AddItemToCart();
            Pages.Inventory.CheckOut();
            Pages.Checkout.EnterDetails("Example", "User", "A123");
            Pages.Checkout.FinishCheckout();

            Assert.IsTrue(Pages.Checkout.Map.PonyExpressImage.Displayed);
        }

        [Test]
        [Description("Validate all items can be added to the cart")]
        [Author("karthik raja")]

        public void Add_All_Items_To_Cart()
        {
            Pages.Home.GoTo();
            Pages.Home.Login();
            Pages.Inventory.AddAllItemsToCart();

            Assert.IsTrue(Pages.Inventory.Map.ShoppingCart.Text == "6");
        }
    }
}
