#if !NETSTANDARD13
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

namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Paginators for the IoTAnalytics service
    ///</summary>
    public interface IIoTAnalyticsPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListChannels operation
        ///</summary>
        IListChannelsPaginator ListChannels(ListChannelsRequest request);

        /// <summary>
        /// Paginator for ListDatasetContents operation
        ///</summary>
        IListDatasetContentsPaginator ListDatasetContents(ListDatasetContentsRequest request);

        /// <summary>
        /// Paginator for ListDatasets operation
        ///</summary>
        IListDatasetsPaginator ListDatasets(ListDatasetsRequest request);

        /// <summary>
        /// Paginator for ListDatastores operation
        ///</summary>
        IListDatastoresPaginator ListDatastores(ListDatastoresRequest request);

        /// <summary>
        /// Paginator for ListPipelines operation
        ///</summary>
        IListPipelinesPaginator ListPipelines(ListPipelinesRequest request);
    }
}
#endif