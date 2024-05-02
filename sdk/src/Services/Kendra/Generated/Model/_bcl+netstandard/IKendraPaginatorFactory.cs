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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Paginators for the Kendra service
    ///</summary>
    public interface IKendraPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetSnapshots operation
        ///</summary>
        IGetSnapshotsPaginator GetSnapshots(GetSnapshotsRequest request);

        /// <summary>
        /// Paginator for ListAccessControlConfigurations operation
        ///</summary>
        IListAccessControlConfigurationsPaginator ListAccessControlConfigurations(ListAccessControlConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListDataSources operation
        ///</summary>
        IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request);

        /// <summary>
        /// Paginator for ListDataSourceSyncJobs operation
        ///</summary>
        IListDataSourceSyncJobsPaginator ListDataSourceSyncJobs(ListDataSourceSyncJobsRequest request);

        /// <summary>
        /// Paginator for ListEntityPersonas operation
        ///</summary>
        IListEntityPersonasPaginator ListEntityPersonas(ListEntityPersonasRequest request);

        /// <summary>
        /// Paginator for ListExperienceEntities operation
        ///</summary>
        IListExperienceEntitiesPaginator ListExperienceEntities(ListExperienceEntitiesRequest request);

        /// <summary>
        /// Paginator for ListExperiences operation
        ///</summary>
        IListExperiencesPaginator ListExperiences(ListExperiencesRequest request);

        /// <summary>
        /// Paginator for ListFaqs operation
        ///</summary>
        IListFaqsPaginator ListFaqs(ListFaqsRequest request);

        /// <summary>
        /// Paginator for ListGroupsOlderThanOrderingId operation
        ///</summary>
        IListGroupsOlderThanOrderingIdPaginator ListGroupsOlderThanOrderingId(ListGroupsOlderThanOrderingIdRequest request);

        /// <summary>
        /// Paginator for ListIndices operation
        ///</summary>
        IListIndicesPaginator ListIndices(ListIndicesRequest request);

        /// <summary>
        /// Paginator for ListQuerySuggestionsBlockLists operation
        ///</summary>
        IListQuerySuggestionsBlockListsPaginator ListQuerySuggestionsBlockLists(ListQuerySuggestionsBlockListsRequest request);

        /// <summary>
        /// Paginator for ListThesauri operation
        ///</summary>
        IListThesauriPaginator ListThesauri(ListThesauriRequest request);
    }
}