﻿using FrontToBack.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>options):base(options)
        {
           
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDesc> SliderDescs { get; set; }

        public DbSet<Bio> Bios { get; set; }
    }
}
