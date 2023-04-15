using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<Brand> GetById(int id);
        IDataResult<List<Brand>> GetAll();
        IResult DeleteBrand(Brand brand);
        IResult UpdateBrand(Brand brand);
        IResult AddBrand(Brand brand);
    }
}
