import java.util.*;

public class Main {

    public static int countSetBits(int n) {
        int count = 0;

        while (n > 0) {
            count += (n & 1);
            n = n >> 1;
        }

        return count;
    }

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int t = sc.nextInt();

        while (t-- > 0) {

            int n = sc.nextInt();
            int[] arr = new int[n];

            for (int i = 0; i < n; i++) {
                arr[i] = sc.nextInt();
            }

            ArrayList<Integer> even = new ArrayList<>();
            ArrayList<Integer> odd = new ArrayList<>();

            for (int i = 0; i < n; i++) {

                int bits = countSetBits(arr[i]);

                if (bits % 2 == 0) {
                    even.add(arr[i]);
                } else {
                    odd.add(arr[i]);
                }
            }

            Collections.sort(even);
            Collections.sort(odd);

            for (int x : even) {
                System.out.print(x + " ");
            }

            for (int x : odd) {
                System.out.print(x + " ");
            }

            System.out.println();
        }

        sc.close();
    }
}
