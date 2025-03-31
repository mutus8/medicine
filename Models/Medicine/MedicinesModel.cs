namespace proyecto.Models.Medicine
{
    public class MedicinesModel
    {
        public int totalFilas { get; set; }
        public int pagina { get; set; }
        public int tamanioPagina { get; set; }
        public List<MedicineModel> resultados { get; set; } = [];

    }
}
