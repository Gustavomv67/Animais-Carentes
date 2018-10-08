using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Animais_Carentes.Models
{
    public class OngModel
    {
        [Key]
        [DisplayName("CNPJ")]
        [StringLength(11)]
        [Required(ErrorMessage = "Informe o cnpj da sua ONG")]
        public string cnpj { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Informe o nome da sua ONG")]
        public string nome { get; set; }

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
        public string cidade { get; set; }

        [DisplayName("Bairro")]
        public string bairro { get; set; }

        [DisplayName("Logradouro")]
        public string rua { get; set; }

        [DisplayName("Numero")]
        public string numero { get; set; }

        [DisplayName("Telefone")]

        [Required(ErrorMessage = "Informe seu telefone")]
        public string telefone { get; set; }

        [DisplayName("Email")]
        [StringLength(50)]
        [Required(ErrorMessage = "Informe o email da sua ONG")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        public string email { get; set; }

        [DisplayName("Senha")]
        [StringLength(11)]
        [Required(ErrorMessage = "Informe a senha da sua ONG")]
        public string senha { get; set; }


    }
}