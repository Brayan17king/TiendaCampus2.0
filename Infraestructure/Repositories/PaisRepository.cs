using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;
using Infrastructure.Repositorios;

namespace Infraestructure.Repositories;

public class PaisRepository : GenericRepository<Pais>, IPais
{
    private readonly TiendaCampusContext _context;

    public PaisRepository(TiendaCampusContext context) : base(context)
    {
        _context = context;
    }

    public Task ToListAsync()
    {
        throw new NotImplementedException();
    }

    public Task ToString(string nombre)
    {
        throw new NotImplementedException();
    }
}
