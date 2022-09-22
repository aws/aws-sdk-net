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
        public void Vanilla_outposts_without_ARN_region_access_point_ARNuswest2_19df350cc3294f1da29526b12dff4138_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["S3Control::UseArnRegion"] = false;
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
        public void Vanilla_outposts_with_ARN_region_access_point_ARNuswest2_7b91850898544c0a9b1a4e29295ec999_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["S3Control::UseArnRegion"] = true;
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
        public void Accept_an_access_point_ARNuswest2_b3b1b6a305e345eea31262e41c96c058_Test()
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
        public void Vanilla_outposts_chinacnnorth1_2f893b825fa541a9a0ad38c9c6307df7_Test()
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
        public void Gov_regionuswest2_868d0594425e4b5089e9f355c68b1244_Test()
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
        public void Gov_cloud_with_fipsuswest2_7740120fce1d4ab5a63210095cf62be3_Test()
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
        public void Govcloud_with_fips_arn_regionusgovwest1_5ace9dc30e044cf89de988d05c093b5e_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-gov-west-1";
            parameters["RequiresAccountId"] = true;
            parameters["S3Control::UseArnRegion"] = true;
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
        public void Gov_regioncnnorth1_a725bb4d94b44776925188c4529bc5d1_Test()
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
        public void Gov_cloud_with_fipscnnorth1_67d72d73887d4d7091948d413da0e166_Test()
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
        public void Govcloud_with_fips_arn_regionusgovwest1_3f4d43e8fe1748e293e9791ba22916dc_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-gov-west-1";
            parameters["RequiresAccountId"] = true;
            parameters["S3Control::UseArnRegion"] = true;
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
        public void Gov_regionafsouth1_e4e7fcc765574b859b66b65c75762ca5_Test()
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
        public void Gov_cloud_with_fipsafsouth1_82f60d2bf674438eb0a8ec68de48bb2a_Test()
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
        public void Govcloud_with_fips_arn_regionusgovwest1_f987a58595844611bbf305d6cd624be1_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["AccessPointName"] = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            parameters["AccountId"] = "123456789012";
            parameters["Region"] = "us-gov-west-1";
            parameters["RequiresAccountId"] = true;
            parameters["S3Control::UseArnRegion"] = true;
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
        public void CreateBucket_OutpostId_outposts_endpointuseast2_453db81732b9410e8c29201015d5a313_Test()
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
        public void CreateBucket_OutpostId_with_fips_outposts_endpointuseast2_1dff3efbd5e34cb88e79856d1175b4d2_Test()
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
        public void CreateBucket_without_OutpostId_regular_endpointuseast2_516407be6f4341e48fa510b986947c7e_Test()
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
        public void ListRegionalBuckets_OutpostId_outposts_endpointuseast2_47c26170a7f14537bf491190b4e4d781_Test()
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
        public void ListRegionalBuckets_without_OutpostId_regular_endpointuseast2_5137344f1ede4392bb59f66451d02529_Test()
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
        public void ListRegionalBucket_OutpostId_with_fips_outposts_endpointuseast2_d276d6e1abf1474a8422a9bfebd5ba73_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: Outpost Access Points do not support dual-stack")]
        public void Outpost_access_points_do_not_support_dualstackuswest2_f4c1cb2ec0c747fc8e35e15540895165_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: Outpost Access Points do not support dual-stack")]
        public void Outpost_access_points_do_not_support_dualstackcnnorth1_5045c6e80200411f873e798520fb3db5_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: Outpost Access Points do not support dual-stack")]
        public void Outpost_access_points_do_not_support_dualstackafsouth1_c4a00439eba34dfbb28780abbc4b44e2_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: The Outpost Id was not set")]
        public void Invalid_ARN_must_be_include_outpost_IDuswest2_deb623b343db4ce294ea366fabf2c51e_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: Expected a 4-component resource")]
        public void Invalid_ARN_must_specify_access_pointuswest2_6b1804f822b146c48a4124e4e13bf289_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: Expected a 4-component resource")]
        public void Invalid_ARNuswest2_feb4daf8a4934ca2b4bdd4f8882f5b18_Test()
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
        public void When_set_AccountId_drives_AP_constructionuswest2_2fc76462feac4efc92ccffe797b95ce5_Test()
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
        public void Account_ID_set_inline_and_in_ARN_but_they_both_matchuswest2_fc68583e62ad4aa2856ca71f446c3bff_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: the accountId specified in the ARN (`123456789012`) does not match the parameter (`9999999`)")]
        public void Account_ID_set_inline_and_in_ARN_and_they_do_not_matchuswest2_ed0161c647ec43c4b0adcb50cc13aeba_Test()
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
        public void Get_access_point_prefixed_with_account_id_using_endpoint_urluswest2_bdacf96d9db144c7a5f3b6aec91a439f_Test()
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
        public void Endpoint_url_with_s3outpostsuswest2_319f9b5b6a4f439483e3fedcdcc56b62_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Expected an outpost type `accesspoint`, found `bucket`")]
        public void Access_point_name_with_a_bucket_arnuswest2_02188b38f12344eb98b9d370e970b817_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: Expected an outpost type `bucket`, found `accesspoint`")]
        public void Bucket_arn_with_access_point_nameuswest2_aaaa4074de3c4a26ae468524b957d13d_Test()
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
        public void Create_bucket_with_outpostsuswest2_38b9b38406d242ff8eb8e87744616942_Test()
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
        public void Get_bucket_with_endpoint_urluswest2_1e9a8ffd839742ceab24ec6e3e975193_Test()
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
        public void ListRegionalBucket_OutpostId_endpoint_urluseast2_82e38463c0df41d998ae79e42481b67e_Test()
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
        public void ListRegionalBucket_OutpostId_fips_endpoint_urluseast2_14d2eed7e58c43129dde3e01b1ce5698_Test()
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
        public void CreateBucket_OutpostId_endpoint_urluseast2_216f92f38a2f403d807665e21a6f0b92_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: Outpost Access Points do not support dual-stack")]
        public void Dualstack_cannot_be_used_with_outposts_when_an_endpoint_URL_is_setuswest2_fc87785c79984b1296c700897537a763_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: Outposts do not support dual-stack")]
        public void Dualstack_cannot_be_used_with_outpostsuswest2_2b59311c62944e2ba63679649a395c69_Test()
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
        public void Vanilla_bucket_arn_requires_account_iduswest2_a657fe33726f464799f1a7b6b7ed6ecc_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["__name"] = "apname";
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("bucket arn with UseArnRegion = true (arn region supercedes client configured region)@us-west-2")]
        public void Bucket_arn_with_UseArnRegion_true_arn_region_supercedes_client_configured_regionuswest2_16a20d33fb104579baff945e8c6f74ea_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["S3Control::UseArnRegion"] = true;
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
        public void Bucket_ARN_in_gov_partition_nonfipsusgoveast1_4e87df73196545cebf7439da2fc6f09b_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-gov-east-1";
            parameters["RequiresAccountId"] = true;
            parameters["S3Control::UseArnRegion"] = true;
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
        public void Bucket_ARN_in_gov_partition_with_FIPSusgovwest1_2e826442c4d64b86aa96b93135d8a752_Test()
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
        public void Bucket_ARN_in_aws_partition_with_FIPSuseast2_2c5e3d88e5a045dcb718139056d60497_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: Outpost buckets do not support dual-stack")]
        public void Outposts_do_not_support_dualstackuswest2_88ce0293361941b28280102213eaf84d_Test()
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
        public void Vanilla_bucket_arn_requires_account_idcnnorth1_d2b6f5e933fd4f6eaebb45cd40f748aa_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws-cn:s3-outposts:cn-north-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "cn-north-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["__name"] = "apname";
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("bucket arn with UseArnRegion = true (arn region supercedes client configured region)@us-west-2")]
        public void Bucket_arn_with_UseArnRegion_true_arn_region_supercedes_client_configured_regionuswest2_0a153428a39648feb34856a481e93396_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["S3Control::UseArnRegion"] = true;
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
        public void Bucket_ARN_in_gov_partition_nonfipsusgoveast1_9ce17452a15640b792302d8374146eec_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-gov-east-1";
            parameters["RequiresAccountId"] = true;
            parameters["S3Control::UseArnRegion"] = true;
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
        public void Bucket_ARN_in_gov_partition_with_FIPSusgovwest1_060b4b1404804bc1a1df7017df047720_Test()
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
        public void Bucket_ARN_in_aws_partition_with_FIPSuseast2_a8fcb0eeda264827947df4b50a42c026_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: Outpost buckets do not support dual-stack")]
        public void Outposts_do_not_support_dualstackuswest2_11be5ede37a7495bba35068ed1a3ad07_Test()
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
        public void Vanilla_bucket_arn_requires_account_idafsouth1_279f724bae5142a29d2d9c07859de32c_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:af-south-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "af-south-1";
            parameters["RequiresAccountId"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["__name"] = "apname";
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://s3-outposts.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("bucket arn with UseArnRegion = true (arn region supercedes client configured region)@us-west-2")]
        public void Bucket_arn_with_UseArnRegion_true_arn_region_supercedes_client_configured_regionuswest2_80a24317001b4a5cb421a7a1ecc24248_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-west-2";
            parameters["RequiresAccountId"] = true;
            parameters["S3Control::UseArnRegion"] = true;
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
        public void Bucket_ARN_in_gov_partition_nonfipsusgoveast1_46da69557b984819aba076dd3c95bb53_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            parameters["Bucket"] = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            parameters["Region"] = "us-gov-east-1";
            parameters["RequiresAccountId"] = true;
            parameters["S3Control::UseArnRegion"] = true;
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
        public void Bucket_ARN_in_gov_partition_with_FIPSusgovwest1_6f8214230a4b4d73804ffa70f92dd9c1_Test()
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
        public void Bucket_ARN_in_aws_partition_with_FIPSuseast2_6b5e18223a3d44578444b13c9b787208_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: Outpost buckets do not support dual-stack")]
        public void Outposts_do_not_support_dualstackuswest2_828426f3981e4fcaaefdeafd1f02a42c_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: The Outpost Id was not set")]
        public void Invalid_ARN_missing_outpost_id_and_bucketuswest2_5de8ea41252d47e4bfc24e7dee76b769_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: Expected a 4-component resource")]
        public void Invalid_ARN_missing_bucketuswest2_b4fd6c2e48c448dea74a4b85436de2b6_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: Expected a 4-component resource")]
        public void Invalid_ARN_missing_outpost_and_bucket_idsuswest2_3c398ca070964e328c6f7606f04ed6c0_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: expected a bucket name")]
        public void Invalid_ARN_missing_bucket_iduswest2_90b4f35e69f4476fbaff5a6df7e6fae0_Test()
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
        public void Account_id_inserted_into_hostnameuswest2_4ba7e23917cb40faae90b4a929a6bd43_Test()
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
        public void Account_id_prefix_with_dualstackuseast1_eb441171871e4ef6b4dfce7b1d7f98d1_Test()
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
        public void Account_id_prefix_with_fipsuseast1_e152de2bb6044231b245f3693cf7ec12_Test()
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
        public void Custom_account_id_prefix_with_fipsuseast1_7441a7394a2647b88f0b66d095a1c9a1_Test()
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
        public void Standard_url_useast1_57226a03e10e436dbdcd0e121ed4f913_Test()
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
        public void Fips_url_useast1_542a5b997db44c5087bd0e7a1d3e5283_Test()
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
        public void Dualstack_url_useast1_dd756e4bc2c1490b8390e0c158e1e75a_Test()
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
        public void Fipsdualstack_url_useast1_ff163c29677a4e5786f261410560050a_Test()
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
        public void Standard_url_cnnorth1_a592dbc46a1e4e33b56ea5816d3c523c_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Partition does not support FIPS")]
        public void Fips_cnnorth1_6d30ff9fd32443669ad27abccdf09c93_Test()
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
        public void Custom_account_id_prefix_useast1_ebe260bdfeca45a1ae0b11e22837bd18_Test()
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
        [ExpectedException(typeof(AmazonClientException), "AccountId must only contain a-z, A-Z, 0-9 and `-`.")]
        public void Invalid_account_id_prefix_useast1_c8c730bcc7c94e03b5cb40729d46b114_Test()
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
        public void Custom_account_id_prefix_with_fipsuseast1_05ecd98c31b14a2fac718468fd953f97_Test()
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
        public void Custom_account_id_prefix_with_dualstackfipsuseast1_7142a580bc484d23a38186c91b6563ba_Test()
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
        public void Custom_account_id_with_custom_endpoint_c00e2e03fe9143358885646de0916cc1_Test()
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
        [ExpectedException(typeof(AmazonClientException), "AccountId is required but not set")]
        public void RequiresAccountId_with_AccountId_unset_f34742e9d3d244c886a7bd2fd08a7843_Test()
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
        [ExpectedException(typeof(AmazonClientException), "AccountId is required but not set")]
        public void RequiresAccountId_with_AccountId_unset_and_custom_endpoint_54a2ceb7fb7c4c7e9d8f0eec4a24d2ac_Test()
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
        [ExpectedException(typeof(AmazonClientException), "AccountId must only contain a-z, A-Z, 0-9 and `-`.")]
        public void RequiresAccountId_with_invalid_AccountId_and_custom_endpoint_c34ec59c0e08464197c478e20a78d9de_Test()
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
        public void Account_id_with_custom_endpoint_fips_and_dualstack_1cbe42da446e4954b10a28e753afbb76_Test()
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
        public void Custom_endpoint_fips_and_dualstack_975a9911f9554b848196227bce519010_Test()
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
        public void Custom_endpoint_fips_687d43421fd9481a982757169a43ce63_Test()
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
        public void Custom_endpoint_dualstack_e633039e79ee49b3804373230a7e8942_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Region must be set")]
        public void Region_not_set_2bbe7a9a287143c39b3f43397b9ecb0a_Test()
        {
            var parameters = new S3ControlEndpointParameters();
            var endpoint = new AmazonS3ControlEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("S3Control")]
        [Description("invalid partition")]
        [ExpectedException(typeof(AmazonClientException), "Invalid region: region was not a valid DNS name.")]
        public void Invalid_partition_dbbbfeff953845dfbb2714fc28056875_Test()
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
        [ExpectedException(typeof(AmazonClientException), "AccountId is required but not set")]
        public void ListRegionalBuckets_OutpostId_without_accountId_set_53ddc87fadd94e2d98003e4a44077d9f_Test()
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
        [ExpectedException(typeof(AmazonClientException), "AccountId must only contain a-z, A-Z, 0-9 and `-`.")]
        public void ListRegionalBuckets_OutpostId_with_invalid_accountId_set_55ca281a2b6b41dd805c63691b0e3268_Test()
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
        [ExpectedException(typeof(AmazonClientException), "AccountId is required but not set")]
        public void Accesspoint_set_but_missing_accountId_ec8c8c4980e84c788afee05c623bbe04_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: missing account ID")]
        public void Outpost_accesspoint_ARN_with_missing_accountId_01ecb6e2af654af78baa59b2766974d2_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: missing account ID")]
        public void Bucket_ARN_with_missing_accountId_80b2bf4ab3ce4a27bc84734ed8e7ecdc_Test()
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
        public void Endpoint_url_with_accesspoint_nonarn_4bb7e36e950e4193bb1f3e5973cb76c8_Test()
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
        public void Access_point_name_with_an_accesspoint_arnuswest2_62f933161d52469c881cb2062a3ff377_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void Dualstack_Custom_endpoint_is_not_supportednonarn_716942cb756844099ab380c58be1d817_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: Outpost buckets do not support dual-stack")]
        public void Get_bucket_with_endpoint_url_and_dualstack_is_not_supporteduswest2_45814bea7a02460086e812668b0bc990_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Partition does not support FIPS")]
        public void ListRegionalBuckets_OutpostId_with_fips_in_CN_974ea24898c44608a7881c617c461566_Test()
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
        [ExpectedException(typeof(AmazonClientException), "OutpostId must only contain a-z, A-Z, 0-9 and `-`.")]
        public void ListRegionalBuckets_invalid_OutpostId_d354cfbc5be448bca27aee5c6387784e_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid ARN: the accountId specified in the ARN (`999999`) does not match the parameter (`0123456789012`)")]
        public void Bucket_ARN_with_mismatched_accountId_c1f6a80c0e2f483aa0b2a2ddb75e7dd7_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid region: region was not a valid DNS name.")]
        public void OutpostId_with_invalid_region_79d2011ec7ff4141b1fb7024349939b6_Test()
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
        public void OutpostId_with_RequireAccountId_unset_51e2944f778b4f45aa1aa094104100f5_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: region from ARN `us-east-1` does not match client region `us-west-2` and UseArnRegion is `false`")]
        public void Outpost_Accesspoint_ARN_with_arn_region_and_client_region_mismatch_with_UseArnRegionfalse_551603d1a1b24a1b96b00938d652e06a_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: region from ARN `us-east-1` does not match client region `us-west-2` and UseArnRegion is `false`")]
        public void Outpost_Bucket_ARN_with_arn_region_and_client_region_mismatch_with_UseArnRegionfalse_8482deba26f24f63a8c69a5cf1be5670_Test()
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
        public void Accesspoint_ARN_with_region_mismatch_and_UseArnRegion_unset_97b389baf22042b2a2cddb2588934744_Test()
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
        public void Bucket_ARN_with_region_mismatch_and_UseArnRegion_unset_0b3c674bc7224176a1016b16d8e9ac1e_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Client was configured for partition `aws` but ARN has `aws-cn`")]
        public void Outpost_Bucket_ARN_with_partition_mismatch_with_UseArnRegiontrue_2ae1e9099160489fadd88ce88fb7d770_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Client was configured for partition `aws` but ARN has `aws-cn`")]
        public void Accesspoint_ARN_with_partition_mismatch_and_UseArnRegiontrue_ac400ad2946c484b921a17ef36949f85_Test()
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
        [ExpectedException(typeof(AmazonClientException), "Invalid configuration: region from ARN `cn-north-1` does not match client region `us-west-2` and UseArnRegion is `false`")]
        public void Accesspoint_ARN_with_region_mismatch_UseArnRegionfalse_and_custom_endpoint_be56bb811f624ccfbcb693ac4432f5f5_Test()
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

    }
}