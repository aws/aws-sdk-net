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
using Amazon.JsonRpc10DataPlane;
using Amazon.JsonRpc10DataPlane.Model;
using Amazon.Runtime;
using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// E2E benchmarks for AWS JSON 1.0 protocol (DynamoDB-like operations).
/// Full SDK client pipeline with mocked HTTP.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(E2EBenchmarkConfig))]
public class AwsJson10E2EBenchmarks
{
    private AmazonJsonRpc10DataPlaneClient _healthcheckClient = null!;
    private AmazonJsonRpc10DataPlaneClient _putClient = null!;
    private AmazonJsonRpc10DataPlaneClient _getClientS = null!;
    private AmazonJsonRpc10DataPlaneClient _getClientM = null!;
    private AmazonJsonRpc10DataPlaneClient _getClientL = null!;

    private PutItemRequest _putItemS = null!;
    private PutItemRequest _putItemM = null!;
    private PutItemRequest _putItemL = null!;
    private GetItemRequest _getItemRequest = null!;
    private HealthcheckRequest _healthcheckRequest = null!;

    private static readonly byte[] EmptyJson = Encoding.UTF8.GetBytes("{}");
    private static readonly byte[] GetItemResponseS = Encoding.UTF8.GetBytes(BuildGetItemJson(5));
    private static readonly byte[] GetItemResponseM = Encoding.UTF8.GetBytes(BuildGetItemJson(20));
    private static readonly byte[] GetItemResponseL = Encoding.UTF8.GetBytes(BuildGetItemJson(50));

    private static string BuildGetItemJson(int attrCount)
    {
        var sb = new StringBuilder("{\"Item\":{");
        for (int i = 0; i < attrCount; i++)
        {
            if (i > 0) sb.Append(',');
            sb.Append($"\"attr_{i}\":{{\"S\":\"value-{i}-{new string('x', 20)}\"}}");
        }
        sb.Append("}}");
        return sb.ToString();
    }

    private AmazonJsonRpc10DataPlaneClient CreateClient(byte[] responseBody)
    {
        var handler = new MockHttpHandler(responseBody, "application/x-amz-json-1.0");
        var config = new AmazonJsonRpc10DataPlaneConfig
        {
            RegionEndpoint = Amazon.RegionEndpoint.USWest2,
            HttpClientFactory = new MockHttpClientFactory(handler)
        };
        return new AmazonJsonRpc10DataPlaneClient(new BasicAWSCredentials("AKID", "SECRET"), config);
    }

    private static AttributeValue S(string v) => new AttributeValue { S = v };

    [GlobalSetup]
    public void Setup()
    {
        _healthcheckClient = CreateClient(EmptyJson);
        _putClient = CreateClient(EmptyJson);
        _getClientS = CreateClient(GetItemResponseS);
        _getClientM = CreateClient(GetItemResponseM);
        _getClientL = CreateClient(GetItemResponseL);

        _healthcheckRequest = new HealthcheckRequest();
        _putItemS = new PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateSmallItem<AttributeValue>(S, n => new AttributeValue { N = n.ToString() }, b => new AttributeValue { BOOL = b }) };
        _putItemM = new PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateMediumItem<AttributeValue>(S, n => new AttributeValue { N = n.ToString() }, b => new AttributeValue { BOOL = b }, l => new AttributeValue { L = l }, m => new AttributeValue { M = m }) };
        _putItemL = new PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateLargeItem<AttributeValue>(S, n => new AttributeValue { N = n.ToString() }, b => new AttributeValue { BOOL = b }, l => new AttributeValue { L = l }, m => new AttributeValue { M = m }) };
        _getItemRequest = new GetItemRequest { TableName = "T", Key = TestDataHelpers.CreateBaselineItem<AttributeValue>(S) };
    }

    [Benchmark] public async Task awsJson10_e2e_Healthcheck() => await _healthcheckClient.HealthcheckAsync(_healthcheckRequest);
    [Benchmark] public async Task awsJson10_e2e_PutItem_S() => await _putClient.PutItemAsync(_putItemS);
    [Benchmark] public async Task awsJson10_e2e_PutItem_M() => await _putClient.PutItemAsync(_putItemM);
    [Benchmark] public async Task awsJson10_e2e_PutItem_L() => await _putClient.PutItemAsync(_putItemL);
    [Benchmark] public async Task awsJson10_e2e_GetItem_S() => await _getClientS.GetItemAsync(_getItemRequest);
    [Benchmark] public async Task awsJson10_e2e_GetItem_M() => await _getClientM.GetItemAsync(_getItemRequest);
    [Benchmark] public async Task awsJson10_e2e_GetItem_L() => await _getClientL.GetItemAsync(_getItemRequest);

    [GlobalCleanup]
    public void Cleanup()
    {
        _healthcheckClient?.Dispose();
        _putClient?.Dispose();
        _getClientS?.Dispose();
        _getClientM?.Dispose();
        _getClientL?.Dispose();
    }
}
