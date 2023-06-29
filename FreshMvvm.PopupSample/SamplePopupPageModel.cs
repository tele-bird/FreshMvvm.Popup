using System.Diagnostics;
using FreshMvvm.Popups;
using Xamarin.Forms;

namespace FreshMvvm.PopupSample
{
    public class SamplePopupPageModel : FreshBasePageModel
    {
        public string Title { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);
            Title = (string)initData;
        }

        public override void ReverseInit(object returnedData)
        {
            base.ReverseInit(returnedData);
            Title = (string)returnedData;
        }

        public Command OpenPopupCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await CoreMethods.PushPopupPageModel<SecondSamplePopupPageModel>(Title);
                });
            }
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
