﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectMaster.Models;

namespace ProiectMaster.Models.Entites
{
    public partial class Favorite : IEntity<int>
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdUser { get; set; }

        public virtual Product Product { get; set; }

    }
}
