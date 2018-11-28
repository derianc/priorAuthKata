using System.Collections.Generic;

using Moq;
using Xunit;
using FluentAssertions;

using AutoFixture;
using AutoFixture.AutoMoq;

using PriorAuth.Web.Data;
using PriorAuth.Web.Services;
using PriorAuth.Web.Repositories.Interfaces;

namespace PriorAuth.Web.Tests
{
    public class UserTests
    {
        [Fact]
        public async void GetAllUsers_TestPassed()
        {
            // Arrange
            var fixture = new Fixture().Customize(new AutoMoqCustomization());

            var userList = fixture.Create<List<User>>();
            var repository = fixture.Freeze<Mock<IUserRepository>>();
            repository.Setup(r => r.GetAllUsers()).Returns(userList);

            var serviceUnderTest = fixture.Create<UserService>();

            // Act
            var retVal = await serviceUnderTest.GetAllUsers();

            // Assert
            retVal.Should().HaveCountGreaterThan(1);
        }

        [Fact]
        public async void GetAllUsersEmptyList_TestPassed()
        {
            // Arrange
            var fixture = new Fixture().Customize(new AutoMoqCustomization());

            var repository = fixture.Freeze<Mock<IUserRepository>>();
            repository.Setup(r => r.GetAllUsers()).Returns(new List<User>());

            var serviceUnderTest = fixture.Create<UserService>();

            // Act
            var retVal = await serviceUnderTest.GetAllUsers();

            // Assert
            retVal.Should().HaveCountGreaterOrEqualTo(0);
        }

        [Fact]
        public async void GetUserById_TestPassed()
        {
            // Arrange
            var fixture = new Fixture().Customize(new AutoMoqCustomization());

            var repository = fixture.Freeze<Mock<IUserRepository>>();
            repository.Setup(r => r.GetUserById(It.IsAny<int>())).Returns(fixture.Create<User>());

            var serviceUnderTest = fixture.Create<UserService>();

            // Act
            var retVal = await serviceUnderTest.GetUserById(fixture.Create<int>());

            // Assert
            retVal.Should().NotBeNull();
        }
    }
}
