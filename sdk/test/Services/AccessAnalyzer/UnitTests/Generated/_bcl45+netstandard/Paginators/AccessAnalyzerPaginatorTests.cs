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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */

using Amazon.AccessAnalyzer;
using Amazon.AccessAnalyzer.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class AccessAnalyzerPaginatorTests
    {
        private static Mock<AmazonAccessAnalyzerClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonAccessAnalyzerClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AccessAnalyzer")]
        public void ListAccessPreviewFindingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAccessPreviewFindingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAccessPreviewFindingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAccessPreviewFindingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAccessPreviewFindings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccessPreviewFindings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AccessAnalyzer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAccessPreviewFindingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAccessPreviewFindingsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAccessPreviewFindingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAccessPreviewFindings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccessPreviewFindings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AccessAnalyzer")]
        public void ListAccessPreviewsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAccessPreviewsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAccessPreviewsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAccessPreviewsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAccessPreviews(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccessPreviews(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AccessAnalyzer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAccessPreviewsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAccessPreviewsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAccessPreviewsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAccessPreviews(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccessPreviews(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AccessAnalyzer")]
        public void ListAnalyzedResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAnalyzedResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAnalyzedResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAnalyzedResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAnalyzedResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAnalyzedResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AccessAnalyzer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAnalyzedResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAnalyzedResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAnalyzedResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAnalyzedResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAnalyzedResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AccessAnalyzer")]
        public void ListAnalyzersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAnalyzersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAnalyzersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAnalyzersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAnalyzers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAnalyzers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AccessAnalyzer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAnalyzersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAnalyzersRequest>();

            var response = InstantiateClassGenerator.Execute<ListAnalyzersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAnalyzers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAnalyzers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AccessAnalyzer")]
        public void ListArchiveRulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListArchiveRulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListArchiveRulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListArchiveRulesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListArchiveRules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListArchiveRules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AccessAnalyzer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListArchiveRulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListArchiveRulesRequest>();

            var response = InstantiateClassGenerator.Execute<ListArchiveRulesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListArchiveRules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListArchiveRules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AccessAnalyzer")]
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
        [TestCategory("AccessAnalyzer")]
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
        [TestCategory("AccessAnalyzer")]
        public void ListPolicyGenerationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPolicyGenerationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPolicyGenerationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPolicyGenerationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPolicyGenerations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPolicyGenerations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AccessAnalyzer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPolicyGenerationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPolicyGenerationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPolicyGenerationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPolicyGenerations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPolicyGenerations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AccessAnalyzer")]
        public void ValidatePolicyTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ValidatePolicyRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ValidatePolicyResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ValidatePolicyResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ValidatePolicy(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ValidatePolicy(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AccessAnalyzer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ValidatePolicyTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ValidatePolicyRequest>();

            var response = InstantiateClassGenerator.Execute<ValidatePolicyResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ValidatePolicy(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ValidatePolicy(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}