using Ecommerce.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategories();
        Task<CategoryDTO> GetById(Guid? id);
        Task<CategoryDTO> Add(CategoryDTO categoryDto);
        Task Update(CategoryDTO categoryDto);
        Task Remove(Guid? id);
    }
}
