using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace BusinessObject.DtoModels
{
    [Table("[System.Activities.DurableInstancing].Instances")]
    public class Instance
    {
        [Key]
        [Column(Order = 0)]
        public Guid InstanceId { get; set; }

        public DateTime? PendingTimer { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime CreationTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public long? ServiceDeploymentId { get; set; }

        [StringLength(450)]
        public string SuspensionExceptionName { get; set; }

        public string SuspensionReason { get; set; }

        public string ActiveBookmarks { get; set; }

        [StringLength(128)]
        public string CurrentMachine { get; set; }

        [StringLength(450)]
        public string LastMachine { get; set; }

        [StringLength(450)]
        public string ExecutionStatus { get; set; }

        public bool? IsInitialized { get; set; }

        public bool? IsSuspended { get; set; }

        public bool? IsCompleted { get; set; }

        public byte? EncodingOption { get; set; }

        public byte[] ReadWritePrimitiveDataProperties { get; set; }

        public byte[] WriteOnlyPrimitiveDataProperties { get; set; }

        public byte[] ReadWriteComplexDataProperties { get; set; }

        public byte[] WriteOnlyComplexDataProperties { get; set; }

        public string IdentityName { get; set; }

        public string IdentityPackage { get; set; }

        public long? Build { get; set; }

        public long? Major { get; set; }

        public long? Minor { get; set; }

        public long? Revision { get; set; }
    }
}
