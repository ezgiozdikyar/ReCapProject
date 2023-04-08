using Core.Utilities;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<Rental> GetRental(int id);
        IDataResult<List<Rental>> GetAll();
        IResult DeleteRental(Rental rental);
        IResult UpdateRental(Rental rental);
        IResult AddRental(Rental rental);
    }
}
