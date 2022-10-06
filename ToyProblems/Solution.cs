using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ToyProblems.Test")]
namespace ToyProblems;
internal static class Solution
{
    public static int Add(int x, int y)
    {
        return x + y;
    }
}
