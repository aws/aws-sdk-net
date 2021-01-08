#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */

using Amazon.Route53Domains;
using Amazon.Route53Domains.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class Route53DomainsPaginatorTests
    {
        private static Mock<AmazonRoute53DomainsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonRoute53DomainsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Domains")]
        public void ListDomainsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDomainsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDomainsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDomainsResponse>();
            secondResponse.NextPageMarker = null;

            _mockClient.SetupSequence(x => x.ListDomains(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDomains(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Domains")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDomainsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDomainsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDomainsResponse>();
            response.NextPageMarker = null;

            _mockClient.Setup(x => x.ListDomains(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDomains(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Domains")]
        public void ListOperationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOperationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOperationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOperationsResponse>();
            secondResponse.NextPageMarker = null;

            _mockClient.SetupSequence(x => x.ListOperations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOperations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Domains")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOperationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOperationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListOperationsResponse>();
            response.NextPageMarker = null;

            _mockClient.Setup(x => x.ListOperations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOperations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif