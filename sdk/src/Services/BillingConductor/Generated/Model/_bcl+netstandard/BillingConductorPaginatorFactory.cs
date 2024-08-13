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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// Paginators for the BillingConductor service
    ///</summary>
    public class BillingConductorPaginatorFactory : IBillingConductorPaginatorFactory
    {
        private readonly IAmazonBillingConductor client;

        internal BillingConductorPaginatorFactory(IAmazonBillingConductor client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAccountAssociations operation
        ///</summary>
        public IListAccountAssociationsPaginator ListAccountAssociations(ListAccountAssociationsRequest request) 
        {
            return new ListAccountAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBillingGroupCostReports operation
        ///</summary>
        public IListBillingGroupCostReportsPaginator ListBillingGroupCostReports(ListBillingGroupCostReportsRequest request) 
        {
            return new ListBillingGroupCostReportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBillingGroups operation
        ///</summary>
        public IListBillingGroupsPaginator ListBillingGroups(ListBillingGroupsRequest request) 
        {
            return new ListBillingGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCustomLineItems operation
        ///</summary>
        public IListCustomLineItemsPaginator ListCustomLineItems(ListCustomLineItemsRequest request) 
        {
            return new ListCustomLineItemsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCustomLineItemVersions operation
        ///</summary>
        public IListCustomLineItemVersionsPaginator ListCustomLineItemVersions(ListCustomLineItemVersionsRequest request) 
        {
            return new ListCustomLineItemVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPricingPlans operation
        ///</summary>
        public IListPricingPlansPaginator ListPricingPlans(ListPricingPlansRequest request) 
        {
            return new ListPricingPlansPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPricingPlansAssociatedWithPricingRule operation
        ///</summary>
        public IListPricingPlansAssociatedWithPricingRulePaginator ListPricingPlansAssociatedWithPricingRule(ListPricingPlansAssociatedWithPricingRuleRequest request) 
        {
            return new ListPricingPlansAssociatedWithPricingRulePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPricingRules operation
        ///</summary>
        public IListPricingRulesPaginator ListPricingRules(ListPricingRulesRequest request) 
        {
            return new ListPricingRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPricingRulesAssociatedToPricingPlan operation
        ///</summary>
        public IListPricingRulesAssociatedToPricingPlanPaginator ListPricingRulesAssociatedToPricingPlan(ListPricingRulesAssociatedToPricingPlanRequest request) 
        {
            return new ListPricingRulesAssociatedToPricingPlanPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourcesAssociatedToCustomLineItem operation
        ///</summary>
        public IListResourcesAssociatedToCustomLineItemPaginator ListResourcesAssociatedToCustomLineItem(ListResourcesAssociatedToCustomLineItemRequest request) 
        {
            return new ListResourcesAssociatedToCustomLineItemPaginator(this.client, request);
        }
    }
}