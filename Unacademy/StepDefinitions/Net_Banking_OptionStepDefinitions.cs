//using TechTalk.SpecFlow;

//namespace Unacademy
//{
//    [Binding]
//    public class Net_Banking_OptionStepDefinitions : UtilityClass
//    {
//        public Get_subscription GB;
//        public LoginPage LP;
//        public Selecting_Subscription_Plans SSPL;
//        public CA_Foundation_subscription CA_Foundation;
//        public Choose_a_payment_method Payment_Method;
//        [BeforeScenario]
//        //public void BeforeScenario()
//        //{
//        //    LaunchBrowser("CHROME");
//        //    LaunchApp(Url);


//        //}
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

//        [When(@"User clicks on Plan Duration Radio button")]
//        public void WhenUserClicksOnPlanDurationRadioButton()
//        {
//            ObjectMethod();
//            Thread.Sleep(2000);
//            GB.ClickOnGetSubscriptionButton();
//            Thread.Sleep(20000);
//            SSPL.ClickOnSelectPLUSButton();
//            Thread.Sleep(2000);
//            CA_Foundation.Viewallplansbutton();
//            Thread.Sleep(2000);
//            CA_Foundation.TwoMonthsRadioButton();
//        }

//        //[When(@"User clicks on Have a referral code Text Box and enters Valid referral code and click on apply")]
//        //public void WhenUserClicksOnHaveAReferralCodeTextBoxAndEntersValidReferralCodeAndClickOnApply()
//        //{
//        //    CA_Foundation.HaveArefferalcodeTextBox1();
//        //    CA_Foundation.ApplyReferralCode();
//        //}

//        [When(@"User clicks on Proceed to pay button")]
//        public void WhenUserClicksOnProceedToPayButton()
//        {
//            CA_Foundation.HaveArefferalcodeTextBox1();
//            CA_Foundation.ApplyReferralCode();
//            Thread.Sleep(12000);
//            CA_Foundation.Proceedtopaybutton();
//        }

//        [When(@"User enters Registered Phone Number (.*)")]
//        public void WhenUserEntersRegisteredPhoneNumber(string RegisteredPhoneNumber)
//        {
//            Thread.Sleep(1000);
//            LP.MobileNumberTextBox();
//            CA_Foundation.Loginbutton();
//            Thread.Sleep(55000);
//            CA_Foundation.VerifyOTPButton();

//        }

//        [When(@"It shows Choose a payment method page")]
//        public void WhenItShowsChooseAPaymentMethodPage()
//        {
//            Console.WriteLine("Showing Payment method page");
//        }

//        [Then(@"User Choose Net banking payment method")]
//        public void ThenUserChooseNetBankingPaymentMethod()
//        {
//            Thread.Sleep(6000);
//            Payment_Method.Netbanking();
//        }

//        [Then(@"Click on Select a bank dropdown")]
//        public void ThenClickOnSelectABankDropdown()
//        {
//            Thread.Sleep(20000);
//            Payment_Method.SelectingabankDropdown();
//        }

//        [Then(@"Select Canara Bank Corporate")]
//        public void ThenSelectCanaraBankCorporate()
//        {
//            Thread.Sleep(20000);
//            Payment_Method.Selectingabankname();
//        }
//        [AfterScenario]
//        public void AfterScenario()
//        {
//            Thread.Sleep(5000);
//            CloseBrowser();
//        }
//    }
//}
