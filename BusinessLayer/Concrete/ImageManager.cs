using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageManager : IImageService
    {
        private readonly IImagesDal _ımagesDal;

        public ImageManager(IImagesDal ımagesDal)
        {
            _ımagesDal = ımagesDal;
        }

        public void Delete(Image t)
        {
            _ımagesDal.Delete(t);
        }

        public Image GetById(int id)
        {
            return _ımagesDal.GetById(id);
        }

        public List<Image> GetListAll()
        {
            return _ımagesDal.GetListAll();
        }

        public void Insert(Image t)
        {
            _ımagesDal.Insert(t);
        }

        public void Update(Image t)
        {
            _ımagesDal.Update(t);
        }
    }
}
