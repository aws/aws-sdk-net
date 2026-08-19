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
using Amazon.RestJsonDataPlane.Model;
using Amazon.RestJsonDataPlane.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// BenchmarkDotNet benchmarks for RestJson1 protocol serialization/deserialization.
/// 10 test cases: CopyObject request/response, PutObject S/M/L, GetObject S/M/L.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(SerdeBenchmarkConfig))]
public class RestJson1Benchmarks
{
    // Request objects
    private CopyObjectRequest _copyObjectBaseline = null!;
    private CopyObjectRequest _copyObjectMedium = null!;
    private PutObjectRequest _putObjectS = null!;
    private PutObjectRequest _putObjectM = null!;
    private PutObjectRequest _putObjectL = null!;

    // Response data
    private byte[] _copyOutputBaselineBytes = null!;
    private byte[] _copyOutputMBytes = null!;
    private byte[] _getObjectSBytes = null!;
    private byte[] _getObjectMBytes = null!;
    private byte[] _getObjectLBytes = null!;
    private WebResponseData _getObjectHeaders = null!;

    [GlobalSetup]
    public void Setup()
    {
        _copyObjectBaseline = new CopyObjectRequest
        {
            Bucket = "bucket", Key = "key", CopySource = "source-bucket/source-key"
        };

        _copyObjectMedium = new CopyObjectRequest
        {
            Bucket = "my-destination-bucket",
            Key = "destination/path/to/my-object.dat",
            CopySource = "my-source-bucket/source/path/to/original-object.dat",
            ACL = "bucket-owner-full-control",
            CacheControl = "max-age=86400",
            ContentDisposition = "attachment; filename=\"report.pdf\"",
            ContentEncoding = "gzip",
            ContentLanguage = "en-US",
            ContentType = "application/octet-stream",
            MetadataDirective = "REPLACE",
            TaggingDirective = "REPLACE",
            ServerSideEncryption = "aws:kms",
            StorageClass = "STANDARD_IA",
            Tagging = "env=prod&team=sdk",
            WebsiteRedirectLocation = "/redirect",
            GrantFullControl = "id=account-id-1",
            GrantRead = "id=account-id-2",
            ExpectedBucketOwner = "123456789012",
            ExpectedSourceBucketOwner = "210987654321",
            SSEKMSKeyId = "arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012",
            SSEKMSEncryptionContext = "{\"context\":\"value\"}",
            BucketKeyEnabled = true,
            CopySourceIfMatch = "\"etag-value\"",
            CopySourceIfNoneMatch = "\"old-etag\"",
            CopySourceIfModifiedSince = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            CopySourceIfUnmodifiedSince = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ObjectLockMode = "GOVERNANCE",
            ObjectLockRetainUntilDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ObjectLockLegalHoldStatus = "ON",
            RequestPayer = "requester"
        };

        _putObjectS = CreatePutObjectRequest(1024);
        _putObjectM = CreatePutObjectRequest(1024 * 100);
        _putObjectL = CreatePutObjectRequest(1024 * 1024);

        _copyOutputBaselineBytes = Encoding.UTF8.GetBytes("{}");
        _copyOutputMBytes = Encoding.UTF8.GetBytes(
            "{\"ETag\":\"\\\"d41d8cd98f00b204e9800998ecf8427e\\\"\",\"LastModified\":1704067200," +
            "\"ChecksumCRC32\":\"abc123\",\"ChecksumCRC32C\":\"def456\",\"ChecksumSHA1\":\"ghi789\"," +
            "\"ChecksumSHA256\":\"jkl012\",\"ChecksumType\":\"FULL_OBJECT\",\"ServerSideEncryption\":\"aws:kms\"," +
            "\"VersionId\":\"v1.0\",\"SSEKMSKeyId\":\"arn:aws:kms:us-east-1:123456789012:key/key-id\"," +
            "\"SSEKMSEncryptionContext\":\"{}\",\"BucketKeyEnabled\":true,\"RequestCharged\":\"requester\"}");

        _getObjectSBytes = new byte[1024];
        Random.Shared.NextBytes(_getObjectSBytes);
        _getObjectMBytes = new byte[1024 * 100];
        Random.Shared.NextBytes(_getObjectMBytes);
        _getObjectLBytes = new byte[1024 * 1024];
        Random.Shared.NextBytes(_getObjectLBytes);

        _getObjectHeaders = new WebResponseData
        {
            Headers = {
                { "x-amzn-RequestId", "test-request-id" },
                { "Content-Type", "application/octet-stream" },
                { "ETag", "\"d41d8cd98f00b204e9800998ecf8427e\"" },
                { "Last-Modified", "Mon, 01 Jan 2024 00:00:00 GMT" }
            }
        };
    }

