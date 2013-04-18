using Android.App;
using KX.Platform.Android;
using Sample.Core.ViewModels;

namespace Sample.Android
{
    [Activity(Label = "Sample.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class HostingActivity : KXActivity
    {
        public HostingActivity()
        {
            ViewModelType = typeof (FirstScreenVm);
        }
    }
}