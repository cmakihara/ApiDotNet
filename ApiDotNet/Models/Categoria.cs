using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDotNet.Models
{
    public class Categoria
    {

        public int id { set; get; }
       // [Display(Name = "Descrição")]
      //  [Required(ErrorMessage = "O campo descrição obrigatório")]
        //[Range(1,10,ErrorMessage ="Valor errada")]
        public string Descricao { set; get; }

       // public List<Produto> Produtos { get; set; }

    }
}
