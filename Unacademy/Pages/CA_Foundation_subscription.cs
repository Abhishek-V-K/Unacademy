using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Unacademy
{
    public class CA_Foundation_subscription : UtilityClass
    {
        private IWebDriver driver;
        private By Heading_Path = By.ClassName("e1121ic30");
        private By PLUS_Plan_Switch_button = By.XPath("/html/body/div[1]/div[1]/div/div[3]/div[2]/div[1]/h4");
        private By ICONIC_Plan_Switch_button = By.XPath("/html/body/div[1]/div[1]/div/div[3]/div[2]/div[2]/h4");
        private By LITE_Plan_Switch_button = By.XPath("/html/body/div[1]/div[1]/div/div[3]/div[2]/div[2]/h4");
        private By View_all_plans_button = By.XPath("//button[text()='View all plans']");
        private By Have_a_refferal_code_Text_Box = By.XPath("//*[@id='__next']/div[1]/div/div[3]/div[4]/div/div[2]/div/input");
        private By Proceed_to_pay_button = By.XPath("//*[@id='__next']/div[1]/div/div[3]/div[4]/div/button");
        private By Accept_Cookies_button = By.XPath("/html/body/div[1]/div[1]/div/div[4]/div/div/button[2]");
        private By Apply_Referral_Code = By.XPath("//h6[@class='css-fswug9-H6-Apply egso1ul2']");
        private By Two_Months_Radio_button = By.XPath("//*[@id='__next']/div[1]/div/div[3]/div[3]/div[7]/div/div[1]");
        private By Login_button = By.XPath("//*[@id='__next']/div[1]/div/div[2]/div/div[1]/div[3]/button");
        private By Verify_OTP_Button = By.XPath("//*[@id='__next']/div[1]/div/div[2]/div/div[1]/div[2]/button");
        public CA_Foundation_subscription(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void HeadingText()
        {
            string expectedText = "CA Foundation subscription";
            string actualText = driver.FindElement(Heading_Path).Text;
            Assert.That(actualText, Is.EqualTo(expectedText));
            Console.WriteLine(actualText);
        }
        public void PLUSSwitchbutton()
        {
            driver.FindElement(PLUS_Plan_Switch_button).Click();    
        }
        public void ICONICSwitchbutton()
        {
            driver.FindElement(ICONIC_Plan_Switch_button).Click();
        }
        public void LITESwitchbutton()
        {
            driver.FindElement(LITE_Plan_Switch_button).Click();
        }
        public void Viewallplansbutton()
        {
            IWebElement secondElement = driver.FindElement(By.XPath("//button[text()='View all plans']"));
            Actions action = new Actions(driver);
            action.MoveToElement(secondElement).Perform();
            driver.FindElement(View_all_plans_button).Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement element = driver.FindElement(By.XPath("//*[@id='__next']/div[1]/div/div[3]/div[3]/div[7]/div"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        public void Proceedtopaybutton()
        {
            driver.FindElement(Proceed_to_pay_button).Click();
        }
        public void HaveArefferalcodeTextBox1()
        {
            driver.FindElement(Have_a_refferal_code_Text_Box).SendKeys("SAVE10");
        }

        public void HaveArefferalcodeTextBox2()
        {
            driver.FindElement(Have_a_refferal_code_Text_Box).SendKeys("SAVE100");
        }
        public void AcceptCookiesbutton()
        {
            IWebElement secondElement = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div[4]/div/div/button[2]"));
            Actions action = new Actions(driver);
            action.MoveToElement(secondElement).Perform();
            driver.FindElement(Accept_Cookies_button).Click();
        }

        public void ApplyReferralCode()
        {
            IWebElement secondElement = driver.FindElement(By.XPath("//h6[@class='css-fswug9-H6-Apply egso1ul2']"));
            Actions action = new Actions(driver);
            action.MoveToElement(secondElement).Perform();
            driver.FindElement(Apply_Referral_Code).Click();
        }
        public void TwoMonthsRadioButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement element = driver.FindElement(By.XPath("//*[@id='__next']/div[1]/div/div[3]/div[3]/div[7]/div/div[1]"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            driver.FindElement(Two_Months_Radio_button).Click();
        }

        public void Loginbutton()
        {
            driver.FindElement(Login_button).Click();
        }

        public void VerifyOTPButton()
        {
            driver.FindElement(Verify_OTP_Button).Click();
        }
    }
}













