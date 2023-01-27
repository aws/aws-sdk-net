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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.S3Control.Endpoints;
using Amazon.S3Control.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class S3ControlEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Vanilla outposts without ARN region + access point ARN@us-west-2")]
        public void Vanilla_outposts_without_ARN_region_access_point_ARNuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Vanilla outposts with ARN region + access point ARN@us-west-2")]
        public void Vanilla_outposts_with_ARN_region_access_point_ARNuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("accept an access point ARN@us-west-2")]
        public void Accept_an_access_point_ARNuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("vanilla outposts china@cn-north-1")]
        public void Vanilla_outposts_chinacnnorth1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws-cn:s3-outposts:cn-north-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "cn-north-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("gov region@us-west-2")]
        public void Gov_regionuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("gov cloud with fips@us-west-2")]
        public void Gov_cloud_with_fipsuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("govcloud with fips + arn region@us-gov-west-1")]
        public void Govcloud_with_fips_arn_regionusgovwest1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-gov-west-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("gov region@cn-north-1")]
        public void Gov_regioncnnorth1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws-cn:s3-outposts:cn-north-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "cn-north-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("gov cloud with fips@cn-north-1")]
        public void Gov_cloud_with_fipscnnorth1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws-cn:s3-outposts:cn-north-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "cn-north-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("govcloud with fips + arn region@us-gov-west-1")]
        public void Govcloud_with_fips_arn_regionusgovwest1_1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-gov-west-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("gov region@af-south-1")]
        public void Gov_regionafsouth1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:af-south-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "af-south-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("gov cloud with fips@af-south-1")]
        public void Gov_cloud_with_fipsafsouth1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:af-south-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "af-south-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("govcloud with fips + arn region@us-gov-west-1")]
        public void Govcloud_with_fips_arn_regionusgovwest1_2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-gov-west-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("CreateBucket + OutpostId = outposts endpoint@us-east-2")]
        public void CreateBucket_OutpostId_outposts_endpointuseast2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "blah";
            parameters["Operation"] = "CreateBucket";
            parameters["OutpostId"] = "123";
            parameters["Region"] = "us-east-2";
            parameters["RequiresAccountId"] = false;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("CreateBucket + OutpostId with fips = outposts endpoint@us-east-2")]
        public void CreateBucket_OutpostId_with_fips_outposts_endpointuseast2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "blah";
            parameters["Operation"] = "CreateBucket";
            parameters["OutpostId"] = "123";
            parameters["Region"] = "us-east-2";
            parameters["RequiresAccountId"] = false;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("CreateBucket without OutpostId = regular endpoint@us-east-2")]
        public void CreateBucket_without_OutpostId_regular_endpointuseast2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "blah";
            parameters["Operation"] = "CreateBucket";
            parameters["Region"] = "us-east-2";
            parameters["RequiresAccountId"] = false;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-control.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("ListRegionalBuckets + OutpostId = outposts endpoint@us-east-2")]
        public void ListRegionalBuckets_OutpostId_outposts_endpointuseast2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccountId"] = "123";
            parameters["Operation"] = "ListRegionalBuckets";
            parameters["OutpostId"] = "op-123";
            parameters["Region"] = "us-east-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("ListRegionalBuckets without OutpostId = regular endpoint@us-east-2")]
        public void ListRegionalBuckets_without_OutpostId_regular_endpointuseast2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccountId"] = "123";
            parameters["Operation"] = "ListRegionalBuckets";
            parameters["Region"] = "us-east-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.s3-control.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("ListRegionalBucket + OutpostId with fips = outposts endpoint@us-east-2")]
        public void ListRegionalBucket_OutpostId_with_fips_outposts_endpointuseast2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccountId"] = "123";
            parameters["Operation"] = "CreateBucket";
            parameters["OutpostId"] = "op-123";
            parameters["Region"] = "us-east-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("outpost access points do not support dualstack@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: Outpost Access Points do not support dual-stack")]
        public void Outpost_access_points_do_not_support_dualstackuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("outpost access points do not support dualstack@cn-north-1")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: Outpost Access Points do not support dual-stack")]
        public void Outpost_access_points_do_not_support_dualstackcnnorth1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "cn-north-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("outpost access points do not support dualstack@af-south-1")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: Outpost Access Points do not support dual-stack")]
        public void Outpost_access_points_do_not_support_dualstackafsouth1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "af-south-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("invalid ARN: must be include outpost ID@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: The Outpost Id was not set")]
        public void Invalid_ARN_must_be_include_outpost_IDuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("invalid ARN: must specify access point@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Expected a 4-component resource")]
        public void Invalid_ARN_must_specify_access_pointuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("invalid ARN@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Expected a 4-component resource")]
        public void Invalid_ARNuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:myaccesspoint";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("when set, AccountId drives AP construction@us-west-2")]
        public void When_set_AccountId_drives_AP_constructionuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "myaccesspoint";
            parameters["AccountId"] = "myid-1234";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://myid-1234.s3-control.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Account ID set inline and in ARN but they both match@us-west-2")]
        public void Account_ID_set_inline_and_in_ARN_but_they_both_matchuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseArnRegion"] = false;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Account ID set inline and in ARN and they do not match@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: the accountId specified in the ARN (`123456789012`) does not match the parameter (`9999999`)")]
        public void Account_ID_set_inline_and_in_ARN_and_they_do_not_matchuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "9999999";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseArnRegion"] = false;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("get access point prefixed with account id using endpoint url@us-west-2")]
        public void Get_access_point_prefixed_with_account_id_using_endpoint_urluswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "apname";
            parameters["AccountId"] = "123456789012";
            parameters["Endpoint"] = "https://control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com";
            parameters["Operation"] = "GetAccessPoint";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.control.vpce-1a2b3c4d-5e6f.s3.us-west-2.vpce.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("endpoint url with s3-outposts@us-west-2")]
        public void Endpoint_url_with_s3outpostsuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["Operation"] = "GetAccessPoint";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://beta.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("access point name with a bucket arn@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Expected an outpost type `accesspoint`, found `bucket`")]
        public void Access_point_name_with_a_bucket_arnuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Endpoint"] = "beta.example.com";
            parameters["Operation"] = "GetAccessPoint";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("bucket arn with access point name@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Expected an outpost type `bucket`, found `accesspoint`")]
        public void Bucket_arn_with_access_point_nameuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["Endpoint"] = "beta.example.com";
            parameters["Operation"] = "GetBucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("create bucket with outposts@us-west-2")]
        public void Create_bucket_with_outpostsuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "bucketname";
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["Operation"] = "CreateBucket";
            parameters["OutpostId"] = "op-123";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = false;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://beta.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("get bucket with endpoint_url@us-west-2")]
        public void Get_bucket_with_endpoint_urluswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["Operation"] = "GetBucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://beta.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("ListRegionalBucket + OutpostId endpoint url@us-east-2")]
        public void ListRegionalBucket_OutpostId_endpoint_urluseast2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccountId"] = "123";
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["Operation"] = "CreateBucket";
            parameters["OutpostId"] = "op-123";
            parameters["Region"] = "us-east-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://beta.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("ListRegionalBucket + OutpostId + fips + endpoint url@us-east-2")]
        public void ListRegionalBucket_OutpostId_fips_endpoint_urluseast2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccountId"] = "123";
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["Operation"] = "CreateBucket";
            parameters["OutpostId"] = "op-123";
            parameters["Region"] = "us-east-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://beta.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("CreateBucket + OutpostId endpoint url@us-east-2")]
        public void CreateBucket_OutpostId_endpoint_urluseast2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "blah";
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["Operation"] = "CreateBucket";
            parameters["OutpostId"] = "123";
            parameters["Region"] = "us-east-2";
            parameters["RequiresAccountId"] = false;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://beta.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("dualstack cannot be used with outposts when an endpoint URL is set@us-west-2.")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: Outpost Access Points do not support dual-stack")]
        public void Dualstack_cannot_be_used_with_outposts_when_an_endpoint_URL_is_setuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["Operation"] = "GetAccessPoint";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Dual-stack cannot be used with outposts@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: Outposts do not support dual-stack")]
        public void Dualstack_cannot_be_used_with_outpostsuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "bucketname";
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["Operation"] = "CreateBucket";
            parameters["OutpostId"] = "op-123";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = false;
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("vanilla bucket arn requires account id@us-west-2")]
        public void Vanilla_bucket_arn_requires_account_iduswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("bucket arn with UseArnRegion = true (arn region supercedes client configured region)@us-west-2")]
        public void Bucket_arn_with_UseArnRegion_true_arn_region_supercedes_client_configured_regionuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("bucket ARN in gov partition (non-fips)@us-gov-east-1")]
        public void Bucket_ARN_in_gov_partition_nonfipsusgoveast1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-gov-east-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("bucket ARN in gov partition with FIPS@us-gov-west-1")]
        public void Bucket_ARN_in_gov_partition_with_FIPSusgovwest1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws-us-gov:s3-outposts:us-gov-west-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-gov-west-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("bucket ARN in aws partition with FIPS@us-east-2")]
        public void Bucket_ARN_in_aws_partition_with_FIPSuseast2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-east-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Outposts do not support dualstack@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: Outpost buckets do not support dual-stack")]
        public void Outposts_do_not_support_dualstackuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("vanilla bucket arn requires account id@cn-north-1")]
        public void Vanilla_bucket_arn_requires_account_idcnnorth1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws-cn:s3-outposts:cn-north-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "cn-north-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("bucket arn with UseArnRegion = true (arn region supercedes client configured region)@us-west-2")]
        public void Bucket_arn_with_UseArnRegion_true_arn_region_supercedes_client_configured_regionuswest2_1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("bucket ARN in gov partition (non-fips)@us-gov-east-1")]
        public void Bucket_ARN_in_gov_partition_nonfipsusgoveast1_1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-gov-east-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("bucket ARN in gov partition with FIPS@us-gov-west-1")]
        public void Bucket_ARN_in_gov_partition_with_FIPSusgovwest1_1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws-us-gov:s3-outposts:us-gov-west-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-gov-west-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("bucket ARN in aws partition with FIPS@us-east-2")]
        public void Bucket_ARN_in_aws_partition_with_FIPSuseast2_1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-east-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Outposts do not support dualstack@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: Outpost buckets do not support dual-stack")]
        public void Outposts_do_not_support_dualstackuswest2_1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("vanilla bucket arn requires account id@af-south-1")]
        public void Vanilla_bucket_arn_requires_account_idafsouth1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:af-south-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "af-south-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("bucket arn with UseArnRegion = true (arn region supercedes client configured region)@us-west-2")]
        public void Bucket_arn_with_UseArnRegion_true_arn_region_supercedes_client_configured_regionuswest2_2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("bucket ARN in gov partition (non-fips)@us-gov-east-1")]
        public void Bucket_ARN_in_gov_partition_nonfipsusgoveast1_2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-gov-east-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("bucket ARN in gov partition with FIPS@us-gov-west-1")]
        public void Bucket_ARN_in_gov_partition_with_FIPSusgovwest1_2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws-us-gov:s3-outposts:us-gov-west-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-gov-west-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("bucket ARN in aws partition with FIPS@us-east-2")]
        public void Bucket_ARN_in_aws_partition_with_FIPSuseast2_2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-east-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Outposts do not support dualstack@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: Outpost buckets do not support dual-stack")]
        public void Outposts_do_not_support_dualstackuswest2_2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Invalid ARN: missing outpost id and bucket@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: The Outpost Id was not set")]
        public void Invalid_ARN_missing_outpost_id_and_bucketuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Invalid ARN: missing bucket@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Expected a 4-component resource")]
        public void Invalid_ARN_missing_bucketuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Invalid ARN: missing outpost and bucket ids@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Expected a 4-component resource")]
        public void Invalid_ARN_missing_outpost_and_bucket_idsuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:bucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Invalid ARN: missing bucket id@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: expected a bucket name")]
        public void Invalid_ARN_missing_bucket_iduswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("account id inserted into hostname@us-west-2")]
        public void Account_id_inserted_into_hostnameuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccountId"] = "1234567890";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://1234567890.s3-control.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("account id prefix with dualstack@us-east-1")]
        public void Account_id_prefix_with_dualstackuseast1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccountId"] = "1234567890";
            parameters["Region"] = "us-east-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://1234567890.s3-control.dualstack.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("account id prefix with fips@us-east-1")]
        public void Account_id_prefix_with_fipsuseast1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccountId"] = "1234567890";
            parameters["Region"] = "us-east-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://1234567890.s3-control-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("custom account id prefix with fips@us-east-1")]
        public void Custom_account_id_prefix_with_fipsuseast1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccountId"] = "1234567890-aBC";
            parameters["Region"] = "us-east-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://1234567890-aBC.s3-control-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("standard url @ us-east-1")]
        public void Standard_url_useast1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-control.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("fips url @ us-east-1")]
        public void Fips_url_useast1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-control-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("dualstack url @ us-east-1")]
        public void Dualstack_url_useast1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-control.dualstack.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("fips,dualstack url @ us-east-1")]
        public void Fipsdualstack_url_useast1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-control-fips.dualstack.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("standard url @ cn-north-1")]
        public void Standard_url_cnnorth1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-control.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("fips @ cn-north-1")]
        [ExpectedException(typeof(AmazonClientException), @"Partition does not support FIPS")]
        public void Fips_cnnorth1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("custom account id prefix @us-east-1")]
        public void Custom_account_id_prefix_useast1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccountId"] = "1234567890-aBC";
            parameters["Region"] = "us-east-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://1234567890-aBC.s3-control.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("invalid account id prefix @us-east-1")]
        [ExpectedException(typeof(AmazonClientException), @"AccountId must only contain a-z, A-Z, 0-9 and `-`.")]
        public void Invalid_account_id_prefix_useast1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccountId"] = "/?invalid&not-host*label";
            parameters["Region"] = "us-east-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("custom account id prefix with fips@us-east-1")]
        public void Custom_account_id_prefix_with_fipsuseast1_1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccountId"] = "1234567890-aBC";
            parameters["Region"] = "us-east-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://1234567890-aBC.s3-control-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("custom account id prefix with dualstack,fips@us-east-1")]
        public void Custom_account_id_prefix_with_dualstackfipsuseast1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccountId"] = "1234567890-aBC";
            parameters["Region"] = "us-east-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://1234567890-aBC.s3-control-fips.dualstack.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("custom account id with custom endpoint")]
        public void Custom_account_id_with_custom_endpoint_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccountId"] = "1234567890-aBC";
            parameters["Region"] = "us-east-1";
            parameters["RequiresAccountId"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://1234567890-aBC.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("RequiresAccountId with AccountId unset")]
        [ExpectedException(typeof(AmazonClientException), @"AccountId is required but not set")]
        public void RequiresAccountId_with_AccountId_unset_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["RequiresAccountId"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("RequiresAccountId with AccountId unset and custom endpoint")]
        [ExpectedException(typeof(AmazonClientException), @"AccountId is required but not set")]
        public void RequiresAccountId_with_AccountId_unset_and_custom_endpoint_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["RequiresAccountId"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("RequiresAccountId with invalid AccountId and custom endpoint")]
        [ExpectedException(typeof(AmazonClientException), @"AccountId must only contain a-z, A-Z, 0-9 and `-`.")]
        public void RequiresAccountId_with_invalid_AccountId_and_custom_endpoint_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["AccountId"] = "/?invalid&not-host*label";
            parameters["RequiresAccountId"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("account id with custom endpoint, fips and dualstack")]
        public void Account_id_with_custom_endpoint_fips_and_dualstack_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccountId"] = "1234567890-aBC";
            parameters["Region"] = "us-east-1";
            parameters["RequiresAccountId"] = true;
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = true;
            parameters["UseDualstack"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://1234567890-aBC.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("custom endpoint, fips and dualstack")]
        public void Custom_endpoint_fips_and_dualstack_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = true;
            parameters["UseDualstack"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("custom endpoint, fips")]
        public void Custom_endpoint_fips_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = true;
            parameters["UseDualstack"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("custom endpoint, dualstack")]
        public void Custom_endpoint_dualstack_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = false;
            parameters["UseDualstack"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("region not set")]
        [ExpectedException(typeof(AmazonClientException), @"Region must be set")]
        public void Region_not_set_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("invalid partition")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid region: region was not a valid DNS name.")]
        public void Invalid_partition_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Region"] = "invalid-region 42";
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("ListRegionalBuckets + OutpostId without accountId set.")]
        [ExpectedException(typeof(AmazonClientException), @"AccountId is required but not set")]
        public void ListRegionalBuckets_OutpostId_without_accountId_set_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Operation"] = "ListRegionalBuckets";
            parameters["OutpostId"] = "op-123";
            parameters["Region"] = "us-east-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("ListRegionalBuckets + OutpostId with invalid accountId set.")]
        [ExpectedException(typeof(AmazonClientException), @"AccountId must only contain a-z, A-Z, 0-9 and `-`.")]
        public void ListRegionalBuckets_OutpostId_with_invalid_accountId_set_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccountId"] = "/?invalid&not-host*label";
            parameters["Operation"] = "ListRegionalBuckets";
            parameters["OutpostId"] = "op-123";
            parameters["Region"] = "us-east-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("accesspoint set but missing accountId")]
        [ExpectedException(typeof(AmazonClientException), @"AccountId is required but not set")]
        public void Accesspoint_set_but_missing_accountId_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "myaccesspoint";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("outpost accesspoint ARN with missing accountId")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: missing account ID")]
        public void Outpost_accesspoint_ARN_with_missing_accountId_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2::outpost:op-01234567890123456:outpost:op1";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("bucket ARN with missing accountId")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: missing account ID")]
        public void Bucket_ARN_with_missing_accountId_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2::outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("endpoint url with accesspoint (non-arn)")]
        public void Endpoint_url_with_accesspoint_nonarn_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "apname";
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["AccountId"] = "123456789012";
            parameters["Operation"] = "GetAccessPoint";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.beta.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("access point name with an accesspoint arn@us-west-2")]
        public void Access_point_name_with_an_accesspoint_arnuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["Operation"] = "GetAccessPoint";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://beta.example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Dualstack + Custom endpoint is not supported(non-arn)")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void Dualstack_Custom_endpoint_is_not_supportednonarn_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "apname";
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["AccountId"] = "123456789012";
            parameters["Operation"] = "GetAccessPoint";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("get bucket with endpoint_url and dualstack is not supported@us-west-2")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: Outpost buckets do not support dual-stack")]
        public void Get_bucket_with_endpoint_url_and_dualstack_is_not_supporteduswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["Operation"] = "GetBucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("ListRegionalBuckets + OutpostId with fips in CN.")]
        [ExpectedException(typeof(AmazonClientException), @"Partition does not support FIPS")]
        public void ListRegionalBuckets_OutpostId_with_fips_in_CN_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccountId"] = "0123456789012";
            parameters["Operation"] = "ListRegionalBuckets";
            parameters["OutpostId"] = "op-123";
            parameters["Region"] = "cn-north-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("ListRegionalBuckets + invalid OutpostId.")]
        [ExpectedException(typeof(AmazonClientException), @"OutpostId must only contain a-z, A-Z, 0-9 and `-`.")]
        public void ListRegionalBuckets_invalid_OutpostId_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccountId"] = "0123456789012";
            parameters["Operation"] = "ListRegionalBuckets";
            parameters["OutpostId"] = "?outpost/invalid+";
            parameters["Region"] = "us-west-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("bucket ARN with mismatched accountId")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: the accountId specified in the ARN (`999999`) does not match the parameter (`0123456789012`)")]
        public void Bucket_ARN_with_mismatched_accountId_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:999999:outpost:op-01234567890123456:bucket:mybucket";
            parameters["AccountId"] = "0123456789012";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("OutpostId with invalid region")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid region: region was not a valid DNS name.")]
        public void OutpostId_with_invalid_region_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Operation"] = "ListRegionalBuckets";
            parameters["OutpostId"] = "op-123";
            parameters["Region"] = "invalid-region 42";
            parameters["AccountId"] = "0123456";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("OutpostId with RequireAccountId unset")]
        public void OutpostId_with_RequireAccountId_unset_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Operation"] = "ListRegionalBuckets";
            parameters["OutpostId"] = "op-123";
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Outpost Accesspoint ARN with arn region and client region mismatch with UseArnRegion=false")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: region from ARN `us-east-1` does not match client region `us-west-2` and UseArnRegion is `false`")]
        public void Outpost_Accesspoint_ARN_with_arn_region_and_client_region_mismatch_with_UseArnRegionfalse_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseArnRegion"] = false;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Outpost Bucket ARN with arn region and client region mismatch with UseArnRegion=false")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: region from ARN `us-east-1` does not match client region `us-west-2` and UseArnRegion is `false`")]
        public void Outpost_Bucket_ARN_with_arn_region_and_client_region_mismatch_with_UseArnRegionfalse_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Endpoint"] = "https://beta.example.com";
            parameters["Operation"] = "GetBucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseArnRegion"] = false;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Accesspoint ARN with region mismatch and UseArnRegion unset")]
        public void Accesspoint_ARN_with_region_mismatch_and_UseArnRegion_unset_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Bucket ARN with region mismatch and UseArnRegion unset")]
        public void Bucket_ARN_with_region_mismatch_and_UseArnRegion_unset_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Outpost Bucket ARN with partition mismatch with UseArnRegion=true")]
        [ExpectedException(typeof(AmazonClientException), @"Client was configured for partition `aws` but ARN has `aws-cn`")]
        public void Outpost_Bucket_ARN_with_partition_mismatch_with_UseArnRegiontrue_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:cn-north-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Operation"] = "GetBucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseArnRegion"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Accesspoint ARN with partition mismatch and UseArnRegion=true")]
        [ExpectedException(typeof(AmazonClientException), @"Client was configured for partition `aws` but ARN has `aws-cn`")]
        public void Accesspoint_ARN_with_partition_mismatch_and_UseArnRegiontrue_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:cn-north-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseArnRegion"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("Accesspoint ARN with region mismatch, UseArnRegion=false and custom endpoint")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid configuration: region from ARN `cn-north-1` does not match client region `us-west-2` and UseArnRegion is `false`")]
        public void Accesspoint_ARN_with_region_mismatch_UseArnRegionfalse_and_custom_endpoint_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:cn-north-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["Region"] = "us-west-2";
            parameters["Endpoint"] = "https://example.com";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseArnRegion"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("outpost bucket arn@us-west-2")]
        public void Outpost_bucket_arnuswest2_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-west-2.amazonaws.com", endpoint.URL);
        }

    }
}