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
 * Do not modify this file. This file is generated from the migration-hub-refactor-spaces-2021-10-26.normal.json service model.
 */

using Amazon.MigrationHubRefactorSpaces;
using Amazon.MigrationHubRefactorSpaces.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class MigrationHubRefactorSpacesPaginatorTests
    {
        private static Mock<AmazonMigrationHubRefactorSpacesClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonMigrationHubRefactorSpacesClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHubRefactorSpaces")]
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
        [TestCategory("MigrationHubRefactorSpaces")]
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
        [TestCategory("MigrationHubRefactorSpaces")]
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
        [TestCategory("MigrationHubRefactorSpaces")]
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
        [TestCategory("MigrationHubRefactorSpaces")]
        public void ListEnvironmentVpcsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEnvironmentVpcsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEnvironmentVpcsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEnvironmentVpcsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEnvironmentVpcs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEnvironmentVpcs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHubRefactorSpaces")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEnvironmentVpcsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEnvironmentVpcsRequest>();

            var response = InstantiateClassGenerator.Execute<ListEnvironmentVpcsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEnvironmentVpcs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEnvironmentVpcs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHubRefactorSpaces")]
        public void ListRoutesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRoutesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRoutesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRoutesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRoutes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRoutes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHubRefactorSpaces")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRoutesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRoutesRequest>();

            var response = InstantiateClassGenerator.Execute<ListRoutesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRoutes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRoutes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHubRefactorSpaces")]
        public void ListServicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListServices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHubRefactorSpaces")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServicesRequest>();

            var response = InstantiateClassGenerator.Execute<ListServicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListServices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}