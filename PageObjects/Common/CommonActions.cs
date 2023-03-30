using ExerciseQA.Hooks;
using ExerciseQA.PageObjects.BasePages;

namespace ExerciseQA.PageObjects;

    public partial class Common : BasePage
    {
        public Common(Context context) : base(context)
        {
        }
        
        public async Task GoToWebPage(string url)
        {
            await Navigate(url);
        }

        public async Task ClickMenuButton(string menuText)
        {
            await Click(MenuButton(menuText));
        }

        public async Task ClickSideMenuButton(string menuText)
        {
            await Click(SideMenuButton(menuText));
        }

        public async Task ClickSubmitButton()
        {
            await Click(SubmitButton);
        }

        public async Task WriteText(string selector, string text)
        {
            await EnterText(selector, text);
        }
    }
