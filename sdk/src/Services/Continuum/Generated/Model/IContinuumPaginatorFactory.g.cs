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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// Paginators for the Continuum service
    /// </summary>
    public interface IContinuumPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAssociatedCollectors operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssociatedCollectorsPaginator ListAssociatedCollectors(ListAssociatedCollectorsRequest request);

        /// <summary>
        /// Paginator for ListAssociatedEnvironments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssociatedEnvironmentsPaginator ListAssociatedEnvironments(ListAssociatedEnvironmentsRequest request);

        /// <summary>
        /// Paginator for ListCodeFindings operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCodeFindingsPaginator ListCodeFindings(ListCodeFindingsRequest request);

        /// <summary>
        /// Paginator for ListCodeIssueArtifacts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCodeIssueArtifactsPaginator ListCodeIssueArtifacts(ListCodeIssueArtifactsRequest request);

        /// <summary>
        /// Paginator for ListCodeIssues operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCodeIssuesPaginator ListCodeIssues(ListCodeIssuesRequest request);

        /// <summary>
        /// Paginator for ListCodeScans operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCodeScansPaginator ListCodeScans(ListCodeScansRequest request);

        /// <summary>
        /// Paginator for ListEnvironments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request);

        /// <summary>
        /// Paginator for ListIntegrations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIntegrationsPaginator ListIntegrations(ListIntegrationsRequest request);
    }
}
