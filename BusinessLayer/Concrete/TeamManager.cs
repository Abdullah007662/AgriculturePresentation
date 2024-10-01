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
    public class TeamManager:ITeamService
    {
        private readonly ITeamsDal _teamsDal;

        public TeamManager(ITeamsDal teamsDal)
        {   
            _teamsDal = teamsDal;
        }

        public void Delete(Team t)
        {
            _teamsDal.Delete(t);
        }

        public Team GetById(int id)
        {
            return _teamsDal.GetById(id);
        }

        public List<Team> GetListAll()
        {
            return _teamsDal.GetListAll();
        }

        public void Insert(Team t)
        {
            _teamsDal.Insert(t);
        }

        public void Update(Team t)
        {
            _teamsDal.Update(t);
        }
    }
}
