//using System;
//using TechTalk.SpecFlow;

//namespace Unacademy
//{
//    [Binding]
//    public class Login_ButtonStepDefinitions : ApplicationHooks
//    {
//        [Given(@"Chrome is launched and Unacademy application is launched")]
//        public void GivenChromeIsLaunchedAndUnacademyApplicationIsLaunched()
//        {
//            Console.WriteLine("Chrome Is Launched And Unacademy Application Is Launched");
//        }

//        [When(@"User clicks on login button")]
//        public void WhenUserClicksOnLoginButton()
//        {
//            Thread.Sleep(10000);
//            LP.LoginButton();

//        }

//        [When(@"User enters Registered Phone Number (.*)")]
//        public void WhenUserEntersRegisteredPhoneNumber(String RegisteredPhoneNumber)
//        {
//            Thread.Sleep(11000);
//            LP.MobileNumberTextBox(RegisteredPhoneNumber);
//            LP.LoginButton1();
//            Thread.Sleep(30000);
//            LP.Verify_OTP_Button();
//        }

//        [Then(@"It shows home page")]
//        public void ThenItShowsHomePage()
//        {
//            Thread.Sleep(5000);
//            Console.WriteLine("Home Page Is Displayed");
//        }
//    }
//}
