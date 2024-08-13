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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Paginators for the ElasticTranscoder service
    ///</summary>
    public class ElasticTranscoderPaginatorFactory : IElasticTranscoderPaginatorFactory
    {
        private readonly IAmazonElasticTranscoder client;

        internal ElasticTranscoderPaginatorFactory(IAmazonElasticTranscoder client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListJobsByPipeline operation
        ///</summary>
        public IListJobsByPipelinePaginator ListJobsByPipeline(ListJobsByPipelineRequest request) 
        {
            return new ListJobsByPipelinePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListJobsByStatus operation
        ///</summary>
        public IListJobsByStatusPaginator ListJobsByStatus(ListJobsByStatusRequest request) 
        {
            return new ListJobsByStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPipelines operation
        ///</summary>
        public IListPipelinesPaginator ListPipelines(ListPipelinesRequest request) 
        {
            return new ListPipelinesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPresets operation
        ///</summary>
        public IListPresetsPaginator ListPresets(ListPresetsRequest request) 
        {
            return new ListPresetsPaginator(this.client, request);
        }
    }
}