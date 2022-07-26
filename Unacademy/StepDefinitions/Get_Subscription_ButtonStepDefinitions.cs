//using NUnit.Framework;
//using System;
//using TechTalk.SpecFlow;

//namespace Unacademy
//{
//    [Binding]
//    public class Get_Subscription_ButtonStepDefinitions : ApplicationHooks
//    {
//        [Given(@"Chrome is launched and Unacademy application is launched")]
//        public void GivenChromeIsLaunchedAndUnacademyApplicationIsLaunched()
//        {
//            Console.WriteLine("Chrome Is Launched And Unacademy Application Is Launched");
//            Thread.Sleep(2000);
       
//        }

//        [When(@"User clicks on Get subscription button")]
//        public void WhenUserClicksOnGetSubscriptionButton()
//        {
//            Thread.Sleep(2000);
//            GB.ClickOnGetSubscriptionButton();
//            String actualTitle = ValidatePageTitle();
//            Console.WriteLine(actualTitle);
//        }

//        [Then(@"It shows subscription plan page")]
//        public void ThenItShowsSubscriptioPlanPage()
//        {
//            Thread.Sleep(2000);
//            String expectedTitle = "Crack your CA Foundation Exam with Unacademy | Unacademy";
//            String actualTitle = ValidatePageTitle();
//            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
//            Console.WriteLine(actualTitle);
//            CaptureScreenshot();
      
//        }
//    }
//}
