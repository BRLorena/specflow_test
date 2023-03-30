namespace ExerciseQA.PageObjects
{
    public partial class PracticeForm
    {
        public string RadioButton(string gender) => $"//label[text()='{gender}']";

    public const string DateButton = "//*[@id='dateOfBirthInput']";
    
    public const string MonthDropDown = "//select[contains(@class, 'month')]";

    public const string YearDropDown = "//select[contains(@class, 'year')]";

    public string Day(string month, string day) => $"//div[contains(@aria-label, '{month}') and text()='{day}']";
        
    public const string SubjectsField = "//input[@id='subjectsInput']";
        
    public string HobbieField(string hobbie) => $"//label[text()='{hobbie}']";

    public string DropDown(string text) => $"//div[text()='{text}']";

    public string DropDownOption(string text) => $"//div[text()='{text}']";

    public string FormOutput(string text) => $"//td[text()='{text}']"; 

    public const string CloseButton = "//button[@id='closeLargeModal']";
    }
}