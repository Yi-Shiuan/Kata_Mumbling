namespace Kata_Mumbling
{
    #region

    using System.Linq;

    #endregion

    public class Mumbling
    {
        public string Accum(string s)
        {
            return string.Join("-", s.Select((x, i) => new string(char.ToUpper(x), 1) + new string(char.ToLower(x), i)));
        }
    }
}