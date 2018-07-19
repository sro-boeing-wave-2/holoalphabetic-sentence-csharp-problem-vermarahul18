using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            Boolean val = true;
            for (int i = 0; i < alphabets.Length; i++) {
                if (input.ToLower().Contains(alphabets[i]))
                {
                    val = true;
                }
                else  {
                    val = false;
                    break;
                }
            }
            return val;
        }
    }
}
