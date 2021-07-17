using System;

namespace EntityFM.Modelos
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string ChaveAcesso { get; set; }
    }
}
