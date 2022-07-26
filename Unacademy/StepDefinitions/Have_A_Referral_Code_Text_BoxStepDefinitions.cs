using System;
using TechTalk.SpecFlow;

namespace Unacademy
{
    [Binding]
    public class Have_A_Referral_Code_Text_BoxStepDefinitions : ApplicationHooks
    {
        [Given(@"Chrome is launched and Unacademy application is launched")]
        public void GivenChromeIsLaunchedAndUnacademyApplicationIsLaunched()
        {
            Console.WriteLine("Chrome Is Launched And Unacademy Application Is Launched");
        }

        [When(@"User clicks on Get subscription button")]
        public void WhenUserClicksOnGetSubscriptionButton()
        {
            Thread.Sleep(2000);
            GB.ClickOnGetSubscriptionButton();

        }

        [When(@"User clicks on Select PLUS button")]
        public void WhenUserClicksOnSelectPLUSButton()
        {

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
            CA_Foundation.Viewallplansbutton();
        }

        [Then(@"It shows all plans")]
        public void ThenItShowsAllPlans()
        {
            Console.WriteLine("It show all plans");
        }

    }
}
