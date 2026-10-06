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
using Fixtures = AWSSDK.Benchmarks.Serde.ModelFixtures.RestXml;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// E2E benchmarks for REST XML protocol (S3-like operations).
/// Full SDK client pipeline with mocked HTTP, with payloads from the shared benchmark models
/// (CopyObject uses the Baseline case). The models define CloudWatch operations only for awsQuery,
/// so the PutMetricData/GetMetricData cases use those requests re-targeted to REST XML and those
/// responses re-encoded as REST XML.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(E2EBenchmarkConfig))]
public class RestXmlE2EBenchmarks
{
    internal AmazonRestXmlDataPlaneClient _copyClient = null!;
    internal AmazonRestXmlDataPlaneClient _putClient = null!;
    internal AmazonRestXmlDataPlaneClient _getClientS = null!;
    internal AmazonRestXmlDataPlaneClient _getClientM = null!;
    internal AmazonRestXmlDataPlaneClient _getClientL = null!;
    internal AmazonRestXmlDataPlaneClient _putMetricClientS = null!;
    internal AmazonRestXmlDataPlaneClient _putMetricClientM = null!;
    internal AmazonRestXmlDataPlaneClient _getMetricClientS = null!;
    internal AmazonRestXmlDataPlaneClient _getMetricClientM = null!;

    internal CopyObjectRequest _copyObjectRequest = null!;
    internal PutObjectRequest _putObjectS = null!;
    internal PutObjectRequest _putObjectM = null!;
    internal PutObjectRequest _putObjectL = null!;
    internal GetObjectRequest _getObjectRequest = null!;
    internal PutMetricDataRequest _putMetricDataS = null!;
    internal PutMetricDataRequest _putMetricDataM = null!;
    internal GetMetricDataRequest _getMetricDataS = null!;
    internal GetMetricDataRequest _getMetricDataM = null!;

    private static readonly byte[] EmptyXml = Encoding.UTF8.GetBytes("<?xml version=\"1.0\" encoding=\"UTF-8\"?><Response/>");

    internal AmazonRestXmlDataPlaneClient CreateClient(byte[] responseBody, IReadOnlyDictionary<string, string>? headers = null, string contentType = "application/xml")
    {
        var handler = new MockHttpHandler(responseBody, contentType, responseHeaders: headers?.ToDictionary(kv => kv.Key, kv => kv.Value));
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
        _copyClient = CreateClient(Fixtures.CopyObjectOutput_Baseline, Fixtures.CopyObjectOutput_Baseline_Headers);
        _putClient = CreateClient(EmptyXml);
        _getClientS = CreateClient(Fixtures.GetObject_S, Fixtures.GetObject_S_Headers, "application/octet-stream");
        _getClientM = CreateClient(Fixtures.GetObject_M, Fixtures.GetObject_M_Headers, "application/octet-stream");
        _getClientL = CreateClient(Fixtures.GetObject_L, Fixtures.GetObject_L_Headers, "application/octet-stream");
        _putMetricClientS = CreateClient(EmptyXml);
        _putMetricClientM = CreateClient(EmptyXml);
        _getMetricClientS = CreateClient(Fixtures.GetMetricDataResponse_S);
        _getMetricClientM = CreateClient(Fixtures.GetMetricDataResponse_M);

        _copyObjectRequest = Fixtures.CopyObjectRequest_Baseline();
        _putObjectS = Fixtures.PutObject_S();
        _putObjectM = Fixtures.PutObject_M();
        _putObjectL = Fixtures.PutObject_L();
        _getObjectRequest = new GetObjectRequest { Bucket = "test-bucket", Key = "test-key" };
        _putMetricDataS = Fixtures.PutMetricDataRequest_S();
        _putMetricDataM = Fixtures.PutMetricDataRequest_M();
        _getMetricDataS = Fixtures.GetMetricDataRequest_S();
        _getMetricDataM = Fixtures.GetMetricDataRequest_M();
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
