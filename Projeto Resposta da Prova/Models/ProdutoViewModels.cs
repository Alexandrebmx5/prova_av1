using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Resposta_da_Prova.Models
{
    public class ProdutoViewsModels
    {
        [DisplayName("Código do produto")]
        [Required(ErrorMessage = "O campo Códido do produto é obrigatório")]
        public string CodProd { get; set; }

        [DisplayName("Preço")]
        [Required(ErrorMessage = "O campo Preço é obrigatório")]
        public string Preco { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo categoria é obrigatório")]
        public string Categoria { get; set; }

        [DisplayName("Observação")]
        public string Observacao { get; set; }

    }
}
