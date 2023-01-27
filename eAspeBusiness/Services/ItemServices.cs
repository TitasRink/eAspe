using eAspe.Models;
using eAspeDatabase.SqlDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAspeBusiness.Services
{
    public class ItemServices
    {
        private readonly AspeContext _context;

        public ItemServices(AspeContext context)
        {
            _context = context;
        }

        public async Task AddNewItemAsync(Item item)
        {
            await _context.Items.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveItemAsync(Item item)
        {
            var result = await _context.Items.FirstOrDefaultAsync(c => c.Id == item.Id);
            if (result != null)
            {
                _context.Items.Remove(result);
            }
            await _context.SaveChangesAsync();
        }

        public async Task RenameItemAsync(Item item)
        {
            var resultItem = await _context.Items.FirstOrDefaultAsync(c => c.Id == item.Id);
            if (resultItem != null)
            {
                resultItem.Title = item.Title;
                resultItem.ManufacturerId = item.ManufacturerId;
                resultItem.Categories = item.Categories;
                resultItem.Content = item.Content;
                resultItem.ItemProperties = item.ItemProperties;
                resultItem.Images = item.Images;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Item> GetItemById(Item item)
        {
            var itemsDetails = await _context.Items
                .Include(c=>c.Categories)
                .Include(m=>m.ManufacturerId)
                .Include(i=>i.Images)
                .Include(i=>i.ItemProperties)
                .FirstOrDefaultAsync(n=>n.Id== item.Id);

            return itemsDetails;
        }
    }
}
