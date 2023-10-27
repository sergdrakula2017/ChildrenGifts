using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChildrenGifts.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ChildrenGifts.Data
{
    public class ChildContext :DbContext
    {
        public required DbSet<DbChild> Children { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DbChild>(entity =>
            {
                entity.HasKey(x=>x.Id)
            })
        }
    }
}
