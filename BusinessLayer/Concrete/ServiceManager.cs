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
    public class ServiceManager : IServiceServices
    {
        private readonly IServicesDal _servicesDal;

        public ServiceManager(IServicesDal servicesDal)
        {
            _servicesDal = servicesDal;
        }

        public void Delete(Service t)
        {
            _servicesDal.Delete(t);
        }

        public Service GetById(int id)
        {
            return _servicesDal.GetById(id);
        }

        public List<Service> GetListAll()
        {
            return _servicesDal.GetListAll();
        }

        public void Insert(Service t)
        {
            _servicesDal.Insert(t);
        }

        public void Update(Service t)
        {
            _servicesDal.Update(t);
        }
    }
}
