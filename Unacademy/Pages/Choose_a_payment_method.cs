using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace Unacademy
{
    public class Choose_a_payment_method : UtilityClass
    {
        private IWebDriver driver;
        private By Card_Option = By.XPath("//*[@id='__next']/div[1]/div/div[2]/div[2]/div/div/div[2]/p");
        private By Card_number = By.ClassName("card_number");
        private By Valid_through_MM = By.XPath("//input[@placeholder='MM']");
        private By Valid_through_YY = By.XPath("//input[@placeholder='YY']");
        private By Name_on_card = By.XPath("//*[@id='name_on_card']");
        private By Net_banking_Option = By.XPath("//*[@id='__next']/div[1]/div/div[2]/div[2]/div/div/div[3]/p");
        private By Select_a_bank_Drop_Down = By.XPath("//input[@placeholder='Select a bank']");
        private By Selecting_a_Bank_Name = By.XPath("//*[@id='payment_form_nb']/div/div[5]/div/div[2]/div[3]/div/p");
        private By UPI_option = By.XPath("//*[@id='__next']/div[1]/div/div[2]/div[2]/div/div/div[4]/p");
        private By Enter_UPI_ID_Text_Box = By.XPath("//*[@id='payment_form_upi']/div[1]/div/input");
        private By Select_a_bank_name_UPI_DropDown = By.XPath("//*[@id='payment_form_upi']/div[1]/div/div/div/div[2]/div[2]/div[6]/div/p");
        public Choose_a_payment_method(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Cardoption()
        {
            driver.FindElement(Card_Option).Click();
        }

        public void Cardnumber()
        {
            driver.FindElement(Card_number).SendKeys("123456");
        }
        public void ValidThroughMM()
        {
            driver.FindElement(Valid_through_MM).SendKeys("08");
        }
        public void ValidThroughYY()
        {
            driver.FindElement(Valid_through_YY).SendKeys("28");
        }
        public void NameOnCard()
        {
            driver.FindElement(Name_on_card).SendKeys("Abhishek");
            driver.FindElement(Name_on_card).Clear();
        }
         public void Netbanking()
        {
            driver.FindElement(Net_banking_Option).Click();
        }
        public void SelectingabankDropdown()
        {

            IWebElement secondElement = driver.FindElement(Select_a_bank_Drop_Down);
            Actions action = new Actions(driver);
            action.MoveToElement(secondElement).Perform();
            driver.FindElement(Select_a_bank_Drop_Down).Click();


        }
        public void Selectingabankname()
        {
            IWebElement ondElement = driver.FindElement(Selecting_a_Bank_Name);
            Actions act = new Actions(driver);
            act.MoveToElement(ondElement).Perform();
            driver.FindElement(Selecting_a_Bank_Name).Click();
        }
        public void UPIoption()
        {
            driver.FindElement(UPI_option).Click();
        }
        public void EnteringUPIID(string upiid)
        {
            driver.FindElement(Enter_UPI_ID_Text_Box).SendKeys(upiid);
        }
        public void SelectingUPIBankDropDown()
        {
            IWebElement secondElement = driver.FindElement(By.XPath("//input[@placeholder='Select a bank']"));
            Actions action = new Actions(driver);
            action.MoveToElement(secondElement).Perform();
            driver.FindElement(By.XPath("//input[@placeholder='Select a bank']")).Click();
        }
        public void SelectingUPIBankNameFromDropDown()
        {
            
            IWebElement ondElement = driver.FindElement(By.XPath("//*[@id='payment_form_upi']/div[1]/div/div/div/div[2]/div[2]/div[6]/div/p"));
            Actions act = new Actions(driver);
            act.MoveToElement(ondElement).Perform();
            driver.FindElement(Select_a_bank_name_UPI_DropDown).Click();
        }




    }
}












