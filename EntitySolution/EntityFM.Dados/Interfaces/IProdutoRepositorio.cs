using EntityFM.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFM.Dados.Interfaces
{
    public interface IProdutoRepositorio
    {
        Task<Produto> Obter(string codigoBarras);
        Task Cadastrar(Produto produto);
    }
}
