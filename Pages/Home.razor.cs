using Microsoft.AspNetCore.Components;

namespace BlazorWASMHomework.Pages
{
    public partial class Home
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private void GoToHomework()
        {
            NavigationManager.NavigateTo("/homework/parameter");
        }
    }
}
