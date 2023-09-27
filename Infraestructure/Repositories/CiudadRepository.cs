using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infraestructure.Data;
using Infrastructure.Repositorios;

namespace Infraestructure.Repositories
{
    public class CiudadRepository : GenericRepository<Ciudad>
    {
        private readonly TiendaCampusContext _context;

        public CiudadRepository(TiendaCampusContext context) : base(context)
        {
            _context = context;
        }
    }
}