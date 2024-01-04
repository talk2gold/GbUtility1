namespace InjectionProcess.Market
{
    public class OppoGame : ISmartPhone
    {

        private string createdTime;
        public OppoGame()
        {
            createdTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public int getMemorySize()
        {
            return 256;
        }

        public bool ScreenFunctionality()
        {
            return false;
        }

        public string Sim()
        {
            return $"I am from OPPO instance created time {createdTime}";
        }
    }
}
