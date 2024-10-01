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
    public class AnnounCementManager : IAnnouncementService
    {
        private readonly IAnnounCemetDal _announCemetDal;

        public AnnounCementManager(IAnnounCemetDal announCemetDal)
        {
            _announCemetDal = announCemetDal;
        }

        public void AnnouncementStatusToFalse(int id)
        {
            _announCemetDal.AnnouncementStatusToFalse(id);
        }

        public void AnnouncementStatusToTrue(int id)
        {
            _announCemetDal.AnnouncementStatusToTrue(id);
        }

        public void Delete(AnnounCemet t)
        {
            _announCemetDal.Delete(t);
        }

        public AnnounCemet GetById(int id)
        {
            return _announCemetDal.GetById(id);
        }

        public List<AnnounCemet> GetListAll()
        {
            return _announCemetDal.GetListAll();
        }

        public void Insert(AnnounCemet t)
        {
            _announCemetDal.Insert(t);
        }

        public void Update(AnnounCemet t)
        {
            _announCemetDal.Update(t);
        }
    }
}
