using Microsoft.Playwright;
namespace PlaywrightAutomation;

public class TestBase
{
    protected IPlaywright Playwright;
    protected IBrowser Browser;
    protected IPage Page;

    [SetUp]
    public async Task SetUp()
    {
        Playwright = await Microsoft.Playwright.Playwright.CreateAsync();

        Browser = await Playwright.Chromium.LaunchAsync(
            new BrowserTypeLaunchOptions
            {
                Headless = false
            });

        Page = await Browser.NewPageAsync();
    }

    [TearDown]
    public async Task TearDown()
    {
        // await Browser.CloseAsync();
        // Playwright.Dispose();
    }
}
