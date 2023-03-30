using ExerciseQA.PageObjects;
using TechTalk.SpecFlow.Assist;
using ExerciseQA.Models;
using TechTalk.SpecFlow;

namespace ExerciseQA.Steps
{
    [Binding]
    public class WebTableSteps
    {
        private readonly Common common;
        private readonly WebTable webTable;

        public WebTableSteps(Common common, WebTable webTable)
        {
            this.common = common;
            this.webTable = webTable;
        }

        [Given(@"the user has the page '(.*)' loaded")]
        public async Task Giventheuserisat(string url)
        {
            await common.GoToWebPage(url);
        }

        [When(@"added the following user")]
        public async Task Whenaddedthefollowinguser(Table webTableForm)
        {
            await webTable.ClickAddButton();
            WebTableForm formValues = webTableForm.CreateInstance<WebTableForm>();
            await webTable.WriteUserInfo(formValues);
            await common.ClickSubmitButton();
        }

        [Then(@"sees the user at the table")]
        public async Task Thenseestheuseratthetable(Table webtableValidation)
        {
           WebTableForm formValidation = webtableValidation.CreateInstance<WebTableForm>();
           await webTable.CheckTableRow(4, formValidation);
        }

    }
}