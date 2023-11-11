using Api.Interfaces;

namespace Api.models;

public class ProdutoRepositorio : IProduto
{
    public ProdutoRepositorio()
    {
        using (var context = new ApiContext())
        {
            var produtos = new List<Produto>
                {
                new Produto
                {
                    Nome = "Cafe",
                    PontosRequeridos = 100
                },
             };
            context.Produtos.AddRange(produtos);
            context.SaveChanges();
        }
    }
    public List<Produto> GetFuncionarios()
    {
        using (var context = new ApiContext())
        {
            var list = context.Produtos
                .ToList();
            return list;
        }
    }
}
