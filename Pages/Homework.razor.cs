using Microsoft.AspNetCore.Components;

namespace BlazorWASMHomework.Pages
{
    public partial class Homework
    {
        [Parameter]
        public string Header { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private void GoToHome()
        {
            NavigationManager.NavigateTo("/");
        }

    }

}
