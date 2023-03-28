using Core.Utilities;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<Brand> GetBrand(int id);
        IDataResult<List<Brand>> GetAll();
        IResult DeleteBrand(Brand brand);
        IResult UpdateBrand(Brand brand);
        IResult AddBrand(Brand brand);
    }
}
