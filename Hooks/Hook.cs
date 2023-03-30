using Microsoft.Playwright;
using TechTalk.SpecFlow;
using ExerciseQA.Drivers;
using NUnit.Framework; 

[assembly: Parallelizable(ParallelScope.Fixtures)]
namespace ExerciseQA.Hooks

{
    [Binding]
    public class Hooks
    {
        private readonly Context _context;

        public Hooks (Context context)
        {
            _context = context;
        }

        [BeforeScenario]
        public async Task BeforeScenario()
        {
            _context.BrowserContext = await Driver.CreatePlaywright();
            _context.Page = await _context.BrowserContext.NewPageAsync();
        }

        [AfterScenario]
        public async Task AfterScenario()
        {
            await _context.Page.CloseAsync();
        }
    }
}