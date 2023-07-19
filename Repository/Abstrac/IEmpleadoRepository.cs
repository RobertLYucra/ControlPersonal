using BackEndApi.Models;

namespace BackEndApi.Repository.Interfaces
{
    public interface IEmpleadoRepository
    {
        Task<List<Empleado>> GetListEmpleado();
        Task<Empleado> GetEmpleadoById(int id);
        Task<Empleado> CreateEmpleado(Empleado empleado);
        Task<bool> UpdateEmpleado(Empleado empleado);
        Task<bool> DeleteEmpleado(Empleado empleado);
    }
}
