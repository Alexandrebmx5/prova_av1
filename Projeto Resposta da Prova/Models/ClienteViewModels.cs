using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Resposta_da_Prova.Models
{
    public class ClienteViewModel
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome precisa ter no mínimo 5 letras", MinimumLength = 5)]
        public string Nome { get; set; }

        public string Sexo { get; set; }

        [DisplayName("CPF")]
        [Required(ErrorMessage = "O campo CPF é obrigatório")]
        public string cpf { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Cep { get; set; }

        public string Telefone { get; set; }

        [DisplayName("Endereço")]
        public string Endereco { get; set; }

    }
}
