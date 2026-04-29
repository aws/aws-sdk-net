/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System.Text;
using Amazon.QueryDataPlane.Model;
using Amazon.QueryDataPlane.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// BenchmarkDotNet benchmarks for AWS Query protocol serialization/deserialization.
/// 10 test cases: PutMetricData Baseline/S/M/L, GetMetricDataRequest S/M/L, GetMetricDataResponse S/M/L.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(SerdeBenchmarkConfig))]
public class AwsQueryBenchmarks
{
    private PutMetricDataRequest _putMetricBaseline = null!;
    private PutMetricDataRequest _putMetricS = null!;
    private PutMetricDataRequest _putMetricM = null!;
    private PutMetricDataRequest _putMetricL = null!;
    private GetMetricDataRequest _getMetricReqS = null!;
    private GetMetricDataRequest _getMetricReqM = null!;
    private GetMetricDataRequest _getMetricReqL = null!;
    private byte[] _getMetricRespSBytes = null!;
    private byte[] _getMetricRespMBytes = null!;
    private byte[] _getMetricRespLBytes = null!;

    [GlobalSetup]
    public void Setup()
    {
        _putMetricBaseline = new PutMetricDataRequest { Namespace = "AWS/Benchmark" };
        _putMetricS = new PutMetricDataRequest { Namespace = "AWS/Benchmark", MetricData = CreateMetricDatumList(1) };
        _putMetricM = new PutMetricDataRequest { Namespace = "AWS/Benchmark", MetricData = CreateMetricDatumList(10) };
        _putMetricL = new PutMetricDataRequest { Namespace = "AWS/Benchmark", MetricData = CreateMetricDatumList(100) };

        _getMetricReqS = CreateGetMetricDataRequest(1);
        _getMetricReqM = CreateGetMetricDataRequest(10);
        _getMetricReqL = CreateGetMetricDataRequest(100);

        _getMetricRespSBytes = Encoding.UTF8.GetBytes(BuildGetMetricDataResponseXml(1, 10));
        _getMetricRespMBytes = Encoding.UTF8.GetBytes(BuildGetMetricDataResponseXml(10, 100));
        _getMetricRespLBytes = Encoding.UTF8.GetBytes(BuildGetMetricDataResponseXml(100, 1000));
    }

    // --- PutMetricData Request ---
    [Benchmark] public void awsQuery_PutMetricDataRequest_Baseline() => PutMetricDataRequestMarshaller.Instance.Marshall(_putMetricBaseline);
    [Benchmark] public void awsQuery_PutMetricDataRequest_S() => PutMetricDataRequestMarshaller.Instance.Marshall(_putMetricS);
    [Benchmark] public void awsQuery_PutMetricDataRequest_M() => PutMetricDataRequestMarshaller.Instance.Marshall(_putMetricM);
    [Benchmark] public void awsQuery_PutMetricDataRequest_L() => PutMetricDataRequestMarshaller.Instance.Marshall(_putMetricL);

    // --- GetMetricData Request ---
    [Benchmark] public void awsQuery_GetMetricDataRequest_S() => GetMetricDataRequestMarshaller.Instance.Marshall(_getMetricReqS);
    [Benchmark] public void awsQuery_GetMetricDataRequest_M() => GetMetricDataRequestMarshaller.Instance.Marshall(_getMetricReqM);
    [Benchmark] public void awsQuery_GetMetricDataRequest_L() => GetMetricDataRequestMarshaller.Instance.Marshall(_getMetricReqL);

    // --- GetMetricData Response ---
    [Benchmark] public void awsQuery_GetMetricDataResponse_S() => UnmarshallXml(_getMetricRespSBytes);
    [Benchmark] public void awsQuery_GetMetricDataResponse_M() => UnmarshallXml(_getMetricRespMBytes);
    [Benchmark] public void awsQuery_GetMetricDataResponse_L() => UnmarshallXml(_getMetricRespLBytes);

    private void UnmarshallXml(byte[] bytes)
    {
        using var stream = new MemoryStream(bytes);
        var wr = new WebResponseData { ContentType = "text/xml", Headers = { { "x-amzn-RequestId", "test-id" }, { "Content-Length", bytes.Length.ToString() }, { "Content-Type", "text/xml" } } };
        var ctx = new XmlUnmarshallerContext(stream, false, wr);
        GetMetricDataResponseUnmarshaller.Instance.Unmarshall(ctx);
    }

    private static GetMetricDataRequest CreateGetMetricDataRequest(int queryCount)
    {
        return new GetMetricDataRequest
        {
            StartTime = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            EndTime = new DateTime(2024, 1, 2, 0, 0, 0, DateTimeKind.Utc),
            MetricDataQueries = CreateMetricDataQueryList(queryCount)
        };
    }

    private static List<MetricDatum> CreateMetricDatumList(int count)
    {
        var list = new List<MetricDatum>();
        for (int i = 0; i < count; i++)
        {
            list.Add(new MetricDatum
            {
                MetricName = $"BenchmarkMetric_{i}", Value = 42.0 + i, Unit = "Count",
                Timestamp = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMinutes(i),
                Dimensions = new List<Dimension> { new() { Name = "Environment", Value = "Production" }, new() { Name = "Service", Value = "BenchmarkService" } },
                StatisticValues = new StatisticSet { Maximum = 100.0 + i, Minimum = 1.0 + i, SampleCount = 10.0, Sum = 500.0 + i * 10 }
            });
        }
        return list;
    }

    private static List<MetricDataQuery> CreateMetricDataQueryList(int count)
    {
        var list = new List<MetricDataQuery>();
        for (int i = 0; i < count; i++)
        {
            list.Add(new MetricDataQuery
            {
                Id = $"q{i}", ReturnData = true,
                MetricStat = new MetricStat
                {
                    Period = 300, Stat = "Average",
                    Metric = new Metric
                    {
                        MetricName = $"BenchmarkMetric_{i}", Namespace = "AWS/Benchmark",
                        Dimensions = new List<Dimension> { new() { Name = "Environment", Value = "Production" }, new() { Name = "Service", Value = "BenchmarkService" } }
                    }
                }
            });
        }
        return list;
    }

    private static string BuildGetMetricDataResponseXml(int resultCount, int valuesPerResult)
    {
        var sb = new StringBuilder();
        sb.Append("<GetMetricDataResponse xmlns=\"https://awsquerydataplane.amazonaws.com\">");
        sb.Append("<GetMetricDataResult><MetricDataResults>");
        for (int r = 0; r < resultCount; r++)
        {
            sb.Append($"<member><Id>q{r}</Id><Label>BenchmarkMetric_{r}</Label><StatusCode>Complete</StatusCode><Timestamps>");
            for (int v = 0; v < valuesPerResult; v++) sb.Append($"<member>2024-01-01T{v / 60:D2}:{v % 60:D2}:00Z</member>");
            sb.Append("</Timestamps><Values>");
            for (int v = 0; v < valuesPerResult; v++) sb.Append($"<member>{42.0 + v}</member>");
            sb.Append("</Values></member>");
        }
        sb.Append("</MetricDataResults></GetMetricDataResult></GetMetricDataResponse>");
        return sb.ToString();
    }
}
