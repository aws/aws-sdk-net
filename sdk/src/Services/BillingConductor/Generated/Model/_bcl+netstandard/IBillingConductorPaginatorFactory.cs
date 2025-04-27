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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// Paginators for the BillingConductor service
    ///</summary>
    public interface IBillingConductorPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAccountAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListAccountAssociationsPaginator ListAccountAssociations(ListAccountAssociationsRequest request);

        /// <summary>
        /// Paginator for ListBillingGroupCostReports operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBillingGroupCostReportsPaginator ListBillingGroupCostReports(ListBillingGroupCostReportsRequest request);

        /// <summary>
        /// Paginator for ListBillingGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBillingGroupsPaginator ListBillingGroups(ListBillingGroupsRequest request);

        /// <summary>
        /// Paginator for ListCustomLineItems operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCustomLineItemsPaginator ListCustomLineItems(ListCustomLineItemsRequest request);

        /// <summary>
        /// Paginator for ListCustomLineItemVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCustomLineItemVersionsPaginator ListCustomLineItemVersions(ListCustomLineItemVersionsRequest request);

        /// <summary>
        /// Paginator for ListPricingPlans operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPricingPlansPaginator ListPricingPlans(ListPricingPlansRequest request);

        /// <summary>
        /// Paginator for ListPricingPlansAssociatedWithPricingRule operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPricingPlansAssociatedWithPricingRulePaginator ListPricingPlansAssociatedWithPricingRule(ListPricingPlansAssociatedWithPricingRuleRequest request);

        /// <summary>
        /// Paginator for ListPricingRules operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPricingRulesPaginator ListPricingRules(ListPricingRulesRequest request);

        /// <summary>
        /// Paginator for ListPricingRulesAssociatedToPricingPlan operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPricingRulesAssociatedToPricingPlanPaginator ListPricingRulesAssociatedToPricingPlan(ListPricingRulesAssociatedToPricingPlanRequest request);

        /// <summary>
        /// Paginator for ListResourcesAssociatedToCustomLineItem operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResourcesAssociatedToCustomLineItemPaginator ListResourcesAssociatedToCustomLineItem(ListResourcesAssociatedToCustomLineItemRequest request);
    }
}