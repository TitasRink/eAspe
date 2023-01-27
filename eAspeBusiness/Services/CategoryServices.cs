using eAspe.Models;
using eAspeDatabase.SqlDbContext;
using Microsoft.EntityFrameworkCore;

namespace eAspeBusiness.Services
{
    public class CategoryServices
    {
        private readonly AspeContext _context;

        public CategoryServices(AspeContext context)
        {
            _context = context;
        }

        public async Task AddNewCategoryAsync(Category categoryName)
        {
            await _context.Categories.AddAsync(categoryName);
        }

        public async Task RenameCategoryAsync(Category categoryName)
        {
            
            var category = await _context.Categories.FirstOrDefaultAsync(c=>c.Id == categoryName.Id);
            if (category != null)
            {
                category.Name = categoryName.Name;
            }

            await _context.SaveChangesAsync();
        }

        public async Task RemoveNewCategoryAsync(Category categoryName)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c=>c.Name == categoryName.Name);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<List<Category>> GetCategoryListAsync()
        {
            var result = await _context.Categories.OrderBy(c => c.Id).ToListAsync();
            return result;
        }
    }
}
