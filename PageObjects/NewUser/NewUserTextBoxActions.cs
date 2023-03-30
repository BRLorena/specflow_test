using ExerciseQA.Hooks;
using ExerciseQA.Models;
using ExerciseQA.PageObjects.BasePages;

namespace ExerciseQA.PageObjects.NewUser;

public partial class NewUser : BasePage
{
    private readonly Common common;
    public NewUser(Common common, Context context) : base(context)
    {
        this.common = common;
    }
    
    public async Task WriteNewUserInfo(NewUserTextBox formValues)
    {
        await EnterText(common.InputText("userName"), formValues.FullName);
        await EnterText(common.InputText("userEmail"), formValues.Email);
        await EnterText(common.InputText("currentAddress"), formValues.CurrentAdress);
        await EnterText(common.InputText("permanentAddress"), formValues.PermanentAdress);
    }

    public async Task<NewUserValidation> GetMessageContent()
    {
        var user = new NewUserValidation();
        user.Name = await GetText(MessageOutput("name"));
        user.Email = await GetText(MessageOutput("email"));
        user.CurrentAdress = await GetText(MessageOutput("currentAddress"));
        user.PermanentAdress = await GetText(MessageOutput("permanentAddress"));

        user.Name = user.Name.Split(":")[1];
        user.Email = user.Email.Split(":")[1];
        user.CurrentAdress = user.CurrentAdress.Split(":")[1];
        user.PermanentAdress = user.PermanentAdress.Split(":")[1];

        return user;
    }
}