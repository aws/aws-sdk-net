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
using Amazon.RestXmlDataPlane;
using Amazon.RestXmlDataPlane.Model;
using Amazon.Runtime;
using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// E2E benchmarks for REST XML protocol (S3-like operations).
/// Full SDK client pipeline with mocked HTTP.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(E2EBenchmarkConfig))]
public class RestXmlE2EBenchmarks
{
    private AmazonRestXmlDataPlaneClient _copyClient = null!;
    private AmazonRestXmlDataPlaneClient _putClient = null!;
    private AmazonRestXmlDataPlaneClient _getClientS = null!;
    private AmazonRestXmlDataPlaneClient _getClientM = null!;
    private AmazonRestXmlDataPlaneClient _getClientL = null!;
    private AmazonRestXmlDataPlaneClient _putMetricClientS = null!;
    private AmazonRestXmlDataPlaneClient _putMetricClientM = null!;
    private AmazonRestXmlDataPlaneClient _getMetricClientS = null!;
    private AmazonRestXmlDataPlaneClient _getMetricClientM = null!;

    private CopyObjectRequest _copyObjectRequest = null!;
    private PutObjectRequest _putObjectS = null!;
    private PutObjectRequest _putObjectM = null!;
    private PutObjectRequest _putObjectL = null!;
    private GetObjectRequest _getObjectRequest = null!;
    private PutMetricDataRequest _putMetricDataS = null!;
    private PutMetricDataRequest _putMetricDataM = null!;
    private GetMetricDataRequest _getMetricDataS = null!;
    private GetMetricDataRequest _getMetricDataM = null!;

    private static readonly byte[] CopyResponse = Encoding.UTF8.GetBytes(
        "<?xml version=\"1.0\" encoding=\"UTF-8\"?><CopyObjectResult><ETag>\"d41d8cd98f00b204e9800998ecf8427e\"</ETag><LastModified>2024-01-01T00:00:00Z</LastModified></CopyObjectResult>");
    private static readonly byte[] EmptyXml = Encoding.UTF8.GetBytes("<?xml version=\"1.0\" encoding=\"UTF-8\"?><Response/>");
    private static readonly byte[] GetObjectS = new byte[1024];
    private static readonly byte[] GetObjectM = new byte[100 * 1024];
    private static readonly byte[] GetObjectL = new byte[1024 * 1024];
    private static readonly byte[] GetMetricResponseS = Encoding.UTF8.GetBytes(BuildGetMetricXml(5));
    private static readonly byte[] GetMetricResponseM = Encoding.UTF8.GetBytes(BuildGetMetricXml(50));

    private static string BuildGetMetricXml(int datapoints)
    {
        var sb = new StringBuilder("<?xml version=\"1.0\" encoding=\"UTF-8\"?><GetMetricDataResponse><GetMetricDataResult><MetricDataResults><member><Id>m1</Id><Label>CPUUtilization</Label><Values>");
        for (int i = 0; i < datapoints; i++) sb.Append($"<member>{42.0 + i * 0.1}</member>");
        sb.Append("</Values><Timestamps>");
        for (int i = 0; i < datapoints; i++)
        {
            var ts = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMinutes(i * 5);
            sb.Append($"<member>{ts:yyyy-MM-ddTHH:mm:ssZ}</member>");
        }
        sb.Append("</Timestamps></member></MetricDataResults></GetMetricDataResult></GetMetricDataResponse>");
        return sb.ToString();
    }

    private AmazonRestXmlDataPlaneClient CreateClient(byte[] responseBody, string contentType = "application/xml")
    {
        var handler = new MockHttpHandler(responseBody, contentType);
        var config = new AmazonRestXmlDataPlaneConfig
        {
            RegionEndpoint = Amazon.RegionEndpoint.USWest2,
            HttpClientFactory = new MockHttpClientFactory(handler)
        };
        return new AmazonRestXmlDataPlaneClient(new BasicAWSCredentials("AKID", "SECRET"), config);
    }

