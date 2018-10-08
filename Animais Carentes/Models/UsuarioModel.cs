using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Animais_Carentes.Models
{
    public class UsuarioModel
    {
        [Key]
        [DisplayName("CPF")]
        [StringLength(11)]
        [Required(ErrorMessage = "Informe seu CPF")]
        public string cpf { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Informe seu Nome")]
        public string nome { get; set; }

        [DisplayName("Sobrenome")]
        public string sobrenome { get; set; }

        [DisplayName("Sexo")]
        public string sexo { get; set; }

        [DisplayName("Idade")]
        public int idade { get; set; }

        [DisplayName("CEP")]
        [StringLength(8)]
        [Required(ErrorMessage = "Informe seu cep")]
        public string cep { get; set; }

        [DisplayName("Estado")]
        [StringLength(2)]
        [Required(ErrorMessage = "Informe seu estado")]
        public string estado { get; set; }

        [DisplayName("Cidade")]
        [Required(ErrorMessage = "Informe sua cidade")]
        public string codade { get; set; }

        [DisplayName("Bairro")]
        public string bairro { get; set; }

        [DisplayName("Logradouro")]
        public string rua { get; set; }

        [DisplayName("Numero")]
        public string numero { get; set; }

        [DisplayName("Email")]
        [StringLength(50)]
        [Required(ErrorMessage = "Informe seu Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        public string email { get; set; }

        [DisplayName("Senha")]
        [StringLength(11)]
        [Required(ErrorMessage = "Informe sua senha")]
        public string senha { get; set; }

        [DisplayName("Data Nascimento")]
        [DataType(DataType.Date)]
        public DateTime nascimento { get; set; }

    }
}