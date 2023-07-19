using BackEndApi.Models;
using BackEndApi.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackEndApi.Repository
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private DbempleadoContext _dbContext;
        
        public EmpleadoRepository(DbempleadoContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<List<Empleado>> GetListEmpleado()
        {
            try
            {
                List<Empleado> list = new List<Empleado>();
                return await _dbContext.Empleados.Include(x=>x.IdDepartamentoNavigation).ToListAsync();
            } catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Empleado> GetEmpleadoById(int id)
        {
            try
            {
                Empleado? empleado = new Empleado();
                empleado= await _dbContext.Empleados.Include(x=>x.IdDepartamentoNavigation)
                    .Where(x=>x.IdEmpleado == id).FirstOrDefaultAsync();
                return empleado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Empleado> CreateEmpleado(Empleado empleado)
        {
            try
            {
                _dbContext.Empleados.Add(empleado);
                await _dbContext.SaveChangesAsync();
                return empleado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateEmpleado(Empleado empleado)
        {
            try
            {
                _dbContext.Empleados.Update(empleado);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> DeleteEmpleado(Empleado empleado)
        {
            try
            {
                _dbContext.Remove(empleado);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
