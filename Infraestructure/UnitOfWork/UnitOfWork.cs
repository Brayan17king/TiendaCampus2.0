using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infraestructure.Data;
using Infraestructure.Repositories;

namespace Infraestructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly TiendaCampusContext _context;

        private IPais _Paises;
        private IDepartamento _Departamentos;
        private ICiudad _Ciudades;

        public UnitOfWork(TiendaCampusContext context)
        {
            _context = context;
        }

        public IPais Paises
        {
            get{
                if (_Paises == null){
                    _Paises = new PaisRepository(_context);
                }
                return _Paises;
            }
        }

        public IDepartamento Departamentos
        {
            get{
                if (_Departamentos == null){
                    _Departamentos = new DepartamentoRepository(_context);
                }
                return _Departamentos;
            }
        }

        public ICiudad Ciudades
        {
            get{
                if (_Ciudades == null){
                    _Ciudades = new CiudadRepository(_context);
                }
                return _Ciudades;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Task<int> saveAsync()
        {
            throw new NotImplementedException();
        }
    }
}