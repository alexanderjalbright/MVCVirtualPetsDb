using MvcVirtualPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcVirtualPets.Repositories
{
    public class ListAndEditPetsRepository
    {
        PetContext db;
        public ListAndEditPetsRepository(PetContext db)
        {
            this.db = db;
        }

        public ListAndEditPets GetAll()
        {
            return db.ListAndEdits.Single();
        }
    }
}

