using Amazon;
using Amazon.Echo;
using Amazon.Echo.Model;
using Amazon.Echo.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Util;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;
using System.Text;

namespace CborPerformanceBenchmarksRunner.EchoBenchmarks;

public class AllTypesBenchmarks : BaseBenchmarks
{
    protected Random _random = new Random();

    [Params(0)]
    public override int DimensionValue { get; set; }
    public override string Service { get; } = "EchoService";
    public override string TestCase { get; } = "All types";

    protected IAmazonEcho _client;
    public override void CreateServiceClient()
    {
        _client = new AmazonEchoClient(new AmazonEchoConfig
        {
            DisableRequestCompression = true,
            MaxErrorRetry = 0,
            RegionEndpoint = RegionEndpoint.USWest2,
        });
    }

    protected EchoOperationRequest request;

    [Benchmark(Description = "Serialization time (ms)")]
    public override byte[] Marshall()
    {
        var iRequest = EchoOperationRequestMarshaller.Instance.Marshall(request);
        MarshalledRequest = iRequest;

        return iRequest.Content;
    }

    [Benchmark(Description = "Total request time (ms)")]
    public async override Task<AmazonWebServiceResponse> TotalRequest()
    {
        var response = await _client.EchoOperationAsync(request);
        ResponseSizeBytes = Math.Max(ResponseSizeBytes, response.ContentLength);

        return response;
    }

    public override void GenerateRequest()
    {
        request = new EchoOperationRequest
        {
            BooleanMember = _random.Next(2) == 0,
            StringMember = GenerateRandomASCIIString(32),
            IntegerMember = _random.Next(int.MinValue, int.MaxValue),
            LongMember = GenerateRandomLong(),
            FloatMember = GenerateRandomFloat(),
            DoubleMember = GenerateRandomDouble(),
            TimestampMember = DateTimeOffset.FromUnixTimeSeconds(Utils.RunStartTimestamp).UtcDateTime,
            BlobMember = new MemoryStream(GenerateRandomBytes(128)),
            ListOfStringsMember = Enumerable.Range(0, 8)
                                            .Select(_ => GenerateRandomASCIIString(32))
                                            .ToList(),
            MapOfStringToStringMember = Enumerable.Range(0, 8)
                                                  .ToDictionary(
                                                      _ => GenerateRandomASCIIString(32),
                                                      _ => GenerateRandomASCIIString(64)
                                                  ),
            ComplexStructMember = new ComplexStructure
            {
                StringMember = GenerateRandomASCIIString(32),
                ComplexStructMember = new ComplexStructure
                {
                    StringMember = GenerateRandomASCIIString(32)
                }
            }

        };
    }
    protected long GenerateRandomLong()
    {
        var buffer = new byte[8];
        _random.NextBytes(buffer);
        return BitConverter.ToInt64(buffer, 0);
    }

    protected float GenerateRandomFloat()
    {
        var bytes = new byte[4];
        _random.NextBytes(bytes);
        return BitConverter.ToSingle(bytes, 0);
    }

    protected double GenerateRandomDouble()
    {
        var bytes = new byte[8];
        _random.NextBytes(bytes);
        return BitConverter.ToDouble(bytes, 0);
    }

    protected byte[] GenerateRandomBytes(int length)
    {
        var buffer = new byte[length];
        _random.NextBytes(buffer);
        return buffer;
    }

    protected string GenerateRandomASCIIString(int length = 32)
    {
        var sb = new StringBuilder(length);

        for (int i = 0; i < length; i++)
        {
            // ASCII visible characters from 33 to 126
            char randomChar = (char)_random.Next(33, 127);
            sb.Append(randomChar);
        }

        return sb.ToString();
    }


    [Benchmark(Description = "Deserialization time (ms)")]
    public override AmazonWebServiceResponse Unmarshall()
    {
        var response = EchoOperationResponseUnmarshaller.Instance.Unmarshall(UnmarshallerContext);
        return response;
    }
}