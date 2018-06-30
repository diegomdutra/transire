﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TransireWebStore.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class transirestoredbEntities : DbContext
    {
        public transirestoredbEntities()
            : base("name=transirestoredbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Category> Category { get; set; }
    
        public virtual int sp_insert_category(string category_name, ObjectParameter category_id)
        {
            var category_nameParameter = category_name != null ?
                new ObjectParameter("category_name", category_name) :
                new ObjectParameter("category_name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_insert_category", category_nameParameter, category_id);
        }
    
        public virtual ObjectResult<Nullable<short>> InsertCategory(string category_name, ObjectParameter category_id)
        {
            var category_nameParameter = category_name != null ?
                new ObjectParameter("category_name", category_name) :
                new ObjectParameter("category_name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<short>>("InsertCategory", category_nameParameter, category_id);
        }
    }
}
