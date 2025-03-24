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

#pragma warning disable CS1570
namespace Amazon.RedshiftDataAPIService
{
    /// <summary>
    /// <para>Interface for accessing RedshiftDataAPIService</para>
    ///
    /// You can use the Amazon Redshift Data API to run queries on Amazon Redshift tables.
    /// You can run SQL statements, which are committed if the statement succeeds. 
    /// 
    ///  
    /// <para>
    /// For more information about the Amazon Redshift Data API and CLI usage examples, see
    /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
    /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
    /// </para>
    /// </summary>
    public partial interface IAmazonRedshiftDataAPIService : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRedshiftDataAPIServicePaginatorFactory Paginators { get; }

        
        #region  BatchExecuteStatement


        /// <summary>
        /// Runs one or more SQL statements, which can be data manipulation language (DML) or
        /// data definition language (DDL). Depending on the authorization method, use one of
        /// the following combinations of request parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Secrets Manager - when connecting to a cluster, provide the <c>secret-arn</c> of a
        /// secret stored in Secrets Manager which has <c>username</c> and <c>password</c>. The
        /// specified secret contains credentials to connect to the <c>database</c> you specify.
        /// When you are connecting to a cluster, you also supply the database name, If you provide
        /// a cluster identifier (<c>dbClusterIdentifier</c>), it must match the cluster identifier
        /// stored in the secret. When you are connecting to a serverless workgroup, you also
        /// supply the database name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - when connecting to your data warehouse, choose one of the
        /// following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When connecting to a serverless workgroup, specify the workgroup name and database
        /// name. The database user name is derived from the IAM identity. For example, <c>arn:iam::123456789012:user:foo</c>
        /// has the database user name <c>IAM:foo</c>. Also, permission to call the <c>redshift-serverless:GetCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as an IAM identity, specify the cluster identifier and
        /// the database name. The database user name is derived from the IAM identity. For example,
        /// <c>arn:iam::123456789012:user:foo</c> has the database user name <c>IAM:foo</c>. Also,
        /// permission to call the <c>redshift:GetClusterCredentialsWithIAM</c> operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as a database user, specify the cluster identifier, the
        /// database name, and the database user name. Also, permission to call the <c>redshift:GetClusterCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchExecuteStatement service method.</param>
        /// 
        /// <returns>The response from the BatchExecuteStatement service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ActiveSessionsExceededException">
        /// The Amazon Redshift Data API operation failed because the maximum number of active
        /// sessions exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ActiveStatementsExceededException">
        /// The number of active statements exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.BatchExecuteStatementException">
        /// An SQL statement encountered an environmental error while running.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/BatchExecuteStatement">REST API Reference for BatchExecuteStatement Operation</seealso>
        BatchExecuteStatementResponse BatchExecuteStatement(BatchExecuteStatementRequest request);



