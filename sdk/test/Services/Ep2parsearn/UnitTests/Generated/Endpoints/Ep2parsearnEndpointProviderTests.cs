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

/*
 * Do not modify this file. This file is generated from the ep2-parse-arn-2022-08-24.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Ep2parsearn.Endpoints;
using Amazon.Ep2parsearn.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    public partial class Ep2parsearnEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2parsearn")]
        [Description("arn + region resolution")]
        public void Arn_region_resolution_Test()
        {
            var parameters = new Ep2parsearnEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3:us-east-2:012345678:outpost:op-1234";
            parameters["Region"] = "us-east-2";
            var endpoint = new AmazonEp2parsearnEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://op-1234-012345678.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2parsearn")]
        [Description("arn, unset outpost id")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: outpostId was not set")]
        public void Arn_unset_outpost_id_Test()
        {
            var parameters = new Ep2parsearnEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3:us-east-2:012345678:outpost";
            parameters["Region"] = "us-east-2";
            var endpoint = new AmazonEp2parsearnEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2parsearn")]
        [Description("arn, empty outpost id (tests that empty strings are handled properly during matching)")]
        [ExpectedException(typeof(AmazonClientException), @"OutpostId was empty")]
        public void Arn_empty_outpost_id_tests_that_empty_strings_are_handled_properly_during_matching_Test()
        {
            var parameters = new Ep2parsearnEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3:us-east-2:012345678:outpost::";
            parameters["Region"] = "us-east-2";
            var endpoint = new AmazonEp2parsearnEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2parsearn")]
        [Description("arn, empty outpost id (tests that ARN parsing considers a trailing colon)")]
        [ExpectedException(typeof(AmazonClientException), @"OutpostId was empty")]
        public void Arn_empty_outpost_id_tests_that_ARN_parsing_considers_a_trailing_colon_Test()
        {
            var parameters = new Ep2parsearnEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3:us-east-2:012345678:outpost:";
            parameters["Region"] = "us-east-2";
            var endpoint = new AmazonEp2parsearnEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2parsearn")]
        [Description("valid hostlabel + region resolution")]
        public void Valid_hostlabel_region_resolution_Test()
        {
            var parameters = new Ep2parsearnEndpointParameters();
            parameters["Bucket"] = "mybucket";
            parameters["Region"] = "us-east-2";
            var endpoint = new AmazonEp2parsearnEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2parsearn")]
        [Description("not a valid hostlabel + region resolution")]
        public void Not_a_valid_hostlabel_region_resolution_Test()
        {
            var parameters = new Ep2parsearnEndpointParameters();
            parameters["Bucket"] = "99_a";
            parameters["Region"] = "us-east-2";
            var endpoint = new AmazonEp2parsearnEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://us-east-2.amazonaws.com/99_a", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2parsearn")]
        [Description("no bucket")]
        public void No_bucket_Test()
        {
            var parameters = new Ep2parsearnEndpointParameters();
            parameters["Region"] = "us-east-2";
            var endpoint = new AmazonEp2parsearnEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2parsearn")]
        [Description("a string that is not a 6-part ARN")]
        [ExpectedException(typeof(AmazonClientException), @"Test case passed: `asdf` is not a valid ARN.")]
        public void A_string_that_is_not_a_6part_ARN_Test()
        {
            var parameters = new Ep2parsearnEndpointParameters();
            parameters["TestCaseId"] = "invalid-arn";
            parameters["Bucket"] = "asdf";
            var endpoint = new AmazonEp2parsearnEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2parsearn")]
        [Description("resource id MUST not be null")]
        [ExpectedException(typeof(AmazonClientException), @"Test case passed: `arn:aws:s3:us-west-2:123456789012:` is not a valid ARN.")]
        public void Resource_id_MUST_not_be_null_Test()
        {
            var parameters = new Ep2parsearnEndpointParameters();
            parameters["TestCaseId"] = "invalid-arn";
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456789012:";
            var endpoint = new AmazonEp2parsearnEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2parsearn")]
        [Description("service MUST not be null")]
        [ExpectedException(typeof(AmazonClientException), @"Test case passed: `arn:aws::us-west-2:123456789012:resource-id` is not a valid ARN.")]
        public void Service_MUST_not_be_null_Test()
        {
            var parameters = new Ep2parsearnEndpointParameters();
            parameters["TestCaseId"] = "invalid-arn";
            parameters["Bucket"] = "arn:aws::us-west-2:123456789012:resource-id";
            var endpoint = new AmazonEp2parsearnEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2parsearn")]
        [Description("partition MUST not be null")]
        [ExpectedException(typeof(AmazonClientException), @"Test case passed: `arn::s3:us-west-2:123456789012:resource-id` is not a valid ARN.")]
        public void Partition_MUST_not_be_null_Test()
        {
            var parameters = new Ep2parsearnEndpointParameters();
            parameters["TestCaseId"] = "invalid-arn";
            parameters["Bucket"] = "arn::s3:us-west-2:123456789012:resource-id";
            var endpoint = new AmazonEp2parsearnEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2parsearn")]
        [Description("region MAY be null")]
        [ExpectedException(typeof(AmazonClientException), @"Test case passed: A valid ARN was parsed: service: `s3`, partition: `aws, region: ``, accountId: `123456789012`, resource: `resource-id`")]
        public void Region_MAY_be_null_Test()
        {
            var parameters = new Ep2parsearnEndpointParameters();
            parameters["TestCaseId"] = "valid-arn";
            parameters["Bucket"] = "arn:aws:s3::123456789012:resource-id";
            var endpoint = new AmazonEp2parsearnEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2parsearn")]
        [Description("accountId MAY be null")]
        [ExpectedException(typeof(AmazonClientException), @"Test case passed: A valid ARN was parsed: service: `s3`, partition: `aws, region: `us-east-1`, accountId: ``, resource: `resource-id`")]
        public void AccountId_MAY_be_null_Test()
        {
            var parameters = new Ep2parsearnEndpointParameters();
            parameters["TestCaseId"] = "valid-arn";
            parameters["Bucket"] = "arn:aws:s3:us-east-1::resource-id";
            var endpoint = new AmazonEp2parsearnEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2parsearn")]
        [Description("accountId MAY be non-numeric")]
        [ExpectedException(typeof(AmazonClientException), @"Test case passed: A valid ARN was parsed: service: `s3`, partition: `aws, region: `us-east-1`, accountId: `abcd`, resource: `resource-id`")]
        public void AccountId_MAY_be_nonnumeric_Test()
        {
            var parameters = new Ep2parsearnEndpointParameters();
            parameters["TestCaseId"] = "valid-arn";
            parameters["Bucket"] = "arn:aws:s3:us-east-1:abcd:resource-id";
            var endpoint = new AmazonEp2parsearnEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}