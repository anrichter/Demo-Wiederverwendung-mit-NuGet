namespace App2.Tests.MainViewModelTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SelectedColor
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
            Assert.AreEqual(string.Empty, this.sut.SelectedColor);
        }

        [TestMethod]
        public void Should_Return_SelectedColor_After_Color_Was_Set()
        {
            // Arrange
            var color = "blue";
            var exprectedSelectedColor = string.Format("You've selected {0}", color);

            // Act
            this.sut.Color = color;

            // Assert
            Assert.AreEqual(exprectedSelectedColor, this.sut.SelectedColor);
        }
    }
}
