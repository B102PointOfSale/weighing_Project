﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Weighing.Preparation.DataAccess
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class PreparationEntities : DbContext
    {
        public PreparationEntities(string entities)
            : base(entities)
        //: base("name=PreparationEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<ItemLotMasterSequence> ItemLotMasterSequences { get; set; }
        public virtual DbSet<OracleDetail> OracleDetails { get; set; }
        public virtual DbSet<OracleHeader> OracleHeaders { get; set; }
        public virtual DbSet<TaskTimbang> TaskTimbangs { get; set; }
        public virtual DbSet<MOQueue> MOQueues { get; set; }
    }
}
