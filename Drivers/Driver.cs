using Microsoft.Playwright;

namespace ExerciseQA.Drivers
{
    public class Driver
    {
        public static async Task<IBrowserContext> CreatePlaywright()
        {
            //Playwright
            var playwright = await Playwright.CreateAsync();

            //Browser
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false    //I can see the browser
            });

            // Browser context options
            var browserContextOps = new BrowserNewContextOptions
            {
                ViewportSize = new ViewportSize()
                {
                    Width = 640,
                    Height = 480
                }
            };
            
            // Browser context
            var context = browser.NewContextAsync(new (browserContextOps));
            
            return await context;
        }
    }
}