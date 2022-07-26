using TechTalk.SpecFlow;

namespace Unacademy
{
    public class ApplicationHooks : UtilityClass
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
            //LaunchApp(url);
            LaunchApp(Url);

         

            GB = new Get_subscription(driver);
            driver.Manage().Window.Maximize();

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

        [AfterScenario]
        public void AfterScenario()
        {
            Thread.Sleep(5000);
            CloseBrowser();
        }
    }
}
