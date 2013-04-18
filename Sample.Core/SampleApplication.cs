using KX.Core;
using Sample.Core.ViewModels;

namespace Sample.Core
{
    public class SampleApplication : KXApplication
    {
        public SampleApplication()
        {
            InitialViewModel = typeof (FirstScreenVm);
        }        
    }
}