﻿
using Api_CQRS.Models;
using Api_CQRS.Recursos.Command;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Api_CQRS.Recursos.Commands
{
    public class ProdutoDeleteCommandHandler : IRequestHandler<ProdutoDeleteCommand, Produto>
    {
        private readonly AppDbContext _context;
        public ProdutoDeleteCommandHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Produto> Handle(ProdutoDeleteCommand request, CancellationToken cancellationToken)
        {
            var produto = await _context.Produto.Where(a => a.Id == request.Id).FirstOrDefaultAsync();
            _context.Remove(produto);

            await _context.SaveChangesAsync();
            return produto;
        }
    }
}