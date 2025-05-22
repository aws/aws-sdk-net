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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Paginators for the CodePipeline service
    ///</summary>
    public class CodePipelinePaginatorFactory : ICodePipelinePaginatorFactory
    {
        private readonly IAmazonCodePipeline client;

        internal CodePipelinePaginatorFactory(IAmazonCodePipeline client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListActionExecutions operation
        ///</summary>
        public IListActionExecutionsPaginator ListActionExecutions(ListActionExecutionsRequest request) 
        {
            return new ListActionExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListActionTypes operation
        ///</summary>
        public IListActionTypesPaginator ListActionTypes(ListActionTypesRequest request) 
        {
            return new ListActionTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDeployActionExecutionTargets operation
        ///</summary>
        public IListDeployActionExecutionTargetsPaginator ListDeployActionExecutionTargets(ListDeployActionExecutionTargetsRequest request) 
        {
            return new ListDeployActionExecutionTargetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPipelineExecutions operation
        ///</summary>
        public IListPipelineExecutionsPaginator ListPipelineExecutions(ListPipelineExecutionsRequest request) 
        {
            return new ListPipelineExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPipelines operation
        ///</summary>
        public IListPipelinesPaginator ListPipelines(ListPipelinesRequest request) 
        {
            return new ListPipelinesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRuleExecutions operation
        ///</summary>
        public IListRuleExecutionsPaginator ListRuleExecutions(ListRuleExecutionsRequest request) 
        {
            return new ListRuleExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWebhooks operation
        ///</summary>
        public IListWebhooksPaginator ListWebhooks(ListWebhooksRequest request) 
        {
            return new ListWebhooksPaginator(this.client, request);
        }
    }
}