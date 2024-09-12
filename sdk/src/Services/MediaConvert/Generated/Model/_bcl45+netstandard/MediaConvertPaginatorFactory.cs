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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Paginators for the MediaConvert service
    ///</summary>
    public class MediaConvertPaginatorFactory : IMediaConvertPaginatorFactory
    {
        private readonly IAmazonMediaConvert client;

        internal MediaConvertPaginatorFactory(IAmazonMediaConvert client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeEndpoints operation
        ///</summary>
        public IDescribeEndpointsPaginator DescribeEndpoints(DescribeEndpointsRequest request) 
        {
            return new DescribeEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        public IListJobsPaginator ListJobs(ListJobsRequest request) 
        {
            return new ListJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobTemplates operation
        ///</summary>
        public IListJobTemplatesPaginator ListJobTemplates(ListJobTemplatesRequest request) 
        {
            return new ListJobTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPresets operation
        ///</summary>
        public IListPresetsPaginator ListPresets(ListPresetsRequest request) 
        {
            return new ListPresetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQueues operation
        ///</summary>
        public IListQueuesPaginator ListQueues(ListQueuesRequest request) 
        {
            return new ListQueuesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVersions operation
        ///</summary>
        public IListVersionsPaginator ListVersions(ListVersionsRequest request) 
        {
            return new ListVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchJobs operation
        ///</summary>
        public ISearchJobsPaginator SearchJobs(SearchJobsRequest request) 
        {
            return new SearchJobsPaginator(this.client, request);
        }
    }
}