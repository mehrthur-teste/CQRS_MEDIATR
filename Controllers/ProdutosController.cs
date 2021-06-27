using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_CQRS.Models;
using Api_CQRS.Recursos.Command;
using Api_CQRS.Recursos.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {

        private readonly IMediator _mediator;

        public ProdutosController(AppDbContext context, IMediator mediator)
        {
            _mediator = mediator;
        }

        // METODO PRINCIPAL DE INICIALIZAÇÃO
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            try
            {
                var command = new GetTodosProdutosQuery();
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Produto>> GetProdutos(int id)
        {
            try
            {
                var command = new GetProdutoPorIdQuery { Id = id };
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto([FromBody] ProdutoCreateCommand command)
        {
            try
            {
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Produto>> DeleteProduto(int id)
        {
            try
            {
                var command = new ProdutoDeleteCommand { Id = id };
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<Produto>> PutProduto([FromBody] ProdutoUpdateCommand command)
        {
            try
            {
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
