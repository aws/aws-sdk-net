#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */

using Amazon.CostExplorer;
using Amazon.CostExplorer.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CostExplorerPaginatorTests
    {
        private static Mock<AmazonCostExplorerClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCostExplorerClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CostExplorer")]
        public void GetSavingsPlansCoverageTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetSavingsPlansCoverageRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetSavingsPlansCoverageResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetSavingsPlansCoverageResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetSavingsPlansCoverage(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetSavingsPlansCoverage(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CostExplorer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetSavingsPlansCoverageTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetSavingsPlansCoverageRequest>();

            var response = InstantiateClassGenerator.Execute<GetSavingsPlansCoverageResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetSavingsPlansCoverage(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetSavingsPlansCoverage(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CostExplorer")]
        public void GetSavingsPlansUtilizationDetailsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetSavingsPlansUtilizationDetailsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetSavingsPlansUtilizationDetailsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetSavingsPlansUtilizationDetailsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetSavingsPlansUtilizationDetails(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetSavingsPlansUtilizationDetails(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CostExplorer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetSavingsPlansUtilizationDetailsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetSavingsPlansUtilizationDetailsRequest>();

            var response = InstantiateClassGenerator.Execute<GetSavingsPlansUtilizationDetailsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetSavingsPlansUtilizationDetails(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetSavingsPlansUtilizationDetails(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CostExplorer")]
        public void ListCostCategoryDefinitionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCostCategoryDefinitionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCostCategoryDefinitionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCostCategoryDefinitionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCostCategoryDefinitions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCostCategoryDefinitions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CostExplorer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCostCategoryDefinitionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCostCategoryDefinitionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCostCategoryDefinitionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCostCategoryDefinitions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCostCategoryDefinitions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif