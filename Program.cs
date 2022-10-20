public class Program
{
    public static void Main()
    {
        int s = 4;
        FindStep(s, 0, new int[s], Array.Empty<int>());
    }

    public static void FindStep(int input, int currentIndex, int[] currectClimb, int[] vals)
    {
        if (input < 0)
            return;

        if (input == 0)
        {
            _ = vals.Append(currentIndex);
            int last = 0;
            for (int i = currentIndex - 1; i >= 0; i--)
            {
                int current = currectClimb[i];
                int res = current - last;
                last = current;
                Console.Write($"{res}{(i > input ? "," : "")} ");
            }
            Console.WriteLine();
            return;
        }

        currectClimb[currentIndex] = input;
        FindStep(input - 1, currentIndex + 1, currectClimb, vals);
        FindStep(input - 2, currentIndex + 1, currectClimb, vals);
    }
}
