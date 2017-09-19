using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula1AspNetMVC.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido.")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        [DisplayName("Nome do Cliente")]
        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        public string Nome { get; set; }
        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido.")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        [DisplayName("Sobrenome")]
        [Required(ErrorMessage = "Campo Sobrenome obrigatório")]
        public string SobreNome { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido.")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        [DisplayName("Email")]
        [Required(ErrorMessage = "Campo E-mail obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido")]
        public string Email { get; set; }
    }
}   