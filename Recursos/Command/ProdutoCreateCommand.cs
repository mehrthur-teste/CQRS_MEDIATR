using Api_CQRS.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_CQRS.Recursos.Command
{
    public class ProdutoCreateCommand : IRequest<Produto>
    {
        public string Nome { get; set; }
        public string CodigoBarras { get; set; }
        public bool Ativo { get; set; } = true;
        public string Descricao { get; set; }
        public decimal Taxa { get; set; }
        public decimal Preco { get; set; }
    }
}
