﻿using PrisonBack.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonBack.Domain.Repositories
{
    public interface IPrisonerRepository
    {
        Prisoner SelectedPrisoner(int id);
        Task<IEnumerable<Prisoner>> AllPrisoner(string userName);
        bool SaveChanges();
        void CreatePrisoner(Prisoner prisoner);
        void DeletePrisoner(Prisoner prisoner);
        void UpdatePrisoner(Prisoner prisoner);
    }
}
