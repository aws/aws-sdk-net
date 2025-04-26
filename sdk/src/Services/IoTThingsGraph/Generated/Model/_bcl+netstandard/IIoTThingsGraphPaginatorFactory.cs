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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// Paginators for the IoTThingsGraph service
    ///</summary>
    public interface IIoTThingsGraphPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetFlowTemplateRevisions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetFlowTemplateRevisionsPaginator GetFlowTemplateRevisions(GetFlowTemplateRevisionsRequest request);

        /// <summary>
        /// Paginator for GetSystemTemplateRevisions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetSystemTemplateRevisionsPaginator GetSystemTemplateRevisions(GetSystemTemplateRevisionsRequest request);

        /// <summary>
        /// Paginator for ListFlowExecutionMessages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFlowExecutionMessagesPaginator ListFlowExecutionMessages(ListFlowExecutionMessagesRequest request);

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
        /// Paginator for SearchEntities operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchEntitiesPaginator SearchEntities(SearchEntitiesRequest request);

        /// <summary>
        /// Paginator for SearchFlowExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchFlowExecutionsPaginator SearchFlowExecutions(SearchFlowExecutionsRequest request);

        /// <summary>
        /// Paginator for SearchFlowTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchFlowTemplatesPaginator SearchFlowTemplates(SearchFlowTemplatesRequest request);

        /// <summary>
        /// Paginator for SearchSystemInstances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchSystemInstancesPaginator SearchSystemInstances(SearchSystemInstancesRequest request);

        /// <summary>
        /// Paginator for SearchSystemTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchSystemTemplatesPaginator SearchSystemTemplates(SearchSystemTemplatesRequest request);

        /// <summary>
        /// Paginator for SearchThings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchThingsPaginator SearchThings(SearchThingsRequest request);
    }
}