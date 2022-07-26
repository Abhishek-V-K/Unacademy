
using OpenQA.Selenium;

namespace Unacademy
{
    public class LoginPage : UtilityClass
    {
        private IWebDriver driver;

        
        private By Login_Button = By.CssSelector("#__next > header > div > div > button");
        private By Enter_your_mobile_number_Text_Box = By.ClassName("MuiOutlinedInput-inputAdornedStart");
        private By Click_On_Login_Button = By.XPath("//*[@id='DrawerPaper']/div[2]/div[3]/button");
        private By Verify_OTP = By.XPath("//*[@id='DrawerPaper']/div[2]/div[2]/button");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void LoginButton()
        {
            driver.FindElement(Login_Button).Click();
        }



        public void MobileNumberTextBox(String MobileNumber)
        {
            driver.FindElement(Enter_your_mobile_number_Text_Box).SendKeys(MobileNumber);
        }

        public void LoginButton1()
        {
            driver.FindElement(Click_On_Login_Button).Click();
        }

        public void Verify_OTP_Button()
        {
            driver.FindElement(Verify_OTP).Click();
        }

    }
}

