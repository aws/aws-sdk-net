#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the redshift-data-2019-12-20.normal.json service model.
 */

namespace Amazon.RedshiftDataAPIService.Model
{
    /// <summary>
    /// Paginators for the RedshiftDataAPIService service
    ///</summary>
    public interface IRedshiftDataAPIServicePaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeTable operation
        ///</summary>
        IDescribeTablePaginator DescribeTable(DescribeTableRequest request);

        /// <summary>
        /// Paginator for GetStatementResult operation
        ///</summary>
        IGetStatementResultPaginator GetStatementResult(GetStatementResultRequest request);

        /// <summary>
        /// Paginator for ListDatabases operation
        ///</summary>
        IListDatabasesPaginator ListDatabases(ListDatabasesRequest request);

        /// <summary>
        /// Paginator for ListSchemas operation
        ///</summary>
        IListSchemasPaginator ListSchemas(ListSchemasRequest request);

        /// <summary>
        /// Paginator for ListStatements operation
        ///</summary>
        IListStatementsPaginator ListStatements(ListStatementsRequest request);

        /// <summary>
        /// Paginator for ListTables operation
        ///</summary>
        IListTablesPaginator ListTables(ListTablesRequest request);
    }
}
#endif