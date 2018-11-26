using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Animais_Carentes.Models
{
    public class AnimalModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [DisplayName("Especie")]
        [Required(ErrorMessage = "Informe sua Especie")]
        public string especie { get; set; }

        [DisplayName("Raça")]
        public string raca { get; set; }

        [DisplayName("Descrição")]
        public string descricao { get; set; }


    }
}