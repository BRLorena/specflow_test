using ExerciseQA.Models;
using NUnit.Framework;
using FluentAssertions;
namespace ExerciseQA.PageObjects
{
    public partial class WebTable
    {
        public async Task CheckTableRow(int row, WebTableForm expectedRowContent)  
    {
        var actualRowContent = new WebTableForm();
        actualRowContent.FirstName = await GetCellText(row, 1);
        actualRowContent.LastName = await GetCellText(row, 2);
        actualRowContent.Email = await GetCellText(row, 4);
        actualRowContent.Age = await GetCellText(row, 3);
        actualRowContent.Salary = await GetCellText(row, 5);
        actualRowContent.Department = await GetCellText(row, 6);

        expectedRowContent.FirstName.Should().Be(actualRowContent.FirstName);
        expectedRowContent.LastName.Should().Be(actualRowContent.LastName);
        expectedRowContent.Email.Should().Be(actualRowContent.Email);
        expectedRowContent.Age.Should().Be(actualRowContent.Age);
        expectedRowContent.Salary.Should().Be(actualRowContent.Salary);
        expectedRowContent.Department.Should().Be(actualRowContent.Department);
            
    }
    }
}