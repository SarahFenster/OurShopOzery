﻿using Entits;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        AdoNetManageContext _AdoNetManageContext;

        public CategoryRepository(AdoNetManageContext manageDbContext)
        {
            this._AdoNetManageContext = manageDbContext;
        }

        //public async Task<Category> AddCategory(Category category)
        //{
        //    await _AdoNetManageContext.Categories.AddAsync(category);
        //    await _AdoNetManageContext.SaveChangesAsync();
        //    return category;

        //}

        //public async Task UpdateCategory(int id, Category categoryToUpdate)
        //{
        //    categoryToUpdate.Id = id;

        //    _AdoNetManageContext.Categories.Update(categoryToUpdate);

        //    await _AdoNetManageContext.SaveChangesAsync();
        //}

        public async Task<List<Category>> GetCategory()
        {
            return await _AdoNetManageContext.Categories.ToListAsync();

        }


        //public async Task<Category> GetCategoryById(int id)
        //{
        //    Category category = await _AdoNetManageContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
        //    return category;

        //}



        //public async Task DeleteCategory(int id, Category categoryToDelete)
        //{
        //    categoryToDelete.Id = id;

        //    _AdoNetManageContext.Categories.Remove(categoryToDelete);

        //    await _AdoNetManageContext.SaveChangesAsync();

        //}



    }
}