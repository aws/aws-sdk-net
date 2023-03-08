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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Athena.Model;
using Amazon.Athena.Model.Internal.MarshallTransformations;
using Amazon.Athena.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Athena
{
    /// <summary>
    /// Implementation for accessing Athena
    ///
    /// Amazon Athena is an interactive query service that lets you use standard SQL to analyze
    /// data directly in Amazon S3. You can point Athena at your data in Amazon S3 and run
    /// ad-hoc queries and get results in seconds. Athena is serverless, so there is no infrastructure
    /// to set up or manage. You pay only for the queries you run. Athena scales automatically—executing
    /// queries in parallel—so results are fast, even with large datasets and complex queries.
    /// For more information, see <a href="http://docs.aws.amazon.com/athena/latest/ug/what-is.html">What
    /// is Amazon Athena</a> in the <i>Amazon Athena User Guide</i>.
    /// 
    ///  
    /// <para>
    /// If you connect to Athena using the JDBC driver, use version 1.1.0 of the driver or
    /// later with the Amazon Athena API. Earlier version drivers do not support the API.
    /// For more information and to download the driver, see <a href="https://docs.aws.amazon.com/athena/latest/ug/connect-with-jdbc.html">Accessing
    /// Amazon Athena with JDBC</a>.
    /// </para>
    ///  
    /// <para>
    /// For code samples using the Amazon Web Services SDK for Java, see <a href="https://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
    /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonAthenaClient : AmazonServiceClient, IAmazonAthena
    {
        private static IServiceMetadata serviceMetadata = new AmazonAthenaMetadata();
        private IAthenaPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAthenaPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AthenaPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonAthenaClient with the credentials loaded from the application's
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
        public AmazonAthenaClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAthenaConfig()) { }

        /// <summary>
        /// Constructs AmazonAthenaClient with the credentials loaded from the application's
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
        public AmazonAthenaClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAthenaConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAthenaClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAthenaClient Configuration Object</param>
        public AmazonAthenaClient(AmazonAthenaConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonAthenaClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAthenaClient(AWSCredentials credentials)
            : this(credentials, new AmazonAthenaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAthenaClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAthenaClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAthenaConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAthenaClient with AWS Credentials and an
        /// AmazonAthenaClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAthenaClient Configuration Object</param>
        public AmazonAthenaClient(AWSCredentials credentials, AmazonAthenaConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAthenaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAthenaClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAthenaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAthenaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAthenaClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAthenaConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAthenaClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAthenaClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAthenaClient Configuration Object</param>
        public AmazonAthenaClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAthenaConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAthenaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAthenaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAthenaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAthenaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAthenaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAthenaConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAthenaClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAthenaClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAthenaClient Configuration Object</param>
        public AmazonAthenaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAthenaConfig clientConfig)
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAthenaEndpointResolver());
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


        #region  BatchGetNamedQuery


        /// <summary>
        /// Returns the details of a single named query or a list of up to 50 queries, which you
        /// provide as an array of query ID strings. Requires you to have access to the workgroup
        /// in which the queries were saved. Use <a>ListNamedQueriesInput</a> to get the list
        /// of named query IDs in the specified workgroup. If information could not be retrieved
        /// for a submitted query ID, information about the query ID submitted is listed under
        /// <a>UnprocessedNamedQueryId</a>. Named queries differ from executed queries. Use <a>BatchGetQueryExecutionInput</a>
        /// to get details about each unique query execution, and <a>ListQueryExecutionsInput</a>
        /// to get a list of query execution IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetNamedQuery service method.</param>
        /// 
        /// <returns>The response from the BatchGetNamedQuery service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/BatchGetNamedQuery">REST API Reference for BatchGetNamedQuery Operation</seealso>
        public virtual BatchGetNamedQueryResponse BatchGetNamedQuery(BatchGetNamedQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetNamedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetNamedQueryResponseUnmarshaller.Instance;

            return Invoke<BatchGetNamedQueryResponse>(request, options);
        }


        /// <summary>
        /// Returns the details of a single named query or a list of up to 50 queries, which you
        /// provide as an array of query ID strings. Requires you to have access to the workgroup
        /// in which the queries were saved. Use <a>ListNamedQueriesInput</a> to get the list
        /// of named query IDs in the specified workgroup. If information could not be retrieved
        /// for a submitted query ID, information about the query ID submitted is listed under
        /// <a>UnprocessedNamedQueryId</a>. Named queries differ from executed queries. Use <a>BatchGetQueryExecutionInput</a>
        /// to get details about each unique query execution, and <a>ListQueryExecutionsInput</a>
        /// to get a list of query execution IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetNamedQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetNamedQuery service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/BatchGetNamedQuery">REST API Reference for BatchGetNamedQuery Operation</seealso>
        public virtual Task<BatchGetNamedQueryResponse> BatchGetNamedQueryAsync(BatchGetNamedQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetNamedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetNamedQueryResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetNamedQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetPreparedStatement


        /// <summary>
        /// Returns the details of a single prepared statement or a list of up to 256 prepared
        /// statements for the array of prepared statement names that you provide. Requires you
        /// to have access to the workgroup to which the prepared statements belong. If a prepared
        /// statement cannot be retrieved for the name specified, the statement is listed in <code>UnprocessedPreparedStatementNames</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPreparedStatement service method.</param>
        /// 
        /// <returns>The response from the BatchGetPreparedStatement service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/BatchGetPreparedStatement">REST API Reference for BatchGetPreparedStatement Operation</seealso>
        public virtual BatchGetPreparedStatementResponse BatchGetPreparedStatement(BatchGetPreparedStatementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetPreparedStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetPreparedStatementResponseUnmarshaller.Instance;

            return Invoke<BatchGetPreparedStatementResponse>(request, options);
        }


        /// <summary>
        /// Returns the details of a single prepared statement or a list of up to 256 prepared
        /// statements for the array of prepared statement names that you provide. Requires you
        /// to have access to the workgroup to which the prepared statements belong. If a prepared
        /// statement cannot be retrieved for the name specified, the statement is listed in <code>UnprocessedPreparedStatementNames</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPreparedStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetPreparedStatement service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/BatchGetPreparedStatement">REST API Reference for BatchGetPreparedStatement Operation</seealso>
        public virtual Task<BatchGetPreparedStatementResponse> BatchGetPreparedStatementAsync(BatchGetPreparedStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetPreparedStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetPreparedStatementResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetPreparedStatementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetQueryExecution


        /// <summary>
        /// Returns the details of a single query execution or a list of up to 50 query executions,
        /// which you provide as an array of query execution ID strings. Requires you to have
        /// access to the workgroup in which the queries ran. To get a list of query execution
        /// IDs, use <a>ListQueryExecutionsInput$WorkGroup</a>. Query executions differ from named
        /// (saved) queries. Use <a>BatchGetNamedQueryInput</a> to get details about named queries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetQueryExecution service method.</param>
        /// 
        /// <returns>The response from the BatchGetQueryExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/BatchGetQueryExecution">REST API Reference for BatchGetQueryExecution Operation</seealso>
        public virtual BatchGetQueryExecutionResponse BatchGetQueryExecution(BatchGetQueryExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetQueryExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetQueryExecutionResponseUnmarshaller.Instance;

            return Invoke<BatchGetQueryExecutionResponse>(request, options);
        }


        /// <summary>
        /// Returns the details of a single query execution or a list of up to 50 query executions,
        /// which you provide as an array of query execution ID strings. Requires you to have
        /// access to the workgroup in which the queries ran. To get a list of query execution
        /// IDs, use <a>ListQueryExecutionsInput$WorkGroup</a>. Query executions differ from named
        /// (saved) queries. Use <a>BatchGetNamedQueryInput</a> to get details about named queries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetQueryExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetQueryExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/BatchGetQueryExecution">REST API Reference for BatchGetQueryExecution Operation</seealso>
        public virtual Task<BatchGetQueryExecutionResponse> BatchGetQueryExecutionAsync(BatchGetQueryExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetQueryExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetQueryExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetQueryExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataCatalog


        /// <summary>
        /// Creates (registers) a data catalog with the specified name and properties. Catalogs
        /// created are visible to all users of the same Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataCatalog service method.</param>
        /// 
        /// <returns>The response from the CreateDataCatalog service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateDataCatalog">REST API Reference for CreateDataCatalog Operation</seealso>
        public virtual CreateDataCatalogResponse CreateDataCatalog(CreateDataCatalogRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataCatalogResponseUnmarshaller.Instance;

            return Invoke<CreateDataCatalogResponse>(request, options);
        }


        /// <summary>
        /// Creates (registers) a data catalog with the specified name and properties. Catalogs
        /// created are visible to all users of the same Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataCatalog service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateDataCatalog">REST API Reference for CreateDataCatalog Operation</seealso>
        public virtual Task<CreateDataCatalogResponse> CreateDataCatalogAsync(CreateDataCatalogRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataCatalogResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDataCatalogResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNamedQuery


        /// <summary>
        /// Creates a named query in the specified workgroup. Requires that you have access to
        /// the workgroup.
        /// 
        ///  
        /// <para>
        /// For code samples using the Amazon Web Services SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
        /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNamedQuery service method.</param>
        /// 
        /// <returns>The response from the CreateNamedQuery service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateNamedQuery">REST API Reference for CreateNamedQuery Operation</seealso>
        public virtual CreateNamedQueryResponse CreateNamedQuery(CreateNamedQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNamedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNamedQueryResponseUnmarshaller.Instance;

            return Invoke<CreateNamedQueryResponse>(request, options);
        }


        /// <summary>
        /// Creates a named query in the specified workgroup. Requires that you have access to
        /// the workgroup.
        /// 
        ///  
        /// <para>
        /// For code samples using the Amazon Web Services SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
        /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNamedQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNamedQuery service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateNamedQuery">REST API Reference for CreateNamedQuery Operation</seealso>
        public virtual Task<CreateNamedQueryResponse> CreateNamedQueryAsync(CreateNamedQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNamedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNamedQueryResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateNamedQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNotebook


        /// <summary>
        /// Creates an empty <code>ipynb</code> file in the specified Apache Spark enabled workgroup.
        /// Throws an error if a file in the workgroup with the same name already exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebook service method.</param>
        /// 
        /// <returns>The response from the CreateNotebook service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateNotebook">REST API Reference for CreateNotebook Operation</seealso>
        public virtual CreateNotebookResponse CreateNotebook(CreateNotebookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotebookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotebookResponseUnmarshaller.Instance;

            return Invoke<CreateNotebookResponse>(request, options);
        }


        /// <summary>
        /// Creates an empty <code>ipynb</code> file in the specified Apache Spark enabled workgroup.
        /// Throws an error if a file in the workgroup with the same name already exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNotebook service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateNotebook">REST API Reference for CreateNotebook Operation</seealso>
        public virtual Task<CreateNotebookResponse> CreateNotebookAsync(CreateNotebookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotebookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotebookResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateNotebookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePreparedStatement


        /// <summary>
        /// Creates a prepared statement for use with SQL queries in Athena.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePreparedStatement service method.</param>
        /// 
        /// <returns>The response from the CreatePreparedStatement service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreatePreparedStatement">REST API Reference for CreatePreparedStatement Operation</seealso>
        public virtual CreatePreparedStatementResponse CreatePreparedStatement(CreatePreparedStatementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePreparedStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePreparedStatementResponseUnmarshaller.Instance;

            return Invoke<CreatePreparedStatementResponse>(request, options);
        }


        /// <summary>
        /// Creates a prepared statement for use with SQL queries in Athena.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePreparedStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePreparedStatement service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreatePreparedStatement">REST API Reference for CreatePreparedStatement Operation</seealso>
        public virtual Task<CreatePreparedStatementResponse> CreatePreparedStatementAsync(CreatePreparedStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePreparedStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePreparedStatementResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePreparedStatementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePresignedNotebookUrl


        /// <summary>
        /// Gets an authentication token and the URL at which the notebook can be accessed. During
        /// programmatic access, <code>CreatePresignedNotebookUrl</code> must be called every
        /// 10 minutes to refresh the authentication token.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedNotebookUrl service method.</param>
        /// 
        /// <returns>The response from the CreatePresignedNotebookUrl service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreatePresignedNotebookUrl">REST API Reference for CreatePresignedNotebookUrl Operation</seealso>
        public virtual CreatePresignedNotebookUrlResponse CreatePresignedNotebookUrl(CreatePresignedNotebookUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePresignedNotebookUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresignedNotebookUrlResponseUnmarshaller.Instance;

            return Invoke<CreatePresignedNotebookUrlResponse>(request, options);
        }


        /// <summary>
        /// Gets an authentication token and the URL at which the notebook can be accessed. During
        /// programmatic access, <code>CreatePresignedNotebookUrl</code> must be called every
        /// 10 minutes to refresh the authentication token.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedNotebookUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePresignedNotebookUrl service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreatePresignedNotebookUrl">REST API Reference for CreatePresignedNotebookUrl Operation</seealso>
        public virtual Task<CreatePresignedNotebookUrlResponse> CreatePresignedNotebookUrlAsync(CreatePresignedNotebookUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePresignedNotebookUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresignedNotebookUrlResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePresignedNotebookUrlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkGroup


        /// <summary>
        /// Creates a workgroup with the specified name. Only one of <code>Configurations</code>
        /// or <code>Configuration</code> can be specified; <code>Configurations</code> for a
        /// workgroup with multi engine support (for example, an Apache Spark enabled workgroup)
        /// or <code>Configuration</code> for an Athena SQL workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkGroup service method.</param>
        /// 
        /// <returns>The response from the CreateWorkGroup service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateWorkGroup">REST API Reference for CreateWorkGroup Operation</seealso>
        public virtual CreateWorkGroupResponse CreateWorkGroup(CreateWorkGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkGroupResponseUnmarshaller.Instance;

            return Invoke<CreateWorkGroupResponse>(request, options);
        }


        /// <summary>
        /// Creates a workgroup with the specified name. Only one of <code>Configurations</code>
        /// or <code>Configuration</code> can be specified; <code>Configurations</code> for a
        /// workgroup with multi engine support (for example, an Apache Spark enabled workgroup)
        /// or <code>Configuration</code> for an Athena SQL workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkGroup service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateWorkGroup">REST API Reference for CreateWorkGroup Operation</seealso>
        public virtual Task<CreateWorkGroupResponse> CreateWorkGroupAsync(CreateWorkGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateWorkGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataCatalog


        /// <summary>
        /// Deletes a data catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataCatalog service method.</param>
        /// 
        /// <returns>The response from the DeleteDataCatalog service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteDataCatalog">REST API Reference for DeleteDataCatalog Operation</seealso>
        public virtual DeleteDataCatalogResponse DeleteDataCatalog(DeleteDataCatalogRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataCatalogResponseUnmarshaller.Instance;

            return Invoke<DeleteDataCatalogResponse>(request, options);
        }


        /// <summary>
        /// Deletes a data catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataCatalog service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteDataCatalog">REST API Reference for DeleteDataCatalog Operation</seealso>
        public virtual Task<DeleteDataCatalogResponse> DeleteDataCatalogAsync(DeleteDataCatalogRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataCatalogResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDataCatalogResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNamedQuery


        /// <summary>
        /// Deletes the named query if you have access to the workgroup in which the query was
        /// saved.
        /// 
        ///  
        /// <para>
        /// For code samples using the Amazon Web Services SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
        /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamedQuery service method.</param>
        /// 
        /// <returns>The response from the DeleteNamedQuery service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteNamedQuery">REST API Reference for DeleteNamedQuery Operation</seealso>
        public virtual DeleteNamedQueryResponse DeleteNamedQuery(DeleteNamedQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNamedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamedQueryResponseUnmarshaller.Instance;

            return Invoke<DeleteNamedQueryResponse>(request, options);
        }


        /// <summary>
        /// Deletes the named query if you have access to the workgroup in which the query was
        /// saved.
        /// 
        ///  
        /// <para>
        /// For code samples using the Amazon Web Services SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
        /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamedQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNamedQuery service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteNamedQuery">REST API Reference for DeleteNamedQuery Operation</seealso>
        public virtual Task<DeleteNamedQueryResponse> DeleteNamedQueryAsync(DeleteNamedQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNamedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamedQueryResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteNamedQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNotebook


        /// <summary>
        /// Deletes the specified notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebook service method.</param>
        /// 
        /// <returns>The response from the DeleteNotebook service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteNotebook">REST API Reference for DeleteNotebook Operation</seealso>
        public virtual DeleteNotebookResponse DeleteNotebook(DeleteNotebookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotebookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotebookResponseUnmarshaller.Instance;

            return Invoke<DeleteNotebookResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNotebook service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteNotebook">REST API Reference for DeleteNotebook Operation</seealso>
        public virtual Task<DeleteNotebookResponse> DeleteNotebookAsync(DeleteNotebookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotebookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotebookResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteNotebookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePreparedStatement


        /// <summary>
        /// Deletes the prepared statement with the specified name from the specified workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePreparedStatement service method.</param>
        /// 
        /// <returns>The response from the DeletePreparedStatement service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeletePreparedStatement">REST API Reference for DeletePreparedStatement Operation</seealso>
        public virtual DeletePreparedStatementResponse DeletePreparedStatement(DeletePreparedStatementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePreparedStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePreparedStatementResponseUnmarshaller.Instance;

            return Invoke<DeletePreparedStatementResponse>(request, options);
        }


        /// <summary>
        /// Deletes the prepared statement with the specified name from the specified workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePreparedStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePreparedStatement service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeletePreparedStatement">REST API Reference for DeletePreparedStatement Operation</seealso>
        public virtual Task<DeletePreparedStatementResponse> DeletePreparedStatementAsync(DeletePreparedStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePreparedStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePreparedStatementResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePreparedStatementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkGroup


        /// <summary>
        /// Deletes the workgroup with the specified name. The primary workgroup cannot be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkGroup service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteWorkGroup">REST API Reference for DeleteWorkGroup Operation</seealso>
        public virtual DeleteWorkGroupResponse DeleteWorkGroup(DeleteWorkGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkGroupResponse>(request, options);
        }


        /// <summary>
        /// Deletes the workgroup with the specified name. The primary workgroup cannot be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkGroup service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteWorkGroup">REST API Reference for DeleteWorkGroup Operation</seealso>
        public virtual Task<DeleteWorkGroupResponse> DeleteWorkGroupAsync(DeleteWorkGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteWorkGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportNotebook


        /// <summary>
        /// Exports the specified notebook and its metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportNotebook service method.</param>
        /// 
        /// <returns>The response from the ExportNotebook service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ExportNotebook">REST API Reference for ExportNotebook Operation</seealso>
        public virtual ExportNotebookResponse ExportNotebook(ExportNotebookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportNotebookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportNotebookResponseUnmarshaller.Instance;

            return Invoke<ExportNotebookResponse>(request, options);
        }


        /// <summary>
        /// Exports the specified notebook and its metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportNotebook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportNotebook service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ExportNotebook">REST API Reference for ExportNotebook Operation</seealso>
        public virtual Task<ExportNotebookResponse> ExportNotebookAsync(ExportNotebookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportNotebookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportNotebookResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExportNotebookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCalculationExecution


        /// <summary>
        /// Describes a previously submitted calculation execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculationExecution service method.</param>
        /// 
        /// <returns>The response from the GetCalculationExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetCalculationExecution">REST API Reference for GetCalculationExecution Operation</seealso>
        public virtual GetCalculationExecutionResponse GetCalculationExecution(GetCalculationExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCalculationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCalculationExecutionResponseUnmarshaller.Instance;

            return Invoke<GetCalculationExecutionResponse>(request, options);
        }


        /// <summary>
        /// Describes a previously submitted calculation execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculationExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCalculationExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetCalculationExecution">REST API Reference for GetCalculationExecution Operation</seealso>
        public virtual Task<GetCalculationExecutionResponse> GetCalculationExecutionAsync(GetCalculationExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCalculationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCalculationExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCalculationExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCalculationExecutionCode


        /// <summary>
        /// Retrieves a pre-signed URL to a copy of the code that was executed for the calculation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculationExecutionCode service method.</param>
        /// 
        /// <returns>The response from the GetCalculationExecutionCode service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetCalculationExecutionCode">REST API Reference for GetCalculationExecutionCode Operation</seealso>
        public virtual GetCalculationExecutionCodeResponse GetCalculationExecutionCode(GetCalculationExecutionCodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCalculationExecutionCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCalculationExecutionCodeResponseUnmarshaller.Instance;

            return Invoke<GetCalculationExecutionCodeResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a pre-signed URL to a copy of the code that was executed for the calculation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculationExecutionCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCalculationExecutionCode service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetCalculationExecutionCode">REST API Reference for GetCalculationExecutionCode Operation</seealso>
        public virtual Task<GetCalculationExecutionCodeResponse> GetCalculationExecutionCodeAsync(GetCalculationExecutionCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCalculationExecutionCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCalculationExecutionCodeResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCalculationExecutionCodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCalculationExecutionStatus


        /// <summary>
        /// Gets the status of a current calculation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculationExecutionStatus service method.</param>
        /// 
        /// <returns>The response from the GetCalculationExecutionStatus service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetCalculationExecutionStatus">REST API Reference for GetCalculationExecutionStatus Operation</seealso>
        public virtual GetCalculationExecutionStatusResponse GetCalculationExecutionStatus(GetCalculationExecutionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCalculationExecutionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCalculationExecutionStatusResponseUnmarshaller.Instance;

            return Invoke<GetCalculationExecutionStatusResponse>(request, options);
        }


        /// <summary>
        /// Gets the status of a current calculation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculationExecutionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCalculationExecutionStatus service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetCalculationExecutionStatus">REST API Reference for GetCalculationExecutionStatus Operation</seealso>
        public virtual Task<GetCalculationExecutionStatusResponse> GetCalculationExecutionStatusAsync(GetCalculationExecutionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCalculationExecutionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCalculationExecutionStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCalculationExecutionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDatabase


        /// <summary>
        /// Returns a database object for the specified database and data catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase service method.</param>
        /// 
        /// <returns>The response from the GetDatabase service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.MetadataException">
        /// An exception that Athena received when it called a custom metastore. Occurs if the
        /// error is not caused by user input (<code>InvalidRequestException</code>) or from the
        /// Athena platform (<code>InternalServerException</code>). For example, if a user-created
        /// Lambda function is missing permissions, the Lambda <code>4XX</code> exception is returned
        /// in a <code>MetadataException</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        public virtual GetDatabaseResponse GetDatabase(GetDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatabaseResponseUnmarshaller.Instance;

            return Invoke<GetDatabaseResponse>(request, options);
        }


        /// <summary>
        /// Returns a database object for the specified database and data catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDatabase service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.MetadataException">
        /// An exception that Athena received when it called a custom metastore. Occurs if the
        /// error is not caused by user input (<code>InvalidRequestException</code>) or from the
        /// Athena platform (<code>InternalServerException</code>). For example, if a user-created
        /// Lambda function is missing permissions, the Lambda <code>4XX</code> exception is returned
        /// in a <code>MetadataException</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        public virtual Task<GetDatabaseResponse> GetDatabaseAsync(GetDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatabaseResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataCatalog


        /// <summary>
        /// Returns the specified data catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataCatalog service method.</param>
        /// 
        /// <returns>The response from the GetDataCatalog service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetDataCatalog">REST API Reference for GetDataCatalog Operation</seealso>
        public virtual GetDataCatalogResponse GetDataCatalog(GetDataCatalogRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataCatalogResponseUnmarshaller.Instance;

            return Invoke<GetDataCatalogResponse>(request, options);
        }


        /// <summary>
        /// Returns the specified data catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataCatalog service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetDataCatalog">REST API Reference for GetDataCatalog Operation</seealso>
        public virtual Task<GetDataCatalogResponse> GetDataCatalogAsync(GetDataCatalogRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataCatalogResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDataCatalogResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNamedQuery


        /// <summary>
        /// Returns information about a single query. Requires that you have access to the workgroup
        /// in which the query was saved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNamedQuery service method.</param>
        /// 
        /// <returns>The response from the GetNamedQuery service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetNamedQuery">REST API Reference for GetNamedQuery Operation</seealso>
        public virtual GetNamedQueryResponse GetNamedQuery(GetNamedQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNamedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamedQueryResponseUnmarshaller.Instance;

            return Invoke<GetNamedQueryResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a single query. Requires that you have access to the workgroup
        /// in which the query was saved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNamedQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNamedQuery service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetNamedQuery">REST API Reference for GetNamedQuery Operation</seealso>
        public virtual Task<GetNamedQueryResponse> GetNamedQueryAsync(GetNamedQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNamedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamedQueryResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetNamedQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNotebookMetadata


        /// <summary>
        /// Retrieves notebook metadata for the specified notebook ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotebookMetadata service method.</param>
        /// 
        /// <returns>The response from the GetNotebookMetadata service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetNotebookMetadata">REST API Reference for GetNotebookMetadata Operation</seealso>
        public virtual GetNotebookMetadataResponse GetNotebookMetadata(GetNotebookMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNotebookMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotebookMetadataResponseUnmarshaller.Instance;

            return Invoke<GetNotebookMetadataResponse>(request, options);
        }


        /// <summary>
        /// Retrieves notebook metadata for the specified notebook ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotebookMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNotebookMetadata service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetNotebookMetadata">REST API Reference for GetNotebookMetadata Operation</seealso>
        public virtual Task<GetNotebookMetadataResponse> GetNotebookMetadataAsync(GetNotebookMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNotebookMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotebookMetadataResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetNotebookMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPreparedStatement


        /// <summary>
        /// Retrieves the prepared statement with the specified name from the specified workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPreparedStatement service method.</param>
        /// 
        /// <returns>The response from the GetPreparedStatement service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetPreparedStatement">REST API Reference for GetPreparedStatement Operation</seealso>
        public virtual GetPreparedStatementResponse GetPreparedStatement(GetPreparedStatementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPreparedStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPreparedStatementResponseUnmarshaller.Instance;

            return Invoke<GetPreparedStatementResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the prepared statement with the specified name from the specified workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPreparedStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPreparedStatement service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetPreparedStatement">REST API Reference for GetPreparedStatement Operation</seealso>
        public virtual Task<GetPreparedStatementResponse> GetPreparedStatementAsync(GetPreparedStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPreparedStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPreparedStatementResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPreparedStatementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQueryExecution


        /// <summary>
        /// Returns information about a single execution of a query if you have access to the
        /// workgroup in which the query ran. Each time a query executes, information about the
        /// query execution is saved with a unique ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryExecution service method.</param>
        /// 
        /// <returns>The response from the GetQueryExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetQueryExecution">REST API Reference for GetQueryExecution Operation</seealso>
        public virtual GetQueryExecutionResponse GetQueryExecution(GetQueryExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueryExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryExecutionResponseUnmarshaller.Instance;

            return Invoke<GetQueryExecutionResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a single execution of a query if you have access to the
        /// workgroup in which the query ran. Each time a query executes, information about the
        /// query execution is saved with a unique ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueryExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetQueryExecution">REST API Reference for GetQueryExecution Operation</seealso>
        public virtual Task<GetQueryExecutionResponse> GetQueryExecutionAsync(GetQueryExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueryExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetQueryExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQueryResults


        /// <summary>
        /// Streams the results of a single query execution specified by <code>QueryExecutionId</code>
        /// from the Athena query results location in Amazon S3. For more information, see <a
        /// href="https://docs.aws.amazon.com/athena/latest/ug/querying.html">Query Results</a>
        /// in the <i>Amazon Athena User Guide</i>. This request does not execute the query but
        /// returns results. Use <a>StartQueryExecution</a> to run a query.
        /// 
        ///  
        /// <para>
        /// To stream query results successfully, the IAM principal with permission to call <code>GetQueryResults</code>
        /// also must have permissions to the Amazon S3 <code>GetObject</code> action for the
        /// Athena query results location.
        /// </para>
        ///  <important> 
        /// <para>
        /// IAM principals with permission to the Amazon S3 <code>GetObject</code> action for
        /// the query results location are able to retrieve query results from Amazon S3 even
        /// if permission to the <code>GetQueryResults</code> action is denied. To restrict user
        /// or role access, ensure that Amazon S3 permissions to the Athena query location are
        /// denied.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResults service method.</param>
        /// 
        /// <returns>The response from the GetQueryResults service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetQueryResults">REST API Reference for GetQueryResults Operation</seealso>
        public virtual GetQueryResultsResponse GetQueryResults(GetQueryResultsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueryResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsResponseUnmarshaller.Instance;

            return Invoke<GetQueryResultsResponse>(request, options);
        }


        /// <summary>
        /// Streams the results of a single query execution specified by <code>QueryExecutionId</code>
        /// from the Athena query results location in Amazon S3. For more information, see <a
        /// href="https://docs.aws.amazon.com/athena/latest/ug/querying.html">Query Results</a>
        /// in the <i>Amazon Athena User Guide</i>. This request does not execute the query but
        /// returns results. Use <a>StartQueryExecution</a> to run a query.
        /// 
        ///  
        /// <para>
        /// To stream query results successfully, the IAM principal with permission to call <code>GetQueryResults</code>
        /// also must have permissions to the Amazon S3 <code>GetObject</code> action for the
        /// Athena query results location.
        /// </para>
        ///  <important> 
        /// <para>
        /// IAM principals with permission to the Amazon S3 <code>GetObject</code> action for
        /// the query results location are able to retrieve query results from Amazon S3 even
        /// if permission to the <code>GetQueryResults</code> action is denied. To restrict user
        /// or role access, ensure that Amazon S3 permissions to the Athena query location are
        /// denied.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueryResults service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetQueryResults">REST API Reference for GetQueryResults Operation</seealso>
        public virtual Task<GetQueryResultsResponse> GetQueryResultsAsync(GetQueryResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueryResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetQueryResultsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQueryRuntimeStatistics


        /// <summary>
        /// Returns query execution runtime statistics related to a single execution of a query
        /// if you have access to the workgroup in which the query ran. Query execution runtime
        /// statistics are returned only when <a>QueryExecutionStatus$State</a> is in a SUCCEEDED
        /// or FAILED state. Stage-level input and output row count and data size statistics are
        /// not shown when a query has row-level filters defined in Lake Formation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryRuntimeStatistics service method.</param>
        /// 
        /// <returns>The response from the GetQueryRuntimeStatistics service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetQueryRuntimeStatistics">REST API Reference for GetQueryRuntimeStatistics Operation</seealso>
        public virtual GetQueryRuntimeStatisticsResponse GetQueryRuntimeStatistics(GetQueryRuntimeStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueryRuntimeStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryRuntimeStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetQueryRuntimeStatisticsResponse>(request, options);
        }


        /// <summary>
        /// Returns query execution runtime statistics related to a single execution of a query
        /// if you have access to the workgroup in which the query ran. Query execution runtime
        /// statistics are returned only when <a>QueryExecutionStatus$State</a> is in a SUCCEEDED
        /// or FAILED state. Stage-level input and output row count and data size statistics are
        /// not shown when a query has row-level filters defined in Lake Formation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryRuntimeStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueryRuntimeStatistics service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetQueryRuntimeStatistics">REST API Reference for GetQueryRuntimeStatistics Operation</seealso>
        public virtual Task<GetQueryRuntimeStatisticsResponse> GetQueryRuntimeStatisticsAsync(GetQueryRuntimeStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueryRuntimeStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryRuntimeStatisticsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetQueryRuntimeStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSession


        /// <summary>
        /// Gets the full details of a previously created session, including the session status
        /// and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual GetSessionResponse GetSession(GetSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return Invoke<GetSessionResponse>(request, options);
        }


        /// <summary>
        /// Gets the full details of a previously created session, including the session status
        /// and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual Task<GetSessionResponse> GetSessionAsync(GetSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSessionStatus


        /// <summary>
        /// Gets the current status of a session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionStatus service method.</param>
        /// 
        /// <returns>The response from the GetSessionStatus service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetSessionStatus">REST API Reference for GetSessionStatus Operation</seealso>
        public virtual GetSessionStatusResponse GetSessionStatus(GetSessionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionStatusResponseUnmarshaller.Instance;

            return Invoke<GetSessionStatusResponse>(request, options);
        }


        /// <summary>
        /// Gets the current status of a session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSessionStatus service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetSessionStatus">REST API Reference for GetSessionStatus Operation</seealso>
        public virtual Task<GetSessionStatusResponse> GetSessionStatusAsync(GetSessionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSessionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTableMetadata


        /// <summary>
        /// Returns table metadata for the specified catalog, database, and table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableMetadata service method.</param>
        /// 
        /// <returns>The response from the GetTableMetadata service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.MetadataException">
        /// An exception that Athena received when it called a custom metastore. Occurs if the
        /// error is not caused by user input (<code>InvalidRequestException</code>) or from the
        /// Athena platform (<code>InternalServerException</code>). For example, if a user-created
        /// Lambda function is missing permissions, the Lambda <code>4XX</code> exception is returned
        /// in a <code>MetadataException</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetTableMetadata">REST API Reference for GetTableMetadata Operation</seealso>
        public virtual GetTableMetadataResponse GetTableMetadata(GetTableMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableMetadataResponseUnmarshaller.Instance;

            return Invoke<GetTableMetadataResponse>(request, options);
        }


        /// <summary>
        /// Returns table metadata for the specified catalog, database, and table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableMetadata service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.MetadataException">
        /// An exception that Athena received when it called a custom metastore. Occurs if the
        /// error is not caused by user input (<code>InvalidRequestException</code>) or from the
        /// Athena platform (<code>InternalServerException</code>). For example, if a user-created
        /// Lambda function is missing permissions, the Lambda <code>4XX</code> exception is returned
        /// in a <code>MetadataException</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetTableMetadata">REST API Reference for GetTableMetadata Operation</seealso>
        public virtual Task<GetTableMetadataResponse> GetTableMetadataAsync(GetTableMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableMetadataResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTableMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWorkGroup


        /// <summary>
        /// Returns information about the workgroup with the specified name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkGroup service method.</param>
        /// 
        /// <returns>The response from the GetWorkGroup service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetWorkGroup">REST API Reference for GetWorkGroup Operation</seealso>
        public virtual GetWorkGroupResponse GetWorkGroup(GetWorkGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkGroupResponseUnmarshaller.Instance;

            return Invoke<GetWorkGroupResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the workgroup with the specified name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkGroup service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetWorkGroup">REST API Reference for GetWorkGroup Operation</seealso>
        public virtual Task<GetWorkGroupResponse> GetWorkGroupAsync(GetWorkGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetWorkGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportNotebook


        /// <summary>
        /// Imports a single <code>ipynb</code> file to a Spark enabled workgroup. The maximum
        /// file size that can be imported is 10 megabytes. If an <code>ipynb</code> file with
        /// the same name already exists in the workgroup, throws an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportNotebook service method.</param>
        /// 
        /// <returns>The response from the ImportNotebook service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ImportNotebook">REST API Reference for ImportNotebook Operation</seealso>
        public virtual ImportNotebookResponse ImportNotebook(ImportNotebookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportNotebookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportNotebookResponseUnmarshaller.Instance;

            return Invoke<ImportNotebookResponse>(request, options);
        }


        /// <summary>
        /// Imports a single <code>ipynb</code> file to a Spark enabled workgroup. The maximum
        /// file size that can be imported is 10 megabytes. If an <code>ipynb</code> file with
        /// the same name already exists in the workgroup, throws an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportNotebook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportNotebook service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ImportNotebook">REST API Reference for ImportNotebook Operation</seealso>
        public virtual Task<ImportNotebookResponse> ImportNotebookAsync(ImportNotebookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportNotebookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportNotebookResponseUnmarshaller.Instance;
            
            return InvokeAsync<ImportNotebookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplicationDPUSizes


        /// <summary>
        /// Returns the supported DPU sizes for the supported application runtimes (for example,
        /// <code>Jupyter 1.0</code>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationDPUSizes service method.</param>
        /// 
        /// <returns>The response from the ListApplicationDPUSizes service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListApplicationDPUSizes">REST API Reference for ListApplicationDPUSizes Operation</seealso>
        public virtual ListApplicationDPUSizesResponse ListApplicationDPUSizes(ListApplicationDPUSizesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationDPUSizesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationDPUSizesResponseUnmarshaller.Instance;

            return Invoke<ListApplicationDPUSizesResponse>(request, options);
        }


        /// <summary>
        /// Returns the supported DPU sizes for the supported application runtimes (for example,
        /// <code>Jupyter 1.0</code>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationDPUSizes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationDPUSizes service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListApplicationDPUSizes">REST API Reference for ListApplicationDPUSizes Operation</seealso>
        public virtual Task<ListApplicationDPUSizesResponse> ListApplicationDPUSizesAsync(ListApplicationDPUSizesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationDPUSizesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationDPUSizesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListApplicationDPUSizesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCalculationExecutions


        /// <summary>
        /// Lists the calculations that have been submitted to a session in descending order.
        /// Newer calculations are listed first; older calculations are listed later.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCalculationExecutions service method.</param>
        /// 
        /// <returns>The response from the ListCalculationExecutions service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListCalculationExecutions">REST API Reference for ListCalculationExecutions Operation</seealso>
        public virtual ListCalculationExecutionsResponse ListCalculationExecutions(ListCalculationExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCalculationExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCalculationExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListCalculationExecutionsResponse>(request, options);
        }


        /// <summary>
        /// Lists the calculations that have been submitted to a session in descending order.
        /// Newer calculations are listed first; older calculations are listed later.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCalculationExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCalculationExecutions service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListCalculationExecutions">REST API Reference for ListCalculationExecutions Operation</seealso>
        public virtual Task<ListCalculationExecutionsResponse> ListCalculationExecutionsAsync(ListCalculationExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCalculationExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCalculationExecutionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCalculationExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDatabases


        /// <summary>
        /// Lists the databases in the specified data catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases service method.</param>
        /// 
        /// <returns>The response from the ListDatabases service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.MetadataException">
        /// An exception that Athena received when it called a custom metastore. Occurs if the
        /// error is not caused by user input (<code>InvalidRequestException</code>) or from the
        /// Athena platform (<code>InternalServerException</code>). For example, if a user-created
        /// Lambda function is missing permissions, the Lambda <code>4XX</code> exception is returned
        /// in a <code>MetadataException</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        public virtual ListDatabasesResponse ListDatabases(ListDatabasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatabasesResponseUnmarshaller.Instance;

            return Invoke<ListDatabasesResponse>(request, options);
        }


        /// <summary>
        /// Lists the databases in the specified data catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatabases service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.MetadataException">
        /// An exception that Athena received when it called a custom metastore. Occurs if the
        /// error is not caused by user input (<code>InvalidRequestException</code>) or from the
        /// Athena platform (<code>InternalServerException</code>). For example, if a user-created
        /// Lambda function is missing permissions, the Lambda <code>4XX</code> exception is returned
        /// in a <code>MetadataException</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        public virtual Task<ListDatabasesResponse> ListDatabasesAsync(ListDatabasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatabasesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDatabasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataCatalogs


        /// <summary>
        /// Lists the data catalogs in the current Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// In the Athena console, data catalogs are listed as "data sources" on the <b>Data sources</b>
        /// page under the <b>Data source name</b> column.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataCatalogs service method.</param>
        /// 
        /// <returns>The response from the ListDataCatalogs service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListDataCatalogs">REST API Reference for ListDataCatalogs Operation</seealso>
        public virtual ListDataCatalogsResponse ListDataCatalogs(ListDataCatalogsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataCatalogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataCatalogsResponseUnmarshaller.Instance;

            return Invoke<ListDataCatalogsResponse>(request, options);
        }


        /// <summary>
        /// Lists the data catalogs in the current Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// In the Athena console, data catalogs are listed as "data sources" on the <b>Data sources</b>
        /// page under the <b>Data source name</b> column.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataCatalogs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataCatalogs service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListDataCatalogs">REST API Reference for ListDataCatalogs Operation</seealso>
        public virtual Task<ListDataCatalogsResponse> ListDataCatalogsAsync(ListDataCatalogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataCatalogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataCatalogsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDataCatalogsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEngineVersions


        /// <summary>
        /// Returns a list of engine versions that are available to choose from, including the
        /// Auto option.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEngineVersions service method.</param>
        /// 
        /// <returns>The response from the ListEngineVersions service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListEngineVersions">REST API Reference for ListEngineVersions Operation</seealso>
        public virtual ListEngineVersionsResponse ListEngineVersions(ListEngineVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngineVersionsResponseUnmarshaller.Instance;

            return Invoke<ListEngineVersionsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of engine versions that are available to choose from, including the
        /// Auto option.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEngineVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEngineVersions service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListEngineVersions">REST API Reference for ListEngineVersions Operation</seealso>
        public virtual Task<ListEngineVersionsResponse> ListEngineVersionsAsync(ListEngineVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngineVersionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEngineVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListExecutors


        /// <summary>
        /// Lists, in descending order, the executors that have been submitted to a session. Newer
        /// executors are listed first; older executors are listed later. The result can be optionally
        /// filtered by state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutors service method.</param>
        /// 
        /// <returns>The response from the ListExecutors service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListExecutors">REST API Reference for ListExecutors Operation</seealso>
        public virtual ListExecutorsResponse ListExecutors(ListExecutorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExecutorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExecutorsResponseUnmarshaller.Instance;

            return Invoke<ListExecutorsResponse>(request, options);
        }


        /// <summary>
        /// Lists, in descending order, the executors that have been submitted to a session. Newer
        /// executors are listed first; older executors are listed later. The result can be optionally
        /// filtered by state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExecutors service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListExecutors">REST API Reference for ListExecutors Operation</seealso>
        public virtual Task<ListExecutorsResponse> ListExecutorsAsync(ListExecutorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExecutorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExecutorsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListExecutorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNamedQueries


        /// <summary>
        /// Provides a list of available query IDs only for queries saved in the specified workgroup.
        /// Requires that you have access to the specified workgroup. If a workgroup is not specified,
        /// lists the saved queries for the primary workgroup.
        /// 
        ///  
        /// <para>
        /// For code samples using the Amazon Web Services SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
        /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamedQueries service method.</param>
        /// 
        /// <returns>The response from the ListNamedQueries service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListNamedQueries">REST API Reference for ListNamedQueries Operation</seealso>
        public virtual ListNamedQueriesResponse ListNamedQueries(ListNamedQueriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNamedQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamedQueriesResponseUnmarshaller.Instance;

            return Invoke<ListNamedQueriesResponse>(request, options);
        }


        /// <summary>
        /// Provides a list of available query IDs only for queries saved in the specified workgroup.
        /// Requires that you have access to the specified workgroup. If a workgroup is not specified,
        /// lists the saved queries for the primary workgroup.
        /// 
        ///  
        /// <para>
        /// For code samples using the Amazon Web Services SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
        /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamedQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNamedQueries service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListNamedQueries">REST API Reference for ListNamedQueries Operation</seealso>
        public virtual Task<ListNamedQueriesResponse> ListNamedQueriesAsync(ListNamedQueriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNamedQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamedQueriesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListNamedQueriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNotebookMetadata


        /// <summary>
        /// Displays the notebook files for the specified workgroup in paginated format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookMetadata service method.</param>
        /// 
        /// <returns>The response from the ListNotebookMetadata service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListNotebookMetadata">REST API Reference for ListNotebookMetadata Operation</seealso>
        public virtual ListNotebookMetadataResponse ListNotebookMetadata(ListNotebookMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookMetadataResponseUnmarshaller.Instance;

            return Invoke<ListNotebookMetadataResponse>(request, options);
        }


        /// <summary>
        /// Displays the notebook files for the specified workgroup in paginated format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotebookMetadata service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListNotebookMetadata">REST API Reference for ListNotebookMetadata Operation</seealso>
        public virtual Task<ListNotebookMetadataResponse> ListNotebookMetadataAsync(ListNotebookMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookMetadataResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListNotebookMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNotebookSessions


        /// <summary>
        /// Lists, in descending order, the sessions that have been created in a notebook that
        /// are in an active state like <code>CREATING</code>, <code>CREATED</code>, <code>IDLE</code>
        /// or <code>BUSY</code>. Newer sessions are listed first; older sessions are listed later.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookSessions service method.</param>
        /// 
        /// <returns>The response from the ListNotebookSessions service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListNotebookSessions">REST API Reference for ListNotebookSessions Operation</seealso>
        public virtual ListNotebookSessionsResponse ListNotebookSessions(ListNotebookSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookSessionsResponseUnmarshaller.Instance;

            return Invoke<ListNotebookSessionsResponse>(request, options);
        }


        /// <summary>
        /// Lists, in descending order, the sessions that have been created in a notebook that
        /// are in an active state like <code>CREATING</code>, <code>CREATED</code>, <code>IDLE</code>
        /// or <code>BUSY</code>. Newer sessions are listed first; older sessions are listed later.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotebookSessions service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListNotebookSessions">REST API Reference for ListNotebookSessions Operation</seealso>
        public virtual Task<ListNotebookSessionsResponse> ListNotebookSessionsAsync(ListNotebookSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookSessionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListNotebookSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPreparedStatements


        /// <summary>
        /// Lists the prepared statements in the specified workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPreparedStatements service method.</param>
        /// 
        /// <returns>The response from the ListPreparedStatements service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListPreparedStatements">REST API Reference for ListPreparedStatements Operation</seealso>
        public virtual ListPreparedStatementsResponse ListPreparedStatements(ListPreparedStatementsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPreparedStatementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPreparedStatementsResponseUnmarshaller.Instance;

            return Invoke<ListPreparedStatementsResponse>(request, options);
        }


        /// <summary>
        /// Lists the prepared statements in the specified workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPreparedStatements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPreparedStatements service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListPreparedStatements">REST API Reference for ListPreparedStatements Operation</seealso>
        public virtual Task<ListPreparedStatementsResponse> ListPreparedStatementsAsync(ListPreparedStatementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPreparedStatementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPreparedStatementsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPreparedStatementsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListQueryExecutions


        /// <summary>
        /// Provides a list of available query execution IDs for the queries in the specified
        /// workgroup. If a workgroup is not specified, returns a list of query execution IDs
        /// for the primary workgroup. Requires you to have access to the workgroup in which the
        /// queries ran.
        /// 
        ///  
        /// <para>
        /// For code samples using the Amazon Web Services SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
        /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueryExecutions service method.</param>
        /// 
        /// <returns>The response from the ListQueryExecutions service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListQueryExecutions">REST API Reference for ListQueryExecutions Operation</seealso>
        public virtual ListQueryExecutionsResponse ListQueryExecutions(ListQueryExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueryExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueryExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListQueryExecutionsResponse>(request, options);
        }


        /// <summary>
        /// Provides a list of available query execution IDs for the queries in the specified
        /// workgroup. If a workgroup is not specified, returns a list of query execution IDs
        /// for the primary workgroup. Requires you to have access to the workgroup in which the
        /// queries ran.
        /// 
        ///  
        /// <para>
        /// For code samples using the Amazon Web Services SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
        /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueryExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueryExecutions service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListQueryExecutions">REST API Reference for ListQueryExecutions Operation</seealso>
        public virtual Task<ListQueryExecutionsResponse> ListQueryExecutionsAsync(ListQueryExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueryExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueryExecutionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListQueryExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSessions


        /// <summary>
        /// Lists the sessions in a workgroup that are in an active state like <code>CREATING</code>,
        /// <code>CREATED</code>, <code>IDLE</code>, or <code>BUSY</code>. Newer sessions are
        /// listed first; older sessions are listed later.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// 
        /// <returns>The response from the ListSessions service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual ListSessionsResponse ListSessions(ListSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;

            return Invoke<ListSessionsResponse>(request, options);
        }


        /// <summary>
        /// Lists the sessions in a workgroup that are in an active state like <code>CREATING</code>,
        /// <code>CREATED</code>, <code>IDLE</code>, or <code>BUSY</code>. Newer sessions are
        /// listed first; older sessions are listed later.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSessions service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual Task<ListSessionsResponse> ListSessionsAsync(ListSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTableMetadata


        /// <summary>
        /// Lists the metadata for the tables in the specified data catalog database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTableMetadata service method.</param>
        /// 
        /// <returns>The response from the ListTableMetadata service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.MetadataException">
        /// An exception that Athena received when it called a custom metastore. Occurs if the
        /// error is not caused by user input (<code>InvalidRequestException</code>) or from the
        /// Athena platform (<code>InternalServerException</code>). For example, if a user-created
        /// Lambda function is missing permissions, the Lambda <code>4XX</code> exception is returned
        /// in a <code>MetadataException</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListTableMetadata">REST API Reference for ListTableMetadata Operation</seealso>
        public virtual ListTableMetadataResponse ListTableMetadata(ListTableMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTableMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableMetadataResponseUnmarshaller.Instance;

            return Invoke<ListTableMetadataResponse>(request, options);
        }


        /// <summary>
        /// Lists the metadata for the tables in the specified data catalog database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTableMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTableMetadata service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.MetadataException">
        /// An exception that Athena received when it called a custom metastore. Occurs if the
        /// error is not caused by user input (<code>InvalidRequestException</code>) or from the
        /// Athena platform (<code>InternalServerException</code>). For example, if a user-created
        /// Lambda function is missing permissions, the Lambda <code>4XX</code> exception is returned
        /// in a <code>MetadataException</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListTableMetadata">REST API Reference for ListTableMetadata Operation</seealso>
        public virtual Task<ListTableMetadataResponse> ListTableMetadataAsync(ListTableMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTableMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableMetadataResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTableMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags associated with an Athena workgroup or data catalog resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags associated with an Athena workgroup or data catalog resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkGroups


        /// <summary>
        /// Lists available workgroups for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkGroups service method.</param>
        /// 
        /// <returns>The response from the ListWorkGroups service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListWorkGroups">REST API Reference for ListWorkGroups Operation</seealso>
        public virtual ListWorkGroupsResponse ListWorkGroups(ListWorkGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkGroupsResponseUnmarshaller.Instance;

            return Invoke<ListWorkGroupsResponse>(request, options);
        }


        /// <summary>
        /// Lists available workgroups for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkGroups service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListWorkGroups">REST API Reference for ListWorkGroups Operation</seealso>
        public virtual Task<ListWorkGroupsResponse> ListWorkGroupsAsync(ListWorkGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListWorkGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartCalculationExecution


        /// <summary>
        /// Submits calculations for execution within a session. You can supply the code to run
        /// as an inline code block within the request or as an Amazon S3 URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCalculationExecution service method.</param>
        /// 
        /// <returns>The response from the StartCalculationExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StartCalculationExecution">REST API Reference for StartCalculationExecution Operation</seealso>
        public virtual StartCalculationExecutionResponse StartCalculationExecution(StartCalculationExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCalculationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCalculationExecutionResponseUnmarshaller.Instance;

            return Invoke<StartCalculationExecutionResponse>(request, options);
        }


        /// <summary>
        /// Submits calculations for execution within a session. You can supply the code to run
        /// as an inline code block within the request or as an Amazon S3 URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCalculationExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCalculationExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StartCalculationExecution">REST API Reference for StartCalculationExecution Operation</seealso>
        public virtual Task<StartCalculationExecutionResponse> StartCalculationExecutionAsync(StartCalculationExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCalculationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCalculationExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartCalculationExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartQueryExecution


        /// <summary>
        /// Runs the SQL query statements contained in the <code>Query</code>. Requires you to
        /// have access to the workgroup in which the query ran. Running queries against an external
        /// catalog requires <a>GetDataCatalog</a> permission to the catalog. For code samples
        /// using the Amazon Web Services SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
        /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQueryExecution service method.</param>
        /// 
        /// <returns>The response from the StartQueryExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StartQueryExecution">REST API Reference for StartQueryExecution Operation</seealso>
        public virtual StartQueryExecutionResponse StartQueryExecution(StartQueryExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartQueryExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryExecutionResponseUnmarshaller.Instance;

            return Invoke<StartQueryExecutionResponse>(request, options);
        }


        /// <summary>
        /// Runs the SQL query statements contained in the <code>Query</code>. Requires you to
        /// have access to the workgroup in which the query ran. Running queries against an external
        /// catalog requires <a>GetDataCatalog</a> permission to the catalog. For code samples
        /// using the Amazon Web Services SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
        /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQueryExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartQueryExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StartQueryExecution">REST API Reference for StartQueryExecution Operation</seealso>
        public virtual Task<StartQueryExecutionResponse> StartQueryExecutionAsync(StartQueryExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartQueryExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartQueryExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartSession


        /// <summary>
        /// Creates a session for running calculations within a workgroup. The session is ready
        /// when it reaches an <code>IDLE</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSession service method.</param>
        /// 
        /// <returns>The response from the StartSession service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.SessionAlreadyExistsException">
        /// The specified session already exists.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StartSession">REST API Reference for StartSession Operation</seealso>
        public virtual StartSessionResponse StartSession(StartSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSessionResponseUnmarshaller.Instance;

            return Invoke<StartSessionResponse>(request, options);
        }


        /// <summary>
        /// Creates a session for running calculations within a workgroup. The session is ready
        /// when it reaches an <code>IDLE</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSession service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.SessionAlreadyExistsException">
        /// The specified session already exists.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StartSession">REST API Reference for StartSession Operation</seealso>
        public virtual Task<StartSessionResponse> StartSessionAsync(StartSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopCalculationExecution


        /// <summary>
        /// Requests the cancellation of a calculation. A <code>StopCalculationExecution</code>
        /// call on a calculation that is already in a terminal state (for example, <code>STOPPED</code>,
        /// <code>FAILED</code>, or <code>COMPLETED</code>) succeeds but has no effect.
        /// 
        ///  <note> 
        /// <para>
        /// Cancelling a calculation is done on a best effort basis. If a calculation cannot be
        /// cancelled, you can be charged for its completion. If you are concerned about being
        /// charged for a calculation that cannot be cancelled, consider terminating the session
        /// in which the calculation is running.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCalculationExecution service method.</param>
        /// 
        /// <returns>The response from the StopCalculationExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StopCalculationExecution">REST API Reference for StopCalculationExecution Operation</seealso>
        public virtual StopCalculationExecutionResponse StopCalculationExecution(StopCalculationExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCalculationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCalculationExecutionResponseUnmarshaller.Instance;

            return Invoke<StopCalculationExecutionResponse>(request, options);
        }


        /// <summary>
        /// Requests the cancellation of a calculation. A <code>StopCalculationExecution</code>
        /// call on a calculation that is already in a terminal state (for example, <code>STOPPED</code>,
        /// <code>FAILED</code>, or <code>COMPLETED</code>) succeeds but has no effect.
        /// 
        ///  <note> 
        /// <para>
        /// Cancelling a calculation is done on a best effort basis. If a calculation cannot be
        /// cancelled, you can be charged for its completion. If you are concerned about being
        /// charged for a calculation that cannot be cancelled, consider terminating the session
        /// in which the calculation is running.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCalculationExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopCalculationExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StopCalculationExecution">REST API Reference for StopCalculationExecution Operation</seealso>
        public virtual Task<StopCalculationExecutionResponse> StopCalculationExecutionAsync(StopCalculationExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCalculationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCalculationExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopCalculationExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopQueryExecution


        /// <summary>
        /// Stops a query execution. Requires you to have access to the workgroup in which the
        /// query ran.
        /// 
        ///  
        /// <para>
        /// For code samples using the Amazon Web Services SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
        /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQueryExecution service method.</param>
        /// 
        /// <returns>The response from the StopQueryExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StopQueryExecution">REST API Reference for StopQueryExecution Operation</seealso>
        public virtual StopQueryExecutionResponse StopQueryExecution(StopQueryExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopQueryExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryExecutionResponseUnmarshaller.Instance;

            return Invoke<StopQueryExecutionResponse>(request, options);
        }


        /// <summary>
        /// Stops a query execution. Requires you to have access to the workgroup in which the
        /// query ran.
        /// 
        ///  
        /// <para>
        /// For code samples using the Amazon Web Services SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
        /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQueryExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopQueryExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StopQueryExecution">REST API Reference for StopQueryExecution Operation</seealso>
        public virtual Task<StopQueryExecutionResponse> StopQueryExecutionAsync(StopQueryExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopQueryExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryExecutionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopQueryExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags to an Athena resource. A tag is a label that you assign to a
        /// resource. In Athena, a resource can be a workgroup or data catalog. Each tag consists
        /// of a key and an optional value, both of which you define. For example, you can use
        /// tags to categorize Athena workgroups or data catalogs by purpose, owner, or environment.
        /// Use a consistent set of tag keys to make it easier to search and filter workgroups
        /// or data catalogs in your account. For best practices, see <a href="https://aws.amazon.com/answers/account-management/aws-tagging-strategies/">Tagging
        /// Best Practices</a>. Tag keys can be from 1 to 128 UTF-8 Unicode characters, and tag
        /// values can be from 0 to 256 UTF-8 Unicode characters. Tags can use letters and numbers
        /// representable in UTF-8, and the following characters: + - = . _ : / @. Tag keys and
        /// values are case-sensitive. Tag keys must be unique per resource. If you specify more
        /// than one tag, separate them by commas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds one or more tags to an Athena resource. A tag is a label that you assign to a
        /// resource. In Athena, a resource can be a workgroup or data catalog. Each tag consists
        /// of a key and an optional value, both of which you define. For example, you can use
        /// tags to categorize Athena workgroups or data catalogs by purpose, owner, or environment.
        /// Use a consistent set of tag keys to make it easier to search and filter workgroups
        /// or data catalogs in your account. For best practices, see <a href="https://aws.amazon.com/answers/account-management/aws-tagging-strategies/">Tagging
        /// Best Practices</a>. Tag keys can be from 1 to 128 UTF-8 Unicode characters, and tag
        /// values can be from 0 to 256 UTF-8 Unicode characters. Tags can use letters and numbers
        /// representable in UTF-8, and the following characters: + - = . _ : / @. Tag keys and
        /// values are case-sensitive. Tag keys must be unique per resource. If you specify more
        /// than one tag, separate them by commas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateSession


        /// <summary>
        /// Terminates an active session. A <code>TerminateSession</code> call on a session that
        /// is already inactive (for example, in a <code>FAILED</code>, <code>TERMINATED</code>
        /// or <code>TERMINATING</code> state) succeeds but has no effect. Calculations running
        /// in the session when <code>TerminateSession</code> is called are forcefully stopped,
        /// but may display as <code>FAILED</code> instead of <code>STOPPED</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateSession service method.</param>
        /// 
        /// <returns>The response from the TerminateSession service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/TerminateSession">REST API Reference for TerminateSession Operation</seealso>
        public virtual TerminateSessionResponse TerminateSession(TerminateSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateSessionResponseUnmarshaller.Instance;

            return Invoke<TerminateSessionResponse>(request, options);
        }


        /// <summary>
        /// Terminates an active session. A <code>TerminateSession</code> call on a session that
        /// is already inactive (for example, in a <code>FAILED</code>, <code>TERMINATED</code>
        /// or <code>TERMINATING</code> state) succeeds but has no effect. Calculations running
        /// in the session when <code>TerminateSession</code> is called are forcefully stopped,
        /// but may display as <code>FAILED</code> instead of <code>STOPPED</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateSession service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/TerminateSession">REST API Reference for TerminateSession Operation</seealso>
        public virtual Task<TerminateSessionResponse> TerminateSessionAsync(TerminateSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<TerminateSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from a data catalog or workgroup resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes one or more tags from a data catalog or workgroup resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataCatalog


        /// <summary>
        /// Updates the data catalog that has the specified name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataCatalog service method.</param>
        /// 
        /// <returns>The response from the UpdateDataCatalog service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateDataCatalog">REST API Reference for UpdateDataCatalog Operation</seealso>
        public virtual UpdateDataCatalogResponse UpdateDataCatalog(UpdateDataCatalogRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataCatalogResponseUnmarshaller.Instance;

            return Invoke<UpdateDataCatalogResponse>(request, options);
        }


        /// <summary>
        /// Updates the data catalog that has the specified name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataCatalog service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateDataCatalog">REST API Reference for UpdateDataCatalog Operation</seealso>
        public virtual Task<UpdateDataCatalogResponse> UpdateDataCatalogAsync(UpdateDataCatalogRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataCatalogResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDataCatalogResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNamedQuery


        /// <summary>
        /// Updates a <a>NamedQuery</a> object. The database or workgroup cannot be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNamedQuery service method.</param>
        /// 
        /// <returns>The response from the UpdateNamedQuery service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateNamedQuery">REST API Reference for UpdateNamedQuery Operation</seealso>
        public virtual UpdateNamedQueryResponse UpdateNamedQuery(UpdateNamedQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNamedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNamedQueryResponseUnmarshaller.Instance;

            return Invoke<UpdateNamedQueryResponse>(request, options);
        }


        /// <summary>
        /// Updates a <a>NamedQuery</a> object. The database or workgroup cannot be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNamedQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNamedQuery service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateNamedQuery">REST API Reference for UpdateNamedQuery Operation</seealso>
        public virtual Task<UpdateNamedQueryResponse> UpdateNamedQueryAsync(UpdateNamedQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNamedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNamedQueryResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateNamedQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNotebook


        /// <summary>
        /// Updates the contents of a Spark notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebook service method.</param>
        /// 
        /// <returns>The response from the UpdateNotebook service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateNotebook">REST API Reference for UpdateNotebook Operation</seealso>
        public virtual UpdateNotebookResponse UpdateNotebook(UpdateNotebookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotebookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotebookResponseUnmarshaller.Instance;

            return Invoke<UpdateNotebookResponse>(request, options);
        }


        /// <summary>
        /// Updates the contents of a Spark notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNotebook service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateNotebook">REST API Reference for UpdateNotebook Operation</seealso>
        public virtual Task<UpdateNotebookResponse> UpdateNotebookAsync(UpdateNotebookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotebookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotebookResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateNotebookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNotebookMetadata


        /// <summary>
        /// Updates the metadata for a notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateNotebookMetadata service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateNotebookMetadata">REST API Reference for UpdateNotebookMetadata Operation</seealso>
        public virtual UpdateNotebookMetadataResponse UpdateNotebookMetadata(UpdateNotebookMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotebookMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotebookMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateNotebookMetadataResponse>(request, options);
        }


        /// <summary>
        /// Updates the metadata for a notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNotebookMetadata service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateNotebookMetadata">REST API Reference for UpdateNotebookMetadata Operation</seealso>
        public virtual Task<UpdateNotebookMetadataResponse> UpdateNotebookMetadataAsync(UpdateNotebookMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotebookMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotebookMetadataResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateNotebookMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePreparedStatement


        /// <summary>
        /// Updates a prepared statement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePreparedStatement service method.</param>
        /// 
        /// <returns>The response from the UpdatePreparedStatement service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdatePreparedStatement">REST API Reference for UpdatePreparedStatement Operation</seealso>
        public virtual UpdatePreparedStatementResponse UpdatePreparedStatement(UpdatePreparedStatementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePreparedStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePreparedStatementResponseUnmarshaller.Instance;

            return Invoke<UpdatePreparedStatementResponse>(request, options);
        }


        /// <summary>
        /// Updates a prepared statement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePreparedStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePreparedStatement service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdatePreparedStatement">REST API Reference for UpdatePreparedStatement Operation</seealso>
        public virtual Task<UpdatePreparedStatementResponse> UpdatePreparedStatementAsync(UpdatePreparedStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePreparedStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePreparedStatementResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePreparedStatementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWorkGroup


        /// <summary>
        /// Updates the workgroup with the specified name. The workgroup's name cannot be changed.
        /// Only one of <code>ConfigurationsUpdates</code> or <code>ConfigurationUpdates</code>
        /// can be specified; <code>ConfigurationsUpdates</code> for a workgroup with multi engine
        /// support (for example, an Apache Spark enabled workgroup) or <code>ConfigurationUpdates</code>
        /// for an Athena SQL workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkGroup service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateWorkGroup">REST API Reference for UpdateWorkGroup Operation</seealso>
        public virtual UpdateWorkGroupResponse UpdateWorkGroup(UpdateWorkGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkGroupResponse>(request, options);
        }


        /// <summary>
        /// Updates the workgroup with the specified name. The workgroup's name cannot be changed.
        /// Only one of <code>ConfigurationsUpdates</code> or <code>ConfigurationUpdates</code>
        /// can be specified; <code>ConfigurationsUpdates</code> for a workgroup with multi engine
        /// support (for example, an Apache Spark enabled workgroup) or <code>ConfigurationUpdates</code>
        /// for an Athena SQL workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkGroup service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateWorkGroup">REST API Reference for UpdateWorkGroup Operation</seealso>
        public virtual Task<UpdateWorkGroupResponse> UpdateWorkGroupAsync(UpdateWorkGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateWorkGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}