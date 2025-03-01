﻿using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FreshMvvm.PopupSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SamplePopupPage : PopupPage
    {
        public SamplePopupPage()
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
