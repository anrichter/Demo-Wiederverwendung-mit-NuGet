namespace App2
{
    using System;
    using System.ComponentModel;
    using Library.Mvvm;

    internal class MainViewModel : ViewModelBase
    {
        private string color = string.Empty;
        private string selectedColor = string.Empty;

        public MainViewModel()
        {
            this.PropertyChanged += this.MainViewModel_PropertyChanged;
        }

        public string Color
        {
            get
            {
                return this.color;
            }

            set
            {
                this.color = value;
                this.OnPropertyChanged();
            }
        }

        public string SelectedColor
        {
            get
            {
                return this.selectedColor;
            }

            set
            {
                this.selectedColor = value;
                this.OnPropertyChanged();
            }
        }

        private void MainViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Color")
            {
                this.SelectedColor = string.Format("You've selected {0}", this.Color);
            }
        }
    }
}
