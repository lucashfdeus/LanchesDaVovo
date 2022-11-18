using LanchesDaVovo.Models;
using LanchesDaVovo.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LanchesDaVovo.Components
{
    public class CarrinhoCompraResumo : ViewComponent
    {
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraResumo(CarrinhoCompra carrinhoCompra)
        {
                _carrinhoCompra = carrinhoCompra;
        }

        public IViewComponentResult Invoke()
        {
            //Para testar
            var itens = new List<CarrinhoCompraItem>() { new CarrinhoCompraItem(), new CarrinhoCompraItem() };
            //var itens = _carrinhoCompra.GetCarrinhoCompraItems();
             _carrinhoCompra.CarrinhoCompraItens = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal(),
            };
            return View(carrinhoCompraVM);
        }
    }
}
