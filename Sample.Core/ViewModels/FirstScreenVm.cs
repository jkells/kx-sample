using System.Text;
using KX.Core;
using KX.Core.Observables;

namespace Sample.Core.ViewModels
{    
    public class FirstScreenVm : IKXReady
    {
        public KXObservable<string> Title { get; set; }
        public KXObservable<string> Blurb { get; set; }        
        public KXObservable<int> CompanionCount { get; set; }
        public KXNavigate Navigator { get; set; }
    
        public void Ready()
        {
            Title.Set("Title");

            var sb = new StringBuilder();
            sb.AppendLine("This is a multi-line");
            sb.AppendLine("chunk of text.");
            sb.AppendLine("Hello world.....");
            Blurb.Set(sb.ToString());

            CompanionCount.Set(1);
        }

        public void OnNextButtonClick()
        {            
            Navigator.NavigateTo(typeof(SecondScreenVm));
        }
    }
}