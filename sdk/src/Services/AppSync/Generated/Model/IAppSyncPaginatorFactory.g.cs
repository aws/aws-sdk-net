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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Paginators for the AppSync service
    /// </summary>
    public interface IAppSyncPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListApiKeys operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListApiKeysPaginator ListApiKeys(ListApiKeysRequest request);

        /// <summary>
        /// Paginator for ListApis operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListApisPaginator ListApis(ListApisRequest request);

        /// <summary>
        /// Paginator for ListChannelNamespaces operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListChannelNamespacesPaginator ListChannelNamespaces(ListChannelNamespacesRequest request);

        /// <summary>
        /// Paginator for ListDataSources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request);

        /// <summary>
        /// Paginator for ListDomainNames operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDomainNamesPaginator ListDomainNames(ListDomainNamesRequest request);

        /// <summary>
        /// Paginator for ListFunctions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFunctionsPaginator ListFunctions(ListFunctionsRequest request);

        /// <summary>
        /// Paginator for ListGraphqlApis operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGraphqlApisPaginator ListGraphqlApis(ListGraphqlApisRequest request);

        /// <summary>
        /// Paginator for ListResolvers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListResolversPaginator ListResolvers(ListResolversRequest request);

        /// <summary>
        /// Paginator for ListResolversByFunction operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListResolversByFunctionPaginator ListResolversByFunction(ListResolversByFunctionRequest request);

        /// <summary>
        /// Paginator for ListSourceApiAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSourceApiAssociationsPaginator ListSourceApiAssociations(ListSourceApiAssociationsRequest request);

        /// <summary>
        /// Paginator for ListTypes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTypesPaginator ListTypes(ListTypesRequest request);

        /// <summary>
        /// Paginator for ListTypesByAssociation operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListTypesByAssociationPaginator ListTypesByAssociation(ListTypesByAssociationRequest request);
    }
}
