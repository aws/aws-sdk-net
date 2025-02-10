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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Paginators for the AppSync service
    ///</summary>
    public interface IAppSyncPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListApiKeys operation
        ///</summary>
        IListApiKeysPaginator ListApiKeys(ListApiKeysRequest request);

        /// <summary>
        /// Paginator for ListApis operation
        ///</summary>
        IListApisPaginator ListApis(ListApisRequest request);

        /// <summary>
        /// Paginator for ListChannelNamespaces operation
        ///</summary>
        IListChannelNamespacesPaginator ListChannelNamespaces(ListChannelNamespacesRequest request);

        /// <summary>
        /// Paginator for ListDataSources operation
        ///</summary>
        IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request);

        /// <summary>
        /// Paginator for ListDomainNames operation
        ///</summary>
        IListDomainNamesPaginator ListDomainNames(ListDomainNamesRequest request);

        /// <summary>
        /// Paginator for ListFunctions operation
        ///</summary>
        IListFunctionsPaginator ListFunctions(ListFunctionsRequest request);

        /// <summary>
        /// Paginator for ListGraphqlApis operation
        ///</summary>
        IListGraphqlApisPaginator ListGraphqlApis(ListGraphqlApisRequest request);

        /// <summary>
        /// Paginator for ListResolvers operation
        ///</summary>
        IListResolversPaginator ListResolvers(ListResolversRequest request);

        /// <summary>
        /// Paginator for ListResolversByFunction operation
        ///</summary>
        IListResolversByFunctionPaginator ListResolversByFunction(ListResolversByFunctionRequest request);

        /// <summary>
        /// Paginator for ListSourceApiAssociations operation
        ///</summary>
        IListSourceApiAssociationsPaginator ListSourceApiAssociations(ListSourceApiAssociationsRequest request);

        /// <summary>
        /// Paginator for ListTypes operation
        ///</summary>
        IListTypesPaginator ListTypes(ListTypesRequest request);

        /// <summary>
        /// Paginator for ListTypesByAssociation operation
        ///</summary>
        IListTypesByAssociationPaginator ListTypesByAssociation(ListTypesByAssociationRequest request);
    }
}