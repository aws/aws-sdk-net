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
using Amazon.Extensions.CborProtocol.Internal.Transform;
using Amazon.RpcCborDataPlane.Model;
using Amazon.RpcCborDataPlane.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using BenchmarkDotNet.Attributes;
using AV = Amazon.RpcCborDataPlane.Model.AttributeValue;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// BenchmarkDotNet benchmarks for Smithy RPC V2 CBOR protocol serialization/deserialization.
/// 19 test cases covering GetItem responses and PutItem requests with various payload sizes.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(SerdeBenchmarkConfig))]
public class RpcV2CborBenchmarks
{
    static AV S(string val) => new AV { S = val };
    static AV N(double val) => new AV { N = val.ToString() };
    static AV BOOL(bool val) => new AV { BOOL = val };
    static AV L(List<AV> val) => new AV { L = val };
    static AV M(Dictionary<string, AV> val) => new AV { M = val };
    static AV B(MemoryStream val) => new AV { B = val };

    private byte[] _getItemBaselineBytes = null!;
    private byte[] _getItemSBytes = null!;
    private byte[] _getItemMBytes = null!;
    private byte[] _getItemLBytes = null!;
    private byte[] _getItemBinarySBytes = null!;
    private byte[] _getItemBinaryMBytes = null!;
    private byte[] _getItemBinaryLBytes = null!;
    private PutItemRequest _putItemBaseline = null!;
    private PutItemRequest _putItemBinaryS = null!;
    private PutItemRequest _putItemBinaryM = null!;
    private PutItemRequest _putItemBinaryL = null!;
    private PutItemRequest _putItemMixedS = null!;
    private PutItemRequest _putItemMixedM = null!;
    private PutItemRequest _putItemMixedL = null!;
    private PutItemRequest _putItemNestedM = null!;
    private PutItemRequest _putItemNestedL = null!;
    private PutItemRequest _putItemShallowS = null!;
    private PutItemRequest _putItemShallowM = null!;
    private PutItemRequest _putItemShallowL = null!;

