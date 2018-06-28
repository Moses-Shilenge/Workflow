namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using BusinessObject.DtoModels;
    using DataAccess.Migrations;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DefaultConnection")
        {
            //If Configuration.ProxyCreationEnabled is set to false, DbContext will not load child objects for some parent object unless Include method is called on parent object. 
            //If DbContext.Configuration.ProxyCreationEnabled is set to true, child objects will be loaded automatically.
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;

            //Update Database to latest version
            System.Data.Entity.Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
        }

        public DbSet<Game> Game { get; set; }
        public DbSet<DefinitionIdentityTable> DefinitionIdentityTable { get; set; }
        public DbSet<IdentityOwnerTable> IdentityOwnerTable { get; set; }
        public DbSet<InstanceMetadataChangesTable> InstanceMetadataChangesTable { get; set; }
        public DbSet<InstancePromotedPropertiesTable> InstancePromotedPropertiesTable { get; set; }
        public DbSet<InstancesTable> InstancesTable { get; set; }
        public DbSet<KeysTable> KeysTable { get; set; }
        public DbSet<LockOwnersTable> LockOwnersTable { get; set; }
        public DbSet<RunnableInstancesTable> RunnableInstancesTable { get; set; }
        public DbSet<ServiceDeploymentsTable> ServiceDeploymentsTable { get; set; }
        public DbSet<SqlWorkflowInstanceStoreVersionTable> SqlWorkflowInstanceStoreVersionTable { get; set; }
        public DbSet<InstancePromotedProperties> InstancePromotedProperties { get; set; }
        public DbSet<Instances> Instances { get; set; }
        public DbSet<ServiceDeployments> ServiceDeployments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
