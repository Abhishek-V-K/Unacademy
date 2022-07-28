using TechTalk.SpecFlow;

namespace Unacademy
{
    [Binding]
    public class Payment_MethodsStepDefinitions : UtilityClass
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




        //[When(@"User clicks on Select PLUS button")]
        //public void WhenUserClicksOnSelectPLUSButton()
        //{
        //    ObjectMethod();
        //    Thread.Sleep(20000);
        //    SSPL.ClickOnSelectPLUSButton();
        //}

        //[When(@"User clicks on View all plans")]
        //public void WhenUserClicksOnViewAllPlans()
        //{
        //    ObjectMethod();
        //    CA_Foundation.Viewallplansbutton();
        //}

        //[When(@"User clicks on Plan Duration Radio button")]
        //public void WhenUserClicksOnPlanDurationRadioButton()
        //{
        //    ObjectMethod();
        //    CA_Foundation.TwoMonthsRadioButton();
        //}

        //[When(@"User clicks on Accept cookies")]
        //public void WhenUserClicksOnAcceptCookies()
        //{
        //    ObjectMethod();
        //    Thread.Sleep(2000);
        //    CA_Foundation.AcceptCookiesbutton();
        //}

        //[When(@"User clicks on Have a referral code Text Box and enters Valid referral code and click on apply")]
        //public void WhenUserClicksOnHaveAReferralCodeTextBoxAndEntersValidReferralCodeAndClickOnApply()
        //{
        //    ObjectMethod();
        //    CA_Foundation.HaveArefferalcodeTextBox1();
        //    CA_Foundation.ApplyReferralCode();
        //}

        //[When(@"User clicks on Proceed to pay button")]
        //public void WhenUserClicksOnProceedToPayButton()
        //{
        //    ObjectMethod();
        //    Thread.Sleep(12000);
        //    CA_Foundation.Proceedtopaybutton();
        //}

        //[When(@"User enters Registered Phone Number (.*)")]
        //public void WhenUserEntersRegisteredPhoneNumber(string RegisteredPhoneNumber)
        //{
        //    ObjectMethod();
        //    Thread.Sleep(1000);
        //    LP.MobileNumberTextBox(RegisteredPhoneNumber);
        //    CA_Foundation.Loginbutton();
        //    Thread.Sleep(55000);
        //    CA_Foundation.VerifyOTPButton();

        //}

        //[When(@"It shows Choose a payment method page")]
        //public void WhenItShowsChooseAPaymentMethodPage()
        //{
        //    Console.WriteLine("Showing Payment method page");
        //}
        //[Then(@"User Chooses method to pay")]
        //public void ThenUserChoosesMethodToPay()
        //{
        //    Console.WriteLine("The Users chooses method to pay");
        //}
        //[Then(@"User Choose Net banking payment method")]
        //public void ThenUserChooseNetBankingPaymentMethod()
        //{
        //    ObjectMethod();
        //    Thread.Sleep(6000);
        //    Payment_Method.Netbanking();
        //}

        //[Then(@"Click on Select a bank dropdown")]
        //public void ThenClickOnSelectABankDropdown()
        //{
        //    ObjectMethod();
        //    Thread.Sleep(20000);
        //    Payment_Method.SelectingabankDropdown();
        //}

        //[Then(@"Select Canara Bank Corporate")]
        //public void ThenSelectCanaraBankCorporate()
        //{
        //    ObjectMethod();
        //    Thread.Sleep(20000);
        //    Payment_Method.Selectingabankname();
        //}

        [Then(@"User Choose UPI payment method")]
        public void ThenUserChooseUPIPaymentMethod()
        {
            Thread.Sleep(20000);
            SSPL.ClickOnGetSubscriptionButton();
            ObjectMethod();
            Thread.Sleep(20000);
            SSPL.ClickOnSelectPLUSButton();
            Thread.Sleep(10000);
            CA_Foundation.Viewallplansbutton();
            Thread.Sleep(2000);
            CA_Foundation.TwoMonthsRadioButton();
            Thread.Sleep(10000);
            CA_Foundation.AcceptCookiesbutton();
            Thread.Sleep(3000);
            CA_Foundation.HaveArefferalcodeTextBox1();
            Thread.Sleep(3000);
            CA_Foundation.ApplyReferralCode();
            Thread.Sleep(12000);
            CA_Foundation.Proceedtopaybutton();
            Thread.Sleep(1000);
            LP.MobileNumberTextBox();
            Thread.Sleep(3000);
            CA_Foundation.Loginbutton();
            Thread.Sleep(55000);
            CA_Foundation.VerifyOTPButton();
            Thread.Sleep(6000);
            Payment_Method.Netbanking();
            Thread.Sleep(20000);
            Payment_Method.SelectingabankDropdown();
            Thread.Sleep(20000);
            Payment_Method.Selectingabankname();
            Thread.Sleep(6000);
            Payment_Method.UPIoption();
        }

        [Then(@"Click on Enter UPI ID text box and Enter (.*)")]
        public void ThenClickOnEnterUPIIDTextBoxAndEnter(string UPIID)
        {
            ObjectMethod();
            Thread.Sleep(2000);
            Payment_Method.EnteringUPIID(UPIID);


        }



        [Then(@"Select @paytm")]
        public void ThenSelectPaytm()
        {
            Thread.Sleep(20000);
            Payment_Method.SelectingabankDropdown();
            ObjectMethod();
            Thread.Sleep(20000);
            Payment_Method.SelectingUPIBankNameFromDropDown();
        }
        [AfterScenario]
        public void AfterScenario()
        {
            Thread.Sleep(5000);
            CloseBrowser();
        }

    }
}

