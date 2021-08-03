using System;

namespace madFurry
{
    public static class StringHelpers
    {
        public static int ToInt(this string str)
        {
            int result;
            if (Int32.TryParse(str, out result))
                return result;
            return 0;
        }
    }
}
