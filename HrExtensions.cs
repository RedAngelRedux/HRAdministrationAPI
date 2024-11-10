

namespace HRAdministrationAPI;

public static class HrExtensions
{
    public static int WordCount(this string str)
    {
        return str.Split(
            new char[] { ' ', '.', '?' },
            StringSplitOptions.RemoveEmptyEntries)
            .Length;
    }
}
