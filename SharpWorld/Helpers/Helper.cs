using System;

namespace SharpWorld.Helpers
{
    class Helper
    {
        private static Random _random = new Random();
        public static int GetRandom(int min, int max)
        {
            return _random.Next(min, max+1);
        }
    }
}
