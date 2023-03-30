using ExerciseQA.Models;
using ExerciseQA.Hooks;
using Microsoft.VisualBasic;
using ExerciseQA.PageObjects.BasePages;
namespace ExerciseQA.PageObjects
{
    public partial class PracticeForm: BasePage
    {
        private readonly Common common;

        public PracticeForm(Common common, Context context) : base(context)
        {
            this.common = common;
        }

        public async Task WriteUserInfo(PracticeFormFields formValues)
        {
            await EnterText(common.InputText("firstName"), formValues.FirstName);
            await EnterText(common.InputText("lastName"), formValues.LastName);
            await EnterText(common.InputText("userEmail"), formValues.Email);
            await EnterText(common.InputText("userNumber"), formValues.Mobile);
            await EnterText(common.InputText("currentAddress"), formValues.CurrentAdress);
        }

        public async Task ChooseGender(string gender)
        {
            await Click(RadioButton(gender));
        }

        public async Task ChooseDate(string date)
        {
            // input->30-09-1992
            var dateArray = date.Split("-");
            var day = dateArray[0];
            var month = dateArray[1];
            var year = dateArray[2];

            // convert string to int
            int monthNr = Int32.Parse(month);

            // conver month number to "tipo o mes por extenso"
            var monthName = DateAndTime.MonthName(monthNr);

            await Click(DateButton);

            await SelectByIndex(MonthDropDown, monthNr-1);
            await SelectByLabel(YearDropDown, year);
            await Click(Day(monthName, day));
        }

        
        public async Task ChooseSubject(string subjects)
        {
            var subjectArray = subjects.Split(" ");
            
            foreach (var subject in subjectArray)
            {
                await EnterText((SubjectsField), subject);
                await SendKeys("Enter");
            
            }

        }

        public async Task ChooseHobbies(string hobbies)
        {
            var hobbieArray = hobbies.Split(",");
            
            foreach (var hobbie in hobbieArray)
            {
                await Click(HobbieField(hobbie.Trim()));
            }
        }

        public async Task ChooseState(string places)
        {
            await Click(DropDown("Select State"));
            await Click(DropDownOption(places));
        }

        public async Task ChooseCity(string places)
        {
            await Click(DropDown("Select City"));
            await Click(DropDownOption(places));
        }
        
        public async Task<PracticeFormFieldsValidation> GetFormFieldContent()
        {
            var practiceForm = new PracticeFormFieldsValidation();
            practiceForm.StudentName = await GetText(FormOutput("Student Name"));
            practiceForm.StudentEmail = await GetText(FormOutput("Student Email"));
            practiceForm.Gender = await GetText(FormOutput("Gender"));
            practiceForm.Mobile = await GetText(FormOutput("Mobile"));
            practiceForm.DateofBirth = await GetText(FormOutput("Date of Birth"));
            practiceForm.Subjects = await GetText(FormOutput("Subjects"));
            practiceForm.Hobbies = await GetText(FormOutput("Hobbies"));
            practiceForm.Picture = await GetText(FormOutput("Picture"));
            practiceForm.Address = await GetText(FormOutput("Address"));
            practiceForm.StateandCity = await GetText(FormOutput("State and City"));

            return practiceForm;

            
        }
        public async Task CloseForm()
        {
            await Click(CloseButton);
        }
    }
}