namespace App1.Tests.MainViewModelTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Greetings
    {
        private MainViewModel sut;

        [TestInitialize]
        public void Initialize()
        {
            this.sut = new MainViewModel();
        }

        [TestMethod]
        public void Should_Return_EmptyString_After_Initialization()
        {
            Assert.AreEqual(string.Empty, this.sut.Greetings);
        }

        [TestMethod]
        public void Should_Return_Greetings_After_Name_Was_Set()
        {
            // Arrange
            var name = "Hans Wurst";
            var exprectedGreetings = string.Format("Hello {0}", name);

            // Act
            this.sut.Name = name;

            // Assert
            Assert.AreEqual(exprectedGreetings, this.sut.Greetings);
        }
    }
}
