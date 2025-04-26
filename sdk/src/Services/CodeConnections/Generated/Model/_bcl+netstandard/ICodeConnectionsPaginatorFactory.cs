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
 * Do not modify this file. This file is generated from the codeconnections-2023-12-01.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeConnections.Model
{
    /// <summary>
    /// Paginators for the CodeConnections service
    ///</summary>
    public interface ICodeConnectionsPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListConnections operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListConnectionsPaginator ListConnections(ListConnectionsRequest request);

        /// <summary>
        /// Paginator for ListHosts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListHostsPaginator ListHosts(ListHostsRequest request);

        /// <summary>
        /// Paginator for ListRepositoryLinks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRepositoryLinksPaginator ListRepositoryLinks(ListRepositoryLinksRequest request);

        /// <summary>
        /// Paginator for ListSyncConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSyncConfigurationsPaginator ListSyncConfigurations(ListSyncConfigurationsRequest request);
    }
}