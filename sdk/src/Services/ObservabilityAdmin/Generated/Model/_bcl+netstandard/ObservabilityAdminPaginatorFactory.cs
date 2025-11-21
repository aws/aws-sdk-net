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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Paginators for the ObservabilityAdmin service
    ///</summary>
    public class ObservabilityAdminPaginatorFactory : IObservabilityAdminPaginatorFactory
    {
        private readonly IAmazonObservabilityAdmin client;

        internal ObservabilityAdminPaginatorFactory(IAmazonObservabilityAdmin client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCentralizationRulesForOrganization operation
        ///</summary>
        public IListCentralizationRulesForOrganizationPaginator ListCentralizationRulesForOrganization(ListCentralizationRulesForOrganizationRequest request) 
        {
            return new ListCentralizationRulesForOrganizationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceTelemetry operation
        ///</summary>
        public IListResourceTelemetryPaginator ListResourceTelemetry(ListResourceTelemetryRequest request) 
        {
            return new ListResourceTelemetryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceTelemetryForOrganization operation
        ///</summary>
        public IListResourceTelemetryForOrganizationPaginator ListResourceTelemetryForOrganization(ListResourceTelemetryForOrganizationRequest request) 
        {
            return new ListResourceTelemetryForOrganizationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTelemetryRules operation
        ///</summary>
        public IListTelemetryRulesPaginator ListTelemetryRules(ListTelemetryRulesRequest request) 
        {
            return new ListTelemetryRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTelemetryRulesForOrganization operation
        ///</summary>
        public IListTelemetryRulesForOrganizationPaginator ListTelemetryRulesForOrganization(ListTelemetryRulesForOrganizationRequest request) 
        {
            return new ListTelemetryRulesForOrganizationPaginator(this.client, request);
        }
    }
}