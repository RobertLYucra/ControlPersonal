using BackEndApi.Models;
using BackEndApi.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackEndApi.Repository
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        private DbempleadoContext _dbContext;

        public DepartamentoRepository(DbempleadoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Departamento>> GetListDepartments()
        {
            try
            {
                List <Departamento> departamentos = new List <Departamento> ();
                return await _dbContext.Departamentos.ToListAsync();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
