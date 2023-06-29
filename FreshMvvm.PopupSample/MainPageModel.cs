using System;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace FreshMvvm.PopupSample
{
    public class MainPageModel : FreshBasePageModel
    {
        public string Title { get; set; } = "Main Page";

        public override void ReverseInit(object returnedData)
        {
            base.ReverseInit(returnedData);
            Title = (string)returnedData;
        }

        public Command OpenSecondPageCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await CoreMethods.PushPageModel<SecondPageModel>(Title);
                });
            }
        }
    }
}
