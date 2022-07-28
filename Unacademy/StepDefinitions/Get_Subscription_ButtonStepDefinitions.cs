using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Unacademy
{
    [Binding]
    public class Get_Subscription_ButtonStepDefinitions : UtilityClass
    {
        public Get_subscription GB;
        public LoginPage LP;
        public Selecting_Subscription_Plans SSPL;
        public CA_Foundation_subscription CA_Foundation;
        public Choose_a_payment_method Payment_Method;
        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("CHROME");
            LaunchApp(Url);


        }
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


       

        [When(@"User clicks on Get subscription button")]
        public void WhenUserClicksOnGetSubscriptionButton()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            GB.ClickOnGetSubscriptionButton();
            String actualTitle = ValidatePageTitle();
            Console.WriteLine(actualTitle);
        }

        [Then(@"It shows subscription plan page")]
        public void ThenItShowsSubscriptioPlanPage()
        {
            Thread.Sleep(2000);
            String expectedTitle = "Crack your CA Foundation Exam with Unacademy | Unacademy";
            String actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
            CaptureScreenshot();

        }
        [AfterScenario]
        public void AfterScenario()
        {
            Thread.Sleep(5000);
            CloseBrowser();
        }
    }
}
