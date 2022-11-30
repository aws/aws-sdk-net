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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Paginators for the Athena service
    ///</summary>
    public class AthenaPaginatorFactory : IAthenaPaginatorFactory
    {
        private readonly IAmazonAthena client;

        internal AthenaPaginatorFactory(IAmazonAthena client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetQueryResults operation
        ///</summary>
        public IGetQueryResultsPaginator GetQueryResults(GetQueryResultsRequest request) 
        {
            return new GetQueryResultsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApplicationDPUSizes operation
        ///</summary>
        public IListApplicationDPUSizesPaginator ListApplicationDPUSizes(ListApplicationDPUSizesRequest request) 
        {
            return new ListApplicationDPUSizesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCalculationExecutions operation
        ///</summary>
        public IListCalculationExecutionsPaginator ListCalculationExecutions(ListCalculationExecutionsRequest request) 
        {
            return new ListCalculationExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDatabases operation
        ///</summary>
        public IListDatabasesPaginator ListDatabases(ListDatabasesRequest request) 
        {
            return new ListDatabasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataCatalogs operation
        ///</summary>
        public IListDataCatalogsPaginator ListDataCatalogs(ListDataCatalogsRequest request) 
        {
            return new ListDataCatalogsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEngineVersions operation
        ///</summary>
        public IListEngineVersionsPaginator ListEngineVersions(ListEngineVersionsRequest request) 
        {
            return new ListEngineVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListExecutors operation
        ///</summary>
        public IListExecutorsPaginator ListExecutors(ListExecutorsRequest request) 
        {
            return new ListExecutorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNamedQueries operation
        ///</summary>
        public IListNamedQueriesPaginator ListNamedQueries(ListNamedQueriesRequest request) 
        {
            return new ListNamedQueriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPreparedStatements operation
        ///</summary>
        public IListPreparedStatementsPaginator ListPreparedStatements(ListPreparedStatementsRequest request) 
        {
            return new ListPreparedStatementsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQueryExecutions operation
        ///</summary>
        public IListQueryExecutionsPaginator ListQueryExecutions(ListQueryExecutionsRequest request) 
        {
            return new ListQueryExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSessions operation
        ///</summary>
        public IListSessionsPaginator ListSessions(ListSessionsRequest request) 
        {
            return new ListSessionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTableMetadata operation
        ///</summary>
        public IListTableMetadataPaginator ListTableMetadata(ListTableMetadataRequest request) 
        {
            return new ListTableMetadataPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkGroups operation
        ///</summary>
        public IListWorkGroupsPaginator ListWorkGroups(ListWorkGroupsRequest request) 
        {
            return new ListWorkGroupsPaginator(this.client, request);
        }
    }
}