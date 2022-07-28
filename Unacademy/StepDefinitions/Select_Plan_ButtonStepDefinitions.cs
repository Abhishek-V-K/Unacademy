using TechTalk.SpecFlow;

namespace Unacademy.StepDefinitions
{
    [Binding]
    public class Select_Plan_ButtonStepDefinitions : UtilityClass
    {
        public Get_subscription GB;
        public LoginPage LP;
        public Selecting_Subscription_Plans SSPL;
        public CA_Foundation_subscription CA_Foundation;
        public Choose_a_payment_method Payment_Method;
        [BeforeScenario]
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
        [Given(@"Chrome is launched and Unacademy application is launched")]
        public void GivenChromeIsLaunchedAndUnacademyApplicationIsLaunched()
        {
            Console.WriteLine("Chrome Is Launched And Unacademy Application Is Launched");
        }



 

        //[Then(@"It shows price of PLUS plan with duration in other page")]
        //public void ThenItShowsPriceOfPLUSPlanWithDurationInOtherPage()
        //{
        //    Console.WriteLine("It shows price of PLUS plan with duration in other page");
        //}

        //[When(@"User clicks on Select LITE button")]
        //public void WhenUserClicksOnSelectLITEButton()
        //{
         
        //    ObjectMethod();
        //    Thread.Sleep(12000);
        //    SSPL.ScrollDown();
        //    Thread.Sleep(2000);
        //    SSPL.ClickOnSelectLITEButton();
        //}

        //[Then(@"It shows price of LITE plan with duration in other page")]
        //public void ThenItShowsPriceOfLITEPlanWithDurationInOtherPage()
        //{
        //    Console.WriteLine("It shows price of LITE plan with duration in other page");
        //}

        //[When(@"User clicks on Select ICONIC button")]
        //public void WhenUserClicksOnSelectICONICButton()
        //{
        //    ObjectMethod();
        //    Thread.Sleep(20000);
        //    SSPL.ClickOnSelectICONICButton();
        //}

        //[Then(@"It shows price of ICONIC plan with duration in other page")]
        //public void ThenItShowsPriceOfICONICPlanWithDurationInOtherPage()
        //{
        //    Console.WriteLine("It shows price of ICONIC plan with duration in other page");
        //}

        [When(@"User clicks on Select '([^']*)' button")]
        public void WhenUserClicksOnSelectButton(string pLUS)
        {
            ObjectMethod();
            Thread.Sleep(20000);
            GB.ClickOnGetSubscriptionButton();

            switch (pLUS)
            {
                case "PLUS":
                    // code block
                    Thread.Sleep(20000);
                    SSPL.ClickOnSelectPLUSButton();
                    break;
                case "ICONIC":
                    // code block
                    Thread.Sleep(10000);
                    SSPL.ClickOnSelectICONICButton();
                    break;
                default:
                    // code block
                    
                    Thread.Sleep(10000);
                    SSPL.ScrollDown();
                    Thread.Sleep(2000);
                    SSPL.ClickOnSelectLITEButton();
                    break;
            }


        }
        [Then(@"It shows price of '([^']*)' plan with duration in other page")]
        public void ThenItShowsPriceOfPlanWithDurationInOtherPage(string pLUS)
        {
            switch (pLUS)
            {
                case "PLUS":
                    // code block
                    Console.WriteLine("It shows price of PLUS plan with duration in other page");
                    break;
                case "ICONIC":
                    // code block
                    Console.WriteLine("It shows price of ICONIC plan with duration in other page");
                    break;
                default:
                    // code block
                    Console.WriteLine("It shows price of LITE plan with duration in other page");
                    break;
            }
        }

    }
}
