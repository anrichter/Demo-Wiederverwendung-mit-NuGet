namespace App1.Tests.MainViewModelTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Name
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
    }
}
