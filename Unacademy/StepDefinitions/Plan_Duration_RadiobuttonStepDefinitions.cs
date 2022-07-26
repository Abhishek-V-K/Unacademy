//using System;
//using TechTalk.SpecFlow;

//namespace Unacademy
//{
//    [Binding]
//    public class Plan_Duration_RadiobuttonStepDefinitions : ApplicationHooks
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

//        [Then(@"It shows tick mark")]
//        public void ThenItShowsTickMark()
//        {
//            Console.WriteLine("Tick mark is displayed");
//        }
//    }
//}
