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
 * Do not modify this file. This file is generated from the cur-2017-01-06.normal.json service model.
 */

using Amazon.CostAndUsageReport;
using Amazon.CostAndUsageReport.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CostAndUsageReportPaginatorTests
    {
        private static Mock<AmazonCostAndUsageReportClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCostAndUsageReportClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CostAndUsageReport")]
        public void DescribeReportDefinitionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReportDefinitionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReportDefinitionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReportDefinitionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeReportDefinitions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReportDefinitions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CostAndUsageReport")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReportDefinitionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReportDefinitionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReportDefinitionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeReportDefinitions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReportDefinitions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif