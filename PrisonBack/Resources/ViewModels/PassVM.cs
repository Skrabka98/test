﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonBack.Resources.ViewModels
{
    public class PassVM
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int IdUser { get; set; }
        public int IdPrisoner { get; set; }
    }
}
