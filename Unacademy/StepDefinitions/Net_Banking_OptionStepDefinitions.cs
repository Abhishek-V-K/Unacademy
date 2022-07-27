//using TechTalk.SpecFlow;

//namespace Unacademy
//{
//    [Binding]
//    public class Net_Banking_OptionStepDefinitions : ApplicationHooks
//    {
//        [Given(@"Chrome is launched and Unacademy application is launched")]
//        public void GivenChromeIsLaunchedAndUnacademyApplicationIsLaunched()
//        {
//            Console.WriteLine("Chrome Is Launched And Unacademy Application Is Launched");
//        }

//        [When(@"User clicks on Get subscription button")]
//        public void WhenUserClicksOnGetSubscriptionButton()
//        {
//            Thread.Sleep(2000);
//            GB.ClickOnGetSubscriptionButton();
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

//    }
//}
