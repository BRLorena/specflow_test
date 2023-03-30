

namespace ExerciseQA.PageObjects
{
    public partial class Links
    {
    public string LinkStatus(string status) => $"//*[@id='{status}']";

    public string LinkMessage(string message) => $"//*[@id='{message}']"; 

    public string validateMsg(string status) => $"//*[@id='linkResponse']/b[text()='{status}']";
    }
}