//using TechTalk.SpecFlow;

//namespace Unacademy
//{
//    [Binding]
//    public class Proceed_To_Pay_ButtonStepDefinitions : UtilityClass
//    {
//        public Get_subscription GB;
//        public LoginPage LP;
//        public Selecting_Subscription_Plans SSPL;
//        public CA_Foundation_subscription CA_Foundation;
//        public Choose_a_payment_method Payment_Method;
//        [BeforeScenario]
//        public void BeforeScenario()
//        {
//            LaunchBrowser("CHROME");
//            LaunchApp(Url);


//        }
//        public void ObjectMethod()
//        {
//            GB = new Get_subscription(driver);
//            driver.Manage().Window.FullScreen();

//            LP = new LoginPage(driver);
//            driver.Manage().Window.FullScreen();

//            SSPL = new Selecting_Subscription_Plans(driver);
//            driver.Manage().Window.FullScreen();

//            CA_Foundation = new CA_Foundation_subscription(driver);
//            driver.Manage().Window.FullScreen();

//            Payment_Method = new Choose_a_payment_method(driver);
//            driver.Manage().Window.FullScreen();

//            Thread.Sleep(5000);
//        }
        



//        [When(@"User clicks on Select PLUS button")]
//        public void WhenUserClicksOnSelectPLUSButton()
//        {
//            Thread.Sleep(20000);
//            SSPL.ClickOnSelectPLUSButton();
//        }

//        [When(@"User clicks on View all plans")]
//        public void WhenUserClicksOnViewAllPlans()
//        {
//            CA_Foundation.Viewallplansbutton();
//        }

//        [When(@"User clicks on Accept cookies")]
//        public void WhenUserClicksOnAcceptCookies()
//        {
//            Thread.Sleep(2000);
//            CA_Foundation.AcceptCookiesbutton();
//        }

//        [When(@"User clicks on Plan Duration Radio button")]
//        public void WhenUserClicksOnPlanDurationRadioButton()
//        {
//            CA_Foundation.TwoMonthsRadioButton();

//        }

//        [When(@"User clicks on Have a referral code Text Box and enters Valid referral code and click on apply")]
//        public void WhenUserClicksOnHaveAReferralCodeTextBoxAndEntersValidReferralCodeAndClickOnApply()
//        {
//            CA_Foundation.HaveArefferalcodeTextBox1();
//            CA_Foundation.ApplyReferralCode();
//        }

//        [When(@"User clicks on Proceed to pay button")]
//        public void WhenUserClicksOnProceedToPayButton()
//        {
//            Thread.Sleep(12000);
//            CA_Foundation.Proceedtopaybutton();
//        }

//        [When(@"User enters Registered Phone Number (.*)")]
//        public void WhenUserEntersRegisteredPhoneNumber(string RegisteredPhoneNumber)
//        {
//            Thread.Sleep(1000);
//            LP.MobileNumberTextBox(RegisteredPhoneNumber);
//            CA_Foundation.Loginbutton();
//            Thread.Sleep(30000);
//            CA_Foundation.VerifyOTPButton();

//        }


//        [Then(@"It shows Choose a payment method page")]
//        public void ThenItShowsChooseAPaymentMethodPage()
//        {
//            Console.WriteLine("Showing Payment method page");
//        }
//        [AfterScenario]
//        public void AfterScenario()
//        {
//            Thread.Sleep(5000);
//            CloseBrowser();
//        }
//    }
//}
