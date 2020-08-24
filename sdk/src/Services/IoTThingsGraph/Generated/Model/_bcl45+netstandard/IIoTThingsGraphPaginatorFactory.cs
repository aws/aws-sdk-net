#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        IGetFlowTemplateRevisionsPaginator GetFlowTemplateRevisions(GetFlowTemplateRevisionsRequest request);

        /// <summary>
        /// Paginator for GetSystemTemplateRevisions operation
        ///</summary>
        IGetSystemTemplateRevisionsPaginator GetSystemTemplateRevisions(GetSystemTemplateRevisionsRequest request);

        /// <summary>
        /// Paginator for ListFlowExecutionMessages operation
        ///</summary>
        IListFlowExecutionMessagesPaginator ListFlowExecutionMessages(ListFlowExecutionMessagesRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for SearchEntities operation
        ///</summary>
        ISearchEntitiesPaginator SearchEntities(SearchEntitiesRequest request);

        /// <summary>
        /// Paginator for SearchFlowExecutions operation
        ///</summary>
        ISearchFlowExecutionsPaginator SearchFlowExecutions(SearchFlowExecutionsRequest request);

        /// <summary>
        /// Paginator for SearchFlowTemplates operation
        ///</summary>
        ISearchFlowTemplatesPaginator SearchFlowTemplates(SearchFlowTemplatesRequest request);

        /// <summary>
        /// Paginator for SearchSystemInstances operation
        ///</summary>
        ISearchSystemInstancesPaginator SearchSystemInstances(SearchSystemInstancesRequest request);

        /// <summary>
        /// Paginator for SearchSystemTemplates operation
        ///</summary>
        ISearchSystemTemplatesPaginator SearchSystemTemplates(SearchSystemTemplatesRequest request);

        /// <summary>
        /// Paginator for SearchThings operation
        ///</summary>
        ISearchThingsPaginator SearchThings(SearchThingsRequest request);
    }
}
#endif