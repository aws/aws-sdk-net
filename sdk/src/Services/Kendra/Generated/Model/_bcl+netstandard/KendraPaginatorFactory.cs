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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Paginators for the Kendra service
    ///</summary>
    public class KendraPaginatorFactory : IKendraPaginatorFactory
    {
        private readonly IAmazonKendra client;

        internal KendraPaginatorFactory(IAmazonKendra client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetSnapshots operation
        ///</summary>
        public IGetSnapshotsPaginator GetSnapshots(GetSnapshotsRequest request) 
        {
            return new GetSnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAccessControlConfigurations operation
        ///</summary>
        public IListAccessControlConfigurationsPaginator ListAccessControlConfigurations(ListAccessControlConfigurationsRequest request) 
        {
            return new ListAccessControlConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataSources operation
        ///</summary>
        public IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request) 
        {
            return new ListDataSourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataSourceSyncJobs operation
        ///</summary>
        public IListDataSourceSyncJobsPaginator ListDataSourceSyncJobs(ListDataSourceSyncJobsRequest request) 
        {
            return new ListDataSourceSyncJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEntityPersonas operation
        ///</summary>
        public IListEntityPersonasPaginator ListEntityPersonas(ListEntityPersonasRequest request) 
        {
            return new ListEntityPersonasPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExperienceEntities operation
        ///</summary>
        public IListExperienceEntitiesPaginator ListExperienceEntities(ListExperienceEntitiesRequest request) 
        {
            return new ListExperienceEntitiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExperiences operation
        ///</summary>
        public IListExperiencesPaginator ListExperiences(ListExperiencesRequest request) 
        {
            return new ListExperiencesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFaqs operation
        ///</summary>
        public IListFaqsPaginator ListFaqs(ListFaqsRequest request) 
        {
            return new ListFaqsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroupsOlderThanOrderingId operation
        ///</summary>
        public IListGroupsOlderThanOrderingIdPaginator ListGroupsOlderThanOrderingId(ListGroupsOlderThanOrderingIdRequest request) 
        {
            return new ListGroupsOlderThanOrderingIdPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIndices operation
        ///</summary>
        public IListIndicesPaginator ListIndices(ListIndicesRequest request) 
        {
            return new ListIndicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQuerySuggestionsBlockLists operation
        ///</summary>
        public IListQuerySuggestionsBlockListsPaginator ListQuerySuggestionsBlockLists(ListQuerySuggestionsBlockListsRequest request) 
        {
            return new ListQuerySuggestionsBlockListsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListThesauri operation
        ///</summary>
        public IListThesauriPaginator ListThesauri(ListThesauriRequest request) 
        {
            return new ListThesauriPaginator(this.client, request);
        }
    }
}