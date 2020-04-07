using DAL= DAL_API.Repositories;
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


        private IUTILISATEURRepository<int, DAL_API.Models.UTILISATEUR> _repo = new UTILISATEURRepository();


        public void Add(DAL_API.Models.UTILISATEUR entity)
        {
            _repo.Add(entity.ToDAL());
        }

        public void Add(API.UTILISATEUR entity)
        {
            throw new NotImplementedException();
        }

        public void changePassword(int id, string password)
        {
            _repo.changePassword(id, password);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public IEnumerable<DAL_API.Models.UTILISATEUR> Get()
        {
            return _repo.Get().Select(u=>u.ToAPI
        }

        public DAL_API.Models.UTILISATEUR Get(int id)
        {
            throw new NotImplementedException();
        }

        public void setUtils(int id)
        {
            throw new NotImplementedException();
        }

        public void UnsetUtils(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, DAL_API.Models.UTILISATEUR entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, API.UTILISATEUR entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<API.UTILISATEUR> IRepository<int, API.UTILISATEUR>.Get()
        {
            throw new NotImplementedException();
        }

        API.UTILISATEUR IRepository<int, API.UTILISATEUR>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}