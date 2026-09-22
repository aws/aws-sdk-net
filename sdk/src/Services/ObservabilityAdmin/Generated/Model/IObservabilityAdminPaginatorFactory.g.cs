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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Paginators for the ObservabilityAdmin service
    /// </summary>
    public interface IObservabilityAdminPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListCentralizationRulesForOrganization operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCentralizationRulesForOrganizationPaginator ListCentralizationRulesForOrganization(ListCentralizationRulesForOrganizationRequest request);

        /// <summary>
        /// Paginator for ListDatasetIntegrations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDatasetIntegrationsPaginator ListDatasetIntegrations(ListDatasetIntegrationsRequest request);

        /// <summary>
        /// Paginator for ListResourceTelemetry operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListResourceTelemetryPaginator ListResourceTelemetry(ListResourceTelemetryRequest request);

        /// <summary>
        /// Paginator for ListResourceTelemetryForOrganization operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListResourceTelemetryForOrganizationPaginator ListResourceTelemetryForOrganization(ListResourceTelemetryForOrganizationRequest request);

        /// <summary>
        /// Paginator for ListS3TableIntegrations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListS3TableIntegrationsPaginator ListS3TableIntegrations(ListS3TableIntegrationsRequest request);

        /// <summary>
        /// Paginator for ListTelemetryPipelines operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTelemetryPipelinesPaginator ListTelemetryPipelines(ListTelemetryPipelinesRequest request);

        /// <summary>
        /// Paginator for ListTelemetryRules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTelemetryRulesPaginator ListTelemetryRules(ListTelemetryRulesRequest request);

        /// <summary>
        /// Paginator for ListTelemetryRulesForOrganization operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTelemetryRulesForOrganizationPaginator ListTelemetryRulesForOrganization(ListTelemetryRulesForOrganizationRequest request);
    }
}
