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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */

using Amazon.Inspector;
using Amazon.Inspector.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class InspectorPaginatorTests
    {
        private static Mock<AmazonInspectorClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonInspectorClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        public void GetExclusionsPreviewTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetExclusionsPreviewRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetExclusionsPreviewResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetExclusionsPreviewResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetExclusionsPreview(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetExclusionsPreview(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetExclusionsPreviewTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetExclusionsPreviewRequest>();

            var response = InstantiateClassGenerator.Execute<GetExclusionsPreviewResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetExclusionsPreview(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetExclusionsPreview(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        public void ListAssessmentRunAgentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssessmentRunAgentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssessmentRunAgentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssessmentRunAgentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssessmentRunAgents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssessmentRunAgents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssessmentRunAgentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssessmentRunAgentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssessmentRunAgentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssessmentRunAgents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssessmentRunAgents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        public void ListAssessmentRunsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssessmentRunsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssessmentRunsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssessmentRunsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssessmentRuns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssessmentRuns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssessmentRunsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssessmentRunsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssessmentRunsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssessmentRuns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssessmentRuns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        public void ListAssessmentTargetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssessmentTargetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssessmentTargetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssessmentTargetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssessmentTargets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssessmentTargets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssessmentTargetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssessmentTargetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssessmentTargetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssessmentTargets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssessmentTargets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        public void ListAssessmentTemplatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssessmentTemplatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssessmentTemplatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssessmentTemplatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssessmentTemplates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssessmentTemplates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssessmentTemplatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssessmentTemplatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssessmentTemplatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssessmentTemplates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssessmentTemplates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        public void ListEventSubscriptionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEventSubscriptionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEventSubscriptionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEventSubscriptionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEventSubscriptions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEventSubscriptions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEventSubscriptionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEventSubscriptionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListEventSubscriptionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEventSubscriptions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEventSubscriptions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        public void ListExclusionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListExclusionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListExclusionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListExclusionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListExclusions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListExclusions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListExclusionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListExclusionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListExclusionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListExclusions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListExclusions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        public void ListFindingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFindingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFindingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFindingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFindings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFindings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFindingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFindingsRequest>();

            var response = InstantiateClassGenerator.Execute<ListFindingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFindings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFindings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        public void ListRulesPackagesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRulesPackagesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRulesPackagesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRulesPackagesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRulesPackages(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRulesPackages(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRulesPackagesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRulesPackagesRequest>();

            var response = InstantiateClassGenerator.Execute<ListRulesPackagesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRulesPackages(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRulesPackages(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        public void PreviewAgentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<PreviewAgentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<PreviewAgentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<PreviewAgentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.PreviewAgents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.PreviewAgents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Inspector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void PreviewAgentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<PreviewAgentsRequest>();

            var response = InstantiateClassGenerator.Execute<PreviewAgentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.PreviewAgents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.PreviewAgents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif