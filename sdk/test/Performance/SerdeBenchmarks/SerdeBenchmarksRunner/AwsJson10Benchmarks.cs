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
using Amazon.JsonRpc10DataPlane.Model;
using Amazon.JsonRpc10DataPlane.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using BenchmarkDotNet.Attributes;
using AV = Amazon.JsonRpc10DataPlane.Model.AttributeValue;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// BenchmarkDotNet benchmarks for AWS JSON 1.0 protocol serialization/deserialization.
/// 22 test cases covering Healthcheck, GetItem, PutItem with various payload sizes.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(SerdeBenchmarkConfig))]
public class AwsJson10Benchmarks
{
    static AV S(string val) => new AV { S = val };
    static AV N(double val) => new AV { N = val.ToString() };
    static AV BOOL(bool val) => new AV { BOOL = val };
    static AV L(List<AV> val) => new AV { L = val };
    static AV M(Dictionary<string, AV> val) => new AV { M = val };
    static AV B(MemoryStream val) => new AV { B = val };

    private HealthcheckRequest _healthcheckRequest = null!;
    private byte[] _healthcheckResponseBytes = null!;
    private GetItemRequest _getItemBaseline = null!;
    private byte[] _getItemOutputBaselineBytes = null!;
    private byte[] _getItemOutputSBytes = null!;
    private byte[] _getItemOutputMBytes = null!;
    private byte[] _getItemOutputLBytes = null!;
    private byte[] _getItemOutputBinarySBytes = null!;
    private byte[] _getItemOutputBinaryMBytes = null!;
    private byte[] _getItemOutputBinaryLBytes = null!;
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
        _healthcheckRequest = new HealthcheckRequest();
        _healthcheckResponseBytes = Encoding.UTF8.GetBytes("{\"ok\":\"OK\"}");
        _getItemBaseline = new GetItemRequest { TableName = "TestTable", Key = TestDataHelpers.CreateBaselineItem<AV>(S) };
        _getItemOutputBaselineBytes = Encoding.UTF8.GetBytes("{}");
        _getItemOutputSBytes = Encoding.UTF8.GetBytes(BuildGetItemJson(5));
        _getItemOutputMBytes = Encoding.UTF8.GetBytes(BuildGetItemJson(20));
        _getItemOutputLBytes = Encoding.UTF8.GetBytes(BuildGetItemJson(50));
        _getItemOutputBinarySBytes = Encoding.UTF8.GetBytes(BuildBinaryGetItemJson(TestDataHelpers.SmallBinarySize));
        _getItemOutputBinaryMBytes = Encoding.UTF8.GetBytes(BuildBinaryGetItemJson(TestDataHelpers.MediumBinarySize));
        _getItemOutputBinaryLBytes = Encoding.UTF8.GetBytes(BuildBinaryGetItemJson(TestDataHelpers.LargeBinarySize));
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

    private static string BuildGetItemJson(int attrCount)
    {
        var sb = new StringBuilder("{\"Item\":{");
        for (int i = 0; i < attrCount; i++) { if (i > 0) sb.Append(','); sb.Append($"\"attr_{i}\":{{\"S\":\"value-{i}-{new string('x', 20)}\"}}"); }
        sb.Append("}}"); return sb.ToString();
    }

    private static string BuildBinaryGetItemJson(int binarySize)
    {
        var data = new byte[binarySize]; Random.Shared.NextBytes(data);
        return $"{{\"Item\":{{\"pk\":{{\"S\":\"binary-item\"}},\"data\":{{\"B\":\"{Convert.ToBase64String(data)}\"}}}}}}";
    }

    private void UnmarshallJson(byte[] bytes, Type unmarshallerType)
    {
        using var stream = new MemoryStream(bytes);
        var wr = new WebResponseData { Headers = { { "x-amzn-RequestId", "test-id" }, { "Content-Length", bytes.Length.ToString() }, { "Content-Type", "application/x-amz-json-1.0" } } };
        var unmarshaller = (IResponseUnmarshaller<AmazonWebServiceResponse, UnmarshallerContext>)
            unmarshallerType.GetMethod("GetInstance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public)!.Invoke(null, null)!;
        using var ctx = new JsonUnmarshallerContext(stream, false, wr);
        unmarshaller.Unmarshall(ctx);
    }

    // --- Healthcheck ---
    [Benchmark] public void awsJson1_0_HealthcheckRequest_Example() => HealthcheckRequestMarshaller.Instance.Marshall(_healthcheckRequest);
    [Benchmark] public void awsJson1_0_HealthcheckResponse_Example() => UnmarshallJson(_healthcheckResponseBytes, typeof(HealthcheckResponseUnmarshaller));

    // --- GetItem ---
    [Benchmark] public void awsJson1_0_GetItemInput_Baseline() => GetItemRequestMarshaller.Instance.Marshall(_getItemBaseline);
    [Benchmark] public void awsJson1_0_GetItemOutput_Baseline() => UnmarshallJson(_getItemOutputBaselineBytes, typeof(GetItemResponseUnmarshaller));
    [Benchmark] public void awsJson1_0_GetItemOutput_S() => UnmarshallJson(_getItemOutputSBytes, typeof(GetItemResponseUnmarshaller));
    [Benchmark] public void awsJson1_0_GetItemOutput_M() => UnmarshallJson(_getItemOutputMBytes, typeof(GetItemResponseUnmarshaller));
    [Benchmark] public void awsJson1_0_GetItemOutput_L() => UnmarshallJson(_getItemOutputLBytes, typeof(GetItemResponseUnmarshaller));
    [Benchmark] public void awsJson1_0_GetItemOutputBinary_S() => UnmarshallJson(_getItemOutputBinarySBytes, typeof(GetItemResponseUnmarshaller));
    [Benchmark] public void awsJson1_0_GetItemOutputBinary_M() => UnmarshallJson(_getItemOutputBinaryMBytes, typeof(GetItemResponseUnmarshaller));
    [Benchmark] public void awsJson1_0_GetItemOutputBinary_L() => UnmarshallJson(_getItemOutputBinaryLBytes, typeof(GetItemResponseUnmarshaller));

    // --- PutItem ---
    [Benchmark] public void awsJson1_0_PutItemRequest_Baseline() => PutItemRequestMarshaller.Instance.Marshall(_putItemBaseline);
    [Benchmark] public void awsJson1_0_PutItemRequest_BinaryData_S() => PutItemRequestMarshaller.Instance.Marshall(_putItemBinaryS);
    [Benchmark] public void awsJson1_0_PutItemRequest_BinaryData_M() => PutItemRequestMarshaller.Instance.Marshall(_putItemBinaryM);
    [Benchmark] public void awsJson1_0_PutItemRequest_BinaryData_L() => PutItemRequestMarshaller.Instance.Marshall(_putItemBinaryL);
    [Benchmark] public void awsJson1_0_PutItemRequest_MixedItem_S() => PutItemRequestMarshaller.Instance.Marshall(_putItemMixedS);
    [Benchmark] public void awsJson1_0_PutItemRequest_MixedItem_M() => PutItemRequestMarshaller.Instance.Marshall(_putItemMixedM);
    [Benchmark] public void awsJson1_0_PutItemRequest_MixedItem_L() => PutItemRequestMarshaller.Instance.Marshall(_putItemMixedL);
    [Benchmark] public void awsJson1_0_PutItemRequest_Nested_M() => PutItemRequestMarshaller.Instance.Marshall(_putItemNestedM);
    [Benchmark] public void awsJson1_0_PutItemRequest_Nested_L() => PutItemRequestMarshaller.Instance.Marshall(_putItemNestedL);
    [Benchmark] public void awsJson1_0_PutItemRequest_ShallowMap_S() => PutItemRequestMarshaller.Instance.Marshall(_putItemShallowS);
    [Benchmark] public void awsJson1_0_PutItemRequest_ShallowMap_M() => PutItemRequestMarshaller.Instance.Marshall(_putItemShallowM);
    [Benchmark] public void awsJson1_0_PutItemRequest_ShallowMap_L() => PutItemRequestMarshaller.Instance.Marshall(_putItemShallowL);
}
