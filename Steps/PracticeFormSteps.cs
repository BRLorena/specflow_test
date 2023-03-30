using TechTalk.SpecFlow;
using ExerciseQA.PageObjects;
using TechTalk.SpecFlow.Assist;
using ExerciseQA.Models;


namespace ExerciseQA.Steps
{
    [Binding]
    public class PracticeFormSteps
    {
        private readonly PracticeForm practiceform;
        private readonly Common common;

        public PracticeFormSteps(PracticeForm practiceform, Common common)
        {
            this.practiceform = practiceform;
            this.common = common;
        }
        
        
        [Given(@"clicks Practice Form at Forms menu")]
        public async Task GivenclicksPracticeFormatFormsmenu()
        {
            await common.ClickSideMenuButton("Practice Form");
        }


        [When(@"added the following user table")]
        public async Task Whenaddedthefollowingusertable(Table practiceFormValues)
        {
            PracticeFormFields formValues = practiceFormValues.CreateInstance<PracticeFormFields>();
            await practiceform.WriteUserInfo(formValues);
            await practiceform.ChooseGender(formValues.Gender);
            await practiceform.ChooseDate(formValues.DateofBirth);
            await practiceform.ChooseSubject(formValues.Subjects);
            await practiceform.ChooseHobbies(formValues.Hobbies);
            await practiceform.ChooseState(formValues.State);
            await practiceform.ChooseCity(formValues.City);
            await common.ClickSubmitButton();
        }

        [Then(@"the values that are presented of the user are")]
        public async Task Thenthevaluesthatarepresentedoftheuserare(Table practiceFormValuesValidation)
        {
            PracticeFormFieldsValidation formValidation = practiceFormValuesValidation.CreateInstance<PracticeFormFieldsValidation>();
            var realFormFields = await practiceform.GetFormFieldContent();
            System.Console.WriteLine(realFormFields.StudentName);
            System.Console.WriteLine(realFormFields.StudentEmail);
            System.Console.WriteLine(realFormFields.Gender);
            System.Console.WriteLine(realFormFields.Mobile);
            System.Console.WriteLine(realFormFields.DateofBirth);
            System.Console.WriteLine(realFormFields.Subjects);
            System.Console.WriteLine(realFormFields.Hobbies);
            System.Console.WriteLine(realFormFields.Picture);
            System.Console.WriteLine(realFormFields.Address);
            System.Console.WriteLine(realFormFields.StateandCity); //Here is the problem, I couldn't find the element on the page
            await practiceform.CloseForm();
        }
    }


}
