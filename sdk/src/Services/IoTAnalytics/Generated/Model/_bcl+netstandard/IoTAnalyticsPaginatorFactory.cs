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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Paginators for the IoTAnalytics service
    ///</summary>
    public class IoTAnalyticsPaginatorFactory : IIoTAnalyticsPaginatorFactory
    {
        private readonly IAmazonIoTAnalytics client;

        internal IoTAnalyticsPaginatorFactory(IAmazonIoTAnalytics client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListChannels operation
        ///</summary>
        public IListChannelsPaginator ListChannels(ListChannelsRequest request) 
        {
            return new ListChannelsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDatasetContents operation
        ///</summary>
        public IListDatasetContentsPaginator ListDatasetContents(ListDatasetContentsRequest request) 
        {
            return new ListDatasetContentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDatasets operation
        ///</summary>
        public IListDatasetsPaginator ListDatasets(ListDatasetsRequest request) 
        {
            return new ListDatasetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDatastores operation
        ///</summary>
        public IListDatastoresPaginator ListDatastores(ListDatastoresRequest request) 
        {
            return new ListDatastoresPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPipelines operation
        ///</summary>
        public IListPipelinesPaginator ListPipelines(ListPipelinesRequest request) 
        {
            return new ListPipelinesPaginator(this.client, request);
        }
    }
}