using Pacagroup.Ecommerce.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Infrastructure.Interface
{
    public interface ICustomerRepository
    {
        #region MetodosSíncronos

        IEnumerable<Customers> GetAll();
        Customers Get(string customerId);
        bool Insert(Customers customer);
        bool Update(Customers customer);
        bool Delete(string customerId);

        #endregion

        #region MetodosAsíncronos

        Task<IEnumerable<Customers>> GetAllAsync();
        Task<Customers> GetAsync(string customerId);
        Task<bool> InsertAsync(Customers customer);
        Task<bool> UpdateAsync(Customers customer);
        Task<bool> DeleteAsync(string customerId);

        #endregion
    }
}
