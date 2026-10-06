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
using Fixtures = AWSSDK.Benchmarks.Serde.ModelFixtures.RestJson1;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// E2E benchmarks for RestJson1 protocol exercising the full SDK client pipeline:
/// credentials → signing → marshalling → HTTP dispatch (mocked) → unmarshalling → response.
/// Payloads come from the shared benchmark models. The models define CloudWatch operations only
/// for awsQuery, so the PutMetricData/GetMetricData cases use those requests re-targeted to
/// RestJson1 and those responses re-encoded as JSON.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(E2EBenchmarkConfig))]
public class RestJson1E2EBenchmarks
{
    internal AmazonRestJsonDataPlaneClient _copyClientBaseline = null!;
    internal AmazonRestJsonDataPlaneClient _copyClientM = null!;
    internal AmazonRestJsonDataPlaneClient _putClient = null!;
    internal AmazonRestJsonDataPlaneClient _getClientS = null!;
    internal AmazonRestJsonDataPlaneClient _getClientM = null!;
    internal AmazonRestJsonDataPlaneClient _getClientL = null!;
    internal AmazonRestJsonDataPlaneClient _putMetricClientS = null!;
    internal AmazonRestJsonDataPlaneClient _putMetricClientM = null!;
    internal AmazonRestJsonDataPlaneClient _putMetricClientL = null!;
    internal AmazonRestJsonDataPlaneClient _getMetricClientS = null!;
    internal AmazonRestJsonDataPlaneClient _getMetricClientM = null!;
    internal AmazonRestJsonDataPlaneClient _getMetricClientL = null!;

    internal CopyObjectRequest _copyObjectBaseline = null!;
    internal CopyObjectRequest _copyObjectMedium = null!;
    internal PutObjectRequest _putObjectS = null!;
    internal PutObjectRequest _putObjectM = null!;
    internal PutObjectRequest _putObjectL = null!;
    internal GetObjectRequest _getObjectRequest = null!;
    internal PutMetricDataRequest _putMetricDataS = null!;
    internal PutMetricDataRequest _putMetricDataM = null!;
    internal PutMetricDataRequest _putMetricDataL = null!;
    internal GetMetricDataRequest _getMetricDataS = null!;
    internal GetMetricDataRequest _getMetricDataM = null!;
    internal GetMetricDataRequest _getMetricDataL = null!;

    private static readonly byte[] EmptyJson = Encoding.UTF8.GetBytes("{}");

    internal AmazonRestJsonDataPlaneClient CreateClient(byte[] responseBody, IReadOnlyDictionary<string, string>? headers = null, string contentType = "application/json")
    {
        var handler = new MockHttpHandler(responseBody, contentType, responseHeaders: headers?.ToDictionary(kv => kv.Key, kv => kv.Value));
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
        _copyClientBaseline = CreateClient(Fixtures.CopyObjectOutput_Baseline, Fixtures.CopyObjectOutput_Baseline_Headers);
        _copyClientM = CreateClient(Fixtures.CopyObjectOutput_M, Fixtures.CopyObjectOutput_M_Headers);
        _putClient = CreateClient(Array.Empty<byte>());
        _getClientS = CreateClient(Fixtures.GetObject_S, Fixtures.GetObject_S_Headers, "application/octet-stream");
        _getClientM = CreateClient(Fixtures.GetObject_M, Fixtures.GetObject_M_Headers, "application/octet-stream");
        _getClientL = CreateClient(Fixtures.GetObject_L, Fixtures.GetObject_L_Headers, "application/octet-stream");
        _putMetricClientS = CreateClient(EmptyJson);
        _putMetricClientM = CreateClient(EmptyJson);
        _putMetricClientL = CreateClient(EmptyJson);
        _getMetricClientS = CreateClient(Fixtures.GetMetricDataResponse_S);
        _getMetricClientM = CreateClient(Fixtures.GetMetricDataResponse_M);
        _getMetricClientL = CreateClient(Fixtures.GetMetricDataResponse_L);

        _copyObjectBaseline = Fixtures.CopyObjectRequest_Baseline();
        _copyObjectMedium = Fixtures.CopyObjectRequest_M();
        _putObjectS = Fixtures.PutObject_S();
        _putObjectM = Fixtures.PutObject_M();
        _putObjectL = Fixtures.PutObject_L();
        _getObjectRequest = new GetObjectRequest { Bucket = "test-bucket", Key = "test-key" };
        _putMetricDataS = Fixtures.PutMetricDataRequest_S();
        _putMetricDataM = Fixtures.PutMetricDataRequest_M();
        _putMetricDataL = Fixtures.PutMetricDataRequest_L();
        _getMetricDataS = Fixtures.GetMetricDataRequest_S();
        _getMetricDataM = Fixtures.GetMetricDataRequest_M();
        _getMetricDataL = Fixtures.GetMetricDataRequest_L();
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
