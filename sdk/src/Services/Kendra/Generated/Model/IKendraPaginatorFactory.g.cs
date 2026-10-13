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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Paginators for the Kendra service
    /// </summary>
    public interface IKendraPaginatorFactory
    {
        /// <summary>
        /// Paginator for GetSnapshots operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetSnapshotsPaginator GetSnapshots(GetSnapshotsRequest request);

        /// <summary>
        /// Paginator for ListAccessControlConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccessControlConfigurationsPaginator ListAccessControlConfigurations(ListAccessControlConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListDataSourceSyncJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataSourceSyncJobsPaginator ListDataSourceSyncJobs(ListDataSourceSyncJobsRequest request);

        /// <summary>
        /// Paginator for ListDataSources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request);

        /// <summary>
        /// Paginator for ListEntityPersonas operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEntityPersonasPaginator ListEntityPersonas(ListEntityPersonasRequest request);

        /// <summary>
        /// Paginator for ListExperienceEntities operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], OutputToken = ["NextToken"])]
        IListExperienceEntitiesPaginator ListExperienceEntities(ListExperienceEntitiesRequest request);

        /// <summary>
        /// Paginator for ListExperiences operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListExperiencesPaginator ListExperiences(ListExperiencesRequest request);

        /// <summary>
        /// Paginator for ListFaqs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFaqsPaginator ListFaqs(ListFaqsRequest request);

        /// <summary>
        /// Paginator for ListGroupsOlderThanOrderingId operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGroupsOlderThanOrderingIdPaginator ListGroupsOlderThanOrderingId(ListGroupsOlderThanOrderingIdRequest request);

        /// <summary>
        /// Paginator for ListIndices operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIndicesPaginator ListIndices(ListIndicesRequest request);

        /// <summary>
        /// Paginator for ListQuerySuggestionsBlockLists operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListQuerySuggestionsBlockListsPaginator ListQuerySuggestionsBlockLists(ListQuerySuggestionsBlockListsRequest request);

        /// <summary>
        /// Paginator for ListThesauri operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListThesauriPaginator ListThesauri(ListThesauriRequest request);
    }
}
