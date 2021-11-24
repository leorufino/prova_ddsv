using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/inicializar")]
    public class InicializarDadosController : ControllerBase
    {
        private readonly DataContext _context;
        public InicializarDadosController(DataContext context)
        {
            _context = context;
        }

        //POST: api/inicializar/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create()
        {
            _context.Categorias.AddRange(new Categoria[]
                {
                    new Categoria { CategoriaId = 1, Nome = "Jogos Eletronicos" },
                    new Categoria { CategoriaId = 2, Nome = "Jogos de Tabuleiro" },
                }
            );
            _context.Produtos.AddRange(new Produto[]
                {
                    new Produto { ProdutoId = 1, Nome = "Doom 3", Preco = 198, Quantidade = 200, CategoriaId = 1 },
                    new Produto { ProdutoId = 2, Nome = "Counter-Strike", Preco = 23, Quantidade = 132, CategoriaId = 1 },
                    new Produto { ProdutoId = 3, Nome = "World of Warcraft", Preco = 125, Quantidade = 150, CategoriaId = 1 },
                    new Produto { ProdutoId = 4, Nome = "Monopoly", Preco = 99, Quantidade = 25, CategoriaId = 2}
                }
            );
            _context.FormasDePagamento.AddRange(new FormaDePagamento[]
                {
                    new FormaDePagamento { FormaDePagamentoId = 1, TipoDePagamento = "Crédito", Parcelas = "3x" },
                    new FormaDePagamento { FormaDePagamentoId = 2, TipoDePagamento = "Boleto", Parcelas = "À vista" },
                    new FormaDePagamento { FormaDePagamentoId = 3, TipoDePagamento = "Pix", Parcelas = "À vista" }
                }
            );
            _context.SaveChanges();
            return Ok(new { message = "Dados inicializados com sucesso!" });
        }
    }
}