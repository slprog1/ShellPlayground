using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Playground_Shell.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
        }

        public async void Init()
        {
            if(true)
            {
                await AppShell.Current.GoToAsync("");
            }
        }

        public ICommand OpenWebCommand { get; }
    }
}