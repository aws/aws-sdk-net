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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */

using Amazon.AppConfig;
using Amazon.AppConfig.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class AppConfigPaginatorTests
    {
        private static Mock<AmazonAppConfigClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonAppConfigClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppConfig")]
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
        [TestCategory("AppConfig")]
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
        [TestCategory("AppConfig")]
        public void ListConfigurationProfilesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListConfigurationProfilesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListConfigurationProfilesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListConfigurationProfilesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListConfigurationProfiles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListConfigurationProfiles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppConfig")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListConfigurationProfilesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListConfigurationProfilesRequest>();

            var response = InstantiateClassGenerator.Execute<ListConfigurationProfilesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListConfigurationProfiles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListConfigurationProfiles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppConfig")]
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
        [TestCategory("AppConfig")]
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


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppConfig")]
        public void ListDeploymentStrategiesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDeploymentStrategiesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDeploymentStrategiesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDeploymentStrategiesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDeploymentStrategies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDeploymentStrategies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppConfig")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDeploymentStrategiesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDeploymentStrategiesRequest>();

            var response = InstantiateClassGenerator.Execute<ListDeploymentStrategiesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDeploymentStrategies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDeploymentStrategies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppConfig")]
        public void ListEnvironmentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEnvironmentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEnvironmentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEnvironmentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEnvironments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEnvironments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppConfig")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEnvironmentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEnvironmentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListEnvironmentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEnvironments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEnvironments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppConfig")]
        public void ListHostedConfigurationVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListHostedConfigurationVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListHostedConfigurationVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListHostedConfigurationVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListHostedConfigurationVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListHostedConfigurationVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppConfig")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListHostedConfigurationVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListHostedConfigurationVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListHostedConfigurationVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListHostedConfigurationVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListHostedConfigurationVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif