using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoMapperApp.ViewModel
{
    public class ClienteViewModel
    {
        [Required(ErrorMessage = "Favor preencher o campo nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo de data de nascimento.")]
        [Display(Name = "Data de Nascimento")]
        //máscara para data
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido.")]
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
        public int NumeroDaSorte { get; set; }
    }
}