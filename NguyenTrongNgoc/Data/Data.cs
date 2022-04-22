#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenTrongNgoc.Models;

    public class Data : DbContext
    {
        public Data (DbContextOptions<Data> options)
            : base(options)
        {
        }

        public DbSet<NguyenTrongNgoc.Models.Category> Category { get; set; }

        public DbSet<NguyenTrongNgoc.Models.Comments> Comments { get; set; }

        public DbSet<NguyenTrongNgoc.Models.News> News { get; set; }
    }
