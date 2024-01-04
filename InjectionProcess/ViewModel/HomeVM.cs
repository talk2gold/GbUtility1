namespace InjectionProcess.ViewModel
{
    public class HomeVM
    {
        public string MarketForecast { get; set; }
        public GameDesign design { get; set; }
        public HomeVM()
        {
            design= new GameDesign();   
        }
    }
}
