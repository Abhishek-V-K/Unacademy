//using TechTalk.SpecFlow;

//namespace Unacademy.StepDefinitions
//{
//    [Binding]
//    public class Select_LITE_ButtonStepDefinitions : UtilityClass
//    {
//        public Get_subscription GB;
//        public LoginPage LP;
//        public Selecting_Subscription_Plans SSPL;
//        public CA_Foundation_subscription CA_Foundation;
//        public Choose_a_payment_method Payment_Method;
//        [BeforeScenario]
//        public void BeforeScenario()
//        {
//            LaunchBrowser("CHROME");
//            LaunchApp(Url);


//        }
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
        



//        [When(@"User clicks on Select LITE button")]
//        public void WhenUserClicksOnSelectLITEButton()
//        {
//            ObjectMethod();
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
//        [AfterScenario]
//        public void AfterScenario()
//        {
//            Thread.Sleep(5000);
//            CloseBrowser();
//        }
//    }
//}
