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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Paginators for the Athena service
    ///</summary>
    public interface IAthenaPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetQueryResults operation
        ///</summary>
        IGetQueryResultsPaginator GetQueryResults(GetQueryResultsRequest request);

        /// <summary>
        /// Paginator for ListApplicationDPUSizes operation
        ///</summary>
        IListApplicationDPUSizesPaginator ListApplicationDPUSizes(ListApplicationDPUSizesRequest request);

        /// <summary>
        /// Paginator for ListCalculationExecutions operation
        ///</summary>
        IListCalculationExecutionsPaginator ListCalculationExecutions(ListCalculationExecutionsRequest request);

        /// <summary>
        /// Paginator for ListDatabases operation
        ///</summary>
        IListDatabasesPaginator ListDatabases(ListDatabasesRequest request);

        /// <summary>
        /// Paginator for ListDataCatalogs operation
        ///</summary>
        IListDataCatalogsPaginator ListDataCatalogs(ListDataCatalogsRequest request);

        /// <summary>
        /// Paginator for ListEngineVersions operation
        ///</summary>
        IListEngineVersionsPaginator ListEngineVersions(ListEngineVersionsRequest request);

        /// <summary>
        /// Paginator for ListExecutors operation
        ///</summary>
        IListExecutorsPaginator ListExecutors(ListExecutorsRequest request);

        /// <summary>
        /// Paginator for ListNamedQueries operation
        ///</summary>
        IListNamedQueriesPaginator ListNamedQueries(ListNamedQueriesRequest request);

        /// <summary>
        /// Paginator for ListPreparedStatements operation
        ///</summary>
        IListPreparedStatementsPaginator ListPreparedStatements(ListPreparedStatementsRequest request);

        /// <summary>
        /// Paginator for ListQueryExecutions operation
        ///</summary>
        IListQueryExecutionsPaginator ListQueryExecutions(ListQueryExecutionsRequest request);

        /// <summary>
        /// Paginator for ListSessions operation
        ///</summary>
        IListSessionsPaginator ListSessions(ListSessionsRequest request);

        /// <summary>
        /// Paginator for ListTableMetadata operation
        ///</summary>
        IListTableMetadataPaginator ListTableMetadata(ListTableMetadataRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Paginator for ListWorkGroups operation
        ///</summary>
        IListWorkGroupsPaginator ListWorkGroups(ListWorkGroupsRequest request);
    }
}