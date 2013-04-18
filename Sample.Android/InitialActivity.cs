using Android.App;
using KX.Android;
using Sample.Core;

namespace Sample.Android
{
    [Activity(Label = "Sample.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class InitialActivity : KXActivity
    {
        public InitialActivity()
        {
            SetApplicationType(typeof (SampleApplication));
        }
    }
}