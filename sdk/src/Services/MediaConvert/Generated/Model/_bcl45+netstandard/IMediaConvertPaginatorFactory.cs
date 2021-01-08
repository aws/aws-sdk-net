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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Paginators for the MediaConvert service
    ///</summary>
    public interface IMediaConvertPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeEndpoints operation
        ///</summary>
        IDescribeEndpointsPaginator DescribeEndpoints(DescribeEndpointsRequest request);

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        IListJobsPaginator ListJobs(ListJobsRequest request);

        /// <summary>
        /// Paginator for ListJobTemplates operation
        ///</summary>
        IListJobTemplatesPaginator ListJobTemplates(ListJobTemplatesRequest request);

        /// <summary>
        /// Paginator for ListPresets operation
        ///</summary>
        IListPresetsPaginator ListPresets(ListPresetsRequest request);

        /// <summary>
        /// Paginator for ListQueues operation
        ///</summary>
        IListQueuesPaginator ListQueues(ListQueuesRequest request);
    }
}
#endif