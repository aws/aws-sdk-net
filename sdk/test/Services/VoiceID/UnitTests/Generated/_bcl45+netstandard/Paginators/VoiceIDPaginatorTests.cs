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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
 */

using Amazon.VoiceID;
using Amazon.VoiceID.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class VoiceIDPaginatorTests
    {
        private static Mock<AmazonVoiceIDClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonVoiceIDClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("VoiceID")]
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
        [TestCategory("VoiceID")]
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
        [TestCategory("VoiceID")]
        public void ListFraudsterRegistrationJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFraudsterRegistrationJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFraudsterRegistrationJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFraudsterRegistrationJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFraudsterRegistrationJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFraudsterRegistrationJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("VoiceID")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFraudsterRegistrationJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFraudsterRegistrationJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListFraudsterRegistrationJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFraudsterRegistrationJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFraudsterRegistrationJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("VoiceID")]
        public void ListSpeakerEnrollmentJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSpeakerEnrollmentJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSpeakerEnrollmentJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSpeakerEnrollmentJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSpeakerEnrollmentJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSpeakerEnrollmentJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("VoiceID")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSpeakerEnrollmentJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSpeakerEnrollmentJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSpeakerEnrollmentJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSpeakerEnrollmentJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSpeakerEnrollmentJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("VoiceID")]
        public void ListSpeakersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSpeakersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSpeakersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSpeakersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSpeakers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSpeakers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("VoiceID")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSpeakersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSpeakersRequest>();

            var response = InstantiateClassGenerator.Execute<ListSpeakersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSpeakers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSpeakers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}