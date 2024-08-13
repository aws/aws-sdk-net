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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// Paginators for the IoTThingsGraph service
    ///</summary>
    public class IoTThingsGraphPaginatorFactory : IIoTThingsGraphPaginatorFactory
    {
        private readonly IAmazonIoTThingsGraph client;

        internal IoTThingsGraphPaginatorFactory(IAmazonIoTThingsGraph client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetFlowTemplateRevisions operation
        ///</summary>
        public IGetFlowTemplateRevisionsPaginator GetFlowTemplateRevisions(GetFlowTemplateRevisionsRequest request) 
        {
            return new GetFlowTemplateRevisionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetSystemTemplateRevisions operation
        ///</summary>
        public IGetSystemTemplateRevisionsPaginator GetSystemTemplateRevisions(GetSystemTemplateRevisionsRequest request) 
        {
            return new GetSystemTemplateRevisionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFlowExecutionMessages operation
        ///</summary>
        public IListFlowExecutionMessagesPaginator ListFlowExecutionMessages(ListFlowExecutionMessagesRequest request) 
        {
            return new ListFlowExecutionMessagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchEntities operation
        ///</summary>
        public ISearchEntitiesPaginator SearchEntities(SearchEntitiesRequest request) 
        {
            return new SearchEntitiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchFlowExecutions operation
        ///</summary>
        public ISearchFlowExecutionsPaginator SearchFlowExecutions(SearchFlowExecutionsRequest request) 
        {
            return new SearchFlowExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchFlowTemplates operation
        ///</summary>
        public ISearchFlowTemplatesPaginator SearchFlowTemplates(SearchFlowTemplatesRequest request) 
        {
            return new SearchFlowTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchSystemInstances operation
        ///</summary>
        public ISearchSystemInstancesPaginator SearchSystemInstances(SearchSystemInstancesRequest request) 
        {
            return new SearchSystemInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchSystemTemplates operation
        ///</summary>
        public ISearchSystemTemplatesPaginator SearchSystemTemplates(SearchSystemTemplatesRequest request) 
        {
            return new SearchSystemTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchThings operation
        ///</summary>
        public ISearchThingsPaginator SearchThings(SearchThingsRequest request) 
        {
            return new SearchThingsPaginator(this.client, request);
        }
    }
}