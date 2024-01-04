namespace InjectionProcess.Market
{
    public class VivoGame : ISmartPhone
    {
        private string createdTime;
        public VivoGame()
        {
            createdTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        public int getMemorySize()
        {
            return 112;
        }

        public bool ScreenFunctionality()
        {
            return false;
        }

        public string Sim()
        {
            return $"This is from Vivo - Game created time {createdTime}";
        }
    }
}
