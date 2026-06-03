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

    private CopyObjectRequest _copyObjectRequest = null!;
    private PutObjectRequest _putObjectS = null!;
    private PutObjectRequest _putObjectM = null!;
    private PutObjectRequest _putObjectL = null!;
    private GetObjectRequest _getObjectRequest = null!;

    private static readonly byte[] CopyResponse = Encoding.UTF8.GetBytes(
        "<?xml version=\"1.0\" encoding=\"UTF-8\"?><CopyObjectResult><ETag>\"d41d8cd98f00b204e9800998ecf8427e\"</ETag><LastModified>2024-01-01T00:00:00Z</LastModified></CopyObjectResult>");
    private static readonly byte[] EmptyXml = Encoding.UTF8.GetBytes("<?xml version=\"1.0\" encoding=\"UTF-8\"?><Response/>");
    private static readonly byte[] GetObjectS = new byte[1024];
    private static readonly byte[] GetObjectM = new byte[100 * 1024];
    private static readonly byte[] GetObjectL = new byte[1024 * 1024];

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

        _copyObjectRequest = new CopyObjectRequest { Bucket = "b", Key = "k", CopySource = "src/k" };
        _putObjectS = new PutObjectRequest { Bucket = "b", Key = "k", ContentType = "application/octet-stream", Body = new MemoryStream(new byte[1024]) };
        _putObjectM = new PutObjectRequest { Bucket = "b", Key = "k", ContentType = "application/octet-stream", Body = new MemoryStream(new byte[100 * 1024]) };
        _putObjectL = new PutObjectRequest { Bucket = "b", Key = "k", ContentType = "application/octet-stream", Body = new MemoryStream(new byte[1024 * 1024]) };
        _getObjectRequest = new GetObjectRequest { Bucket = "b", Key = "k" };
    }

    [Benchmark] public async Task restXml_e2e_CopyObject() => await _copyClient.CopyObjectAsync(_copyObjectRequest);
    [Benchmark] public async Task restXml_e2e_PutObject_S() { _putObjectS.Body.Position = 0; await _putClient.PutObjectAsync(_putObjectS); }
    [Benchmark] public async Task restXml_e2e_PutObject_M() { _putObjectM.Body.Position = 0; await _putClient.PutObjectAsync(_putObjectM); }
    [Benchmark] public async Task restXml_e2e_PutObject_L() { _putObjectL.Body.Position = 0; await _putClient.PutObjectAsync(_putObjectL); }
    [Benchmark] public async Task restXml_e2e_GetObject_S() => await _getClientS.GetObjectAsync(_getObjectRequest);
    [Benchmark] public async Task restXml_e2e_GetObject_M() => await _getClientM.GetObjectAsync(_getObjectRequest);
    [Benchmark] public async Task restXml_e2e_GetObject_L() => await _getClientL.GetObjectAsync(_getObjectRequest);

    [GlobalCleanup]
    public void Cleanup()
    {
        _copyClient?.Dispose();
        _putClient?.Dispose();
        _getClientS?.Dispose();
        _getClientM?.Dispose();
        _getClientL?.Dispose();
    }
}
