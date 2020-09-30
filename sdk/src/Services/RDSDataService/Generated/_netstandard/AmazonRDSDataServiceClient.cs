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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.RDSDataService.Model;
using Amazon.RDSDataService.Model.Internal.MarshallTransformations;
using Amazon.RDSDataService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RDSDataService
{
    /// <summary>
    /// Implementation for accessing RDSDataService
    ///
    /// Amazon RDS Data Service 
    /// <para>
    /// Amazon RDS provides an HTTP endpoint to run SQL statements on an Amazon Aurora Serverless
    /// DB cluster. To run these statements, you work with the Data Service API.
    /// 
    ///  
    /// <para>
    /// For more information about the Data Service API, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/data-api.html">Using
    /// the Data API for Aurora Serverless</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you have questions or comments related to the Data API, send email to <a href="mailto:Rds-data-api-feedback@amazon.com">Rds-data-api-feedback@amazon.com</a>.
    /// </para>
    ///  </note>
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonRDSDataServiceClient : AmazonServiceClient, IAmazonRDSDataService
    {
        private static IServiceMetadata serviceMetadata = new AmazonRDSDataServiceMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonRDSDataServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRDSDataServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSDataServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRDSDataServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonRDSDataServiceClient Configuration Object</param>
        public AmazonRDSDataServiceClient(AmazonRDSDataServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRDSDataServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonRDSDataServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSDataServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRDSDataServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with AWS Credentials and an
        /// AmazonRDSDataServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRDSDataServiceClient Configuration Object</param>
        public AmazonRDSDataServiceClient(AWSCredentials credentials, AmazonRDSDataServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRDSDataServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRDSDataServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSDataServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRDSDataServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRDSDataServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRDSDataServiceClient Configuration Object</param>
        public AmazonRDSDataServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRDSDataServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRDSDataServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRDSDataServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSDataServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRDSDataServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRDSDataServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRDSDataServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRDSDataServiceClient Configuration Object</param>
        public AmazonRDSDataServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRDSDataServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  BatchExecuteStatement

        internal virtual BatchExecuteStatementResponse BatchExecuteStatement(BatchExecuteStatementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchExecuteStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchExecuteStatementResponseUnmarshaller.Instance;

            return Invoke<BatchExecuteStatementResponse>(request, options);
        }



        /// <summary>
        /// Runs a batch SQL statement over an array of data.
        /// 
        ///  
        /// <para>
        /// You can run bulk update and insert operations for multiple records using a DML statement
        /// with different parameter sets. Bulk operations can provide a significant performance
        /// improvement over individual insert and update operations.
        /// </para>
        ///  <important> 
        /// <para>
        /// If a call isn't part of a transaction because it doesn't include the <code>transactionID</code>
        /// parameter, changes that result from the call are committed automatically.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchExecuteStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchExecuteStatement service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// There is an error in the call or in a SQL statement.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// There are insufficient privileges to make the call.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// The service specified by the <code>resourceArn</code> parameter is not available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.StatementTimeoutException">
        /// The execution of the SQL statement timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/BatchExecuteStatement">REST API Reference for BatchExecuteStatement Operation</seealso>
        public virtual Task<BatchExecuteStatementResponse> BatchExecuteStatementAsync(BatchExecuteStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchExecuteStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchExecuteStatementResponseUnmarshaller.Instance;

            return InvokeAsync<BatchExecuteStatementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BeginTransaction

        internal virtual BeginTransactionResponse BeginTransaction(BeginTransactionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BeginTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BeginTransactionResponseUnmarshaller.Instance;

            return Invoke<BeginTransactionResponse>(request, options);
        }



        /// <summary>
        /// Starts a SQL transaction.
        /// 
        ///  <pre><code> &lt;important&gt; &lt;p&gt;A transaction can run for a maximum of 24
        /// hours. A transaction is terminated and rolled back automatically after 24 hours.&lt;/p&gt;
        /// &lt;p&gt;A transaction times out if no calls use its transaction ID in three minutes.
        /// If a transaction times out before it's committed, it's rolled back automatically.&lt;/p&gt;
        /// &lt;p&gt;DDL statements inside a transaction cause an implicit commit. We recommend
        /// that you run each DDL statement in a separate &lt;code&gt;ExecuteStatement&lt;/code&gt;
        /// call with &lt;code&gt;continueAfterTimeout&lt;/code&gt; enabled.&lt;/p&gt; &lt;/important&gt;
        /// </code></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BeginTransaction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BeginTransaction service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// There is an error in the call or in a SQL statement.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// There are insufficient privileges to make the call.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// The service specified by the <code>resourceArn</code> parameter is not available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.StatementTimeoutException">
        /// The execution of the SQL statement timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/BeginTransaction">REST API Reference for BeginTransaction Operation</seealso>
        public virtual Task<BeginTransactionResponse> BeginTransactionAsync(BeginTransactionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BeginTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BeginTransactionResponseUnmarshaller.Instance;

            return InvokeAsync<BeginTransactionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CommitTransaction

        internal virtual CommitTransactionResponse CommitTransaction(CommitTransactionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CommitTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CommitTransactionResponseUnmarshaller.Instance;

            return Invoke<CommitTransactionResponse>(request, options);
        }



        /// <summary>
        /// Ends a SQL transaction started with the <code>BeginTransaction</code> operation and
        /// commits the changes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CommitTransaction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CommitTransaction service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// There is an error in the call or in a SQL statement.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// There are insufficient privileges to make the call.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.NotFoundException">
        /// The <code>resourceArn</code>, <code>secretArn</code>, or <code>transactionId</code>
        /// value can't be found.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// The service specified by the <code>resourceArn</code> parameter is not available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.StatementTimeoutException">
        /// The execution of the SQL statement timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/CommitTransaction">REST API Reference for CommitTransaction Operation</seealso>
        public virtual Task<CommitTransactionResponse> CommitTransactionAsync(CommitTransactionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CommitTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CommitTransactionResponseUnmarshaller.Instance;

            return InvokeAsync<CommitTransactionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteSql

        [Obsolete("ExecuteSql has been deprecated.  Please use ExecuteStatement or BatchExecuteStatement instead.")]
        internal virtual ExecuteSqlResponse ExecuteSql(ExecuteSqlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteSqlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteSqlResponseUnmarshaller.Instance;

            return Invoke<ExecuteSqlResponse>(request, options);
        }



        /// <summary>
        /// Runs one or more SQL statements.
        /// 
        ///  <important> 
        /// <para>
        /// This operation is deprecated. Use the <code>BatchExecuteStatement</code> or <code>ExecuteStatement</code>
        /// operation.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteSql service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteSql service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// There is an error in the call or in a SQL statement.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// There are insufficient privileges to make the call.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// The service specified by the <code>resourceArn</code> parameter is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/ExecuteSql">REST API Reference for ExecuteSql Operation</seealso>
        [Obsolete("ExecuteSql has been deprecated.  Please use ExecuteStatement or BatchExecuteStatement instead.")]
        public virtual Task<ExecuteSqlResponse> ExecuteSqlAsync(ExecuteSqlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteSqlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteSqlResponseUnmarshaller.Instance;

            return InvokeAsync<ExecuteSqlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteStatement

        internal virtual ExecuteStatementResponse ExecuteStatement(ExecuteStatementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteStatementResponseUnmarshaller.Instance;

            return Invoke<ExecuteStatementResponse>(request, options);
        }



        /// <summary>
        /// Runs a SQL statement against a database.
        /// 
        ///  <important> 
        /// <para>
        /// If a call isn't part of a transaction because it doesn't include the <code>transactionID</code>
        /// parameter, changes that result from the call are committed automatically.
        /// </para>
        ///  </important> 
        /// <para>
        /// The response size limit is 1 MB. If the call returns more than 1 MB of response data,
        /// the call is terminated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteStatement service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// There is an error in the call or in a SQL statement.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// There are insufficient privileges to make the call.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// The service specified by the <code>resourceArn</code> parameter is not available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.StatementTimeoutException">
        /// The execution of the SQL statement timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/ExecuteStatement">REST API Reference for ExecuteStatement Operation</seealso>
        public virtual Task<ExecuteStatementResponse> ExecuteStatementAsync(ExecuteStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteStatementResponseUnmarshaller.Instance;

            return InvokeAsync<ExecuteStatementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RollbackTransaction

        internal virtual RollbackTransactionResponse RollbackTransaction(RollbackTransactionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RollbackTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RollbackTransactionResponseUnmarshaller.Instance;

            return Invoke<RollbackTransactionResponse>(request, options);
        }



        /// <summary>
        /// Performs a rollback of a transaction. Rolling back a transaction cancels its changes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RollbackTransaction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RollbackTransaction service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// There is an error in the call or in a SQL statement.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// There are insufficient privileges to make the call.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.NotFoundException">
        /// The <code>resourceArn</code>, <code>secretArn</code>, or <code>transactionId</code>
        /// value can't be found.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// The service specified by the <code>resourceArn</code> parameter is not available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.StatementTimeoutException">
        /// The execution of the SQL statement timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/RollbackTransaction">REST API Reference for RollbackTransaction Operation</seealso>
        public virtual Task<RollbackTransactionResponse> RollbackTransactionAsync(RollbackTransactionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RollbackTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RollbackTransactionResponseUnmarshaller.Instance;

            return InvokeAsync<RollbackTransactionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}