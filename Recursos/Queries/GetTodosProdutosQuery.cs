﻿using Api_CQRS.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_CQRS.Recursos.Queries
{
    public class GetTodosProdutosQuery : IRequest<IEnumerable<Produto>>
    {
    }
}
