using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcVirtualPets.Models
{
    public class Pet
    {
        public int PetId { get; set; }

        [Display(Name="Pet Name:")]
        public string Name { get; set; }

        public int ListAndEditPetsId { get; set; }

        public virtual ListAndEditPets ListAndEditPets { get; set; }

        public string Description { get; set; }


    }
}
