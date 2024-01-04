using InjectionProcess.Market;
using InjectionProcess.Models;
using InjectionProcess.ViewModel;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InjectionProcess.Controllers
{
    public class HomeController : Controller
    {

        ISmartPhone _smartPhone;
        IMarketForecast _marketForecast;

        public HomeController( ISmartPhone smartPhone, IMarketForecast marketForecast)
        {
            _smartPhone = smartPhone;
            _marketForecast = marketForecast;
        }
        public IActionResult Index()
        {
            HomeVM homevm = new HomeVM();
            //MarketForecastV3 mk = new MarketForecastV3();
            MarketResult mr = _marketForecast.GetMarketResult();
            

            switch (mr.marketCondition)
            {
                case MarketCondition.StableUp:
                    homevm.MarketForecast = "Market shows sings to go up in a stable condition, its  a good time to buy a shares";
                    break;
                case MarketCondition.StableDown:
                    homevm.MarketForecast = "Market shows sings to go down in a stable condition, its  a good time to sell a shares";
                    break;
                case MarketCondition.Volatile:
                    homevm.MarketForecast = "Market looks very risky to invest, its volatile";
                    break;
                default:
                    homevm.MarketForecast = "";
                    break;
            }

            //ISmartPhone _smartPhone =new VivoGame();

            homevm.design.simMessage = _smartPhone.Sim();
            homevm.design.MemorySize = _smartPhone.getMemorySize();

            return View(homevm);
        }

        public IActionResult Privacy()
        {

            PrivacyVM pvm = new PrivacyVM();
            MarketForecast mk = new MarketForecast();
            MarketResult mr = mk.GetMarketResult();
            switch (mr.marketCondition)
            {
                case MarketCondition.StableUp:
                    pvm.MarketForecast = "hey this is  shows sings to go up in a stable condition, its  a good time to buy a shares";
                    break;
                case MarketCondition.StableDown:
                    pvm.MarketForecast = "hey this is  shows sings to go down in a stable condition, its  a good time to sell a shares";
                    break;
                case MarketCondition.Volatile:
                    pvm.MarketForecast = "hey this is  looks very risky to invest, its volatile";
                    break;
                default:
                    pvm.MarketForecast = "";
                    break;
            }



            return View(pvm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