        /// <summary>
        /// Runs one or more SQL statements, which can be data manipulation language (DML) or
        /// data definition language (DDL). Depending on the authorization method, use one of
        /// the following combinations of request parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Secrets Manager - when connecting to a cluster, provide the <c>secret-arn</c> of a
        /// secret stored in Secrets Manager which has <c>username</c> and <c>password</c>. The
        /// specified secret contains credentials to connect to the <c>database</c> you specify.
        /// When you are connecting to a cluster, you also supply the database name, If you provide
        /// a cluster identifier (<c>dbClusterIdentifier</c>), it must match the cluster identifier
        /// stored in the secret. When you are connecting to a serverless workgroup, you also
        /// supply the database name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - when connecting to your data warehouse, choose one of the
        /// following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When connecting to a serverless workgroup, specify the workgroup name and database
        /// name. The database user name is derived from the IAM identity. For example, <c>arn:iam::123456789012:user:foo</c>
        /// has the database user name <c>IAM:foo</c>. Also, permission to call the <c>redshift-serverless:GetCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as an IAM identity, specify the cluster identifier and
        /// the database name. The database user name is derived from the IAM identity. For example,
        /// <c>arn:iam::123456789012:user:foo</c> has the database user name <c>IAM:foo</c>. Also,
        /// permission to call the <c>redshift:GetClusterCredentialsWithIAM</c> operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as a database user, specify the cluster identifier, the
        /// database name, and the database user name. Also, permission to call the <c>redshift:GetClusterCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchExecuteStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchExecuteStatement service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ActiveSessionsExceededException">
        /// The Amazon Redshift Data API operation failed because the maximum number of active
        /// sessions exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ActiveStatementsExceededException">
        /// The number of active statements exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.BatchExecuteStatementException">
        /// An SQL statement encountered an environmental error while running.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/BatchExecuteStatement">REST API Reference for BatchExecuteStatement Operation</seealso>
        Task<BatchExecuteStatementResponse> BatchExecuteStatementAsync(BatchExecuteStatementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelStatement


        /// <summary>
        /// Cancels a running query. To be canceled, a query must be running. 
        /// 
        ///  
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelStatement service method.</param>
        /// 
        /// <returns>The response from the CancelStatement service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.DatabaseConnectionException">
        /// Connection to a database failed.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ResourceNotFoundException">
        /// The Amazon Redshift Data API operation failed due to a missing resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/CancelStatement">REST API Reference for CancelStatement Operation</seealso>
        CancelStatementResponse CancelStatement(CancelStatementRequest request);



        /// <summary>
        /// Cancels a running query. To be canceled, a query must be running. 
        /// 
        ///  
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelStatement service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.DatabaseConnectionException">
        /// Connection to a database failed.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ResourceNotFoundException">
        /// The Amazon Redshift Data API operation failed due to a missing resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/CancelStatement">REST API Reference for CancelStatement Operation</seealso>
        Task<CancelStatementResponse> CancelStatementAsync(CancelStatementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStatement


        /// <summary>
        /// Describes the details about a specific instance when a query was run by the Amazon
        /// Redshift Data API. The information includes when the query started, when it finished,
        /// the query status, the number of rows returned, and the SQL statement. 
        /// 
        ///  
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStatement service method.</param>
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
        DescribeStatementResponse DescribeStatement(DescribeStatementRequest request);



        /// <summary>
        /// Describes the details about a specific instance when a query was run by the Amazon
        /// Redshift Data API. The information includes when the query started, when it finished,
        /// the query status, the number of rows returned, and the SQL statement. 
        /// 
        ///  
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
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
        Task<DescribeStatementResponse> DescribeStatementAsync(DescribeStatementRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Secrets Manager - when connecting to a cluster, provide the <c>secret-arn</c> of a
        /// secret stored in Secrets Manager which has <c>username</c> and <c>password</c>. The
        /// specified secret contains credentials to connect to the <c>database</c> you specify.
        /// When you are connecting to a cluster, you also supply the database name, If you provide
        /// a cluster identifier (<c>dbClusterIdentifier</c>), it must match the cluster identifier
        /// stored in the secret. When you are connecting to a serverless workgroup, you also
        /// supply the database name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - when connecting to your data warehouse, choose one of the
        /// following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When connecting to a serverless workgroup, specify the workgroup name and database
        /// name. The database user name is derived from the IAM identity. For example, <c>arn:iam::123456789012:user:foo</c>
        /// has the database user name <c>IAM:foo</c>. Also, permission to call the <c>redshift-serverless:GetCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as an IAM identity, specify the cluster identifier and
        /// the database name. The database user name is derived from the IAM identity. For example,
        /// <c>arn:iam::123456789012:user:foo</c> has the database user name <c>IAM:foo</c>. Also,
        /// permission to call the <c>redshift:GetClusterCredentialsWithIAM</c> operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as a database user, specify the cluster identifier, the
        /// database name, and the database user name. Also, permission to call the <c>redshift:GetClusterCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTable service method.</param>
        /// 
        /// <returns>The response from the DescribeTable service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.DatabaseConnectionException">
        /// Connection to a database failed.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.QueryTimeoutException">
        /// The Amazon Redshift Data API operation failed due to timeout.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/DescribeTable">REST API Reference for DescribeTable Operation</seealso>
        DescribeTableResponse DescribeTable(DescribeTableRequest request);



        /// <summary>
        /// Describes the detailed information about a table from metadata in the cluster. The
        /// information includes its columns. A token is returned to page through the column list.
        /// Depending on the authorization method, use one of the following combinations of request
        /// parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Secrets Manager - when connecting to a cluster, provide the <c>secret-arn</c> of a
        /// secret stored in Secrets Manager which has <c>username</c> and <c>password</c>. The
        /// specified secret contains credentials to connect to the <c>database</c> you specify.
        /// When you are connecting to a cluster, you also supply the database name, If you provide
        /// a cluster identifier (<c>dbClusterIdentifier</c>), it must match the cluster identifier
        /// stored in the secret. When you are connecting to a serverless workgroup, you also
        /// supply the database name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - when connecting to your data warehouse, choose one of the
        /// following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When connecting to a serverless workgroup, specify the workgroup name and database
        /// name. The database user name is derived from the IAM identity. For example, <c>arn:iam::123456789012:user:foo</c>
        /// has the database user name <c>IAM:foo</c>. Also, permission to call the <c>redshift-serverless:GetCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as an IAM identity, specify the cluster identifier and
        /// the database name. The database user name is derived from the IAM identity. For example,
        /// <c>arn:iam::123456789012:user:foo</c> has the database user name <c>IAM:foo</c>. Also,
        /// permission to call the <c>redshift:GetClusterCredentialsWithIAM</c> operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as a database user, specify the cluster identifier, the
        /// database name, and the database user name. Also, permission to call the <c>redshift:GetClusterCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTable service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.DatabaseConnectionException">
        /// Connection to a database failed.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.QueryTimeoutException">
        /// The Amazon Redshift Data API operation failed due to timeout.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/DescribeTable">REST API Reference for DescribeTable Operation</seealso>
        Task<DescribeTableResponse> DescribeTableAsync(DescribeTableRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExecuteStatement


        /// <summary>
        /// Runs an SQL statement, which can be data manipulation language (DML) or data definition
        /// language (DDL). This statement must be a single SQL statement. Depending on the authorization
        /// method, use one of the following combinations of request parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Secrets Manager - when connecting to a cluster, provide the <c>secret-arn</c> of a
        /// secret stored in Secrets Manager which has <c>username</c> and <c>password</c>. The
        /// specified secret contains credentials to connect to the <c>database</c> you specify.
        /// When you are connecting to a cluster, you also supply the database name, If you provide
        /// a cluster identifier (<c>dbClusterIdentifier</c>), it must match the cluster identifier
        /// stored in the secret. When you are connecting to a serverless workgroup, you also
        /// supply the database name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - when connecting to your data warehouse, choose one of the
        /// following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When connecting to a serverless workgroup, specify the workgroup name and database
        /// name. The database user name is derived from the IAM identity. For example, <c>arn:iam::123456789012:user:foo</c>
        /// has the database user name <c>IAM:foo</c>. Also, permission to call the <c>redshift-serverless:GetCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as an IAM identity, specify the cluster identifier and
        /// the database name. The database user name is derived from the IAM identity. For example,
        /// <c>arn:iam::123456789012:user:foo</c> has the database user name <c>IAM:foo</c>. Also,
        /// permission to call the <c>redshift:GetClusterCredentialsWithIAM</c> operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as a database user, specify the cluster identifier, the
        /// database name, and the database user name. Also, permission to call the <c>redshift:GetClusterCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteStatement service method.</param>
        /// 
        /// <returns>The response from the ExecuteStatement service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ActiveSessionsExceededException">
        /// The Amazon Redshift Data API operation failed because the maximum number of active
        /// sessions exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ActiveStatementsExceededException">
        /// The number of active statements exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ExecuteStatementException">
        /// The SQL statement encountered an environmental error while running.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ExecuteStatement">REST API Reference for ExecuteStatement Operation</seealso>
        ExecuteStatementResponse ExecuteStatement(ExecuteStatementRequest request);



        /// <summary>
        /// Runs an SQL statement, which can be data manipulation language (DML) or data definition
        /// language (DDL). This statement must be a single SQL statement. Depending on the authorization
        /// method, use one of the following combinations of request parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Secrets Manager - when connecting to a cluster, provide the <c>secret-arn</c> of a
        /// secret stored in Secrets Manager which has <c>username</c> and <c>password</c>. The
        /// specified secret contains credentials to connect to the <c>database</c> you specify.
        /// When you are connecting to a cluster, you also supply the database name, If you provide
        /// a cluster identifier (<c>dbClusterIdentifier</c>), it must match the cluster identifier
        /// stored in the secret. When you are connecting to a serverless workgroup, you also
        /// supply the database name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - when connecting to your data warehouse, choose one of the
        /// following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When connecting to a serverless workgroup, specify the workgroup name and database
        /// name. The database user name is derived from the IAM identity. For example, <c>arn:iam::123456789012:user:foo</c>
        /// has the database user name <c>IAM:foo</c>. Also, permission to call the <c>redshift-serverless:GetCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as an IAM identity, specify the cluster identifier and
        /// the database name. The database user name is derived from the IAM identity. For example,
        /// <c>arn:iam::123456789012:user:foo</c> has the database user name <c>IAM:foo</c>. Also,
        /// permission to call the <c>redshift:GetClusterCredentialsWithIAM</c> operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as a database user, specify the cluster identifier, the
        /// database name, and the database user name. Also, permission to call the <c>redshift:GetClusterCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteStatement service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ActiveSessionsExceededException">
        /// The Amazon Redshift Data API operation failed because the maximum number of active
        /// sessions exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ActiveStatementsExceededException">
        /// The number of active statements exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ExecuteStatementException">
        /// The SQL statement encountered an environmental error while running.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ExecuteStatement">REST API Reference for ExecuteStatement Operation</seealso>
        Task<ExecuteStatementResponse> ExecuteStatementAsync(ExecuteStatementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStatementResult


        /// <summary>
        /// Fetches the temporarily cached result of an SQL statement in JSON format. The <c>ExecuteStatement</c>
        /// or <c>BatchExecuteStatement</c> operation that ran the SQL statement must have specified
        /// <c>ResultFormat</c> as <c>JSON</c> , or let the format default to JSON. A token is
        /// returned to page through the statement results.
        /// 
        ///  
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStatementResult service method.</param>
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
        GetStatementResultResponse GetStatementResult(GetStatementResultRequest request);



        /// <summary>
        /// Fetches the temporarily cached result of an SQL statement in JSON format. The <c>ExecuteStatement</c>
        /// or <c>BatchExecuteStatement</c> operation that ran the SQL statement must have specified
        /// <c>ResultFormat</c> as <c>JSON</c> , or let the format default to JSON. A token is
        /// returned to page through the statement results.
        /// 
        ///  
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
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
        Task<GetStatementResultResponse> GetStatementResultAsync(GetStatementResultRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStatementResultV2


        /// <summary>
        /// Fetches the temporarily cached result of an SQL statement in CSV format. The <c>ExecuteStatement</c>
        /// or <c>BatchExecuteStatement</c> operation that ran the SQL statement must have specified
        /// <c>ResultFormat</c> as <c>CSV</c>. A token is returned to page through the statement
        /// results.
        /// 
        ///  
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStatementResultV2 service method.</param>
        /// 
        /// <returns>The response from the GetStatementResultV2 service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ResourceNotFoundException">
        /// The Amazon Redshift Data API operation failed due to a missing resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/GetStatementResultV2">REST API Reference for GetStatementResultV2 Operation</seealso>
        GetStatementResultV2Response GetStatementResultV2(GetStatementResultV2Request request);



        /// <summary>
        /// Fetches the temporarily cached result of an SQL statement in CSV format. The <c>ExecuteStatement</c>
        /// or <c>BatchExecuteStatement</c> operation that ran the SQL statement must have specified
        /// <c>ResultFormat</c> as <c>CSV</c>. A token is returned to page through the statement
        /// results.
        /// 
        ///  
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStatementResultV2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStatementResultV2 service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ResourceNotFoundException">
        /// The Amazon Redshift Data API operation failed due to a missing resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/GetStatementResultV2">REST API Reference for GetStatementResultV2 Operation</seealso>
        Task<GetStatementResultV2Response> GetStatementResultV2Async(GetStatementResultV2Request request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDatabases


        /// <summary>
        /// List the databases in a cluster. A token is returned to page through the database
        /// list. Depending on the authorization method, use one of the following combinations
        /// of request parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Secrets Manager - when connecting to a cluster, provide the <c>secret-arn</c> of a
        /// secret stored in Secrets Manager which has <c>username</c> and <c>password</c>. The
        /// specified secret contains credentials to connect to the <c>database</c> you specify.
        /// When you are connecting to a cluster, you also supply the database name, If you provide
        /// a cluster identifier (<c>dbClusterIdentifier</c>), it must match the cluster identifier
        /// stored in the secret. When you are connecting to a serverless workgroup, you also
        /// supply the database name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - when connecting to your data warehouse, choose one of the
        /// following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When connecting to a serverless workgroup, specify the workgroup name and database
        /// name. The database user name is derived from the IAM identity. For example, <c>arn:iam::123456789012:user:foo</c>
        /// has the database user name <c>IAM:foo</c>. Also, permission to call the <c>redshift-serverless:GetCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as an IAM identity, specify the cluster identifier and
        /// the database name. The database user name is derived from the IAM identity. For example,
        /// <c>arn:iam::123456789012:user:foo</c> has the database user name <c>IAM:foo</c>. Also,
        /// permission to call the <c>redshift:GetClusterCredentialsWithIAM</c> operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as a database user, specify the cluster identifier, the
        /// database name, and the database user name. Also, permission to call the <c>redshift:GetClusterCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases service method.</param>
        /// 
        /// <returns>The response from the ListDatabases service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.DatabaseConnectionException">
        /// Connection to a database failed.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.QueryTimeoutException">
        /// The Amazon Redshift Data API operation failed due to timeout.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        ListDatabasesResponse ListDatabases(ListDatabasesRequest request);



        /// <summary>
        /// List the databases in a cluster. A token is returned to page through the database
        /// list. Depending on the authorization method, use one of the following combinations
        /// of request parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Secrets Manager - when connecting to a cluster, provide the <c>secret-arn</c> of a
        /// secret stored in Secrets Manager which has <c>username</c> and <c>password</c>. The
        /// specified secret contains credentials to connect to the <c>database</c> you specify.
        /// When you are connecting to a cluster, you also supply the database name, If you provide
        /// a cluster identifier (<c>dbClusterIdentifier</c>), it must match the cluster identifier
        /// stored in the secret. When you are connecting to a serverless workgroup, you also
        /// supply the database name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - when connecting to your data warehouse, choose one of the
        /// following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When connecting to a serverless workgroup, specify the workgroup name and database
        /// name. The database user name is derived from the IAM identity. For example, <c>arn:iam::123456789012:user:foo</c>
        /// has the database user name <c>IAM:foo</c>. Also, permission to call the <c>redshift-serverless:GetCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as an IAM identity, specify the cluster identifier and
        /// the database name. The database user name is derived from the IAM identity. For example,
        /// <c>arn:iam::123456789012:user:foo</c> has the database user name <c>IAM:foo</c>. Also,
        /// permission to call the <c>redshift:GetClusterCredentialsWithIAM</c> operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as a database user, specify the cluster identifier, the
        /// database name, and the database user name. Also, permission to call the <c>redshift:GetClusterCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatabases service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.DatabaseConnectionException">
        /// Connection to a database failed.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.QueryTimeoutException">
        /// The Amazon Redshift Data API operation failed due to timeout.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        Task<ListDatabasesResponse> ListDatabasesAsync(ListDatabasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSchemas


        /// <summary>
        /// Lists the schemas in a database. A token is returned to page through the schema list.
        /// Depending on the authorization method, use one of the following combinations of request
        /// parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Secrets Manager - when connecting to a cluster, provide the <c>secret-arn</c> of a
        /// secret stored in Secrets Manager which has <c>username</c> and <c>password</c>. The
        /// specified secret contains credentials to connect to the <c>database</c> you specify.
        /// When you are connecting to a cluster, you also supply the database name, If you provide
        /// a cluster identifier (<c>dbClusterIdentifier</c>), it must match the cluster identifier
        /// stored in the secret. When you are connecting to a serverless workgroup, you also
        /// supply the database name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - when connecting to your data warehouse, choose one of the
        /// following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When connecting to a serverless workgroup, specify the workgroup name and database
        /// name. The database user name is derived from the IAM identity. For example, <c>arn:iam::123456789012:user:foo</c>
        /// has the database user name <c>IAM:foo</c>. Also, permission to call the <c>redshift-serverless:GetCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as an IAM identity, specify the cluster identifier and
        /// the database name. The database user name is derived from the IAM identity. For example,
        /// <c>arn:iam::123456789012:user:foo</c> has the database user name <c>IAM:foo</c>. Also,
        /// permission to call the <c>redshift:GetClusterCredentialsWithIAM</c> operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as a database user, specify the cluster identifier, the
        /// database name, and the database user name. Also, permission to call the <c>redshift:GetClusterCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.DatabaseConnectionException">
        /// Connection to a database failed.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.QueryTimeoutException">
        /// The Amazon Redshift Data API operation failed due to timeout.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        ListSchemasResponse ListSchemas(ListSchemasRequest request);



        /// <summary>
        /// Lists the schemas in a database. A token is returned to page through the schema list.
        /// Depending on the authorization method, use one of the following combinations of request
        /// parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Secrets Manager - when connecting to a cluster, provide the <c>secret-arn</c> of a
        /// secret stored in Secrets Manager which has <c>username</c> and <c>password</c>. The
        /// specified secret contains credentials to connect to the <c>database</c> you specify.
        /// When you are connecting to a cluster, you also supply the database name, If you provide
        /// a cluster identifier (<c>dbClusterIdentifier</c>), it must match the cluster identifier
        /// stored in the secret. When you are connecting to a serverless workgroup, you also
        /// supply the database name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - when connecting to your data warehouse, choose one of the
        /// following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When connecting to a serverless workgroup, specify the workgroup name and database
        /// name. The database user name is derived from the IAM identity. For example, <c>arn:iam::123456789012:user:foo</c>
        /// has the database user name <c>IAM:foo</c>. Also, permission to call the <c>redshift-serverless:GetCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as an IAM identity, specify the cluster identifier and
        /// the database name. The database user name is derived from the IAM identity. For example,
        /// <c>arn:iam::123456789012:user:foo</c> has the database user name <c>IAM:foo</c>. Also,
        /// permission to call the <c>redshift:GetClusterCredentialsWithIAM</c> operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as a database user, specify the cluster identifier, the
        /// database name, and the database user name. Also, permission to call the <c>redshift:GetClusterCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.DatabaseConnectionException">
        /// Connection to a database failed.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.QueryTimeoutException">
        /// The Amazon Redshift Data API operation failed due to timeout.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        Task<ListSchemasResponse> ListSchemasAsync(ListSchemasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStatements


        /// <summary>
        /// List of SQL statements. By default, only finished statements are shown. A token is
        /// returned to page through the statement list. 
        /// 
        ///  
        /// <para>
        /// When you use identity-enhanced role sessions to list statements, you must provide
        /// either the <c>cluster-identifier</c> or <c>workgroup-name</c> parameter. This ensures
        /// that the IdC user can only access the Amazon Redshift IdC applications they are assigned.
        /// For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-overview.html">
        /// Trusted identity propagation overview</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStatements service method.</param>
        /// 
        /// <returns>The response from the ListStatements service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListStatements">REST API Reference for ListStatements Operation</seealso>
        ListStatementsResponse ListStatements(ListStatementsRequest request);



        /// <summary>
        /// List of SQL statements. By default, only finished statements are shown. A token is
        /// returned to page through the statement list. 
        /// 
        ///  
        /// <para>
        /// When you use identity-enhanced role sessions to list statements, you must provide
        /// either the <c>cluster-identifier</c> or <c>workgroup-name</c> parameter. This ensures
        /// that the IdC user can only access the Amazon Redshift IdC applications they are assigned.
        /// For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-overview.html">
        /// Trusted identity propagation overview</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
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
        Task<ListStatementsResponse> ListStatementsAsync(ListStatementsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTables


        /// <summary>
        /// List the tables in a database. If neither <c>SchemaPattern</c> nor <c>TablePattern</c>
        /// are specified, then all tables in the database are returned. A token is returned to
        /// page through the table list. Depending on the authorization method, use one of the
        /// following combinations of request parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Secrets Manager - when connecting to a cluster, provide the <c>secret-arn</c> of a
        /// secret stored in Secrets Manager which has <c>username</c> and <c>password</c>. The
        /// specified secret contains credentials to connect to the <c>database</c> you specify.
        /// When you are connecting to a cluster, you also supply the database name, If you provide
        /// a cluster identifier (<c>dbClusterIdentifier</c>), it must match the cluster identifier
        /// stored in the secret. When you are connecting to a serverless workgroup, you also
        /// supply the database name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - when connecting to your data warehouse, choose one of the
        /// following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When connecting to a serverless workgroup, specify the workgroup name and database
        /// name. The database user name is derived from the IAM identity. For example, <c>arn:iam::123456789012:user:foo</c>
        /// has the database user name <c>IAM:foo</c>. Also, permission to call the <c>redshift-serverless:GetCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as an IAM identity, specify the cluster identifier and
        /// the database name. The database user name is derived from the IAM identity. For example,
        /// <c>arn:iam::123456789012:user:foo</c> has the database user name <c>IAM:foo</c>. Also,
        /// permission to call the <c>redshift:GetClusterCredentialsWithIAM</c> operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as a database user, specify the cluster identifier, the
        /// database name, and the database user name. Also, permission to call the <c>redshift:GetClusterCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.DatabaseConnectionException">
        /// Connection to a database failed.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.QueryTimeoutException">
        /// The Amazon Redshift Data API operation failed due to timeout.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListTables">REST API Reference for ListTables Operation</seealso>
        ListTablesResponse ListTables(ListTablesRequest request);



        /// <summary>
        /// List the tables in a database. If neither <c>SchemaPattern</c> nor <c>TablePattern</c>
        /// are specified, then all tables in the database are returned. A token is returned to
        /// page through the table list. Depending on the authorization method, use one of the
        /// following combinations of request parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Secrets Manager - when connecting to a cluster, provide the <c>secret-arn</c> of a
        /// secret stored in Secrets Manager which has <c>username</c> and <c>password</c>. The
        /// specified secret contains credentials to connect to the <c>database</c> you specify.
        /// When you are connecting to a cluster, you also supply the database name, If you provide
        /// a cluster identifier (<c>dbClusterIdentifier</c>), it must match the cluster identifier
        /// stored in the secret. When you are connecting to a serverless workgroup, you also
        /// supply the database name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - when connecting to your data warehouse, choose one of the
        /// following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When connecting to a serverless workgroup, specify the workgroup name and database
        /// name. The database user name is derived from the IAM identity. For example, <c>arn:iam::123456789012:user:foo</c>
        /// has the database user name <c>IAM:foo</c>. Also, permission to call the <c>redshift-serverless:GetCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as an IAM identity, specify the cluster identifier and
        /// the database name. The database user name is derived from the IAM identity. For example,
        /// <c>arn:iam::123456789012:user:foo</c> has the database user name <c>IAM:foo</c>. Also,
        /// permission to call the <c>redshift:GetClusterCredentialsWithIAM</c> operation is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When connecting to a cluster as a database user, specify the cluster identifier, the
        /// database name, and the database user name. Also, permission to call the <c>redshift:GetClusterCredentials</c>
        /// operation is required.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.DatabaseConnectionException">
        /// Connection to a database failed.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.InternalServerException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.QueryTimeoutException">
        /// The Amazon Redshift Data API operation failed due to timeout.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListTables">REST API Reference for ListTables Operation</seealso>
        Task<ListTablesResponse> ListTablesAsync(ListTablesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}