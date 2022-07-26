using OpenQA.Selenium;


namespace Unacademy
{
    public class ConfigClass
    {

        public static IWebDriver driver;
        public static string ChromeDriverPath = @"C:\Users\abhis\source\repos\Unacademy\Unacademy\WebDrivers\";
        public static string GeckoDriverPath = @"C:\Users\abhis\source\repos\Unacademy\Unacademy\WebDrivers\";
        
        public static string Url = "https://unacademy.com/goal/ca-foundation/BBKWG";




        public static string filePath = @"C:\Users\abhis\source\repos\Unacademy\Unacademy\Screenshots\";

        public static int PAGE_LOAD_TIMEOUT = 10;
        public static int IMPLICIT_WAIT = 10;


    }
}
