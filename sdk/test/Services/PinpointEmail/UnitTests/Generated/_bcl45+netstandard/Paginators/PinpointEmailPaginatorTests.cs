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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */

using Amazon.PinpointEmail;
using Amazon.PinpointEmail.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class PinpointEmailPaginatorTests
    {
        private static Mock<AmazonPinpointEmailClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonPinpointEmailClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PinpointEmail")]
        public void GetDedicatedIpsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetDedicatedIpsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetDedicatedIpsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetDedicatedIpsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetDedicatedIps(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetDedicatedIps(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PinpointEmail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetDedicatedIpsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetDedicatedIpsRequest>();

            var response = InstantiateClassGenerator.Execute<GetDedicatedIpsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetDedicatedIps(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetDedicatedIps(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PinpointEmail")]
        public void ListConfigurationSetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListConfigurationSetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListConfigurationSetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListConfigurationSetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListConfigurationSets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListConfigurationSets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PinpointEmail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListConfigurationSetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListConfigurationSetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListConfigurationSetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListConfigurationSets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListConfigurationSets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PinpointEmail")]
        public void ListDedicatedIpPoolsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDedicatedIpPoolsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDedicatedIpPoolsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDedicatedIpPoolsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDedicatedIpPools(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDedicatedIpPools(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PinpointEmail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDedicatedIpPoolsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDedicatedIpPoolsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDedicatedIpPoolsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDedicatedIpPools(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDedicatedIpPools(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PinpointEmail")]
        public void ListDeliverabilityTestReportsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDeliverabilityTestReportsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDeliverabilityTestReportsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDeliverabilityTestReportsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDeliverabilityTestReports(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDeliverabilityTestReports(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PinpointEmail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDeliverabilityTestReportsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDeliverabilityTestReportsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDeliverabilityTestReportsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDeliverabilityTestReports(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDeliverabilityTestReports(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PinpointEmail")]
        public void ListDomainDeliverabilityCampaignsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDomainDeliverabilityCampaignsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDomainDeliverabilityCampaignsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDomainDeliverabilityCampaignsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDomainDeliverabilityCampaigns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDomainDeliverabilityCampaigns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PinpointEmail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDomainDeliverabilityCampaignsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDomainDeliverabilityCampaignsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDomainDeliverabilityCampaignsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDomainDeliverabilityCampaigns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDomainDeliverabilityCampaigns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PinpointEmail")]
        public void ListEmailIdentitiesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEmailIdentitiesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEmailIdentitiesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEmailIdentitiesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEmailIdentities(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEmailIdentities(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PinpointEmail")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEmailIdentitiesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEmailIdentitiesRequest>();

            var response = InstantiateClassGenerator.Execute<ListEmailIdentitiesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEmailIdentities(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEmailIdentities(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif