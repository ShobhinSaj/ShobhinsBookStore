using ShobhinsBooks.DataAccess.Repository.IRepository;
using ShobhinsBooks.Models;
using ShobhinsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShobhinsBooks.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Product product)
        {
            //Use .NET LINQ to retrieve the first or default product object
            //then pass the id as a generic entity which matches the product ID
            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDb != null)  //save changes if not null
            {
                if(product.ImageUr1 != null)
                {
                    objFromDb.ImageUr1 = product.ImageUr1;
                }
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.Author = product.Author;
                objFromDb.ISBN = product.ISBN;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId;

            }
        }
    }
}
