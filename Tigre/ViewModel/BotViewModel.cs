using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tigre.ViewModel
{
    [Table("Bot")]
    public class BotViewModel
    {
        [Key]
        public int BotId { get; set; }
       

    }
}
