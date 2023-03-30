
namespace ExerciseQA.PageObjects.NewUser
{
    public partial class NewUser
    {
        public string MessageOutput(string id) => $"//p[@id='{id}']";
    }
}