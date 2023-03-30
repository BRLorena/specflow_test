using ExerciseQA.Models;
using ExerciseQA.Hooks;
using ExerciseQA.PageObjects.BasePages;

namespace ExerciseQA.PageObjects
{
    public partial class Links : BasePage
    {
        private readonly Common common;

        public Links(Common common, Context context) : base(context)
        {
            this.common = common;
        }

        public async Task ClickLink(string status)
        {
            await Click(LinkStatus(status));
        }

        public async Task<string> GetResponse(string msg)
        {
        
            return await GetText(validateMsg(msg));

        }

        public async Task<string> GetMessageDefault()
        {
            string full_msg = await GetText(LinkMessage("linkResponse"));

            return full_msg;
        }
    }
}