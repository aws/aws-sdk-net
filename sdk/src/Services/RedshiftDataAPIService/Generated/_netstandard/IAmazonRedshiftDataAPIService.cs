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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RedshiftDataAPIService.Model;

namespace Amazon.RedshiftDataAPIService
{
    /// <summary>
    /// Interface for accessing RedshiftDataAPIService
    ///
    /// You can use the Amazon Redshift Data API to run queries on Amazon Redshift tables.
    /// You can run individual SQL statements, which are committed if the statement succeeds.
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonRedshiftDataAPIService : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRedshiftDataAPIServicePaginatorFactory Paginators { get; }
#endif
                
        #region  CancelStatement



        /// <summary>
        /// Cancels a running query. To be canceled, a query must be running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelStatement service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ResourceNotFoundException">
        /// The Amazon Redshift Data API operation failed due to a missing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/CancelStatement">REST API Reference for CancelStatement Operation</seealso>
        Task<CancelStatementResponse> CancelStatementAsync(CancelStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStatement



        /// <summary>
        /// Describes the details about a specific instance when a query was run by the Amazon
        /// Redshift Data API. The information includes when the query started, when it finished,
        /// the query status, the number of rows returned, and the SQL statement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStatement service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ResourceNotFoundException">
        /// The Amazon Redshift Data API operation failed due to a missing resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/DescribeStatement">REST API Reference for DescribeStatement Operation</seealso>
        Task<DescribeStatementResponse> DescribeStatementAsync(DescribeStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTable



        /// <summary>
        /// Describes the detailed information about a table from metadata in the cluster. The
        /// information includes its columns. A token is returned to page through the column list.
        /// Depending on the authorization method, use one of the following combinations of request
        /// parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// AWS Secrets Manager - specify the Amazon Resource Name (ARN) of the secret and the
        /// cluster identifier that matches the cluster in the secret. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - specify the cluster identifier, the database name, and the
        /// database user name. Permission to call the <code>redshift:GetClusterCredentials</code>
        /// operation is required to use this method. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTable service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/DescribeTable">REST API Reference for DescribeTable Operation</seealso>
        Task<DescribeTableResponse> DescribeTableAsync(DescribeTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExecuteStatement



        /// <summary>
        /// Runs an SQL statement, which can be data manipulation language (DML) or data definition
        /// language (DDL). This statement must be a single SQL statement. Depending on the authorization
        /// method, use one of the following combinations of request parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// AWS Secrets Manager - specify the Amazon Resource Name (ARN) of the secret and the
        /// cluster identifier that matches the cluster in the secret. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - specify the cluster identifier, the database name, and the
        /// database user name. Permission to call the <code>redshift:GetClusterCredentials</code>
        /// operation is required to use this method. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteStatement service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ExecuteStatementException">
        /// The SQL statement encountered an environmental error while running.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ExecuteStatement">REST API Reference for ExecuteStatement Operation</seealso>
        Task<ExecuteStatementResponse> ExecuteStatementAsync(ExecuteStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetStatementResult



        /// <summary>
        /// Fetches the temporarily cached result of an SQL statement. A token is returned to
        /// page through the statement results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStatementResult service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStatementResult service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ResourceNotFoundException">
        /// The Amazon Redshift Data API operation failed due to a missing resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/GetStatementResult">REST API Reference for GetStatementResult Operation</seealso>
        Task<GetStatementResultResponse> GetStatementResultAsync(GetStatementResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDatabases



        /// <summary>
        /// List the databases in a cluster. A token is returned to page through the database
        /// list. Depending on the authorization method, use one of the following combinations
        /// of request parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// AWS Secrets Manager - specify the Amazon Resource Name (ARN) of the secret and the
        /// cluster identifier that matches the cluster in the secret. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - specify the cluster identifier, the database name, and the
        /// database user name. Permission to call the <code>redshift:GetClusterCredentials</code>
        /// operation is required to use this method. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatabases service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        Task<ListDatabasesResponse> ListDatabasesAsync(ListDatabasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSchemas



        /// <summary>
        /// Lists the schemas in a database. A token is returned to page through the schema list.
        /// Depending on the authorization method, use one of the following combinations of request
        /// parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// AWS Secrets Manager - specify the Amazon Resource Name (ARN) of the secret and the
        /// cluster identifier that matches the cluster in the secret. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - specify the cluster identifier, the database name, and the
        /// database user name. Permission to call the <code>redshift:GetClusterCredentials</code>
        /// operation is required to use this method. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        Task<ListSchemasResponse> ListSchemasAsync(ListSchemasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListStatements



        /// <summary>
        /// List of SQL statements. By default, only finished statements are shown. A token is
        /// returned to page through the statement list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStatements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStatements service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListStatements">REST API Reference for ListStatements Operation</seealso>
        Task<ListStatementsResponse> ListStatementsAsync(ListStatementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTables



        /// <summary>
        /// List the tables in a database. If neither <code>SchemaPattern</code> nor <code>TablePattern</code>
        /// are specified, then all tables in the database are returned. A token is returned to
        /// page through the table list. Depending on the authorization method, use one of the
        /// following combinations of request parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// AWS Secrets Manager - specify the Amazon Resource Name (ARN) of the secret and the
        /// cluster identifier that matches the cluster in the secret. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - specify the cluster identifier, the database name, and the
        /// database user name. Permission to call the <code>redshift:GetClusterCredentials</code>
        /// operation is required to use this method. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListTables">REST API Reference for ListTables Operation</seealso>
        Task<ListTablesResponse> ListTablesAsync(ListTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}