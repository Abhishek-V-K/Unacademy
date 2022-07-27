//using TechTalk.SpecFlow;

//namespace Unacademy
//{
//    [Binding]
//    public class Switch_Plan_ButtonStepDefinitions : ApplicationHooks
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

//        [When(@"User clicks on Select LITE plan")]
//        public void WhenUserClicksOnSelectLITEPlan()
//        {
//            Thread.Sleep(12000);
//            SSPL.ScrollDown();
//            Thread.Sleep(2000);
//            SSPL.ClickOnSelectLITEButton();
//        }

//        [Then(@"It shows subscription plan page")]
//        public void ThenItShowsSubscriptionPlanPage()
//        {
//            Thread.Sleep(2000);
//            CA_Foundation.HeadingText();
//        }

//        [Then(@"User switches to PLUS plan")]
//        public void ThenUserSwitchesToPLUSPlan()
//        {
//            Thread.Sleep(2000);
//            CA_Foundation.PLUSSwitchbutton();
//        }

//        [Then(@"User switches to ICONIC plan")]
//        public void ThenUserSwitchesToICONICPlan()
//        {
//            Thread.Sleep(2000);
//            CA_Foundation.ICONICSwitchbutton();
//        }

//        [When(@"User clicks on Select PLUS plan")]
//        public void WhenUserClicksOnSelectPLUSPlan()
//        {
//            Thread.Sleep(20000);
//            SSPL.ClickOnSelectPLUSButton();
//        }

//        [Then(@"User switches to LITE plan")]
//        public void ThenUserSwitchesToLITEPlan()
//        {
//            Thread.Sleep(2000);
//            CA_Foundation.LITESwitchbutton();
//        }
//    }
//}
