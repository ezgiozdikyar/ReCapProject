using Core.Utilities;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<Color> GetColor(int id);
        IDataResult<List<Color>> GetAll();
        IResult AddColor(Color color);
        IResult DeleteColor(Color color);
        IResult UpdateColor(Color color);

    }
}
