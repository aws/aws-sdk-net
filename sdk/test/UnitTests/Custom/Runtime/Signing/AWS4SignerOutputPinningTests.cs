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
    /// Pins the exact SigV4 output (Authorization header, payload hash, canonical request, string to sign)
    /// for representative requests. The expected values were produced by the signer before the
    /// allocation/formatting rewrite, so these tests guard byte-for-byte equivalence of the new code paths.
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
            {
                Name = name;
                Authorization = authorization;
                ContentSha256 = contentSha256;
                CanonicalRequest = canonicalRequest;
                StringToSign = stringToSign;
            }

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
            new ExpectedSignature("WhitespaceAndMultiValueHeaders",
                "AWS4-HMAC-SHA256 Credential=AKIDEXAMPLE/20261005/us-east-1/service/aws4_request, SignedHeaders=content-type;host;x-amz-content-sha256;x-amz-date;x-amz-meta-empty;x-amz-meta-inner;x-amz-meta-multivalue;x-amz-meta-newline;x-amz-meta-spaces;x-amz-meta-tabs;x-amz-meta-unicode;x_underscore, Signature=0e3996a4fe244bccf9f73cd88ff8aa86b6dfb0e89a62bd4927105764028c184c",
                "2cf24dba5fb0a30e26e83b2ac5b9e29e1b161e5c1fa7425e73043362938b9824",
                "POST\n/\n\ncontent-type:text/plain\nhost:dynamodb.us-east-1.amazonaws.com\nx-amz-content-sha256:2cf24dba5fb0a30e26e83b2ac5b9e29e1b161e5c1fa7425e73043362938b9824\nx-amz-date:20261005T031415Z\nx-amz-meta-empty:\nx-amz-meta-inner:a b c\nx-amz-meta-multivalue:v1,v2, v3, v4\nx-amz-meta-newline:line1 line2\nx-amz-meta-spaces:leading and trailing\nx-amz-meta-tabs:x\ty\nx-amz-meta-unicode:caf\u00e9 bar baz\nx_underscore:u\n\ncontent-type;host;x-amz-content-sha256;x-amz-date;x-amz-meta-empty;x-amz-meta-inner;x-amz-meta-multivalue;x-amz-meta-newline;x-amz-meta-spaces;x-amz-meta-tabs;x-amz-meta-unicode;x_underscore\n2cf24dba5fb0a30e26e83b2ac5b9e29e1b161e5c1fa7425e73043362938b9824",
                "AWS4-HMAC-SHA256\n20261005T031415Z\n20261005/us-east-1/service/aws4_request\n8606f8a01e66677c74b0bad878c07dfac7cdf0fe9c345d56aa301453ec375b04"),
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
            new ExpectedSignature("IgnoredHeadersPresent",
                "AWS4-HMAC-SHA256 Credential=AKIDEXAMPLE/20261005/us-east-1/service/aws4_request, SignedHeaders=content-type;host;x-amz-agent-x;x-amz-content-sha256;x-amz-date, Signature=43d9b807176c2ab5ad89539ec1d29abee84030a21441f57fb8a8d91873592771",
                "44136fa355b3678a1146ad16f7e8649e94fb4fc21fe77e8310c060f61caaff8a",
                "POST\n/\n\ncontent-type:application/json\nhost:dynamodb.us-east-1.amazonaws.com\nx-amz-agent-x:same length as ignored\nx-amz-content-sha256:44136fa355b3678a1146ad16f7e8649e94fb4fc21fe77e8310c060f61caaff8a\nx-amz-date:20261005T031415Z\n\ncontent-type;host;x-amz-agent-x;x-amz-content-sha256;x-amz-date\n44136fa355b3678a1146ad16f7e8649e94fb4fc21fe77e8310c060f61caaff8a",
                "AWS4-HMAC-SHA256\n20261005T031415Z\n20261005/us-east-1/service/aws4_request\n9b7ab70bc0be4f63ad80c02d1d7c3e5281720a58af063c475f9d2a5d6ac093d7"),
            new ExpectedSignature("NonAsciiHeaderName",
                "AWS4-HMAC-SHA256 Credential=AKIDEXAMPLE/20261005/us-east-1/service/aws4_request, SignedHeaders=content-type;host;x-amz-content-sha256;x-amz-date;x-caf\u00e9, Signature=5a43a5872fdb8b0cf4293196b82a1dfbd6b3f389fa5a4646cedc7d893a8c3543",
                "44136fa355b3678a1146ad16f7e8649e94fb4fc21fe77e8310c060f61caaff8a",
                "POST\n/\n\ncontent-type:application/json\nhost:dynamodb.us-east-1.amazonaws.com\nx-amz-content-sha256:44136fa355b3678a1146ad16f7e8649e94fb4fc21fe77e8310c060f61caaff8a\nx-amz-date:20261005T031415Z\nx-caf\u00e9:v\n\ncontent-type;host;x-amz-content-sha256;x-amz-date;x-caf\u00e9\n44136fa355b3678a1146ad16f7e8649e94fb4fc21fe77e8310c060f61caaff8a",
                "AWS4-HMAC-SHA256\n20261005T031415Z\n20261005/us-east-1/service/aws4_request\nee4fdd7073544820666d609a4b3aa34ccc5a0c181a6f15dafeb6be910441dbac"),
            new ExpectedSignature("PathResourcesAndPort",
                "AWS4-HMAC-SHA256 Credential=AKIDEXAMPLE/20261005/us-east-1/service/aws4_request, SignedHeaders=content-type;host;x-amz-content-sha256;x-amz-date, Signature=5af55ce8fbcd619099941899fd955990007b3161ccd13f7ed82fcf73cfd6a92f",
                "ff5d8507b6a72bee2debce2c0054798deaccdc5d8a1b945b6280ce8aa9cba52e",
                "PUT\n/my-bucket/folder/key%2520with%2520spaces.txt\n\ncontent-type:application/octet-stream\nhost:localhost:8443\nx-amz-content-sha256:ff5d8507b6a72bee2debce2c0054798deaccdc5d8a1b945b6280ce8aa9cba52e\nx-amz-date:20261005T031415Z\n\ncontent-type;host;x-amz-content-sha256;x-amz-date\nff5d8507b6a72bee2debce2c0054798deaccdc5d8a1b945b6280ce8aa9cba52e",
                "AWS4-HMAC-SHA256\n20261005T031415Z\n20261005/us-east-1/service/aws4_request\n1ad5434bcc9bf4bfe6946b6be528cc44df7bc4cee02daaf08d97208ea98c3b9e"),
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
                case "WhitespaceAndMultiValueHeaders":
                    r.Headers["Content-Type"] = "text/plain";
                    r.Headers["X-Amz-Meta-Spaces"] = "   leading and trailing   ";
                    r.Headers["x-amz-meta-inner"] = "a    b  \t  c";
                    r.Headers["X-Amz-Meta-MultiValue"] = "v1,v2, v3,  v4";
                    r.Headers["x-amz-meta-tabs"] = "\tx\ty\t";
                    r.Headers["X-Amz-Meta-Newline"] = "line1\r\n line2";
                    r.Headers["x-amz-meta-empty"] = "";
                    r.Headers["X-Amz-Meta-Unicode"] = "caf\u00e9\u00a0\u00a0bar\u2003baz";
                    r.Headers["x_underscore"] = "u";
                    r.Content = Encoding.UTF8.GetBytes("hello");
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
                case "IgnoredHeadersPresent":
                    r.Headers["Content-Type"] = "application/json";
                    r.Headers["User-Agent"] = "aws-sdk-dotnet-coreclr/4.0 ua/2.0";
                    r.Headers["X-Amzn-Trace-Id"] = "Root=1-5759e988-bd862e3fe1be46a994272793";
                    r.Headers["amz-sdk-invocation-id"] = "00000000-0000-0000-0000-000000000000";
                    r.Headers["Amz-Sdk-Request"] = "attempt=1; max=3";
                    r.Headers["x-amz-user-agent"] = "legacy";
                    r.Headers["Transfer-Encoding"] = "chunked";
                    r.Headers["X-Amz-Agent-X"] = "same length as ignored";
                    r.Content = Encoding.UTF8.GetBytes("{}");
                    break;
                case "NonAsciiHeaderName":
                    r.Headers["Content-Type"] = "application/json";
                    r.Headers["X-Caf\u00c9"] = "v";
                    r.Content = Encoding.UTF8.GetBytes("{}");
                    break;
                case "PathResourcesAndPort":
                    r.Endpoint = new Uri("https://localhost:8443");
                    r.HttpMethod = "PUT";
                    r.ResourcePath = "/{Bucket}/{Key+}";
                    r.AddPathResource("{Bucket}", "my-bucket");
                    r.AddPathResource("{Key+}", "folder/key with spaces.txt");
                    r.Headers["Content-Type"] = "application/octet-stream";
                    r.Content = new byte[] { 0, 1, 2, 3, 255 };
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
        [DataRow("WhitespaceAndMultiValueHeaders")]
        [DataRow("EmptyBodyGet")]
        [DataRow("QueryStringAndSubResources")]
        [DataRow("IgnoredHeadersPresent")]
        [DataRow("NonAsciiHeaderName")]
        [DataRow("PathResourcesAndPort")]
        [DataRow("BodyFromParameters")]
        public void SignRequest_WithMetrics_MatchesPinnedOutput(string name)
        {
            var expected = GetExpected(name);
            var request = Build(name);
            var metrics = new RequestMetrics { IsEnabled = true };

            var result = new AWS4Signer().SignRequest(request, NewConfig(), metrics, AccessKey, SecretKey, SignedAt);

            Assert.AreEqual(expected.Authorization, result.ForAuthorizationHeader);
            Assert.AreEqual(expected.ContentSha256, request.Headers[HeaderKeys.XAmzContentSha256Header]);
            Assert.AreEqual(expected.CanonicalRequest, metrics.Properties[Metric.CanonicalRequest].Single().ToString());
            var stringToSign = metrics.Properties[Metric.StringToSign].Single();
            Assert.IsInstanceOfType(stringToSign, typeof(StringBuilder));
            Assert.AreEqual(expected.StringToSign, stringToSign.ToString());
        }

        [TestMethod]
        [DataRow("JsonPostMixedCaseHeaders")]
        [DataRow("WhitespaceAndMultiValueHeaders")]
        [DataRow("EmptyBodyGet")]
        [DataRow("QueryStringAndSubResources")]
        [DataRow("IgnoredHeadersPresent")]
        [DataRow("NonAsciiHeaderName")]
        [DataRow("PathResourcesAndPort")]
        [DataRow("BodyFromParameters")]
        public void SignRequest_WithoutMetrics_MatchesPinnedOutput(string name)
        {
            // Without enabled metrics the canonical request is hashed without being materialized as a string.
            var expected = GetExpected(name);

            var nullMetricsResult = new AWS4Signer().SignRequest(Build(name), NewConfig(), null, AccessKey, SecretKey, SignedAt);
            Assert.AreEqual(expected.Authorization, nullMetricsResult.ForAuthorizationHeader);

            var disabledMetrics = new RequestMetrics();
            var disabledMetricsResult = new AWS4Signer().SignRequest(Build(name), NewConfig(), disabledMetrics, AccessKey, SecretKey, SignedAt);
            Assert.AreEqual(expected.Authorization, disabledMetricsResult.ForAuthorizationHeader);
            Assert.AreEqual(0, disabledMetrics.Properties.Count);
        }

        [TestMethod]
        [DataRow("JsonPostMixedCaseHeaders")]
        [DataRow("WhitespaceAndMultiValueHeaders")]
        [DataRow("EmptyBodyGet")]
        [DataRow("QueryStringAndSubResources")]
        [DataRow("IgnoredHeadersPresent")]
        [DataRow("NonAsciiHeaderName")]
        [DataRow("PathResourcesAndPort")]
        [DataRow("BodyFromParameters")]
        public void SignRequest_FastCanonicalizationDisabled_MatchesPinnedOutput(string name)
        {
            var expected = GetExpected(name);
            var saved = AWS4Signer.DisableFastCanonicalization;
            AWS4Signer.DisableFastCanonicalization = true;
            try
            {
                var metrics = new RequestMetrics { IsEnabled = true };
                var withMetrics = new AWS4Signer().SignRequest(Build(name), NewConfig(), metrics, AccessKey, SecretKey, SignedAt);
                Assert.AreEqual(expected.Authorization, withMetrics.ForAuthorizationHeader);
                Assert.AreEqual(expected.CanonicalRequest, metrics.Properties[Metric.CanonicalRequest].Single().ToString());

                var withoutMetrics = new AWS4Signer().SignRequest(Build(name), NewConfig(), null, AccessKey, SecretKey, SignedAt);
                Assert.AreEqual(expected.Authorization, withoutMetrics.ForAuthorizationHeader);
            }
            finally
            {
                AWS4Signer.DisableFastCanonicalization = saved;
            }
        }

        [TestMethod]
        public void FastCanonicalizationSwitch_IsOffByDefault()
        {
            Assert.AreEqual("Amazon.Runtime.AWS4Signer.DisableFastCanonicalization", AWS4Signer.DisableFastCanonicalizationSwitch);
            Assert.IsFalse(AWS4Signer.DisableFastCanonicalization);
        }

        [TestMethod]
        public void Sign_SetsAuthorizationHeaderFromSigningResult()
        {
            var request = Build("JsonPostMixedCaseHeaders");
            var config = NewConfig();
            // Sign() takes "now" from the clock; pin it by re-signing at the instant it recorded.
            new AWS4Signer().Sign(request, config, null, new BasicAWSCredentials(AccessKey, SecretKey));
            var signedAt = request.AWS4SignerResult.DateTime;

            var resigned = new AWS4Signer().SignRequest(Build("JsonPostMixedCaseHeaders"), config, null, AccessKey, SecretKey, signedAt);
            Assert.AreEqual(resigned.ForAuthorizationHeader, request.Headers[HeaderKeys.AuthorizationHeader]);
            Assert.AreEqual(request.AWS4SignerResult.ForAuthorizationHeader, request.Headers[HeaderKeys.AuthorizationHeader]);
            Assert.AreEqual(signedAt.ToUniversalTime().ToString(AWSSDKUtils.ISO8601BasicDateTimeFormat, CultureInfo.InvariantCulture), request.Headers[HeaderKeys.XAmzDateHeader]);
        }

        [TestMethod]
        public void SigningResult_SignatureAndAuthorizationHeaderAreStable()
        {
            var expected = GetExpected("JsonPostMixedCaseHeaders");
            var result = new AWS4Signer().SignRequest(Build("JsonPostMixedCaseHeaders"), NewConfig(), null, AccessKey, SecretKey, SignedAt);

            Assert.AreEqual(expected.Authorization, result.ForAuthorizationHeader);
            Assert.AreEqual(expected.Authorization, result.ForAuthorizationHeader);
            StringAssert.EndsWith(expected.Authorization, ", Signature=" + result.Signature);
            Assert.AreEqual(result.Signature, result.Signature);
            Assert.AreEqual("20261005T031415Z", result.ISO8601DateTime);
            Assert.AreEqual("20261005", result.ISO8601Date);
            Assert.AreEqual("20261005/us-east-1/service/aws4_request", result.Scope);
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
            // Exercises the pooled keyed HMAC on the cached signing key under contention.
            var expected = GetExpected("JsonPostMixedCaseHeaders").Authorization;
            var config = NewConfig();
            var results = new string[2000];
            Parallel.For(0, results.Length, new ParallelOptions { MaxDegreeOfParallelism = 8 }, i =>
            {
                results[i] = new AWS4Signer().SignRequest(Build("JsonPostMixedCaseHeaders"), config, null, AccessKey, SecretKey, SignedAt).ForAuthorizationHeader;
            });

            foreach (var result in results)
                Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SignRequest_AlternatingScopes_ProduceIndependentSignatures()
        {
            // Different scopes have different cached keys; interleaving them must not mix up keyed HMAC state.
            var config = NewConfig();
            var otherConfig = new MockClientConfig { AuthenticationRegion = "eu-west-1", AuthenticationServiceName = "other" };
            var expected = GetExpected("JsonPostMixedCaseHeaders").Authorization;
            var otherExpected = new AWS4Signer().SignRequest(Build("JsonPostMixedCaseHeaders"), otherConfig, null, AccessKey, SecretKey, SignedAt).ForAuthorizationHeader;
            Assert.AreNotEqual(expected, otherExpected);

            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(expected, new AWS4Signer().SignRequest(Build("JsonPostMixedCaseHeaders"), config, null, AccessKey, SecretKey, SignedAt).ForAuthorizationHeader);
                Assert.AreEqual(otherExpected, new AWS4Signer().SignRequest(Build("JsonPostMixedCaseHeaders"), otherConfig, null, AccessKey, SecretKey, SignedAt).ForAuthorizationHeader);
            }
        }

        [TestMethod]
        public void SignRequest_MatchesSortAndPruneHeadersCanonicalization_ForRandomHeaders()
        {
            // The signer builds the canonical request without SortAndPruneHeaders; compare it with the general path.
            var random = new Random(12345);
            const string nameChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~!#$%&'*+^`|";
            const string valueChars = "abcXYZ019 ,;:=/+\t\"";
            for (int iteration = 0; iteration < 200; iteration++)
            {
                var request = Build("JsonPostMixedCaseHeaders");
                int headerCount = random.Next(0, 12);
                for (int h = 0; h < headerCount; h++)
                {
                    var name = new string(Enumerable.Range(0, random.Next(1, 24)).Select(_ => nameChars[random.Next(nameChars.Length)]).ToArray());
                    var value = new string(Enumerable.Range(0, random.Next(0, 40)).Select(_ => valueChars[random.Next(valueChars.Length)]).ToArray());
                    request.Headers[name] = value;
                }

                var metrics = new RequestMetrics { IsEnabled = true };
                var result = new AWS4Signer().SignRequest(request, NewConfig(), metrics, AccessKey, SecretKey, SignedAt);

                var sortedHeaders = AWS4Signer.SortAndPruneHeaders(request.Headers);
                var expectedCanonicalRequest = AWS4SignerTestee.TestCanonicalizeRequest(request.Endpoint, request.ResourcePath, request.HttpMethod,
                    sortedHeaders, string.Empty, request.Headers[HeaderKeys.XAmzContentSha256Header], request.PathResources, request.UseDoubleEncoding);

                Assert.AreEqual(expectedCanonicalRequest, metrics.Properties[Metric.CanonicalRequest].Single().ToString(), "iteration " + iteration);
                Assert.AreEqual(string.Join(";", sortedHeaders.Keys), result.SignedHeaders, "iteration " + iteration);

                var withoutMetrics = new AWS4Signer().SignRequest(request, NewConfig(), null, AccessKey, SecretKey, SignedAt);
                Assert.AreEqual(result.ForAuthorizationHeader, withoutMetrics.ForAuthorizationHeader, "iteration " + iteration);
            }
        }

        [TestMethod]
        public void IsHeaderIgnoredWhenSigning_MatchesIgnoreSet()
        {
            var ignored = AWS4Signer.HeadersToIgnoreWhenSigning.ToList();
            Assert.AreEqual(6, ignored.Count);
            foreach (var name in ignored)
            {
                Assert.IsTrue(AWS4Signer.IsHeaderIgnoredWhenSigning(name), name);
                Assert.IsTrue(AWS4Signer.IsHeaderIgnoredWhenSigning(name.ToUpperInvariant()), name);
                Assert.IsTrue(AWS4Signer.IsHeaderIgnoredWhenSigning(name.ToLowerInvariant()), name);
                Assert.AreEqual(0, AWS4Signer.SortAndPruneHeaders(new Dictionary<string, string> { { name, "v" } }).Count, name);

                // Same length, one character different.
                var nearMiss = name.Substring(0, name.Length - 1) + (name[name.Length - 1] == 'x' ? 'y' : 'x');
                Assert.IsFalse(AWS4Signer.IsHeaderIgnoredWhenSigning(nearMiss), nearMiss);
            }

            foreach (var name in new[] { "Content-Type", "Host", "X-Amz-Date", "X-Amz-Target", "x-amz-content-sha256", "User-Agen", "User-Agentx" })
                Assert.IsFalse(AWS4Signer.IsHeaderIgnoredWhenSigning(name), name);
        }

        [TestMethod]
        public void CanonicalizeHeaderValue_MatchesCompressSpaces()
        {
            var inputs = new List<string>
            {
                null, "", " ", "  ", "a", " a", "a ", " a ", "a b", "a  b", "a\tb", "\ta", "a\t", "a\r\nb", "a\u000bb", "a\u000cb",
                "a\u001cb", "a\u001fb", "a\u0085b", "a\u00a0b", "a\u00a0\u00a0b", "\u00a0a\u00a0", "a\u2003b", "a\u3000b",
                "caf\u00e9", "application/x-amz-json-1.0", "v1,v2, v3", new string('x', 2000), new string('x', 999) + "  " + new string('y', 999),
                new string('x', 1000) + "\t", new string('x', 1000) + " "
            };
            for (int c = 0; c < 0x100; c++)
            {
                inputs.Add("a" + (char)c + "b");
                inputs.Add("ab" + (char)c);
            }

            foreach (var input in inputs)
                Assert.AreEqual(AWSSDKUtils.CompressSpaces(input, trim: true), AWS4Signer.CanonicalizeHeaderValue(input), input == null ? "null" : string.Join(",", input.Take(8).Select(ch => ((int)ch).ToString("x", CultureInfo.InvariantCulture))));
        }

        [TestMethod]
        public void FormatDateTime_MatchesDateTimeToString()
        {
            var formats = new[] { AWSSDKUtils.ISO8601BasicDateTimeFormat, AWSSDKUtils.ISO8601BasicDateFormat };
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
                foreach (var format in formats)
                    Assert.AreEqual(date.ToUniversalTime().ToString(format, CultureInfo.InvariantCulture), AWS4Signer.FormatDateTime(date, format), date.ToString("o", CultureInfo.InvariantCulture));
            }

            // Other formats still go through DateTime.ToString.
            Assert.AreEqual("2015-08-30", AWS4Signer.FormatDateTime(new DateTime(2015, 8, 30, 12, 36, 0, DateTimeKind.Utc), "yyyy-MM-dd"));
        }

        [TestMethod]
        public void EmptyBodySha256_IsSha256OfEmptyInput()
        {
            using (var sha256 = SHA256.Create())
            {
                Assert.AreEqual(AWS4Signer.EmptyBodySha256, AWSSDKUtils.ToHex(sha256.ComputeHash(new byte[0]), true));
            }
        }

        private class AWS4SignerTestee : AWS4Signer
        {
            public static string TestCanonicalizeRequest(Uri endpoint, string resourcePath, string httpMethod, IDictionary<string, string> sortedHeaders,
                string canonicalQueryString, string precomputedBodyHash, IDictionary<string, string> pathResources, bool doubleEncode)
                => CanonicalizeRequest(endpoint, resourcePath, httpMethod, sortedHeaders, canonicalQueryString, precomputedBodyHash, pathResources, doubleEncode);
        }
    }
}
