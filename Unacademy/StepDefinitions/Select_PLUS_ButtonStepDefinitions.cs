//using System;
//using TechTalk.SpecFlow;

//namespace Unacademy.StepDefinitions
//{
//    [Binding]
//    public class Select_PLUS_ButtonStepDefinitions : ApplicationHooks
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

//        [Then(@"It shows price of PLUS plans with duration in other page")]
//        public void ThenItShowsPriceOfPLUSPlansWithDurationInOtherPage()
//        {
//            Thread.Sleep(2000);
//            CaptureScreenshot();
//        }
//    }
//}
