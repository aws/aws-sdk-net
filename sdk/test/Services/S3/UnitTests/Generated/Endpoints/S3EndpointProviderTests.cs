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
        [ExpectedException(typeof(AmazonClientException), "Invalid region: region was not a valid DNS name.")]
        public void Region_is_not_a_valid_DNSsuffix_492dbe6453974c3abc6d746c6965612d_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: The ARN was not for the S3 service, found: not-s3")]
        public void Invalid_access_point_ARN_Not_S3_480abc3abf7b4f75a1574fa2b3abb1e6_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: The ARN may only contain a single resource component after `accesspoint`.")]
        public void Invalid_access_point_ARN_invalid_resource_0af76ab0a1af473abb81faaa5736244c_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: Expected a resource of the format `accesspoint:<accesspoint name>` but no name was provided")]
        public void Invalid_access_point_ARN_invalid_no_ap_name_3f8204d9ad2d42799bc7e4a504600a35_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: The account id may only contain a-z, A-Z, 0-9 and `-`. Found: `123456_789012`")]
        public void Invalid_access_point_ARN_AccountId_is_invalid_4d01cd0788414c8795adffdcc947db08_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: The access point name may only contain a-z, A-Z, 0-9 and `-`. Found: `ap_name`")]
        public void Invalid_access_point_ARN_access_point_name_is_invalid_93ad39d091564db2a864b58b77f2f269_Test()
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
        public void Access_points_disable_access_points_explicitly_false_1b72ea8b369d4786bb7ba909b4379e61_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Partition does not support FIPS")]
        public void Access_points_partition_does_not_support_FIPS_e76a8c02f9744d4188f38a4a4be2874f_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid region in ARN: `us-west -2` (invalid DNS name)")]
        public void Bucket_region_is_invalid_233d6ec7e43f4f6eb7d7eb7fb7301ce0_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Access points are not supported for this operation")]
        public void Access_points_when_Access_points_explicitly_disabled_used_for_CreateBucket_f2f2744adc314ec995858c9dee95612c_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: `arn:aws:s3:us-west-2:123456789012:` was not a valid ARN")]
        public void Missing_arn_type_49ddb6a2ab2b43a7a787ad39deb8f88f_Test()
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
        [ExpectedException(typeof(AmazonClientException), "DualStack cannot be combined with a Host override (PrivateLink)")]
        public void SDKHost_access_point_Dualstack_is_an_error_15c4341d8215486bba0d433048e0d8d6_Test()
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
        public void Access_point_ARN_with_FIPS_Dualstack_f60991008c6b438e94efed96bcfbb6cd_Test()
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
        public void Access_point_ARN_with_Dualstack_ff1b4a53b7dd4786895a1ac9a8697ac8_Test()
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
        public void Vanilla_MRAP_827ccda1656e47f08f71ac147ffecea7_Test()
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
        [ExpectedException(typeof(AmazonClientException), "S3 MRAP does not support FIPS")]
        public void MRAP_does_not_support_FIPS_c160a1860f4b4900b8e0d2d56bf1a5bf_Test()
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
        [ExpectedException(typeof(AmazonClientException), "S3 MRAP does not support dual-stack")]
        public void MRAP_does_not_support_DualStack_890ea8ab9fb34ace9902485a91ffca25_Test()
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
        [ExpectedException(typeof(AmazonClientException), "S3 MRAP does not support S3 Accelerate")]
        public void MRAP_does_not_support_S3_Accelerate_7b8eb029d24b443caaeb0b754431bf93_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: Multi-Region Access Point ARNs are disabled.")]
        public void MRAP_explicitly_disabled_fd93162562244d7bb783974a63880014_Test()
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
        public void Dualstack_endpoint_with_pathstyle_forced_265c018b22264d2e89c6796ce222c4e7_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Cannot set dual-stack in combination with a custom endpoint.")]
        public void Dualstack_endpoint_SDKHost_is_error_6bbef0447e964d34bfcc5a29de98c691_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Path-style addressing cannot be used with ARN buckets")]
        public void Path_style_ARN_bucket_660347e3402640bc83ce3715e0b344c0_Test()
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
        public void Implicit_path_style_bucket_dualstack_976c91c4d01e4f1eab537014fdd84f7c_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Cannot set dual-stack in combination with a custom endpoint.")]
        public void Implicit_path_style_bucket_dualstack_4e79f1deaff749aebb75e96a4db7e7cb_Test()
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
        public void Dont_allow_URL_injections_in_the_bucket_3cea569a4f214bd5992b49807b281ae6_Test()
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
        public void URI_encode_bucket_names_in_the_path_ced5b0ad9ff144259649fffd8d84a9bd_Test()
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
        public void Scheme_is_respected_02856f5ab5594d91813800061cafcb80_Test()
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
        public void Scheme_is_respected_virtual_addressing_221e89680c354931ab37052d2c395012_Test()
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
        public void Path_style_implicit_private_link_acaf80f2bf384f4c9dcbe2a930b414e1_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Custom endpoint `abcde://nota#url` was not a valid URI")]
        public void Invalid_Endpoint_override_6438a8f4cba040e7be154882faaa597a_Test()
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
        public void Using_an_IPv4_address_forces_path_style_6241526c9ecc48b3863003c36f96eb58_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: region from ARN `us-east-1` does not match client region `us-west-2` and UseArnRegion is `false`")]
        public void Vanilla_access_point_arn_with_region_mismatch_and_UseArnRegionfalse_fd967721866b49afb7de740659e2beb6_Test()
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
        public void Vanilla_access_point_arn_with_region_mismatch_and_UseArnRegion_unset_38b047f2b3bb4b04a75b070623fb397a_Test()
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
        public void Vanilla_access_point_arn_with_region_mismatch_and_UseArnRegiontrue_325c67803537417f9e0f305797a732f1_Test()
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
        public void Subdomains_are_not_allowed_in_virtual_buckets_d1e70ae98bd043f98de07397c4caccee_Test()
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
        public void Bucket_names_with_3_characters_are_allowed_in_virtual_buckets_e410f19d1d1446e1b48b57e864b8750b_Test()
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
        public void Bucket_names_with_fewer_than_3_characters_are_not_allowed_in_virtual_host_d3e09af44d2c45f0991b4933fce4bd23_Test()
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
        public void Bucket_names_with_uppercase_characters_are_not_allowed_in_virtual_host_dd1d813f3a86429a87c2a075bf619b57_Test()
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
        public void Subdomains_are_allowed_in_virtual_buckets_on_http_endpoints_4b97ce3cb5a44b438310d3e189da4ff5_Test()
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
        [ExpectedException(typeof(AmazonClientException), "A region must be set when sending requests to S3.")]
        public void No_region_set_11d79bb27506417f8aa62bb87fc8ea90_Test()
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
        public void UseGlobalEndpointstrue_regionuseast1_uses_the_global_endpoint_9acd4e5f5bda4f03bf117af82a025b41_Test()
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
        public void UseGlobalEndpointstrue_regionuswest2_uses_the_regional_endpoint_6b3d868695584f6cb7b88358a0e1908f_Test()
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
        public void UseGlobalEndpointstrue_regioncnnorth1_uses_the_regional_endpoint_66408bab2e03409c966edecbf399f164_Test()
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
        public void UseGlobalEndpointstrue_regionuseast1_fipstrue_uses_the_regional_endpoint_with_fips_34453007eb9b4e95808a050797e17882_Test()
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
        public void UseGlobalEndpointstrue_regionuseast1_dualstacktrue_uses_the_regional_endpoint_with_dualstack_996d5b3679e842bf808cd3ea2e8ff063_Test()
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
        public void UseGlobalEndpointstrue_regionuseast1_dualstack_and_fips_uses_the_regional_endpoint_with_fipsdualstack_8e53bf84986d414ab1197b12f252bc84_Test()
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
        public void UseGlobalEndpointstrue_regionuseast1_with_custom_endpoint_uses_custom_2136be3d47bc4b5a99a1737a6c9a308c_Test()
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
        public void UseGlobalEndpointstrue_regionuswest2_with_custom_endpoint_uses_custom_b9e3ab3929054d04888be6816e917e9d_Test()
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
        public void UseGlobalEndpointstrue_regionuseast1_with_accelerate_on_non_bucket_case_uses_the_global_endpoint_and_ignores_accelerate_3f868cd03f144fffa6e7858b6dfd4ad2_Test()
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
        public void Awsglobal_region_uses_the_global_endpoint_7b35941a8d0b4d1e8aa0e221418796e5_Test()
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
        public void Awsglobal_region_with_fips_uses_the_regional_endpoint_b74a2db1c09e4527af1e9cebcdcad44d_Test()
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
        public void Awsglobal_region_with_dualstack_uses_the_regional_endpoint_14da6298f5f5463a9a74868303a317a5_Test()
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
        public void Awsglobal_region_with_fips_and_dualstack_uses_the_regional_endpoint_cd1f33ae23064ff59634907438accaaa_Test()
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
        public void Awsglobal_region_with_accelerate_on_nonbucket_case_uses_global_endpoint_and_ignores_accelerate_5c83a9716bb84c47a916d5a3dd1ff647_Test()
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
        public void Awsglobal_region_with_custom_endpoint_uses_custom_351e1de293f347c797b0ce9cd992eff4_Test()
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
        public void Virtual_addressing_awsglobal_region_uses_the_global_endpoint_ebe7c9b8383e4c85b6bc3da3e7d19f46_Test()
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
        public void Virtual_addressing_awsglobal_region_with_fips_uses_the_regional_fips_endpoint_9f448869d0254797a20ed8b5c048217d_Test()
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
        public void Virtual_addressing_awsglobal_region_with_dualstack_uses_the_regional_dualstack_endpoint_5169baaaa1da41d9a43bcb05f137ba98_Test()
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
        public void Virtual_addressing_awsglobal_region_with_fipsdualstack_uses_the_regional_fipsdualstack_endpoint_e4b0a377fa48418a93e876135725d0c5_Test()
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
        public void Virtual_addressing_awsglobal_region_with_accelerate_uses_the_global_accelerate_endpoint_40c0e6532dbe4b8ba4cb7a6ed68b7ca0_Test()
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
        public void Virtual_addressing_awsglobal_region_with_custom_endpoint_dd2ba56d3f0b495dac4ee0c97367c605_Test()
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
        public void Virtual_addressing_UseGlobalEndpoint_and_useast1_region_uses_the_global_endpoint_bd5b0e147c764fcdbd961c854d271236_Test()
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
        public void Virtual_addressing_UseGlobalEndpoint_and_uswest2_region_uses_the_regional_endpoint_d01f8b73fd6c4ddfb6aa097f7a7c2c94_Test()
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
        public void Virtual_addressing_UseGlobalEndpoint_and_useast1_region_and_fips_uses_the_regional_fips_endpoint_d1e5add2e7194041b5c3e090f60bb17c_Test()
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
        public void Virtual_addressing_UseGlobalEndpoint_and_useast1_region_and_dualstack_uses_the_regional_dualstack_endpoint_02cb7ec15a4747f6b4955758de0fbf87_Test()
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
        public void Virtual_addressing_UseGlobalEndpoint_and_useast1_region_and_accelerate_uses_the_global_accelerate_endpoint_d6ebaeeb8b0940a898cf363c240964ce_Test()
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
        public void Virtual_addressing_UseGlobalEndpoint_and_useast1_region_with_custom_endpoint_7b075192b09048fbb36118e6cda90f94_Test()
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
        public void ForcePathStyle_awsglobal_region_uses_the_global_endpoint_2daa244792b34e3b93fc4d11906bbd0b_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Path-style addressing cannot be used with FIPS")]
        public void ForcePathStyle_awsglobal_region_with_fips_is_invalid_bcc6eae929b8446eb994a805dd9ed858_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Accelerate"] = false;
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("ForcePathStyle, aws-global region with dualstack uses regional dualstack endpoint")]
        public void ForcePathStyle_awsglobal_region_with_dualstack_uses_regional_dualstack_endpoint_e0aeebf258d04a3ba6ecee2eb30dbcdb_Test()
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
        public void ForcePathStyle_awsglobal_region_custom_endpoint_uses_the_custom_endpoint_29bbe69210fc4a43936a4d4102434dcf_Test()
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
        public void ForcePathStyle_UseGlobalEndpoint_useast1_region_uses_the_global_endpoint_c046218b006c4131b5fca7e59d1d2c5f_Test()
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
        public void ForcePathStyle_UseGlobalEndpoint_uswest2_region_uses_the_regional_endpoint_1b23e1bb99ac4f8b87a4cbab45eac1e0_Test()
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
        public void ForcePathStyle_UseGlobalEndpoint_useast1_region_dualstack_uses_the_regional_dualstack_endpoint_ce84a803e72c4ba8a3f35d38311d3c48_Test()
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
        public void ForcePathStyle_UseGlobalEndpoint_useast1_region_custom_endpoint_uses_the_custom_endpoint_78f90420678949dabc11757cfe57f4ad_Test()
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
        public void ARN_with_awsglobal_region_and_UseArnRegion_uses_the_regional_endpoint_eb74d244303e444783528ffe99063457_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Client was configured for partition `aws` but bucket referred to partition `aws-cn`")]
        public void Cross_partition_MRAP_ARN_is_an_error_193e5f9bf62b4012ae870474d7e32838_Test()
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
        public void Endpoint_override_accesspoint_with_HTTP_port_7b8ae301a3bd4e629bfcc165af22f2bf_Test()
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
        public void Endpoint_override_accesspoint_with_http_path_query_and_port_dab91823b0324233a4e7dabdd4fc0f88_Test()
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
        public void Vanilla_virtual_addressinguswest2_cfdac601175e415b98479a600e59c9f3_Test()
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
        public void Virtual_addressing_dualstackuswest2_d4f42dec85124325b93fb002ef3a0aa5_Test()
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
        public void Accelerate_dualstackuswest2_4a0d199382134c908cd6a8756e64a566_Test()
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
        public void Accelerate_dualstackfalseuswest2_0160248e432f4ae18f817868a38d38a8_Test()
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
        public void Virtual_addressing_fipsuswest2_b44da242767342f2b2eb33c663f04ece_Test()
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
        public void Virtual_addressing_dualstack_fipsuswest2_cda61c863e014e6b8dfded4475ca4316_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Accelerate cannot be used with FIPS")]
        public void Accelerate_fips_erroruswest2_82917e9c8ad34abda5f3687e067330f5_Test()
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
        public void Vanilla_virtual_addressingcnnorth1_5c15d973ba4b4d0daea2057b6fb302d4_Test()
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
        public void Virtual_addressing_dualstackcnnorth1_2d20dec24176445bb87ffab66817ca5c_Test()
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
        [ExpectedException(typeof(AmazonClientException), "S3 Accelerate cannot be used in this region")]
        public void Accelerate_dualstackfalsecnnorth1_c368613684b74be2b1e86afdf3bc8b9b_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Partition does not support FIPS")]
        public void Virtual_addressing_fipscnnorth1_1ffc31b66ee242b2b0db29b052f24017_Test()
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
        public void Vanilla_virtual_addressingafsouth1_77e5594ed0cb4984bd0458cd36cf1d94_Test()
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
        public void Virtual_addressing_dualstackafsouth1_c5bb8cbbf2f94360b51d3a609a7de4ca_Test()
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
        public void Accelerate_dualstackafsouth1_bbd60cbfaa0346509e25746ed2793c3a_Test()
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
        public void Accelerate_dualstackfalseafsouth1_edf167c2c78c4ce5b9fb96e27797345b_Test()
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
        public void Virtual_addressing_fipsafsouth1_1115339d74a84e7692d59af96f64182f_Test()
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
        public void Virtual_addressing_dualstack_fipsafsouth1_d04c88317fb44b2d8754d728fc27410b_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Accelerate cannot be used with FIPS")]
        public void Accelerate_fips_errorafsouth1_0c4e1313cf2c420d8974d47a8e32e417_Test()
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
        public void Vanilla_path_styleuswest2_6ee07cd87d644520aa78c45e8f144e2b_Test()
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
        [Description("path style + fips@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), "Path-style addressing cannot be used with FIPS")]
        public void Path_style_fipsuswest2_8678acd2be3e4d27b18e89bbe80eb668_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
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
        [Description("path style + accelerate = error@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), "Path-style addressing cannot be used with S3 Accelerate")]
        public void Path_style_accelerate_erroruswest2_a21159530ef34de9a8d129ec1a6db5f1_Test()
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
        public void Path_style_dualstackuswest2_25bc826a725e4a6b9f0430a65240bd9c_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Path-style addressing cannot be used with ARN buckets")]
        public void Path_style_arn_is_erroruswest2_bfe8070309e948e18386246e9c60f02f_Test()
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
        public void Path_style_invalid_DNS_nameuswest2_c92a06de02534b35a733866b20734f65_Test()
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
        public void No_path_style_invalid_DNS_nameuswest2_7a71544e6b0149dcb18b0a4016dad9da_Test()
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
        public void Vanilla_path_stylecnnorth1_f44bcb5259434d8582f3f61379e02262_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Path-style addressing cannot be used with FIPS")]
        public void Path_style_fipscnnorth1_591b704514074c4faf6ca447f5f6866b_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["___key"] = "key";
            var endpoint = new AmazonS3EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3")]
        [Description("path style + accelerate = error@cn-north-1")]
        [ExpectedException(typeof(AmazonClientException), "Path-style addressing cannot be used with S3 Accelerate")]
        public void Path_style_accelerate_errorcnnorth1_78ca8c9a7fee45089638df5dd383eec8_Test()
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
        public void Path_style_dualstackcnnorth1_8ef62bdd16c747ef8fc74c73d34e4686_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Path-style addressing cannot be used with ARN buckets")]
        public void Path_style_arn_is_errorcnnorth1_308cc21429d742ce92cf25083f3cfe1e_Test()
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
        public void Path_style_invalid_DNS_namecnnorth1_aac17b1d6d8d4bdf9e14cede282040a0_Test()
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
        public void No_path_style_invalid_DNS_namecnnorth1_e7de9ea5509a4b57ae16825b6cc55893_Test()
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
        public void Vanilla_path_styleafsouth1_ff1bea3b2f0c43a8b8da77869bad3e4c_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Path-style addressing cannot be used with FIPS")]
        public void Path_style_fipsafsouth1_f6b9ad1015704482b96b2a5a3dbf3871_Test()
        {
            var parameters = new S3EndpointParameters();
            parameters["Accelerate"] = false;
            parameters["Bucket"] = "bucket-name";
            parameters["ForcePathStyle"] = true;
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
        [Description("path style + accelerate = error@af-south-1")]
        [ExpectedException(typeof(AmazonClientException), "Path-style addressing cannot be used with S3 Accelerate")]
        public void Path_style_accelerate_errorafsouth1_5ffac57319fa448bbd745abf0630687f_Test()
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
        public void Path_style_dualstackafsouth1_023e729870a3425b92a423a9d38e771a_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Path-style addressing cannot be used with ARN buckets")]
        public void Path_style_arn_is_errorafsouth1_19db3c3755f84df6a64a73088b0bf960_Test()
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
        public void Path_style_invalid_DNS_nameafsouth1_e3bc7515d82e4ff3b9f9aa957ad11ace_Test()
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
        public void No_path_style_invalid_DNS_nameafsouth1_249db639cfc44131bdb7798c6a37c7d2_Test()
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
        public void Virtual_addressing_private_linkuswest2_93a03a456b7d40efb3006a1550158ada_Test()
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
        public void Path_style_private_linkuswest2_e72ada2dda8d42b3b9d7a71b31c7e46b_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Host override cannot be combined with Dualstack, FIPS, or S3 Accelerate")]
        public void SDKHost_FIPSuswest2_04dc15f2541348e2a3cc595db82fb300_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Host override cannot be combined with Dualstack, FIPS, or S3 Accelerate")]
        public void SDKHost_DualStackuswest2_a47bab3286544e3b85c5d0e632d8e1b9_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Host override cannot be combined with Dualstack, FIPS, or S3 Accelerate")]
        public void SDKHOST_accelerateuswest2_93a2bfc1996340b099cae19336dd5b59_Test()
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
        public void SDKHost_access_point_ARNuswest2_635135d7d19a4c9ca6d18b271102a843_Test()
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
        public void Virtual_addressing_private_linkcnnorth1_bab0f9c17b7845fbba7e80d168b15935_Test()
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
        public void Path_style_private_linkcnnorth1_1957ce722f724208b600e7dcaf5da3e7_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Partition does not support FIPS")]
        public void SDKHost_FIPScnnorth1_105576df57e44ec8b7c2f191b553b0e2_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Host override cannot be combined with Dualstack, FIPS, or S3 Accelerate")]
        public void SDKHost_DualStackcnnorth1_6c2c9753e6ec436e811e9d81bd9d286e_Test()
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
        [ExpectedException(typeof(AmazonClientException), "S3 Accelerate cannot be used in this region")]
        public void SDKHOST_acceleratecnnorth1_e6988817d02c47978bc0ff4ca6d4d755_Test()
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
        public void SDKHost_access_point_ARNcnnorth1_0c2297b685304101ab2eda5482548e5e_Test()
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
        public void Virtual_addressing_private_linkafsouth1_0896f7bc16e64daca6628fbfb9405db5_Test()
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
        public void Path_style_private_linkafsouth1_868516f7e6d948c9b748a369e3b4502b_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Host override cannot be combined with Dualstack, FIPS, or S3 Accelerate")]
        public void SDKHost_FIPSafsouth1_f108c8d312ff440f9db88fdccfe41228_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Host override cannot be combined with Dualstack, FIPS, or S3 Accelerate")]
        public void SDKHost_DualStackafsouth1_91c847f33b7d4a87b111c32c2805b18a_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Host override cannot be combined with Dualstack, FIPS, or S3 Accelerate")]
        public void SDKHOST_accelerateafsouth1_a96060bd9db24b39a58390def0e2f87c_Test()
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
        public void SDKHost_access_point_ARNafsouth1_9e4ca0fcf9444b1aa5bd746053fe39a9_Test()
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
        public void Vanilla_access_point_arnuswest2_145427f86f73431299b0b08306f1aa66_Test()
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
        public void Access_point_arn_FIPSuswest2_bf1df89493644f6e944a41f3bf0d6944_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Access Points do not support S3 Accelerate")]
        public void Access_point_arn_accelerate_erroruswest2_ea5fbe59287540919f6e7c57277a16bc_Test()
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
        public void Access_point_arn_FIPS_DualStackuswest2_45e6bb71fa1f40ea81c3e7391894eb82_Test()
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
        public void Vanilla_access_point_arncnnorth1_b379d412198d4eb1a3a05e8b1a9a6b10_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Partition does not support FIPS")]
        public void Access_point_arn_FIPScnnorth1_0a58a657d1f2454ebbd46537d20ecd3d_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Access Points do not support S3 Accelerate")]
        public void Access_point_arn_accelerate_errorcnnorth1_f1672465c6a6495fba389f517783df25_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Partition does not support FIPS")]
        public void Access_point_arn_FIPS_DualStackcnnorth1_c63cf8abf51647ecbf9f11695787c63d_Test()
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
        public void Vanilla_access_point_arnafsouth1_178ff50cb1154e708f48e376c3e5cbea_Test()
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
        public void Access_point_arn_FIPSafsouth1_c2559eeb452a406f945478a535f57697_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Access Points do not support S3 Accelerate")]
        public void Access_point_arn_accelerate_errorafsouth1_4464418e89194c57a41410815571fd1c_Test()
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
        public void Access_point_arn_FIPS_DualStackafsouth1_0890e87cc4b3431780d42a946acfba85_Test()
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
        public void S3_outposts_vanilla_test_c3ba5fdcf8324dbaa012234f701bfb0f_Test()
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
        public void S3_outposts_custom_endpoint_538b9f86ac6a4e369a344b4c88f30317_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: region from ARN `us-east-1` does not match client region `us-west-2` and UseArnRegion is `false`")]
        public void Outposts_arn_with_region_mismatch_and_UseArnRegionfalse_66cb5c409a3b4a7eba2c96790a2ca98b_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: region from ARN `us-east-1` does not match client region `us-west-2` and UseArnRegion is `false`")]
        public void Outposts_arn_with_region_mismatch_custom_region_and_UseArnRegionfalse_2d356b6d3df04e6faa939e4eef842e06_Test()
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
        public void Outposts_arn_with_region_mismatch_and_UseArnRegiontrue_aa63bd85b12c4a8c9eb3b5720d4b1ab0_Test()
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
        public void Outposts_arn_with_region_mismatch_and_UseArnRegion_unset_d6cfd40443d94570bc61a178a8d71e6e_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Client was configured for partition `aws` but ARN (`arn:aws:s3-outposts:cn-north-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint`) has `aws-cn`")]
        public void Outposts_arn_with_partition_mismatch_and_UseArnRegiontrue_2bf6c40d313f4a8c881d4c541ae7b3ff_Test()
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
        public void ARN_with_UseGlobalEndpoint_and_useeast1_region_uses_the_regional_endpoint_53d6ca447e2346789249b0256386daf3_Test()
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
        [ExpectedException(typeof(AmazonClientException), "S3 Outposts does not support Dual-stack")]
        public void S3_outposts_does_not_support_dualstack_c8322dfd91aa4cf3bb7d29b73bc3030e_Test()
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
        [ExpectedException(typeof(AmazonClientException), "S3 Outposts does not support FIPS")]
        public void S3_outposts_does_not_support_fips_1b7d24bd97974446beb9edf6cb594fb5_Test()
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
        [ExpectedException(typeof(AmazonClientException), "S3 Outposts does not support S3 Accelerate")]
        public void S3_outposts_does_not_support_accelerate_692cbc0449644a9e9660abff002874b5_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid Arn: Outpost Access Point ARN contains sub resources")]
        public void Validates_against_subresource_f3ed9e5ecffb4f89a48604082c709e2f_Test()
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
        public void Object_lambda_useast1_571479607662439cbe85e976dd37cb25_Test()
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
        public void Object_lambda_uswest2_d15e16ab11684c8fb46b60d4eb9369a9_Test()
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
        public void Object_lambda_colon_resource_deliminator_uswest2_43000bab74c94a8bbd93bb448bf7d993_Test()
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
        public void Object_lambda_useast1_client_region_uswest2_useArnRegiontrue_3ee3b4f878a64373bc7313d43ed9a476_Test()
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
        public void Object_lambda_useast1_client_region_s3external1_useArnRegiontrue_89c3fcc1742a439a8d7e0fde07388943_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: region from ARN `us-east-1` does not match client region `s3-external-1` and UseArnRegion is `false`")]
        public void Object_lambda_useast1_client_region_s3external1_useArnRegionfalse_a97e1d9aa89343659001ea73bc16a0a6_Test()
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
        public void Object_lambda_useast1_client_region_awsglobal_useArnRegiontrue_4fb81088763345d78fd90a6357a96c27_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: region from ARN `us-east-1` does not match client region `aws-global` and UseArnRegion is `false`")]
        public void Object_lambda_useast1_client_region_awsglobal_useArnRegionfalse_0ed9392d610247fd87db289b965ccf8d_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Client was configured for partition `aws` but ARN (`arn:aws-cn:s3-object-lambda:cn-north-1:123456789012:accesspoint/mybanner`) has `aws-cn`")]
        public void Object_lambda_cnnorth1_client_region_uswest2_cross_partition_useArnRegiontrue_4105b8f2039248da908d110e5601a7e9_Test()
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
        [ExpectedException(typeof(AmazonClientException), "S3 Object Lambda does not support Dual-stack")]
        public void Object_lambda_with_dualstack_4b04f98ee84a481c9915644f7251afb9_Test()
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
        public void Object_lambda_usgoveast1_eb36cd148ad04a00b25b6c0116a76d1a_Test()
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
        public void Object_lambda_usgoveast1_with_fips_a6692df52d1845c08897c3bdaff1d608_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Partition does not support FIPS")]
        public void Object_lambda_cnnorth1_with_fips_0afa8b8e863e4f8d825862d98bb21c12_Test()
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
        [ExpectedException(typeof(AmazonClientException), "S3 Object Lambda does not support S3 Accelerate")]
        public void Object_lambda_with_accelerate_3d05c23cbad740b2b826840344c8e2bc_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: Unrecognized format: arn:aws:sqs:us-west-2:123456789012:someresource (type: someresource)")]
        public void Object_lambda_with_invalid_arn_bad_service_and_someresource_87b51337bc3a403eb6ef145195de800d_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: Object Lambda ARNs only support `accesspoint` arn types, but found: `bucket_name`")]
        public void Object_lambda_with_invalid_arn_invalid_resource_06017e0fbd1e450590775b280edbeaf3_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: bucket ARN is missing a region")]
        public void Object_lambda_with_invalid_arn_missing_region_986a183bdfae46a0a8a3042ab1669d7e_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: Missing account id")]
        public void Object_lambda_with_invalid_arn_missing_accountid_500b2b9103844fa6aaa9299cefbcf159_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: The account id may only contain a-z, A-Z, 0-9 and `-`. Found: `123.45678.9012`")]
        public void Object_lambda_with_invalid_arn_account_id_contains_invalid_characters_3c3e2552a9ac4178a0b9673e3efaf392_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: Expected a resource of the format `accesspoint:<accesspoint name>` but no name was provided")]
        public void Object_lambda_with_invalid_arn_missing_access_point_name_da911da5e8fc4071b33af53d8b863bc1_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: The access point name may only contain a-z, A-Z, 0-9 and `-`. Found: `*`")]
        public void Object_lambda_with_invalid_arn_access_point_name_contains_invalid_character_6593699495694dc291f031ad2590afc3_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: The access point name may only contain a-z, A-Z, 0-9 and `-`. Found: `my.bucket`")]
        public void Object_lambda_with_invalid_arn_access_point_name_contains_invalid_character_6c1e621fbe17465babc0caec4bdbf268_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: The ARN may only contain a single resource component after `accesspoint`.")]
        public void Object_lambda_with_invalid_arn_access_point_name_contains_sub_resources_cb41f2f98b594b8c83dfaefbd4beac4c_Test()
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
        public void Object_lambda_with_custom_endpoint_f62dcbbed3c048eb954274991b978f79_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: region from ARN `us-east-1` does not match client region `us-west-2` and UseArnRegion is `false`")]
        public void Object_lambda_arn_with_region_mismatch_and_UseArnRegionfalse_32f943253e7146b19d2ac4da79f653f7_Test()
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
        public void WriteGetObjectResponse_uswest2_7d27b3f6e29a4d0da21906395b769150_Test()
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
        public void WriteGetObjectResponse_with_custom_endpoint_ef33f3aa87c14e6e9b00ce3fc5c0c3a5_Test()
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
        public void WriteGetObjectResponse_useast1_1487f3b68f2244df995b4edee815e263_Test()
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
        public void WriteGetObjectResponse_with_fips_969ef26ef2124559a9d6d4d34b0f2033_Test()
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
        [ExpectedException(typeof(AmazonClientException), "S3 Object Lambda does not support Dual-stack")]
        public void WriteGetObjectResponse_with_dualstack_b7e9292e71534f139e7b150b0a324386_Test()
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
        [ExpectedException(typeof(AmazonClientException), "S3 Object Lambda does not support S3 Accelerate")]
        public void WriteGetObjectResponse_with_accelerate_a1daa3aba69f43ebb20106375842ec27_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Partition does not support FIPS")]
        public void WriteGetObjectResponse_with_fips_in_CN_d278d7dc86a044ab989e75d0f4b333c5_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid region: region was not a valid DNS name.")]
        public void WriteGetObjectResponse_with_invalid_partition_e78379ae2d1742cb962936ec47e9f4f8_Test()
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
        public void WriteGetObjectResponse_with_an_unknown_partition_1eb2dc3e227a4ca48089b23dcaa374c5_Test()
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

    }
}