using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcVirtualPets.Models;
using MvcVirtualPets.Repositories;

namespace MvcVirtualPets.Controllers
{
    public class ListAndEditPetsController : Controller
    {
        PetRepository petRepo;
        PetController controller;
        public ListAndEditPetsController(PetRepository petRepo, PetController controller)
        {
            this.petRepo = petRepo;
            this.controller = controller;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public ViewResult Create()
        {
            
            return controller.View();
        }

        [HttpPost]
        public ActionResult Create(ListAndEditPets list)
        {
            petRepo.Create(list);
            return RedirectToAction("/Pet/Index");
        }
    }
}