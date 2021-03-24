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
        IListActionExecutionsPaginator ListActionExecutions(ListActionExecutionsRequest request);

        /// <summary>
        /// Paginator for ListActionTypes operation
        ///</summary>
        IListActionTypesPaginator ListActionTypes(ListActionTypesRequest request);

        /// <summary>
        /// Paginator for ListPipelineExecutions operation
        ///</summary>
        IListPipelineExecutionsPaginator ListPipelineExecutions(ListPipelineExecutionsRequest request);

        /// <summary>
        /// Paginator for ListPipelines operation
        ///</summary>
        IListPipelinesPaginator ListPipelines(ListPipelinesRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListWebhooks operation
        ///</summary>
        IListWebhooksPaginator ListWebhooks(ListWebhooksRequest request);
    }
}