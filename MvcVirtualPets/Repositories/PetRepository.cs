using System.Collections.Generic;
using System.Linq;
using MvcVirtualPets.Models;

namespace MvcVirtualPets.Repositories
{
    public class PetRepository
    {
        PetContext db;
        public PetRepository(PetContext db)
        {
            this.db = db;
        }

        public ListAndEditPets GetAll()
        {
            return db.ListAndEdits.Single();
        }

        public Pet GetById(int id)
        {
            return db.Pets.Single(pet => pet.PetId == id);
        }

        public void Create(ListAndEditPets list)
        {
            db.Pets.Add(list.NewPet);
            db.SaveChanges();
        }

        public void Edit(Pet pet)
        {
            db.Update(pet);
            db.SaveChanges();
        }

        public void Delete(Pet pet)
        {
            db.Pets.Remove(pet);
            db.SaveChanges();
        }
    }
}
