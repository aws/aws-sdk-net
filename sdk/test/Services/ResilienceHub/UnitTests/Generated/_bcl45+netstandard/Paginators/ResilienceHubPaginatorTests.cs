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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */

using Amazon.ResilienceHub;
using Amazon.ResilienceHub.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ResilienceHubPaginatorTests
    {
        private static Mock<AmazonResilienceHubClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonResilienceHubClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        public void ListAlarmRecommendationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAlarmRecommendationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAlarmRecommendationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAlarmRecommendationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAlarmRecommendations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAlarmRecommendations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAlarmRecommendationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAlarmRecommendationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAlarmRecommendationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAlarmRecommendations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAlarmRecommendations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        public void ListAppAssessmentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAppAssessmentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAppAssessmentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAppAssessmentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAppAssessments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAppAssessments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAppAssessmentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAppAssessmentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAppAssessmentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAppAssessments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAppAssessments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        public void ListAppComponentCompliancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAppComponentCompliancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAppComponentCompliancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAppComponentCompliancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAppComponentCompliances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAppComponentCompliances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAppComponentCompliancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAppComponentCompliancesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAppComponentCompliancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAppComponentCompliances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAppComponentCompliances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        public void ListAppComponentRecommendationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAppComponentRecommendationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAppComponentRecommendationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAppComponentRecommendationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAppComponentRecommendations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAppComponentRecommendations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAppComponentRecommendationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAppComponentRecommendationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAppComponentRecommendationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAppComponentRecommendations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAppComponentRecommendations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        public void ListAppsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAppsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAppsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAppsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListApps(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListApps(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAppsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAppsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAppsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListApps(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListApps(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        public void ListAppVersionResourceMappingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAppVersionResourceMappingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAppVersionResourceMappingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAppVersionResourceMappingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAppVersionResourceMappings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAppVersionResourceMappings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAppVersionResourceMappingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAppVersionResourceMappingsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAppVersionResourceMappingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAppVersionResourceMappings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAppVersionResourceMappings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        public void ListAppVersionResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAppVersionResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAppVersionResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAppVersionResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAppVersionResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAppVersionResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAppVersionResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAppVersionResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAppVersionResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAppVersionResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAppVersionResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        public void ListAppVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAppVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAppVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAppVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAppVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAppVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAppVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAppVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAppVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAppVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAppVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        public void ListRecommendationTemplatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRecommendationTemplatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRecommendationTemplatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRecommendationTemplatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRecommendationTemplates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRecommendationTemplates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRecommendationTemplatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRecommendationTemplatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListRecommendationTemplatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRecommendationTemplates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRecommendationTemplates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        public void ListResiliencyPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResiliencyPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResiliencyPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResiliencyPoliciesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResiliencyPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResiliencyPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResiliencyPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResiliencyPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListResiliencyPoliciesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResiliencyPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResiliencyPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        public void ListSopRecommendationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSopRecommendationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSopRecommendationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSopRecommendationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSopRecommendations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSopRecommendations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSopRecommendationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSopRecommendationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSopRecommendationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSopRecommendations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSopRecommendations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        public void ListSuggestedResiliencyPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSuggestedResiliencyPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSuggestedResiliencyPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSuggestedResiliencyPoliciesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSuggestedResiliencyPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSuggestedResiliencyPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSuggestedResiliencyPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSuggestedResiliencyPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListSuggestedResiliencyPoliciesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSuggestedResiliencyPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSuggestedResiliencyPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        public void ListTestRecommendationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTestRecommendationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTestRecommendationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTestRecommendationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTestRecommendations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTestRecommendations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTestRecommendationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTestRecommendationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTestRecommendationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTestRecommendations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTestRecommendations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        public void ListUnsupportedAppVersionResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUnsupportedAppVersionResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUnsupportedAppVersionResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUnsupportedAppVersionResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListUnsupportedAppVersionResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUnsupportedAppVersionResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResilienceHub")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUnsupportedAppVersionResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUnsupportedAppVersionResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListUnsupportedAppVersionResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListUnsupportedAppVersionResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUnsupportedAppVersionResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}