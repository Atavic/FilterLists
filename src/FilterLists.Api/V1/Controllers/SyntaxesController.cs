﻿using System.Threading.Tasks;
using FilterLists.Data.Entities;
using FilterLists.Services.SeedService;
using FilterLists.Services.SeedService.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class SyntaxesController : BaseController
    {
        private readonly SeedService seedService;

        public SyntaxesController(SeedService seedService)
        {
            this.seedService = seedService;
        }

        [HttpGet]
        public async Task<IActionResult> Seed()
        {
            return Json(await seedService.GetAllAsync<Syntax, SyntaxSeedDto>());
        }
    }
}