
namespace HRAdministrationAPI;

public static class HRDelegates
{
    public delegate double hrIntDouble(int i, double j);

    public static double MultiplyNumbers(int m, double n)
    {
        return m * n;
    }
}
