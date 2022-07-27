//using TechTalk.SpecFlow;

//namespace Unacademy.StepDefinitions
//{
//    [Binding]
//    public class Select_LITE_ButtonStepDefinitions : ApplicationHooks
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

//        [When(@"User clicks on Select LITE button")]
//        public void WhenUserClicksOnSelectLITEButton()
//        {

//            Thread.Sleep(12000);
//            SSPL.ScrollDown();
//            Thread.Sleep(2000);
//            SSPL.ClickOnSelectLITEButton();
//        }

//        [Then(@"It shows price of LITE plans with duration in other page")]
//        public void ThenItShowsPriceOfLITEPlansWithDurationInOtherPage()
//        {
//            Console.WriteLine("LITE plans with duration page is displayed"); CaptureScreenshot();
//        }
//    }
//}
