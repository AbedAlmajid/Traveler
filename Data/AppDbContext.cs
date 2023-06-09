﻿using DemoTraveler.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTraveler.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Travel> Travels { get; set; }
        public DbSet<HomeImage> HomeImages { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Package> Packages { get; set; }


    }
}
