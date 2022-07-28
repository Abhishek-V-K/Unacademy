using TechTalk.SpecFlow;

namespace Unacademy
{
    [Binding]
    public class Have_A_Referral_Code_Text_BoxStepDefinitions : UtilityClass
    {
        public Get_subscription GB;
        public LoginPage LP;
        public Selecting_Subscription_Plans SSPL;
        public CA_Foundation_subscription CA_Foundation;
        public Choose_a_payment_method Payment_Method;
        [BeforeScenario]
        //public void BeforeScenario()
        //{
        //    LaunchBrowser("CHROME");
        //    LaunchApp(Url);


        //}
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

        


        [When(@"User clicks on Select PLUS button")]
        public void WhenUserClicksOnSelectPLUSButton()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            GB.ClickOnGetSubscriptionButton();
            Thread.Sleep(20000);
            SSPL.ClickOnSelectPLUSButton();
        }
        [When(@"User clicks on Accept cookies button")]
        public void WhenUserClicksOnAcceptCookiesButton()
        {
            Thread.Sleep(20000);
            CA_Foundation.AcceptCookiesbutton();
        }

        [When(@"User clicks on Have a referral code Text Box and enters Valid referral code and click on apply")]
        public void WhenUserClicksOnHaveAReferralCodeTextBoxAndEntersValidReferralCodeAndClickOnApply()
        {
            Thread.Sleep(2000);
            CA_Foundation.HaveArefferalcodeTextBox1();
            Thread.Sleep(2000);
            CA_Foundation.ApplyReferralCode();
        }

        [Then(@"It shows message you got off\.")]
        public void ThenItShowsMessageYouGotOff_()
        {
            Console.WriteLine("It Shows message you got off");
        }

        [When(@"User clicks on Have a referral code Text Box and enters Invalid referral code and click on apply")]
        public void WhenUserClicksOnHaveAReferralCodeTextBoxAndEntersInvalidReferralCodeAndClickOnApply()
        {
            Thread.Sleep(2000);
            CA_Foundation.HaveArefferalcodeTextBox2();
            Thread.Sleep(2000);
            CA_Foundation.ApplyReferralCode();
        }

        [When(@"User clicks on View all plans")]
        public void WhenUserClicksOnViewAllPlans()
        {
            Thread.Sleep(5000);
            CA_Foundation.Viewallplansbutton();
        }

        [Then(@"It shows all plans")]
        public void ThenItShowsAllPlans()
        {
            Console.WriteLine("It show all plans");
        }
        [AfterScenario]
        public void AfterScenario()
        {
            Thread.Sleep(5000);
            CloseBrowser();
        }

    }
}
