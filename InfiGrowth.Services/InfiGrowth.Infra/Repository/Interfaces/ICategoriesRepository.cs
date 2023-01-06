using InfiGrowth.Entity.Manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Infra.Repository.Interfaces
{
    public interface ICategoriesRepository
    {
        Task<List<Categories>> CategoriesGetCategoriesAsync();
    }
}
