namespace ConditionalStatementsD24
{
    public class NumberSign
    {
        public static void CheckNumber(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("0 is a NEUTRAL Number");
                return;
            }

            var result = (number > 0) ? string.Format("{0} is a POSITIVE Number", number) : string.Format("{0} is a NEGATIVE Number", number);
            Console.Write("\n>>>>> {0}", result);
        }
    }
}