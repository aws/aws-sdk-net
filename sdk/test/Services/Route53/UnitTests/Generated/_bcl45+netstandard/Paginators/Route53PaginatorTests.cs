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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */

using Amazon.Route53;
using Amazon.Route53.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class Route53PaginatorTests
    {
        private static Mock<AmazonRoute53Client> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonRoute53Client>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53")]
        public void ListHealthChecksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListHealthChecksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListHealthChecksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListHealthChecksResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListHealthChecks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListHealthChecks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListHealthChecksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListHealthChecksRequest>();

            var response = InstantiateClassGenerator.Execute<ListHealthChecksResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListHealthChecks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListHealthChecks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53")]
        public void ListHostedZonesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListHostedZonesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListHostedZonesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListHostedZonesResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListHostedZones(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListHostedZones(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListHostedZonesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListHostedZonesRequest>();

            var response = InstantiateClassGenerator.Execute<ListHostedZonesResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListHostedZones(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListHostedZones(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53")]
        public void ListQueryLoggingConfigsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListQueryLoggingConfigsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListQueryLoggingConfigsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListQueryLoggingConfigsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListQueryLoggingConfigs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListQueryLoggingConfigs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListQueryLoggingConfigsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListQueryLoggingConfigsRequest>();

            var response = InstantiateClassGenerator.Execute<ListQueryLoggingConfigsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListQueryLoggingConfigs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListQueryLoggingConfigs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53")]
        public void ListResourceRecordSetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResourceRecordSetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResourceRecordSetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResourceRecordSetsResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListResourceRecordSets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResourceRecordSets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResourceRecordSetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResourceRecordSetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListResourceRecordSetsResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListResourceRecordSets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResourceRecordSets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}