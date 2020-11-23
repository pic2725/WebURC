using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using URC_final.Models;

    public class URC_final_Context : DbContext
    {
        public URC_final_Context (DbContextOptions<URC_final_Context> options)
            : base(options)
        {
        }

    public DbSet<Opportunity> Opportunities { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<OpportunityViews> OpportunityViews { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Opportunity>().ToTable("Opportunity");
        modelBuilder.Entity<OpportunityViews>().ToTable("OpportunityViews");
        modelBuilder.Entity<Student>().ToTable("Student");
    }

    
}
