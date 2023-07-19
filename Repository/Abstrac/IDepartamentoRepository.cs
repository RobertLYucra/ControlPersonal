using BackEndApi.Models;

namespace BackEndApi.Repository.Interfaces
{
    public interface IDepartamentoRepository
    {
        Task<List<Departamento>> GetListDepartments();
    }
}
