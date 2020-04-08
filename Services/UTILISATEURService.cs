using DAL = DAL_API.Models;
using API= ProjetsAPI.Models;
using ProjetsAPI.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL_API.Models;
using DAL_API.Repositories;

namespace ProjetsAPI.Services
{
    public class UTILISATEURService : IUTILISATEURRepository<int, API.UTILISATEUR>
    {


        private IUTILISATEURRepository<int, DAL.UTILISATEUR> _repo = new UTILISATEURRepository();


        public void Add(API.UTILISATEUR entity)
        {
            _repo.Add(entity.ToDAL());
        }

        
        public void changePassword(int id, string password)
        {
            _repo.changePassword(id, password);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public IEnumerable<API.UTILISATEUR> Get()
        {
            return _repo.Get().Select(u => u.ToAPI());
        }

        public API.UTILISATEUR Get(int id)
        {
            throw new NotImplementedException();
        }

        public void setUtils(int id)
        {
            _repo.setUtils(id);
        }

        public void UnsetUtils(int id)
        {
            _repo.UnsetUtils(id);
        }

        public void Update(int id, API.UTILISATEUR entity)
        {
            _repo.Update(id,entity.ToDAL());
        }
    }

}