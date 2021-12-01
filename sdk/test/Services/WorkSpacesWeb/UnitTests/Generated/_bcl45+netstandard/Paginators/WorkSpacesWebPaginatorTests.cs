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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */

using Amazon.WorkSpacesWeb;
using Amazon.WorkSpacesWeb.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class WorkSpacesWebPaginatorTests
    {
        private static Mock<AmazonWorkSpacesWebClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonWorkSpacesWebClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpacesWeb")]
        public void ListBrowserSettingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBrowserSettingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBrowserSettingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBrowserSettingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBrowserSettings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBrowserSettings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpacesWeb")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBrowserSettingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBrowserSettingsRequest>();

            var response = InstantiateClassGenerator.Execute<ListBrowserSettingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBrowserSettings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBrowserSettings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpacesWeb")]
        public void ListIdentityProvidersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListIdentityProvidersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListIdentityProvidersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListIdentityProvidersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListIdentityProviders(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListIdentityProviders(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpacesWeb")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListIdentityProvidersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListIdentityProvidersRequest>();

            var response = InstantiateClassGenerator.Execute<ListIdentityProvidersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListIdentityProviders(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListIdentityProviders(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpacesWeb")]
        public void ListNetworkSettingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListNetworkSettingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListNetworkSettingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListNetworkSettingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListNetworkSettings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListNetworkSettings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpacesWeb")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListNetworkSettingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListNetworkSettingsRequest>();

            var response = InstantiateClassGenerator.Execute<ListNetworkSettingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListNetworkSettings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListNetworkSettings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpacesWeb")]
        public void ListPortalsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPortalsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPortalsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPortalsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPortals(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPortals(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpacesWeb")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPortalsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPortalsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPortalsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPortals(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPortals(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpacesWeb")]
        public void ListTrustStoreCertificatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTrustStoreCertificatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTrustStoreCertificatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTrustStoreCertificatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTrustStoreCertificates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTrustStoreCertificates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpacesWeb")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTrustStoreCertificatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTrustStoreCertificatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListTrustStoreCertificatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTrustStoreCertificates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTrustStoreCertificates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpacesWeb")]
        public void ListTrustStoresTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTrustStoresRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTrustStoresResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTrustStoresResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTrustStores(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTrustStores(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpacesWeb")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTrustStoresTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTrustStoresRequest>();

            var response = InstantiateClassGenerator.Execute<ListTrustStoresResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTrustStores(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTrustStores(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpacesWeb")]
        public void ListUserSettingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUserSettingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUserSettingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUserSettingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListUserSettings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUserSettings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpacesWeb")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUserSettingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUserSettingsRequest>();

            var response = InstantiateClassGenerator.Execute<ListUserSettingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListUserSettings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUserSettings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}