
namespace ExerciseQA.PageObjects
{
    public partial class WebTable
    {
    public const string AddBlueButton = "//button[text()='Add']";

    public string TableCell(int row, int column) => $"//div[@class='rt-tbody']/div[{row}]/div/div[{column}]";

    public string TableHeader(string name) => $"//div[@class='rt-tr']//div[text()='{name}']";
    }
}