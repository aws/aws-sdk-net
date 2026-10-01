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

namespace Amazon.NovaAct.Model
{
    /// <summary>
    /// Paginators for the NovaAct service
    /// </summary>
    public interface INovaActPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListActs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListActsPaginator ListActs(ListActsRequest request);

        /// <summary>
        /// Paginator for ListSessions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSessionsPaginator ListSessions(ListSessionsRequest request);

        /// <summary>
        /// Paginator for ListWorkflowDefinitions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListWorkflowDefinitionsPaginator ListWorkflowDefinitions(ListWorkflowDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListWorkflowRuns operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListWorkflowRunsPaginator ListWorkflowRuns(ListWorkflowRunsRequest request);
    }
}
