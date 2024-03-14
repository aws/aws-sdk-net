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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// Paginators for the SageMakerGeospatial service
    ///</summary>
    public class SageMakerGeospatialPaginatorFactory : ISageMakerGeospatialPaginatorFactory
    {
        private readonly IAmazonSageMakerGeospatial client;

        internal SageMakerGeospatialPaginatorFactory(IAmazonSageMakerGeospatial client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListEarthObservationJobs operation
        ///</summary>
        public IListEarthObservationJobsPaginator ListEarthObservationJobs(ListEarthObservationJobsRequest request) 
        {
            return new ListEarthObservationJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRasterDataCollections operation
        ///</summary>
        public IListRasterDataCollectionsPaginator ListRasterDataCollections(ListRasterDataCollectionsRequest request) 
        {
            return new ListRasterDataCollectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVectorEnrichmentJobs operation
        ///</summary>
        public IListVectorEnrichmentJobsPaginator ListVectorEnrichmentJobs(ListVectorEnrichmentJobsRequest request) 
        {
            return new ListVectorEnrichmentJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchRasterDataCollection operation
        ///</summary>
        public ISearchRasterDataCollectionPaginator SearchRasterDataCollection(SearchRasterDataCollectionRequest request) 
        {
            return new SearchRasterDataCollectionPaginator(this.client, request);
        }
    }
}