using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using Taste.DataAccess.Data.Repository.IRepository;
using Taste.Models.Models;

namespace Taste.DataAccess.Data.Repository
{
    class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext dbContext): base(dbContext)
        {
            _db = dbContext;
        }
        public IEnumerable<SelectListItem> GetCategoryListForDropDown()
        {
            return _db.Category.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
        }

        public void Update(Category category)
        {
            var cat = _db.Category.FirstOrDefault(c => c.Id == category.Id);
            cat.Name = category.Name;
            cat.DisplayOrder = category.DisplayOrder;
            _db.SaveChanges();
        }
    }
}
