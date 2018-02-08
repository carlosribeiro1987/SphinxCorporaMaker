using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Util.Text {
    public class TextUtil {

        /// <summary>
        /// Split a single string into an string array based on ponctuation.
        /// </summary>
        /// <param name="input">The string to be splitted.</param>
        /// <returns>A string array with the splitted sentences.</returns>
        public static string[] SplitSentences(string input) {
            string[] output = input.Split('.', ':', '!', '(', ')', '?', '/');
            for (int i = 0; i < output.Length;i++) {
                if (output[i].StartsWith(" "))
                    output[i] = output[i].Substring(1);
            }
            
            return output;
        }

        /// <summary>
        /// Remove symbols and ponctuation from a string.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>A string containing only letters and spaces.</returns>
        public static string RemoveSymbols(string input) {
            return Regex.Replace(input, @"[^\p{L} ]", "", RegexOptions.None, TimeSpan.FromSeconds(1.5));
        }

    }
}
