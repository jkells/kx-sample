using KX.Core;

namespace Sample.Core.ViewModels
{
    public class SecondScreenVm
    {
        public KXNavigate Navigator { get; set; }
        
        public void OnBackButtonClick()
        {
            Navigator.NavigateBack();
        }

        public void OnNextButtonClick()
        {
            Navigator.NavigateTo(typeof(SecondScreenVm)); 
        }
    }
}
