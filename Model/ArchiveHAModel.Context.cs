﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBEntities : DbContext
    {
        public DBEntities()
            : base("name=DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Affix> Affix { get; set; }
        public DbSet<Dept> Dept { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Resource> Resource { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleMenu> RoleMenu { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
