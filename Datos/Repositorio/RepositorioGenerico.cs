using Datos.Context;
using Datos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorio
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
        protected readonly AppDbContext _contexto;
        protected readonly DbSet<T> _dbSet;

        public RepositorioGenerico(AppDbContext contexto)
        {
            _contexto = contexto;
            _dbSet = _contexto.Set<T>();
        }

        public async Task<IEnumerable<T>> ListarAsync() => await _dbSet.ToListAsync();

        public async Task<T> ObtenerPorIdAsync(int id) => await _dbSet.FindAsync(id);

        public async Task<T> InsertarAsync(T entidad)
        {
            await _dbSet.AddAsync(entidad);
            await _contexto.SaveChangesAsync();
            return entidad;
        }

        public async Task ActualizarAsync(T entidad)
        {
            _dbSet.Update(entidad);
            await _contexto.SaveChangesAsync();
        }

        public async Task EliminarAsync(int id)
        {
            var entidad = await ObtenerPorIdAsync(id);
            _dbSet.Remove(entidad);
            await _contexto.SaveChangesAsync();
        }
    }
}
