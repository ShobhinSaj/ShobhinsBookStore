using System;
using System.Collections.Generic;
using System.Text;
using ShobhinsBooks.Models;
using ShobhinsBooks.DataAccess.Repository.IRepository;
using ShobhinsBookStore.DataAccess.Data;
using System.Linq;

namespace ShobhinsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            //Use .NET LINQ to retrieve the first or default coverType object
            //then pass the id as a generic entity which matches the coverType ID
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)  //save changes if not null
            {
                objFromDb.Name = coverType.Name;

            }
        }
    }
}
