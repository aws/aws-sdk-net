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
using Fixtures = AWSSDK.Benchmarks.Serde.ModelFixtures.AwsQuery;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// E2E benchmarks for AWS Query protocol (CloudWatch-like operations).
/// Full SDK client pipeline with mocked HTTP, with payloads from the shared benchmark models:
/// each GetMetricData round trip pairs the model request and response of the same size.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(E2EBenchmarkConfig))]
public class AwsQueryE2EBenchmarks
{
    internal AmazonQueryDataPlaneClient _healthcheckClient = null!;
    internal AmazonQueryDataPlaneClient _putClientS = null!;
    internal AmazonQueryDataPlaneClient _putClientM = null!;
    internal AmazonQueryDataPlaneClient _getClientS = null!;
    internal AmazonQueryDataPlaneClient _getClientM = null!;

    internal HealthcheckRequest _healthcheckRequest = null!;
    internal PutMetricDataRequest _putMetricDataS = null!;
    internal PutMetricDataRequest _putMetricDataM = null!;
    internal GetMetricDataRequest _getMetricDataRequestS = null!;
    internal GetMetricDataRequest _getMetricDataRequestM = null!;

    private static readonly byte[] PutMetricResponse = Encoding.UTF8.GetBytes(
        "<PutMetricDataResponse xmlns=\"https://awsquerydataplane.amazonaws.com\"><PutMetricDataResult/><ResponseMetadata><RequestId>test-id</RequestId></ResponseMetadata></PutMetricDataResponse>");

    internal AmazonQueryDataPlaneClient CreateClient(byte[] responseBody)
    {
        var handler = new MockHttpHandler(responseBody, "text/xml");
        var config = new AmazonQueryDataPlaneConfig
        {
            RegionEndpoint = Amazon.RegionEndpoint.USWest2,
            HttpClientFactory = new MockHttpClientFactory(handler)
        };
        return new AmazonQueryDataPlaneClient(new BasicAWSCredentials("AKID", "SECRET"), config);
    }

    [GlobalSetup]
    public void Setup()
    {
        _healthcheckClient = CreateClient(Fixtures.HealthcheckResponse_Example);
        _putClientS = CreateClient(PutMetricResponse);
        _putClientM = CreateClient(PutMetricResponse);
        _getClientS = CreateClient(Fixtures.GetMetricDataResponse_S);
        _getClientM = CreateClient(Fixtures.GetMetricDataResponse_M);

        _healthcheckRequest = Fixtures.HealthcheckRequest_Example();
        _putMetricDataS = Fixtures.PutMetricDataRequest_S();
        _putMetricDataM = Fixtures.PutMetricDataRequest_M();
        _getMetricDataRequestS = Fixtures.GetMetricDataRequest_S();
        _getMetricDataRequestM = Fixtures.GetMetricDataRequest_M();
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
