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

using Amazon.Extensions.CborProtocol.Internal.Transform;
using Amazon.RpcCborDataPlane.Model;
using Amazon.RpcCborDataPlane.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using BenchmarkDotNet.Attributes;
using Fixtures = AWSSDK.Benchmarks.Serde.ModelFixtures.RpcV2Cbor;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// BenchmarkDotNet benchmarks for Smithy RPC V2 CBOR protocol serialization/deserialization.
/// 19 test cases covering GetItem responses and PutItem requests, with payloads from the shared benchmark models.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(SerdeBenchmarkConfig))]
public class RpcV2CborBenchmarks
{
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
        _getItemBaselineBytes = Fixtures.GetItemOutput_Baseline;
        _getItemSBytes = Fixtures.GetItemOutput_S;
        _getItemMBytes = Fixtures.GetItemOutput_M;
        _getItemLBytes = Fixtures.GetItemOutput_L;
        _getItemBinarySBytes = Fixtures.GetItemOutputBinary_S;
        _getItemBinaryMBytes = Fixtures.GetItemOutputBinary_M;
        _getItemBinaryLBytes = Fixtures.GetItemOutputBinary_L;
        _putItemBaseline = Fixtures.PutItemRequest_Baseline();
        _putItemBinaryS = Fixtures.PutItemRequest_BinaryData_S();
        _putItemBinaryM = Fixtures.PutItemRequest_BinaryData_M();
        _putItemBinaryL = Fixtures.PutItemRequest_BinaryData_L();
        _putItemMixedS = Fixtures.PutItemRequest_MixedItem_S();
        _putItemMixedM = Fixtures.PutItemRequest_MixedItem_M();
        _putItemMixedL = Fixtures.PutItemRequest_MixedItem_L();
        _putItemNestedM = Fixtures.PutItemRequest_Nested_M();
        _putItemNestedL = Fixtures.PutItemRequest_Nested_L();
        _putItemShallowS = Fixtures.PutItemRequest_ShallowMap_S();
        _putItemShallowM = Fixtures.PutItemRequest_ShallowMap_M();
        _putItemShallowL = Fixtures.PutItemRequest_ShallowMap_L();
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
