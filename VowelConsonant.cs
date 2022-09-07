namespace ConditionalStatementsD24
{
    public class VowelConsonant
    {
        public static void ChkAlphabet(string input)
        {
            var vowels = new string[] { "a", "e", "i", "o", "u" };

            var result = vowels.Contains(input) ? string.Format("{0} is a VOWEL", input) : string.Format("{0} is a CONSONANT", input);
            Console.Write("\n>>>>> {0}", result);
        }
    }
}