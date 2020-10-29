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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */

using Amazon.SimpleEmailV2;
using Amazon.SimpleEmailV2.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SimpleEmailServiceV2PaginatorTests
    {
        private static Mock<AmazonSimpleEmailServiceV2Client> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSimpleEmailServiceV2Client>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleEmailV2")]
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
        [TestCategory("SimpleEmailV2")]
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
        [TestCategory("SimpleEmailV2")]
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
        [TestCategory("SimpleEmailV2")]
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
        [TestCategory("SimpleEmailV2")]
        public void ListContactListsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListContactListsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListContactListsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListContactListsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListContactLists(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListContactLists(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleEmailV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListContactListsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListContactListsRequest>();

            var response = InstantiateClassGenerator.Execute<ListContactListsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListContactLists(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListContactLists(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleEmailV2")]
        public void ListContactsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListContactsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListContactsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListContactsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListContacts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListContacts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleEmailV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListContactsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListContactsRequest>();

            var response = InstantiateClassGenerator.Execute<ListContactsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListContacts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListContacts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleEmailV2")]
        public void ListCustomVerificationEmailTemplatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomVerificationEmailTemplatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCustomVerificationEmailTemplatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCustomVerificationEmailTemplatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCustomVerificationEmailTemplates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCustomVerificationEmailTemplates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleEmailV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCustomVerificationEmailTemplatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomVerificationEmailTemplatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListCustomVerificationEmailTemplatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCustomVerificationEmailTemplates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCustomVerificationEmailTemplates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleEmailV2")]
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
        [TestCategory("SimpleEmailV2")]
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
        [TestCategory("SimpleEmailV2")]
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
        [TestCategory("SimpleEmailV2")]
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
        [TestCategory("SimpleEmailV2")]
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
        [TestCategory("SimpleEmailV2")]
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
        [TestCategory("SimpleEmailV2")]
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
        [TestCategory("SimpleEmailV2")]
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


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleEmailV2")]
        public void ListEmailTemplatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEmailTemplatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEmailTemplatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEmailTemplatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEmailTemplates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEmailTemplates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleEmailV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEmailTemplatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEmailTemplatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListEmailTemplatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEmailTemplates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEmailTemplates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleEmailV2")]
        public void ListImportJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListImportJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListImportJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListImportJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListImportJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListImportJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleEmailV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListImportJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListImportJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListImportJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListImportJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListImportJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleEmailV2")]
        public void ListSuppressedDestinationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSuppressedDestinationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSuppressedDestinationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSuppressedDestinationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSuppressedDestinations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSuppressedDestinations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleEmailV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSuppressedDestinationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSuppressedDestinationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSuppressedDestinationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSuppressedDestinations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSuppressedDestinations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif