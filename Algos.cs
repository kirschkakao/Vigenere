using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace Vigenere
{
    public class Algos
    {
        #region Methods
        public static string Crypt(string Input, string Key, string Mode)
        {
            char[] buffer=new char[Input.Length];
            int[] iKey = new int[Key.Length];
            //Transform Keystring to integer array using the alphabet object
            for(int i=0;i<Key.Length;i++)
            {
                iKey[i] = Key[i] - 'A';
            }
            //Encrypt input with the given Key
            for(int i=0;i<Input.Length;i++)
            {
                int iLetter=Input[i]-'A';
                switch (Mode)
                {
                    case "Encrypt": iLetter = (iLetter + iKey[i % iKey.Length]) % 26;break;
                    case "Decrypt": iLetter = iLetter < iKey[i % iKey.Length] ? (iLetter + 26 - iKey[i % iKey.Length]) % 26 : (iLetter - iKey[i % iKey.Length]) % 26;break;
                }
                buffer[i] = Convert.ToChar(iLetter + 'A');
            }
            //return crypted Text
            return new string(buffer);
        }

        public static string FormatText(string Inputtext)
        {
            string FormattedText = Inputtext.ToUpper();
            FormattedText = FormattedText.Replace("Ä", "AE");
            FormattedText = FormattedText.Replace("Ü", "UE");
            FormattedText = FormattedText.Replace("Ö", "OE");
            FormattedText = FormattedText.Replace("ß", "SS");
            FormattedText = Regex.Replace(FormattedText, "[^A-Z]", "");
            return FormattedText;
        }
        public static int FormatNumber(string Inputnumber)
        {
            string number = Regex.Replace(Inputnumber, "[^0-9]", "");
            if (int.TryParse(number, out int n)) return Convert.ToInt32(number);
            return 0;
        }

        public static double[] CalcPhiVec(string text, int philength)
        {
            double[] PhiVec = new double[philength];
            for (int j = 1; j <= philength; j++)
            {
                List<StringBuilder> textparts = new List<StringBuilder>();
                for (int i = 0; i < text.Length; i++)
                {
                    try { textparts[i % j].Append( text[i]); }
                    catch (ArgumentOutOfRangeException){ textparts.Add(new StringBuilder()); textparts[i % j].Append(text[i]); }
                }
                double phisum = 0.0;
                for (int i = 0; i < textparts.Count(); i++)
                {
                    phisum += CalcPhi(textparts[i].ToString());
                }
                PhiVec[j - 1] = Math.Round((double)phisum / textparts.Count(),4);
            }
            return PhiVec;
        }

        public static double CalcPhi(string textpart)
        {
            return (double)textpart.GroupBy(x => x).Select(x => x.Count() * (x.Count() - 1)).Sum() / (textpart.Length*(textpart.Length-1));
        }
        #endregion

        public static string FormatArr(double[] input)
        {
            StringBuilder output = new StringBuilder();
            output.Append("[");
            for (int i=0;i<input.Length;i++)
            {
                output.Append($"; {input[i]}");
            }
            if(input.Length>0)output.Remove(1, 2);
            output.Append("]");
            return output.ToString();
        }

        public static string GenerateKey(string text, int KeyLen)
        {
            List<StringBuilder> textparts = new List<StringBuilder>();
            for (int i = 0; i < text.Length; i++)
            {
                try { textparts[i % KeyLen].Append(text[i]); }
                catch (ArgumentOutOfRangeException) { textparts.Add(new StringBuilder()); textparts[i % KeyLen].Append(text[i]); }
            }
            StringBuilder key = new StringBuilder();
            for (int i = 0; i < textparts.Count(); i++)
            {
                char mostoftenletter = textparts[i]
                    .ToString()
                    .GroupBy(x => x)
                    .Select(x => new { letter = x.Key, count = x.Count() })
                    .OrderByDescending(x => x.count)
                    .First().letter;
                key.Append(mostoftenletter - 'E' < 0 ? Convert.ToChar(mostoftenletter - 'E' + 'A' + 26) : Convert.ToChar(mostoftenletter - 'E' + 'A'));
            }
            return key.ToString();
        }
    }
}
