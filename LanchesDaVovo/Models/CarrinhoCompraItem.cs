using System.ComponentModel.DataAnnotations;

namespace LanchesDaVovo.Models
{
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraItemId { get; set; }
        public Lanche Lanche { get; set; }
        public int Quantidade { get; set; }

        [StringLength(255)]
        public string CarrinhoCompraId { get; set; }
    }
}
