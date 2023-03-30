using Microsoft.Playwright;

namespace ExerciseQA.Hooks
{
    public class Context
    {
        public IBrowserContext BrowserContext { get; set; }
        public IPage Page { get; set; }
    }
}