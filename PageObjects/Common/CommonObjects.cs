namespace ExerciseQA.PageObjects
{
    public partial class Common
    {
        public string MenuButton(string menuText) => $"//h5[text()='{menuText}']";
        public string SideMenuButton(string sidemenuText) => $"//span[text()='{sidemenuText}']";
        public string InputText(string id) => $"//*[@id='{id}']";
        public const string SubmitButton = "//*[@id='submit']";
    }
}