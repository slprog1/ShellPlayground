using System;
using System.Threading.Tasks;

namespace Playground_Shell.ViewModels
{
    public class LoadingViewModel : BaseViewModel
    {
        public LoadingViewModel()
        {
        }

        public async void Init()
        {
            Acr.UserDialogs.UserDialogs.Instance.ShowLoading("loading.....");
            await Task.Delay(3000);

            Acr.UserDialogs.UserDialogs.Instance.HideLoading();
            await Task.Delay(3000);

            if (true)
            {
                await AppShell.Current.GoToAsync("//authorized/home");
            }
            else
            {
                await AppShell.Current.GoToAsync("//unauthorized/home");
            }
        }
    }
}
