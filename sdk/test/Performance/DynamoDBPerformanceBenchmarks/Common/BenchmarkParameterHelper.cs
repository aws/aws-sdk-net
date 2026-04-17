namespace AWSSDK.Benchmarks.MockedDynamoDB;

internal static class BenchmarkParameterHelper
{
    public static IEnumerable<T> GetValues<T>(T? overrideValue, params T[] defaults)
        where T : struct
    {
        if (overrideValue.HasValue)
        {
            yield return overrideValue.Value;
            yield break;
        }

        foreach (var value in defaults)
        {
            yield return value;
        }
    }

    public static IEnumerable<T> GetValues<T>(T? overrideValue)
        where T : struct, Enum
    {
        if (overrideValue.HasValue)
        {
            yield return overrideValue.Value;
            yield break;
        }

        foreach (var value in Enum.GetValues<T>())
        {
            yield return value;
        }
    }
}
