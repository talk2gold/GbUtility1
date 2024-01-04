namespace InjectionProcess.Market
{
    public class AndroidGame : ISmartPhone
    {
        private string createdTime;
        public AndroidGame()
        {
            createdTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        public int getMemorySize()
        {
            return 23;
        }

        public bool ScreenFunctionality()
        {
            return true;
        }

        public string Sim()
        {
            return $"this is my standard from Android  Object Created time is {createdTime}";
        }
    }
}
