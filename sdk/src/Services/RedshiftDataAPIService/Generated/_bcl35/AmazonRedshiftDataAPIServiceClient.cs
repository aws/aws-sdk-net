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
using System.Net;

using Amazon.RedshiftDataAPIService.Model;
using Amazon.RedshiftDataAPIService.Model.Internal.MarshallTransformations;
using Amazon.RedshiftDataAPIService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RedshiftDataAPIService
{
    /// <summary>
    /// Implementation for accessing RedshiftDataAPIService
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
    public partial class AmazonRedshiftDataAPIServiceClient : AmazonServiceClient, IAmazonRedshiftDataAPIService
    {
        private static IServiceMetadata serviceMetadata = new AmazonRedshiftDataAPIServiceMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IRedshiftDataAPIServicePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRedshiftDataAPIServicePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new RedshiftDataAPIServicePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonRedshiftDataAPIServiceClient with the credentials loaded from the application's
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
        public AmazonRedshiftDataAPIServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRedshiftDataAPIServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonRedshiftDataAPIServiceClient with the credentials loaded from the application's
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
        public AmazonRedshiftDataAPIServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRedshiftDataAPIServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRedshiftDataAPIServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRedshiftDataAPIServiceClient Configuration Object</param>
        public AmazonRedshiftDataAPIServiceClient(AmazonRedshiftDataAPIServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonRedshiftDataAPIServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRedshiftDataAPIServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonRedshiftDataAPIServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftDataAPIServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftDataAPIServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRedshiftDataAPIServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftDataAPIServiceClient with AWS Credentials and an
        /// AmazonRedshiftDataAPIServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRedshiftDataAPIServiceClient Configuration Object</param>
        public AmazonRedshiftDataAPIServiceClient(AWSCredentials credentials, AmazonRedshiftDataAPIServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftDataAPIServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRedshiftDataAPIServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRedshiftDataAPIServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftDataAPIServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftDataAPIServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRedshiftDataAPIServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftDataAPIServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftDataAPIServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRedshiftDataAPIServiceClient Configuration Object</param>
        public AmazonRedshiftDataAPIServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRedshiftDataAPIServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftDataAPIServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRedshiftDataAPIServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftDataAPIServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftDataAPIServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftDataAPIServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftDataAPIServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftDataAPIServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftDataAPIServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRedshiftDataAPIServiceClient Configuration Object</param>
        public AmazonRedshiftDataAPIServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRedshiftDataAPIServiceConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRedshiftDataAPIServiceEndpointResolver());
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

        /// <summary>
        /// Runs one or more SQL statements, which can be data manipulation language (DML) or
        /// data definition language (DDL). Depending on the authorization method, use one of
        /// the following combinations of request parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Secrets Manager - when connecting to a cluster, specify the Amazon Resource Name (ARN)
        /// of the secret, the database name, and the cluster identifier that matches the cluster
        /// in the secret. When connecting to a serverless workgroup, specify the Amazon Resource
        /// Name (ARN) of the secret and the database name. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - when connecting to a cluster, specify the cluster identifier,
        /// the database name, and the database user name. Also, permission to call the <code>redshift:GetClusterCredentials</code>
        /// operation is required. When connecting to a serverless workgroup, specify the workgroup
        /// name and database name. Also, permission to call the <code>redshift-serverless:GetCredentials</code>
        /// operation is required. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchExecuteStatement service method.</param>
        /// 
        /// <returns>The response from the BatchExecuteStatement service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ActiveStatementsExceededException">
        /// The number of active statements exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.BatchExecuteStatementException">
        /// An SQL statement encountered an environmental error while running.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/BatchExecuteStatement">REST API Reference for BatchExecuteStatement Operation</seealso>
        public virtual BatchExecuteStatementResponse BatchExecuteStatement(BatchExecuteStatementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchExecuteStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchExecuteStatementResponseUnmarshaller.Instance;

            return Invoke<BatchExecuteStatementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchExecuteStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchExecuteStatement operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchExecuteStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/BatchExecuteStatement">REST API Reference for BatchExecuteStatement Operation</seealso>
        public virtual IAsyncResult BeginBatchExecuteStatement(BatchExecuteStatementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchExecuteStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchExecuteStatementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchExecuteStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchExecuteStatement.</param>
        /// 
        /// <returns>Returns a  BatchExecuteStatementResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/BatchExecuteStatement">REST API Reference for BatchExecuteStatement Operation</seealso>
        public virtual BatchExecuteStatementResponse EndBatchExecuteStatement(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchExecuteStatementResponse>(asyncResult);
        }

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
        public virtual CancelStatementResponse CancelStatement(CancelStatementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelStatementResponseUnmarshaller.Instance;

            return Invoke<CancelStatementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelStatement operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/CancelStatement">REST API Reference for CancelStatement Operation</seealso>
        public virtual IAsyncResult BeginCancelStatement(CancelStatementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelStatementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelStatement.</param>
        /// 
        /// <returns>Returns a  CancelStatementResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/CancelStatement">REST API Reference for CancelStatement Operation</seealso>
        public virtual CancelStatementResponse EndCancelStatement(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelStatementResponse>(asyncResult);
        }

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
        public virtual DescribeStatementResponse DescribeStatement(DescribeStatementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStatementResponseUnmarshaller.Instance;

            return Invoke<DescribeStatementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStatement operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/DescribeStatement">REST API Reference for DescribeStatement Operation</seealso>
        public virtual IAsyncResult BeginDescribeStatement(DescribeStatementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStatementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStatement.</param>
        /// 
        /// <returns>Returns a  DescribeStatementResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/DescribeStatement">REST API Reference for DescribeStatement Operation</seealso>
        public virtual DescribeStatementResponse EndDescribeStatement(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStatementResponse>(asyncResult);
        }

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
        /// Secrets Manager - when connecting to a cluster, specify the Amazon Resource Name (ARN)
        /// of the secret, the database name, and the cluster identifier that matches the cluster
        /// in the secret. When connecting to a serverless workgroup, specify the Amazon Resource
        /// Name (ARN) of the secret and the database name. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - when connecting to a cluster, specify the cluster identifier,
        /// the database name, and the database user name. Also, permission to call the <code>redshift:GetClusterCredentials</code>
        /// operation is required. When connecting to a serverless workgroup, specify the workgroup
        /// name and database name. Also, permission to call the <code>redshift-serverless:GetCredentials</code>
        /// operation is required. 
        /// </para>
        ///  </li> </ul> 
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
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/DescribeTable">REST API Reference for DescribeTable Operation</seealso>
        public virtual DescribeTableResponse DescribeTable(DescribeTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableResponseUnmarshaller.Instance;

            return Invoke<DescribeTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTable operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/DescribeTable">REST API Reference for DescribeTable Operation</seealso>
        public virtual IAsyncResult BeginDescribeTable(DescribeTableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTable.</param>
        /// 
        /// <returns>Returns a  DescribeTableResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/DescribeTable">REST API Reference for DescribeTable Operation</seealso>
        public virtual DescribeTableResponse EndDescribeTable(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTableResponse>(asyncResult);
        }

        #endregion
        
        #region  ExecuteStatement

        /// <summary>
        /// Runs an SQL statement, which can be data manipulation language (DML) or data definition
        /// language (DDL). This statement must be a single SQL statement. Depending on the authorization
        /// method, use one of the following combinations of request parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Secrets Manager - when connecting to a cluster, specify the Amazon Resource Name (ARN)
        /// of the secret, the database name, and the cluster identifier that matches the cluster
        /// in the secret. When connecting to a serverless workgroup, specify the Amazon Resource
        /// Name (ARN) of the secret and the database name. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - when connecting to a cluster, specify the cluster identifier,
        /// the database name, and the database user name. Also, permission to call the <code>redshift:GetClusterCredentials</code>
        /// operation is required. When connecting to a serverless workgroup, specify the workgroup
        /// name and database name. Also, permission to call the <code>redshift-serverless:GetCredentials</code>
        /// operation is required. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about the Amazon Redshift Data API and CLI usage examples, see
        /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
        /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteStatement service method.</param>
        /// 
        /// <returns>The response from the ExecuteStatement service method, as returned by RedshiftDataAPIService.</returns>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ActiveStatementsExceededException">
        /// The number of active statements exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ExecuteStatementException">
        /// The SQL statement encountered an environmental error while running.
        /// </exception>
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ExecuteStatement">REST API Reference for ExecuteStatement Operation</seealso>
        public virtual ExecuteStatementResponse ExecuteStatement(ExecuteStatementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteStatementResponseUnmarshaller.Instance;

            return Invoke<ExecuteStatementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteStatement operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ExecuteStatement">REST API Reference for ExecuteStatement Operation</seealso>
        public virtual IAsyncResult BeginExecuteStatement(ExecuteStatementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteStatementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteStatement.</param>
        /// 
        /// <returns>Returns a  ExecuteStatementResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ExecuteStatement">REST API Reference for ExecuteStatement Operation</seealso>
        public virtual ExecuteStatementResponse EndExecuteStatement(IAsyncResult asyncResult)
        {
            return EndInvoke<ExecuteStatementResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStatementResult

        /// <summary>
        /// Fetches the temporarily cached result of an SQL statement. A token is returned to
        /// page through the statement results. 
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
        public virtual GetStatementResultResponse GetStatementResult(GetStatementResultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStatementResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStatementResultResponseUnmarshaller.Instance;

            return Invoke<GetStatementResultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStatementResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStatementResult operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStatementResult
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/GetStatementResult">REST API Reference for GetStatementResult Operation</seealso>
        public virtual IAsyncResult BeginGetStatementResult(GetStatementResultRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStatementResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStatementResultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStatementResult operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStatementResult.</param>
        /// 
        /// <returns>Returns a  GetStatementResultResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/GetStatementResult">REST API Reference for GetStatementResult Operation</seealso>
        public virtual GetStatementResultResponse EndGetStatementResult(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStatementResultResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDatabases

        /// <summary>
        /// List the databases in a cluster. A token is returned to page through the database
        /// list. Depending on the authorization method, use one of the following combinations
        /// of request parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Secrets Manager - when connecting to a cluster, specify the Amazon Resource Name (ARN)
        /// of the secret, the database name, and the cluster identifier that matches the cluster
        /// in the secret. When connecting to a serverless workgroup, specify the Amazon Resource
        /// Name (ARN) of the secret and the database name. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - when connecting to a cluster, specify the cluster identifier,
        /// the database name, and the database user name. Also, permission to call the <code>redshift:GetClusterCredentials</code>
        /// operation is required. When connecting to a serverless workgroup, specify the workgroup
        /// name and database name. Also, permission to call the <code>redshift-serverless:GetCredentials</code>
        /// operation is required. 
        /// </para>
        ///  </li> </ul> 
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
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatabases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
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
        /// <returns>Returns a  ListDatabasesResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        public virtual ListDatabasesResponse EndListDatabases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDatabasesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSchemas

        /// <summary>
        /// Lists the schemas in a database. A token is returned to page through the schema list.
        /// Depending on the authorization method, use one of the following combinations of request
        /// parameters: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Secrets Manager - when connecting to a cluster, specify the Amazon Resource Name (ARN)
        /// of the secret, the database name, and the cluster identifier that matches the cluster
        /// in the secret. When connecting to a serverless workgroup, specify the Amazon Resource
        /// Name (ARN) of the secret and the database name. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - when connecting to a cluster, specify the cluster identifier,
        /// the database name, and the database user name. Also, permission to call the <code>redshift:GetClusterCredentials</code>
        /// operation is required. When connecting to a serverless workgroup, specify the workgroup
        /// name and database name. Also, permission to call the <code>redshift-serverless:GetCredentials</code>
        /// operation is required. 
        /// </para>
        ///  </li> </ul> 
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
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        public virtual ListSchemasResponse ListSchemas(ListSchemasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemasResponseUnmarshaller.Instance;

            return Invoke<ListSchemasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSchemas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        public virtual IAsyncResult BeginListSchemas(ListSchemasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchemas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchemas.</param>
        /// 
        /// <returns>Returns a  ListSchemasResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        public virtual ListSchemasResponse EndListSchemas(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSchemasResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStatements

        /// <summary>
        /// List of SQL statements. By default, only finished statements are shown. A token is
        /// returned to page through the statement list. 
        /// 
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
        public virtual ListStatementsResponse ListStatements(ListStatementsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStatementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStatementsResponseUnmarshaller.Instance;

            return Invoke<ListStatementsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStatements operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStatements operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStatements
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListStatements">REST API Reference for ListStatements Operation</seealso>
        public virtual IAsyncResult BeginListStatements(ListStatementsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStatementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStatementsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStatements operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStatements.</param>
        /// 
        /// <returns>Returns a  ListStatementsResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListStatements">REST API Reference for ListStatements Operation</seealso>
        public virtual ListStatementsResponse EndListStatements(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStatementsResponse>(asyncResult);
        }

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
        /// Secrets Manager - when connecting to a cluster, specify the Amazon Resource Name (ARN)
        /// of the secret, the database name, and the cluster identifier that matches the cluster
        /// in the secret. When connecting to a serverless workgroup, specify the Amazon Resource
        /// Name (ARN) of the secret and the database name. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary credentials - when connecting to a cluster, specify the cluster identifier,
        /// the database name, and the database user name. Also, permission to call the <code>redshift:GetClusterCredentials</code>
        /// operation is required. When connecting to a serverless workgroup, specify the workgroup
        /// name and database name. Also, permission to call the <code>redshift-serverless:GetCredentials</code>
        /// operation is required. 
        /// </para>
        ///  </li> </ul> 
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
        /// <exception cref="Amazon.RedshiftDataAPIService.Model.ValidationException">
        /// The Amazon Redshift Data API operation failed due to invalid input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual ListTablesResponse ListTables(ListTablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTablesResponseUnmarshaller.Instance;

            return Invoke<ListTablesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTables operation on AmazonRedshiftDataAPIServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual IAsyncResult BeginListTables(ListTablesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTablesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTables.</param>
        /// 
        /// <returns>Returns a  ListTablesResult from RedshiftDataAPIService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-data-2019-12-20/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual ListTablesResponse EndListTables(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTablesResponse>(asyncResult);
        }

        #endregion
        
    }
}