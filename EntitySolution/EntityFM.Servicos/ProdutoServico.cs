using EntityFM.Dados.Interfaces;
using EntityFM.Modelos;
using EntityFM.Servicos.Interfaces;
using System;
using System.Threading.Tasks;

namespace EntityFM.Servicos
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoServico(IProdutoRepositorio produtoRepositorio)
        {
            this._produtoRepositorio = produtoRepositorio;
        }

        public async Task Cadastrar(Produto produto)
        {
            await this._produtoRepositorio.Cadastrar(produto);
        }

        public async Task<Produto> Obter(string codigoBarras)
        {
            return await this._produtoRepositorio.Obter(codigoBarras);
        }
    }
}
