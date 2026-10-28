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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Signing
{
    /// <summary>
    /// Pins SigV4 output to values produced by the signer before the formatting and crypto-reuse changes.
    /// </summary>
    [TestClass]
    [TestCategory("Core")]
    [TestCategory("Signer")]
    public class AWS4SignerOutputPinningTests
    {
        private const string AccessKey = "AKIDEXAMPLE";
        private const string SecretKey = "wJalrXUtnFEMI/K7MDENG+bPxRfiCYEXAMPLEKEY";
        private static readonly DateTime SignedAt = new DateTime(2026, 10, 5, 3, 14, 15, DateTimeKind.Utc);

        private sealed class ExpectedSignature
        {
            public ExpectedSignature(string name, string authorization, string contentSha256, string canonicalRequest, string stringToSign)
                => (Name, Authorization, ContentSha256, CanonicalRequest, StringToSign) = (name, authorization, contentSha256, canonicalRequest, stringToSign);

            public string Name { get; }
            public string Authorization { get; }
            public string ContentSha256 { get; }
            public string CanonicalRequest { get; }
            public string StringToSign { get; }
        }

        private static readonly ExpectedSignature[] Expected =
        {
            new ExpectedSignature("JsonPostMixedCaseHeaders",
                "AWS4-HMAC-SHA256 Credential=AKIDEXAMPLE/20261005/us-east-1/service/aws4_request, SignedHeaders=content-length;content-type;host;x-amz-content-sha256;x-amz-date;x-amz-security-token;x-amz-target, Signature=21e2ecce94fe4e80c0f538a70fbc8c787ff3c3f70808675177f8a34470f6ea3c",
                "5aa68099608485838073440e0ca5c42dc1d45f423df8239cfbbdf81b2eed0fb5",
                "POST\n/\n\ncontent-length:57\ncontent-type:application/x-amz-json-1.0\nhost:dynamodb.us-east-1.amazonaws.com\nx-amz-content-sha256:5aa68099608485838073440e0ca5c42dc1d45f423df8239cfbbdf81b2eed0fb5\nx-amz-date:20261005T031415Z\nx-amz-security-token:IQoJb3JpZ2luX2VjEXAMPLE/+=TOKEN==\nx-amz-target:DynamoDB_20120810.GetItem\n\ncontent-length;content-type;host;x-amz-content-sha256;x-amz-date;x-amz-security-token;x-amz-target\n5aa68099608485838073440e0ca5c42dc1d45f423df8239cfbbdf81b2eed0fb5",
                "AWS4-HMAC-SHA256\n20261005T031415Z\n20261005/us-east-1/service/aws4_request\nec2970096dec466672e3f493315c23b0d58d929836983d4904430bd6a484077c"),
            new ExpectedSignature("EmptyBodyGet",
                "AWS4-HMAC-SHA256 Credential=AKIDEXAMPLE/20261005/us-east-1/service/aws4_request, SignedHeaders=host;range;x-amz-content-sha256;x-amz-date, Signature=1cc96195f468d741cb247641f3bcd35b3ab304aba4ee5d40f5c7830755e5db04",
                "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855",
                "GET\n/test.txt\n\nhost:examplebucket.s3.amazonaws.com\nrange:bytes=0-9\nx-amz-content-sha256:e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855\nx-amz-date:20261005T031415Z\n\nhost;range;x-amz-content-sha256;x-amz-date\ne3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855",
                "AWS4-HMAC-SHA256\n20261005T031415Z\n20261005/us-east-1/service/aws4_request\nece737ae293885e8ba63c928c747da7aaa0ce48e4c9978d4de48abfe49f50b06"),
            new ExpectedSignature("QueryStringAndSubResources",
                "AWS4-HMAC-SHA256 Credential=AKIDEXAMPLE/20261005/us-east-1/service/aws4_request, SignedHeaders=host;x-amz-content-sha256;x-amz-date, Signature=6af857020f855c28060c6a73e86eca0a71c0962b274293ad338a5b49cac0079f",
                "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855",
                "GET\n/path/with%2520space/\nAction=ListUsers&Param1=a%2Fb%2Bc%3Dd%26e&Param2=value%20two&acl=&empty=&versionId=3%2FL4kqtJlcpXroDTDmJ%2BrmSpXd3dIbrHY%2BMTRCxf3vjVBH40Nr8X8gdRQBpUMLUo\nhost:dynamodb.us-east-1.amazonaws.com\nx-amz-content-sha256:e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855\nx-amz-date:20261005T031415Z\n\nhost;x-amz-content-sha256;x-amz-date\ne3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855",
                "AWS4-HMAC-SHA256\n20261005T031415Z\n20261005/us-east-1/service/aws4_request\nca7a364146487485bd56cf12f77d72d56d9ef6cb5e3da02c1c06bd1be6de62e4"),
            new ExpectedSignature("BodyFromParameters",
                "AWS4-HMAC-SHA256 Credential=AKIDEXAMPLE/20261005/us-east-1/service/aws4_request, SignedHeaders=content-type;host;x-amz-content-sha256;x-amz-date, Signature=911d0328d4586f7d74b1ffb5c8ddecf35b90c811bf99250d3839ff3e1fd06b86",
                "ab821ae955788b0e33ebd34c208442ccfc2d406e2edc5e7a39bd6458fbb4f843",
                "POST\n/\n\ncontent-type:application/x-www-form-urlencoded; charset=utf-8\nhost:sts.amazonaws.com\nx-amz-content-sha256:ab821ae955788b0e33ebd34c208442ccfc2d406e2edc5e7a39bd6458fbb4f843\nx-amz-date:20261005T031415Z\n\ncontent-type;host;x-amz-content-sha256;x-amz-date\nab821ae955788b0e33ebd34c208442ccfc2d406e2edc5e7a39bd6458fbb4f843",
                "AWS4-HMAC-SHA256\n20261005T031415Z\n20261005/us-east-1/service/aws4_request\n53886594796ce458403444497701ed9073c055176bb33aa812c7c7d531bec27e")
        };

        private static ExpectedSignature GetExpected(string name) => Expected.Single(e => e.Name == name);

        private static MockClientConfig NewConfig() => new MockClientConfig { AuthenticationRegion = "us-east-1", AuthenticationServiceName = "service" };

        private class PinningRequest : AmazonWebServiceRequest { }

        private static IRequest Build(string name)
        {
            var r = new DefaultRequest(new PinningRequest(), "TestService");
            r.Endpoint = new Uri("https://dynamodb.us-east-1.amazonaws.com");
            r.HttpMethod = "POST";
            r.ResourcePath = "/";
            switch (name)
            {
                case "JsonPostMixedCaseHeaders":
                    r.Headers["Content-Type"] = "application/x-amz-json-1.0";
                    r.Headers["X-Amz-Target"] = "DynamoDB_20120810.GetItem";
                    r.Headers["X-Amz-Security-Token"] = "IQoJb3JpZ2luX2VjEXAMPLE/+=TOKEN==";
                    r.Headers["Content-Length"] = "57";
                    r.Content = Encoding.UTF8.GetBytes("{\"TableName\":\"T\",\"Key\":{\"id\":{\"S\":\"0123456789abcdef\"}}}");
                    break;
                case "EmptyBodyGet":
                    r.HttpMethod = "GET";
                    r.Endpoint = new Uri("https://examplebucket.s3.amazonaws.com");
                    r.ResourcePath = "/test.txt";
                    r.Headers["Range"] = "bytes=0-9";
                    break;
                case "QueryStringAndSubResources":
                    r.HttpMethod = "GET";
                    r.UseQueryString = true;
                    r.ResourcePath = "/path/with space/";
                    r.Parameters["Param2"] = "value two";
                    r.Parameters["Param1"] = "a/b+c=d&e";
                    r.Parameters["empty"] = "";
                    r.Parameters["Action"] = "ListUsers";
                    r.AddSubResource("acl");
                    r.AddSubResource("versionId", "3/L4kqtJlcpXroDTDmJ+rmSpXd3dIbrHY+MTRCxf3vjVBH40Nr8X8gdRQBpUMLUo");
                    break;
                case "BodyFromParameters":
                    r.Endpoint = new Uri("https://sts.amazonaws.com");
                    r.Headers["Content-Type"] = "application/x-www-form-urlencoded; charset=utf-8";
                    r.Parameters["Action"] = "GetCallerIdentity";
                    r.Parameters["Version"] = "2011-06-15";
                    break;
            }
            return r;
        }

        [TestMethod]
        [DataRow("JsonPostMixedCaseHeaders")]
        [DataRow("EmptyBodyGet")]
        [DataRow("QueryStringAndSubResources")]
        [DataRow("BodyFromParameters")]
        public void SignRequest_MatchesPinnedOutput(string name)
        {
            var expected = GetExpected(name);
            var request = Build(name);
            var metrics = new RequestMetrics { IsEnabled = true };

            var result = new AWS4Signer().SignRequest(request, NewConfig(), metrics, AccessKey, SecretKey, SignedAt);

            Assert.AreEqual(expected.Authorization, result.ForAuthorizationHeader);
            StringAssert.EndsWith(expected.Authorization, ", Signature=" + result.Signature);
            Assert.AreEqual("20261005T031415Z", result.ISO8601DateTime);
            Assert.AreEqual("20261005", result.ISO8601Date);
            Assert.AreEqual("20261005/us-east-1/service/aws4_request", result.Scope);
            Assert.AreEqual(expected.ContentSha256, request.Headers[HeaderKeys.XAmzContentSha256Header]);
            Assert.AreEqual(expected.CanonicalRequest, metrics.Properties[Metric.CanonicalRequest].Single().ToString());
            var stringToSign = metrics.Properties[Metric.StringToSign].Single();
            Assert.IsInstanceOfType(stringToSign, typeof(StringBuilder));
            Assert.AreEqual(expected.StringToSign, stringToSign.ToString());

            Assert.AreEqual(expected.Authorization, new AWS4Signer().SignRequest(Build(name), NewConfig(), null, AccessKey, SecretKey, SignedAt).ForAuthorizationHeader);
            var disabledMetrics = new RequestMetrics();
            Assert.AreEqual(expected.Authorization, new AWS4Signer().SignRequest(Build(name), NewConfig(), disabledMetrics, AccessKey, SecretKey, SignedAt).ForAuthorizationHeader);
            Assert.AreEqual(0, disabledMetrics.Properties.Count);
        }

        [TestMethod]
        public void Sign_SetsAuthorizationAndDateHeaders()
        {
            var request = Build("JsonPostMixedCaseHeaders");
            new AWS4Signer().Sign(request, NewConfig(), null, new BasicAWSCredentials(AccessKey, SecretKey));
            var signedAt = request.AWS4SignerResult.DateTime;

            Assert.AreEqual(SignJsonPost(NewConfig(), signedAt), request.Headers[HeaderKeys.AuthorizationHeader]);
            Assert.AreEqual(request.AWS4SignerResult.ForAuthorizationHeader, request.Headers[HeaderKeys.AuthorizationHeader]);
            Assert.AreEqual(signedAt.ToUniversalTime().ToString(AWSSDKUtils.ISO8601BasicDateTimeFormat, CultureInfo.InvariantCulture), request.Headers[HeaderKeys.XAmzDateHeader]);
        }

        [TestMethod]
        public void ComputeSignature_Static_MatchesPinnedOutput()
        {
            var canonicalRequest = "GET\n/\nAction=ListUsers&Version=2010-05-08\nhost:iam.amazonaws.com\nx-amz-date:20150830T123600Z\n\nhost;x-amz-date\n" + AWS4Signer.EmptyBodySha256;
            var result = AWS4Signer.ComputeSignature(AccessKey, SecretKey, "eu-west-1", new DateTime(2015, 8, 30, 12, 36, 0, DateTimeKind.Utc),
                "iam", "host;x-amz-date", canonicalRequest);

            Assert.AreEqual("AWS4-HMAC-SHA256 Credential=AKIDEXAMPLE/20150830/eu-west-1/iam/aws4_request, SignedHeaders=host;x-amz-date, Signature=529a6163bbce1e97a69a8e01c0d5e8bf9b7f6f22060b1a813a4c18ea54cccc0b", result.ForAuthorizationHeader);
        }

        [TestMethod]
        public void PreSignedUrlSigner_MatchesPinnedOutput()
        {
            var result = AWS4PreSignedUrlSigner.SignRequest(Build("QueryStringAndSubResources"), null, null, AccessKey, SecretKey, "s3", "us-west-2", SignedAt);

            Assert.AreEqual("X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIDEXAMPLE%2F20261005%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20261005T031415Z&X-Amz-SignedHeaders=host&X-Amz-Signature=5fbdd001fa3c1063323d15b1a5820f92976af5b32c59d1f51248f6fc283ddbe3", result.ForQueryParameters);
        }

        [TestMethod]
        public void SignRequest_ConcurrentCallers_ProduceIdenticalSignatures()
        {
            var expected = GetExpected("JsonPostMixedCaseHeaders").Authorization;
            var results = new string[2000];
            Parallel.For(0, results.Length, new ParallelOptions { MaxDegreeOfParallelism = 8 }, i => results[i] = SignJsonPost(NewConfig(), SignedAt));

            foreach (var result in results)
                Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SignRequest_AlternatingScopes_ProduceIndependentSignatures()
        {
            var otherConfig = new MockClientConfig { AuthenticationRegion = "eu-west-1", AuthenticationServiceName = "other" };
            var expected = GetExpected("JsonPostMixedCaseHeaders").Authorization;
            var otherExpected = SignJsonPost(otherConfig, SignedAt);
            Assert.AreNotEqual(expected, otherExpected);

            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(expected, SignJsonPost(NewConfig(), SignedAt));
                Assert.AreEqual(otherExpected, SignJsonPost(otherConfig, SignedAt));
            }
        }

        [TestMethod]
        public void SignRequest_DateChangeAndEviction_SignWithTheCurrentKey()
        {
            // The cached key and its pooled HMACs are replaced at the UTC date change and evicted after 100 scopes.
            var config = NewConfig();
            var expected = GetExpected("JsonPostMixedCaseHeaders").Authorization;
            var nextDay = SignedAt.AddDays(1);
            var nextDayExpected = SignAndVerifyIndependently(Build("JsonPostMixedCaseHeaders"), nextDay);
            StringAssert.Contains(nextDayExpected, "/20261006/us-east-1/service/aws4_request");

            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(expected, SignJsonPost(config, SignedAt));
                Assert.AreEqual(nextDayExpected, SignJsonPost(config, nextDay));
            }

            for (int i = 0; i < 150; i++)
                SignJsonPost(new MockClientConfig { AuthenticationRegion = "eviction-" + i.ToString(CultureInfo.InvariantCulture), AuthenticationServiceName = "service" }, SignedAt);
            Assert.AreEqual(expected, SignJsonPost(config, SignedAt));

            var results = new string[2000];
            Parallel.For(0, results.Length, new ParallelOptions { MaxDegreeOfParallelism = 8 }, i => results[i] = SignJsonPost(config, i % 2 == 0 ? SignedAt : nextDay));
            for (int i = 0; i < results.Length; i++)
                Assert.AreEqual(i % 2 == 0 ? expected : nextDayExpected, results[i], "call " + i.ToString(CultureInfo.InvariantCulture));
        }

        [TestMethod]
        [DataRow("T", 1500)]
        [DataRow("\u20AC", 400)]
        [DataRow("caf\u00E9 \u4E2D\u6587", 1)]
        public void SignRequest_LongAndMultiByteCanonicalRequests_MatchIndependentComputation(string unit, int count)
        {
            // Longer than the 1,024-byte stack buffer, longer only in UTF-8 bytes, and a short multi-byte value.
            var value = string.Concat(Enumerable.Repeat(unit, count));
            var request = Build("JsonPostMixedCaseHeaders");
            request.Headers["x-amz-meta-value"] = value;

            var authorization = SignAndVerifyIndependently(request, SignedAt, value);

            Assert.AreEqual(authorization, new AWS4Signer().SignRequest(request, NewConfig(), null, AccessKey, SecretKey, SignedAt).ForAuthorizationHeader);
        }

        [TestMethod]
        public void FormatDateTime_MatchesDateTimeToString()
        {
            var dates = new List<DateTime>
            {
                new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                new DateTime(999, 12, 31, 23, 59, 59, DateTimeKind.Utc),
                new DateTime(2015, 8, 30, 12, 36, 0, DateTimeKind.Utc),
                new DateTime(2026, 10, 5, 3, 14, 15, 999, DateTimeKind.Utc),
                new DateTime(9999, 12, 31, 23, 59, 59, DateTimeKind.Utc),
                new DateTime(2024, 2, 29, 9, 5, 7, DateTimeKind.Local),
                new DateTime(2024, 2, 29, 9, 5, 7, DateTimeKind.Unspecified),
                DateTime.UtcNow,
                DateTime.Now,
            };
            var random = new Random(4242);
            for (int i = 0; i < 500; i++)
                dates.Add(new DateTime(DateTime.MinValue.Ticks + (long)(random.NextDouble() * (DateTime.MaxValue.Ticks - DateTime.MinValue.Ticks - TimeSpan.TicksPerDay)) + TimeSpan.TicksPerDay / 2, DateTimeKind.Utc));

            foreach (var date in dates)
            {
                foreach (var format in new[] { AWSSDKUtils.ISO8601BasicDateTimeFormat, AWSSDKUtils.ISO8601BasicDateFormat })
                    Assert.AreEqual(date.ToUniversalTime().ToString(format, CultureInfo.InvariantCulture), AWS4Signer.FormatDateTime(date, format), date.ToString("o", CultureInfo.InvariantCulture));
            }
            Assert.AreEqual("2015-08-30", AWS4Signer.FormatDateTime(new DateTime(2015, 8, 30, 12, 36, 0, DateTimeKind.Utc), "yyyy-MM-dd"));
        }

        [TestMethod]
        public void EmptyBodySha256_IsSha256OfEmptyInput()
        {
            using (var sha256 = SHA256.Create())
                Assert.AreEqual(AWS4Signer.EmptyBodySha256, AWSSDKUtils.ToHex(sha256.ComputeHash(new byte[0]), true));
        }

        private static string SignJsonPost(IClientConfig config, DateTime signedAt)
            => new AWS4Signer().SignRequest(Build("JsonPostMixedCaseHeaders"), config, null, AccessKey, SecretKey, signedAt).ForAuthorizationHeader;

        /// <summary>
        /// Signs with metrics on and checks the canonical request hash and signature against SHA-256 and HMAC-SHA256 computed outside the signer.
        /// </summary>
        private static string SignAndVerifyIndependently(IRequest request, DateTime signedAt, string expectedInCanonicalRequest = null)
        {
            var metrics = new RequestMetrics { IsEnabled = true };
            var result = new AWS4Signer().SignRequest(request, NewConfig(), metrics, AccessKey, SecretKey, signedAt);
            var canonicalRequest = metrics.Properties[Metric.CanonicalRequest].Single().ToString();
            var stringToSign = metrics.Properties[Metric.StringToSign].Single().ToString();
            if (expectedInCanonicalRequest != null)
                StringAssert.Contains(canonicalRequest, expectedInCanonicalRequest);

            using (var sha256 = SHA256.Create())
                StringAssert.EndsWith(stringToSign, "\n" + AWSSDKUtils.ToHex(sha256.ComputeHash(Encoding.UTF8.GetBytes(canonicalRequest)), true));

            var scope = result.Scope.Split('/');
            using (var hmac = new HMACSHA256(AWS4Signer.ComposeSigningKey(SecretKey, scope[1], scope[0], scope[2])))
                Assert.AreEqual(AWSSDKUtils.ToHex(hmac.ComputeHash(Encoding.UTF8.GetBytes(stringToSign)), true), result.Signature);

            return result.ForAuthorizationHeader;
        }
    }
}
