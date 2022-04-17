#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenTrongNgoc.Models;

    public class DataComment : DbContext
    {
        public DataComment (DbContextOptions<DataComment> options)
            : base(options)
        {
        }
        public DbSet<NguyenTrongNgoc.Models.comment> comment { get; set; }
    }
