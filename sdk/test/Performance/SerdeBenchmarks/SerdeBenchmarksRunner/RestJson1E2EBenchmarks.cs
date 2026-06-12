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
using Amazon.RestJsonDataPlane;
using Amazon.RestJsonDataPlane.Model;
using Amazon.Runtime;
using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// E2E benchmarks for RestJson1 protocol exercising the full SDK client pipeline:
/// credentials → signing → marshalling → HTTP dispatch (mocked) → unmarshalling → response.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(E2EBenchmarkConfig))]
public class RestJson1E2EBenchmarks
{
    private AmazonRestJsonDataPlaneClient _copyClientBaseline = null!;
    private AmazonRestJsonDataPlaneClient _copyClientM = null!;
    private AmazonRestJsonDataPlaneClient _putClient = null!;
    private AmazonRestJsonDataPlaneClient _getClientS = null!;
    private AmazonRestJsonDataPlaneClient _getClientM = null!;
    private AmazonRestJsonDataPlaneClient _getClientL = null!;
    private AmazonRestJsonDataPlaneClient _putMetricClientS = null!;
    private AmazonRestJsonDataPlaneClient _putMetricClientM = null!;
    private AmazonRestJsonDataPlaneClient _putMetricClientL = null!;
    private AmazonRestJsonDataPlaneClient _getMetricClientS = null!;
    private AmazonRestJsonDataPlaneClient _getMetricClientM = null!;
    private AmazonRestJsonDataPlaneClient _getMetricClientL = null!;

    private CopyObjectRequest _copyObjectBaseline = null!;
    private CopyObjectRequest _copyObjectMedium = null!;
    private PutObjectRequest _putObjectS = null!;
    private PutObjectRequest _putObjectM = null!;
    private PutObjectRequest _putObjectL = null!;
    private GetObjectRequest _getObjectRequest = null!;
    private PutMetricDataRequest _putMetricDataS = null!;
    private PutMetricDataRequest _putMetricDataM = null!;
    private PutMetricDataRequest _putMetricDataL = null!;
    private GetMetricDataRequest _getMetricDataS = null!;
    private GetMetricDataRequest _getMetricDataM = null!;
    private GetMetricDataRequest _getMetricDataL = null!;

    private static readonly byte[] CopyOutputBaseline = Encoding.UTF8.GetBytes("{}");
    private static readonly byte[] CopyOutputM = Encoding.UTF8.GetBytes(
        "{\"ETag\":\"\\\"d41d8cd98f00b204e9800998ecf8427e\\\"\",\"LastModified\":1704067200," +
        "\"ChecksumCRC32\":\"abc123\",\"ServerSideEncryption\":\"aws:kms\",\"VersionId\":\"v1.0\"}");
    private static readonly byte[] GetObjectS = new byte[1024];
    private static readonly byte[] GetObjectM = new byte[100 * 1024];
    private static readonly byte[] GetObjectL = new byte[1024 * 1024];
    private static readonly byte[] EmptyJson = Encoding.UTF8.GetBytes("{}");
    private static readonly byte[] GetMetricResponseS = Encoding.UTF8.GetBytes(BuildGetMetricJson(5));
    private static readonly byte[] GetMetricResponseM = Encoding.UTF8.GetBytes(BuildGetMetricJson(50));
    private static readonly byte[] GetMetricResponseL = Encoding.UTF8.GetBytes(BuildGetMetricJson(500));

