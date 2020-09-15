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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */

using Amazon.Budgets;
using Amazon.Budgets.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class BudgetsPaginatorTests
    {
        private static Mock<AmazonBudgetsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonBudgetsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Budgets")]
        public void DescribeBudgetPerformanceHistoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeBudgetPerformanceHistoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeBudgetPerformanceHistoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeBudgetPerformanceHistoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeBudgetPerformanceHistory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeBudgetPerformanceHistory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Budgets")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeBudgetPerformanceHistoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeBudgetPerformanceHistoryRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeBudgetPerformanceHistoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeBudgetPerformanceHistory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeBudgetPerformanceHistory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Budgets")]
        public void DescribeBudgetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeBudgetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeBudgetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeBudgetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeBudgets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeBudgets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Budgets")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeBudgetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeBudgetsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeBudgetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeBudgets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeBudgets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Budgets")]
        public void DescribeNotificationsForBudgetTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeNotificationsForBudgetRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeNotificationsForBudgetResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeNotificationsForBudgetResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeNotificationsForBudget(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeNotificationsForBudget(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Budgets")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeNotificationsForBudgetTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeNotificationsForBudgetRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeNotificationsForBudgetResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeNotificationsForBudget(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeNotificationsForBudget(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Budgets")]
        public void DescribeSubscribersForNotificationTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSubscribersForNotificationRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeSubscribersForNotificationResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeSubscribersForNotificationResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeSubscribersForNotification(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeSubscribersForNotification(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Budgets")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeSubscribersForNotificationTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSubscribersForNotificationRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeSubscribersForNotificationResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeSubscribersForNotification(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeSubscribersForNotification(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif