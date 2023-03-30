using System;
using ExerciseQA.Hooks;
using Microsoft.Playwright;

namespace ExerciseQA.PageObjects.BasePages
{
    public class BasePage
    {
      private readonly IPage _page;

        public BasePage(Context context)
        {
            _page = context.Page;
        }

        public async Task Navigate(string url)
        {
            await _page.GotoAsync(url);
        
        }
        // public async Task InputText(string id)
        // {
        //     await _page.Locator(id);
        // }

        // public async Task MessageOutput(string id)
        // {
        //     await _page.Locator(id);
        // }

        public async Task Click(string selector)
        {
            await _page.Locator(selector).ClickAsync();
        }

        public async Task EnterText(string selector, string value)
        {
            await _page.Locator(selector).FillAsync(value);
        }

        public async Task<string> GetText(string selector)
        {
            return await _page.Locator(selector).InnerTextAsync();
        }

        public async Task SendKeys(string buttonName)
        {
            await _page.Keyboard.PressAsync(buttonName);
        }

        public async Task SelectByLabel(string selector, string optionLabel)
        {
            SelectOptionValue options = new SelectOptionValue
            {
                Label = optionLabel
            };
            await _page.Locator(selector).SelectOptionAsync(options);
        }

        public async Task SelectByIndex(string selector, int optionIndex)
        {
            SelectOptionValue options = new SelectOptionValue
            {
                Index = optionIndex
            };
            await _page.Locator(selector).SelectOptionAsync(options);
        }  
    }
}