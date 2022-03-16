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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */

using Amazon.BillingConductor;
using Amazon.BillingConductor.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class BillingConductorPaginatorTests
    {
        private static Mock<AmazonBillingConductorClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonBillingConductorClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BillingConductor")]
        public void ListAccountAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAccountAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAccountAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAccountAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccountAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BillingConductor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAccountAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAccountAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAccountAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccountAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BillingConductor")]
        public void ListBillingGroupCostReportsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBillingGroupCostReportsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBillingGroupCostReportsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBillingGroupCostReportsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBillingGroupCostReports(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBillingGroupCostReports(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BillingConductor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBillingGroupCostReportsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBillingGroupCostReportsRequest>();

            var response = InstantiateClassGenerator.Execute<ListBillingGroupCostReportsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBillingGroupCostReports(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBillingGroupCostReports(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BillingConductor")]
        public void ListBillingGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBillingGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBillingGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBillingGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBillingGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBillingGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BillingConductor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBillingGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBillingGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListBillingGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBillingGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBillingGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BillingConductor")]
        public void ListCustomLineItemsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomLineItemsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCustomLineItemsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCustomLineItemsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCustomLineItems(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCustomLineItems(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BillingConductor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCustomLineItemsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomLineItemsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCustomLineItemsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCustomLineItems(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCustomLineItems(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BillingConductor")]
        public void ListPricingPlansTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPricingPlansRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPricingPlansResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPricingPlansResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPricingPlans(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPricingPlans(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BillingConductor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPricingPlansTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPricingPlansRequest>();

            var response = InstantiateClassGenerator.Execute<ListPricingPlansResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPricingPlans(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPricingPlans(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BillingConductor")]
        public void ListPricingPlansAssociatedWithPricingRuleTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPricingPlansAssociatedWithPricingRuleRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPricingPlansAssociatedWithPricingRuleResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPricingPlansAssociatedWithPricingRuleResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPricingPlansAssociatedWithPricingRule(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPricingPlansAssociatedWithPricingRule(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BillingConductor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPricingPlansAssociatedWithPricingRuleTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPricingPlansAssociatedWithPricingRuleRequest>();

            var response = InstantiateClassGenerator.Execute<ListPricingPlansAssociatedWithPricingRuleResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPricingPlansAssociatedWithPricingRule(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPricingPlansAssociatedWithPricingRule(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BillingConductor")]
        public void ListPricingRulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPricingRulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPricingRulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPricingRulesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPricingRules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPricingRules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BillingConductor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPricingRulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPricingRulesRequest>();

            var response = InstantiateClassGenerator.Execute<ListPricingRulesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPricingRules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPricingRules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BillingConductor")]
        public void ListPricingRulesAssociatedToPricingPlanTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPricingRulesAssociatedToPricingPlanRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPricingRulesAssociatedToPricingPlanResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPricingRulesAssociatedToPricingPlanResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPricingRulesAssociatedToPricingPlan(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPricingRulesAssociatedToPricingPlan(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BillingConductor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPricingRulesAssociatedToPricingPlanTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPricingRulesAssociatedToPricingPlanRequest>();

            var response = InstantiateClassGenerator.Execute<ListPricingRulesAssociatedToPricingPlanResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPricingRulesAssociatedToPricingPlan(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPricingRulesAssociatedToPricingPlan(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BillingConductor")]
        public void ListResourcesAssociatedToCustomLineItemTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResourcesAssociatedToCustomLineItemRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResourcesAssociatedToCustomLineItemResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResourcesAssociatedToCustomLineItemResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResourcesAssociatedToCustomLineItem(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResourcesAssociatedToCustomLineItem(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BillingConductor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResourcesAssociatedToCustomLineItemTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResourcesAssociatedToCustomLineItemRequest>();

            var response = InstantiateClassGenerator.Execute<ListResourcesAssociatedToCustomLineItemResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResourcesAssociatedToCustomLineItem(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResourcesAssociatedToCustomLineItem(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}