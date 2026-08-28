using System;
using System.IO;
using System.Linq;


public class HelloWorld
{
    static public void Main()
    {
        String line;
        line = Console.ReadLine();
        int T = Convert.ToInt32(line);

        for(int t_i = 0; t_i < T; t_i++)
        {
            line = Console.ReadLine();
            int N = Convert.ToInt32(line);
            line = Console.ReadLine();
            int[] A = new int[N];
            A = line.Split().Select(str => int.Parse(str)).ToArray();

            int out_ = solve(N, A);
            Console.Out.WriteLine(out_);

        }
    }
static int solve(int N, int[] A)
    {
        // You must complete the logic for the function that is provided
        // before compiling or submitting to avoid an error.
        // Write your code here
         long sum = 0;
        int max = 0; 
        for (int i = 0; i < N; i++)
        {
            if (A[i] < 0)
                return -1;

            sum += A[i];

            if (A[i] > max)
                max = A[i];
        } 
        if (N == 1)
        {
            return A[0] == 0 ? 0 : -1;
        } 
        if (sum % (N - 1) != 0)
            return -1;

        long operations = sum / (N - 1); 
        if (operations < max)
            return -1;

        return (int)operations;

    }
}
