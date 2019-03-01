using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcVirtualPets.Models
{
    public class ListAndEditPets
    {
        public virtual IEnumerable<Pet> Pets { get; set; }

        
        public Pet NewPet { get; set; }

        public ListAndEditPets()
        {
            NewPet = new Pet();
        }
    }
}
