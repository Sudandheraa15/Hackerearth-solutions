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

        for (int t_i = 0; t_i < T; t_i++)
        {
            line = Console.ReadLine();
            int N = Convert.ToInt32(line);

            line = Console.ReadLine();
            int[] A = line.Split().Select(str => int.Parse(str)).ToArray();

            long out_ = solve(N, A);
            Console.Out.WriteLine(out_);
        }
    }

    static long solve(int N, int[] A)
    {
        const long MOD = 1000000007;
 
        long[] dpSum = new long[2]; 
        dpSum[0] = 1;

        int prefixXor = 0;
        long answer = 0;

        for (int i = 0; i < N; i++)
        {
            prefixXor ^= A[i]; 
            int parity = CountSetBitsParity(prefixXor); 
            long dp = dpSum[1 - parity]; 
            dpSum[parity] = (dpSum[parity] + dp) % MOD;

            answer = dp;
        }

        return answer;
    }

    static int CountSetBitsParity(int x)
    {
        int parity = 0;

        while (x != 0)
        {
            parity ^= 1;
            x &= (x - 1);
        }

        return parity;
    }
}
