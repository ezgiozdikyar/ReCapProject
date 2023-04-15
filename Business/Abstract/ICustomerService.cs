using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<Customer> GetById(int id);
        IDataResult<List<Customer>> GetAll();
        IResult DeleteCustomer(Customer customer);
        IResult UpdateCustomer(Customer customer);
        IResult AddCustomer(Customer customer);
    }
}
