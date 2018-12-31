using System.Globalization;

namespace WebApplication17
{
    public class Lol : ILol
    {
        public string ToUpperCase(string str)
        {
            return str.ToUpper(CultureInfo.InvariantCulture);
        }
    }
}