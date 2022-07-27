using OpenQA.Selenium;
using System.Collections;


namespace Unacademy
{
    public class Get_subscription : UtilityClass
    {
        private IWebDriver driver;
        private By OK_GOT_IT_pop_up = By.ClassName("ehhmpcf4");
        private By Get_subscription_button = By.XPath("//*[@id='preSubscribedBlocks']/div[1]/div[5]/button[1]");
        private By Experience_our_2021_recap = By.ClassName("e1k53atl4");


        public Get_subscription(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void ClickOnGetSubscriptionButton()
        {
            driver.FindElement(Get_subscription_button).Click();
        }
        public void OKGOTITpopup()
        {
            driver.FindElement(OK_GOT_IT_pop_up).Click();
        }

        public void Experienceour2021recap()
        {
            string parent_window = driver.CurrentWindowHandle;
            Console.WriteLine(parent_window);
            driver.FindElement(Experience_our_2021_recap).Click();

            IList all_windows = driver.WindowHandles;
            int count = all_windows.Count;
            Console.WriteLine(count);



            foreach (string child_window in all_windows)
            {
                if (!parent_window.Equals(child_window))
                {
                    driver.SwitchTo().Window(child_window);
                    Console.WriteLine("Child window title --> " + driver.Title);
                }
            }



            Thread.Sleep(2000);



            driver.Close();



            Thread.Sleep(2000);
        }
    }
}











