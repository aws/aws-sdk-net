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

using Amazon.RestXmlDataPlane.Model;
using Amazon.RestXmlDataPlane.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using BenchmarkDotNet.Attributes;
using Fixtures = AWSSDK.Benchmarks.Serde.ModelFixtures.RestXml;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// BenchmarkDotNet benchmarks for REST XML protocol serialization/deserialization.
/// 10 test cases: CopyObject request/response, PutObject S/M/L, GetObject S/M/L,
/// with payloads from the shared benchmark models.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(SerdeBenchmarkConfig))]
public class RestXmlBenchmarks
{
    private const string XmlContentType = "application/xml";

    private CopyObjectRequest _copyObjectBaseline = null!;
    private CopyObjectRequest _copyObjectMedium = null!;
    private PutObjectRequest _putObjectS = null!;
    private PutObjectRequest _putObjectM = null!;
    private PutObjectRequest _putObjectL = null!;

    // Cached unmarshaller instance to avoid reflection overhead during measurement
    private IResponseUnmarshaller<AmazonWebServiceResponse, UnmarshallerContext> _copyObjectUnmarshaller = null!;

    [GlobalSetup]
    public void Setup()
    {
        _copyObjectBaseline = Fixtures.CopyObjectRequest_Baseline();
        _copyObjectMedium = Fixtures.CopyObjectRequest_M();
        _putObjectS = Fixtures.PutObject_S();
        _putObjectM = Fixtures.PutObject_M();
        _putObjectL = Fixtures.PutObject_L();

        _copyObjectUnmarshaller = GetUnmarshallerInstance(typeof(CopyObjectResponseUnmarshaller));
    }

    private static IResponseUnmarshaller<AmazonWebServiceResponse, UnmarshallerContext> GetUnmarshallerInstance(Type unmarshallerType)
    {
        return (IResponseUnmarshaller<AmazonWebServiceResponse, UnmarshallerContext>)
            unmarshallerType.GetMethod("GetInstance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public)!.Invoke(null, null)!;
    }

    private static void Unmarshall(IResponseUnmarshaller<AmazonWebServiceResponse, UnmarshallerContext> unmarshaller,
        byte[] body, IReadOnlyDictionary<string, string>? headers, string contentType = XmlContentType)
    {
        using var stream = new MemoryStream(body);
        using var ctx = new XmlUnmarshallerContext(stream, false, TestDataHelpers.CreateResponseData(body, contentType, headers));
        unmarshaller.Unmarshall(ctx);
    }

    [Benchmark] public long restXml_CopyObjectRequest_Baseline() => TestDataHelpers.GetContentLengthAndDispose(CopyObjectRequestMarshaller.Instance.Marshall(_copyObjectBaseline));
    [Benchmark] public long restXml_CopyObjectRequest_M() => TestDataHelpers.GetContentLengthAndDispose(CopyObjectRequestMarshaller.Instance.Marshall(_copyObjectMedium));
    [Benchmark] public void restXml_CopyObjectOutput_Baseline() => Unmarshall(_copyObjectUnmarshaller, Fixtures.CopyObjectOutput_Baseline, Fixtures.CopyObjectOutput_Baseline_Headers);
    [Benchmark] public void restXml_CopyObjectOutput_M() => Unmarshall(_copyObjectUnmarshaller, Fixtures.CopyObjectOutput_M, Fixtures.CopyObjectOutput_M_Headers);
    [Benchmark] public long restXml_PutObject_S() { _putObjectS.Body.Position = 0; return TestDataHelpers.GetContentLengthAndDispose(PutObjectRequestMarshaller.Instance.Marshall(_putObjectS)); }
    [Benchmark] public long restXml_PutObject_M() { _putObjectM.Body.Position = 0; return TestDataHelpers.GetContentLengthAndDispose(PutObjectRequestMarshaller.Instance.Marshall(_putObjectM)); }
    [Benchmark] public long restXml_PutObject_L() { _putObjectL.Body.Position = 0; return TestDataHelpers.GetContentLengthAndDispose(PutObjectRequestMarshaller.Instance.Marshall(_putObjectL)); }
    [Benchmark] public void restXml_GetObject_S() => Unmarshall(GetObjectResponseUnmarshaller.Instance, Fixtures.GetObject_S, Fixtures.GetObject_S_Headers, "application/octet-stream");
    [Benchmark] public void restXml_GetObject_M() => Unmarshall(GetObjectResponseUnmarshaller.Instance, Fixtures.GetObject_M, Fixtures.GetObject_M_Headers, "application/octet-stream");
    [Benchmark] public void restXml_GetObject_L() => Unmarshall(GetObjectResponseUnmarshaller.Instance, Fixtures.GetObject_L, Fixtures.GetObject_L_Headers, "application/octet-stream");
}
