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
using Amazon.QueryDataPlane;
using Amazon.QueryDataPlane.Model;
using Amazon.Runtime;
using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// E2E benchmarks for AWS Query protocol (CloudWatch-like operations).
/// Full SDK client pipeline with mocked HTTP.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(E2EBenchmarkConfig))]
public class AwsQueryE2EBenchmarks
{
    private AmazonQueryDataPlaneClient _healthcheckClient = null!;
    private AmazonQueryDataPlaneClient _putClientS = null!;
    private AmazonQueryDataPlaneClient _putClientM = null!;
    private AmazonQueryDataPlaneClient _getClientS = null!;
    private AmazonQueryDataPlaneClient _getClientM = null!;

    private HealthcheckRequest _healthcheckRequest = null!;
    private PutMetricDataRequest _putMetricDataS = null!;
    private PutMetricDataRequest _putMetricDataM = null!;
    private GetMetricDataRequest _getMetricDataRequestS = null!;
    private GetMetricDataRequest _getMetricDataRequestM = null!;

    private static readonly byte[] HealthcheckResponse = Encoding.UTF8.GetBytes(
        "<HealthcheckResponse xmlns=\"https://query.amazonaws.com/doc/2024-01-01/\"><HealthcheckResult/><ResponseMetadata><RequestId>test-id</RequestId></ResponseMetadata></HealthcheckResponse>");
    private static readonly byte[] PutMetricResponse = Encoding.UTF8.GetBytes(
        "<PutMetricDataResponse xmlns=\"https://query.amazonaws.com/doc/2024-01-01/\"><PutMetricDataResult/><ResponseMetadata><RequestId>test-id</RequestId></ResponseMetadata></PutMetricDataResponse>");
    private static readonly byte[] GetMetricResponseS = Encoding.UTF8.GetBytes(BuildGetMetricXml(5));
    private static readonly byte[] GetMetricResponseM = Encoding.UTF8.GetBytes(BuildGetMetricXml(50));

    private static string BuildGetMetricXml(int datapoints)
    {
        var sb = new StringBuilder("<GetMetricDataResponse xmlns=\"https://query.amazonaws.com/doc/2024-01-01/\"><GetMetricDataResult><MetricDataResults><member><Id>m1</Id><Label>CPUUtilization</Label><Values>");
        for (int i = 0; i < datapoints; i++) sb.Append($"<member>{42.0 + i * 0.1}</member>");
        sb.Append("</Values><Timestamps>");
        for (int i = 0; i < datapoints; i++)
        {
            var ts = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMinutes(i * 5);
            sb.Append($"<member>{ts:yyyy-MM-ddTHH:mm:ssZ}</member>");
        }
        sb.Append("</Timestamps></member></MetricDataResults></GetMetricDataResult><ResponseMetadata><RequestId>test-id</RequestId></ResponseMetadata></GetMetricDataResponse>");
        return sb.ToString();
    }

    private AmazonQueryDataPlaneClient CreateClient(byte[] responseBody)
    {
        var handler = new MockHttpHandler(responseBody, "text/xml");
        var config = new AmazonQueryDataPlaneConfig
        {
            RegionEndpoint = Amazon.RegionEndpoint.USWest2,
            HttpClientFactory = new MockHttpClientFactory(handler)
        };
        return new AmazonQueryDataPlaneClient(new BasicAWSCredentials("AKID", "SECRET"), config);
    }

    private static List<MetricDatum> CreateMetricData(int count)
    {
        var data = new List<MetricDatum>();
        for (int i = 0; i < count; i++)
            data.Add(new MetricDatum { MetricName = $"Metric{i}", Value = 42.0 + i, Unit = "Count" });
        return data;
    }

    private static List<MetricDataQuery> CreateQueries(int count)
    {
        var queries = new List<MetricDataQuery>();
        for (int i = 0; i < count; i++)
            queries.Add(new MetricDataQuery { Id = $"m{i}", MetricStat = new MetricStat { Metric = new Amazon.QueryDataPlane.Model.Metric { MetricName = $"CPU{i}", Namespace = "AWS/EC2" }, Period = 300, Stat = "Average" } });
        return queries;
    }

    [GlobalSetup]
    public void Setup()
    {
        _healthcheckClient = CreateClient(HealthcheckResponse);
        _putClientS = CreateClient(PutMetricResponse);
        _putClientM = CreateClient(PutMetricResponse);
        _getClientS = CreateClient(GetMetricResponseS);
        _getClientM = CreateClient(GetMetricResponseM);

        _healthcheckRequest = new HealthcheckRequest();
        _putMetricDataS = new PutMetricDataRequest { Namespace = "Test", MetricData = CreateMetricData(3) };
        _putMetricDataM = new PutMetricDataRequest { Namespace = "Test", MetricData = CreateMetricData(20) };
        _getMetricDataRequestS = new GetMetricDataRequest { StartTime = DateTime.UtcNow.AddHours(-1), EndTime = DateTime.UtcNow, MetricDataQueries = CreateQueries(1) };
        _getMetricDataRequestM = new GetMetricDataRequest { StartTime = DateTime.UtcNow.AddHours(-1), EndTime = DateTime.UtcNow, MetricDataQueries = CreateQueries(5) };
    }

    [Benchmark] public async Task awsQuery_e2e_Healthcheck() => await _healthcheckClient.HealthcheckAsync(_healthcheckRequest);
    [Benchmark] public async Task awsQuery_e2e_PutMetricData_S() => await _putClientS.PutMetricDataAsync(_putMetricDataS);
    [Benchmark] public async Task awsQuery_e2e_PutMetricData_M() => await _putClientM.PutMetricDataAsync(_putMetricDataM);
    [Benchmark] public async Task awsQuery_e2e_GetMetricData_S() => await _getClientS.GetMetricDataAsync(_getMetricDataRequestS);
    [Benchmark] public async Task awsQuery_e2e_GetMetricData_M() => await _getClientM.GetMetricDataAsync(_getMetricDataRequestM);

    [GlobalCleanup]
    public void Cleanup()
    {
        _healthcheckClient?.Dispose();
        _putClientS?.Dispose();
        _putClientM?.Dispose();
        _getClientS?.Dispose();
        _getClientM?.Dispose();
    }
}
