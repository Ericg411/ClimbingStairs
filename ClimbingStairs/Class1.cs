namespace ClimbingStairs;
public class Class1
{
    public int ClimbStairs(int n)
    {
        if (n <= 3)
        {
            return n;
        }

        int[] numArray = new int[n + 1];

        numArray[1] = 1;
        numArray[2] = 2;

        for (int i = 3; i <= n; i++)
        {
            numArray[i] = numArray[i - 1] + numArray[i - 2];
        }

        return numArray[n];
    }
}
