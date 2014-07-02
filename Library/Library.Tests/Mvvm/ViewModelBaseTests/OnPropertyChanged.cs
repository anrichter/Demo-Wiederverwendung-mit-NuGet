namespace Library.Tests.Mvvm.ViewModelBaseTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class OnPropertyChanged
    {
        private TestViewModel sut;

        [TestInitialize]
        public void Initialize()
        {
            this.sut = new TestViewModel();
        }

        [TestMethod]
        public void Should_Call_PropertyChangedEventHandler()
        {
            // Arrange
            bool wasCalled = false;
            this.sut.PropertyChanged += (o, e) => { wasCalled = true; };

            // Act
            this.sut.IntegerProperty = 42;

            // Assert
            Assert.IsTrue(wasCalled);
        }

        [TestMethod]
        public void Should_Call_PropertyChangedEventHandler_With_Right_PropertyName()
        {
            // Arrange
            string propertyName = string.Empty;
            this.sut.PropertyChanged += (o, e) => { propertyName = e.PropertyName; };

            // Act
            this.sut.IntegerProperty = 42;

            // Assert
            Assert.AreEqual("IntegerProperty", propertyName);
        }
    }
}
