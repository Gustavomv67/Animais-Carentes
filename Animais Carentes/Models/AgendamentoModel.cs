using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Animais_Carentes.Models
{
    public class AgendamentoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [DisplayName("ONG")]
        public OngModel ong { get; set; }

        [DisplayName("Usuario")]
        public UsuarioModel usuario { get; set; }

        [DisplayName("Data entrega")]
        [DataType(DataType.Date)]
        public DateTime dataEntrega { get; set; }

        [DisplayName("Você prefere entregar o animal ou quer que busquemos ele?")]
        public bool usuarioEntrega { get; set; }

        [DisplayName("Caso busquemos o animal, onde devemos ir para pega-lo?")]
        public string enderecoEntrega { get; set; }

        [DisplayName("Qual o tipo de animal?")]
        public string animal { get; set; }




    }
}