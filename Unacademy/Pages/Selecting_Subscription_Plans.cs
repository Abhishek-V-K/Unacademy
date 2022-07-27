using OpenQA.Selenium;

namespace Unacademy
{
    public class Selecting_Subscription_Plans : UtilityClass
    {
        private IWebDriver driver;
        private By Get_subscription_button = By.XPath("//*[@id='preSubscribedBlocks']/div[1]/div[5]/button[1]");
        private By Select_PLUS_button = By.XPath("//*[text()='Select PLUS']");
        private By Select_ICONIC_button = By.XPath("//*[text()='Select ICONIC']"); 
        private By Select_LITE_button = By.XPath("//*[text()='Select LITE']");
        private By Learn_more_button = By.XPath("//*[@id='__next']/div[1]/div/div[4]/div[3]/button[2]");
        public Selecting_Subscription_Plans(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickOnGetSubscriptionButton()
        {
            driver.FindElement(Get_subscription_button).Click();
        }

        public void ClickOnSelectPLUSButton()
        {
            driver.FindElement(Select_PLUS_button).Click();
        }
        public void ClickOnSelectICONICButton()
        {
            driver.FindElement(Select_ICONIC_button).Click();
        }
        public void ScrollDown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement element = driver.FindElement(By.XPath("//*[text()='Select LITE']"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        public void ClickOnSelectLITEButton()
        {
            driver.FindElement(Select_LITE_button).Click();
        }

        public void Learnmorebutton()
        {
            driver.FindElement(Learn_more_button).Click();
        }
    }
}














