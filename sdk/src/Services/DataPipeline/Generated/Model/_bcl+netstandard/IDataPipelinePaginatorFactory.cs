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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Paginators for the DataPipeline service
    ///</summary>
    public interface IDataPipelinePaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeObjects operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "Marker" }
        )]
        IDescribeObjectsPaginator DescribeObjects(DescribeObjectsRequest request);

        /// <summary>
        /// Paginator for ListPipelines operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "Marker" }
        )]
        IListPipelinesPaginator ListPipelines(ListPipelinesRequest request);

        /// <summary>
        /// Paginator for QueryObjects operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "Limit",
            OutputToken = new[] { "Marker" }
        )]
        IQueryObjectsPaginator QueryObjects(QueryObjectsRequest request);
    }
}