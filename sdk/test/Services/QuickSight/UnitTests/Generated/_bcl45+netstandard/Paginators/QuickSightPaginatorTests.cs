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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */

using Amazon.QuickSight;
using Amazon.QuickSight.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class QuickSightPaginatorTests
    {
        private static Mock<AmazonQuickSightClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonQuickSightClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        public void ListAnalysesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAnalysesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAnalysesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAnalysesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAnalyses(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAnalyses(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAnalysesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAnalysesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAnalysesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAnalyses(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAnalyses(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        public void ListDashboardsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDashboardsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDashboardsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDashboardsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDashboards(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDashboards(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDashboardsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDashboardsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDashboardsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDashboards(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDashboards(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        public void ListDashboardVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDashboardVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDashboardVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDashboardVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDashboardVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDashboardVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDashboardVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDashboardVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDashboardVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDashboardVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDashboardVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        public void ListDataSetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDataSetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDataSetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDataSetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDataSets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDataSets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDataSetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDataSetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDataSetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDataSets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDataSets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        public void ListDataSourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDataSourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDataSourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDataSourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDataSources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDataSources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDataSourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDataSourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListDataSourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDataSources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDataSources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        public void ListIngestionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListIngestionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListIngestionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListIngestionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListIngestions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListIngestions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListIngestionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListIngestionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListIngestionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListIngestions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListIngestions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        public void ListNamespacesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListNamespacesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListNamespacesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListNamespacesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListNamespaces(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListNamespaces(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListNamespacesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListNamespacesRequest>();

            var response = InstantiateClassGenerator.Execute<ListNamespacesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListNamespaces(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListNamespaces(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        public void ListTemplateAliasesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTemplateAliasesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTemplateAliasesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTemplateAliasesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTemplateAliases(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTemplateAliases(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTemplateAliasesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTemplateAliasesRequest>();

            var response = InstantiateClassGenerator.Execute<ListTemplateAliasesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTemplateAliases(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTemplateAliases(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        public void ListTemplatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTemplatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTemplatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTemplatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTemplates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTemplates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTemplatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTemplatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListTemplatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTemplates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTemplates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        public void ListTemplateVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTemplateVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTemplateVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTemplateVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTemplateVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTemplateVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTemplateVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTemplateVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTemplateVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTemplateVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTemplateVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        public void ListThemesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListThemesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListThemesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListThemesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListThemes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListThemes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListThemesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListThemesRequest>();

            var response = InstantiateClassGenerator.Execute<ListThemesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListThemes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListThemes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        public void ListThemeVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListThemeVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListThemeVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListThemeVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListThemeVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListThemeVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListThemeVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListThemeVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListThemeVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListThemeVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListThemeVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        public void SearchAnalysesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchAnalysesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchAnalysesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchAnalysesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchAnalyses(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchAnalyses(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchAnalysesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchAnalysesRequest>();

            var response = InstantiateClassGenerator.Execute<SearchAnalysesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchAnalyses(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchAnalyses(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        public void SearchDashboardsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchDashboardsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchDashboardsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchDashboardsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchDashboards(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchDashboards(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QuickSight")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchDashboardsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchDashboardsRequest>();

            var response = InstantiateClassGenerator.Execute<SearchDashboardsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchDashboards(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchDashboards(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}