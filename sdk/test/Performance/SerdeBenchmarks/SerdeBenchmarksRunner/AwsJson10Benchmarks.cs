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

using Amazon.JsonRpc10DataPlane.Model;
using Amazon.JsonRpc10DataPlane.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using BenchmarkDotNet.Attributes;
using Fixtures = AWSSDK.Benchmarks.Serde.ModelFixtures.AwsJson10;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// BenchmarkDotNet benchmarks for AWS JSON 1.0 protocol serialization/deserialization.
/// 22 test cases covering Healthcheck, GetItem, PutItem, with payloads from the shared benchmark models.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(SerdeBenchmarkConfig))]
public class AwsJson10Benchmarks
{
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

    // Cached unmarshaller instances to avoid reflection overhead during measurement
    private IResponseUnmarshaller<AmazonWebServiceResponse, UnmarshallerContext> _healthcheckUnmarshaller = null!;
    private IResponseUnmarshaller<AmazonWebServiceResponse, UnmarshallerContext> _getItemUnmarshaller = null!;

    [GlobalSetup]
    public void Setup()
    {
        _healthcheckRequest = Fixtures.HealthcheckRequest_Example();
        _healthcheckResponseBytes = Fixtures.HealthcheckResponse_Example;
        _getItemBaseline = Fixtures.GetItemInput_Baseline();
        _getItemOutputBaselineBytes = Fixtures.GetItemOutput_Baseline;
        _getItemOutputSBytes = Fixtures.GetItemOutput_S;
        _getItemOutputMBytes = Fixtures.GetItemOutput_M;
        _getItemOutputLBytes = Fixtures.GetItemOutput_L;
        _getItemOutputBinarySBytes = Fixtures.GetItemOutputBinary_S;
        _getItemOutputBinaryMBytes = Fixtures.GetItemOutputBinary_M;
        _getItemOutputBinaryLBytes = Fixtures.GetItemOutputBinary_L;
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

        _healthcheckUnmarshaller = GetUnmarshallerInstance(typeof(HealthcheckResponseUnmarshaller));
        _getItemUnmarshaller = GetUnmarshallerInstance(typeof(GetItemResponseUnmarshaller));
    }

    private static IResponseUnmarshaller<AmazonWebServiceResponse, UnmarshallerContext> GetUnmarshallerInstance(Type unmarshallerType)
    {
        return (IResponseUnmarshaller<AmazonWebServiceResponse, UnmarshallerContext>)
            unmarshallerType.GetMethod("GetInstance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public)!.Invoke(null, null)!;
    }

    private void UnmarshallJson(byte[] bytes, IResponseUnmarshaller<AmazonWebServiceResponse, UnmarshallerContext> unmarshaller)
    {
        using var stream = new MemoryStream(bytes);
        var wr = new WebResponseData { Headers = { { "x-amzn-RequestId", "test-id" }, { "Content-Length", bytes.Length.ToString() }, { "Content-Type", "application/x-amz-json-1.0" } } };
        using var ctx = new JsonUnmarshallerContext(stream, false, wr);
        unmarshaller.Unmarshall(ctx);
    }

    // --- Healthcheck ---
    [Benchmark] public long awsJson1_0_HealthcheckRequest_Example() => TestDataHelpers.GetContentLengthAndDispose(HealthcheckRequestMarshaller.Instance.Marshall(_healthcheckRequest));
    [Benchmark] public void awsJson1_0_HealthcheckResponse_Example() => UnmarshallJson(_healthcheckResponseBytes, _healthcheckUnmarshaller);

    // --- GetItem ---
    [Benchmark] public long awsJson1_0_GetItemInput_Baseline() => TestDataHelpers.GetContentLengthAndDispose(GetItemRequestMarshaller.Instance.Marshall(_getItemBaseline));
    [Benchmark] public void awsJson1_0_GetItemOutput_Baseline() => UnmarshallJson(_getItemOutputBaselineBytes, _getItemUnmarshaller);
    [Benchmark] public void awsJson1_0_GetItemOutput_S() => UnmarshallJson(_getItemOutputSBytes, _getItemUnmarshaller);
    [Benchmark] public void awsJson1_0_GetItemOutput_M() => UnmarshallJson(_getItemOutputMBytes, _getItemUnmarshaller);
    [Benchmark] public void awsJson1_0_GetItemOutput_L() => UnmarshallJson(_getItemOutputLBytes, _getItemUnmarshaller);
    [Benchmark] public void awsJson1_0_GetItemOutputBinary_S() => UnmarshallJson(_getItemOutputBinarySBytes, _getItemUnmarshaller);
    [Benchmark] public void awsJson1_0_GetItemOutputBinary_M() => UnmarshallJson(_getItemOutputBinaryMBytes, _getItemUnmarshaller);
    [Benchmark] public void awsJson1_0_GetItemOutputBinary_L() => UnmarshallJson(_getItemOutputBinaryLBytes, _getItemUnmarshaller);

    // --- PutItem ---
    [Benchmark] public long awsJson1_0_PutItemRequest_Baseline() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemBaseline));
    [Benchmark] public long awsJson1_0_PutItemRequest_BinaryData_S() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemBinaryS));
    [Benchmark] public long awsJson1_0_PutItemRequest_BinaryData_M() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemBinaryM));
    [Benchmark] public long awsJson1_0_PutItemRequest_BinaryData_L() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemBinaryL));
    [Benchmark] public long awsJson1_0_PutItemRequest_MixedItem_S() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemMixedS));
    [Benchmark] public long awsJson1_0_PutItemRequest_MixedItem_M() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemMixedM));
    [Benchmark] public long awsJson1_0_PutItemRequest_MixedItem_L() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemMixedL));
    [Benchmark] public long awsJson1_0_PutItemRequest_Nested_M() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemNestedM));
    [Benchmark] public long awsJson1_0_PutItemRequest_Nested_L() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemNestedL));
    [Benchmark] public long awsJson1_0_PutItemRequest_ShallowMap_S() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemShallowS));
    [Benchmark] public long awsJson1_0_PutItemRequest_ShallowMap_M() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemShallowM));
    [Benchmark] public long awsJson1_0_PutItemRequest_ShallowMap_L() => TestDataHelpers.GetContentLengthAndDispose(PutItemRequestMarshaller.Instance.Marshall(_putItemShallowL));
}
