﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Weighing.Terminal.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Models;

    public partial class TerminalEntities : DbContext
    {
        public TerminalEntities(string entities)
            : base(entities)
        //: base("name=TerminalEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<TaskTimbang> TaskTimbangs { get; set; }
        public virtual DbSet<TerminalActive> TerminalActives { get; set; }
        public virtual DbSet<TerminalConfiguration> TerminalConfigurations { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<MOQueue> MOQueues { get; set; }
        public virtual DbSet<OracleHeader> OracleHeaders { get; set; }
    }
}