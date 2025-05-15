using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Tournament.Model.Models
{
    public class PlayerRegister
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public Player? Player { get; set; }
        public int RegisterId { get; set; }
        public Register? Register { get; set; }
    }
}
