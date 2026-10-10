using System.Text.RegularExpressions;
using Microsoft.Playwright;

namespace PlaywrightAutomation.Tests;

public class DashboardTests : TestBase
{
    [Test]
    public async Task VerifyDashboard()
    {
        await LoginToApplicationAsync();

        await Assertions.Expect(Page)
            .ToHaveURLAsync(new Regex("dashboard"));
    }
}
