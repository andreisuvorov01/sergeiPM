﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommunicationsShowroom.DbEntity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CommunicationsShowroomEntities : DbContext
    {
        public CommunicationsShowroomEntities()
            : base("name=CommunicationsShowroomEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccountClient> AccountClient { get; set; }
        public virtual DbSet<AccountEmployees> AccountEmployees { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<InfoEmployees> InfoEmployees { get; set; }
        public virtual DbSet<OrdersStatus> OrdersStatus { get; set; }
        public virtual DbSet<RepairOrders> RepairOrders { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<SalesStatus> SalesStatus { get; set; }
        public virtual DbSet<StatusAccount> StatusAccount { get; set; }
    }
}
