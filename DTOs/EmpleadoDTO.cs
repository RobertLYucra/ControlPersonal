namespace BackEndApi.DTOs
{
    public class EmpleadoDTO
    {
        public int IdEmpleado { get; set; }
        public string NombreCompleto { get; set; } = null!;
        public int? IdDepartamento { get; set; }
        public int? Sueldo { get; set; }
        public DateTime? FechaContrato { get; set; }
    }
}
