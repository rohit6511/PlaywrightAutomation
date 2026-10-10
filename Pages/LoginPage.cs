using Microsoft.Playwright;

namespace PlaywrightAutomation.Pages;

public class LoginPage
{
    private readonly IPage _page;

    public LoginPage(IPage page)
    {
        _page = page;
    }

    private ILocator Username =>
        _page.Locator("[name='username']");

    private ILocator Password =>
        _page.Locator("[name='password']");

    private ILocator LoginButton =>
        _page.Locator("[type='submit']");

    public async Task NavigateAsync()
    {
        await _page.GotoAsync(
            "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
    }

    public async Task LoginAsync(string username, string password)
    {
        await Username.FillAsync(username);
        await Password.FillAsync(password);
        await LoginButton.ClickAsync();
    }
}
