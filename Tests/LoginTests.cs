using Microsoft.Playwright.NUnit;

namespace PlaywrightAutomation.Tests;

public class LoginTests : TestBase
{
    [Test]
    public async Task OpenGoogle()
    {
        await Page.GotoAsync("https://www.flipkart.com/");

        Console.WriteLine(await Page.TitleAsync());
    }
}