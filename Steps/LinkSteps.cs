using TechTalk.SpecFlow;
using ExerciseQA.PageObjects;
using ExerciseQA.Models;

namespace ExerciseQA.Steps
{
    [Binding]
    public class LinkSteps
    {

    private readonly Links links;
	private readonly Common common;
	
	    public LinkSteps(Links links, Common common)
		{
			this.links= links;
		    this.common = common;
		}
        
        
       
       [Given(@"the user is at '(.*)'")]
        public async Task Giventheuserisat(string url)
        {
            await common.GoToWebPage(url);
        }

        [Given(@"chooses the area '(.*)' to start his exercise")]
        public async Task GivenchoosestheareaElementstostarthisexercise(string menu_elements)
        {
            await common.ClickMenuButton(menu_elements);
        }

        [Given(@"clicks '(.*)' at Elements menu")]
        public async Task GivenclicksTextBoxatElementsmenu(string menu_forms)
        {
            await common.ClickSideMenuButton(menu_forms);
        }

        [When(@"the user clicks on the link '(.*)'")]
        public async Task Whentheuserclicksonthelink(string status)
        {
            await links.ClickLink(status);
        }

        [Then(@"he sees the message Link has responded with status '(.*)' and status text '(.*)'")]
        public async Task Then_he_sees_the_message_Link_has_responded_with_status_and_statustext(string status_code,string text)
        {

            // Get status_code and text from webPage
            var actualValue = new LinksMessage(); 
            actualValue.response = await links.GetResponse(status_code);
            actualValue.text = await links.GetResponse(text);

            //Get full message from WebPage
            var full_msg = links.GetMessageDefault().ToString();

            //Check that the status code and the text are present in the full message.
            full_msg.Contains(actualValue.response);
            full_msg.Contains(actualValue.text);
        }

    }
}