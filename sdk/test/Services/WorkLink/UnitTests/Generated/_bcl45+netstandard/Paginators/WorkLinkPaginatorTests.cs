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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
 */

using Amazon.WorkLink;
using Amazon.WorkLink.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class WorkLinkPaginatorTests
    {
        private static Mock<AmazonWorkLinkClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonWorkLinkClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkLink")]
        public void ListDevicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDevicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDevicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDevicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDevices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDevices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkLink")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDevicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDevicesRequest>();

            var response = InstantiateClassGenerator.Execute<ListDevicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDevices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDevices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkLink")]
        public void ListDomainsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDomainsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDomainsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDomainsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDomains(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDomains(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkLink")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDomainsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDomainsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDomainsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDomains(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDomains(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkLink")]
        public void ListFleetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFleetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFleetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFleetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFleets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFleets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkLink")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFleetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFleetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListFleetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFleets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFleets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkLink")]
        public void ListWebsiteAuthorizationProvidersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWebsiteAuthorizationProvidersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWebsiteAuthorizationProvidersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWebsiteAuthorizationProvidersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWebsiteAuthorizationProviders(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWebsiteAuthorizationProviders(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkLink")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWebsiteAuthorizationProvidersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWebsiteAuthorizationProvidersRequest>();

            var response = InstantiateClassGenerator.Execute<ListWebsiteAuthorizationProvidersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWebsiteAuthorizationProviders(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWebsiteAuthorizationProviders(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkLink")]
        public void ListWebsiteCertificateAuthoritiesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWebsiteCertificateAuthoritiesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWebsiteCertificateAuthoritiesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWebsiteCertificateAuthoritiesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWebsiteCertificateAuthorities(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWebsiteCertificateAuthorities(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkLink")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWebsiteCertificateAuthoritiesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWebsiteCertificateAuthoritiesRequest>();

            var response = InstantiateClassGenerator.Execute<ListWebsiteCertificateAuthoritiesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWebsiteCertificateAuthorities(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWebsiteCertificateAuthorities(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif