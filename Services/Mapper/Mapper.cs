using ProjetsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using D=DAL_API.Models;

namespace ProjetsAPI.Services.Mapper
{
    public static class Mapper
    {
        public static D.UTILISATEUR ToDAL(this UTILISATEUR u)
        {
            return new D.UTILISATEUR
            {
                UserId = u.UserId,
                Login = u.Login,
                Password = u.Password,
                isAdmin = u.isAdmin,
                isPromo = u.isPromo,
                isFinanceur = u.isFinanceur,
                isActive = u.isActive


            };
        }
        public static UTILISATEUR ToAPI(this D.UTILISATEUR u)
        {
            return new UTILISATEUR
            {
                UserId = u.UserId,
                Login = u.Login,
                Password = u.Password,
                isAdmin = u.isAdmin,
                isPromo = u.isPromo,
                isFinanceur = u.isFinanceur,
                isActive = u.isActive,
            };
        }
        public static D.ADMINISTRATEUR ToDAL(this ADMINISTRATEUR a)
        {
            return new D.ADMINISTRATEUR
            {
                AdminId = a.AdminId,
            };
        }
        public static ADMINISTRATEUR ToAPI(this D.ADMINISTRATEUR a)
        {
            return new ADMINISTRATEUR
            {
                AdminId = a.AdminId,
            };
        }
        public static D.PROJETS ToDAL(this PROJETS p)
        {
            return new D.PROJETS
            {
                ProjetId = p.ProjetId,
                Nom = p.Nom,
                Description = p.Description,
                plafondFinancement = p.plafondFinancement,
                numeroCompte = p.numeroCompte,
                urlVideo = p.urlVideo


            };
        }
        public static PROJETS ToAPI(this D.PROJETS p)
        {
            return new PROJETS
            {
                ProjetId = p.ProjetId,
                Nom = p.Nom,
                Description = p.Description,
                plafondFinancement = p.plafondFinancement,
                numeroCompte = p.numeroCompte,
                urlVideo = p.urlVideo


            };
        }

    }
}