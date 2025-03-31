using proyecto.Models.Medicine;

namespace proyecto.Services.Aemps
{
    public interface IAempsService
    {
        public Task<List<MedicineModel>> GetMedicineList(string param);
    }
}
