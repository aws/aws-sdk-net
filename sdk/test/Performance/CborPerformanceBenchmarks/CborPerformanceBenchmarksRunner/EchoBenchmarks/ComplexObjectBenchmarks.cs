using Amazon.Echo.Model;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace CborPerformanceBenchmarksRunner.EchoBenchmarks;

public class ComplexObjectBenchmarks : AllTypesBenchmarks
{
    public override string TestCase { get; } = "Complex object";

    public override void GenerateRequest()
    {
        request = new EchoOperationRequest
        {
            ComplexStructMember = new ComplexStructure
            {
                BooleanMember = _random.Next(2) == 0,
                BlobMember = new MemoryStream(GenerateRandomBytes(128)),
                StringMember = GenerateRandomASCIIString(32),
                ComplexStructMember = new ComplexStructure
                {
                    IntegerMember = _random.Next(int.MinValue, int.MaxValue),
                    LongMember = GenerateRandomLong(),
                    StringMember = GenerateRandomASCIIString(32),
                    ComplexStructMember = new ComplexStructure
                    {
                        FloatMember = GenerateRandomFloat(),
                        DoubleMember = GenerateRandomDouble(),
                        StringMember = GenerateRandomASCIIString(32),
                        ComplexStructMember = new ComplexStructure
                        {
                            ListOfStringsMember = Enumerable.Range(0, 8)
                                            .Select(_ => GenerateRandomASCIIString(32))
                                            .ToList(),
                            MapOfStringToStringMember = Enumerable.Range(0, 8)
                                                  .ToDictionary(
                                                      _ => GenerateRandomASCIIString(32),
                                                      _ => GenerateRandomASCIIString(64)
                                                  ),
                        }

                    }

                }
            }

        };
    }
}