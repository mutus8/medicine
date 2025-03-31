using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using proyecto.Models.Medicine;
using proyecto.Services.Aemps;

namespace proyecto.Controllers
{
    [Authorize]
    public class SearchController : Controller
    {
        private readonly ILogger<SearchController> _logger;
        private readonly IAempsService _aempsService;

        public SearchController(ILogger<SearchController> logger, IAempsService aempsService)
        {
            _logger = logger;
            _aempsService = aempsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Search/List/{param?}")]
        public async Task<IActionResult> List(string param)
        {
            List<MedicineModel> medicineList = await _aempsService.GetMedicineList(param);
            return View(medicineList);
        }
    }
}
