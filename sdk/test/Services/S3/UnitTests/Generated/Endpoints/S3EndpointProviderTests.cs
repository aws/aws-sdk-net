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
using Amazon.Runtime;
using Amazon.S3.Endpoints;
using Amazon.S3.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
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
        [ExpectedException(typeof(AmazonClientException), @"DualStack cannot be combined with a Host override (PrivateLink)")]
        public void SDKHost_access_point_Dualstack_is_an_error_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "arn:aws-cn:s3:cn-north-1:123456789012:accesspoint:myendpoint";
            parameters["ForcePathStyle"] = false;
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["Region"] = "cn-north-1";
            parameters["RequiresAccountId"] = true;
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3.cn-north-1.amazonaws.com.cn/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + fips@cn-north-1")]
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
            Assert.AreEqual("https://s3-fips.cn-north-1.amazonaws.com.cn/bucket-name", endpoint.URL);
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::Host + FIPS@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Host override cannot be combined with Dualstack, FIPS, or S3 Accelerate")]
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
            parameters["___key"] = "key";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::Host + DualStack@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Host override cannot be combined with Dualstack, FIPS, or S3 Accelerate")]
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
            parameters["___key"] = "key";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::HOST + accelerate@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Host override cannot be combined with Dualstack, FIPS, or S3 Accelerate")]
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
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::Host + FIPS@cn-north-1")]
        [ExpectedException(typeof(AmazonClientException), @"Partition does not support FIPS")]
        public void SDKHost_FIPScnnorth1_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = false;
            parameters["Endpoint"] = "https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com";
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
        [ExpectedException(typeof(AmazonClientException), @"Host override cannot be combined with Dualstack, FIPS, or S3 Accelerate")]
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
            parameters["___key"] = "key";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::HOST + accelerate@cn-north-1")]
        [ExpectedException(typeof(AmazonClientException), @"S3 Accelerate cannot be used in this region")]
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
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
            parameters["___key"] = "key";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com/bucket-name", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::Host + FIPS@af-south-1")]
        [ExpectedException(typeof(AmazonClientException), @"Host override cannot be combined with Dualstack, FIPS, or S3 Accelerate")]
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
            parameters["___key"] = "key";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::Host + DualStack@af-south-1")]
        [ExpectedException(typeof(AmazonClientException), @"Host override cannot be combined with Dualstack, FIPS, or S3 Accelerate")]
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
            parameters["___key"] = "key";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("SDK::HOST + accelerate@af-south-1")]
        [ExpectedException(typeof(AmazonClientException), @"Host override cannot be combined with Dualstack, FIPS, or S3 Accelerate")]
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
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["___key"] = "key";
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
        [Description("S3 Outposts Abba Real Outpost Prod us-west-1")]
        public void S3_Outposts_Abba_Real_Outpost_Prod_uswest1_Test()
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
        [Description("S3 Outposts Abba Real Outpost Prod ap-east-1")]
        public void S3_Outposts_Abba_Real_Outpost_Prod_apeast1_Test()
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
        [Description("S3 Outposts Abba Ec2 Outpost Prod us-east-1")]
        public void S3_Outposts_Abba_Ec2_Outpost_Prod_useast1_Test()
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
        [Description("S3 Outposts Abba Ec2 Outpost Prod me-south-1")]
        public void S3_Outposts_Abba_Ec2_Outpost_Prod_mesouth1_Test()
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
        [Description("S3 Outposts Abba Real Outpost Beta")]
        public void S3_Outposts_Abba_Real_Outpost_Beta_Test()
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
        [Description("S3 Outposts Abba Ec2 Outpost Beta")]
        public void S3_Outposts_Abba_Ec2_Outpost_Beta_Test()
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
        [Description("S3 Outposts Abba - No endpoint set for beta")]
        [ExpectedException(typeof(AmazonClientException), @"Expected a endpoint to be specified but no endpoint was found")]
        public void S3_Outposts_Abba_No_endpoint_set_for_beta_Test()
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
        [Description("S3 Outposts Abba Invalid hardware type")]
        [ExpectedException(typeof(AmazonClientException), @"Unrecognized hardware type: ""Expected hardware type o or e but got h""")]
        public void S3_Outposts_Abba_Invalid_hardware_type_Test()
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
        [Description("S3 Outposts Abba Special character in Outpost Arn")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: The outpost Id must only contain a-z, A-Z, 0-9 and `-`.")]
        public void S3_Outposts_Abba_Special_character_in_Outpost_Arn_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Bucket"] = "test-accessp-o00000754%1d83bebde8xz5w8ijx1qzlbp3i3kuse10--op-s3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

    }
}