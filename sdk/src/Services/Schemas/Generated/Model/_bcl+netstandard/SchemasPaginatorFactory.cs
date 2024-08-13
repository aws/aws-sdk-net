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
 * Do not modify this file. This file is generated from the schemas-2019-12-02.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Schemas.Model
{
    /// <summary>
    /// Paginators for the Schemas service
    ///</summary>
    public class SchemasPaginatorFactory : ISchemasPaginatorFactory
    {
        private readonly IAmazonSchemas client;

        internal SchemasPaginatorFactory(IAmazonSchemas client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDiscoverers operation
        ///</summary>
        public IListDiscoverersPaginator ListDiscoverers(ListDiscoverersRequest request) 
        {
            return new ListDiscoverersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRegistries operation
        ///</summary>
        public IListRegistriesPaginator ListRegistries(ListRegistriesRequest request) 
        {
            return new ListRegistriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSchemas operation
        ///</summary>
        public IListSchemasPaginator ListSchemas(ListSchemasRequest request) 
        {
            return new ListSchemasPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSchemaVersions operation
        ///</summary>
        public IListSchemaVersionsPaginator ListSchemaVersions(ListSchemaVersionsRequest request) 
        {
            return new ListSchemaVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchSchemas operation
        ///</summary>
        public ISearchSchemasPaginator SearchSchemas(SearchSchemasRequest request) 
        {
            return new SearchSchemasPaginator(this.client, request);
        }
    }
}