namespace Library.Tests.Mvvm.ViewModelBaseTests
{
    using Library.Mvvm;

    internal class TestViewModel : ViewModelBase
    {
        private int integerProperty;

        public int IntegerProperty
        {
            get
            {
                return this.integerProperty;
            }
            
            set
            {
                this.integerProperty = value;
                this.OnPropertyChanged();
            }
        }
    }
}
