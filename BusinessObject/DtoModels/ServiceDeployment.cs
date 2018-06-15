using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace BusinessObject.DtoModels
{
    [Table("[System.Activities.DurableInstancing].ServiceDeployments")]
    public class ServiceDeployment
    {
        [Key]
        [Column(Order = 0)]
        public long ServiceDeploymentId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string SiteName { get; set; }

        [Key]
        [Column(Order = 2)]
        public string RelativeServicePath { get; set; }

        [Key]
        [Column(Order = 3)]
        public string RelativeApplicationPath { get; set; }

        [Key]
        [Column(Order = 4)]
        public string ServiceName { get; set; }

        [Key]
        [Column(Order = 5)]
        public string ServiceNamespace { get; set; }
    }
}
