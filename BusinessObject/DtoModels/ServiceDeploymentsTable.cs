using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace BusinessObject.DtoModels
{
    [Table("[System.Activities.DurableInstancing].ServiceDeploymentsTable")]
    public class ServiceDeploymentsTable
    {
        public long Id { get; set; }

        public Guid ServiceDeploymentHash { get; set; }

        [Required]
        public string SiteName { get; set; }

        [Required]
        public string RelativeServicePath { get; set; }

        [Required]
        public string RelativeApplicationPath { get; set; }

        [Required]
        public string ServiceName { get; set; }

        [Required]
        public string ServiceNamespace { get; set; }
    }
}
