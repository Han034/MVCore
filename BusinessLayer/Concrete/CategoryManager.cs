using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository EfCategoryRepository;
        public CategoryManager()
        {
            EfCategoryRepository = new EfCategoryRepository();  
        }
        //CategoryRepository categoryRepository = new CategoryRepository();
        //----------------------2-------------------------------------------
        //GenericRepository<Category> repo = new GenericRepository<Category>();
        public void CategoryAdd(Category category)
        {
            //if (category.CategoryName!=""&&category.CategoryDescription!=""&&
            //    category.CategoryName.Length>=5&& category.CategoryStatus==true)
            //{
            //    categoryRepository.AddCategory(category);
            //}
            //else
            //{
            //    //Hata Mesajı 
            //}
            //categoryRepository.AddCategory(category);
            //------------------2--------------------------
            EfCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            //if (category.CategoryId != 0) {
            //    repo.Delete(category);
            //}
            EfCategoryRepository.Delete(category);
        }

        public void CategoryUpdaet(Category category)
        {
            EfCategoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
            return EfCategoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return EfCategoryRepository.GetListAll();
        }
    }
}
