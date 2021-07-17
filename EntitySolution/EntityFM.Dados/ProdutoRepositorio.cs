using EntityFM.Dados.Interfaces;
using EntityFM.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFM.Dados
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly ApplicationDbContext _contexto;

        public ProdutoRepositorio(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task Cadastrar(Produto produto)
        {
            await _contexto.Produtos.AddAsync(produto);
            await _contexto.SaveChangesAsync();
        }

        public async Task<Produto> Obter(string codigoBarras)
        {
            return await _contexto.Produtos.FirstOrDefaultAsync(x => x.CodigoBarras == codigoBarras);
        }
    }
}
