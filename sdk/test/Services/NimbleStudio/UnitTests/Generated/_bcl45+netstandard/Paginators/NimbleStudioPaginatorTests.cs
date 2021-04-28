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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */

using Amazon.NimbleStudio;
using Amazon.NimbleStudio.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class NimbleStudioPaginatorTests
    {
        private static Mock<AmazonNimbleStudioClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonNimbleStudioClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NimbleStudio")]
        public void ListEulaAcceptancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEulaAcceptancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEulaAcceptancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEulaAcceptancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEulaAcceptances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEulaAcceptances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NimbleStudio")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEulaAcceptancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEulaAcceptancesRequest>();

            var response = InstantiateClassGenerator.Execute<ListEulaAcceptancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEulaAcceptances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEulaAcceptances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NimbleStudio")]
        public void ListEulasTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEulasRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEulasResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEulasResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEulas(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEulas(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NimbleStudio")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEulasTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEulasRequest>();

            var response = InstantiateClassGenerator.Execute<ListEulasResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEulas(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEulas(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NimbleStudio")]
        public void ListLaunchProfileMembersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLaunchProfileMembersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLaunchProfileMembersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLaunchProfileMembersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListLaunchProfileMembers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLaunchProfileMembers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NimbleStudio")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLaunchProfileMembersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLaunchProfileMembersRequest>();

            var response = InstantiateClassGenerator.Execute<ListLaunchProfileMembersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListLaunchProfileMembers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLaunchProfileMembers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NimbleStudio")]
        public void ListLaunchProfilesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLaunchProfilesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLaunchProfilesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLaunchProfilesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListLaunchProfiles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLaunchProfiles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NimbleStudio")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLaunchProfilesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLaunchProfilesRequest>();

            var response = InstantiateClassGenerator.Execute<ListLaunchProfilesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListLaunchProfiles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLaunchProfiles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NimbleStudio")]
        public void ListStreamingImagesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStreamingImagesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStreamingImagesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStreamingImagesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStreamingImages(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStreamingImages(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NimbleStudio")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStreamingImagesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStreamingImagesRequest>();

            var response = InstantiateClassGenerator.Execute<ListStreamingImagesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStreamingImages(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStreamingImages(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NimbleStudio")]
        public void ListStreamingSessionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStreamingSessionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStreamingSessionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStreamingSessionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStreamingSessions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStreamingSessions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NimbleStudio")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStreamingSessionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStreamingSessionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListStreamingSessionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStreamingSessions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStreamingSessions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NimbleStudio")]
        public void ListStudioComponentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStudioComponentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStudioComponentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStudioComponentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStudioComponents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStudioComponents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NimbleStudio")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStudioComponentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStudioComponentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListStudioComponentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStudioComponents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStudioComponents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NimbleStudio")]
        public void ListStudioMembersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStudioMembersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStudioMembersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStudioMembersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStudioMembers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStudioMembers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NimbleStudio")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStudioMembersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStudioMembersRequest>();

            var response = InstantiateClassGenerator.Execute<ListStudioMembersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStudioMembers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStudioMembers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NimbleStudio")]
        public void ListStudiosTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStudiosRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStudiosResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStudiosResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStudios(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStudios(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NimbleStudio")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStudiosTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStudiosRequest>();

            var response = InstantiateClassGenerator.Execute<ListStudiosResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStudios(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStudios(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}