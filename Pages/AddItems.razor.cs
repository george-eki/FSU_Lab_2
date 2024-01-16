using Lab_2.Data;
using Lab_2.Models;
using Microsoft.AspNetCore.Components;
using static Lab_2.Pages.AddItems;

namespace Lab_2.Pages
{
    public partial class AddItems
    {
        //private async void AddNewItem()
        //{
            
        //    ItemService itemService = new ItemService();
        //    await itemService.AddNewItem(item);
        //    item = new Item();
        //}
        Item _item = new Item();
        protected async void AddNewItem()
        {
            await itemService.AddNewItem(_item);
            NavigationManager.NavigateTo("Items");
        }
        protected async void Cancel()
        {
            NavigationManager.NavigateTo("Items");
        }

    }
}