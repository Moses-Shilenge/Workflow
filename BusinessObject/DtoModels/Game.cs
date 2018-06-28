using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DtoModels
{
    [Table("GameTable")]
    public class Game
    {
        [Key]
        public Guid Id { get; set; }
        public Guid InstanceId { get; set; }
        public int MaxNumber { get; set; }
        public string WorkflowType { get; set; }
        public int Guess { get; set; }
        public string Result { get; set; }
        public int Turns { get; set; }
        public int RandomNumber { get; set; }
    }
}
