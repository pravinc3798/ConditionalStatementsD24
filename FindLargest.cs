namespace ConditionalStatementsD24
{
    public class FindLargest
    {
        public static void UsingNestedCondition(int[] intArray)
        {
            if (intArray[0] > intArray[1])
            {
                if (intArray[0] > intArray[2])
                    Console.WriteLine("{0} is the Largest Number", intArray[0]);
            }
            else if (intArray[1] > intArray[2])
                Console.WriteLine("{0} is the Largest Number", intArray[1]);
            else
                Console.WriteLine("{0} is the Largest Number", intArray[2]);
        }

        public static void UsingAccumulator(int[] intArray)
        {
            var max = 0;
            foreach (var num in intArray)
                max = (num > max) ? num : max;
            Console.WriteLine("{0} is the Largest Number", max);
        }
    }
}