using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Transversal.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Application.Interface
{
    public interface ICustomerApplication
    {
        #region MetodosSíncronos

        Response<IEnumerable<CustomersDto>> GetAll();
        Response<CustomersDto> Get(string customerId);
        Response<bool> Insert(CustomersDto customerDto);
        Response<bool> Update(CustomersDto customerDto);
        Response<bool> Delete(string customerId);

        #endregion

        #region MetodosAsíncronos

        Task<Response<IEnumerable<CustomersDto>>> GetAllAsync();
        Task<Response<CustomersDto>> GetAsync(string customerId);
        Task<Response<bool>> InsertAsync(CustomersDto customerDto);
        Task<Response<bool>> UpdateAsync(CustomersDto customerDto);
        Task<Response<bool>> DeleteAsync(string customerId);

        #endregion
    }
}
