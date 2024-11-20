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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.RedshiftDataAPIService.Model
{
    /// <summary>
    /// Paginators for the RedshiftDataAPIService service
    ///</summary>
    public class RedshiftDataAPIServicePaginatorFactory : IRedshiftDataAPIServicePaginatorFactory
    {
        private readonly IAmazonRedshiftDataAPIService client;

        internal RedshiftDataAPIServicePaginatorFactory(IAmazonRedshiftDataAPIService client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeTable operation
        ///</summary>
        public IDescribeTablePaginator DescribeTable(DescribeTableRequest request) 
        {
            return new DescribeTablePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetStatementResult operation
        ///</summary>
        public IGetStatementResultPaginator GetStatementResult(GetStatementResultRequest request) 
        {
            return new GetStatementResultPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetStatementResultV2 operation
        ///</summary>
        public IGetStatementResultV2Paginator GetStatementResultV2(GetStatementResultV2Request request) 
        {
            return new GetStatementResultV2Paginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDatabases operation
        ///</summary>
        public IListDatabasesPaginator ListDatabases(ListDatabasesRequest request) 
        {
            return new ListDatabasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSchemas operation
        ///</summary>
        public IListSchemasPaginator ListSchemas(ListSchemasRequest request) 
        {
            return new ListSchemasPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStatements operation
        ///</summary>
        public IListStatementsPaginator ListStatements(ListStatementsRequest request) 
        {
            return new ListStatementsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTables operation
        ///</summary>
        public IListTablesPaginator ListTables(ListTablesRequest request) 
        {
            return new ListTablesPaginator(this.client, request);
        }
    }
}