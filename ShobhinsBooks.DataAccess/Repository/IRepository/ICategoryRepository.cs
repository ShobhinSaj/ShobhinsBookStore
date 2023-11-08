using ShobhinsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShobhinsBooks.DataAccess.Repository.IRepository
{
    interface ICategoryRepository
    {
        void Update(Category category);
    }
}
