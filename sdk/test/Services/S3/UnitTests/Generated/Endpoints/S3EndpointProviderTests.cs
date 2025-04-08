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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.S3.Endpoints;
using Amazon.S3.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    public partial class S3EndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("region is not a valid DNS-suffix")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid region: region was not a valid DNS name.")]
        public void Region_is_not_a_valid_DNSsuffix_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "a b";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Invalid access point ARN: Not S3")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: The ARN was not for the S3 service, found: not-s3")]
        public void Invalid_access_point_ARN_Not_S3_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:not-s3:us-west-2:123456789012:accesspoint:myendpoint";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Invalid access point ARN: invalid resource")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: The ARN may only contain a single resource component after `accesspoint`.")]
        public void Invalid_access_point_ARN_invalid_resource_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint:more-data";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Invalid access point ARN: invalid no ap name")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Expected a resource of the format `accesspoint:<accesspoint name>` but no name was provided")]
        public void Invalid_access_point_ARN_invalid_no_ap_name_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456789012:accesspoint:";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Invalid access point ARN: AccountId is invalid")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: The account id may only contain a-z, A-Z, 0-9 and `-`. Found: `123456_789012`")]
        public void Invalid_access_point_ARN_AccountId_is_invalid_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456_789012:accesspoint:apname";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Invalid access point ARN: access point name is invalid")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: The access point name may only contain a-z, A-Z, 0-9 and `-`. Found: `ap_name`")]
        public void Invalid_access_point_ARN_access_point_name_is_invalid_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456789012:accesspoint:ap_name";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Access points (disable access points explicitly false)")]
        public void Access_points_disable_access_points_explicitly_false_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["DisableAccessPoints"] = false;
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myendpoint-123456789012.s3-accesspoint.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Access points: partition does not support FIPS")]
        [ExpectedException(typeof(AmazonClientException), @"Partition does not support FIPS")]
        public void Access_points_partition_does_not_support_FIPS_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3:cn-north-1:123456789012:accesspoint:myendpoint";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Bucket region is invalid")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid region in ARN: `us-west -2` (invalid DNS name)")]
        public void Bucket_region_is_invalid_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["DisableAccessPoints"] = false;
            parameters["Bucket"] = "arn:aws:s3:us-west -2:123456789012:accesspoint:myendpoint";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Access points when Access points explicitly disabled (used for CreateBucket)")]
        [ExpectedException(typeof(AmazonClientException), @"Access points are not supported for this operation")]
        public void Access_points_when_Access_points_explicitly_disabled_used_for_CreateBucket_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["DisableAccessPoints"] = true;
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("missing arn type")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: `arn:aws:s3:us-west-2:123456789012:` was not a valid ARN")]
        public void Missing_arn_type_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["DisableAccessPoints"] = true;
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456789012:";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::Host + access point + Dualstack is an error")]
        [ExpectedException(typeof(AmazonClientException), @"Cannot set dual-stack in combination with a custom endpoint.")]
        public void SDKHost_access_point_Dualstack_is_an_error_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws-cn:s3:cn-north-1:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Access point ARN with FIPS & Dualstack")]
        public void Access_point_ARN_with_FIPS_Dualstack_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Accelerate"] = false;
            parameters["DisableAccessPoints"] = false;
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myendpoint-123456789012.s3-accesspoint-fips.dualstack.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Access point ARN with Dualstack")]
        public void Access_point_ARN_with_Dualstack_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Accelerate"] = false;
            parameters["DisableAccessPoints"] = false;
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myendpoint-123456789012.s3-accesspoint.dualstack.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("vanilla MRAP")]
        public void Vanilla_MRAP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Bucket"] = "arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap";
            parameters["Region"] = "us-east-1";
            parameters["DisableMultiRegionAccessPoints"] = false;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mfzwi23gnjvgw.mrap.accesspoint.s3-global.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("MRAP does not support FIPS")]
        [ExpectedException(typeof(AmazonClientException), @"S3 MRAP does not support FIPS")]
        public void MRAP_does_not_support_FIPS_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Bucket"] = "arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap";
            parameters["Region"] = "us-east-1";
            parameters["DisableMultiRegionAccessPoints"] = false;
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("MRAP does not support DualStack")]
        [ExpectedException(typeof(AmazonClientException), @"S3 MRAP does not support dual-stack")]
        public void MRAP_does_not_support_DualStack_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Bucket"] = "arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap";
            parameters["Region"] = "us-east-1";
            parameters["DisableMultiRegionAccessPoints"] = false;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("MRAP does not support S3 Accelerate")]
        [ExpectedException(typeof(AmazonClientException), @"S3 MRAP does not support S3 Accelerate")]
        public void MRAP_does_not_support_S3_Accelerate_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Bucket"] = "arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap";
            parameters["Region"] = "us-east-1";
            parameters["DisableMultiRegionAccessPoints"] = false;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("MRAP explicitly disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: Multi-Region Access Point ARNs are disabled.")]
        public void MRAP_explicitly_disabled_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Bucket"] = "arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap";
            parameters["Region"] = "us-east-1";
            parameters["DisableMultiRegionAccessPoints"] = true;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Dual-stack endpoint with path-style forced")]
        public void Dualstack_endpoint_with_pathstyle_forced_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Bucket"] = "bucketname";
            parameters["Region"] = "us-west-2";
            parameters["ForcePathStyle"] = true;
            parameters["UseFIPS"] = false;
            parameters["Accelerate"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.dualstack.us-west-2.amazonaws.com/bucketname", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Dual-stack endpoint + SDK::Host is error")]
        [ExpectedException(typeof(AmazonClientException), @"Cannot set dual-stack in combination with a custom endpoint.")]
        public void Dualstack_endpoint_SDKHost_is_error_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Bucket"] = "bucketname";
            parameters["Region"] = "us-west-2";
            parameters["ForcePathStyle"] = true;
            parameters["UseFIPS"] = false;
            parameters["Accelerate"] = false;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://abc.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + ARN bucket")]
        [ExpectedException(typeof(AmazonClientException), @"Path-style addressing cannot be used with ARN buckets")]
        public void Path_style_ARN_bucket_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("implicit path style bucket + dualstack")]
        public void Implicit_path_style_bucket_dualstack_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "99_ab";
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.dualstack.us-west-2.amazonaws.com/99_ab", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("implicit path style bucket + dualstack")]
        [ExpectedException(typeof(AmazonClientException), @"Cannot set dual-stack in combination with a custom endpoint.")]
        public void Implicit_path_style_bucket_dualstack_1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "99_ab";
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "http://abc.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("don't allow URL injections in the bucket")]
        public void Dont_allow_URL_injections_in_the_bucket_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Bucket"] = "example.com#";
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.us-west-2.amazonaws.com/example.com%23", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("URI encode bucket names in the path")]
        public void URI_encode_bucket_names_in_the_path_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Bucket"] = "bucket name";
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.us-west-2.amazonaws.com/bucket%20name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("scheme is respected")]
        public void Scheme_is_respected_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "99_ab";
            parameters["Endpoint"] = "http://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com";
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com/99_ab", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("scheme is respected (virtual addressing)")]
        public void Scheme_is_respected_virtual_addressing_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucketname";
            parameters["Endpoint"] = "http://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com/foo";
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://bucketname.control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com/foo", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + implicit private link")]
        public void Path_style_implicit_private_link_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "99_ab";
            parameters["Endpoint"] = "https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com";
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com/99_ab", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("invalid Endpoint override")]
        [ExpectedException(typeof(AmazonClientException), @"Custom endpoint `abcde://nota#url` was not a valid URI")]
        public void Invalid_Endpoint_override_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucketname";
            parameters["Endpoint"] = "abcde://nota#url";
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("using an IPv4 address forces path style")]
        public void Using_an_IPv4_address_forces_path_style_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucketname";
            parameters["Endpoint"] = "https://123.123.0.1";
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.123.0.1/bucketname", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("vanilla access point arn with region mismatch and UseArnRegion=false")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: region from ARN `us-east-1` does not match client region `us-west-2` and UseArnRegion is `false`")]
        public void Vanilla_access_point_arn_with_region_mismatch_and_UseArnRegionfalse_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3:us-east-1:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["UseArnRegion"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("vanilla access point arn with region mismatch and UseArnRegion unset")]
        public void Vanilla_access_point_arn_with_region_mismatch_and_UseArnRegion_unset_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myendpoint-123456789012.s3-accesspoint.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("vanilla access point arn with region mismatch and UseArnRegion=true")]
        public void Vanilla_access_point_arn_with_region_mismatch_and_UseArnRegiontrue_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["UseArnRegion"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myendpoint-123456789012.s3-accesspoint.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("subdomains are not allowed in virtual buckets")]
        public void Subdomains_are_not_allowed_in_virtual_buckets_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Bucket"] = "bucket.name";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.us-east-1.amazonaws.com/bucket.name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("bucket names with 3 characters are allowed in virtual buckets")]
        public void Bucket_names_with_3_characters_are_allowed_in_virtual_buckets_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Bucket"] = "aaa";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://aaa.s3.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("bucket names with fewer than 3 characters are not allowed in virtual host")]
        public void Bucket_names_with_fewer_than_3_characters_are_not_allowed_in_virtual_host_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Bucket"] = "aa";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.us-east-1.amazonaws.com/aa", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("bucket names with uppercase characters are not allowed in virtual host")]
        public void Bucket_names_with_uppercase_characters_are_not_allowed_in_virtual_host_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Bucket"] = "BucketName";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.us-east-1.amazonaws.com/BucketName", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("subdomains are allowed in virtual buckets on http endpoints")]
        public void Subdomains_are_allowed_in_virtual_buckets_on_http_endpoints_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Bucket"] = "bucket.name";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "http://example.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://bucket.name.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("no region set")]
        [ExpectedException(typeof(AmazonClientException), @"A region must be set when sending requests to S3.")]
        public void No_region_set_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Bucket"] = "bucket-name";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("UseGlobalEndpoints=true, region=us-east-1 uses the global endpoint")]
        public void UseGlobalEndpointstrue_regionuseast1_uses_the_global_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("UseGlobalEndpoints=true, region=us-west-2 uses the regional endpoint")]
        public void UseGlobalEndpointstrue_regionuswest2_uses_the_regional_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("UseGlobalEndpoints=true, region=cn-north-1 uses the regional endpoint")]
        public void UseGlobalEndpointstrue_regioncnnorth1_uses_the_regional_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("UseGlobalEndpoints=true, region=us-east-1, fips=true uses the regional endpoint with fips")]
        public void UseGlobalEndpointstrue_regionuseast1_fipstrue_uses_the_regional_endpoint_with_fips_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("UseGlobalEndpoints=true, region=us-east-1, dualstack=true uses the regional endpoint with dualstack")]
        public void UseGlobalEndpointstrue_regionuseast1_dualstacktrue_uses_the_regional_endpoint_with_dualstack_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.dualstack.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("UseGlobalEndpoints=true, region=us-east-1, dualstack and fips uses the regional endpoint with fips/dualstack")]
        public void UseGlobalEndpointstrue_regionuseast1_dualstack_and_fips_uses_the_regional_endpoint_with_fipsdualstack_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.dualstack.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("UseGlobalEndpoints=true, region=us-east-1 with custom endpoint, uses custom")]
        public void UseGlobalEndpointstrue_regionuseast1_with_custom_endpoint_uses_custom_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("UseGlobalEndpoints=true, region=us-west-2 with custom endpoint, uses custom")]
        public void UseGlobalEndpointstrue_regionuswest2_with_custom_endpoint_uses_custom_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Endpoint"] = "https://example.com";
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("UseGlobalEndpoints=true, region=us-east-1 with accelerate on non bucket case uses the global endpoint and ignores accelerate")]
        public void UseGlobalEndpointstrue_regionuseast1_with_accelerate_on_non_bucket_case_uses_the_global_endpoint_and_ignores_accelerate_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("aws-global region uses the global endpoint")]
        public void Awsglobal_region_uses_the_global_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("aws-global region with fips uses the regional endpoint")]
        public void Awsglobal_region_with_fips_uses_the_regional_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("aws-global region with dualstack uses the regional endpoint")]
        public void Awsglobal_region_with_dualstack_uses_the_regional_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.dualstack.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("aws-global region with fips and dualstack uses the regional endpoint")]
        public void Awsglobal_region_with_fips_and_dualstack_uses_the_regional_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.dualstack.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("aws-global region with accelerate on non-bucket case, uses global endpoint and ignores accelerate")]
        public void Awsglobal_region_with_accelerate_on_nonbucket_case_uses_global_endpoint_and_ignores_accelerate_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("aws-global region with custom endpoint, uses custom")]
        public void Awsglobal_region_with_custom_endpoint_uses_custom_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Endpoint"] = "https://example.com";
            parameters["UseGlobalEndpoint"] = false;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing, aws-global region uses the global endpoint")]
        public void Virtual_addressing_awsglobal_region_uses_the_global_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket-name";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing, aws-global region with Prefix, and Key uses the global endpoint. Prefix and Key parameters should not be used in endpoint evaluation.")]
        public void Virtual_addressing_awsglobal_region_with_Prefix_and_Key_uses_the_global_endpoint_Prefix_and_Key_parameters_should_not_be_used_in_endpoint_evaluation_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket-name";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Prefix"] = "prefix";
            parameters["Key"] = "key";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing, aws-global region with Copy Source, and Key uses the global endpoint. Copy Source and Key parameters should not be used in endpoint evaluation.")]
        public void Virtual_addressing_awsglobal_region_with_Copy_Source_and_Key_uses_the_global_endpoint_Copy_Source_and_Key_parameters_should_not_be_used_in_endpoint_evaluation_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket-name";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["CopySource"] = "/copy/source";
            parameters["Key"] = "key";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing, aws-global region with fips uses the regional fips endpoint")]
        public void Virtual_addressing_awsglobal_region_with_fips_uses_the_regional_fips_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket-name";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing, aws-global region with dualstack uses the regional dualstack endpoint")]
        public void Virtual_addressing_awsglobal_region_with_dualstack_uses_the_regional_dualstack_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket-name";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3.dualstack.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing, aws-global region with fips/dualstack uses the regional fips/dualstack endpoint")]
        public void Virtual_addressing_awsglobal_region_with_fipsdualstack_uses_the_regional_fipsdualstack_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket-name";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3-fips.dualstack.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing, aws-global region with accelerate uses the global accelerate endpoint")]
        public void Virtual_addressing_awsglobal_region_with_accelerate_uses_the_global_accelerate_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket-name";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3-accelerate.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing, aws-global region with custom endpoint")]
        public void Virtual_addressing_awsglobal_region_with_custom_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Endpoint"] = "https://example.com";
            parameters["Bucket"] = "bucket-name";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing, UseGlobalEndpoint and us-east-1 region uses the global endpoint")]
        public void Virtual_addressing_UseGlobalEndpoint_and_useast1_region_uses_the_global_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseGlobalEndpoint"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing, UseGlobalEndpoint and us-west-2 region uses the regional endpoint")]
        public void Virtual_addressing_UseGlobalEndpoint_and_uswest2_region_uses_the_regional_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseGlobalEndpoint"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing, UseGlobalEndpoint and us-east-1 region and fips uses the regional fips endpoint")]
        public void Virtual_addressing_UseGlobalEndpoint_and_useast1_region_and_fips_uses_the_regional_fips_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseGlobalEndpoint"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing, UseGlobalEndpoint and us-east-1 region and dualstack uses the regional dualstack endpoint")]
        public void Virtual_addressing_UseGlobalEndpoint_and_useast1_region_and_dualstack_uses_the_regional_dualstack_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseGlobalEndpoint"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3.dualstack.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing, UseGlobalEndpoint and us-east-1 region and accelerate uses the global accelerate endpoint")]
        public void Virtual_addressing_UseGlobalEndpoint_and_useast1_region_and_accelerate_uses_the_global_accelerate_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseGlobalEndpoint"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3-accelerate.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing, UseGlobalEndpoint and us-east-1 region with custom endpoint")]
        public void Virtual_addressing_UseGlobalEndpoint_and_useast1_region_with_custom_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            parameters["UseGlobalEndpoint"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("ForcePathStyle, aws-global region uses the global endpoint")]
        public void ForcePathStyle_awsglobal_region_uses_the_global_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.amazonaws.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("ForcePathStyle, aws-global region with fips is invalid")]
        public void ForcePathStyle_awsglobal_region_with_fips_is_invalid_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.us-east-1.amazonaws.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("ForcePathStyle, aws-global region with dualstack uses regional dualstack endpoint")]
        public void ForcePathStyle_awsglobal_region_with_dualstack_uses_regional_dualstack_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.dualstack.us-east-1.amazonaws.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("ForcePathStyle, aws-global region custom endpoint uses the custom endpoint")]
        public void ForcePathStyle_awsglobal_region_custom_endpoint_uses_the_custom_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Endpoint"] = "https://example.com";
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("ForcePathStyle, UseGlobalEndpoint us-east-1 region uses the global endpoint")]
        public void ForcePathStyle_UseGlobalEndpoint_useast1_region_uses_the_global_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket-name";
            parameters["UseGlobalEndpoint"] = true;
            parameters["ForcePathStyle"] = true;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.amazonaws.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("ForcePathStyle, UseGlobalEndpoint us-west-2 region uses the regional endpoint")]
        public void ForcePathStyle_UseGlobalEndpoint_uswest2_region_uses_the_regional_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "bucket-name";
            parameters["UseGlobalEndpoint"] = true;
            parameters["ForcePathStyle"] = true;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.us-west-2.amazonaws.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("ForcePathStyle, UseGlobalEndpoint us-east-1 region, dualstack uses the regional dualstack endpoint")]
        public void ForcePathStyle_UseGlobalEndpoint_useast1_region_dualstack_uses_the_regional_dualstack_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket-name";
            parameters["UseGlobalEndpoint"] = true;
            parameters["ForcePathStyle"] = true;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.dualstack.us-east-1.amazonaws.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("ForcePathStyle, UseGlobalEndpoint us-east-1 region custom endpoint uses the custom endpoint")]
        public void ForcePathStyle_UseGlobalEndpoint_useast1_region_custom_endpoint_uses_the_custom_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket-name";
            parameters["Endpoint"] = "https://example.com";
            parameters["UseGlobalEndpoint"] = true;
            parameters["ForcePathStyle"] = true;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("ARN with aws-global region and  UseArnRegion uses the regional endpoint")]
        public void ARN_with_awsglobal_region_and_UseArnRegion_uses_the_regional_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseArnRegion"] = true;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost/op-01234567890123456/accesspoint/reports";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://reports-123456789012.op-01234567890123456.s3-outposts.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("cross partition MRAP ARN is an error")]
        [ExpectedException(typeof(AmazonClientException), @"Client was configured for partition `aws` but bucket referred to partition `aws-cn`")]
        public void Cross_partition_MRAP_ARN_is_an_error_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Bucket"] = "arn:aws-cn:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap";
            parameters["Region"] = "us-west-1";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Endpoint override, accesspoint with HTTP, port")]
        public void Endpoint_override_accesspoint_with_HTTP_port_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Endpoint"] = "http://beta.example.com:1234";
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://myendpoint-123456789012.beta.example.com:1234", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Endpoint override, accesspoint with http, path, query, and port")]
        public void Endpoint_override_accesspoint_with_http_path_query_and_port_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint";
            parameters["Endpoint"] = "http://beta.example.com:1234/path";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://myendpoint-123456789012.beta.example.com:1234/path", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("non-bucket endpoint override with FIPS = error")]
        [ExpectedException(typeof(AmazonClientException), @"A custom endpoint cannot be combined with FIPS")]
        public void Nonbucket_endpoint_override_with_FIPS_error_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Endpoint"] = "http://beta.example.com:1234/path";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("FIPS + dualstack + custom endpoint")]
        [ExpectedException(typeof(AmazonClientException), @"Cannot set dual-stack in combination with a custom endpoint.")]
        public void FIPS_dualstack_custom_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Endpoint"] = "http://beta.example.com:1234/path";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("dualstack + custom endpoint")]
        [ExpectedException(typeof(AmazonClientException), @"Cannot set dual-stack in combination with a custom endpoint.")]
        public void Dualstack_custom_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Endpoint"] = "http://beta.example.com:1234/path";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("custom endpoint without FIPS/dualstack")]
        public void Custom_endpoint_without_FIPSdualstack_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Endpoint"] = "http://beta.example.com:1234/path";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://beta.example.com:1234/path", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("s3 object lambda with access points disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Access points are not supported for this operation")]
        public void S3_object_lambda_with_access_points_disabled_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint:myendpoint";
            parameters["DisableAccessPoints"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("non bucket + FIPS")]
        public void Non_bucket_FIPS_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("standard non bucket endpoint")]
        public void Standard_non_bucket_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("non bucket endpoint with FIPS + Dualstack")]
        public void Non_bucket_endpoint_with_FIPS_Dualstack_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.dualstack.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("non bucket endpoint with dualstack")]
        public void Non_bucket_endpoint_with_dualstack_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.dualstack.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("use global endpoint + IP address endpoint override")]
        public void Use_global_endpoint_IP_address_endpoint_override_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "http://127.0.0.1";
            parameters["UseGlobalEndpoint"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://127.0.0.1/bucket", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("non-dns endpoint + global endpoint")]
        public void Nondns_endpoint_global_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket!";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["UseGlobalEndpoint"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.amazonaws.com/bucket%21", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("endpoint override + use global endpoint")]
        public void Endpoint_override_use_global_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket!";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["UseGlobalEndpoint"] = true;
            parameters["Endpoint"] = "http://foo.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://foo.com/bucket%21", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("FIPS + dualstack + non-bucket endpoint")]
        public void FIPS_dualstack_nonbucket_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket!";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.dualstack.us-east-1.amazonaws.com/bucket%21", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("FIPS + dualstack + non-DNS endpoint")]
        public void FIPS_dualstack_nonDNS_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket!";
            parameters["ForcePathStyle"] = true;
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.dualstack.us-east-1.amazonaws.com/bucket%21", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("endpoint override + FIPS + dualstack (BUG)")]
        [ExpectedException(typeof(AmazonClientException), @"A custom endpoint cannot be combined with FIPS")]
        public void Endpoint_override_FIPS_dualstack_BUG_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket!";
            parameters["ForcePathStyle"] = true;
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "http://foo.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("endpoint override + non-dns bucket + FIPS (BUG)")]
        [ExpectedException(typeof(AmazonClientException), @"A custom endpoint cannot be combined with FIPS")]
        public void Endpoint_override_nondns_bucket_FIPS_BUG_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket!";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "http://foo.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("FIPS + bucket endpoint + force path style")]
        public void FIPS_bucket_endpoint_force_path_style_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket!";
            parameters["ForcePathStyle"] = true;
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseGlobalEndpoint"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.us-east-1.amazonaws.com/bucket%21", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("bucket + FIPS + force path style")]
        public void Bucket_FIPS_force_path_style_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket";
            parameters["ForcePathStyle"] = true;
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["UseGlobalEndpoint"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.dualstack.us-east-1.amazonaws.com/bucket", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("FIPS + dualstack + use global endpoint")]
        public void FIPS_dualstack_use_global_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["UseGlobalEndpoint"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket.s3-fips.dualstack.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("URI encoded bucket + use global endpoint")]
        [ExpectedException(typeof(AmazonClientException), @"A custom endpoint cannot be combined with FIPS")]
        public void URI_encoded_bucket_use_global_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket!";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseGlobalEndpoint"] = true;
            parameters["Endpoint"] = "https://foo.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("FIPS + path based endpoint")]
        public void FIPS_path_based_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket!";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseGlobalEndpoint"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.us-east-1.amazonaws.com/bucket%21", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("accelerate + dualstack + global endpoint")]
        public void Accelerate_dualstack_global_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Accelerate"] = true;
            parameters["UseGlobalEndpoint"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket.s3-accelerate.dualstack.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("dualstack + global endpoint + non URI safe bucket")]
        public void Dualstack_global_endpoint_non_URI_safe_bucket_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket!";
            parameters["Accelerate"] = false;
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["UseGlobalEndpoint"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.dualstack.us-east-1.amazonaws.com/bucket%21", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("FIPS + uri encoded bucket")]
        public void FIPS_uri_encoded_bucket_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket!";
            parameters["ForcePathStyle"] = true;
            parameters["Accelerate"] = false;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["UseGlobalEndpoint"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.us-east-1.amazonaws.com/bucket%21", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("endpoint override + non-uri safe endpoint + force path style")]
        [ExpectedException(typeof(AmazonClientException), @"A custom endpoint cannot be combined with FIPS")]
        public void Endpoint_override_nonuri_safe_endpoint_force_path_style_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket!";
            parameters["ForcePathStyle"] = true;
            parameters["Accelerate"] = false;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "http://foo.com";
            parameters["UseGlobalEndpoint"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("FIPS + Dualstack + global endpoint + non-dns bucket")]
        public void FIPS_Dualstack_global_endpoint_nondns_bucket_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "bucket!";
            parameters["Accelerate"] = false;
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            parameters["UseGlobalEndpoint"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.dualstack.us-east-1.amazonaws.com/bucket%21", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("endpoint override + FIPS + dualstack")]
        [ExpectedException(typeof(AmazonClientException), @"Cannot set dual-stack in combination with a custom endpoint.")]
        public void Endpoint_override_FIPS_dualstack_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            parameters["UseGlobalEndpoint"] = true;
            parameters["Endpoint"] = "http://foo.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("non-bucket endpoint override + dualstack + global endpoint")]
        [ExpectedException(typeof(AmazonClientException), @"Cannot set dual-stack in combination with a custom endpoint.")]
        public void Nonbucket_endpoint_override_dualstack_global_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["UseGlobalEndpoint"] = true;
            parameters["Endpoint"] = "http://foo.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Endpoint override + UseGlobalEndpoint + us-east-1")]
        [ExpectedException(typeof(AmazonClientException), @"A custom endpoint cannot be combined with FIPS")]
        public void Endpoint_override_UseGlobalEndpoint_useast1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseGlobalEndpoint"] = true;
            parameters["Endpoint"] = "http://foo.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("non-FIPS partition with FIPS set + custom endpoint")]
        [ExpectedException(typeof(AmazonClientException), @"Partition does not support FIPS")]
        public void NonFIPS_partition_with_FIPS_set_custom_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseGlobalEndpoint"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("aws-global signs as us-east-1")]
        public void Awsglobal_signs_as_useast1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket!";
            parameters["UseFIPS"] = true;
            parameters["Accelerate"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.dualstack.us-east-1.amazonaws.com/bucket%21", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("aws-global signs as us-east-1")]
        public void Awsglobal_signs_as_useast1_1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Accelerate"] = false;
            parameters["Endpoint"] = "https://foo.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket.foo.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("aws-global + dualstack + path-only bucket")]
        public void Awsglobal_dualstack_pathonly_bucket_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket!";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.dualstack.us-east-1.amazonaws.com/bucket%21", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("aws-global + path-only bucket")]
        public void Awsglobal_pathonly_bucket_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket!";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.amazonaws.com/bucket%21", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("aws-global + fips + custom endpoint")]
        [ExpectedException(typeof(AmazonClientException), @"A custom endpoint cannot be combined with FIPS")]
        public void Awsglobal_fips_custom_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket!";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Accelerate"] = false;
            parameters["Endpoint"] = "http://foo.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("aws-global, endpoint override & path only-bucket")]
        public void Awsglobal_endpoint_override_path_onlybucket_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket!";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Accelerate"] = false;
            parameters["Endpoint"] = "http://foo.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://foo.com/bucket%21", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("aws-global + dualstack + custom endpoint")]
        [ExpectedException(typeof(AmazonClientException), @"Cannot set dual-stack in combination with a custom endpoint.")]
        public void Awsglobal_dualstack_custom_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Accelerate"] = false;
            parameters["Endpoint"] = "http://foo.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("accelerate, dualstack + aws-global")]
        public void Accelerate_dualstack_awsglobal_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Accelerate"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket.s3-accelerate.dualstack.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("FIPS + aws-global + path only bucket. This is not supported by S3 but we allow garbage in garbage out")]
        public void FIPS_awsglobal_path_only_bucket_This_is_not_supported_by_S3_but_we_allow_garbage_in_garbage_out_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket!";
            parameters["ForcePathStyle"] = true;
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.dualstack.us-east-1.amazonaws.com/bucket%21", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("aws-global + FIPS + endpoint override.")]
        [ExpectedException(typeof(AmazonClientException), @"A custom endpoint cannot be combined with FIPS")]
        public void Awsglobal_FIPS_endpoint_override_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "http://foo.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("force path style, FIPS, aws-global & endpoint override")]
        [ExpectedException(typeof(AmazonClientException), @"A custom endpoint cannot be combined with FIPS")]
        public void Force_path_style_FIPS_awsglobal_endpoint_override_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket!";
            parameters["ForcePathStyle"] = true;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "http://foo.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("ip address causes path style to be forced")]
        public void Ip_address_causes_path_style_to_be_forced_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket";
            parameters["Endpoint"] = "http://192.168.1.1";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://192.168.1.1/bucket", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("endpoint override with aws-global region")]
        [ExpectedException(typeof(AmazonClientException), @"Cannot set dual-stack in combination with a custom endpoint.")]
        public void Endpoint_override_with_awsglobal_region_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "http://foo.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("FIPS + path-only (TODO: consider making this an error)")]
        public void FIPS_pathonly_TODO_consider_making_this_an_error_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket!";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.us-east-1.amazonaws.com/bucket%21", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("empty arn type")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: No ARN type specified")]
        public void Empty_arn_type_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["Bucket"] = "arn:aws:not-s3:us-west-2:123456789012::myendpoint";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style can't be used with accelerate")]
        [ExpectedException(typeof(AmazonClientException), @"Path-style addressing cannot be used with S3 Accelerate")]
        public void Path_style_cant_be_used_with_accelerate_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["Bucket"] = "bucket!";
            parameters["Accelerate"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("invalid region")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid region: region was not a valid DNS name.")]
        public void Invalid_region_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2!";
            parameters["Bucket"] = "bucket.subdomain";
            parameters["Endpoint"] = "http://foo.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("invalid region")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid region: region was not a valid DNS name.")]
        public void Invalid_region_1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2!";
            parameters["Bucket"] = "bucket";
            parameters["Endpoint"] = "http://foo.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("empty arn type")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Access Point Name")]
        public void Empty_arn_type_1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["Bucket"] = "arn:aws:s3::123456789012:accesspoint:my_endpoint";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("empty arn type")]
        [ExpectedException(typeof(AmazonClientException), @"Client was configured for partition `aws` but ARN (`arn:aws:s3:cn-north-1:123456789012:accesspoint:my-endpoint`) has `aws-cn`")]
        public void Empty_arn_type_2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["Bucket"] = "arn:aws:s3:cn-north-1:123456789012:accesspoint:my-endpoint";
            parameters["UseArnRegion"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("invalid arn region")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid region in ARN: `us-east_2` (invalid DNS name)")]
        public void Invalid_arn_region_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-east_2:123456789012:accesspoint:my-endpoint";
            parameters["UseArnRegion"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("invalid ARN outpost")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: The outpost Id may only contain a-z, A-Z, 0-9 and `-`. Found: `op_01234567890123456`")]
        public void Invalid_ARN_outpost_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost/op_01234567890123456/accesspoint/reports";
            parameters["UseArnRegion"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("invalid ARN")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: expected an access point name")]
        public void Invalid_ARN_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost/op-01234567890123456/reports";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("invalid ARN")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Expected a 4-component resource")]
        public void Invalid_ARN_1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost/op-01234567890123456";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("invalid outpost type")]
        [ExpectedException(typeof(AmazonClientException), @"Expected an outpost type `accesspoint`, found not-accesspoint")]
        public void Invalid_outpost_type_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost/op-01234567890123456/not-accesspoint/reports";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("invalid outpost type")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid region in ARN: `us-east_1` (invalid DNS name)")]
        public void Invalid_outpost_type_1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east_1:123456789012:outpost/op-01234567890123456/not-accesspoint/reports";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("invalid outpost type")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: The account id may only contain a-z, A-Z, 0-9 and `-`. Found: `12345_789012`")]
        public void Invalid_outpost_type_2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:12345_789012:outpost/op-01234567890123456/not-accesspoint/reports";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("invalid outpost type")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: The Outpost Id was not set")]
        public void Invalid_outpost_type_3_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:12345789012:outpost";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("use global endpoint virtual addressing")]
        public void Use_global_endpoint_virtual_addressing_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["Bucket"] = "bucket";
            parameters["Endpoint"] = "http://example.com";
            parameters["UseGlobalEndpoint"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://bucket.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("global endpoint + ip address")]
        public void Global_endpoint_ip_address_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["Bucket"] = "bucket";
            parameters["Endpoint"] = "http://192.168.0.1";
            parameters["UseGlobalEndpoint"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://192.168.0.1/bucket", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("invalid outpost type")]
        public void Invalid_outpost_type_4_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["Bucket"] = "bucket!";
            parameters["UseGlobalEndpoint"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.us-east-2.amazonaws.com/bucket%21", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("invalid outpost type")]
        public void Invalid_outpost_type_5_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["Bucket"] = "bucket";
            parameters["Accelerate"] = true;
            parameters["UseGlobalEndpoint"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket.s3-accelerate.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("use global endpoint + custom endpoint")]
        public void Use_global_endpoint_custom_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["Bucket"] = "bucket!";
            parameters["UseGlobalEndpoint"] = true;
            parameters["Endpoint"] = "http://foo.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://foo.com/bucket%21", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("use global endpoint, not us-east-1, force path style")]
        public void Use_global_endpoint_not_useast1_force_path_style_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["Bucket"] = "bucket!";
            parameters["UseGlobalEndpoint"] = true;
            parameters["ForcePathStyle"] = true;
            parameters["Endpoint"] = "http://foo.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://foo.com/bucket%21", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("vanilla virtual addressing@us-west-2")]
        public void Vanilla_virtual_addressinguswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing + dualstack@us-west-2")]
        public void Virtual_addressing_dualstackuswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3.dualstack.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("accelerate + dualstack@us-west-2")]
        public void Accelerate_dualstackuswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3-accelerate.dualstack.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("accelerate (dualstack=false)@us-west-2")]
        public void Accelerate_dualstackfalseuswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3-accelerate.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing + fips@us-west-2")]
        public void Virtual_addressing_fipsuswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing + dualstack + fips@us-west-2")]
        public void Virtual_addressing_dualstack_fipsuswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3-fips.dualstack.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("accelerate + fips = error@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Accelerate cannot be used with FIPS")]
        public void Accelerate_fips_erroruswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("vanilla virtual addressing@cn-north-1")]
        public void Vanilla_virtual_addressingcnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing + dualstack@cn-north-1")]
        public void Virtual_addressing_dualstackcnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3.dualstack.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("accelerate (dualstack=false)@cn-north-1")]
        [ExpectedException(typeof(AmazonClientException), @"S3 Accelerate cannot be used in this region")]
        public void Accelerate_dualstackfalsecnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing + fips@cn-north-1")]
        [ExpectedException(typeof(AmazonClientException), @"Partition does not support FIPS")]
        public void Virtual_addressing_fipscnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("vanilla virtual addressing@af-south-1")]
        public void Vanilla_virtual_addressingafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing + dualstack@af-south-1")]
        public void Virtual_addressing_dualstackafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3.dualstack.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("accelerate + dualstack@af-south-1")]
        public void Accelerate_dualstackafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3-accelerate.dualstack.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("accelerate (dualstack=false)@af-south-1")]
        public void Accelerate_dualstackfalseafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3-accelerate.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing + fips@af-south-1")]
        public void Virtual_addressing_fipsafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing + dualstack + fips@af-south-1")]
        public void Virtual_addressing_dualstack_fipsafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3-fips.dualstack.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("accelerate + fips = error@af-south-1")]
        [ExpectedException(typeof(AmazonClientException), @"Accelerate cannot be used with FIPS")]
        public void Accelerate_fips_errorafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("vanilla path style@us-west-2")]
        public void Vanilla_path_styleuswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.us-west-2.amazonaws.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("fips@us-gov-west-2, bucket is not S3-dns-compatible (subdomains)")]
        public void Fipsusgovwest2_bucket_is_not_S3dnscompatible_subdomains_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket.with.dots";
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.us-gov-west-1.amazonaws.com/bucket.with.dots", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + accelerate = error@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Path-style addressing cannot be used with S3 Accelerate")]
        public void Path_style_accelerate_erroruswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + dualstack@us-west-2")]
        public void Path_style_dualstackuswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.dualstack.us-west-2.amazonaws.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + arn is error@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Path-style addressing cannot be used with ARN buckets")]
        public void Path_style_arn_is_erroruswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:PARTITION:s3-outposts:REGION:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + invalid DNS name@us-west-2")]
        public void Path_style_invalid_DNS_nameuswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "99a_b";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.us-west-2.amazonaws.com/99a_b", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("no path style + invalid DNS name@us-west-2")]
        public void No_path_style_invalid_DNS_nameuswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "99a_b";
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.us-west-2.amazonaws.com/99a_b", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("vanilla path style@cn-north-1")]
        public void Vanilla_path_stylecnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.cn-north-1.amazonaws.com.cn/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + fips@cn-north-1")]
        [ExpectedException(typeof(AmazonClientException), @"Partition does not support FIPS")]
        public void Path_style_fipscnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + accelerate = error@cn-north-1")]
        [ExpectedException(typeof(AmazonClientException), @"Path-style addressing cannot be used with S3 Accelerate")]
        public void Path_style_accelerate_errorcnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + dualstack@cn-north-1")]
        public void Path_style_dualstackcnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.dualstack.cn-north-1.amazonaws.com.cn/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + arn is error@cn-north-1")]
        [ExpectedException(typeof(AmazonClientException), @"Path-style addressing cannot be used with ARN buckets")]
        public void Path_style_arn_is_errorcnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:PARTITION:s3-outposts:REGION:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + invalid DNS name@cn-north-1")]
        public void Path_style_invalid_DNS_namecnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "99a_b";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.cn-north-1.amazonaws.com.cn/99a_b", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("no path style + invalid DNS name@cn-north-1")]
        public void No_path_style_invalid_DNS_namecnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "99a_b";
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.cn-north-1.amazonaws.com.cn/99a_b", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("vanilla path style@af-south-1")]
        public void Vanilla_path_styleafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.af-south-1.amazonaws.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + fips@af-south-1")]
        public void Path_style_fipsafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-fips.af-south-1.amazonaws.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + accelerate = error@af-south-1")]
        [ExpectedException(typeof(AmazonClientException), @"Path-style addressing cannot be used with S3 Accelerate")]
        public void Path_style_accelerate_errorafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + dualstack@af-south-1")]
        public void Path_style_dualstackafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.dualstack.af-south-1.amazonaws.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + arn is error@af-south-1")]
        [ExpectedException(typeof(AmazonClientException), @"Path-style addressing cannot be used with ARN buckets")]
        public void Path_style_arn_is_errorafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:PARTITION:s3-outposts:REGION:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + invalid DNS name@af-south-1")]
        public void Path_style_invalid_DNS_nameafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "99a_b";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.af-south-1.amazonaws.com/99a_b", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("no path style + invalid DNS name@af-south-1")]
        public void No_path_style_invalid_DNS_nameafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "99a_b";
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.af-south-1.amazonaws.com/99a_b", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing + private link@us-west-2")]
        public void Virtual_addressing_private_linkuswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Endpoint"] = "http://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com";
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://bucket-name.control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + private link@us-west-2")]
        public void Path_style_private_linkuswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["Endpoint"] = "https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com";
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::Host + FIPS@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"A custom endpoint cannot be combined with FIPS")]
        public void SDKHost_FIPSuswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Endpoint"] = "https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com";
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::Host + DualStack@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Cannot set dual-stack in combination with a custom endpoint.")]
        public void SDKHost_DualStackuswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Endpoint"] = "https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com";
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::HOST + accelerate@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"A custom endpoint cannot be combined with S3 Accelerate")]
        public void SDKHOST_accelerateuswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Endpoint"] = "http://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com";
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::Host + access point ARN@us-west-2")]
        public void SDKHost_access_point_ARNuswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myendpoint-123456789012.beta.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing + private link@cn-north-1")]
        public void Virtual_addressing_private_linkcnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Endpoint"] = "https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com";
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + private link@cn-north-1")]
        public void Path_style_private_linkcnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["Endpoint"] = "https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com";
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("FIPS@cn-north-1")]
        [ExpectedException(typeof(AmazonClientException), @"Partition does not support FIPS")]
        public void FIPScnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::Host + DualStack@cn-north-1")]
        [ExpectedException(typeof(AmazonClientException), @"Cannot set dual-stack in combination with a custom endpoint.")]
        public void SDKHost_DualStackcnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Endpoint"] = "https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com";
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::HOST + accelerate@cn-north-1")]
        [ExpectedException(typeof(AmazonClientException), @"A custom endpoint cannot be combined with S3 Accelerate")]
        public void SDKHOST_acceleratecnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Endpoint"] = "https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com";
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::Host + access point ARN@cn-north-1")]
        public void SDKHost_access_point_ARNcnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws-cn:s3:cn-north-1:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myendpoint-123456789012.beta.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("virtual addressing + private link@af-south-1")]
        public void Virtual_addressing_private_linkafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Endpoint"] = "https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com";
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + private link@af-south-1")]
        public void Path_style_private_linkafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["Endpoint"] = "https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com";
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::Host + FIPS@af-south-1")]
        [ExpectedException(typeof(AmazonClientException), @"A custom endpoint cannot be combined with FIPS")]
        public void SDKHost_FIPSafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Endpoint"] = "https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com";
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::Host + DualStack@af-south-1")]
        [ExpectedException(typeof(AmazonClientException), @"Cannot set dual-stack in combination with a custom endpoint.")]
        public void SDKHost_DualStackafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Endpoint"] = "https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com";
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::HOST + accelerate@af-south-1")]
        [ExpectedException(typeof(AmazonClientException), @"A custom endpoint cannot be combined with S3 Accelerate")]
        public void SDKHOST_accelerateafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = true;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Endpoint"] = "https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com";
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::Host + access point ARN@af-south-1")]
        public void SDKHost_access_point_ARNafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3:af-south-1:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myendpoint-123456789012.beta.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("vanilla access point arn@us-west-2")]
        public void Vanilla_access_point_arnuswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myendpoint-123456789012.s3-accesspoint.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("access point arn + FIPS@us-west-2")]
        public void Access_point_arn_FIPSuswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myendpoint-123456789012.s3-accesspoint-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("access point arn + accelerate = error@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Access Points do not support S3 Accelerate")]
        public void Access_point_arn_accelerate_erroruswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = true;
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("access point arn + FIPS + DualStack@us-west-2")]
        public void Access_point_arn_FIPS_DualStackuswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myendpoint-123456789012.s3-accesspoint-fips.dualstack.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("vanilla access point arn@cn-north-1")]
        public void Vanilla_access_point_arncnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws-cn:s3:cn-north-1:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myendpoint-123456789012.s3-accesspoint.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("access point arn + FIPS@cn-north-1")]
        [ExpectedException(typeof(AmazonClientException), @"Partition does not support FIPS")]
        public void Access_point_arn_FIPScnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws-cn:s3:cn-north-1:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("access point arn + accelerate = error@cn-north-1")]
        [ExpectedException(typeof(AmazonClientException), @"Access Points do not support S3 Accelerate")]
        public void Access_point_arn_accelerate_errorcnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = true;
            parameters["Bucket"] = "arn:aws-cn:s3:cn-north-1:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("access point arn + FIPS + DualStack@cn-north-1")]
        [ExpectedException(typeof(AmazonClientException), @"Partition does not support FIPS")]
        public void Access_point_arn_FIPS_DualStackcnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws-cn:s3:cn-north-1:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("vanilla access point arn@af-south-1")]
        public void Vanilla_access_point_arnafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3:af-south-1:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myendpoint-123456789012.s3-accesspoint.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("access point arn + FIPS@af-south-1")]
        public void Access_point_arn_FIPSafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3:af-south-1:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myendpoint-123456789012.s3-accesspoint-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("access point arn + accelerate = error@af-south-1")]
        [ExpectedException(typeof(AmazonClientException), @"Access Points do not support S3 Accelerate")]
        public void Access_point_arn_accelerate_errorafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = true;
            parameters["Bucket"] = "arn:aws:s3:af-south-1:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("access point arn + FIPS + DualStack@af-south-1")]
        public void Access_point_arn_FIPS_DualStackafsouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3:af-south-1:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myendpoint-123456789012.s3-accesspoint-fips.dualstack.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 outposts vanilla test")]
        public void S3_outposts_vanilla_test_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost/op-01234567890123456/accesspoint/reports";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://reports-123456789012.op-01234567890123456.s3-outposts.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 outposts custom endpoint")]
        public void S3_outposts_custom_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost/op-01234567890123456/accesspoint/reports";
            parameters["Endpoint"] = "https://example.amazonaws.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://reports-123456789012.op-01234567890123456.example.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("outposts arn with region mismatch and UseArnRegion=false")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: region from ARN `us-east-1` does not match client region `us-west-2` and UseArnRegion is `false`")]
        public void Outposts_arn_with_region_mismatch_and_UseArnRegionfalse_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["ForcePathStyle"] = false;
            parameters["UseArnRegion"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("outposts arn with region mismatch, custom region and UseArnRegion=false")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: region from ARN `us-east-1` does not match client region `us-west-2` and UseArnRegion is `false`")]
        public void Outposts_arn_with_region_mismatch_custom_region_and_UseArnRegionfalse_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["Endpoint"] = "https://example.com";
            parameters["ForcePathStyle"] = false;
            parameters["UseArnRegion"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("outposts arn with region mismatch and UseArnRegion=true")]
        public void Outposts_arn_with_region_mismatch_and_UseArnRegiontrue_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["ForcePathStyle"] = false;
            parameters["UseArnRegion"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint-123456789012.op-01234567890123456.s3-outposts.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("outposts arn with region mismatch and UseArnRegion unset")]
        public void Outposts_arn_with_region_mismatch_and_UseArnRegion_unset_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["ForcePathStyle"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint-123456789012.op-01234567890123456.s3-outposts.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("outposts arn with partition mismatch and UseArnRegion=true")]
        [ExpectedException(typeof(AmazonClientException), @"Client was configured for partition `aws` but ARN (`arn:aws:s3-outposts:cn-north-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint`) has `aws-cn`")]
        public void Outposts_arn_with_partition_mismatch_and_UseArnRegiontrue_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3-outposts:cn-north-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["ForcePathStyle"] = false;
            parameters["UseArnRegion"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("ARN with UseGlobalEndpoint and use-east-1 region uses the regional endpoint")]
        public void ARN_with_UseGlobalEndpoint_and_useeast1_region_uses_the_regional_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost/op-01234567890123456/accesspoint/reports";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://reports-123456789012.op-01234567890123456.s3-outposts.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 outposts does not support dualstack")]
        [ExpectedException(typeof(AmazonClientException), @"S3 Outposts does not support Dual-stack")]
        public void S3_outposts_does_not_support_dualstack_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost/op-01234567890123456/accesspoint/reports";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 outposts does not support fips")]
        [ExpectedException(typeof(AmazonClientException), @"S3 Outposts does not support FIPS")]
        public void S3_outposts_does_not_support_fips_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost/op-01234567890123456/accesspoint/reports";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 outposts does not support accelerate")]
        [ExpectedException(typeof(AmazonClientException), @"S3 Outposts does not support S3 Accelerate")]
        public void S3_outposts_does_not_support_accelerate_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = true;
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost/op-01234567890123456/accesspoint/reports";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("validates against subresource")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Arn: Outpost Access Point ARN contains sub resources")]
        public void Validates_against_subresource_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:mybucket:object:foo";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda @us-east-1")]
        public void Object_lambda_useast1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = false;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-east-1:123456789012:accesspoint/mybanner";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybanner-123456789012.s3-object-lambda.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda @us-west-2")]
        public void Object_lambda_uswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = false;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint/mybanner";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybanner-123456789012.s3-object-lambda.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda, colon resource deliminator @us-west-2")]
        public void Object_lambda_colon_resource_deliminator_uswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = false;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint:mybanner";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybanner-123456789012.s3-object-lambda.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda @us-east-1, client region us-west-2, useArnRegion=true")]
        public void Object_lambda_useast1_client_region_uswest2_useArnRegiontrue_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = true;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-east-1:123456789012:accesspoint/mybanner";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybanner-123456789012.s3-object-lambda.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda @us-east-1, client region s3-external-1, useArnRegion=true")]
        public void Object_lambda_useast1_client_region_s3external1_useArnRegiontrue_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "s3-external-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = true;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-east-1:123456789012:accesspoint/mybanner";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybanner-123456789012.s3-object-lambda.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda @us-east-1, client region s3-external-1, useArnRegion=false")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: region from ARN `us-east-1` does not match client region `s3-external-1` and UseArnRegion is `false`")]
        public void Object_lambda_useast1_client_region_s3external1_useArnRegionfalse_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "s3-external-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = false;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-east-1:123456789012:accesspoint/mybanner";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda @us-east-1, client region aws-global, useArnRegion=true")]
        public void Object_lambda_useast1_client_region_awsglobal_useArnRegiontrue_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = true;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-east-1:123456789012:accesspoint/mybanner";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybanner-123456789012.s3-object-lambda.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda @us-east-1, client region aws-global, useArnRegion=false")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: region from ARN `us-east-1` does not match client region `aws-global` and UseArnRegion is `false`")]
        public void Object_lambda_useast1_client_region_awsglobal_useArnRegionfalse_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = false;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-east-1:123456789012:accesspoint/mybanner";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda @cn-north-1, client region us-west-2 (cross partition), useArnRegion=true")]
        [ExpectedException(typeof(AmazonClientException), @"Client was configured for partition `aws` but ARN (`arn:aws-cn:s3-object-lambda:cn-north-1:123456789012:accesspoint/mybanner`) has `aws-cn`")]
        public void Object_lambda_cnnorth1_client_region_uswest2_cross_partition_useArnRegiontrue_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = true;
            parameters["Bucket"] = "arn:aws-cn:s3-object-lambda:cn-north-1:123456789012:accesspoint/mybanner";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda with dualstack")]
        [ExpectedException(typeof(AmazonClientException), @"S3 Object Lambda does not support Dual-stack")]
        public void Object_lambda_with_dualstack_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = false;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint/mybanner";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda @us-gov-east-1")]
        public void Object_lambda_usgoveast1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = false;
            parameters["Bucket"] = "arn:aws-us-gov:s3-object-lambda:us-gov-east-1:123456789012:accesspoint/mybanner";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybanner-123456789012.s3-object-lambda.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda @us-gov-east-1, with fips")]
        public void Object_lambda_usgoveast1_with_fips_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = false;
            parameters["Bucket"] = "arn:aws-us-gov:s3-object-lambda:us-gov-east-1:123456789012:accesspoint/mybanner";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybanner-123456789012.s3-object-lambda-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda @cn-north-1, with fips")]
        [ExpectedException(typeof(AmazonClientException), @"Partition does not support FIPS")]
        public void Object_lambda_cnnorth1_with_fips_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = false;
            parameters["Bucket"] = "arn:aws-cn:s3-object-lambda:cn-north-1:123456789012:accesspoint/mybanner";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda with accelerate")]
        [ExpectedException(typeof(AmazonClientException), @"S3 Object Lambda does not support S3 Accelerate")]
        public void Object_lambda_with_accelerate_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = true;
            parameters["UseArnRegion"] = false;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint/mybanner";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda with invalid arn - bad service and someresource")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Unrecognized format: arn:aws:sqs:us-west-2:123456789012:someresource (type: someresource)")]
        public void Object_lambda_with_invalid_arn_bad_service_and_someresource_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = false;
            parameters["Bucket"] = "arn:aws:sqs:us-west-2:123456789012:someresource";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda with invalid arn - invalid resource")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Object Lambda ARNs only support `accesspoint` arn types, but found: `bucket_name`")]
        public void Object_lambda_with_invalid_arn_invalid_resource_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = false;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-west-2:123456789012:bucket_name:mybucket";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda with invalid arn - missing region")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: bucket ARN is missing a region")]
        public void Object_lambda_with_invalid_arn_missing_region_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = false;
            parameters["Bucket"] = "arn:aws:s3-object-lambda::123456789012:accesspoint/mybanner";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda with invalid arn - missing account-id")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Missing account id")]
        public void Object_lambda_with_invalid_arn_missing_accountid_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = true;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-west-2::accesspoint/mybanner";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda with invalid arn - account id contains invalid characters")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: The account id may only contain a-z, A-Z, 0-9 and `-`. Found: `123.45678.9012`")]
        public void Object_lambda_with_invalid_arn_account_id_contains_invalid_characters_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = true;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-west-2:123.45678.9012:accesspoint:mybucket";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda with invalid arn - missing access point name")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Expected a resource of the format `accesspoint:<accesspoint name>` but no name was provided")]
        public void Object_lambda_with_invalid_arn_missing_access_point_name_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = true;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda with invalid arn - access point name contains invalid character: *")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: The access point name may only contain a-z, A-Z, 0-9 and `-`. Found: `*`")]
        public void Object_lambda_with_invalid_arn_access_point_name_contains_invalid_character__Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = true;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint:*";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda with invalid arn - access point name contains invalid character: .")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: The access point name may only contain a-z, A-Z, 0-9 and `-`. Found: `my.bucket`")]
        public void Object_lambda_with_invalid_arn_access_point_name_contains_invalid_character__1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = true;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint:my.bucket";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda with invalid arn - access point name contains sub resources")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: The ARN may only contain a single resource component after `accesspoint`.")]
        public void Object_lambda_with_invalid_arn_access_point_name_contains_sub_resources_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = true;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint:mybucket:object:foo";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda with custom endpoint")]
        public void Object_lambda_with_custom_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseArnRegion"] = false;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-west-2:123456789012:accesspoint/mybanner";
            parameters["Endpoint"] = "https://my-endpoint.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybanner-123456789012.my-endpoint.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("object lambda arn with region mismatch and UseArnRegion=false")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: region from ARN `us-east-1` does not match client region `us-west-2` and UseArnRegion is `false`")]
        public void Object_lambda_arn_with_region_mismatch_and_UseArnRegionfalse_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws:s3-object-lambda:us-east-1:123456789012:accesspoint/mybanner";
            parameters["ForcePathStyle"] = false;
            parameters["UseArnRegion"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("WriteGetObjectResponse @ us-west-2")]
        public void WriteGetObjectResponse_uswest2_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["UseObjectLambdaEndpoint"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-object-lambda.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("WriteGetObjectResponse with custom endpoint")]
        public void WriteGetObjectResponse_with_custom_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["UseObjectLambdaEndpoint"] = true;
            parameters["Endpoint"] = "https://my-endpoint.com";
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://my-endpoint.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("WriteGetObjectResponse @ us-east-1")]
        public void WriteGetObjectResponse_useast1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["UseObjectLambdaEndpoint"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-object-lambda.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("WriteGetObjectResponse with fips")]
        public void WriteGetObjectResponse_with_fips_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["UseObjectLambdaEndpoint"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-object-lambda-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("WriteGetObjectResponse with dualstack")]
        [ExpectedException(typeof(AmazonClientException), @"S3 Object Lambda does not support Dual-stack")]
        public void WriteGetObjectResponse_with_dualstack_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["UseObjectLambdaEndpoint"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("WriteGetObjectResponse with accelerate")]
        [ExpectedException(typeof(AmazonClientException), @"S3 Object Lambda does not support S3 Accelerate")]
        public void WriteGetObjectResponse_with_accelerate_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = true;
            parameters["UseObjectLambdaEndpoint"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("WriteGetObjectResponse with fips in CN")]
        [ExpectedException(typeof(AmazonClientException), @"Partition does not support FIPS")]
        public void WriteGetObjectResponse_with_fips_in_CN_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseObjectLambdaEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("WriteGetObjectResponse with invalid partition")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid region: region was not a valid DNS name.")]
        public void WriteGetObjectResponse_with_invalid_partition_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["UseObjectLambdaEndpoint"] = true;
            parameters["Region"] = "not a valid DNS name";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("WriteGetObjectResponse with an unknown partition")]
        public void WriteGetObjectResponse_with_an_unknown_partition_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["UseObjectLambdaEndpoint"] = true;
            parameters["Region"] = "us-east.special";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-object-lambda.us-east.special.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 Outposts bucketAlias Real Outpost Prod us-west-1")]
        public void S3_Outposts_bucketAlias_Real_Outpost_Prod_uswest1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["Bucket"] = "test-accessp-o0b1d075431d83bebde8xz5w8ijx1qzlbp3i3kuse10--op-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://test-accessp-o0b1d075431d83bebde8xz5w8ijx1qzlbp3i3kuse10--op-s3.op-0b1d075431d83bebd.s3-outposts.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 Outposts bucketAlias Real Outpost Prod ap-east-1")]
        public void S3_Outposts_bucketAlias_Real_Outpost_Prod_apeast1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["Bucket"] = "test-accessp-o0b1d075431d83bebde8xz5w8ijx1qzlbp3i3kuse10--op-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://test-accessp-o0b1d075431d83bebde8xz5w8ijx1qzlbp3i3kuse10--op-s3.op-0b1d075431d83bebd.s3-outposts.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 Outposts bucketAlias Ec2 Outpost Prod us-east-1")]
        public void S3_Outposts_bucketAlias_Ec2_Outpost_Prod_useast1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "test-accessp-e0000075431d83bebde8xz5w8ijx1qzlbp3i3kuse10--op-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://test-accessp-e0000075431d83bebde8xz5w8ijx1qzlbp3i3kuse10--op-s3.ec2.s3-outposts.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 Outposts bucketAlias Ec2 Outpost Prod me-south-1")]
        public void S3_Outposts_bucketAlias_Ec2_Outpost_Prod_mesouth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["Bucket"] = "test-accessp-e0000075431d83bebde8xz5w8ijx1qzlbp3i3kuse10--op-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://test-accessp-e0000075431d83bebde8xz5w8ijx1qzlbp3i3kuse10--op-s3.ec2.s3-outposts.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 Outposts bucketAlias Real Outpost Beta")]
        public void S3_Outposts_bucketAlias_Real_Outpost_Beta_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "test-accessp-o0b1d075431d83bebde8xz5w8ijx1qzlbp3i3kbeta0--op-s3";
            parameters["Endpoint"] = "https://example.amazonaws.com";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://test-accessp-o0b1d075431d83bebde8xz5w8ijx1qzlbp3i3kbeta0--op-s3.op-0b1d075431d83bebd.example.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 Outposts bucketAlias Ec2 Outpost Beta")]
        public void S3_Outposts_bucketAlias_Ec2_Outpost_Beta_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "161743052723-e00000136899934034jeahy1t8gpzpbwjj8kb7beta0--op-s3";
            parameters["Endpoint"] = "https://example.amazonaws.com";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://161743052723-e00000136899934034jeahy1t8gpzpbwjj8kb7beta0--op-s3.ec2.example.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 Outposts bucketAlias - No endpoint set for beta")]
        [ExpectedException(typeof(AmazonClientException), @"Expected a endpoint to be specified but no endpoint was found")]
        public void S3_Outposts_bucketAlias_No_endpoint_set_for_beta_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "test-accessp-o0b1d075431d83bebde8xz5w8ijx1qzlbp3i3kbeta0--op-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 Outposts bucketAlias Invalid hardware type")]
        [ExpectedException(typeof(AmazonClientException), @"Unrecognized hardware type: ""Expected hardware type o or e but got h""")]
        public void S3_Outposts_bucketAlias_Invalid_hardware_type_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "test-accessp-h0000075431d83bebde8xz5w8ijx1qzlbp3i3kuse10--op-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 Outposts bucketAlias Special character in Outpost Arn")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: The outpost Id must only contain a-z, A-Z, 0-9 and `-`.")]
        public void S3_Outposts_bucketAlias_Special_character_in_Outpost_Arn_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "test-accessp-o00000754%1d83bebde8xz5w8ijx1qzlbp3i3kuse10--op-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 Outposts bucketAlias - No endpoint set for beta")]
        [ExpectedException(typeof(AmazonClientException), @"Expected a endpoint to be specified but no endpoint was found")]
        public void S3_Outposts_bucketAlias_No_endpoint_set_for_beta_1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "test-accessp-e0b1d075431d83bebde8xz5w8ijx1qzlbp3i3ebeta0--op-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 Snow with bucket")]
        public void S3_Snow_with_bucket_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "snow";
            parameters["Bucket"] = "bucketName";
            parameters["Endpoint"] = "http://10.0.1.12:433";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://10.0.1.12:433/bucketName", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 Snow without bucket")]
        public void S3_Snow_without_bucket_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "snow";
            parameters["Endpoint"] = "https://10.0.1.12:433";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://10.0.1.12:433", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 Snow no port")]
        public void S3_Snow_no_port_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "snow";
            parameters["Bucket"] = "bucketName";
            parameters["Endpoint"] = "http://10.0.1.12";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://10.0.1.12/bucketName", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("S3 Snow dns endpoint")]
        public void S3_Snow_dns_endpoint_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "snow";
            parameters["Bucket"] = "bucketName";
            parameters["Endpoint"] = "https://amazonaws.com";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amazonaws.com/bucketName", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with short zone name")]
        public void Data_Plane_with_short_zone_name_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "mybucket--abcd-ab1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--abcd-ab1--x-s3.s3express-abcd-ab1.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with short zone name china region")]
        public void Data_Plane_with_short_zone_name_china_region_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["Bucket"] = "mybucket--abcd-ab1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--abcd-ab1--x-s3.s3express-abcd-ab1.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with short zone name with AP")]
        public void Data_Plane_with_short_zone_name_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "myaccesspoint--abcd-ab1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--abcd-ab1--xa-s3.s3express-abcd-ab1.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with short zone name with AP china region")]
        public void Data_Plane_with_short_zone_name_with_AP_china_region_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["Bucket"] = "myaccesspoint--abcd-ab1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--abcd-ab1--xa-s3.s3express-abcd-ab1.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with short zone names (13 chars)")]
        public void Data_Plane_with_short_zone_names_13_chars_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--test-zone-ab1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--test-zone-ab1--x-s3.s3express-test-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with short zone names (13 chars) with AP")]
        public void Data_Plane_with_short_zone_names_13_chars_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--test-zone-ab1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--test-zone-ab1--xa-s3.s3express-test-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with medium zone names (14 chars)")]
        public void Data_Plane_with_medium_zone_names_14_chars_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--test1-zone-ab1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--test1-zone-ab1--x-s3.s3express-test1-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with medium zone names (14 chars) with AP")]
        public void Data_Plane_with_medium_zone_names_14_chars_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--test1-zone-ab1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--test1-zone-ab1--xa-s3.s3express-test1-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with long zone names (20 chars)")]
        public void Data_Plane_with_long_zone_names_20_chars_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--test1-long1-zone-ab1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--test1-long1-zone-ab1--x-s3.s3express-test1-long1-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with long zone names (20 chars)")]
        public void Data_Plane_with_long_zone_names_20_chars_1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--test1-long1-zone-ab1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--test1-long1-zone-ab1--xa-s3.s3express-test1-long1-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with short zone fips")]
        public void Data_Plane_with_short_zone_fips_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "mybucket--test-ab1--x-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--test-ab1--x-s3.s3express-fips-test-ab1.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with short zone fips china region")]
        [ExpectedException(typeof(AmazonClientException), @"Partition does not support FIPS")]
        public void Data_Plane_with_short_zone_fips_china_region_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["Bucket"] = "mybucket--test-ab1--x-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with short zone fips with AP")]
        public void Data_Plane_with_short_zone_fips_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "myaccesspoint--test-ab1--xa-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--test-ab1--xa-s3.s3express-fips-test-ab1.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with short zone fips with AP china region")]
        [ExpectedException(typeof(AmazonClientException), @"Partition does not support FIPS")]
        public void Data_Plane_with_short_zone_fips_with_AP_china_region_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["Bucket"] = "myaccesspoint--test-ab1--xa-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with short zone (13 chars) fips")]
        public void Data_Plane_with_short_zone_13_chars_fips_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--test-zone-ab1--x-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--test-zone-ab1--x-s3.s3express-fips-test-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with short zone (13 chars) fips with AP")]
        public void Data_Plane_with_short_zone_13_chars_fips_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--test-zone-ab1--xa-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--test-zone-ab1--xa-s3.s3express-fips-test-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with medium zone (14 chars) fips")]
        public void Data_Plane_with_medium_zone_14_chars_fips_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--test1-zone-ab1--x-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--test1-zone-ab1--x-s3.s3express-fips-test1-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with medium zone (14 chars) fips with AP")]
        public void Data_Plane_with_medium_zone_14_chars_fips_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--test1-zone-ab1--xa-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--test1-zone-ab1--xa-s3.s3express-fips-test1-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with long zone (20 chars) fips")]
        public void Data_Plane_with_long_zone_20_chars_fips_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--test1-long1-zone-ab1--x-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--test1-long1-zone-ab1--x-s3.s3express-fips-test1-long1-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with long zone (20 chars) fips with AP")]
        public void Data_Plane_with_long_zone_20_chars_fips_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--test1-long1-zone-ab1--xa-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--test1-long1-zone-ab1--xa-s3.s3express-fips-test1-long1-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with long AZ")]
        public void Data_Plane_with_long_AZ_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--test1-az1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--test1-az1--x-s3.s3express-test1-az1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with long AZ with AP")]
        public void Data_Plane_with_long_AZ_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--test1-az1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--test1-az1--xa-s3.s3express-test1-az1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with long AZ fips")]
        public void Data_Plane_with_long_AZ_fips_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--test1-az1--x-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--test1-az1--x-s3.s3express-fips-test1-az1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane with long AZ fips with AP")]
        public void Data_Plane_with_long_AZ_fips_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--test1-az1--xa-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--test1-az1--xa-s3.s3express-fips-test1-az1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Control plane with short AZ bucket")]
        public void Control_plane_with_short_AZ_bucket_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "mybucket--test-ab1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = true;
            parameters["DisableS3ExpressSessionAuth"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3express-control.us-east-1.amazonaws.com/mybucket--test-ab1--x-s3", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Control plane with short AZ bucket china region")]
        public void Control_plane_with_short_AZ_bucket_china_region_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["Bucket"] = "mybucket--test-ab1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = true;
            parameters["DisableS3ExpressSessionAuth"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3express-control.cn-north-1.amazonaws.com.cn/mybucket--test-ab1--x-s3", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Control plane with short AZ bucket and fips")]
        public void Control_plane_with_short_AZ_bucket_and_fips_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "mybucket--test-ab1--x-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = true;
            parameters["DisableS3ExpressSessionAuth"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3express-control-fips.us-east-1.amazonaws.com/mybucket--test-ab1--x-s3", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Control plane with short AZ bucket and fips china region")]
        [ExpectedException(typeof(AmazonClientException), @"Partition does not support FIPS")]
        public void Control_plane_with_short_AZ_bucket_and_fips_china_region_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["Bucket"] = "mybucket--test-ab1--x-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = true;
            parameters["DisableS3ExpressSessionAuth"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Control plane without bucket")]
        public void Control_plane_without_bucket_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = true;
            parameters["DisableS3ExpressSessionAuth"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3express-control.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Control plane without bucket and fips")]
        public void Control_plane_without_bucket_and_fips_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = true;
            parameters["DisableS3ExpressSessionAuth"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3express-control-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with short AZ")]
        public void Data_Plane_sigv4_auth_with_short_AZ_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--usw2-az1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--usw2-az1--x-s3.s3express-usw2-az1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with short AZ with AP")]
        public void Data_Plane_sigv4_auth_with_short_AZ_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--usw2-az1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--usw2-az1--xa-s3.s3express-usw2-az1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with short zone (13 chars)")]
        public void Data_Plane_sigv4_auth_with_short_zone_13_chars_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--test-zone-ab1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--test-zone-ab1--x-s3.s3express-test-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with short zone (13 chars) with AP")]
        public void Data_Plane_sigv4_auth_with_short_zone_13_chars_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--test-zone-ab1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--test-zone-ab1--xa-s3.s3express-test-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with short AZ fips")]
        public void Data_Plane_sigv4_auth_with_short_AZ_fips_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--usw2-az1--x-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--usw2-az1--x-s3.s3express-fips-usw2-az1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with short AZ fips with AP")]
        public void Data_Plane_sigv4_auth_with_short_AZ_fips_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--usw2-az1--xa-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--usw2-az1--xa-s3.s3express-fips-usw2-az1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with short zone (13 chars) fips")]
        public void Data_Plane_sigv4_auth_with_short_zone_13_chars_fips_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--test-zone-ab1--x-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--test-zone-ab1--x-s3.s3express-fips-test-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with short zone (13 chars) fips with AP")]
        public void Data_Plane_sigv4_auth_with_short_zone_13_chars_fips_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--test-zone-ab1--xa-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--test-zone-ab1--xa-s3.s3express-fips-test-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with long AZ")]
        public void Data_Plane_sigv4_auth_with_long_AZ_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--test1-az1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--test1-az1--x-s3.s3express-test1-az1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with long AZ with AP")]
        public void Data_Plane_sigv4_auth_with_long_AZ_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--test1-az1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--test1-az1--xa-s3.s3express-test1-az1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with medium zone(14 chars)")]
        public void Data_Plane_sigv4_auth_with_medium_zone14_chars_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--test1-zone-ab1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--test1-zone-ab1--x-s3.s3express-test1-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with medium zone(14 chars) with AP")]
        public void Data_Plane_sigv4_auth_with_medium_zone14_chars_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--test1-zone-ab1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--test1-zone-ab1--xa-s3.s3express-test1-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with long zone(20 chars)")]
        public void Data_Plane_sigv4_auth_with_long_zone20_chars_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--test1-long1-zone-ab1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--test1-long1-zone-ab1--x-s3.s3express-test1-long1-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with long zone(20 chars) with AP")]
        public void Data_Plane_sigv4_auth_with_long_zone20_chars_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--test1-long1-zone-ab1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--test1-long1-zone-ab1--xa-s3.s3express-test1-long1-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with long AZ fips")]
        public void Data_Plane_sigv4_auth_with_long_AZ_fips_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--test1-az1--x-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--test1-az1--x-s3.s3express-fips-test1-az1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with long AZ fips with AP")]
        public void Data_Plane_sigv4_auth_with_long_AZ_fips_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--test1-az1--xa-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--test1-az1--xa-s3.s3express-fips-test1-az1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with medium zone (14 chars) fips")]
        public void Data_Plane_sigv4_auth_with_medium_zone_14_chars_fips_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--test1-zone-ab1--x-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--test1-zone-ab1--x-s3.s3express-fips-test1-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with medium zone (14 chars) fips with AP")]
        public void Data_Plane_sigv4_auth_with_medium_zone_14_chars_fips_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--test1-zone-ab1--xa-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--test1-zone-ab1--xa-s3.s3express-fips-test1-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with long zone (20 chars) fips")]
        public void Data_Plane_sigv4_auth_with_long_zone_20_chars_fips_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--test1-long1-zone-ab1--x-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--test1-long1-zone-ab1--x-s3.s3express-fips-test1-long1-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data Plane sigv4 auth with long zone (20 chars) fips with AP")]
        public void Data_Plane_sigv4_auth_with_long_zone_20_chars_fips_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--test1-long1-zone-ab1--xa-s3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--test1-long1-zone-ab1--xa-s3.s3express-fips-test1-long1-zone-ab1.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Control Plane host override")]
        public void Control_Plane_host_override_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--usw2-az1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = true;
            parameters["DisableS3ExpressSessionAuth"] = true;
            parameters["Endpoint"] = "https://custom.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--usw2-az1--x-s3.custom.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Control Plane host override with AP")]
        public void Control_Plane_host_override_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--usw2-az1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = true;
            parameters["DisableS3ExpressSessionAuth"] = true;
            parameters["Endpoint"] = "https://custom.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--usw2-az1--xa-s3.custom.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Control Plane host override no bucket")]
        public void Control_Plane_host_override_no_bucket_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = true;
            parameters["DisableS3ExpressSessionAuth"] = true;
            parameters["Endpoint"] = "https://custom.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://custom.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data plane host override non virtual session auth")]
        public void Data_plane_host_override_non_virtual_session_auth_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--usw2-az1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Endpoint"] = "https://10.0.0.1";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://10.0.0.1/mybucket--usw2-az1--x-s3", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data plane host override non virtual session auth with AP")]
        public void Data_plane_host_override_non_virtual_session_auth_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--usw2-az1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Endpoint"] = "https://10.0.0.1";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://10.0.0.1/myaccesspoint--usw2-az1--xa-s3", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Control Plane host override ip")]
        public void Control_Plane_host_override_ip_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--usw2-az1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = true;
            parameters["DisableS3ExpressSessionAuth"] = true;
            parameters["Endpoint"] = "https://10.0.0.1";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://10.0.0.1/mybucket--usw2-az1--x-s3", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Control Plane host override ip with AP")]
        public void Control_Plane_host_override_ip_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--usw2-az1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = true;
            parameters["DisableS3ExpressSessionAuth"] = true;
            parameters["Endpoint"] = "https://10.0.0.1";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://10.0.0.1/myaccesspoint--usw2-az1--xa-s3", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data plane host override")]
        public void Data_plane_host_override_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "mybucket--usw2-az1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Endpoint"] = "https://custom.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mybucket--usw2-az1--x-s3.custom.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data plane host override with AP")]
        public void Data_plane_host_override_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "myaccesspoint--usw2-az1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Endpoint"] = "https://custom.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myaccesspoint--usw2-az1--xa-s3.custom.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("bad format error")]
        [ExpectedException(typeof(AmazonClientException), @"Unrecognized S3Express bucket name format.")]
        public void Bad_format_error_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "mybucket--usaz1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("bad AP format error")]
        [ExpectedException(typeof(AmazonClientException), @"Unrecognized S3Express bucket name format.")]
        public void Bad_AP_format_error_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "myaccesspoint--usaz1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("bad format error no session auth")]
        [ExpectedException(typeof(AmazonClientException), @"Unrecognized S3Express bucket name format.")]
        public void Bad_format_error_no_session_auth_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "mybucket--usaz1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("bad AP format error no session auth")]
        [ExpectedException(typeof(AmazonClientException), @"Unrecognized S3Express bucket name format.")]
        public void Bad_AP_format_error_no_session_auth_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "myaccesspoint--usaz1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("dual-stack error")]
        [ExpectedException(typeof(AmazonClientException), @"S3Express does not support Dual-stack.")]
        public void Dualstack_error_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "mybucket--test-ab1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("dual-stack error with AP")]
        [ExpectedException(typeof(AmazonClientException), @"S3Express does not support Dual-stack.")]
        public void Dualstack_error_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "myaccesspoint--test-ab1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("accelerate error")]
        [ExpectedException(typeof(AmazonClientException), @"S3Express does not support S3 Accelerate.")]
        public void Accelerate_error_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "mybucket--test-ab1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = true;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("accelerate error with AP")]
        [ExpectedException(typeof(AmazonClientException), @"S3Express does not support S3 Accelerate.")]
        public void Accelerate_error_with_AP_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "myaccesspoint--test-ab1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = true;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data plane bucket format error")]
        [ExpectedException(typeof(AmazonClientException), @"S3Express bucket name is not a valid virtual hostable name.")]
        public void Data_plane_bucket_format_error_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "my.bucket--test-ab1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("Data plane AP format error")]
        [ExpectedException(typeof(AmazonClientException), @"S3Express bucket name is not a valid virtual hostable name.")]
        public void Data_plane_AP_format_error_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "my.myaccesspoint--test-ab1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["UseS3ExpressControlEndpoint"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("host override data plane bucket error session auth")]
        [ExpectedException(typeof(AmazonClientException), @"S3Express bucket name is not a valid virtual hostable name.")]
        public void Host_override_data_plane_bucket_error_session_auth_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "my.bucket--usw2-az1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Endpoint"] = "https://custom.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("host override data plane AP error session auth")]
        [ExpectedException(typeof(AmazonClientException), @"S3Express bucket name is not a valid virtual hostable name.")]
        public void Host_override_data_plane_AP_error_session_auth_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "my.myaccesspoint--usw2-az1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Endpoint"] = "https://custom.com";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("host override data plane bucket error")]
        [ExpectedException(typeof(AmazonClientException), @"S3Express bucket name is not a valid virtual hostable name.")]
        public void Host_override_data_plane_bucket_error_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "my.bucket--usw2-az1--x-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Endpoint"] = "https://custom.com";
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("host override data plane AP error")]
        [ExpectedException(typeof(AmazonClientException), @"S3Express bucket name is not a valid virtual hostable name.")]
        public void Host_override_data_plane_AP_error_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Bucket"] = "my.myaccesspoint--usw2-az1--xa-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            parameters["Endpoint"] = "https://custom.com";
            parameters["DisableS3ExpressSessionAuth"] = true;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

    }
}