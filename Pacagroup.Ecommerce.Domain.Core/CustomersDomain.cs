using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Domain.Interface;
using Pacagroup.Ecommerce.Infrastructure.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Domain.Core
{
    public class CustomersDomain : ICustomersDomain
    {
        private readonly ICustomerRepository customerRepository;

        public CustomersDomain(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        #region MétodosSíncronos

        public IEnumerable<Customers> GetAll()
        {
            return customerRepository.GetAll();
        }

        public Customers Get(string customerId)
        {
            return customerRepository.Get(customerId);
        }

        public bool Insert(Customers customer)
        {
            return customerRepository.Insert(customer);
        }

        public bool Update(Customers customer)
        {
            return customerRepository.Update(customer);
        }

        public bool Delete(string customerId)
        {
            return customerRepository.Delete(customerId);
        }


        #endregion


        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            return await customerRepository.GetAllAsync();
        }

        #region MétodosAsíncronos

        public async Task<Customers> GetAsync(string customerId)
        {
            return await customerRepository.GetAsync(customerId);
        }


        public async Task<bool> InsertAsync(Customers customer)
        {
            return await customerRepository.InsertAsync(customer);
        }

        public async Task<bool> UpdateAsync(Customers customer)
        {
            return await customerRepository.UpdateAsync(customer);
        }


        public async Task<bool> DeleteAsync(string customerId)
        {
            return await customerRepository.DeleteAsync(customerId);
        }

        #endregion
    }
}
