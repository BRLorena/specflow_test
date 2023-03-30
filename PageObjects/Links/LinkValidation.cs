using FluentAssertions;
using ExerciseQA.Models;

namespace ExerciseQA.PageObjects
{
    public partial class Links
    {
        
        public async Task CheckMessageContent(string status_code, string text)
        {
            var actualValue = new LinksMessage(); 
            actualValue.response = await GetResponse(status_code);
            actualValue.text = await GetResponse(text);
            
            var expectedStatus = new LinksMessage(); 
            expectedStatus.response.Should().Be(actualValue.response);
            expectedStatus.text.Should().Be(actualValue.text);
            
        }
    }
}