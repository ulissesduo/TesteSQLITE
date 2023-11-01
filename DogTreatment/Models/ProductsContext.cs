﻿using System;
using System.Collections.Generic;
using EntityFrameworkDbFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DogTreatment.Models;

public partial class ProductsContext : DbContext
{
    public ProductsContext()
    {
    }

    public ProductsContext(DbContextOptions<ProductsContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Testess { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //=> optionsBuilder.UseSqlite(@"Data Source=dogs.db");
        => optionsBuilder.UseSqlite(@"Data Source=C:\Users\uliss\source\repos\DogTreatment\DogTreatment\Database\products.db");

    


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
