using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SignupApp.ViewModels
{
    [QueryProperty(nameof(Username), "Username")]
    [QueryProperty(nameof(Email), "Email")]
    public class ProfilePageViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _email;

        public string Username
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand SignoutCommand { get; }

        public ProfilePageViewModel()
        {
            SignoutCommand = new Command(OnSignoutClicked);
        }

        private async void OnSignoutClicked()
        {
            // Navigate back to signup page
            await Shell.Current.GoToAsync("//signup");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
