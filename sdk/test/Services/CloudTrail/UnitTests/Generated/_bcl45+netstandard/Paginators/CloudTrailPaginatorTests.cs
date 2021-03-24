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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */

using Amazon.CloudTrail;
using Amazon.CloudTrail.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CloudTrailPaginatorTests
    {
        private static Mock<AmazonCloudTrailClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCloudTrailClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudTrail")]
        public void ListPublicKeysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPublicKeysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPublicKeysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPublicKeysResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPublicKeys(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPublicKeys(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudTrail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPublicKeysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPublicKeysRequest>();

            var response = InstantiateClassGenerator.Execute<ListPublicKeysResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPublicKeys(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPublicKeys(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudTrail")]
        public void ListTagsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTagsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTagsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTags(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTags(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudTrail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTagsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTagsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTags(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTags(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudTrail")]
        public void ListTrailsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTrailsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTrailsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTrailsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTrails(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTrails(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudTrail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTrailsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTrailsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTrailsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTrails(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTrails(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudTrail")]
        public void LookupEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<LookupEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<LookupEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<LookupEventsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.LookupEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.LookupEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudTrail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void LookupEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<LookupEventsRequest>();

            var response = InstantiateClassGenerator.Execute<LookupEventsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.LookupEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.LookupEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}