    private static PutObjectRequest CreatePutObjectRequest(int bodySize) => new PutObjectRequest
    {
        Bucket = "my-benchmark-bucket",
        Key = "benchmark/test-object.dat",
        ContentType = "application/octet-stream",
        Body = new MemoryStream(new byte[bodySize])
    };

    // --- CopyObject Request (serialization) ---
    [Benchmark] public long restJson1_CopyObjectRequest_Baseline() =>
        TestDataHelpers.GetContentLengthAndDispose(CopyObjectRequestMarshaller.Instance.Marshall(_copyObjectBaseline));

    [Benchmark] public long restJson1_CopyObjectRequest_M() =>
        TestDataHelpers.GetContentLengthAndDispose(CopyObjectRequestMarshaller.Instance.Marshall(_copyObjectMedium));

    // --- CopyObject Response (deserialization) ---
    [Benchmark]
    public void restJson1_CopyObjectOutput_Baseline()
    {
        using var stream = new MemoryStream(_copyOutputBaselineBytes);
        var wr = new WebResponseData { Headers = { { "x-amzn-RequestId", "test-id" }, { "Content-Length", _copyOutputBaselineBytes.Length.ToString() }, { "Content-Type", "application/json" } } };
        using var ctx = new JsonUnmarshallerContext(stream, false, wr);
        CopyObjectResponseUnmarshaller.Instance.Unmarshall(ctx);
    }

    [Benchmark]
    public void restJson1_CopyObjectOutput_M()
    {
        using var stream = new MemoryStream(_copyOutputMBytes);
        var wr = new WebResponseData { Headers = { { "x-amzn-RequestId", "test-id" }, { "Content-Length", _copyOutputMBytes.Length.ToString() }, { "Content-Type", "application/json" } } };
        using var ctx = new JsonUnmarshallerContext(stream, false, wr);
        CopyObjectResponseUnmarshaller.Instance.Unmarshall(ctx);
    }

    // --- PutObject Request (serialization) ---
    [Benchmark] public long restJson1_PutObject_S() { _putObjectS.Body.Position = 0; return TestDataHelpers.GetContentLengthAndDispose(PutObjectRequestMarshaller.Instance.Marshall(_putObjectS)); }
    [Benchmark] public long restJson1_PutObject_M() { _putObjectM.Body.Position = 0; return TestDataHelpers.GetContentLengthAndDispose(PutObjectRequestMarshaller.Instance.Marshall(_putObjectM)); }
    [Benchmark] public long restJson1_PutObject_L() { _putObjectL.Body.Position = 0; return TestDataHelpers.GetContentLengthAndDispose(PutObjectRequestMarshaller.Instance.Marshall(_putObjectL)); }

    // --- GetObject Response (deserialization) ---
    [Benchmark]
    public void restJson1_GetObject_S()
    {
        using var stream = new MemoryStream(_getObjectSBytes);
        _getObjectHeaders.Headers["Content-Length"] = _getObjectSBytes.Length.ToString();
        using var ctx = new JsonUnmarshallerContext(stream, false, _getObjectHeaders);
        GetObjectResponseUnmarshaller.Instance.Unmarshall(ctx);
    }

    [Benchmark]
    public void restJson1_GetObject_M()
    {
        using var stream = new MemoryStream(_getObjectMBytes);
        _getObjectHeaders.Headers["Content-Length"] = _getObjectMBytes.Length.ToString();
        using var ctx = new JsonUnmarshallerContext(stream, false, _getObjectHeaders);
        GetObjectResponseUnmarshaller.Instance.Unmarshall(ctx);
    }

    [Benchmark]
    public void restJson1_GetObject_L()
    {
        using var stream = new MemoryStream(_getObjectLBytes);
        _getObjectHeaders.Headers["Content-Length"] = _getObjectLBytes.Length.ToString();
        using var ctx = new JsonUnmarshallerContext(stream, false, _getObjectHeaders);
        GetObjectResponseUnmarshaller.Instance.Unmarshall(ctx);
    }
}
