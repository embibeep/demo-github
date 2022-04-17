#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenTrongNgoc.Models;

    public class DataCategory : DbContext
    {
        public DataCategory (DbContextOptions<DataCategory> options)
            : base(options)
        {
        }
        public DbSet<NguyenTrongNgoc.Models.Category> Category { get; set; }
    }
