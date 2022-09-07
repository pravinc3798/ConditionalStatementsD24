namespace ConditionalStatementsD24
{
    public class PrintAlphabets
    {
        public static void Print()
        {
            Console.WriteLine();
            var start = 'a';
            for (var i = 0; i < 26; i++)
            {
                Console.Write("{0} -> ",start);
                start++;
            }
            Console.Write("End \n");
        }
    }
}