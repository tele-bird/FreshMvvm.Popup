using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FreshMvvm.PopupSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondSamplePopupPage : PopupPage
    {
        public SecondSamplePopupPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearingAnimationBegin()
        {
            base.OnAppearingAnimationBegin();
            PopupMainView.IsVisible = true;
        }
    }
}

