using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using URC_final.Models;

    public class Student_final_Context : DbContext
    {
        public Student_final_Context (DbContextOptions<Student_final_Context> options)
            : base(options)
        {
        }

    public DbSet<Student> Students { get; set; }
    public DbSet<Opportunity> Opportunities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().ToTable("Student");
        modelBuilder.Entity<Opportunity>().ToTable("Opportunity");
    }
}
