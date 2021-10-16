using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Models.DTOs.VM
{
    public class FavoriteVM
    {
        public int Id { get; set; }
        [Required]
        public int IdProduct { get; set; }

        public int IdUser { get; set; }
    }
}
