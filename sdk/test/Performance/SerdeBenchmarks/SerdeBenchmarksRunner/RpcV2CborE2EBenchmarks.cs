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

using System.Formats.Cbor;
using Amazon.RpcCborDataPlane;
using Amazon.RpcCborDataPlane.Model;
using Amazon.Runtime;
using BenchmarkDotNet.Attributes;
using AV = Amazon.RpcCborDataPlane.Model.AttributeValue;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// E2E benchmarks for Smithy RPC V2 CBOR protocol.
/// Full SDK client pipeline with mocked HTTP.
/// Uses separate clients for PutItem (empty response) and GetItem (sized responses).
/// </summary>
[MemoryDiagnoser]
[Config(typeof(E2EBenchmarkConfig))]
public class RpcV2CborE2EBenchmarks
{
    private AmazonRpcCborDataPlaneClient _putClient = null!;
    private AmazonRpcCborDataPlaneClient _getClientS = null!;
    private AmazonRpcCborDataPlaneClient _getClientM = null!;
    private AmazonRpcCborDataPlaneClient _getClientL = null!;
    private PutItemRequest _putItemS = null!;
    private PutItemRequest _putItemM = null!;
    private PutItemRequest _putItemL = null!;
    private GetItemRequest _getItemRequest = null!;

    private static readonly byte[] EmptyCborMap = new byte[] { 0xA0 };
    private static readonly byte[] GetItemResponseS = BuildCborGetItemResponse(5);
    private static readonly byte[] GetItemResponseM = BuildCborGetItemResponse(20);
    private static readonly byte[] GetItemResponseL = BuildCborGetItemResponse(50);

    private static byte[] BuildCborGetItemResponse(int attributeCount)
    {
        var writer = new CborWriter();
        writer.WriteStartMap(attributeCount > 0 ? 1 : 0);
        if (attributeCount > 0)
        {
            writer.WriteTextString("Item");
            writer.WriteStartMap(attributeCount);
            for (int i = 0; i < attributeCount; i++)
            {
                writer.WriteTextString($"attr_{i}");
                writer.WriteStartMap(1);
                writer.WriteTextString("S");
                writer.WriteTextString($"value-{i}-{new string('x', 20)}");
                writer.WriteEndMap();
            }
            writer.WriteEndMap();
        }
        writer.WriteEndMap();
        return writer.Encode();
    }

    private static AV S(string v) => new AV { S = v };

    private AmazonRpcCborDataPlaneClient CreateClient(byte[] responseBody)
    {
        var headers = new Dictionary<string, string> { ["smithy-protocol"] = "rpc-v2-cbor" };
        var handler = new MockHttpHandler(responseBody, "application/cbor", responseHeaders: headers);
        var config = new AmazonRpcCborDataPlaneConfig
        {
            RegionEndpoint = Amazon.RegionEndpoint.USWest2,
            HttpClientFactory = new MockHttpClientFactory(handler)
        };
        return new AmazonRpcCborDataPlaneClient(new BasicAWSCredentials("AKID", "SECRET"), config);
    }

    [GlobalSetup]
    public void Setup()
    {
        _putClient = CreateClient(EmptyCborMap);
        _getClientS = CreateClient(GetItemResponseS);
        _getClientM = CreateClient(GetItemResponseM);
        _getClientL = CreateClient(GetItemResponseL);

        _putItemS = new PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateSmallItem<AV>(S, n => new AV { N = n.ToString() }, b => new AV { BOOL = b }) };
        _putItemM = new PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateMediumItem<AV>(S, n => new AV { N = n.ToString() }, b => new AV { BOOL = b }, l => new AV { L = l }, m => new AV { M = m }) };
        _putItemL = new PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateLargeItem<AV>(S, n => new AV { N = n.ToString() }, b => new AV { BOOL = b }, l => new AV { L = l }, m => new AV { M = m }) };
        _getItemRequest = new GetItemRequest { TableName = "T", Key = TestDataHelpers.CreateBaselineItem<AV>(S) };
    }

    [Benchmark] public async Task rpcV2Cbor_e2e_PutItem_S() => await _putClient.PutItemAsync(_putItemS);
    [Benchmark] public async Task rpcV2Cbor_e2e_PutItem_M() => await _putClient.PutItemAsync(_putItemM);
    [Benchmark] public async Task rpcV2Cbor_e2e_PutItem_L() => await _putClient.PutItemAsync(_putItemL);
    [Benchmark] public async Task rpcV2Cbor_e2e_GetItem_S() => await _getClientS.GetItemAsync(_getItemRequest);
    [Benchmark] public async Task rpcV2Cbor_e2e_GetItem_M() => await _getClientM.GetItemAsync(_getItemRequest);
    [Benchmark] public async Task rpcV2Cbor_e2e_GetItem_L() => await _getClientL.GetItemAsync(_getItemRequest);

    [GlobalCleanup]
    public void Cleanup()
    {
        _putClient?.Dispose();
        _getClientS?.Dispose();
        _getClientM?.Dispose();
        _getClientL?.Dispose();
    }
}
