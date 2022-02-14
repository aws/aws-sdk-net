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
        
        #region  CreateWorkGroup

        /// <summary>
        /// Creates a workgroup with the specified name.
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
        
        #region  ListPreparedStatements

        /// <summary>
        /// Lists the prepared statements in the specfied workgroup.
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