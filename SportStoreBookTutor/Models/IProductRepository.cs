using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreBookTutor.Models
{
   public interface IProductRepository
    {
        IQueryable<Product> Products { get; } // Интерфейс который реализуется классом FakeProductRepository
    }
}
