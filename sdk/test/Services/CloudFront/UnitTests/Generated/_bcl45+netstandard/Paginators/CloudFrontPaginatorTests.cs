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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */

using Amazon.CloudFront;
using Amazon.CloudFront.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CloudFrontPaginatorTests
    {
        private static Mock<AmazonCloudFrontClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCloudFrontClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFront")]
        public void ListCloudFrontOriginAccessIdentitiesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCloudFrontOriginAccessIdentitiesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCloudFrontOriginAccessIdentitiesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCloudFrontOriginAccessIdentitiesResponse>();
            secondResponse.CloudFrontOriginAccessIdentityList.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListCloudFrontOriginAccessIdentities(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCloudFrontOriginAccessIdentities(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFront")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCloudFrontOriginAccessIdentitiesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCloudFrontOriginAccessIdentitiesRequest>();

            var response = InstantiateClassGenerator.Execute<ListCloudFrontOriginAccessIdentitiesResponse>();
            response.CloudFrontOriginAccessIdentityList.IsTruncated = false;

            _mockClient.Setup(x => x.ListCloudFrontOriginAccessIdentities(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCloudFrontOriginAccessIdentities(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFront")]
        public void ListDistributionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDistributionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDistributionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDistributionsResponse>();
            secondResponse.DistributionList.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListDistributions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDistributions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFront")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDistributionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDistributionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDistributionsResponse>();
            response.DistributionList.IsTruncated = false;

            _mockClient.Setup(x => x.ListDistributions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDistributions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFront")]
        public void ListInvalidationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInvalidationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInvalidationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInvalidationsResponse>();
            secondResponse.InvalidationList.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListInvalidations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInvalidations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFront")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInvalidationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInvalidationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListInvalidationsResponse>();
            response.InvalidationList.IsTruncated = false;

            _mockClient.Setup(x => x.ListInvalidations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInvalidations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFront")]
        public void ListStreamingDistributionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStreamingDistributionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStreamingDistributionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStreamingDistributionsResponse>();
            secondResponse.StreamingDistributionList.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListStreamingDistributions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStreamingDistributions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFront")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStreamingDistributionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStreamingDistributionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListStreamingDistributionsResponse>();
            response.StreamingDistributionList.IsTruncated = false;

            _mockClient.Setup(x => x.ListStreamingDistributions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStreamingDistributions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}