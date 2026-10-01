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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Paginators for the MediaConvert service
    /// </summary>
    public interface IMediaConvertPaginatorFactory
    {
        /// <summary>
        /// Paginator for DescribeEndpoints operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeEndpointsPaginator DescribeEndpoints(DescribeEndpointsRequest request);

        /// <summary>
        /// Paginator for ListJobTemplates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListJobTemplatesPaginator ListJobTemplates(ListJobTemplatesRequest request);

        /// <summary>
        /// Paginator for ListJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListJobsPaginator ListJobs(ListJobsRequest request);

        /// <summary>
        /// Paginator for ListPresets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPresetsPaginator ListPresets(ListPresetsRequest request);

        /// <summary>
        /// Paginator for ListQueues operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListQueuesPaginator ListQueues(ListQueuesRequest request);

        /// <summary>
        /// Paginator for ListVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListVersionsPaginator ListVersions(ListVersionsRequest request);

        /// <summary>
        /// Paginator for SearchJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchJobsPaginator SearchJobs(SearchJobsRequest request);
    }
}
