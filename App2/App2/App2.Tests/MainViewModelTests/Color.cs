namespace App2.Tests.MainViewModelTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Color
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
            Assert.AreEqual(string.Empty, this.sut.Color);
        }
    }
}
