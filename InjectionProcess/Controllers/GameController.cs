using InjectionProcess.Market;
using InjectionProcess.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace InjectionProcess.Controllers
{
    public class GameController : Controller
    {
        private readonly ISmartPhone _ismartPhone;
        public GameController(ISmartPhone smartPhone)
        {
            _ismartPhone = smartPhone;
        }
        public IActionResult GameInfo() 
        {

            GameDesign ds = new GameDesign();
            ds.simMessage = _ismartPhone.Sim();
            ds.MemorySize = _ismartPhone.getMemorySize();

            return View(ds);
        }
    }
}
