namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterGameTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GameTable", new[] { "InstanceId_InstanceId", "InstanceId_CreationTime" }, "[System.Activities.DurableInstancing].Instances");
            DropIndex("dbo.GameTable", new[] { "InstanceId_InstanceId", "InstanceId_CreationTime" });
            AddColumn("dbo.GameTable", "InstanceId", c => c.Guid(nullable: false));
            DropColumn("dbo.GameTable", "InstanceId_InstanceId");
            DropColumn("dbo.GameTable", "InstanceId_CreationTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GameTable", "InstanceId_CreationTime", c => c.DateTime());
            AddColumn("dbo.GameTable", "InstanceId_InstanceId", c => c.Guid());
            DropColumn("dbo.GameTable", "InstanceId");
            CreateIndex("dbo.GameTable", new[] { "InstanceId_InstanceId", "InstanceId_CreationTime" });
            AddForeignKey("dbo.GameTable", new[] { "InstanceId_InstanceId", "InstanceId_CreationTime" }, "[System.Activities.DurableInstancing].Instances", new[] { "InstanceId", "CreationTime" });
        }
    }
}
