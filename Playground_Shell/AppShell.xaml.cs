using System;
using System.Collections.Generic;
using Playground_Shell.ViewModels;
using Xamarin.Forms;

namespace Playground_Shell
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //BindingContext = new FlowViewModel();
        }

        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    if( BindingContext is FlowViewModel vm)
        //    {
        //        vm.Init();
        //    }                
        //}
    }
}
