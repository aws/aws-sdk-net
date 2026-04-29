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
using Amazon.RestXmlDataPlane.Model;
using Amazon.RestXmlDataPlane.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// BenchmarkDotNet benchmarks for REST XML protocol serialization/deserialization.
/// 10 test cases: CopyObject request/response, PutObject S/M/L, GetObject S/M/L.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(SerdeBenchmarkConfig))]
public class RestXmlBenchmarks
{
    private CopyObjectRequest _copyObjectBaseline = null!;
    private CopyObjectRequest _copyObjectMedium = null!;
    private PutObjectRequest _putObjectS = null!;
    private PutObjectRequest _putObjectM = null!;
    private PutObjectRequest _putObjectL = null!;
    private byte[] _copyOutputBaselineBytes = null!;
    private byte[] _copyOutputMBytes = null!;
    private byte[] _getObjectSBytes = null!;
    private byte[] _getObjectMBytes = null!;
    private byte[] _getObjectLBytes = null!;
    private WebResponseData _getObjectHeaders = null!;

    [GlobalSetup]
    public void Setup()
    {
        _copyObjectBaseline = new CopyObjectRequest { Bucket = "bucket", Key = "key", CopySource = "source-bucket/source-key" };
        _copyObjectMedium = new CopyObjectRequest
        {
            Bucket = "my-destination-bucket", Key = "destination/path/to/my-object.dat",
            CopySource = "my-source-bucket/source/path/to/original-object.dat",
            ACL = "bucket-owner-full-control", CacheControl = "max-age=86400",
            ContentDisposition = "attachment; filename=\"report.pdf\"", ContentEncoding = "gzip",
            ContentLanguage = "en-US", ContentType = "application/octet-stream",
            MetadataDirective = "REPLACE", TaggingDirective = "REPLACE",
            ServerSideEncryption = "aws:kms", StorageClass = "STANDARD_IA",
            Tagging = "env=prod&team=sdk", WebsiteRedirectLocation = "/redirect",
            GrantFullControl = "id=account-id-1", GrantRead = "id=account-id-2",
            ExpectedBucketOwner = "123456789012", ExpectedSourceBucketOwner = "210987654321",
            SSEKMSKeyId = "arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012",
            SSEKMSEncryptionContext = "{\"context\":\"value\"}", BucketKeyEnabled = true,
            CopySourceIfMatch = "\"etag-value\"", CopySourceIfNoneMatch = "\"old-etag\"",
            CopySourceIfModifiedSince = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            CopySourceIfUnmodifiedSince = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ObjectLockMode = "GOVERNANCE", ObjectLockRetainUntilDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ObjectLockLegalHoldStatus = "ON", RequestPayer = "requester"
        };
        _putObjectS = new PutObjectRequest { Bucket = "b", Key = "k", ContentType = "application/octet-stream", Body = new MemoryStream(new byte[1024]) };
        _putObjectM = new PutObjectRequest { Bucket = "b", Key = "k", ContentType = "application/octet-stream", Body = new MemoryStream(new byte[1024 * 100]) };
        _putObjectL = new PutObjectRequest { Bucket = "b", Key = "k", ContentType = "application/octet-stream", Body = new MemoryStream(new byte[1024 * 1024]) };
        _copyOutputBaselineBytes = Encoding.UTF8.GetBytes("<CopyObjectResult/>");
        _copyOutputMBytes = Encoding.UTF8.GetBytes("<CopyObjectResult><ETag>\"d41d8cd98f00b204e9800998ecf8427e\"</ETag><LastModified>2024-01-01T00:00:00Z</LastModified><ChecksumCRC32>abc123</ChecksumCRC32><ChecksumSHA256>jkl012</ChecksumSHA256><ChecksumType>FULL_OBJECT</ChecksumType></CopyObjectResult>");
        _getObjectSBytes = new byte[1024]; Random.Shared.NextBytes(_getObjectSBytes);
        _getObjectMBytes = new byte[1024 * 100]; Random.Shared.NextBytes(_getObjectMBytes);
        _getObjectLBytes = new byte[1024 * 1024]; Random.Shared.NextBytes(_getObjectLBytes);
        _getObjectHeaders = new WebResponseData { ContentType = "application/octet-stream", Headers = { { "x-amzn-RequestId", "test-id" }, { "Content-Type", "application/octet-stream" }, { "ETag", "\"d41d8cd98f00b204e9800998ecf8427e\"" }, { "Last-Modified", "Mon, 01 Jan 2024 00:00:00 GMT" } } };
    }

    private void UnmarshallXml(byte[] bytes, Type unmarshallerType)
    {
        using var stream = new MemoryStream(bytes);
        var wr = new WebResponseData { ContentType = "application/xml", Headers = { { "x-amzn-RequestId", "test-id" }, { "Content-Length", bytes.Length.ToString() }, { "Content-Type", "application/xml" } } };
        var unmarshaller = (IResponseUnmarshaller<AmazonWebServiceResponse, UnmarshallerContext>)unmarshallerType.GetMethod("GetInstance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public)!.Invoke(null, null)!;
        var ctx = new XmlUnmarshallerContext(stream, false, wr);
        unmarshaller.Unmarshall(ctx);
    }

    [Benchmark] public void restXml_CopyObjectRequest_Baseline() => CopyObjectRequestMarshaller.Instance.Marshall(_copyObjectBaseline);
    [Benchmark] public void restXml_CopyObjectRequest_M() => CopyObjectRequestMarshaller.Instance.Marshall(_copyObjectMedium);
    [Benchmark] public void restXml_CopyObjectOutput_Baseline() => UnmarshallXml(_copyOutputBaselineBytes, typeof(CopyObjectResponseUnmarshaller));
    [Benchmark] public void restXml_CopyObjectOutput_M() => UnmarshallXml(_copyOutputMBytes, typeof(CopyObjectResponseUnmarshaller));
    [Benchmark] public void restXml_PutObject_S() { _putObjectS.Body.Position = 0; PutObjectRequestMarshaller.Instance.Marshall(_putObjectS); }
    [Benchmark] public void restXml_PutObject_M() { _putObjectM.Body.Position = 0; PutObjectRequestMarshaller.Instance.Marshall(_putObjectM); }
    [Benchmark] public void restXml_PutObject_L() { _putObjectL.Body.Position = 0; PutObjectRequestMarshaller.Instance.Marshall(_putObjectL); }

    [Benchmark]
    public void restXml_GetObject_S()
    {
        using var stream = new MemoryStream(_getObjectSBytes);
        _getObjectHeaders.Headers["Content-Length"] = _getObjectSBytes.Length.ToString();
        var ctx = new XmlUnmarshallerContext(stream, false, _getObjectHeaders);
        GetObjectResponseUnmarshaller.Instance.Unmarshall(ctx);
    }

    [Benchmark]
    public void restXml_GetObject_M()
    {
        using var stream = new MemoryStream(_getObjectMBytes);
        _getObjectHeaders.Headers["Content-Length"] = _getObjectMBytes.Length.ToString();
        var ctx = new XmlUnmarshallerContext(stream, false, _getObjectHeaders);
        GetObjectResponseUnmarshaller.Instance.Unmarshall(ctx);
    }

    [Benchmark]
    public void restXml_GetObject_L()
    {
        using var stream = new MemoryStream(_getObjectLBytes);
        _getObjectHeaders.Headers["Content-Length"] = _getObjectLBytes.Length.ToString();
        var ctx = new XmlUnmarshallerContext(stream, false, _getObjectHeaders);
        GetObjectResponseUnmarshaller.Instance.Unmarshall(ctx);
    }
}
