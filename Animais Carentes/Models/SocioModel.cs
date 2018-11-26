using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Animais_Carentes.Models
{
    public class SocioModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [DisplayName("ONG")]
        public OngModel ong { get; set; }

        [DisplayName("Usuario")]
        public UsuarioModel usuario { get; set; }

        


    }
}