using NUnit.Framework;
using Microsoft.Playwright;
using FluentAssertions;
using ExerciseQA.Models;

namespace ExerciseQA.PageObjects.NewUser
{
    public partial class NewUser
    {
        public void CheckMessageContent(NewUserValidation expectedUser, NewUserValidation actualUser)
    {
        expectedUser.Name.Should().Be(actualUser.Name);
        expectedUser.Email.Should().Be(actualUser.Email);
        expectedUser.CurrentAdress.Should().Be(actualUser.CurrentAdress);
        expectedUser.PermanentAdress.Should().Be(actualUser.PermanentAdress);
    }
    }
}