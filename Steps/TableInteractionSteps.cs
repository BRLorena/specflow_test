using System;
using ExerciseQA.PageObjects;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace MyNamespace
{
    [Binding]
    public class TableInteractionSteps
    {
        private readonly WebTable webTable;
        private readonly Common common;

        public TableInteractionSteps(Common common, WebTable webTable)
        {
            this.common = common;
            this.webTable = webTable;
        }


        [Given(@"clicks Web Tables at Elements menu")]
        public async Task GivenclicksTextBoxatElementsmenu()
        {
            await common.ClickSideMenuButton("Web Tables");
        }

        [When(@"the user orders columns by '(.*)'")]
        public async Task Whentheuserorderscolumnsby(string name)
        {
            await webTable.ClickHeader(name);
        }

        [Then(@"the values of '(.*)' are ordered")]
        public async Task Thenthevaluesofareordered(string name)
        {
            //read values from table -> build our array
            //order values -> Expeceted array
            //check if ordered values and the actual values are the same

            String[] columnValues = await webTable.GetColumnValues(name, 3);
            Array.Sort(columnValues);

            String[] actualValues = await webTable.GetColumnValues(name, 3);

            Assert.AreEqual(columnValues, actualValues);
        }

    }
}