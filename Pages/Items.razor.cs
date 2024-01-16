using Lab_2.Data;
using Lab_2.Models;

namespace Lab_2.Pages
{
    public partial class Items
    {
        private List<Item>? itemsList;//List containg data from service
        protected override async Task OnInitializedAsync()
        {
            itemsList = await itemservice.GetItemlist();
        }
    }
}
