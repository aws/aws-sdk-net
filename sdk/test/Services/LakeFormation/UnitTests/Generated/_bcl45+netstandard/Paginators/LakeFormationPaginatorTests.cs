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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */

using Amazon.LakeFormation;
using Amazon.LakeFormation.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class LakeFormationPaginatorTests
    {
        private static Mock<AmazonLakeFormationClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonLakeFormationClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        public void GetEffectivePermissionsForPathTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetEffectivePermissionsForPathRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetEffectivePermissionsForPathResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetEffectivePermissionsForPathResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetEffectivePermissionsForPath(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetEffectivePermissionsForPath(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetEffectivePermissionsForPathTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetEffectivePermissionsForPathRequest>();

            var response = InstantiateClassGenerator.Execute<GetEffectivePermissionsForPathResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetEffectivePermissionsForPath(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetEffectivePermissionsForPath(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        public void GetTableObjectsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetTableObjectsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetTableObjectsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetTableObjectsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetTableObjects(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetTableObjects(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetTableObjectsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetTableObjectsRequest>();

            var response = InstantiateClassGenerator.Execute<GetTableObjectsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetTableObjects(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetTableObjects(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        public void GetWorkUnitsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetWorkUnitsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetWorkUnitsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetWorkUnitsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetWorkUnits(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetWorkUnits(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetWorkUnitsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetWorkUnitsRequest>();

            var response = InstantiateClassGenerator.Execute<GetWorkUnitsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetWorkUnits(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetWorkUnits(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        public void ListDataCellsFilterTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDataCellsFilterRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDataCellsFilterResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDataCellsFilterResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDataCellsFilter(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDataCellsFilter(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDataCellsFilterTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDataCellsFilterRequest>();

            var response = InstantiateClassGenerator.Execute<ListDataCellsFilterResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDataCellsFilter(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDataCellsFilter(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        public void ListLFTagsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLFTagsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLFTagsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLFTagsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListLFTags(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLFTags(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLFTagsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLFTagsRequest>();

            var response = InstantiateClassGenerator.Execute<ListLFTagsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListLFTags(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLFTags(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        public void ListPermissionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPermissionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPermissionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPermissionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPermissions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPermissions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPermissionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPermissionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPermissionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPermissions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPermissions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        public void ListResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        public void ListTableStorageOptimizersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTableStorageOptimizersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTableStorageOptimizersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTableStorageOptimizersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTableStorageOptimizers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTableStorageOptimizers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTableStorageOptimizersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTableStorageOptimizersRequest>();

            var response = InstantiateClassGenerator.Execute<ListTableStorageOptimizersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTableStorageOptimizers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTableStorageOptimizers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        public void ListTransactionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTransactionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTransactionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTransactionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTransactions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTransactions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTransactionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTransactionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTransactionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTransactions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTransactions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        public void SearchDatabasesByLFTagsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchDatabasesByLFTagsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchDatabasesByLFTagsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchDatabasesByLFTagsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchDatabasesByLFTags(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchDatabasesByLFTags(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchDatabasesByLFTagsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchDatabasesByLFTagsRequest>();

            var response = InstantiateClassGenerator.Execute<SearchDatabasesByLFTagsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchDatabasesByLFTags(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchDatabasesByLFTags(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        public void SearchTablesByLFTagsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchTablesByLFTagsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchTablesByLFTagsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchTablesByLFTagsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchTablesByLFTags(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchTablesByLFTags(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LakeFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchTablesByLFTagsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchTablesByLFTagsRequest>();

            var response = InstantiateClassGenerator.Execute<SearchTablesByLFTagsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchTablesByLFTags(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchTablesByLFTags(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}