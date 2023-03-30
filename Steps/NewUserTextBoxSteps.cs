using TechTalk.SpecFlow;
using ExerciseQA.PageObjects;
using ExerciseQA.Models;
using TechTalk.SpecFlow.Assist;
using ExerciseQA.PageObjects.NewUser;

namespace ExerciseQA.Steps
{
    [Binding]
    public class NewUserTextBoxSteps
    {
        private readonly Common common;
        private readonly NewUser newUser;
        public NewUserTextBoxSteps(Common common, NewUser newUser)
        {
            this.common = common;
            this.newUser = newUser;
        }
        
        [Given(@"clicks Text Box at Elements menu")]
        public async Task GivenclicksTextBoxatElementsmenu()
        {
            await common.ClickSideMenuButton("Text Box");
        }

        [When(@"the user submits the new user information")]
        public async Task Whentheusersubmitsthenewuserinformation(Table tableFormValues)
        {
            NewUserTextBox formValues = tableFormValues.CreateInstance<NewUserTextBox>();
            await newUser.WriteNewUserInfo(formValues);
            await common.ClickSubmitButton();
        }

        [Then(@"the user sees a box with the created user")]
        public async Task Thentheuserseesaboxwiththecreateduser(Table tableValidation)
        {
            var formValidation = tableValidation.CreateInstance<NewUserValidation>();
            var realUser = await newUser.GetMessageContent();
            newUser.CheckMessageContent(formValidation, realUser);
        }

    }
}