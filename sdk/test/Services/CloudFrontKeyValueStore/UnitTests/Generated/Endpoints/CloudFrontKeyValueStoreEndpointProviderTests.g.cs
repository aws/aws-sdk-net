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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.CloudFrontKeyValueStore.Endpoints;
using Amazon.CloudFrontKeyValueStore.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Endpoints")]
    [TestCategory("CloudFrontKeyValueStore")]
    public partial class CloudFrontKeyValueStoreEndpointsTests
    {
        [TestMethod]
        [Description("FIPS without a KVS ARN, should error on the missing ARN")]
        public void FIPS_without_a_KVS_ARN_should_error_on_the_missing_ARN_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["UseFIPS"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"KVS ARN must be provided to use this service", exception.Message);
        }

        [TestMethod]
        [Description("KVS ARN must be provided to use this service")]
        public void KVS_ARN_must_be_provided_to_use_this_service_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"KVS ARN must be provided to use this service", exception.Message);
        }

        [TestMethod]
        [Description("KVS ARN must be a valid ARN")]
        public void KVS_ARN_must_be_a_valid_ARN_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "not-a-valid-arn";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"KVS ARN must be a valid ARN", exception.Message);
        }

        [TestMethod]
        [Description("Provided ARN was not a valid CloudFront Service ARN. Found: `notcloudfront`")]
        public void Provided_ARN_was_not_a_valid_CloudFront_Service_ARN_Found_notcloudfront_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:notcloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Provided ARN is not a valid CloudFront Service ARN. Found: `notcloudfront`", exception.Message);
        }

        [TestMethod]
        [Description("Provided ARN must be a global resource ARN. Found: `us-west-2`")]
        public void Provided_ARN_must_be_a_global_resource_ARN_Found_uswest2_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront:us-west-2:123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Provided ARN must be a global resource ARN. Found: `us-west-2`", exception.Message);
        }

        [TestMethod]
        [Description("ARN resource type is invalid. Expected `key-value-store`, found: `some-other-resource-type`")]
        public void ARN_resource_type_is_invalid_Expected_keyvaluestore_found_someotherresourcetype_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront::123456789012:some-other-resource-type/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"ARN resource type is invalid. Expected `key-value-store`, found: `some-other-resource-type`", exception.Message);
        }

        [TestMethod]
        [Description("CloudFront-KeyValueStore is not supported in partition `aws-cn`")]
        public void CloudFrontKeyValueStore_is_not_supported_in_partition_awscn_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws-cn:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"CloudFront-KeyValueStore is not supported in partition `aws-cn`", exception.Message);
        }

        [TestMethod]
        [Description("CloudFront-KeyValueStore is not supported in partition `aws-us-gov`")]
        public void CloudFrontKeyValueStore_is_not_supported_in_partition_awsusgov_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws-us-gov:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"CloudFront-KeyValueStore is not supported in partition `aws-us-gov`", exception.Message);
        }

        [TestMethod]
        [Description("Valid account based endpoint")]
        public void Valid_account_based_endpoint_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.cloudfront-kvs.global.api.aws", endpoint.URL);
        }

        [TestMethod]
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
        [Description("Valid ARN, different partition, should error")]
        public void Valid_ARN_different_partition_should_error_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Region"] = "cn-north-1";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Client was configured for partition `aws-cn` but Kvs ARN has `aws`", exception.Message);
        }

        [TestMethod]
        [Description("Valid account based endpoint with FIPS resolves to the same endpoint")]
        public void Valid_account_based_endpoint_with_FIPS_resolves_to_the_same_endpoint_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.cloudfront-kvs.global.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("Valid account based endpoint with FIPS, without SDK region")]
        public void Valid_account_based_endpoint_with_FIPS_without_SDK_region_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.cloudfront-kvs.global.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("FIPS with a custom sdk endpoint override, should error")]
        public void FIPS_with_a_custom_sdk_endpoint_override_should_error_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://my-override.example.com";
            parameters["UseFIPS"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [Description("FIPS with a custom sdk endpoint override, without SDK region, should error")]
        public void FIPS_with_a_custom_sdk_endpoint_override_without_SDK_region_should_error_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Endpoint"] = "https://my-override.example.com";
            parameters["UseFIPS"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [Description("FIPS in an unsupported partition reports the partition, not FIPS")]
        public void FIPS_in_an_unsupported_partition_reports_the_partition_not_FIPS_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws-cn:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["UseFIPS"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"CloudFront-KeyValueStore is not supported in partition `aws-cn`", exception.Message);
        }

        [TestMethod]
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
        [Description("Custom override with different partition should error")]
        public void Custom_override_with_different_partition_should_error_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Region"] = "us-gov-east-1";
            parameters["Endpoint"] = "https://my-override.example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Client was configured for partition `aws-us-gov` but Kvs ARN has `aws`", exception.Message);
        }

        [TestMethod]
        [Description("Valid aws ARN, aws-eusc SDK region, should error")]
        public void Valid_aws_ARN_awseusc_SDK_region_should_error_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Region"] = "eusc-de-east-1";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Client was configured for partition `aws-eusc` but Kvs ARN has `aws`", exception.Message);
        }

        [TestMethod]
        [Description("Empty ARN resource type should error")]
        public void Empty_ARN_resource_type_should_error_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws:cloudfront::123456789012:/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"No resource type found in the KVS ARN. Resource type must be `key-value-store`.", exception.Message);
        }

        [TestMethod]
        [Description("Valid account based endpoint in aws-eusc")]
        public void Valid_account_based_endpoint_in_awseusc_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws-eusc:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.cloudfront-kvs.global.api.amazonwebservices.eu", endpoint.URL);
        }

        [TestMethod]
        [Description("Valid account based endpoint in aws-eusc, with SDK region")]
        public void Valid_account_based_endpoint_in_awseusc_with_SDK_region_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws-eusc:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Region"] = "eusc-de-east-1";
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.cloudfront-kvs.global.api.amazonwebservices.eu", endpoint.URL);
        }

        [TestMethod]
        [Description("Valid aws-eusc ARN, aws SDK region, should error")]
        public void Valid_awseusc_ARN_aws_SDK_region_should_error_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws-eusc:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Region"] = "us-east-1";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Client was configured for partition `aws` but Kvs ARN has `aws-eusc`", exception.Message);
        }

        [TestMethod]
        [Description("Valid account based endpoint in aws-eusc with FIPS, should error")]
        public void Valid_account_based_endpoint_in_awseusc_with_FIPS_should_error_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws-eusc:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Region"] = "eusc-de-east-1";
            parameters["UseFIPS"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS is not supported with CloudFront-KeyValueStore.", exception.Message);
        }

        [TestMethod]
        [Description("aws-eusc with FIPS and a custom endpoint override reports the partition-level FIPS error")]
        public void Awseusc_with_FIPS_and_a_custom_endpoint_override_reports_the_partitionlevel_FIPS_error_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws-eusc:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Region"] = "eusc-de-east-1";
            parameters["Endpoint"] = "https://my-override.example.com";
            parameters["UseFIPS"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS is not supported with CloudFront-KeyValueStore.", exception.Message);
        }

        [TestMethod]
        [Description("Custom sdk endpoint override in aws-eusc")]
        public void Custom_sdk_endpoint_override_in_awseusc_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws-eusc:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Region"] = "eusc-de-east-1";
            parameters["Endpoint"] = "https://my-override.example.com";
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.my-override.example.com", endpoint.URL);
        }

        [TestMethod]
        [Description("Custom sdk endpoint override with path and http in aws-eusc")]
        public void Custom_sdk_endpoint_override_with_path_and_http_in_awseusc_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws-eusc:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Endpoint"] = "http://my-override.example.com/custom-path";
            var endpoint = new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://123456789012.my-override.example.com/custom-path", endpoint.URL);
        }

        [TestMethod]
        [Description("Custom override in aws-eusc with different partition should error")]
        public void Custom_override_in_awseusc_with_different_partition_should_error_Test()
        {
            var parameters = new CloudFrontKeyValueStoreEndpointParameters();
            parameters["KvsARN"] = "arn:aws-eusc:cloudfront::123456789012:key-value-store/my-first-kvs-e10b1dce4f394248811e77167e0451ba";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://my-override.example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonCloudFrontKeyValueStoreEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Client was configured for partition `aws` but Kvs ARN has `aws-eusc`", exception.Message);
        }
    }
}
