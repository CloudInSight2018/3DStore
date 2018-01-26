using _3DStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace _3DStore.Data.EF
{
    /// <summary>
    /// 
    /// </summary>
    public class StoreDB : DbContext
    {        

        public StoreDB(DbContextOptions options) :base(options)
        {
        

        }

        // <summary>
        /// 
        /// </summary>
        public virtual DbSet<Store> Stores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<Category> Categories { get; set; }
    }
}
