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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Paginators for the ElasticTranscoder service
    ///</summary>
    public interface IElasticTranscoderPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListJobsByPipeline operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            
            OutputToken = new[] { "NextPageToken" }
        )]
        IListJobsByPipelinePaginator ListJobsByPipeline(ListJobsByPipelineRequest request);

        /// <summary>
        /// Paginator for ListJobsByStatus operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            
            OutputToken = new[] { "NextPageToken" }
        )]
        IListJobsByStatusPaginator ListJobsByStatus(ListJobsByStatusRequest request);

        /// <summary>
        /// Paginator for ListPipelines operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            
            OutputToken = new[] { "NextPageToken" }
        )]
        IListPipelinesPaginator ListPipelines(ListPipelinesRequest request);

        /// <summary>
        /// Paginator for ListPresets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            
            OutputToken = new[] { "NextPageToken" }
        )]
        IListPresetsPaginator ListPresets(ListPresetsRequest request);
    }
}