using System.Diagnostics;
using FreshMvvm.Popups;
using Xamarin.Forms;

namespace FreshMvvm.PopupSample
{
    public class SecondSamplePopupPageModel : FreshBasePageModel
    {
        public string Title { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);
            Title = (string)initData;
        }

        public Command ClosePopupCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await CoreMethods.PopPopupPageModel(Title);
                });
            }
        }
    }
}
