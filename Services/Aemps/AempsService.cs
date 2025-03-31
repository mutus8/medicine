using Newtonsoft.Json;
using proyecto.Models.Medicine;

namespace proyecto.Services.Aemps
{
    public class AempsService : IAempsService
    {
        private readonly HttpClient _httpClient;

        public AempsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            //_client = client;
            _httpClient.BaseAddress = new Uri("https://cima.aemps.es/cima/rest/");
        }

        public async Task<List<MedicineModel>> GetMedicineList(string param)
        {
            string uri = $"medicamentos?nombre={param}";
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                //return JsonConvert.DeserializeObject<List<MedicineModel>>(await response.Content.ReadAsStringAsync()) ?? [];
                return JsonConvert.DeserializeObject<MedicinesModel>(jsonString)?.resultados ?? [];
            }
            return [];
        }

        public async Task<List<MedicineModel>> GetMedicines(string param)
        {
            string uri = $"medicamentos?nombre={param}"; 
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<MedicineModel>>(await response.Content.ReadAsStringAsync()) ?? [];
            }
            return [];
        }
    }

    
}
