using Lab_2.Models;
using Microsoft.AspNetCore.Components;

namespace Lab_2.Pages
{
    public partial class DeleteItems
    {
        [Parameter]
        public string Id { get; set; }
        Item _item = new Item();
        protected override async Task OnInitializedAsync()
        {
            _item = await Task.Run(() => itemService.GetItemId(Convert.ToInt32(Id)));
        }
        protected async void DeleteItem()
        {
            await itemService.DeleteItem(_item);
            NavigationManager.NavigateTo("Items");
        }
        void Cancel()
        {
            NavigationManager.NavigateTo("Items");
        }
    }
}
