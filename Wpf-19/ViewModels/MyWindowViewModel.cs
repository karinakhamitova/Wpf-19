using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_19.Models;

namespace Wpf_19.ViewModels
{
    class MyWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        private double number1;

        public double Number1
        {
            get { return number1; }
            set
            {
                number1 = value;
                OnPropertyChanged();
            }
        }
        private double number2;

        public double Number2
        {
            get { return number2; }
            set
            {
                number2 = value;
                OnPropertyChanged();
            }
        }
      
        public ICommand AddCommand { get; }
        private void OnAddCommandExecute(object p) 
        {
            Number2 = Arif.Lenght(Number1);
        }
        private bool CanAddCommandExecuted(object p)
        {
            if (Number1!=0)
                return true;
            else
                return false;
        }
        public MyWindowViewModel()
        {
            AddCommand = new RelayCommand(OnAddCommandExecute, CanAddCommandExecuted);
        }
    }
}
