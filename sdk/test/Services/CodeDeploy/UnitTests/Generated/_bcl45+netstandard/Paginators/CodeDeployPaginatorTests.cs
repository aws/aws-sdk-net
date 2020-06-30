#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */

using Amazon.CodeDeploy;
using Amazon.CodeDeploy.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CodeDeployPaginatorTests
    {
        private static Mock<AmazonCodeDeployClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCodeDeployClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeDeploy")]
        public void ListApplicationRevisionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationRevisionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListApplicationRevisionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListApplicationRevisionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListApplicationRevisions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListApplicationRevisions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeDeploy")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListApplicationRevisionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationRevisionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListApplicationRevisionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListApplicationRevisions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListApplicationRevisions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeDeploy")]
        public void ListApplicationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListApplicationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListApplicationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListApplications(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListApplications(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeDeploy")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListApplicationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListApplicationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListApplications(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListApplications(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeDeploy")]
        public void ListDeploymentConfigsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDeploymentConfigsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDeploymentConfigsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDeploymentConfigsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDeploymentConfigs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDeploymentConfigs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeDeploy")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDeploymentConfigsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDeploymentConfigsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDeploymentConfigsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDeploymentConfigs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDeploymentConfigs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeDeploy")]
        public void ListDeploymentGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDeploymentGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDeploymentGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDeploymentGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDeploymentGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDeploymentGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeDeploy")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDeploymentGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDeploymentGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDeploymentGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDeploymentGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDeploymentGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeDeploy")]
        public void ListDeploymentInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDeploymentInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDeploymentInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDeploymentInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDeploymentInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDeploymentInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeDeploy")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDeploymentInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDeploymentInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<ListDeploymentInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDeploymentInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDeploymentInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeDeploy")]
        public void ListDeploymentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDeploymentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDeploymentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDeploymentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDeployments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDeployments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeDeploy")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDeploymentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDeploymentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDeploymentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDeployments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDeployments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif