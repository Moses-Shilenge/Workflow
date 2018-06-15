using BusinessObject.DtoModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext() : base ("name=DefaultConnection")
        {

        }

        public DbSet<Game> Game { get; set; }
        //public DbSet<DefinitionIdentityTable> DefinitionIdentityTable { get; set; }
        public DbSet<IdentityOwnerTable> IdentityOwnerTable { get; set; }
        public DbSet<Instance> Instance { get; set; }
        public DbSet<InstancePromotedPropertiesTable> InstancePromotedPropertiesTable { get; set; }
        public DbSet<InstancePromotedProperty> InstancePromotedProperty { get; set; }
        public DbSet<InstancesTable> InstancesTable { get; set; }
        public DbSet<RunnableInstancesTable> RunnableInstancesTable { get; set; }
        public DbSet<KeysTable> KeysTable { get; set; }
        public DbSet<LockOwnersTable> LockOwnersTable { get; set; }
        public DbSet<ServiceDeployment> ServiceDeployment { get; set; }
        public DbSet<ServiceDeploymentsTable> ServiceDeploymentsTable { get; set; }
        public DbSet<SqlWorkflowInstanceStoreVersionTable> SqlWorkflowInstanceStoreVersionTable { get; set; }
    }
}
