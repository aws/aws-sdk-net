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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Paginators for the AppSync service
    ///</summary>
    public class AppSyncPaginatorFactory : IAppSyncPaginatorFactory
    {
        private readonly IAmazonAppSync client;

        internal AppSyncPaginatorFactory(IAmazonAppSync client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListApiKeys operation
        ///</summary>
        public IListApiKeysPaginator ListApiKeys(ListApiKeysRequest request) 
        {
            return new ListApiKeysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApis operation
        ///</summary>
        public IListApisPaginator ListApis(ListApisRequest request) 
        {
            return new ListApisPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListChannelNamespaces operation
        ///</summary>
        public IListChannelNamespacesPaginator ListChannelNamespaces(ListChannelNamespacesRequest request) 
        {
            return new ListChannelNamespacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataSources operation
        ///</summary>
        public IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request) 
        {
            return new ListDataSourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDomainNames operation
        ///</summary>
        public IListDomainNamesPaginator ListDomainNames(ListDomainNamesRequest request) 
        {
            return new ListDomainNamesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFunctions operation
        ///</summary>
        public IListFunctionsPaginator ListFunctions(ListFunctionsRequest request) 
        {
            return new ListFunctionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGraphqlApis operation
        ///</summary>
        public IListGraphqlApisPaginator ListGraphqlApis(ListGraphqlApisRequest request) 
        {
            return new ListGraphqlApisPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResolvers operation
        ///</summary>
        public IListResolversPaginator ListResolvers(ListResolversRequest request) 
        {
            return new ListResolversPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResolversByFunction operation
        ///</summary>
        public IListResolversByFunctionPaginator ListResolversByFunction(ListResolversByFunctionRequest request) 
        {
            return new ListResolversByFunctionPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSourceApiAssociations operation
        ///</summary>
        public IListSourceApiAssociationsPaginator ListSourceApiAssociations(ListSourceApiAssociationsRequest request) 
        {
            return new ListSourceApiAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTypes operation
        ///</summary>
        public IListTypesPaginator ListTypes(ListTypesRequest request) 
        {
            return new ListTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTypesByAssociation operation
        ///</summary>
        public IListTypesByAssociationPaginator ListTypesByAssociation(ListTypesByAssociationRequest request) 
        {
            return new ListTypesByAssociationPaginator(this.client, request);
        }
    }
}