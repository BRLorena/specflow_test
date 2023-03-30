using ExerciseQA.Hooks;
using ExerciseQA.PageObjects.BasePages;
using ExerciseQA.Models;
namespace ExerciseQA.PageObjects
{
    public partial class WebTable : BasePage
    {
        private readonly Common common;

    public WebTable(Common common, Context context) : base(context)
    {
        this.common = common;
    }

    public async Task ClickAddButton()
    {
        await Click(AddBlueButton);
    }

    public async Task WriteUserInfo(WebTableForm formValues)
    {
        await EnterText(common.InputText("firstName"), formValues.FirstName);
        await EnterText(common.InputText("lastName"), formValues.LastName);
        await EnterText(common.InputText("userEmail"), formValues.Email);
        await EnterText(common.InputText("age"), formValues.Age);
        await EnterText(common.InputText("salary"), formValues.Salary);
        await EnterText(common.InputText("department"), formValues.Department);
    }

    public async Task ClickHeader(string name)
    {
        await Click(TableHeader(name));
    }

    public async Task<string> GetCellText(int row, int column)
    {
        return await GetText(TableCell(row, column));

    }

    public async Task<string[]> GetColumnValues(string columnName, int cellCount)
    {
        String[] columnValues = new string[cellCount];

        for (int i = 0; i < cellCount; i++)
        {
            columnValues[i] = await GetCellText(i+1, GetColumnPosition(columnName));
        }

        return columnValues;
    }

    private int GetColumnPosition(string columnName)
    {
        switch (columnName)
        {
            case "First Name":
                return 1;
    
            case "Last Name":
                return 2;

            case "Age":
                return 3;

            case "Email":
                return 4;

            case "Salary":
                return 5;

            case "Department":
                return 6;

            default:
                throw new ArgumentException("Column Name no found");
        }
    }

    }
}