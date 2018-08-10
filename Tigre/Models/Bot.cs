using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tigre.Models
{
    [Table("Bot")]
    public class Bot
    {
        [Key]
        public int BotId { get; set; }
        [Required(ErrorMessage = "Informe o login do usuário.")]
        [Display(Name = "Usuário")]
        public string BotNome { get; set; }

    }
}
