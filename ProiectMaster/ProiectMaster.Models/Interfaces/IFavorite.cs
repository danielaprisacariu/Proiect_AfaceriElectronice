using ProiectMaster.Models.DTOs.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Models.Interfaces
{
    public interface IFavorite
    {
        IEnumerable<FavoriteVM> GetAllFavorites();
        FavoriteVM GetFavorite(int id);
        void AddFavorite(FavoriteVM dto);
        void UpdateFavorite(int id, FavoriteVM dto);
        void DeleteFavorite(int id);
    }
}
