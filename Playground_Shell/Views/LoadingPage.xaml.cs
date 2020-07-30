using System;
using System.Collections.Generic;
using Playground_Shell.ViewModels;
using Xamarin.Forms;

namespace Playground_Shell.Views
{
    public partial class LoadingPage : ContentPage
    {
        public LoadingPage()
        {
            InitializeComponent();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            if(BindingContext is LoadingViewModel vm)
            {
                vm.Init();
            }
        }
    }
}
