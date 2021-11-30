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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
 */

using Amazon.CloudWatchEvidently;
using Amazon.CloudWatchEvidently.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CloudWatchEvidentlyPaginatorTests
    {
        private static Mock<AmazonCloudWatchEvidentlyClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCloudWatchEvidentlyClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchEvidently")]
        public void ListExperimentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListExperimentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListExperimentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListExperimentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListExperiments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListExperiments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchEvidently")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListExperimentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListExperimentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListExperimentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListExperiments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListExperiments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchEvidently")]
        public void ListFeaturesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFeaturesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFeaturesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFeaturesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFeatures(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFeatures(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchEvidently")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFeaturesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFeaturesRequest>();

            var response = InstantiateClassGenerator.Execute<ListFeaturesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFeatures(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFeatures(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchEvidently")]
        public void ListLaunchesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLaunchesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLaunchesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLaunchesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListLaunches(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLaunches(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchEvidently")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLaunchesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLaunchesRequest>();

            var response = InstantiateClassGenerator.Execute<ListLaunchesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListLaunches(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLaunches(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchEvidently")]
        public void ListProjectsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProjectsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProjectsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProjectsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProjects(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProjects(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchEvidently")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProjectsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProjectsRequest>();

            var response = InstantiateClassGenerator.Execute<ListProjectsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProjects(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProjects(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}