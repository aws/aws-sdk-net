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

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// Paginators for the SageMakerGeospatial service
    ///</summary>
    public interface ISageMakerGeospatialPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListEarthObservationJobs operation
        ///</summary>
        IListEarthObservationJobsPaginator ListEarthObservationJobs(ListEarthObservationJobsRequest request);

        /// <summary>
        /// Paginator for ListRasterDataCollections operation
        ///</summary>
        IListRasterDataCollectionsPaginator ListRasterDataCollections(ListRasterDataCollectionsRequest request);

        /// <summary>
        /// Paginator for ListVectorEnrichmentJobs operation
        ///</summary>
        IListVectorEnrichmentJobsPaginator ListVectorEnrichmentJobs(ListVectorEnrichmentJobsRequest request);

        /// <summary>
        /// Paginator for SearchRasterDataCollection operation
        ///</summary>
        ISearchRasterDataCollectionPaginator SearchRasterDataCollection(SearchRasterDataCollectionRequest request);
    }
}