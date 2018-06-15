namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameTable",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MaxNumber = c.Int(nullable: false),
                        WorkflowType = c.String(),
                        Guess = c.Int(nullable: false),
                        Result = c.String(),
                        Turns = c.Int(nullable: false),
                        InstanceId_InstanceId = c.Guid(),
                        InstanceId_CreationTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("[System.Activities.DurableInstancing].Instances", t => new { t.InstanceId_InstanceId, t.InstanceId_CreationTime })
                .Index(t => new { t.InstanceId_InstanceId, t.InstanceId_CreationTime });
            
            CreateTable(
                "[System.Activities.DurableInstancing].Instances",
                c => new
                    {
                        InstanceId = c.Guid(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        PendingTimer = c.DateTime(),
                        LastUpdatedTime = c.DateTime(),
                        ServiceDeploymentId = c.Long(),
                        SuspensionExceptionName = c.String(maxLength: 450),
                        SuspensionReason = c.String(),
                        ActiveBookmarks = c.String(),
                        CurrentMachine = c.String(maxLength: 128),
                        LastMachine = c.String(maxLength: 450),
                        ExecutionStatus = c.String(maxLength: 450),
                        IsInitialized = c.Boolean(),
                        IsSuspended = c.Boolean(),
                        IsCompleted = c.Boolean(),
                        EncodingOption = c.Byte(),
                        ReadWritePrimitiveDataProperties = c.Binary(),
                        WriteOnlyPrimitiveDataProperties = c.Binary(),
                        ReadWriteComplexDataProperties = c.Binary(),
                        WriteOnlyComplexDataProperties = c.Binary(),
                        IdentityName = c.String(),
                        IdentityPackage = c.String(),
                        Build = c.Long(),
                        Major = c.Long(),
                        Minor = c.Long(),
                        Revision = c.Long(),
                    })
                .PrimaryKey(t => new { t.InstanceId, t.CreationTime });
            
            CreateTable(
                "[System.Activities.DurableInstancing].IdentityOwnerTable",
                c => new
                    {
                        SurrogateIdentityId = c.Long(nullable: false),
                        SurrogateLockOwnerId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.SurrogateIdentityId, t.SurrogateLockOwnerId });
            
            CreateTable(
                "[System.Activities.DurableInstancing].InstancePromotedPropertiesTable",
                c => new
                    {
                        SurrogateInstanceId = c.Long(nullable: false),
                        PromotionName = c.String(nullable: false, maxLength: 400),
                        Value33 = c.Binary(),
                        Value34 = c.Binary(),
                        Value35 = c.Binary(),
                        Value36 = c.Binary(),
                        Value37 = c.Binary(),
                        Value38 = c.Binary(),
                        Value39 = c.Binary(),
                        Value40 = c.Binary(),
                        Value41 = c.Binary(),
                        Value42 = c.Binary(),
                        Value43 = c.Binary(),
                        Value44 = c.Binary(),
                        Value45 = c.Binary(),
                        Value46 = c.Binary(),
                        Value47 = c.Binary(),
                        Value48 = c.Binary(),
                        Value49 = c.Binary(),
                        Value50 = c.Binary(),
                        Value51 = c.Binary(),
                        Value52 = c.Binary(),
                        Value53 = c.Binary(),
                        Value54 = c.Binary(),
                        Value55 = c.Binary(),
                        Value56 = c.Binary(),
                        Value57 = c.Binary(),
                        Value58 = c.Binary(),
                        Value59 = c.Binary(),
                        Value60 = c.Binary(),
                        Value61 = c.Binary(),
                        Value62 = c.Binary(),
                        Value63 = c.Binary(),
                        Value64 = c.Binary(),
                    })
                .PrimaryKey(t => new { t.SurrogateInstanceId, t.PromotionName });
            
            CreateTable(
                "[System.Activities.DurableInstancing].InstancePromotedProperties",
                c => new
                    {
                        InstanceId = c.Guid(nullable: false),
                        PromotionName = c.String(nullable: false, maxLength: 400),
                        EncodingOption = c.Byte(),
                        Value33 = c.Binary(),
                        Value34 = c.Binary(),
                        Value35 = c.Binary(),
                        Value36 = c.Binary(),
                        Value37 = c.Binary(),
                        Value38 = c.Binary(),
                        Value39 = c.Binary(),
                        Value40 = c.Binary(),
                        Value41 = c.Binary(),
                        Value42 = c.Binary(),
                        Value43 = c.Binary(),
                        Value44 = c.Binary(),
                        Value45 = c.Binary(),
                        Value46 = c.Binary(),
                        Value47 = c.Binary(),
                        Value48 = c.Binary(),
                        Value49 = c.Binary(),
                        Value50 = c.Binary(),
                        Value51 = c.Binary(),
                        Value52 = c.Binary(),
                        Value53 = c.Binary(),
                        Value54 = c.Binary(),
                        Value55 = c.Binary(),
                        Value56 = c.Binary(),
                        Value57 = c.Binary(),
                        Value58 = c.Binary(),
                        Value59 = c.Binary(),
                        Value60 = c.Binary(),
                        Value61 = c.Binary(),
                        Value62 = c.Binary(),
                        Value63 = c.Binary(),
                        Value64 = c.Binary(),
                    })
                .PrimaryKey(t => new { t.InstanceId, t.PromotionName });
            
            CreateTable(
                "[System.Activities.DurableInstancing].InstancesTable",
                c => new
                    {
                        SurrogateInstanceId = c.Long(nullable: false, identity: true),
                        Id = c.Guid(nullable: false),
                        SurrogateLockOwnerId = c.Long(),
                        PrimitiveDataProperties = c.Binary(),
                        ComplexDataProperties = c.Binary(),
                        WriteOnlyPrimitiveDataProperties = c.Binary(),
                        WriteOnlyComplexDataProperties = c.Binary(),
                        MetadataProperties = c.Binary(),
                        DataEncodingOption = c.Byte(),
                        MetadataEncodingOption = c.Byte(),
                        Version = c.Long(nullable: false),
                        PendingTimer = c.DateTime(),
                        CreationTime = c.DateTime(nullable: false),
                        LastUpdated = c.DateTime(),
                        WorkflowHostType = c.Guid(),
                        ServiceDeploymentId = c.Long(),
                        SuspensionExceptionName = c.String(maxLength: 450),
                        SuspensionReason = c.String(),
                        BlockingBookmarks = c.String(),
                        LastMachineRunOn = c.String(maxLength: 450),
                        ExecutionStatus = c.String(maxLength: 450),
                        IsInitialized = c.Boolean(),
                        IsSuspended = c.Boolean(),
                        IsReadyToRun = c.Boolean(),
                        IsCompleted = c.Boolean(),
                        SurrogateIdentityId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.SurrogateInstanceId);
            
            CreateTable(
                "[System.Activities.DurableInstancing].KeysTable",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SurrogateKeyId = c.Long(nullable: false, identity: true),
                        SurrogateInstanceId = c.Long(),
                        EncodingOption = c.Byte(),
                        Properties = c.Binary(),
                        IsAssociated = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "[System.Activities.DurableInstancing].LockOwnersTable",
                c => new
                    {
                        SurrogateLockOwnerId = c.Long(nullable: false, identity: true),
                        Id = c.Guid(nullable: false),
                        LockExpiration = c.DateTime(nullable: false),
                        WorkflowHostType = c.Guid(),
                        MachineName = c.String(nullable: false, maxLength: 128),
                        EnqueueCommand = c.Boolean(nullable: false),
                        DeletesInstanceOnCompletion = c.Boolean(nullable: false),
                        PrimitiveLockOwnerData = c.Binary(),
                        ComplexLockOwnerData = c.Binary(),
                        WriteOnlyPrimitiveLockOwnerData = c.Binary(),
                        WriteOnlyComplexLockOwnerData = c.Binary(),
                        EncodingOption = c.Byte(),
                        WorkflowIdentityFilter = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.SurrogateLockOwnerId);
            
            CreateTable(
                "[System.Activities.DurableInstancing].RunnableInstancesTable",
                c => new
                    {
                        SurrogateInstanceId = c.Long(nullable: false),
                        WorkflowHostType = c.Guid(),
                        ServiceDeploymentId = c.Long(),
                        RunnableTime = c.DateTime(nullable: false),
                        SurrogateIdentityId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.SurrogateInstanceId);
            
            CreateTable(
                "[System.Activities.DurableInstancing].ServiceDeployments",
                c => new
                    {
                        ServiceDeploymentId = c.Long(nullable: false),
                        SiteName = c.String(nullable: false, maxLength: 128),
                        RelativeServicePath = c.String(nullable: false, maxLength: 128),
                        RelativeApplicationPath = c.String(nullable: false, maxLength: 128),
                        ServiceName = c.String(nullable: false, maxLength: 128),
                        ServiceNamespace = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.ServiceDeploymentId, t.SiteName, t.RelativeServicePath, t.RelativeApplicationPath, t.ServiceName, t.ServiceNamespace });
            
            CreateTable(
                "[System.Activities.DurableInstancing].ServiceDeploymentsTable",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ServiceDeploymentHash = c.Guid(nullable: false),
                        SiteName = c.String(nullable: false),
                        RelativeServicePath = c.String(nullable: false),
                        RelativeApplicationPath = c.String(nullable: false),
                        ServiceName = c.String(nullable: false),
                        ServiceNamespace = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "[System.Activities.DurableInstancing].SqlWorkflowInstanceStoreVersionTable",
                c => new
                    {
                        Major = c.Long(nullable: false),
                        Minor = c.Long(nullable: false),
                        Build = c.Long(nullable: false),
                        Revision = c.Long(nullable: false),
                        LastUpdated = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.Major, t.Minor, t.Build, t.Revision });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GameTable", new[] { "InstanceId_InstanceId", "InstanceId_CreationTime" }, "[System.Activities.DurableInstancing].Instances");
            DropIndex("dbo.GameTable", new[] { "InstanceId_InstanceId", "InstanceId_CreationTime" });
            DropTable("[System.Activities.DurableInstancing].SqlWorkflowInstanceStoreVersionTable");
            DropTable("[System.Activities.DurableInstancing].ServiceDeploymentsTable");
            DropTable("[System.Activities.DurableInstancing].ServiceDeployments");
            DropTable("[System.Activities.DurableInstancing].RunnableInstancesTable");
            DropTable("[System.Activities.DurableInstancing].LockOwnersTable");
            DropTable("[System.Activities.DurableInstancing].KeysTable");
            DropTable("[System.Activities.DurableInstancing].InstancesTable");
            DropTable("[System.Activities.DurableInstancing].InstancePromotedProperties");
            DropTable("[System.Activities.DurableInstancing].InstancePromotedPropertiesTable");
            DropTable("[System.Activities.DurableInstancing].IdentityOwnerTable");
            DropTable("[System.Activities.DurableInstancing].Instances");
            DropTable("dbo.GameTable");
        }
    }
}
