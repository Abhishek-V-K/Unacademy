using TechTalk.SpecFlow;

namespace Unacademy
{
    [Binding]
    public class Popup_And_New_WindowsStepDefinitions : UtilityClass
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


        [When(@"User clicks on Ok got it Popup button")]
        public void WhenUserClicksOnOkGotItPopupButton()
        {
            GB.OKGOTITpopup();
        }

        [Then(@"Popup disappears")]
        public void ThenPopupDisappears()
        {
            Console.WriteLine("Pop up closed");
        }

        [When(@"User clicks on Experience our recap link")]
        public void WhenUserClicksOnExperienceOurRecapLink()
        {
            Thread.Sleep(5000);
            GB.Experienceour2021recap();
        }

        [Then(@"It shows Unacademy Recap page in new")]
        public void ThenItShowsUnacademyRecapPageInNew()
        {
            Console.WriteLine("Unacademy page is opened in new window");
        }
        [AfterScenario]
        public void AfterScenario()
        {
            Thread.Sleep(5000);
            CloseBrowser();
        }
    }
}