    [GlobalSetup]
    public void Setup()
    {
        Random.Shared.NextBytes(GetObjectS);
        Random.Shared.NextBytes(GetObjectM);
        Random.Shared.NextBytes(GetObjectL);

        _copyClient = CreateClient(CopyResponse);
        _putClient = CreateClient(EmptyXml);
        _getClientS = CreateClient(GetObjectS, "application/octet-stream");
        _getClientM = CreateClient(GetObjectM, "application/octet-stream");
        _getClientL = CreateClient(GetObjectL, "application/octet-stream");
        _putMetricClientS = CreateClient(EmptyXml);
        _putMetricClientM = CreateClient(EmptyXml);
        _getMetricClientS = CreateClient(GetMetricResponseS);
        _getMetricClientM = CreateClient(GetMetricResponseM);

        _copyObjectRequest = new CopyObjectRequest { Bucket = "b", Key = "k", CopySource = "src/k" };
        _putObjectS = new PutObjectRequest { Bucket = "b", Key = "k", ContentType = "application/octet-stream", Body = new MemoryStream(new byte[1024]) };
        _putObjectM = new PutObjectRequest { Bucket = "b", Key = "k", ContentType = "application/octet-stream", Body = new MemoryStream(new byte[100 * 1024]) };
        _putObjectL = new PutObjectRequest { Bucket = "b", Key = "k", ContentType = "application/octet-stream", Body = new MemoryStream(new byte[1024 * 1024]) };
        _getObjectRequest = new GetObjectRequest { Bucket = "b", Key = "k" };
        _putMetricDataS = new PutMetricDataRequest { Namespace = "Test", MetricData = CreateMetricData(3) };
        _putMetricDataM = new PutMetricDataRequest { Namespace = "Test", MetricData = CreateMetricData(20) };
        _getMetricDataS = new GetMetricDataRequest { StartTime = DateTime.UtcNow.AddHours(-1), EndTime = DateTime.UtcNow, MetricDataQueries = CreateQueries(1) };
        _getMetricDataM = new GetMetricDataRequest { StartTime = DateTime.UtcNow.AddHours(-1), EndTime = DateTime.UtcNow, MetricDataQueries = CreateQueries(5) };
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
            queries.Add(new MetricDataQuery { Id = $"m{i}", MetricStat = new MetricStat { Metric = new Amazon.RestXmlDataPlane.Model.Metric { MetricName = $"CPU{i}", Namespace = "AWS/EC2" }, Period = 300, Stat = "Average" } });
        return queries;
    }

    [Benchmark] public async Task restXml_e2e_CopyObject() => await _copyClient.CopyObjectAsync(_copyObjectRequest);
    [Benchmark] public async Task restXml_e2e_PutObject_S() { _putObjectS.Body.Position = 0; await _putClient.PutObjectAsync(_putObjectS); }
    [Benchmark] public async Task restXml_e2e_PutObject_M() { _putObjectM.Body.Position = 0; await _putClient.PutObjectAsync(_putObjectM); }
    [Benchmark] public async Task restXml_e2e_PutObject_L() { _putObjectL.Body.Position = 0; await _putClient.PutObjectAsync(_putObjectL); }
    [Benchmark] public async Task restXml_e2e_GetObject_S() => await _getClientS.GetObjectAsync(_getObjectRequest);
    [Benchmark] public async Task restXml_e2e_GetObject_M() => await _getClientM.GetObjectAsync(_getObjectRequest);
    [Benchmark] public async Task restXml_e2e_GetObject_L() => await _getClientL.GetObjectAsync(_getObjectRequest);
    [Benchmark] public async Task restXml_e2e_PutMetricData_S() => await _putMetricClientS.PutMetricDataAsync(_putMetricDataS);
    [Benchmark] public async Task restXml_e2e_PutMetricData_M() => await _putMetricClientM.PutMetricDataAsync(_putMetricDataM);
    [Benchmark] public async Task restXml_e2e_GetMetricData_S() => await _getMetricClientS.GetMetricDataAsync(_getMetricDataS);
    [Benchmark] public async Task restXml_e2e_GetMetricData_M() => await _getMetricClientM.GetMetricDataAsync(_getMetricDataM);

    [GlobalCleanup]
    public void Cleanup()
    {
        _copyClient?.Dispose();
        _putClient?.Dispose();
        _getClientS?.Dispose();
        _getClientM?.Dispose();
        _getClientL?.Dispose();
        _putMetricClientS?.Dispose();
        _putMetricClientM?.Dispose();
        _getMetricClientS?.Dispose();
        _getMetricClientM?.Dispose();
    }
}
