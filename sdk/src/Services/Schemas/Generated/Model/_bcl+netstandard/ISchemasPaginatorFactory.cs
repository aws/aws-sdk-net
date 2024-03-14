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

namespace Amazon.Schemas.Model
{
    /// <summary>
    /// Paginators for the Schemas service
    ///</summary>
    public interface ISchemasPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDiscoverers operation
        ///</summary>
        IListDiscoverersPaginator ListDiscoverers(ListDiscoverersRequest request);

        /// <summary>
        /// Paginator for ListRegistries operation
        ///</summary>
        IListRegistriesPaginator ListRegistries(ListRegistriesRequest request);

        /// <summary>
        /// Paginator for ListSchemas operation
        ///</summary>
        IListSchemasPaginator ListSchemas(ListSchemasRequest request);

        /// <summary>
        /// Paginator for ListSchemaVersions operation
        ///</summary>
        IListSchemaVersionsPaginator ListSchemaVersions(ListSchemaVersionsRequest request);

        /// <summary>
        /// Paginator for SearchSchemas operation
        ///</summary>
        ISearchSchemasPaginator SearchSchemas(SearchSchemasRequest request);
    }
}