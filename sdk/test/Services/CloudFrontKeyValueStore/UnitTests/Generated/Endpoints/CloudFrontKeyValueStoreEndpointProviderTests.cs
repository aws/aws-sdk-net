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
 * Do not modify this file. This file is generated from the cloudfront-keyvaluestore-2022-07-26.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.CloudFrontKeyValueStore.Endpoints;
using Amazon.CloudFrontKeyValueStore.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    public partial class CloudFrontKeyValueStoreEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFrontKeyValueStore")]
        [Description("FIPS should error")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS is not supported with CloudFront-KeyValueStore.")]
        public void FIPS_should_error_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFrontKeyValueStore")]
        [Description("KVS ARN must be provided to use this service")]
        [ExpectedException(typeof(AmazonClientException), @"KVS ARN must be provided to use this service")]
        public void KVS_ARN_must_be_provided_to_use_this_service_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFrontKeyValueStore")]
        [Description("KVS ARN must be a valid ARN")]
        [ExpectedException(typeof(AmazonClientException), @"KVS ARN must be a valid ARN")]
        public void KVS_ARN_must_be_a_valid_ARN_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "not-a-valid-arn";
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFrontKeyValueStore")]
        [Description("Provided ARN was not a valid CloudFront Service ARN. Found: `notcloudfront`")]
        [ExpectedException(typeof(AmazonClientException), @"Provided ARN is not a valid CloudFront Service ARN. Found: `notcloudfront`")]
        public void Provided_ARN_was_not_a_valid_CloudFront_Service_ARN_Found_notcloudfront_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:notcloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFrontKeyValueStore")]
        [Description("Provided ARN must be a global resource ARN. Found: `us-west-2`")]
        [ExpectedException(typeof(AmazonClientException), @"Provided ARN must be a global resource ARN. Found: `us-west-2`")]
        public void Provided_ARN_must_be_a_global_resource_ARN_Found_uswest2_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront:us-west-2:123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFrontKeyValueStore")]
        [Description("ARN resource type is invalid. Expected `key-value-store`, found: `some-other-resource-type`")]
        [ExpectedException(typeof(AmazonClientException), @"ARN resource type is invalid. Expected `key-value-store`, found: `some-other-resource-type`")]
        public void ARN_resource_type_is_invalid_Expected_keyvaluestore_found_someotherresourcetype_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront::123456789012:some-other-resource-type/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFrontKeyValueStore")]
        [Description("CloudFront-KeyValueStore is not supported in partition `aws-cn`")]
        [ExpectedException(typeof(AmazonClientException), @"CloudFront-KeyValueStore is not supported in partition `aws-cn`")]
        public void CloudFrontKeyValueStore_is_not_supported_in_partition_awscn_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws-cn:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFrontKeyValueStore")]
        [Description("CloudFront-KeyValueStore is not supported in partition `aws-us-gov`")]
        [ExpectedException(typeof(AmazonClientException), @"CloudFront-KeyValueStore is not supported in partition `aws-us-gov`")]
        public void CloudFrontKeyValueStore_is_not_supported_in_partition_awsusgov_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws-us-gov:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFrontKeyValueStore")]
        [Description("Valid account based endpoint")]
        public void Valid_account_based_endpoint_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.cloudfront-kvs.global.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFrontKeyValueStore")]
        [Description("Valid account based endpoint, with SDK region")]
        public void Valid_account_based_endpoint_with_SDK_region_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Region"] = "us-west-2";
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.cloudfront-kvs.global.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFrontKeyValueStore")]
        [Description("Valid ARN, different partition, should error")]
        [ExpectedException(typeof(AmazonClientException), @"Client was configured for partition `aws-cn` but Kvs ARN has `aws`")]
        public void Valid_ARN_different_partition_should_error_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFrontKeyValueStore")]
        [Description("Valid account based endpoint with FIPS, should error")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS is not supported with CloudFront-KeyValueStore.")]
        public void Valid_account_based_endpoint_with_FIPS_should_error_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFrontKeyValueStore")]
        [Description("Custom sdk endpoint override")]
        public void Custom_sdk_endpoint_override_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://my-override.example.com";
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.my-override.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFrontKeyValueStore")]
        [Description("Custom sdk endpoint override with path and http")]
        public void Custom_sdk_endpoint_override_with_path_and_http_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Endpoint"] = "http://my-override.example.com/custom-path";
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://123456789012.my-override.example.com/custom-path", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFrontKeyValueStore")]
        [Description("Custom override with different partition should error")]
        [ExpectedException(typeof(AmazonClientException), @"Client was configured for partition `aws-us-gov` but Kvs ARN has `aws`")]
        public void Custom_override_with_different_partition_should_error_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Region"] = "us-gov-east-1";
            parameters["Endpoint"] = "https://my-override.example.com";
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}