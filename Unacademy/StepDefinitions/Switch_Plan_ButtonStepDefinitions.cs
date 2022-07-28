using TechTalk.SpecFlow;

namespace Unacademy
{
    [Binding]
    public class Switch_Plan_ButtonStepDefinitions : UtilityClass
    {
        public Get_subscription GB;
        public LoginPage LP;
        public Selecting_Subscription_Plans SSPL;
        public CA_Foundation_subscription CA_Foundation;
        public Choose_a_payment_method Payment_Method;
        [BeforeScenario]

        public void ObjectMethod()
        {
            GB = new Get_subscription(driver);
            driver.Manage().Window.FullScreen();

            LP = new LoginPage(driver);
            driver.Manage().Window.FullScreen();

            SSPL = new Selecting_Subscription_Plans(driver);
            driver.Manage().Window.FullScreen();

            CA_Foundation = new CA_Foundation_subscription(driver);
            driver.Manage().Window.FullScreen();

            Payment_Method = new Choose_a_payment_method(driver);
            driver.Manage().Window.FullScreen();

            Thread.Sleep(5000);
        }




        //[When(@"User clicks on Select LITE plan")]
        //public void WhenUserClicksOnSelectLITEPlan()
        //{
        //    Thread.Sleep(12000);
        //    SSPL.ScrollDown();
        //    Thread.Sleep(2000);
        //    SSPL.ClickOnSelectLITEButton();
        //}

        //[Then(@"It shows subscription plan page")]
        //public void ThenItShowsSubscriptionPlanPage()
        //{
        //    Thread.Sleep(2000);
        //    CA_Foundation.HeadingText();
        //}

        [Then(@"User switches to PLUS plan")]
        public void ThenUserSwitchesToPLUSPlan()
        {
            Thread.Sleep(20000);
            GB.ClickOnGetSubscriptionButton();
            Thread.Sleep(12000);
            SSPL.ScrollDown();
            Thread.Sleep(2000);
            SSPL.ClickOnSelectLITEButton();
            Thread.Sleep(2000);
            CA_Foundation.PLUSSwitchbutton();
        }

        [Then(@"User switches to ICONIC plan")]
        public void ThenUserSwitchesToICONICPlan()
        {
            Thread.Sleep(5000);
            GB.ClickOnGetSubscriptionButton();
            Thread.Sleep(12000);
            SSPL.ScrollDown();
            Thread.Sleep(2000);
            SSPL.ClickOnSelectLITEButton();
            Thread.Sleep(3000);
            CA_Foundation.ICONICSwitchbutton();
        }

        //[When(@"User clicks on Select PLUS plan")]
        //public void WhenUserClicksOnSelectPLUSPlan()
        //{
        //    Thread.Sleep(20000);
        //    SSPL.ClickOnSelectPLUSButton();
        //}

        [Then(@"User switches to LITE plan")]
        public void ThenUserSwitchesToLITEPlan()
        {
            Thread.Sleep(2000);
            GB.ClickOnGetSubscriptionButton();
            Thread.Sleep(20000);
            SSPL.ClickOnSelectPLUSButton();
            Thread.Sleep(2000);
            CA_Foundation.LITESwitchbutton();
        }

    }
}
