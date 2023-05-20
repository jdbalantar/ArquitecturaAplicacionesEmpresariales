using AutoMapper;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Application.Interface;
using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Domain.Interface;
using Pacagroup.Ecommerce.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Application.Main
{
    public class CustomersApplication : ICustomerApplication
    {
        private readonly IMapper _mapper;
        private readonly ICustomersDomain _customersDomain;

        public CustomersApplication(IMapper mapper, ICustomersDomain customersDomain)
        {
            _mapper = mapper;
            _customersDomain = customersDomain;
        }

        #region MetodosSíncronos

        public Response<IEnumerable<CustomersDto>> GetAll()
        {
            var response = new Response<IEnumerable<CustomersDto>>();
            try
            {
                var customer = _customersDomain.GetAll();
                if (customer != null)
                    response.Data = _mapper.Map<IEnumerable<CustomersDto>>(customer);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public Response<CustomersDto> Get(string customerId)
        {
            var response = new Response<CustomersDto>();
            try
            {
                var customer = _customersDomain.Get(customerId);
                if (customer != null)
                    response.Data = _mapper.Map<CustomersDto>(customer);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public Response<bool> Insert(CustomersDto customerDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customerDto);
                response.Data = _customersDomain.Insert(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public Response<bool> Update(CustomersDto customerDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customerDto);
                response.Data = _customersDomain.Update(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public Response<bool> Delete(string customerId)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = _customersDomain.Delete(customerId);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        #endregion

        #region MetodosAsíncronos

        public async Task<Response<IEnumerable<CustomersDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<CustomersDto>>();
            try
            {
                var customer = await _customersDomain.GetAllAsync();
                if (customer != null)
                    response.Data = _mapper.Map<IEnumerable<CustomersDto>>(customer);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<CustomersDto>> GetAsync(string customerId)
        {
            var response = new Response<CustomersDto>();
            try
            {
                var customer = await _customersDomain.GetAsync(customerId);
                if (customer != null)
                    response.Data = _mapper.Map<CustomersDto>(customer);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public async Task<Response<bool>> InsertAsync(CustomersDto customerDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customerDto);
                response.Data = await _customersDomain.InsertAsync(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<bool>> UpdateAsync(CustomersDto customerDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customerDto);
                response.Data = await _customersDomain.UpdateAsync(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
        public async Task<Response<bool>> DeleteAsync(string customerId)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _customersDomain.DeleteAsync(customerId);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        #endregion

    }
}
