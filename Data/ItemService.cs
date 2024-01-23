using Lab_2.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace Lab_2.Data
{
    public class ItemService
    {
        private readonly ItemContext _context;
        public ItemService(ItemContext _Context)
        {
            _context = _Context;
        }
        public async Task<List<Item>> GetItemlist()
        {
            ItemContext itemContext = new ItemContext();
            List<Item> items = itemContext.Items.ToList();
            return await Task.FromResult(items);
        }

        public async Task<bool> AddNewItem(Item item)
        {
            await _context.Items.AddAsync(item);
            await _context.SaveChangesAsync();
            return true;
        }
        public void SaveUpdatedItem(Item item)
        {
            ItemContext context = new ItemContext();
            context.Items.Update(item);
            context.SaveChanges();
        }

     
        public async Task<Item> GetItemId(int id)
        {
            Item item = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);
            return item;

        }

        public async Task<bool> UpdateItemDetails(Item item)
        {
            _context.Items.Update(item);
            await _context.SaveChangesAsync(true);
            return true;

        }
        public async Task DeleteItem(Item item)
        {
            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
            
        }
    }
}
