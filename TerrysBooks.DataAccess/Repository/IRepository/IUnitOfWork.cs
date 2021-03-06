using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerrysBooks.DataAccess.Repository.IRepository;
using TerrysBooks.Models;
using TerrysBookStore.Models;

namespace TerrysBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ISP_Call SP_Call { get; }
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }
        IProductRepository Product { get; }

        void Save();
    }
}
