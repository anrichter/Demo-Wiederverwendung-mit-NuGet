namespace App1
{
    using System.ComponentModel;
    using Library.Mvvm;

    internal class MainViewModel : ViewModelBase
    {
        private string name = string.Empty;
        private string greetings = string.Empty;

        public MainViewModel()
        {
            this.PropertyChanged += this.MainViewModel_PropertyChanged;
        }

        public string Name 
        {
            get 
            {
                return this.name;
            }
            
            set
            {
                this.name = value;
                this.OnPropertyChanged();
            }
        }

        public string Greetings
        {
            get
            {
                return this.greetings;
            }

            set
            {
                this.greetings = value;
                this.OnPropertyChanged();
            }
        }

        private void MainViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Name")
            {
                this.Greetings = string.Format("Hello {0}", this.Name);
            }
        }
    }
}
