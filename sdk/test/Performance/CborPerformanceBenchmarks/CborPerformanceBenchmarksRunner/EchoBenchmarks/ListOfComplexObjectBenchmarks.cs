using Amazon.Echo.Model;

namespace CborPerformanceBenchmarksRunner.EchoBenchmarks;

public class ListOfComplexObjectBenchmarks : AllTypesBenchmarks
{
    public override string TestCase { get; } = "List of complex objects";
    public override void GenerateRequest()
    {
        request = new EchoOperationRequest
        {
            ListOfComplexObjectMember = Enumerable.Range(0, 64).Select(_ => new ComplexStructure
            {
                BooleanMember = _random.Next(2) == 0,
                StringMember = GenerateRandomASCIIString(32),
                LongMember = GenerateRandomLong(),
                DoubleMember = GenerateRandomDouble(),
                TimestampMember = DateTimeOffset.FromUnixTimeSeconds(Utils.RunStartTimestamp).UtcDateTime,
                ListOfStringsMember = Enumerable.Range(0, 8)
                                            .Select(_ => GenerateRandomASCIIString(32))
                                            .ToList(),
            }).ToList()
        };
    }
}