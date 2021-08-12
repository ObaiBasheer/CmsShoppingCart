using CmsShoppingCart.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CmsShoppingCart.Infrastructure
{
    public class CmsShoppingCartContext: DbContext
    {
        public CmsShoppingCartContext(DbContextOptions<CmsShoppingCartContext> options) : base(options)
        {

        }

        public DbSet<Page> Pages { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }
    }
}
