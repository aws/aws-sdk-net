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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Paginators for the CodePipeline service
    ///</summary>
    public interface ICodePipelinePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListActionExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListActionExecutionsPaginator ListActionExecutions(ListActionExecutionsRequest request);

        /// <summary>
        /// Paginator for ListActionTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IListActionTypesPaginator ListActionTypes(ListActionTypesRequest request);

        /// <summary>
        /// Paginator for ListDeployActionExecutionTargets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDeployActionExecutionTargetsPaginator ListDeployActionExecutionTargets(ListDeployActionExecutionTargetsRequest request);

        /// <summary>
        /// Paginator for ListPipelineExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPipelineExecutionsPaginator ListPipelineExecutions(ListPipelineExecutionsRequest request);

        /// <summary>
        /// Paginator for ListPipelines operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPipelinesPaginator ListPipelines(ListPipelinesRequest request);

        /// <summary>
        /// Paginator for ListRuleExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRuleExecutionsPaginator ListRuleExecutions(ListRuleExecutionsRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListWebhooks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWebhooksPaginator ListWebhooks(ListWebhooksRequest request);
    }
}