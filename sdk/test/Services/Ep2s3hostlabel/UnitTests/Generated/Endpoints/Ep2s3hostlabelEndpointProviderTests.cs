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
 * Do not modify this file. This file is generated from the ep2-s3-host-label-2022-08-24.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.Ep2s3hostlabel.Endpoints;
using Amazon.Ep2s3hostlabel.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class Ep2s3hostlabelEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2s3hostlabel")]
        [Description("bucket-name:  isVirtualHostable")]
        public void Bucketname_isVirtualHostable_76168a5f9d9043219ff9fa42e9daf9b9_Test()
        {
            var parameters = new Ep2s3hostlabelEndpointParameters();
            parameters["BucketName"] = "bucket-name";
            var endpoint = new AmazonEp2s3hostlabelEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-name.s3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2s3hostlabel")]
        [Description("bucket-with-number-1: isVirtualHostable")]
        public void Bucketwithnumber1_isVirtualHostable_83754e8be5d64a6aab530ff51bc1506d_Test()
        {
            var parameters = new Ep2s3hostlabelEndpointParameters();
            parameters["BucketName"] = "bucket-with-number-1";
            var endpoint = new AmazonEp2s3hostlabelEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://bucket-with-number-1.s3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2s3hostlabel")]
        [Description("BucketName: not isVirtualHostable (uppercase characters)")]
        [ExpectedException(typeof(AmazonClientException), "not isVirtualHostableS3Bucket")]
        public void BucketName_not_isVirtualHostable_uppercase_characters_27f7ee70c5ba4c76b4df8d9cc1f5bcc8_Test()
        {
            var parameters = new Ep2s3hostlabelEndpointParameters();
            parameters["BucketName"] = "BucketName";
            var endpoint = new AmazonEp2s3hostlabelEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2s3hostlabel")]
        [Description("bucket_name: not isVirtualHostable (underscore)")]
        [ExpectedException(typeof(AmazonClientException), "not isVirtualHostableS3Bucket")]
        public void Bucket_name_not_isVirtualHostable_underscore_74ddab7995784638ba40cf99f1112b3e_Test()
        {
            var parameters = new Ep2s3hostlabelEndpointParameters();
            parameters["BucketName"] = "bucket_name";
            var endpoint = new AmazonEp2s3hostlabelEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2s3hostlabel")]
        [Description("bucket.name: isVirtualHostable (http only)")]
        public void Bucketname_isVirtualHostable_http_only_88ab10e37e284401ab7478b427aabcb5_Test()
        {
            var parameters = new Ep2s3hostlabelEndpointParameters();
            parameters["BucketName"] = "bucket.name";
            var endpoint = new AmazonEp2s3hostlabelEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://bucket.name.s3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2s3hostlabel")]
        [Description("bucket.name.multiple.dots1: isVirtualHostable (http only)")]
        public void Bucketnamemultipledots1_isVirtualHostable_http_only_ad2421f1101b4b85a898e326db7b3362_Test()
        {
            var parameters = new Ep2s3hostlabelEndpointParameters();
            parameters["BucketName"] = "bucket.name.multiple.dots1";
            var endpoint = new AmazonEp2s3hostlabelEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://bucket.name.multiple.dots1.s3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2s3hostlabel")]
        [Description("-bucket-name: not isVirtualHostable (leading dash)")]
        [ExpectedException(typeof(AmazonClientException), "not isVirtualHostableS3Bucket")]
        public void Bucketname_not_isVirtualHostable_leading_dash_1e2b24ef6deb4f75a8b77fddd73dff7f_Test()
        {
            var parameters = new Ep2s3hostlabelEndpointParameters();
            parameters["BucketName"] = "-bucket-name";
            var endpoint = new AmazonEp2s3hostlabelEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2s3hostlabel")]
        [Description("bucket-name-: not isVirtualHostable (trailing dash)")]
        [ExpectedException(typeof(AmazonClientException), "not isVirtualHostableS3Bucket")]
        public void Bucketname_not_isVirtualHostable_trailing_dash_34ee26cb117c45619514a46568b23643_Test()
        {
            var parameters = new Ep2s3hostlabelEndpointParameters();
            parameters["BucketName"] = "bucket-name-";
            var endpoint = new AmazonEp2s3hostlabelEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2s3hostlabel")]
        [Description("aa: not isVirtualHostable (< 3 characters)")]
        [ExpectedException(typeof(AmazonClientException), "not isVirtualHostableS3Bucket")]
        public void Aa_not_isVirtualHostable_3_characters_f7c9c532e4b94a49b37253cd22e01483_Test()
        {
            var parameters = new Ep2s3hostlabelEndpointParameters();
            parameters["BucketName"] = "aa";
            var endpoint = new AmazonEp2s3hostlabelEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2s3hostlabel")]
        [Description("'a'*64: not isVirtualHostable (> 63 characters)")]
        [ExpectedException(typeof(AmazonClientException), "not isVirtualHostableS3Bucket")]
        public void A64_not_isVirtualHostable_63_characters_615a2599d655486b846003b64c485c35_Test()
        {
            var parameters = new Ep2s3hostlabelEndpointParameters();
            parameters["BucketName"] = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            var endpoint = new AmazonEp2s3hostlabelEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2s3hostlabel")]
        [Description(".bucket-name: not isVirtualHostable (leading dot)")]
        [ExpectedException(typeof(AmazonClientException), "not isVirtualHostableS3Bucket")]
        public void Bucketname_not_isVirtualHostable_leading_dot_2ef6639f3e314d0a96f4b398a2e95e22_Test()
        {
            var parameters = new Ep2s3hostlabelEndpointParameters();
            parameters["BucketName"] = ".bucket-name";
            var endpoint = new AmazonEp2s3hostlabelEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2s3hostlabel")]
        [Description("bucket-name.: not isVirtualHostable (trailing dot)")]
        [ExpectedException(typeof(AmazonClientException), "not isVirtualHostableS3Bucket")]
        public void Bucketname_not_isVirtualHostable_trailing_dot_054fc8f06ac84362b46b89a8508e7d4c_Test()
        {
            var parameters = new Ep2s3hostlabelEndpointParameters();
            parameters["BucketName"] = "bucket-name.";
            var endpoint = new AmazonEp2s3hostlabelEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2s3hostlabel")]
        [Description("192.168.5.4: not isVirtualHostable (formatted like an ip address)")]
        [ExpectedException(typeof(AmazonClientException), "not isVirtualHostableS3Bucket")]
        public void _19216854_not_isVirtualHostable_formatted_like_an_ip_address_61aca4b4a0594b56b4a9ce65110c4323_Test()
        {
            var parameters = new Ep2s3hostlabelEndpointParameters();
            parameters["BucketName"] = "192.168.5.4";
            var endpoint = new AmazonEp2s3hostlabelEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2s3hostlabel")]
        [Description("bucket-.name: not isVirtualHostable (invalid label, ends with a -)")]
        [ExpectedException(typeof(AmazonClientException), "not isVirtualHostableS3Bucket")]
        public void Bucketname_not_isVirtualHostable_invalid_label_ends_with_a_3dd03461a96843d088ceaeee636c6f88_Test()
        {
            var parameters = new Ep2s3hostlabelEndpointParameters();
            parameters["BucketName"] = "bucket-.name";
            var endpoint = new AmazonEp2s3hostlabelEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2s3hostlabel")]
        [Description("bucket.-name: not isVirtualHostable (invalid label, starts with a -)")]
        [ExpectedException(typeof(AmazonClientException), "not isVirtualHostableS3Bucket")]
        public void Bucketname_not_isVirtualHostable_invalid_label_starts_with_a_b17121e68f0d41b4b81941eab23f6e47_Test()
        {
            var parameters = new Ep2s3hostlabelEndpointParameters();
            parameters["BucketName"] = "bucket.-name";
            var endpoint = new AmazonEp2s3hostlabelEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}