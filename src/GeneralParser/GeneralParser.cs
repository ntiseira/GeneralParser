using System;

namespace GeneralParser
{
    public static class GeneralParser
    {
        public static DateTime ParseDateInvariant(this string dateToParse)
        {
            DateTime dt;

            try
            {
                dt = DateTime.ParseExact(dateToParse, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {

                dt = DateTime.MinValue;
            }

            return dt;
        }
    }
}
