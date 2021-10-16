using AutoMapper;
using ProiectMaster.DataAccess.Interfaces;
using ProiectMaster.Models.DTOs.VM;
using ProiectMaster.Models.Entites;
using ProiectMaster.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Services
{
    class FavoriteService : IFavorite
    {
        private readonly IRepository<Favorite, int> favoriteProductsRep;
        private readonly IMapper mapper;

        public FavoriteService(IRepository<Favorite, int> favoriteproductsRep, IMapper mapper)
        {
            this.favoriteProductsRep = favoriteproductsRep;
            this.mapper = mapper;
        }
        public void AddFavorite(FavoriteVM dto)
        {
            var entity = mapper.Map<Favorite>(dto);
            favoriteProductsRep.Add(entity);
        }

        public void DeleteFavorite(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FavoriteVM> GetAllFavorites()
        {
            var favorites = favoriteProductsRep.GetAll();
            return mapper.Map<List<FavoriteVM>>(favorites);
        }

        public FavoriteVM GetFavorite(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateFavorite(int id, FavoriteVM dto)
        {
            throw new NotImplementedException();
        }
    }
}
