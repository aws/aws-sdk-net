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

using Amazon.QueryDataPlane.Model;
using Amazon.QueryDataPlane.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using BenchmarkDotNet.Attributes;
using Fixtures = AWSSDK.Benchmarks.Serde.ModelFixtures.AwsQuery;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// BenchmarkDotNet benchmarks for AWS Query protocol serialization/deserialization.
/// 10 test cases: PutMetricData Baseline/S/M/L, GetMetricDataRequest S/M/L, GetMetricDataResponse S/M/L,
/// with payloads from the shared benchmark models.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(SerdeBenchmarkConfig))]
public class AwsQueryBenchmarks
{
    private PutMetricDataRequest _putMetricBaseline = null!;
    private PutMetricDataRequest _putMetricS = null!;
    private PutMetricDataRequest _putMetricM = null!;
    private PutMetricDataRequest _putMetricL = null!;
    private GetMetricDataRequest _getMetricReqS = null!;
    private GetMetricDataRequest _getMetricReqM = null!;
    private GetMetricDataRequest _getMetricReqL = null!;
    private byte[] _getMetricRespSBytes = null!;
    private byte[] _getMetricRespMBytes = null!;
    private byte[] _getMetricRespLBytes = null!;

    [GlobalSetup]
    public void Setup()
    {
        _putMetricBaseline = Fixtures.PutMetricDataRequest_Baseline();
        _putMetricS = Fixtures.PutMetricDataRequest_S();
        _putMetricM = Fixtures.PutMetricDataRequest_M();
        _putMetricL = Fixtures.PutMetricDataRequest_L();

        _getMetricReqS = Fixtures.GetMetricDataRequest_S();
        _getMetricReqM = Fixtures.GetMetricDataRequest_M();
        _getMetricReqL = Fixtures.GetMetricDataRequest_L();

        _getMetricRespSBytes = Fixtures.GetMetricDataResponse_S;
        _getMetricRespMBytes = Fixtures.GetMetricDataResponse_M;
        _getMetricRespLBytes = Fixtures.GetMetricDataResponse_L;
    }

    // --- PutMetricData Request ---
    [Benchmark] public long awsQuery_PutMetricDataRequest_Baseline() => TestDataHelpers.GetContentLengthAndDispose(PutMetricDataRequestMarshaller.Instance.Marshall(_putMetricBaseline));
    [Benchmark] public long awsQuery_PutMetricDataRequest_S() => TestDataHelpers.GetContentLengthAndDispose(PutMetricDataRequestMarshaller.Instance.Marshall(_putMetricS));
    [Benchmark] public long awsQuery_PutMetricDataRequest_M() => TestDataHelpers.GetContentLengthAndDispose(PutMetricDataRequestMarshaller.Instance.Marshall(_putMetricM));
    [Benchmark] public long awsQuery_PutMetricDataRequest_L() => TestDataHelpers.GetContentLengthAndDispose(PutMetricDataRequestMarshaller.Instance.Marshall(_putMetricL));

    // --- GetMetricData Request ---
    [Benchmark] public long awsQuery_GetMetricDataRequest_S() => TestDataHelpers.GetContentLengthAndDispose(GetMetricDataRequestMarshaller.Instance.Marshall(_getMetricReqS));
    [Benchmark] public long awsQuery_GetMetricDataRequest_M() => TestDataHelpers.GetContentLengthAndDispose(GetMetricDataRequestMarshaller.Instance.Marshall(_getMetricReqM));
    [Benchmark] public long awsQuery_GetMetricDataRequest_L() => TestDataHelpers.GetContentLengthAndDispose(GetMetricDataRequestMarshaller.Instance.Marshall(_getMetricReqL));

    // --- GetMetricData Response ---
    [Benchmark] public void awsQuery_GetMetricDataResponse_S() => UnmarshallXml(_getMetricRespSBytes);
    [Benchmark] public void awsQuery_GetMetricDataResponse_M() => UnmarshallXml(_getMetricRespMBytes);
    [Benchmark] public void awsQuery_GetMetricDataResponse_L() => UnmarshallXml(_getMetricRespLBytes);

    private void UnmarshallXml(byte[] bytes)
    {
        using var stream = new MemoryStream(bytes);
        var wr = new WebResponseData { ContentType = "text/xml", Headers = { { "x-amzn-RequestId", "test-id" }, { "Content-Length", bytes.Length.ToString() }, { "Content-Type", "text/xml" } } };
        using var ctx = new XmlUnmarshallerContext(stream, false, wr);
        GetMetricDataResponseUnmarshaller.Instance.Unmarshall(ctx);
    }
}
