namespace TecTip_Pattern
{
    public class SolidWorksSingleton
    {
        private static SolidWorksSingleton _instance;
        private SolidWorksSingleton() { }

        public static SolidWorksSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SolidWorksSingleton();
                }
                return _instance;
            }
        }

        // Add methods and properties that access the SolidWorks API here
    }

}
