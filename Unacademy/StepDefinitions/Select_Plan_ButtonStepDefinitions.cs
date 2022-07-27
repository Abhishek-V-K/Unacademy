using TechTalk.SpecFlow;

namespace Unacademy.StepDefinitions
{
    [Binding]
    public class Select_Plan_ButtonStepDefinitions : ApplicationHooks
    {
        [Given(@"Chrome is launched and Unacademy application is launched")]
        public void GivenChromeIsLaunchedAndUnacademyApplicationIsLaunched()
        {
            Console.WriteLine("Chrome Is Launched And Unacademy Application Is Launched");
        }

        [When(@"User clicks on Get subscription button")]
        public void WhenUserClicksOnGetSubscriptionButton()
        {
            GB.ClickOnGetSubscriptionButton();
        }

        [When(@"User clicks on Select PLUS button")]
        public void WhenUserClicksOnSelectPLUSButton()
        {
            Thread.Sleep(20000);
            SSPL.ClickOnSelectPLUSButton();
        }

        [Then(@"It shows price of PLUS plan with duration in other page")]
        public void ThenItShowsPriceOfPLUSPlanWithDurationInOtherPage()
        {
            Console.WriteLine("It shows price of PLUS plan with duration in other page");
        }

        [When(@"User clicks on Select LITE button")]
        public void WhenUserClicksOnSelectLITEButton()
        {
            Thread.Sleep(12000);
            SSPL.ScrollDown();
            Thread.Sleep(2000);
            SSPL.ClickOnSelectLITEButton();
        }

        [Then(@"It shows price of LITE plan with duration in other page")]
        public void ThenItShowsPriceOfLITEPlanWithDurationInOtherPage()
        {
            Console.WriteLine("It shows price of LITE plan with duration in other page");
        }

        [When(@"User clicks on Select ICONIC button")]
        public void WhenUserClicksOnSelectICONICButton()
        {
            Thread.Sleep(20000);
            SSPL.ClickOnSelectICONICButton();
        }

        [Then(@"It shows price of ICONIC plan with duration in other page")]
        public void ThenItShowsPriceOfICONICPlanWithDurationInOtherPage()
        {
            Console.WriteLine("It shows price of ICONIC plan with duration in other page");
        }
    }
}