    [GlobalSetup]
    public void Setup()
    {
        _getItemBaselineBytes = BuildCborGetItemResponse(0);
        _getItemSBytes = BuildCborGetItemResponse(5);
        _getItemMBytes = BuildCborGetItemResponse(20);
        _getItemLBytes = BuildCborGetItemResponse(50);
        _getItemBinarySBytes = BuildCborGetItemBinaryResponse(TestDataHelpers.SmallBinarySize);
        _getItemBinaryMBytes = BuildCborGetItemBinaryResponse(TestDataHelpers.MediumBinarySize);
        _getItemBinaryLBytes = BuildCborGetItemBinaryResponse(TestDataHelpers.LargeBinarySize);
        _putItemBaseline = new PutItemRequest { TableName = "TestTable", Item = TestDataHelpers.CreateBaselineItem<AV>(S) };
        _putItemBinaryS = new PutItemRequest { TableName = "TestTable", Item = TestDataHelpers.CreateBinaryItem<AV>(S, B, TestDataHelpers.SmallBinarySize) };
        _putItemBinaryM = new PutItemRequest { TableName = "TestTable", Item = TestDataHelpers.CreateBinaryItem<AV>(S, B, TestDataHelpers.MediumBinarySize) };
        _putItemBinaryL = new PutItemRequest { TableName = "TestTable", Item = TestDataHelpers.CreateBinaryItem<AV>(S, B, TestDataHelpers.LargeBinarySize) };
        _putItemMixedS = new PutItemRequest { TableName = "TestTable", Item = TestDataHelpers.CreateSmallItem<AV>(S, N, BOOL) };
        _putItemMixedM = new PutItemRequest { TableName = "TestTable", Item = TestDataHelpers.CreateMediumItem<AV>(S, N, BOOL, L, M) };
        _putItemMixedL = new PutItemRequest { TableName = "TestTable", Item = TestDataHelpers.CreateLargeItem<AV>(S, N, BOOL, L, M) };
        _putItemNestedM = new PutItemRequest { TableName = "TestTable", Item = TestDataHelpers.CreateNestedItem<AV>(S, M, TestDataHelpers.MediumNestingDepth) };
        _putItemNestedL = new PutItemRequest { TableName = "TestTable", Item = TestDataHelpers.CreateNestedItem<AV>(S, M, TestDataHelpers.LargeNestingDepth) };
        _putItemShallowS = new PutItemRequest { TableName = "TestTable", Item = TestDataHelpers.CreateShallowMapItem<AV>(S, TestDataHelpers.SmallShallowMapKeys) };
        _putItemShallowM = new PutItemRequest { TableName = "TestTable", Item = TestDataHelpers.CreateShallowMapItem<AV>(S, TestDataHelpers.MediumShallowMapKeys) };
        _putItemShallowL = new PutItemRequest { TableName = "TestTable", Item = TestDataHelpers.CreateShallowMapItem<AV>(S, TestDataHelpers.LargeShallowMapKeys) };
    }

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
                writer.WriteStartMap(1); writer.WriteTextString("S"); writer.WriteTextString($"value-{i}-{new string('x', 20)}"); writer.WriteEndMap();
            }
            writer.WriteEndMap();
        }
        writer.WriteEndMap();
        return writer.Encode();
    }

    private static byte[] BuildCborGetItemBinaryResponse(int binarySize)
    {
        var data = new byte[binarySize]; Random.Shared.NextBytes(data);
        var writer = new CborWriter();
        writer.WriteStartMap(1); writer.WriteTextString("Item"); writer.WriteStartMap(2);
        writer.WriteTextString("pk"); writer.WriteStartMap(1); writer.WriteTextString("S"); writer.WriteTextString("binary-item"); writer.WriteEndMap();
        writer.WriteTextString("data"); writer.WriteStartMap(1); writer.WriteTextString("B"); writer.WriteByteString(data); writer.WriteEndMap();
        writer.WriteEndMap(); writer.WriteEndMap();
        return writer.Encode();
    }

    private void UnmarshallCbor(byte[] bytes)
    {
        using var stream = new MemoryStream(bytes);
        var wr = new WebResponseData { ContentType = "application/cbor", Headers = { { "x-amzn-RequestId", "test-id" }, { "Content-Length", bytes.Length.ToString() }, { "Content-Type", "application/cbor" }, { "smithy-protocol", "rpc-v2-cbor" } } };
        using var ctx = new CborUnmarshallerContext(stream, false, wr);
        GetItemResponseUnmarshaller.Instance.Unmarshall(ctx);
    }

    // --- GetItem Response ---
    [Benchmark] public void rpcv2Cbor_GetItemOutput_Baseline() => UnmarshallCbor(_getItemBaselineBytes);
    [Benchmark] public void rpcv2Cbor_GetItemOutput_S() => UnmarshallCbor(_getItemSBytes);
    [Benchmark] public void rpcv2Cbor_GetItemOutput_M() => UnmarshallCbor(_getItemMBytes);
    [Benchmark] public void rpcv2Cbor_GetItemOutput_L() => UnmarshallCbor(_getItemLBytes);
    [Benchmark] public void rpcv2Cbor_GetItemOutputBinary_S() => UnmarshallCbor(_getItemBinarySBytes);
    [Benchmark] public void rpcv2Cbor_GetItemOutputBinary_M() => UnmarshallCbor(_getItemBinaryMBytes);
    [Benchmark] public void rpcv2Cbor_GetItemOutputBinary_L() => UnmarshallCbor(_getItemBinaryLBytes);

    // --- PutItem Request ---
    [Benchmark] public long rpcv2Cbor_PutItemRequest_Baseline() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemBaseline));
    [Benchmark] public long rpcv2Cbor_PutItemRequest_BinaryData_S() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemBinaryS));
    [Benchmark] public long rpcv2Cbor_PutItemRequest_BinaryData_M() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemBinaryM));
    [Benchmark] public long rpcv2Cbor_PutItemRequest_BinaryData_L() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemBinaryL));
    [Benchmark] public long rpcv2Cbor_PutItemRequest_MixedItem_S() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemMixedS));
    [Benchmark] public long rpcv2Cbor_PutItemRequest_MixedItem_M() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemMixedM));
    [Benchmark] public long rpcv2Cbor_PutItemRequest_MixedItem_L() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemMixedL));
    [Benchmark] public long rpcv2Cbor_PutItemRequest_Nested_M() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemNestedM));
    [Benchmark] public long rpcv2Cbor_PutItemRequest_Nested_L() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemNestedL));
    [Benchmark] public long rpcv2Cbor_PutItemRequest_ShallowMap_S() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemShallowS));
    [Benchmark] public long rpcv2Cbor_PutItemRequest_ShallowMap_M() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemShallowM));
    [Benchmark] public long rpcv2Cbor_PutItemRequest_ShallowMap_L() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemShallowL));
}