    private static string BuildGetMetricJson(int datapoints)
    {
        var sb = new StringBuilder("{\"MetricDataResults\":[{\"Id\":\"m1\",\"Label\":\"CPUUtilization\",\"Values\":[");
        for (int i = 0; i < datapoints; i++) { if (i > 0) sb.Append(','); sb.Append($"{42.0 + i * 0.1}"); }
        sb.Append("],\"Timestamps\":[");
        var baseTime = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero);
        for (int i = 0; i < datapoints; i++)
        {
            if (i > 0) sb.Append(',');
            sb.Append($"{baseTime.AddMinutes(i * 5).ToUnixTimeSeconds()}");
        }
        sb.Append("]}]}");
        return sb.ToString();
    }

    private AmazonRestJsonDataPlaneClient CreateClient(byte[] responseBody)
    {
        var handler = new MockHttpHandler(responseBody, "application/json");
        var config = new AmazonRestJsonDataPlaneConfig
        {
            RegionEndpoint = Amazon.RegionEndpoint.USWest2,
            HttpClientFactory = new MockHttpClientFactory(handler)
        };
        return new AmazonRestJsonDataPlaneClient(new BasicAWSCredentials("AKID", "SECRET"), config);
    }

    [GlobalSetup]
    public void Setup()
    {
        Random.Shared.NextBytes(GetObjectS);
        Random.Shared.NextBytes(GetObjectM);
        Random.Shared.NextBytes(GetObjectL);

        _copyClientBaseline = CreateClient(CopyOutputBaseline);
        _copyClientM = CreateClient(CopyOutputM);
        _putClient = CreateClient(Array.Empty<byte>());
        _getClientS = CreateClient(GetObjectS);
        _getClientM = CreateClient(GetObjectM);
        _getClientL = CreateClient(GetObjectL);
        _putMetricClientS = CreateClient(EmptyJson);
        _putMetricClientM = CreateClient(EmptyJson);
        _putMetricClientL = CreateClient(EmptyJson);
        _getMetricClientS = CreateClient(GetMetricResponseS);
        _getMetricClientM = CreateClient(GetMetricResponseM);
        _getMetricClientL = CreateClient(GetMetricResponseL);

        _copyObjectBaseline = new CopyObjectRequest { Bucket = "bucket", Key = "key", CopySource = "src/key" };
        _copyObjectMedium = new CopyObjectRequest
        {
            Bucket = "my-destination-bucket", Key = "destination/path/to/my-object.dat",
            CopySource = "my-source-bucket/source/path/to/original-object.dat",
            ACL = "bucket-owner-full-control", CacheControl = "max-age=86400",
            ContentType = "application/octet-stream", MetadataDirective = "REPLACE",
            ServerSideEncryption = "aws:kms", StorageClass = "STANDARD_IA",
            SSEKMSKeyId = "arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012"
        };
        _putObjectS = new PutObjectRequest { Bucket = "bucket", Key = "key", Body = new MemoryStream(new byte[1024]) };
        _putObjectM = new PutObjectRequest { Bucket = "bucket", Key = "key", Body = new MemoryStream(new byte[100 * 1024]) };
        _putObjectL = new PutObjectRequest { Bucket = "bucket", Key = "key", Body = new MemoryStream(new byte[1024 * 1024]) };
        _getObjectRequest = new GetObjectRequest { Bucket = "bucket", Key = "key" };
        _putMetricDataS = new PutMetricDataRequest { Namespace = "Test", MetricData = CreateMetricData(5) };
        _putMetricDataM = new PutMetricDataRequest { Namespace = "Test", MetricData = CreateMetricData(50) };
        _putMetricDataL = new PutMetricDataRequest { Namespace = "Test", MetricData = CreateMetricData(500) };
        _getMetricDataS = new GetMetricDataRequest { StartTime = DateTime.UtcNow.AddHours(-1), EndTime = DateTime.UtcNow, MetricDataQueries = CreateQueries(1) };
        _getMetricDataM = new GetMetricDataRequest { StartTime = DateTime.UtcNow.AddHours(-1), EndTime = DateTime.UtcNow, MetricDataQueries = CreateQueries(5) };
        _getMetricDataL = new GetMetricDataRequest { StartTime = DateTime.UtcNow.AddHours(-1), EndTime = DateTime.UtcNow, MetricDataQueries = CreateQueries(25) };
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
            queries.Add(new MetricDataQuery { Id = $"m{i}", MetricStat = new MetricStat { Metric = new Amazon.RestJsonDataPlane.Model.Metric { MetricName = $"CPU{i}", Namespace = "AWS/EC2" }, Period = 300, Stat = "Average" } });
        return queries;
    }

    [Benchmark] public async Task restJson1_e2e_CopyObject_Baseline() => await _copyClientBaseline.CopyObjectAsync(_copyObjectBaseline);
    [Benchmark] public async Task restJson1_e2e_CopyObject_M() => await _copyClientM.CopyObjectAsync(_copyObjectMedium);
    [Benchmark] public async Task restJson1_e2e_PutObject_S() { _putObjectS.Body.Position = 0; await _putClient.PutObjectAsync(_putObjectS); }
    [Benchmark] public async Task restJson1_e2e_PutObject_M() { _putObjectM.Body.Position = 0; await _putClient.PutObjectAsync(_putObjectM); }
    [Benchmark] public async Task restJson1_e2e_PutObject_L() { _putObjectL.Body.Position = 0; await _putClient.PutObjectAsync(_putObjectL); }
    [Benchmark] public async Task restJson1_e2e_GetObject_S() => await _getClientS.GetObjectAsync(_getObjectRequest);
    [Benchmark] public async Task restJson1_e2e_GetObject_M() => await _getClientM.GetObjectAsync(_getObjectRequest);
    [Benchmark] public async Task restJson1_e2e_GetObject_L() => await _getClientL.GetObjectAsync(_getObjectRequest);
    [Benchmark] public async Task restJson1_e2e_PutMetricData_S() => await _putMetricClientS.PutMetricDataAsync(_putMetricDataS);
    [Benchmark] public async Task restJson1_e2e_PutMetricData_M() => await _putMetricClientM.PutMetricDataAsync(_putMetricDataM);
    [Benchmark] public async Task restJson1_e2e_PutMetricData_L() => await _putMetricClientL.PutMetricDataAsync(_putMetricDataL);
    [Benchmark] public async Task restJson1_e2e_GetMetricData_S() => await _getMetricClientS.GetMetricDataAsync(_getMetricDataS);
    [Benchmark] public async Task restJson1_e2e_GetMetricData_M() => await _getMetricClientM.GetMetricDataAsync(_getMetricDataM);
    [Benchmark] public async Task restJson1_e2e_GetMetricData_L() => await _getMetricClientL.GetMetricDataAsync(_getMetricDataL);

    [GlobalCleanup]
    public void Cleanup()
    {
        _copyClientBaseline?.Dispose();
        _copyClientM?.Dispose();
        _putClient?.Dispose();
        _getClientS?.Dispose();
        _getClientM?.Dispose();
        _getClientL?.Dispose();
        _putMetricClientS?.Dispose();
        _putMetricClientM?.Dispose();
        _putMetricClientL?.Dispose();
        _getMetricClientS?.Dispose();
        _getMetricClientM?.Dispose();
        _getMetricClientL?.Dispose();
    }
}
