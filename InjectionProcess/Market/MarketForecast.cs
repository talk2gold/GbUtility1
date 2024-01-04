namespace InjectionProcess.Market
{
    public class MarketForecast : IMarketForecast
    {
        public MarketResult GetMarketResult()
        {
            return new MarketResult
            {
                marketCondition = MarketCondition.StableUp
            };
        }
    }

    public class MarketForecastV2 : IMarketForecast
    {
        public MarketResult GetMarketResult()
        {
            return new MarketResult
            {
                marketCondition = MarketCondition.StableDown
            };
        }
    }

    public class MarketForecastV3 : IMarketForecast
    {
        public MarketResult GetMarketResult()
        {
            return new MarketResult
            {
                marketCondition = MarketCondition.Volatile
            };
        }
    } 
    public class MarketResult
    {
        public MarketCondition marketCondition { get; set; }
    }
}
