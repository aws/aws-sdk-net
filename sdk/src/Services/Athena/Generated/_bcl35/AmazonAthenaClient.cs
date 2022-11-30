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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
#endif
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
        /// Initiates the asynchronous execution of the BatchGetNamedQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetNamedQuery operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetNamedQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/BatchGetNamedQuery">REST API Reference for BatchGetNamedQuery Operation</seealso>
        public virtual IAsyncResult BeginBatchGetNamedQuery(BatchGetNamedQueryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetNamedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetNamedQueryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetNamedQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetNamedQuery.</param>
        /// 
        /// <returns>Returns a  BatchGetNamedQueryResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/BatchGetNamedQuery">REST API Reference for BatchGetNamedQuery Operation</seealso>
        public virtual BatchGetNamedQueryResponse EndBatchGetNamedQuery(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetNamedQueryResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the BatchGetPreparedStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPreparedStatement operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetPreparedStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/BatchGetPreparedStatement">REST API Reference for BatchGetPreparedStatement Operation</seealso>
        public virtual IAsyncResult BeginBatchGetPreparedStatement(BatchGetPreparedStatementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetPreparedStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetPreparedStatementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetPreparedStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetPreparedStatement.</param>
        /// 
        /// <returns>Returns a  BatchGetPreparedStatementResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/BatchGetPreparedStatement">REST API Reference for BatchGetPreparedStatement Operation</seealso>
        public virtual BatchGetPreparedStatementResponse EndBatchGetPreparedStatement(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetPreparedStatementResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the BatchGetQueryExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetQueryExecution operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetQueryExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/BatchGetQueryExecution">REST API Reference for BatchGetQueryExecution Operation</seealso>
        public virtual IAsyncResult BeginBatchGetQueryExecution(BatchGetQueryExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetQueryExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetQueryExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetQueryExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetQueryExecution.</param>
        /// 
        /// <returns>Returns a  BatchGetQueryExecutionResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/BatchGetQueryExecution">REST API Reference for BatchGetQueryExecution Operation</seealso>
        public virtual BatchGetQueryExecutionResponse EndBatchGetQueryExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetQueryExecutionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateDataCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataCatalog operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataCatalog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateDataCatalog">REST API Reference for CreateDataCatalog Operation</seealso>
        public virtual IAsyncResult BeginCreateDataCatalog(CreateDataCatalogRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataCatalogResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataCatalog.</param>
        /// 
        /// <returns>Returns a  CreateDataCatalogResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateDataCatalog">REST API Reference for CreateDataCatalog Operation</seealso>
        public virtual CreateDataCatalogResponse EndCreateDataCatalog(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataCatalogResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateNamedQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNamedQuery operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNamedQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateNamedQuery">REST API Reference for CreateNamedQuery Operation</seealso>
        public virtual IAsyncResult BeginCreateNamedQuery(CreateNamedQueryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNamedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNamedQueryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNamedQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNamedQuery.</param>
        /// 
        /// <returns>Returns a  CreateNamedQueryResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateNamedQuery">REST API Reference for CreateNamedQuery Operation</seealso>
        public virtual CreateNamedQueryResponse EndCreateNamedQuery(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNamedQueryResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateNotebook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebook operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNotebook
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateNotebook">REST API Reference for CreateNotebook Operation</seealso>
        public virtual IAsyncResult BeginCreateNotebook(CreateNotebookRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotebookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotebookResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNotebook operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNotebook.</param>
        /// 
        /// <returns>Returns a  CreateNotebookResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateNotebook">REST API Reference for CreateNotebook Operation</seealso>
        public virtual CreateNotebookResponse EndCreateNotebook(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNotebookResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreatePreparedStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePreparedStatement operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePreparedStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreatePreparedStatement">REST API Reference for CreatePreparedStatement Operation</seealso>
        public virtual IAsyncResult BeginCreatePreparedStatement(CreatePreparedStatementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePreparedStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePreparedStatementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePreparedStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePreparedStatement.</param>
        /// 
        /// <returns>Returns a  CreatePreparedStatementResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreatePreparedStatement">REST API Reference for CreatePreparedStatement Operation</seealso>
        public virtual CreatePreparedStatementResponse EndCreatePreparedStatement(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePreparedStatementResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreatePresignedNotebookUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedNotebookUrl operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePresignedNotebookUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreatePresignedNotebookUrl">REST API Reference for CreatePresignedNotebookUrl Operation</seealso>
        public virtual IAsyncResult BeginCreatePresignedNotebookUrl(CreatePresignedNotebookUrlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePresignedNotebookUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresignedNotebookUrlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePresignedNotebookUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePresignedNotebookUrl.</param>
        /// 
        /// <returns>Returns a  CreatePresignedNotebookUrlResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreatePresignedNotebookUrl">REST API Reference for CreatePresignedNotebookUrl Operation</seealso>
        public virtual CreatePresignedNotebookUrlResponse EndCreatePresignedNotebookUrl(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePresignedNotebookUrlResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateWorkGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkGroup operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateWorkGroup">REST API Reference for CreateWorkGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateWorkGroup(CreateWorkGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkGroup.</param>
        /// 
        /// <returns>Returns a  CreateWorkGroupResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateWorkGroup">REST API Reference for CreateWorkGroup Operation</seealso>
        public virtual CreateWorkGroupResponse EndCreateWorkGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkGroupResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteDataCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataCatalog operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataCatalog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteDataCatalog">REST API Reference for DeleteDataCatalog Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataCatalog(DeleteDataCatalogRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataCatalogResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataCatalog.</param>
        /// 
        /// <returns>Returns a  DeleteDataCatalogResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteDataCatalog">REST API Reference for DeleteDataCatalog Operation</seealso>
        public virtual DeleteDataCatalogResponse EndDeleteDataCatalog(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataCatalogResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteNamedQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamedQuery operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNamedQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteNamedQuery">REST API Reference for DeleteNamedQuery Operation</seealso>
        public virtual IAsyncResult BeginDeleteNamedQuery(DeleteNamedQueryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNamedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamedQueryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNamedQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNamedQuery.</param>
        /// 
        /// <returns>Returns a  DeleteNamedQueryResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteNamedQuery">REST API Reference for DeleteNamedQuery Operation</seealso>
        public virtual DeleteNamedQueryResponse EndDeleteNamedQuery(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNamedQueryResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteNotebook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebook operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNotebook
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteNotebook">REST API Reference for DeleteNotebook Operation</seealso>
        public virtual IAsyncResult BeginDeleteNotebook(DeleteNotebookRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotebookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotebookResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotebook operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotebook.</param>
        /// 
        /// <returns>Returns a  DeleteNotebookResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteNotebook">REST API Reference for DeleteNotebook Operation</seealso>
        public virtual DeleteNotebookResponse EndDeleteNotebook(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNotebookResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeletePreparedStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePreparedStatement operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePreparedStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeletePreparedStatement">REST API Reference for DeletePreparedStatement Operation</seealso>
        public virtual IAsyncResult BeginDeletePreparedStatement(DeletePreparedStatementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePreparedStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePreparedStatementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePreparedStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePreparedStatement.</param>
        /// 
        /// <returns>Returns a  DeletePreparedStatementResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeletePreparedStatement">REST API Reference for DeletePreparedStatement Operation</seealso>
        public virtual DeletePreparedStatementResponse EndDeletePreparedStatement(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePreparedStatementResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteWorkGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkGroup operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteWorkGroup">REST API Reference for DeleteWorkGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteWorkGroup(DeleteWorkGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkGroup.</param>
        /// 
        /// <returns>Returns a  DeleteWorkGroupResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteWorkGroup">REST API Reference for DeleteWorkGroup Operation</seealso>
        public virtual DeleteWorkGroupResponse EndDeleteWorkGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWorkGroupResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ExportNotebook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportNotebook operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportNotebook
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ExportNotebook">REST API Reference for ExportNotebook Operation</seealso>
        public virtual IAsyncResult BeginExportNotebook(ExportNotebookRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportNotebookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportNotebookResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportNotebook operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportNotebook.</param>
        /// 
        /// <returns>Returns a  ExportNotebookResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ExportNotebook">REST API Reference for ExportNotebook Operation</seealso>
        public virtual ExportNotebookResponse EndExportNotebook(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportNotebookResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetCalculationExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCalculationExecution operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCalculationExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetCalculationExecution">REST API Reference for GetCalculationExecution Operation</seealso>
        public virtual IAsyncResult BeginGetCalculationExecution(GetCalculationExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCalculationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCalculationExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCalculationExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCalculationExecution.</param>
        /// 
        /// <returns>Returns a  GetCalculationExecutionResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetCalculationExecution">REST API Reference for GetCalculationExecution Operation</seealso>
        public virtual GetCalculationExecutionResponse EndGetCalculationExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCalculationExecutionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetCalculationExecutionCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCalculationExecutionCode operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCalculationExecutionCode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetCalculationExecutionCode">REST API Reference for GetCalculationExecutionCode Operation</seealso>
        public virtual IAsyncResult BeginGetCalculationExecutionCode(GetCalculationExecutionCodeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCalculationExecutionCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCalculationExecutionCodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCalculationExecutionCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCalculationExecutionCode.</param>
        /// 
        /// <returns>Returns a  GetCalculationExecutionCodeResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetCalculationExecutionCode">REST API Reference for GetCalculationExecutionCode Operation</seealso>
        public virtual GetCalculationExecutionCodeResponse EndGetCalculationExecutionCode(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCalculationExecutionCodeResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetCalculationExecutionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCalculationExecutionStatus operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCalculationExecutionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetCalculationExecutionStatus">REST API Reference for GetCalculationExecutionStatus Operation</seealso>
        public virtual IAsyncResult BeginGetCalculationExecutionStatus(GetCalculationExecutionStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCalculationExecutionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCalculationExecutionStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCalculationExecutionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCalculationExecutionStatus.</param>
        /// 
        /// <returns>Returns a  GetCalculationExecutionStatusResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetCalculationExecutionStatus">REST API Reference for GetCalculationExecutionStatus Operation</seealso>
        public virtual GetCalculationExecutionStatusResponse EndGetCalculationExecutionStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCalculationExecutionStatusResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        public virtual IAsyncResult BeginGetDatabase(GetDatabaseRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatabaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDatabase.</param>
        /// 
        /// <returns>Returns a  GetDatabaseResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        public virtual GetDatabaseResponse EndGetDatabase(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDatabaseResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetDataCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataCatalog operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataCatalog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetDataCatalog">REST API Reference for GetDataCatalog Operation</seealso>
        public virtual IAsyncResult BeginGetDataCatalog(GetDataCatalogRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataCatalogResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataCatalog.</param>
        /// 
        /// <returns>Returns a  GetDataCatalogResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetDataCatalog">REST API Reference for GetDataCatalog Operation</seealso>
        public virtual GetDataCatalogResponse EndGetDataCatalog(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataCatalogResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetNamedQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNamedQuery operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNamedQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetNamedQuery">REST API Reference for GetNamedQuery Operation</seealso>
        public virtual IAsyncResult BeginGetNamedQuery(GetNamedQueryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNamedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamedQueryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNamedQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNamedQuery.</param>
        /// 
        /// <returns>Returns a  GetNamedQueryResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetNamedQuery">REST API Reference for GetNamedQuery Operation</seealso>
        public virtual GetNamedQueryResponse EndGetNamedQuery(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNamedQueryResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetNotebookMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNotebookMetadata operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNotebookMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetNotebookMetadata">REST API Reference for GetNotebookMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetNotebookMetadata(GetNotebookMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNotebookMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotebookMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNotebookMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNotebookMetadata.</param>
        /// 
        /// <returns>Returns a  GetNotebookMetadataResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetNotebookMetadata">REST API Reference for GetNotebookMetadata Operation</seealso>
        public virtual GetNotebookMetadataResponse EndGetNotebookMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNotebookMetadataResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetPreparedStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPreparedStatement operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPreparedStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetPreparedStatement">REST API Reference for GetPreparedStatement Operation</seealso>
        public virtual IAsyncResult BeginGetPreparedStatement(GetPreparedStatementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPreparedStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPreparedStatementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPreparedStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPreparedStatement.</param>
        /// 
        /// <returns>Returns a  GetPreparedStatementResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetPreparedStatement">REST API Reference for GetPreparedStatement Operation</seealso>
        public virtual GetPreparedStatementResponse EndGetPreparedStatement(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPreparedStatementResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetQueryExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueryExecution operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueryExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetQueryExecution">REST API Reference for GetQueryExecution Operation</seealso>
        public virtual IAsyncResult BeginGetQueryExecution(GetQueryExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueryExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueryExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueryExecution.</param>
        /// 
        /// <returns>Returns a  GetQueryExecutionResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetQueryExecution">REST API Reference for GetQueryExecution Operation</seealso>
        public virtual GetQueryExecutionResponse EndGetQueryExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<GetQueryExecutionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetQueryResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResults operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueryResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetQueryResults">REST API Reference for GetQueryResults Operation</seealso>
        public virtual IAsyncResult BeginGetQueryResults(GetQueryResultsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueryResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueryResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueryResults.</param>
        /// 
        /// <returns>Returns a  GetQueryResultsResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetQueryResults">REST API Reference for GetQueryResults Operation</seealso>
        public virtual GetQueryResultsResponse EndGetQueryResults(IAsyncResult asyncResult)
        {
            return EndInvoke<GetQueryResultsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetQueryRuntimeStatistics

        /// <summary>
        /// Returns query execution runtime statistics related to a single execution of a query
        /// if you have access to the workgroup in which the query ran. The query execution runtime
        /// statistics is returned only when <a>QueryExecutionStatus$State</a> is in a SUCCEEDED
        /// or FAILED state.
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
        /// Initiates the asynchronous execution of the GetQueryRuntimeStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueryRuntimeStatistics operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueryRuntimeStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetQueryRuntimeStatistics">REST API Reference for GetQueryRuntimeStatistics Operation</seealso>
        public virtual IAsyncResult BeginGetQueryRuntimeStatistics(GetQueryRuntimeStatisticsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueryRuntimeStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryRuntimeStatisticsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueryRuntimeStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueryRuntimeStatistics.</param>
        /// 
        /// <returns>Returns a  GetQueryRuntimeStatisticsResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetQueryRuntimeStatistics">REST API Reference for GetQueryRuntimeStatistics Operation</seealso>
        public virtual GetQueryRuntimeStatisticsResponse EndGetQueryRuntimeStatistics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetQueryRuntimeStatisticsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSession operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual IAsyncResult BeginGetSession(GetSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSession.</param>
        /// 
        /// <returns>Returns a  GetSessionResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual GetSessionResponse EndGetSession(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSessionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetSessionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSessionStatus operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSessionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetSessionStatus">REST API Reference for GetSessionStatus Operation</seealso>
        public virtual IAsyncResult BeginGetSessionStatus(GetSessionStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSessionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSessionStatus.</param>
        /// 
        /// <returns>Returns a  GetSessionStatusResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetSessionStatus">REST API Reference for GetSessionStatus Operation</seealso>
        public virtual GetSessionStatusResponse EndGetSessionStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSessionStatusResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetTableMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableMetadata operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetTableMetadata">REST API Reference for GetTableMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetTableMetadata(GetTableMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableMetadata.</param>
        /// 
        /// <returns>Returns a  GetTableMetadataResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetTableMetadata">REST API Reference for GetTableMetadata Operation</seealso>
        public virtual GetTableMetadataResponse EndGetTableMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTableMetadataResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetWorkGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkGroup operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetWorkGroup">REST API Reference for GetWorkGroup Operation</seealso>
        public virtual IAsyncResult BeginGetWorkGroup(GetWorkGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkGroup.</param>
        /// 
        /// <returns>Returns a  GetWorkGroupResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetWorkGroup">REST API Reference for GetWorkGroup Operation</seealso>
        public virtual GetWorkGroupResponse EndGetWorkGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkGroupResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ImportNotebook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportNotebook operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportNotebook
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ImportNotebook">REST API Reference for ImportNotebook Operation</seealso>
        public virtual IAsyncResult BeginImportNotebook(ImportNotebookRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportNotebookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportNotebookResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportNotebook operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportNotebook.</param>
        /// 
        /// <returns>Returns a  ImportNotebookResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ImportNotebook">REST API Reference for ImportNotebook Operation</seealso>
        public virtual ImportNotebookResponse EndImportNotebook(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportNotebookResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListApplicationDPUSizes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationDPUSizes operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationDPUSizes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListApplicationDPUSizes">REST API Reference for ListApplicationDPUSizes Operation</seealso>
        public virtual IAsyncResult BeginListApplicationDPUSizes(ListApplicationDPUSizesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationDPUSizesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationDPUSizesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationDPUSizes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationDPUSizes.</param>
        /// 
        /// <returns>Returns a  ListApplicationDPUSizesResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListApplicationDPUSizes">REST API Reference for ListApplicationDPUSizes Operation</seealso>
        public virtual ListApplicationDPUSizesResponse EndListApplicationDPUSizes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationDPUSizesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListCalculationExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCalculationExecutions operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCalculationExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListCalculationExecutions">REST API Reference for ListCalculationExecutions Operation</seealso>
        public virtual IAsyncResult BeginListCalculationExecutions(ListCalculationExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCalculationExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCalculationExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCalculationExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCalculationExecutions.</param>
        /// 
        /// <returns>Returns a  ListCalculationExecutionsResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListCalculationExecutions">REST API Reference for ListCalculationExecutions Operation</seealso>
        public virtual ListCalculationExecutionsResponse EndListCalculationExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCalculationExecutionsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListDatabases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatabases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        public virtual IAsyncResult BeginListDatabases(ListDatabasesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatabasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatabases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatabases.</param>
        /// 
        /// <returns>Returns a  ListDatabasesResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        public virtual ListDatabasesResponse EndListDatabases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDatabasesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataCatalogs

        /// <summary>
        /// Lists the data catalogs in the current Amazon Web Services account.
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
        /// Initiates the asynchronous execution of the ListDataCatalogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataCatalogs operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataCatalogs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListDataCatalogs">REST API Reference for ListDataCatalogs Operation</seealso>
        public virtual IAsyncResult BeginListDataCatalogs(ListDataCatalogsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataCatalogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataCatalogsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataCatalogs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataCatalogs.</param>
        /// 
        /// <returns>Returns a  ListDataCatalogsResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListDataCatalogs">REST API Reference for ListDataCatalogs Operation</seealso>
        public virtual ListDataCatalogsResponse EndListDataCatalogs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataCatalogsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListEngineVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEngineVersions operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEngineVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListEngineVersions">REST API Reference for ListEngineVersions Operation</seealso>
        public virtual IAsyncResult BeginListEngineVersions(ListEngineVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngineVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEngineVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEngineVersions.</param>
        /// 
        /// <returns>Returns a  ListEngineVersionsResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListEngineVersions">REST API Reference for ListEngineVersions Operation</seealso>
        public virtual ListEngineVersionsResponse EndListEngineVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEngineVersionsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListExecutors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExecutors operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExecutors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListExecutors">REST API Reference for ListExecutors Operation</seealso>
        public virtual IAsyncResult BeginListExecutors(ListExecutorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExecutorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExecutorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExecutors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExecutors.</param>
        /// 
        /// <returns>Returns a  ListExecutorsResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListExecutors">REST API Reference for ListExecutors Operation</seealso>
        public virtual ListExecutorsResponse EndListExecutors(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExecutorsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListNamedQueries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNamedQueries operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNamedQueries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListNamedQueries">REST API Reference for ListNamedQueries Operation</seealso>
        public virtual IAsyncResult BeginListNamedQueries(ListNamedQueriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNamedQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamedQueriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNamedQueries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNamedQueries.</param>
        /// 
        /// <returns>Returns a  ListNamedQueriesResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListNamedQueries">REST API Reference for ListNamedQueries Operation</seealso>
        public virtual ListNamedQueriesResponse EndListNamedQueries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNamedQueriesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListNotebookMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookMetadata operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotebookMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListNotebookMetadata">REST API Reference for ListNotebookMetadata Operation</seealso>
        public virtual IAsyncResult BeginListNotebookMetadata(ListNotebookMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotebookMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotebookMetadata.</param>
        /// 
        /// <returns>Returns a  ListNotebookMetadataResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListNotebookMetadata">REST API Reference for ListNotebookMetadata Operation</seealso>
        public virtual ListNotebookMetadataResponse EndListNotebookMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNotebookMetadataResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListNotebookSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookSessions operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotebookSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListNotebookSessions">REST API Reference for ListNotebookSessions Operation</seealso>
        public virtual IAsyncResult BeginListNotebookSessions(ListNotebookSessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookSessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotebookSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotebookSessions.</param>
        /// 
        /// <returns>Returns a  ListNotebookSessionsResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListNotebookSessions">REST API Reference for ListNotebookSessions Operation</seealso>
        public virtual ListNotebookSessionsResponse EndListNotebookSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNotebookSessionsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListPreparedStatements operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPreparedStatements operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPreparedStatements
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListPreparedStatements">REST API Reference for ListPreparedStatements Operation</seealso>
        public virtual IAsyncResult BeginListPreparedStatements(ListPreparedStatementsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPreparedStatementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPreparedStatementsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPreparedStatements operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPreparedStatements.</param>
        /// 
        /// <returns>Returns a  ListPreparedStatementsResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListPreparedStatements">REST API Reference for ListPreparedStatements Operation</seealso>
        public virtual ListPreparedStatementsResponse EndListPreparedStatements(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPreparedStatementsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListQueryExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueryExecutions operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQueryExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListQueryExecutions">REST API Reference for ListQueryExecutions Operation</seealso>
        public virtual IAsyncResult BeginListQueryExecutions(ListQueryExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueryExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueryExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListQueryExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQueryExecutions.</param>
        /// 
        /// <returns>Returns a  ListQueryExecutionsResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListQueryExecutions">REST API Reference for ListQueryExecutions Operation</seealso>
        public virtual ListQueryExecutionsResponse EndListQueryExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListQueryExecutionsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSessions operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual IAsyncResult BeginListSessions(ListSessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSessions.</param>
        /// 
        /// <returns>Returns a  ListSessionsResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual ListSessionsResponse EndListSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSessionsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListTableMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTableMetadata operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTableMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListTableMetadata">REST API Reference for ListTableMetadata Operation</seealso>
        public virtual IAsyncResult BeginListTableMetadata(ListTableMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTableMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTableMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTableMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTableMetadata.</param>
        /// 
        /// <returns>Returns a  ListTableMetadataResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListTableMetadata">REST API Reference for ListTableMetadata Operation</seealso>
        public virtual ListTableMetadataResponse EndListTableMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTableMetadataResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListWorkGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkGroups operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListWorkGroups">REST API Reference for ListWorkGroups Operation</seealso>
        public virtual IAsyncResult BeginListWorkGroups(ListWorkGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkGroups.</param>
        /// 
        /// <returns>Returns a  ListWorkGroupsResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListWorkGroups">REST API Reference for ListWorkGroups Operation</seealso>
        public virtual ListWorkGroupsResponse EndListWorkGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWorkGroupsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the StartCalculationExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCalculationExecution operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCalculationExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StartCalculationExecution">REST API Reference for StartCalculationExecution Operation</seealso>
        public virtual IAsyncResult BeginStartCalculationExecution(StartCalculationExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCalculationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCalculationExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartCalculationExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCalculationExecution.</param>
        /// 
        /// <returns>Returns a  StartCalculationExecutionResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StartCalculationExecution">REST API Reference for StartCalculationExecution Operation</seealso>
        public virtual StartCalculationExecutionResponse EndStartCalculationExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StartCalculationExecutionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the StartQueryExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartQueryExecution operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartQueryExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StartQueryExecution">REST API Reference for StartQueryExecution Operation</seealso>
        public virtual IAsyncResult BeginStartQueryExecution(StartQueryExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartQueryExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartQueryExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartQueryExecution.</param>
        /// 
        /// <returns>Returns a  StartQueryExecutionResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StartQueryExecution">REST API Reference for StartQueryExecution Operation</seealso>
        public virtual StartQueryExecutionResponse EndStartQueryExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StartQueryExecutionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the StartSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSession operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StartSession">REST API Reference for StartSession Operation</seealso>
        public virtual IAsyncResult BeginStartSession(StartSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSession.</param>
        /// 
        /// <returns>Returns a  StartSessionResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StartSession">REST API Reference for StartSession Operation</seealso>
        public virtual StartSessionResponse EndStartSession(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSessionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the StopCalculationExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCalculationExecution operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopCalculationExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StopCalculationExecution">REST API Reference for StopCalculationExecution Operation</seealso>
        public virtual IAsyncResult BeginStopCalculationExecution(StopCalculationExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCalculationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCalculationExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopCalculationExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopCalculationExecution.</param>
        /// 
        /// <returns>Returns a  StopCalculationExecutionResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StopCalculationExecution">REST API Reference for StopCalculationExecution Operation</seealso>
        public virtual StopCalculationExecutionResponse EndStopCalculationExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StopCalculationExecutionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the StopQueryExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopQueryExecution operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopQueryExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StopQueryExecution">REST API Reference for StopQueryExecution Operation</seealso>
        public virtual IAsyncResult BeginStopQueryExecution(StopQueryExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopQueryExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopQueryExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopQueryExecution.</param>
        /// 
        /// <returns>Returns a  StopQueryExecutionResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StopQueryExecution">REST API Reference for StopQueryExecution Operation</seealso>
        public virtual StopQueryExecutionResponse EndStopQueryExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StopQueryExecutionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the TerminateSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateSession operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/TerminateSession">REST API Reference for TerminateSession Operation</seealso>
        public virtual IAsyncResult BeginTerminateSession(TerminateSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateSession.</param>
        /// 
        /// <returns>Returns a  TerminateSessionResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/TerminateSession">REST API Reference for TerminateSession Operation</seealso>
        public virtual TerminateSessionResponse EndTerminateSession(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateSessionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateDataCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataCatalog operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataCatalog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateDataCatalog">REST API Reference for UpdateDataCatalog Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataCatalog(UpdateDataCatalogRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataCatalogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataCatalogResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataCatalog.</param>
        /// 
        /// <returns>Returns a  UpdateDataCatalogResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateDataCatalog">REST API Reference for UpdateDataCatalog Operation</seealso>
        public virtual UpdateDataCatalogResponse EndUpdateDataCatalog(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataCatalogResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateNamedQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNamedQuery operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNamedQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateNamedQuery">REST API Reference for UpdateNamedQuery Operation</seealso>
        public virtual IAsyncResult BeginUpdateNamedQuery(UpdateNamedQueryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNamedQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNamedQueryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNamedQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNamedQuery.</param>
        /// 
        /// <returns>Returns a  UpdateNamedQueryResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateNamedQuery">REST API Reference for UpdateNamedQuery Operation</seealso>
        public virtual UpdateNamedQueryResponse EndUpdateNamedQuery(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNamedQueryResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateNotebook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebook operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNotebook
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateNotebook">REST API Reference for UpdateNotebook Operation</seealso>
        public virtual IAsyncResult BeginUpdateNotebook(UpdateNotebookRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotebookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotebookResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotebook operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotebook.</param>
        /// 
        /// <returns>Returns a  UpdateNotebookResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateNotebook">REST API Reference for UpdateNotebook Operation</seealso>
        public virtual UpdateNotebookResponse EndUpdateNotebook(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNotebookResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateNotebookMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookMetadata operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNotebookMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateNotebookMetadata">REST API Reference for UpdateNotebookMetadata Operation</seealso>
        public virtual IAsyncResult BeginUpdateNotebookMetadata(UpdateNotebookMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotebookMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotebookMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotebookMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotebookMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateNotebookMetadataResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateNotebookMetadata">REST API Reference for UpdateNotebookMetadata Operation</seealso>
        public virtual UpdateNotebookMetadataResponse EndUpdateNotebookMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNotebookMetadataResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdatePreparedStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePreparedStatement operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePreparedStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdatePreparedStatement">REST API Reference for UpdatePreparedStatement Operation</seealso>
        public virtual IAsyncResult BeginUpdatePreparedStatement(UpdatePreparedStatementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePreparedStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePreparedStatementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePreparedStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePreparedStatement.</param>
        /// 
        /// <returns>Returns a  UpdatePreparedStatementResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdatePreparedStatement">REST API Reference for UpdatePreparedStatement Operation</seealso>
        public virtual UpdatePreparedStatementResponse EndUpdatePreparedStatement(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePreparedStatementResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateWorkGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkGroup operation on AmazonAthenaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateWorkGroup">REST API Reference for UpdateWorkGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorkGroup(UpdateWorkGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkGroup.</param>
        /// 
        /// <returns>Returns a  UpdateWorkGroupResult from Athena.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateWorkGroup">REST API Reference for UpdateWorkGroup Operation</seealso>
        public virtual UpdateWorkGroupResponse EndUpdateWorkGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkGroupResponse>(asyncResult);
        }

        #endregion
        
    }
}