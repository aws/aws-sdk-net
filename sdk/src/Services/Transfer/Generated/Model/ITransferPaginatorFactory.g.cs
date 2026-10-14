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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Paginators for the Transfer service
    /// </summary>
    public interface ITransferPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAccesses operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccessesPaginator ListAccesses(ListAccessesRequest request);

        /// <summary>
        /// Paginator for ListAgreements operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAgreementsPaginator ListAgreements(ListAgreementsRequest request);

        /// <summary>
        /// Paginator for ListCertificates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCertificatesPaginator ListCertificates(ListCertificatesRequest request);

        /// <summary>
        /// Paginator for ListConnectors operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConnectorsPaginator ListConnectors(ListConnectorsRequest request);

        /// <summary>
        /// Paginator for ListExecutions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListExecutionsPaginator ListExecutions(ListExecutionsRequest request);

        /// <summary>
        /// Paginator for ListFileTransferResults operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFileTransferResultsPaginator ListFileTransferResults(ListFileTransferResultsRequest request);

        /// <summary>
        /// Paginator for ListProfiles operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListProfilesPaginator ListProfiles(ListProfilesRequest request);

        /// <summary>
        /// Paginator for ListSecurityPolicies operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSecurityPoliciesPaginator ListSecurityPolicies(ListSecurityPoliciesRequest request);

        /// <summary>
        /// Paginator for ListServers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListServersPaginator ListServers(ListServersRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListUsersPaginator ListUsers(ListUsersRequest request);

        /// <summary>
        /// Paginator for ListWebApps operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListWebAppsPaginator ListWebApps(ListWebAppsRequest request);

        /// <summary>
        /// Paginator for ListWorkflows operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListWorkflowsPaginator ListWorkflows(ListWorkflowsRequest request);
    }
}
