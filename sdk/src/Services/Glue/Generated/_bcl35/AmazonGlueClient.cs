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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Glue.Model;
using Amazon.Glue.Model.Internal.MarshallTransformations;
using Amazon.Glue.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Glue
{
    /// <summary>
    /// Implementation for accessing Glue
    ///
    /// Glue 
    /// <para>
    /// Defines the public endpoint for the Glue service.
    /// </para>
    /// </summary>
    public partial class AmazonGlueClient : AmazonServiceClient, IAmazonGlue
    {
        private static IServiceMetadata serviceMetadata = new AmazonGlueMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IGluePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IGluePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new GluePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonGlueClient with the credentials loaded from the application's
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
        public AmazonGlueClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGlueConfig()) { }

        /// <summary>
        /// Constructs AmazonGlueClient with the credentials loaded from the application's
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
        public AmazonGlueClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGlueConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGlueClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonGlueClient Configuration Object</param>
        public AmazonGlueClient(AmazonGlueConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGlueClient(AWSCredentials credentials)
            : this(credentials, new AmazonGlueConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlueClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGlueConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Credentials and an
        /// AmazonGlueClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGlueClient Configuration Object</param>
        public AmazonGlueClient(AWSCredentials credentials, AmazonGlueConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGlueClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGlueConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlueClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGlueConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGlueClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGlueClient Configuration Object</param>
        public AmazonGlueClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGlueConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGlueClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGlueConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlueClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGlueConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlueClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGlueClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGlueClient Configuration Object</param>
        public AmazonGlueClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGlueConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonGlueEndpointResolver());
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


        #region  BatchCreatePartition

        /// <summary>
        /// Creates one or more partitions in a batch operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreatePartition service method.</param>
        /// 
        /// <returns>The response from the BatchCreatePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchCreatePartition">REST API Reference for BatchCreatePartition Operation</seealso>
        public virtual BatchCreatePartitionResponse BatchCreatePartition(BatchCreatePartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreatePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreatePartitionResponseUnmarshaller.Instance;

            return Invoke<BatchCreatePartitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreatePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreatePartition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreatePartition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchCreatePartition">REST API Reference for BatchCreatePartition Operation</seealso>
        public virtual IAsyncResult BeginBatchCreatePartition(BatchCreatePartitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreatePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreatePartitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreatePartition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreatePartition.</param>
        /// 
        /// <returns>Returns a  BatchCreatePartitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchCreatePartition">REST API Reference for BatchCreatePartition Operation</seealso>
        public virtual BatchCreatePartitionResponse EndBatchCreatePartition(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchCreatePartitionResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeleteConnection

        /// <summary>
        /// Deletes a list of connection definitions from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteConnection service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteConnection">REST API Reference for BatchDeleteConnection Operation</seealso>
        public virtual BatchDeleteConnectionResponse BatchDeleteConnection(BatchDeleteConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteConnection operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteConnection">REST API Reference for BatchDeleteConnection Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteConnection(BatchDeleteConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteConnection.</param>
        /// 
        /// <returns>Returns a  BatchDeleteConnectionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteConnection">REST API Reference for BatchDeleteConnection Operation</seealso>
        public virtual BatchDeleteConnectionResponse EndBatchDeleteConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeletePartition

        /// <summary>
        /// Deletes one or more partitions in a batch operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePartition service method.</param>
        /// 
        /// <returns>The response from the BatchDeletePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeletePartition">REST API Reference for BatchDeletePartition Operation</seealso>
        public virtual BatchDeletePartitionResponse BatchDeletePartition(BatchDeletePartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeletePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeletePartitionResponseUnmarshaller.Instance;

            return Invoke<BatchDeletePartitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeletePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePartition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeletePartition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeletePartition">REST API Reference for BatchDeletePartition Operation</seealso>
        public virtual IAsyncResult BeginBatchDeletePartition(BatchDeletePartitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeletePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeletePartitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeletePartition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeletePartition.</param>
        /// 
        /// <returns>Returns a  BatchDeletePartitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeletePartition">REST API Reference for BatchDeletePartition Operation</seealso>
        public virtual BatchDeletePartitionResponse EndBatchDeletePartition(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeletePartitionResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeleteTable

        /// <summary>
        /// Deletes multiple tables at once.
        /// 
        ///  <note> 
        /// <para>
        /// After completing this operation, you no longer have access to the table versions and
        /// partitions that belong to the deleted table. Glue deletes these "orphaned" resources
        /// asynchronously in a timely manner, at the discretion of the service.
        /// </para>
        ///  
        /// <para>
        /// To ensure the immediate deletion of all related resources, before calling <code>BatchDeleteTable</code>,
        /// use <code>DeleteTableVersion</code> or <code>BatchDeleteTableVersion</code>, and <code>DeletePartition</code>
        /// or <code>BatchDeletePartition</code>, to delete any resources that belong to the table.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTable service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNotReadyException">
        /// A resource was not ready for a transaction.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTable">REST API Reference for BatchDeleteTable Operation</seealso>
        public virtual BatchDeleteTableResponse BatchDeleteTable(BatchDeleteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteTableResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTable operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTable">REST API Reference for BatchDeleteTable Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteTable(BatchDeleteTableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteTable.</param>
        /// 
        /// <returns>Returns a  BatchDeleteTableResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTable">REST API Reference for BatchDeleteTable Operation</seealso>
        public virtual BatchDeleteTableResponse EndBatchDeleteTable(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteTableResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeleteTableVersion

        /// <summary>
        /// Deletes a specified batch of versions of a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTableVersion service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteTableVersion service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTableVersion">REST API Reference for BatchDeleteTableVersion Operation</seealso>
        public virtual BatchDeleteTableVersionResponse BatchDeleteTableVersion(BatchDeleteTableVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteTableVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteTableVersionResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteTableVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteTableVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTableVersion operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteTableVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTableVersion">REST API Reference for BatchDeleteTableVersion Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteTableVersion(BatchDeleteTableVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteTableVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteTableVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteTableVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteTableVersion.</param>
        /// 
        /// <returns>Returns a  BatchDeleteTableVersionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchDeleteTableVersion">REST API Reference for BatchDeleteTableVersion Operation</seealso>
        public virtual BatchDeleteTableVersionResponse EndBatchDeleteTableVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteTableVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetBlueprints

        /// <summary>
        /// Retrieves information about a list of blueprints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetBlueprints service method.</param>
        /// 
        /// <returns>The response from the BatchGetBlueprints service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetBlueprints">REST API Reference for BatchGetBlueprints Operation</seealso>
        public virtual BatchGetBlueprintsResponse BatchGetBlueprints(BatchGetBlueprintsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetBlueprintsResponseUnmarshaller.Instance;

            return Invoke<BatchGetBlueprintsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetBlueprints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetBlueprints operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetBlueprints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetBlueprints">REST API Reference for BatchGetBlueprints Operation</seealso>
        public virtual IAsyncResult BeginBatchGetBlueprints(BatchGetBlueprintsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetBlueprintsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetBlueprints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetBlueprints.</param>
        /// 
        /// <returns>Returns a  BatchGetBlueprintsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetBlueprints">REST API Reference for BatchGetBlueprints Operation</seealso>
        public virtual BatchGetBlueprintsResponse EndBatchGetBlueprints(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetBlueprintsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetCrawlers

        /// <summary>
        /// Returns a list of resource metadata for a given list of crawler names. After calling
        /// the <code>ListCrawlers</code> operation, you can call this operation to access the
        /// data to which you have been granted permissions. This operation supports all IAM permissions,
        /// including permission conditions that uses tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCrawlers service method.</param>
        /// 
        /// <returns>The response from the BatchGetCrawlers service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetCrawlers">REST API Reference for BatchGetCrawlers Operation</seealso>
        public virtual BatchGetCrawlersResponse BatchGetCrawlers(BatchGetCrawlersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetCrawlersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCrawlersResponseUnmarshaller.Instance;

            return Invoke<BatchGetCrawlersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetCrawlers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCrawlers operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetCrawlers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetCrawlers">REST API Reference for BatchGetCrawlers Operation</seealso>
        public virtual IAsyncResult BeginBatchGetCrawlers(BatchGetCrawlersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetCrawlersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCrawlersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetCrawlers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetCrawlers.</param>
        /// 
        /// <returns>Returns a  BatchGetCrawlersResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetCrawlers">REST API Reference for BatchGetCrawlers Operation</seealso>
        public virtual BatchGetCrawlersResponse EndBatchGetCrawlers(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetCrawlersResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetCustomEntityTypes

        /// <summary>
        /// Retrieves the details for the custom patterns specified by a list of names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCustomEntityTypes service method.</param>
        /// 
        /// <returns>The response from the BatchGetCustomEntityTypes service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetCustomEntityTypes">REST API Reference for BatchGetCustomEntityTypes Operation</seealso>
        public virtual BatchGetCustomEntityTypesResponse BatchGetCustomEntityTypes(BatchGetCustomEntityTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetCustomEntityTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCustomEntityTypesResponseUnmarshaller.Instance;

            return Invoke<BatchGetCustomEntityTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetCustomEntityTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCustomEntityTypes operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetCustomEntityTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetCustomEntityTypes">REST API Reference for BatchGetCustomEntityTypes Operation</seealso>
        public virtual IAsyncResult BeginBatchGetCustomEntityTypes(BatchGetCustomEntityTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetCustomEntityTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCustomEntityTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetCustomEntityTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetCustomEntityTypes.</param>
        /// 
        /// <returns>Returns a  BatchGetCustomEntityTypesResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetCustomEntityTypes">REST API Reference for BatchGetCustomEntityTypes Operation</seealso>
        public virtual BatchGetCustomEntityTypesResponse EndBatchGetCustomEntityTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetCustomEntityTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetDataQualityResult

        /// <summary>
        /// Retrieves a list of data quality results for the specified result IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDataQualityResult service method.</param>
        /// 
        /// <returns>The response from the BatchGetDataQualityResult service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetDataQualityResult">REST API Reference for BatchGetDataQualityResult Operation</seealso>
        public virtual BatchGetDataQualityResultResponse BatchGetDataQualityResult(BatchGetDataQualityResultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetDataQualityResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDataQualityResultResponseUnmarshaller.Instance;

            return Invoke<BatchGetDataQualityResultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetDataQualityResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDataQualityResult operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetDataQualityResult
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetDataQualityResult">REST API Reference for BatchGetDataQualityResult Operation</seealso>
        public virtual IAsyncResult BeginBatchGetDataQualityResult(BatchGetDataQualityResultRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetDataQualityResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDataQualityResultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetDataQualityResult operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetDataQualityResult.</param>
        /// 
        /// <returns>Returns a  BatchGetDataQualityResultResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetDataQualityResult">REST API Reference for BatchGetDataQualityResult Operation</seealso>
        public virtual BatchGetDataQualityResultResponse EndBatchGetDataQualityResult(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetDataQualityResultResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetDevEndpoints

        /// <summary>
        /// Returns a list of resource metadata for a given list of development endpoint names.
        /// After calling the <code>ListDevEndpoints</code> operation, you can call this operation
        /// to access the data to which you have been granted permissions. This operation supports
        /// all IAM permissions, including permission conditions that uses tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDevEndpoints service method.</param>
        /// 
        /// <returns>The response from the BatchGetDevEndpoints service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetDevEndpoints">REST API Reference for BatchGetDevEndpoints Operation</seealso>
        public virtual BatchGetDevEndpointsResponse BatchGetDevEndpoints(BatchGetDevEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetDevEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDevEndpointsResponseUnmarshaller.Instance;

            return Invoke<BatchGetDevEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetDevEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDevEndpoints operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetDevEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetDevEndpoints">REST API Reference for BatchGetDevEndpoints Operation</seealso>
        public virtual IAsyncResult BeginBatchGetDevEndpoints(BatchGetDevEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetDevEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDevEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetDevEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetDevEndpoints.</param>
        /// 
        /// <returns>Returns a  BatchGetDevEndpointsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetDevEndpoints">REST API Reference for BatchGetDevEndpoints Operation</seealso>
        public virtual BatchGetDevEndpointsResponse EndBatchGetDevEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetDevEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetJobs

        /// <summary>
        /// Returns a list of resource metadata for a given list of job names. After calling the
        /// <code>ListJobs</code> operation, you can call this operation to access the data to
        /// which you have been granted permissions. This operation supports all IAM permissions,
        /// including permission conditions that uses tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetJobs service method.</param>
        /// 
        /// <returns>The response from the BatchGetJobs service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetJobs">REST API Reference for BatchGetJobs Operation</seealso>
        public virtual BatchGetJobsResponse BatchGetJobs(BatchGetJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetJobsResponseUnmarshaller.Instance;

            return Invoke<BatchGetJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetJobs operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetJobs">REST API Reference for BatchGetJobs Operation</seealso>
        public virtual IAsyncResult BeginBatchGetJobs(BatchGetJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetJobs.</param>
        /// 
        /// <returns>Returns a  BatchGetJobsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetJobs">REST API Reference for BatchGetJobs Operation</seealso>
        public virtual BatchGetJobsResponse EndBatchGetJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetPartition

        /// <summary>
        /// Retrieves partitions in a batch request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPartition service method.</param>
        /// 
        /// <returns>The response from the BatchGetPartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidStateException">
        /// An error that indicates your data is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetPartition">REST API Reference for BatchGetPartition Operation</seealso>
        public virtual BatchGetPartitionResponse BatchGetPartition(BatchGetPartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetPartitionResponseUnmarshaller.Instance;

            return Invoke<BatchGetPartitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetPartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPartition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetPartition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetPartition">REST API Reference for BatchGetPartition Operation</seealso>
        public virtual IAsyncResult BeginBatchGetPartition(BatchGetPartitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetPartitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetPartition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetPartition.</param>
        /// 
        /// <returns>Returns a  BatchGetPartitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetPartition">REST API Reference for BatchGetPartition Operation</seealso>
        public virtual BatchGetPartitionResponse EndBatchGetPartition(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetPartitionResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetTriggers

        /// <summary>
        /// Returns a list of resource metadata for a given list of trigger names. After calling
        /// the <code>ListTriggers</code> operation, you can call this operation to access the
        /// data to which you have been granted permissions. This operation supports all IAM permissions,
        /// including permission conditions that uses tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTriggers service method.</param>
        /// 
        /// <returns>The response from the BatchGetTriggers service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetTriggers">REST API Reference for BatchGetTriggers Operation</seealso>
        public virtual BatchGetTriggersResponse BatchGetTriggers(BatchGetTriggersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetTriggersResponseUnmarshaller.Instance;

            return Invoke<BatchGetTriggersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetTriggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTriggers operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetTriggers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetTriggers">REST API Reference for BatchGetTriggers Operation</seealso>
        public virtual IAsyncResult BeginBatchGetTriggers(BatchGetTriggersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetTriggersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetTriggers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetTriggers.</param>
        /// 
        /// <returns>Returns a  BatchGetTriggersResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetTriggers">REST API Reference for BatchGetTriggers Operation</seealso>
        public virtual BatchGetTriggersResponse EndBatchGetTriggers(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetTriggersResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetWorkflows

        /// <summary>
        /// Returns a list of resource metadata for a given list of workflow names. After calling
        /// the <code>ListWorkflows</code> operation, you can call this operation to access the
        /// data to which you have been granted permissions. This operation supports all IAM permissions,
        /// including permission conditions that uses tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetWorkflows service method.</param>
        /// 
        /// <returns>The response from the BatchGetWorkflows service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetWorkflows">REST API Reference for BatchGetWorkflows Operation</seealso>
        public virtual BatchGetWorkflowsResponse BatchGetWorkflows(BatchGetWorkflowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetWorkflowsResponseUnmarshaller.Instance;

            return Invoke<BatchGetWorkflowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetWorkflows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetWorkflows operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetWorkflows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetWorkflows">REST API Reference for BatchGetWorkflows Operation</seealso>
        public virtual IAsyncResult BeginBatchGetWorkflows(BatchGetWorkflowsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetWorkflowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetWorkflows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetWorkflows.</param>
        /// 
        /// <returns>Returns a  BatchGetWorkflowsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchGetWorkflows">REST API Reference for BatchGetWorkflows Operation</seealso>
        public virtual BatchGetWorkflowsResponse EndBatchGetWorkflows(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetWorkflowsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchStopJobRun

        /// <summary>
        /// Stops one or more job runs for a specified job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchStopJobRun service method.</param>
        /// 
        /// <returns>The response from the BatchStopJobRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchStopJobRun">REST API Reference for BatchStopJobRun Operation</seealso>
        public virtual BatchStopJobRunResponse BatchStopJobRun(BatchStopJobRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchStopJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchStopJobRunResponseUnmarshaller.Instance;

            return Invoke<BatchStopJobRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchStopJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchStopJobRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchStopJobRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchStopJobRun">REST API Reference for BatchStopJobRun Operation</seealso>
        public virtual IAsyncResult BeginBatchStopJobRun(BatchStopJobRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchStopJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchStopJobRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchStopJobRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchStopJobRun.</param>
        /// 
        /// <returns>Returns a  BatchStopJobRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchStopJobRun">REST API Reference for BatchStopJobRun Operation</seealso>
        public virtual BatchStopJobRunResponse EndBatchStopJobRun(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchStopJobRunResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchUpdatePartition

        /// <summary>
        /// Updates one or more partitions in a batch operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdatePartition service method.</param>
        /// 
        /// <returns>The response from the BatchUpdatePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchUpdatePartition">REST API Reference for BatchUpdatePartition Operation</seealso>
        public virtual BatchUpdatePartitionResponse BatchUpdatePartition(BatchUpdatePartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdatePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdatePartitionResponseUnmarshaller.Instance;

            return Invoke<BatchUpdatePartitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdatePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdatePartition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdatePartition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchUpdatePartition">REST API Reference for BatchUpdatePartition Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdatePartition(BatchUpdatePartitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdatePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdatePartitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdatePartition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdatePartition.</param>
        /// 
        /// <returns>Returns a  BatchUpdatePartitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/BatchUpdatePartition">REST API Reference for BatchUpdatePartition Operation</seealso>
        public virtual BatchUpdatePartitionResponse EndBatchUpdatePartition(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdatePartitionResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelDataQualityRuleRecommendationRun

        /// <summary>
        /// Cancels the specified recommendation run that was being used to generate rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDataQualityRuleRecommendationRun service method.</param>
        /// 
        /// <returns>The response from the CancelDataQualityRuleRecommendationRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CancelDataQualityRuleRecommendationRun">REST API Reference for CancelDataQualityRuleRecommendationRun Operation</seealso>
        public virtual CancelDataQualityRuleRecommendationRunResponse CancelDataQualityRuleRecommendationRun(CancelDataQualityRuleRecommendationRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelDataQualityRuleRecommendationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDataQualityRuleRecommendationRunResponseUnmarshaller.Instance;

            return Invoke<CancelDataQualityRuleRecommendationRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelDataQualityRuleRecommendationRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelDataQualityRuleRecommendationRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelDataQualityRuleRecommendationRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CancelDataQualityRuleRecommendationRun">REST API Reference for CancelDataQualityRuleRecommendationRun Operation</seealso>
        public virtual IAsyncResult BeginCancelDataQualityRuleRecommendationRun(CancelDataQualityRuleRecommendationRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelDataQualityRuleRecommendationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDataQualityRuleRecommendationRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelDataQualityRuleRecommendationRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelDataQualityRuleRecommendationRun.</param>
        /// 
        /// <returns>Returns a  CancelDataQualityRuleRecommendationRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CancelDataQualityRuleRecommendationRun">REST API Reference for CancelDataQualityRuleRecommendationRun Operation</seealso>
        public virtual CancelDataQualityRuleRecommendationRunResponse EndCancelDataQualityRuleRecommendationRun(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelDataQualityRuleRecommendationRunResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelDataQualityRulesetEvaluationRun

        /// <summary>
        /// Cancels a run where a ruleset is being evaluated against a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDataQualityRulesetEvaluationRun service method.</param>
        /// 
        /// <returns>The response from the CancelDataQualityRulesetEvaluationRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CancelDataQualityRulesetEvaluationRun">REST API Reference for CancelDataQualityRulesetEvaluationRun Operation</seealso>
        public virtual CancelDataQualityRulesetEvaluationRunResponse CancelDataQualityRulesetEvaluationRun(CancelDataQualityRulesetEvaluationRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelDataQualityRulesetEvaluationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDataQualityRulesetEvaluationRunResponseUnmarshaller.Instance;

            return Invoke<CancelDataQualityRulesetEvaluationRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelDataQualityRulesetEvaluationRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelDataQualityRulesetEvaluationRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelDataQualityRulesetEvaluationRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CancelDataQualityRulesetEvaluationRun">REST API Reference for CancelDataQualityRulesetEvaluationRun Operation</seealso>
        public virtual IAsyncResult BeginCancelDataQualityRulesetEvaluationRun(CancelDataQualityRulesetEvaluationRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelDataQualityRulesetEvaluationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDataQualityRulesetEvaluationRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelDataQualityRulesetEvaluationRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelDataQualityRulesetEvaluationRun.</param>
        /// 
        /// <returns>Returns a  CancelDataQualityRulesetEvaluationRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CancelDataQualityRulesetEvaluationRun">REST API Reference for CancelDataQualityRulesetEvaluationRun Operation</seealso>
        public virtual CancelDataQualityRulesetEvaluationRunResponse EndCancelDataQualityRulesetEvaluationRun(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelDataQualityRulesetEvaluationRunResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelMLTaskRun

        /// <summary>
        /// Cancels (stops) a task run. Machine learning task runs are asynchronous tasks that
        /// Glue runs on your behalf as part of various machine learning workflows. You can cancel
        /// a machine learning task run at any time by calling <code>CancelMLTaskRun</code> with
        /// a task run's parent transform's <code>TransformID</code> and the task run's <code>TaskRunId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMLTaskRun service method.</param>
        /// 
        /// <returns>The response from the CancelMLTaskRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CancelMLTaskRun">REST API Reference for CancelMLTaskRun Operation</seealso>
        public virtual CancelMLTaskRunResponse CancelMLTaskRun(CancelMLTaskRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelMLTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMLTaskRunResponseUnmarshaller.Instance;

            return Invoke<CancelMLTaskRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelMLTaskRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelMLTaskRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelMLTaskRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CancelMLTaskRun">REST API Reference for CancelMLTaskRun Operation</seealso>
        public virtual IAsyncResult BeginCancelMLTaskRun(CancelMLTaskRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelMLTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMLTaskRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelMLTaskRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelMLTaskRun.</param>
        /// 
        /// <returns>Returns a  CancelMLTaskRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CancelMLTaskRun">REST API Reference for CancelMLTaskRun Operation</seealso>
        public virtual CancelMLTaskRunResponse EndCancelMLTaskRun(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelMLTaskRunResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelStatement

        /// <summary>
        /// Cancels the statement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelStatement service method.</param>
        /// 
        /// <returns>The response from the CancelStatement service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IllegalSessionStateException">
        /// The session is in an invalid state to perform a requested operation.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CancelStatement">REST API Reference for CancelStatement Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the CancelStatement operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CancelStatement">REST API Reference for CancelStatement Operation</seealso>
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
        /// <returns>Returns a  CancelStatementResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CancelStatement">REST API Reference for CancelStatement Operation</seealso>
        public virtual CancelStatementResponse EndCancelStatement(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelStatementResponse>(asyncResult);
        }

        #endregion
        
        #region  CheckSchemaVersionValidity

        /// <summary>
        /// Validates the supplied schema. This call has no side effects, it simply validates
        /// using the supplied schema using <code>DataFormat</code> as the format. Since it does
        /// not take a schema set name, no compatibility checks are performed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckSchemaVersionValidity service method.</param>
        /// 
        /// <returns>The response from the CheckSchemaVersionValidity service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CheckSchemaVersionValidity">REST API Reference for CheckSchemaVersionValidity Operation</seealso>
        public virtual CheckSchemaVersionValidityResponse CheckSchemaVersionValidity(CheckSchemaVersionValidityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckSchemaVersionValidityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckSchemaVersionValidityResponseUnmarshaller.Instance;

            return Invoke<CheckSchemaVersionValidityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CheckSchemaVersionValidity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckSchemaVersionValidity operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckSchemaVersionValidity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CheckSchemaVersionValidity">REST API Reference for CheckSchemaVersionValidity Operation</seealso>
        public virtual IAsyncResult BeginCheckSchemaVersionValidity(CheckSchemaVersionValidityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckSchemaVersionValidityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckSchemaVersionValidityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CheckSchemaVersionValidity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckSchemaVersionValidity.</param>
        /// 
        /// <returns>Returns a  CheckSchemaVersionValidityResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CheckSchemaVersionValidity">REST API Reference for CheckSchemaVersionValidity Operation</seealso>
        public virtual CheckSchemaVersionValidityResponse EndCheckSchemaVersionValidity(IAsyncResult asyncResult)
        {
            return EndInvoke<CheckSchemaVersionValidityResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBlueprint

        /// <summary>
        /// Registers a blueprint with Glue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueprint service method.</param>
        /// 
        /// <returns>The response from the CreateBlueprint service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateBlueprint">REST API Reference for CreateBlueprint Operation</seealso>
        public virtual CreateBlueprintResponse CreateBlueprint(CreateBlueprintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBlueprintResponseUnmarshaller.Instance;

            return Invoke<CreateBlueprintResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBlueprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueprint operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBlueprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateBlueprint">REST API Reference for CreateBlueprint Operation</seealso>
        public virtual IAsyncResult BeginCreateBlueprint(CreateBlueprintRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBlueprintResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBlueprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBlueprint.</param>
        /// 
        /// <returns>Returns a  CreateBlueprintResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateBlueprint">REST API Reference for CreateBlueprint Operation</seealso>
        public virtual CreateBlueprintResponse EndCreateBlueprint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBlueprintResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateClassifier

        /// <summary>
        /// Creates a classifier in the user's account. This can be a <code>GrokClassifier</code>,
        /// an <code>XMLClassifier</code>, a <code>JsonClassifier</code>, or a <code>CsvClassifier</code>,
        /// depending on which field of the request is present.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClassifier service method.</param>
        /// 
        /// <returns>The response from the CreateClassifier service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateClassifier">REST API Reference for CreateClassifier Operation</seealso>
        public virtual CreateClassifierResponse CreateClassifier(CreateClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClassifierResponseUnmarshaller.Instance;

            return Invoke<CreateClassifierResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClassifier operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClassifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateClassifier">REST API Reference for CreateClassifier Operation</seealso>
        public virtual IAsyncResult BeginCreateClassifier(CreateClassifierRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClassifierResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClassifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClassifier.</param>
        /// 
        /// <returns>Returns a  CreateClassifierResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateClassifier">REST API Reference for CreateClassifier Operation</seealso>
        public virtual CreateClassifierResponse EndCreateClassifier(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateClassifierResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConnection

        /// <summary>
        /// Creates a connection definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual IAsyncResult BeginCreateConnection(CreateConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnection.</param>
        /// 
        /// <returns>Returns a  CreateConnectionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual CreateConnectionResponse EndCreateConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCrawler

        /// <summary>
        /// Creates a new crawler with specified targets, role, configuration, and optional schedule.
        /// At least one crawl target must be specified, in the <code>s3Targets</code> field,
        /// the <code>jdbcTargets</code> field, or the <code>DynamoDBTargets</code> field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCrawler service method.</param>
        /// 
        /// <returns>The response from the CreateCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateCrawler">REST API Reference for CreateCrawler Operation</seealso>
        public virtual CreateCrawlerResponse CreateCrawler(CreateCrawlerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCrawlerResponseUnmarshaller.Instance;

            return Invoke<CreateCrawlerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCrawler operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCrawler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateCrawler">REST API Reference for CreateCrawler Operation</seealso>
        public virtual IAsyncResult BeginCreateCrawler(CreateCrawlerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCrawlerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCrawler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCrawler.</param>
        /// 
        /// <returns>Returns a  CreateCrawlerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateCrawler">REST API Reference for CreateCrawler Operation</seealso>
        public virtual CreateCrawlerResponse EndCreateCrawler(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCrawlerResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCustomEntityType

        /// <summary>
        /// Creates a custom pattern that is used to detect sensitive data across the columns
        /// and rows of your structured data.
        /// 
        ///  
        /// <para>
        /// Each custom pattern you create specifies a regular expression and an optional list
        /// of context words. If no context words are passed only a regular expression is checked.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomEntityType service method.</param>
        /// 
        /// <returns>The response from the CreateCustomEntityType service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IdempotentParameterMismatchException">
        /// The same unique identifier was associated with two different records.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateCustomEntityType">REST API Reference for CreateCustomEntityType Operation</seealso>
        public virtual CreateCustomEntityTypeResponse CreateCustomEntityType(CreateCustomEntityTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomEntityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomEntityTypeResponseUnmarshaller.Instance;

            return Invoke<CreateCustomEntityTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomEntityType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomEntityType operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomEntityType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateCustomEntityType">REST API Reference for CreateCustomEntityType Operation</seealso>
        public virtual IAsyncResult BeginCreateCustomEntityType(CreateCustomEntityTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomEntityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomEntityTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomEntityType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomEntityType.</param>
        /// 
        /// <returns>Returns a  CreateCustomEntityTypeResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateCustomEntityType">REST API Reference for CreateCustomEntityType Operation</seealso>
        public virtual CreateCustomEntityTypeResponse EndCreateCustomEntityType(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCustomEntityTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDatabase

        /// <summary>
        /// Creates a new database in a Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatabase service method.</param>
        /// 
        /// <returns>The response from the CreateDatabase service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDatabase">REST API Reference for CreateDatabase Operation</seealso>
        public virtual CreateDatabaseResponse CreateDatabase(CreateDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatabaseResponseUnmarshaller.Instance;

            return Invoke<CreateDatabaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatabase operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDatabase">REST API Reference for CreateDatabase Operation</seealso>
        public virtual IAsyncResult BeginCreateDatabase(CreateDatabaseRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatabaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatabase.</param>
        /// 
        /// <returns>Returns a  CreateDatabaseResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDatabase">REST API Reference for CreateDatabase Operation</seealso>
        public virtual CreateDatabaseResponse EndCreateDatabase(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDatabaseResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataQualityRuleset

        /// <summary>
        /// Creates a data quality ruleset with DQDL rules applied to a specified Glue table.
        /// 
        ///  
        /// <para>
        /// You create the ruleset using the Data Quality Definition Language (DQDL). For more
        /// information, see the Glue developer guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataQualityRuleset service method.</param>
        /// 
        /// <returns>The response from the CreateDataQualityRuleset service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDataQualityRuleset">REST API Reference for CreateDataQualityRuleset Operation</seealso>
        public virtual CreateDataQualityRulesetResponse CreateDataQualityRuleset(CreateDataQualityRulesetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataQualityRulesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataQualityRulesetResponseUnmarshaller.Instance;

            return Invoke<CreateDataQualityRulesetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataQualityRuleset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataQualityRuleset operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataQualityRuleset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDataQualityRuleset">REST API Reference for CreateDataQualityRuleset Operation</seealso>
        public virtual IAsyncResult BeginCreateDataQualityRuleset(CreateDataQualityRulesetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataQualityRulesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataQualityRulesetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataQualityRuleset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataQualityRuleset.</param>
        /// 
        /// <returns>Returns a  CreateDataQualityRulesetResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDataQualityRuleset">REST API Reference for CreateDataQualityRuleset Operation</seealso>
        public virtual CreateDataQualityRulesetResponse EndCreateDataQualityRuleset(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataQualityRulesetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDevEndpoint

        /// <summary>
        /// Creates a new development endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDevEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateDevEndpoint service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IdempotentParameterMismatchException">
        /// The same unique identifier was associated with two different records.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ValidationException">
        /// A value could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDevEndpoint">REST API Reference for CreateDevEndpoint Operation</seealso>
        public virtual CreateDevEndpointResponse CreateDevEndpoint(CreateDevEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDevEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDevEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateDevEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDevEndpoint operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDevEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDevEndpoint">REST API Reference for CreateDevEndpoint Operation</seealso>
        public virtual IAsyncResult BeginCreateDevEndpoint(CreateDevEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDevEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDevEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDevEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateDevEndpointResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateDevEndpoint">REST API Reference for CreateDevEndpoint Operation</seealso>
        public virtual CreateDevEndpointResponse EndCreateDevEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDevEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateJob

        /// <summary>
        /// Creates a new job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IdempotentParameterMismatchException">
        /// The same unique identifier was associated with two different records.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return Invoke<CreateJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual IAsyncResult BeginCreateJob(CreateJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJob.</param>
        /// 
        /// <returns>Returns a  CreateJobResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual CreateJobResponse EndCreateJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMLTransform

        /// <summary>
        /// Creates an Glue machine learning transform. This operation creates the transform and
        /// all the necessary parameters to train it.
        /// 
        ///  
        /// <para>
        /// Call this operation as the first step in the process of using a machine learning transform
        /// (such as the <code>FindMatches</code> transform) for deduplicating data. You can provide
        /// an optional <code>Description</code>, in addition to the parameters that you want
        /// to use for your algorithm.
        /// </para>
        ///  
        /// <para>
        /// You must also specify certain parameters for the tasks that Glue runs on your behalf
        /// as part of learning from your data and creating a high-quality machine learning transform.
        /// These parameters include <code>Role</code>, and optionally, <code>AllocatedCapacity</code>,
        /// <code>Timeout</code>, and <code>MaxRetries</code>. For more information, see <a href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-api-jobs-job.html">Jobs</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMLTransform service method.</param>
        /// 
        /// <returns>The response from the CreateMLTransform service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IdempotentParameterMismatchException">
        /// The same unique identifier was associated with two different records.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateMLTransform">REST API Reference for CreateMLTransform Operation</seealso>
        public virtual CreateMLTransformResponse CreateMLTransform(CreateMLTransformRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMLTransformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMLTransformResponseUnmarshaller.Instance;

            return Invoke<CreateMLTransformResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMLTransform operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMLTransform operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMLTransform
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateMLTransform">REST API Reference for CreateMLTransform Operation</seealso>
        public virtual IAsyncResult BeginCreateMLTransform(CreateMLTransformRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMLTransformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMLTransformResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMLTransform operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMLTransform.</param>
        /// 
        /// <returns>Returns a  CreateMLTransformResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateMLTransform">REST API Reference for CreateMLTransform Operation</seealso>
        public virtual CreateMLTransformResponse EndCreateMLTransform(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMLTransformResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePartition

        /// <summary>
        /// Creates a new partition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartition service method.</param>
        /// 
        /// <returns>The response from the CreatePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreatePartition">REST API Reference for CreatePartition Operation</seealso>
        public virtual CreatePartitionResponse CreatePartition(CreatePartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartitionResponseUnmarshaller.Instance;

            return Invoke<CreatePartitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePartition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePartition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreatePartition">REST API Reference for CreatePartition Operation</seealso>
        public virtual IAsyncResult BeginCreatePartition(CreatePartitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePartition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePartition.</param>
        /// 
        /// <returns>Returns a  CreatePartitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreatePartition">REST API Reference for CreatePartition Operation</seealso>
        public virtual CreatePartitionResponse EndCreatePartition(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePartitionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePartitionIndex

        /// <summary>
        /// Creates a specified partition index in an existing table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartitionIndex service method.</param>
        /// 
        /// <returns>The response from the CreatePartitionIndex service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreatePartitionIndex">REST API Reference for CreatePartitionIndex Operation</seealso>
        public virtual CreatePartitionIndexResponse CreatePartitionIndex(CreatePartitionIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePartitionIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartitionIndexResponseUnmarshaller.Instance;

            return Invoke<CreatePartitionIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePartitionIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePartitionIndex operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePartitionIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreatePartitionIndex">REST API Reference for CreatePartitionIndex Operation</seealso>
        public virtual IAsyncResult BeginCreatePartitionIndex(CreatePartitionIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePartitionIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePartitionIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePartitionIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePartitionIndex.</param>
        /// 
        /// <returns>Returns a  CreatePartitionIndexResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreatePartitionIndex">REST API Reference for CreatePartitionIndex Operation</seealso>
        public virtual CreatePartitionIndexResponse EndCreatePartitionIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePartitionIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRegistry

        /// <summary>
        /// Creates a new registry which may be used to hold a collection of schemas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistry service method.</param>
        /// 
        /// <returns>The response from the CreateRegistry service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateRegistry">REST API Reference for CreateRegistry Operation</seealso>
        public virtual CreateRegistryResponse CreateRegistry(CreateRegistryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistryResponseUnmarshaller.Instance;

            return Invoke<CreateRegistryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRegistry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistry operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRegistry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateRegistry">REST API Reference for CreateRegistry Operation</seealso>
        public virtual IAsyncResult BeginCreateRegistry(CreateRegistryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRegistry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRegistry.</param>
        /// 
        /// <returns>Returns a  CreateRegistryResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateRegistry">REST API Reference for CreateRegistry Operation</seealso>
        public virtual CreateRegistryResponse EndCreateRegistry(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRegistryResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSchema

        /// <summary>
        /// Creates a new schema set and registers the schema definition. Returns an error if
        /// the schema set already exists without actually registering the version.
        /// 
        ///  
        /// <para>
        /// When the schema set is created, a version checkpoint will be set to the first version.
        /// Compatibility mode "DISABLED" restricts any additional schema versions from being
        /// added after the first schema version. For all other compatibility modes, validation
        /// of compatibility settings will be applied only from the second version onwards when
        /// the <code>RegisterSchemaVersion</code> API is used.
        /// </para>
        ///  
        /// <para>
        /// When this API is called without a <code>RegistryId</code>, this will create an entry
        /// for a "default-registry" in the registry database tables, if it is not already present.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchema service method.</param>
        /// 
        /// <returns>The response from the CreateSchema service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public virtual CreateSchemaResponse CreateSchema(CreateSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return Invoke<CreateSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSchema operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public virtual IAsyncResult BeginCreateSchema(CreateSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSchema.</param>
        /// 
        /// <returns>Returns a  CreateSchemaResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public virtual CreateSchemaResponse EndCreateSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateScript

        /// <summary>
        /// Transforms a directed acyclic graph (DAG) into code.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScript service method.</param>
        /// 
        /// <returns>The response from the CreateScript service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateScript">REST API Reference for CreateScript Operation</seealso>
        public virtual CreateScriptResponse CreateScript(CreateScriptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScriptResponseUnmarshaller.Instance;

            return Invoke<CreateScriptResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScript operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateScript
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateScript">REST API Reference for CreateScript Operation</seealso>
        public virtual IAsyncResult BeginCreateScript(CreateScriptRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScriptResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateScript operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateScript.</param>
        /// 
        /// <returns>Returns a  CreateScriptResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateScript">REST API Reference for CreateScript Operation</seealso>
        public virtual CreateScriptResponse EndCreateScript(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateScriptResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSecurityConfiguration

        /// <summary>
        /// Creates a new security configuration. A security configuration is a set of security
        /// properties that can be used by Glue. You can use a security configuration to encrypt
        /// data at rest. For information about using security configurations in Glue, see <a
        /// href="https://docs.aws.amazon.com/glue/latest/dg/encryption-security-configuration.html">Encrypting
        /// Data Written by Crawlers, Jobs, and Development Endpoints</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateSecurityConfiguration service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateSecurityConfiguration">REST API Reference for CreateSecurityConfiguration Operation</seealso>
        public virtual CreateSecurityConfigurationResponse CreateSecurityConfiguration(CreateSecurityConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityConfiguration operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSecurityConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateSecurityConfiguration">REST API Reference for CreateSecurityConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateSecurityConfiguration(CreateSecurityConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSecurityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSecurityConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateSecurityConfigurationResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateSecurityConfiguration">REST API Reference for CreateSecurityConfiguration Operation</seealso>
        public virtual CreateSecurityConfigurationResponse EndCreateSecurityConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSecurityConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSession

        /// <summary>
        /// Creates a new session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSession service method.</param>
        /// 
        /// <returns>The response from the CreateSession service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IdempotentParameterMismatchException">
        /// The same unique identifier was associated with two different records.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ValidationException">
        /// A value could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateSession">REST API Reference for CreateSession Operation</seealso>
        public virtual CreateSessionResponse CreateSession(CreateSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSessionResponseUnmarshaller.Instance;

            return Invoke<CreateSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSession operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateSession">REST API Reference for CreateSession Operation</seealso>
        public virtual IAsyncResult BeginCreateSession(CreateSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSession.</param>
        /// 
        /// <returns>Returns a  CreateSessionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateSession">REST API Reference for CreateSession Operation</seealso>
        public virtual CreateSessionResponse EndCreateSession(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTable

        /// <summary>
        /// Creates a new table definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTable service method.</param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNotReadyException">
        /// A resource was not ready for a transaction.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTable">REST API Reference for CreateTable Operation</seealso>
        public virtual CreateTableResponse CreateTable(CreateTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableResponseUnmarshaller.Instance;

            return Invoke<CreateTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTable operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTable">REST API Reference for CreateTable Operation</seealso>
        public virtual IAsyncResult BeginCreateTable(CreateTableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTable.</param>
        /// 
        /// <returns>Returns a  CreateTableResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTable">REST API Reference for CreateTable Operation</seealso>
        public virtual CreateTableResponse EndCreateTable(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTableResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTrigger

        /// <summary>
        /// Creates a new trigger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrigger service method.</param>
        /// 
        /// <returns>The response from the CreateTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IdempotentParameterMismatchException">
        /// The same unique identifier was associated with two different records.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTrigger">REST API Reference for CreateTrigger Operation</seealso>
        public virtual CreateTriggerResponse CreateTrigger(CreateTriggerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTriggerResponseUnmarshaller.Instance;

            return Invoke<CreateTriggerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrigger operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrigger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTrigger">REST API Reference for CreateTrigger Operation</seealso>
        public virtual IAsyncResult BeginCreateTrigger(CreateTriggerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTriggerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrigger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrigger.</param>
        /// 
        /// <returns>Returns a  CreateTriggerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateTrigger">REST API Reference for CreateTrigger Operation</seealso>
        public virtual CreateTriggerResponse EndCreateTrigger(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTriggerResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUserDefinedFunction

        /// <summary>
        /// Creates a new function definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserDefinedFunction service method.</param>
        /// 
        /// <returns>The response from the CreateUserDefinedFunction service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateUserDefinedFunction">REST API Reference for CreateUserDefinedFunction Operation</seealso>
        public virtual CreateUserDefinedFunctionResponse CreateUserDefinedFunction(CreateUserDefinedFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserDefinedFunctionResponseUnmarshaller.Instance;

            return Invoke<CreateUserDefinedFunctionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserDefinedFunction operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserDefinedFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateUserDefinedFunction">REST API Reference for CreateUserDefinedFunction Operation</seealso>
        public virtual IAsyncResult BeginCreateUserDefinedFunction(CreateUserDefinedFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserDefinedFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserDefinedFunction.</param>
        /// 
        /// <returns>Returns a  CreateUserDefinedFunctionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateUserDefinedFunction">REST API Reference for CreateUserDefinedFunction Operation</seealso>
        public virtual CreateUserDefinedFunctionResponse EndCreateUserDefinedFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserDefinedFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWorkflow

        /// <summary>
        /// Creates a new workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow service method.</param>
        /// 
        /// <returns>The response from the CreateWorkflow service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        public virtual CreateWorkflowResponse CreateWorkflow(CreateWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowResponseUnmarshaller.Instance;

            return Invoke<CreateWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        public virtual IAsyncResult BeginCreateWorkflow(CreateWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkflow.</param>
        /// 
        /// <returns>Returns a  CreateWorkflowResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        public virtual CreateWorkflowResponse EndCreateWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBlueprint

        /// <summary>
        /// Deletes an existing blueprint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBlueprint service method.</param>
        /// 
        /// <returns>The response from the DeleteBlueprint service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteBlueprint">REST API Reference for DeleteBlueprint Operation</seealso>
        public virtual DeleteBlueprintResponse DeleteBlueprint(DeleteBlueprintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBlueprintResponseUnmarshaller.Instance;

            return Invoke<DeleteBlueprintResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBlueprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBlueprint operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBlueprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteBlueprint">REST API Reference for DeleteBlueprint Operation</seealso>
        public virtual IAsyncResult BeginDeleteBlueprint(DeleteBlueprintRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBlueprintResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBlueprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBlueprint.</param>
        /// 
        /// <returns>Returns a  DeleteBlueprintResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteBlueprint">REST API Reference for DeleteBlueprint Operation</seealso>
        public virtual DeleteBlueprintResponse EndDeleteBlueprint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBlueprintResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteClassifier

        /// <summary>
        /// Removes a classifier from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClassifier service method.</param>
        /// 
        /// <returns>The response from the DeleteClassifier service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteClassifier">REST API Reference for DeleteClassifier Operation</seealso>
        public virtual DeleteClassifierResponse DeleteClassifier(DeleteClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClassifierResponseUnmarshaller.Instance;

            return Invoke<DeleteClassifierResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClassifier operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClassifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteClassifier">REST API Reference for DeleteClassifier Operation</seealso>
        public virtual IAsyncResult BeginDeleteClassifier(DeleteClassifierRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClassifierResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClassifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClassifier.</param>
        /// 
        /// <returns>Returns a  DeleteClassifierResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteClassifier">REST API Reference for DeleteClassifier Operation</seealso>
        public virtual DeleteClassifierResponse EndDeleteClassifier(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClassifierResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteColumnStatisticsForPartition

        /// <summary>
        /// Delete the partition column statistics of a column.
        /// 
        ///  
        /// <para>
        /// The Identity and Access Management (IAM) permission required for this operation is
        /// <code>DeletePartition</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteColumnStatisticsForPartition service method.</param>
        /// 
        /// <returns>The response from the DeleteColumnStatisticsForPartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteColumnStatisticsForPartition">REST API Reference for DeleteColumnStatisticsForPartition Operation</seealso>
        public virtual DeleteColumnStatisticsForPartitionResponse DeleteColumnStatisticsForPartition(DeleteColumnStatisticsForPartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteColumnStatisticsForPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteColumnStatisticsForPartitionResponseUnmarshaller.Instance;

            return Invoke<DeleteColumnStatisticsForPartitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteColumnStatisticsForPartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteColumnStatisticsForPartition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteColumnStatisticsForPartition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteColumnStatisticsForPartition">REST API Reference for DeleteColumnStatisticsForPartition Operation</seealso>
        public virtual IAsyncResult BeginDeleteColumnStatisticsForPartition(DeleteColumnStatisticsForPartitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteColumnStatisticsForPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteColumnStatisticsForPartitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteColumnStatisticsForPartition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteColumnStatisticsForPartition.</param>
        /// 
        /// <returns>Returns a  DeleteColumnStatisticsForPartitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteColumnStatisticsForPartition">REST API Reference for DeleteColumnStatisticsForPartition Operation</seealso>
        public virtual DeleteColumnStatisticsForPartitionResponse EndDeleteColumnStatisticsForPartition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteColumnStatisticsForPartitionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteColumnStatisticsForTable

        /// <summary>
        /// Retrieves table statistics of columns.
        /// 
        ///  
        /// <para>
        /// The Identity and Access Management (IAM) permission required for this operation is
        /// <code>DeleteTable</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteColumnStatisticsForTable service method.</param>
        /// 
        /// <returns>The response from the DeleteColumnStatisticsForTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteColumnStatisticsForTable">REST API Reference for DeleteColumnStatisticsForTable Operation</seealso>
        public virtual DeleteColumnStatisticsForTableResponse DeleteColumnStatisticsForTable(DeleteColumnStatisticsForTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteColumnStatisticsForTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteColumnStatisticsForTableResponseUnmarshaller.Instance;

            return Invoke<DeleteColumnStatisticsForTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteColumnStatisticsForTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteColumnStatisticsForTable operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteColumnStatisticsForTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteColumnStatisticsForTable">REST API Reference for DeleteColumnStatisticsForTable Operation</seealso>
        public virtual IAsyncResult BeginDeleteColumnStatisticsForTable(DeleteColumnStatisticsForTableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteColumnStatisticsForTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteColumnStatisticsForTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteColumnStatisticsForTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteColumnStatisticsForTable.</param>
        /// 
        /// <returns>Returns a  DeleteColumnStatisticsForTableResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteColumnStatisticsForTable">REST API Reference for DeleteColumnStatisticsForTable Operation</seealso>
        public virtual DeleteColumnStatisticsForTableResponse EndDeleteColumnStatisticsForTable(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteColumnStatisticsForTableResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConnection

        /// <summary>
        /// Deletes a connection from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual IAsyncResult BeginDeleteConnection(DeleteConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnection.</param>
        /// 
        /// <returns>Returns a  DeleteConnectionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual DeleteConnectionResponse EndDeleteConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCrawler

        /// <summary>
        /// Removes a specified crawler from the Glue Data Catalog, unless the crawler state is
        /// <code>RUNNING</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrawler service method.</param>
        /// 
        /// <returns>The response from the DeleteCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.CrawlerRunningException">
        /// The operation cannot be performed because the crawler is already running.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.SchedulerTransitioningException">
        /// The specified scheduler is transitioning.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteCrawler">REST API Reference for DeleteCrawler Operation</seealso>
        public virtual DeleteCrawlerResponse DeleteCrawler(DeleteCrawlerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCrawlerResponseUnmarshaller.Instance;

            return Invoke<DeleteCrawlerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrawler operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCrawler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteCrawler">REST API Reference for DeleteCrawler Operation</seealso>
        public virtual IAsyncResult BeginDeleteCrawler(DeleteCrawlerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCrawlerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCrawler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCrawler.</param>
        /// 
        /// <returns>Returns a  DeleteCrawlerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteCrawler">REST API Reference for DeleteCrawler Operation</seealso>
        public virtual DeleteCrawlerResponse EndDeleteCrawler(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCrawlerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCustomEntityType

        /// <summary>
        /// Deletes a custom pattern by specifying its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomEntityType service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomEntityType service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteCustomEntityType">REST API Reference for DeleteCustomEntityType Operation</seealso>
        public virtual DeleteCustomEntityTypeResponse DeleteCustomEntityType(DeleteCustomEntityTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomEntityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomEntityTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomEntityTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomEntityType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomEntityType operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomEntityType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteCustomEntityType">REST API Reference for DeleteCustomEntityType Operation</seealso>
        public virtual IAsyncResult BeginDeleteCustomEntityType(DeleteCustomEntityTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomEntityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomEntityTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomEntityType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomEntityType.</param>
        /// 
        /// <returns>Returns a  DeleteCustomEntityTypeResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteCustomEntityType">REST API Reference for DeleteCustomEntityType Operation</seealso>
        public virtual DeleteCustomEntityTypeResponse EndDeleteCustomEntityType(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCustomEntityTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDatabase

        /// <summary>
        /// Removes a specified database from a Data Catalog.
        /// 
        ///  <note> 
        /// <para>
        /// After completing this operation, you no longer have access to the tables (and all
        /// table versions and partitions that might belong to the tables) and the user-defined
        /// functions in the deleted database. Glue deletes these "orphaned" resources asynchronously
        /// in a timely manner, at the discretion of the service.
        /// </para>
        ///  
        /// <para>
        /// To ensure the immediate deletion of all related resources, before calling <code>DeleteDatabase</code>,
        /// use <code>DeleteTableVersion</code> or <code>BatchDeleteTableVersion</code>, <code>DeletePartition</code>
        /// or <code>BatchDeletePartition</code>, <code>DeleteUserDefinedFunction</code>, and
        /// <code>DeleteTable</code> or <code>BatchDeleteTable</code>, to delete any resources
        /// that belong to the database.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatabase service method.</param>
        /// 
        /// <returns>The response from the DeleteDatabase service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDatabase">REST API Reference for DeleteDatabase Operation</seealso>
        public virtual DeleteDatabaseResponse DeleteDatabase(DeleteDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatabaseResponseUnmarshaller.Instance;

            return Invoke<DeleteDatabaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatabase operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDatabase">REST API Reference for DeleteDatabase Operation</seealso>
        public virtual IAsyncResult BeginDeleteDatabase(DeleteDatabaseRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatabaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatabase.</param>
        /// 
        /// <returns>Returns a  DeleteDatabaseResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDatabase">REST API Reference for DeleteDatabase Operation</seealso>
        public virtual DeleteDatabaseResponse EndDeleteDatabase(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDatabaseResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataQualityRuleset

        /// <summary>
        /// Deletes a data quality ruleset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataQualityRuleset service method.</param>
        /// 
        /// <returns>The response from the DeleteDataQualityRuleset service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDataQualityRuleset">REST API Reference for DeleteDataQualityRuleset Operation</seealso>
        public virtual DeleteDataQualityRulesetResponse DeleteDataQualityRuleset(DeleteDataQualityRulesetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataQualityRulesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataQualityRulesetResponseUnmarshaller.Instance;

            return Invoke<DeleteDataQualityRulesetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataQualityRuleset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataQualityRuleset operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataQualityRuleset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDataQualityRuleset">REST API Reference for DeleteDataQualityRuleset Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataQualityRuleset(DeleteDataQualityRulesetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataQualityRulesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataQualityRulesetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataQualityRuleset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataQualityRuleset.</param>
        /// 
        /// <returns>Returns a  DeleteDataQualityRulesetResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDataQualityRuleset">REST API Reference for DeleteDataQualityRuleset Operation</seealso>
        public virtual DeleteDataQualityRulesetResponse EndDeleteDataQualityRuleset(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataQualityRulesetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDevEndpoint

        /// <summary>
        /// Deletes a specified development endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteDevEndpoint service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDevEndpoint">REST API Reference for DeleteDevEndpoint Operation</seealso>
        public virtual DeleteDevEndpointResponse DeleteDevEndpoint(DeleteDevEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDevEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDevEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteDevEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevEndpoint operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDevEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDevEndpoint">REST API Reference for DeleteDevEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDeleteDevEndpoint(DeleteDevEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDevEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDevEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDevEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteDevEndpointResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteDevEndpoint">REST API Reference for DeleteDevEndpoint Operation</seealso>
        public virtual DeleteDevEndpointResponse EndDeleteDevEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDevEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteJob

        /// <summary>
        /// Deletes a specified job definition. If the job definition is not found, no exception
        /// is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return Invoke<DeleteJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual IAsyncResult BeginDeleteJob(DeleteJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJob.</param>
        /// 
        /// <returns>Returns a  DeleteJobResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual DeleteJobResponse EndDeleteJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMLTransform

        /// <summary>
        /// Deletes an Glue machine learning transform. Machine learning transforms are a special
        /// type of transform that use machine learning to learn the details of the transformation
        /// to be performed by learning from examples provided by humans. These transformations
        /// are then saved by Glue. If you no longer need a transform, you can delete it by calling
        /// <code>DeleteMLTransforms</code>. However, any Glue jobs that still reference the deleted
        /// transform will no longer succeed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMLTransform service method.</param>
        /// 
        /// <returns>The response from the DeleteMLTransform service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteMLTransform">REST API Reference for DeleteMLTransform Operation</seealso>
        public virtual DeleteMLTransformResponse DeleteMLTransform(DeleteMLTransformRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMLTransformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMLTransformResponseUnmarshaller.Instance;

            return Invoke<DeleteMLTransformResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMLTransform operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMLTransform operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMLTransform
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteMLTransform">REST API Reference for DeleteMLTransform Operation</seealso>
        public virtual IAsyncResult BeginDeleteMLTransform(DeleteMLTransformRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMLTransformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMLTransformResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMLTransform operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMLTransform.</param>
        /// 
        /// <returns>Returns a  DeleteMLTransformResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteMLTransform">REST API Reference for DeleteMLTransform Operation</seealso>
        public virtual DeleteMLTransformResponse EndDeleteMLTransform(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMLTransformResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePartition

        /// <summary>
        /// Deletes a specified partition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePartition service method.</param>
        /// 
        /// <returns>The response from the DeletePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeletePartition">REST API Reference for DeletePartition Operation</seealso>
        public virtual DeletePartitionResponse DeletePartition(DeletePartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartitionResponseUnmarshaller.Instance;

            return Invoke<DeletePartitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePartition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePartition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeletePartition">REST API Reference for DeletePartition Operation</seealso>
        public virtual IAsyncResult BeginDeletePartition(DeletePartitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePartition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePartition.</param>
        /// 
        /// <returns>Returns a  DeletePartitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeletePartition">REST API Reference for DeletePartition Operation</seealso>
        public virtual DeletePartitionResponse EndDeletePartition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePartitionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePartitionIndex

        /// <summary>
        /// Deletes a specified partition index from an existing table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePartitionIndex service method.</param>
        /// 
        /// <returns>The response from the DeletePartitionIndex service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConflictException">
        /// The <code>CreatePartitions</code> API was called on a table that has indexes enabled.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeletePartitionIndex">REST API Reference for DeletePartitionIndex Operation</seealso>
        public virtual DeletePartitionIndexResponse DeletePartitionIndex(DeletePartitionIndexRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePartitionIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartitionIndexResponseUnmarshaller.Instance;

            return Invoke<DeletePartitionIndexResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePartitionIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePartitionIndex operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePartitionIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeletePartitionIndex">REST API Reference for DeletePartitionIndex Operation</seealso>
        public virtual IAsyncResult BeginDeletePartitionIndex(DeletePartitionIndexRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePartitionIndexRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePartitionIndexResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePartitionIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePartitionIndex.</param>
        /// 
        /// <returns>Returns a  DeletePartitionIndexResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeletePartitionIndex">REST API Reference for DeletePartitionIndex Operation</seealso>
        public virtual DeletePartitionIndexResponse EndDeletePartitionIndex(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePartitionIndexResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRegistry

        /// <summary>
        /// Delete the entire registry including schema and all of its versions. To get the status
        /// of the delete operation, you can call the <code>GetRegistry</code> API after the asynchronous
        /// call. Deleting a registry will deactivate all online operations for the registry such
        /// as the <code>UpdateRegistry</code>, <code>CreateSchema</code>, <code>UpdateSchema</code>,
        /// and <code>RegisterSchemaVersion</code> APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistry service method.</param>
        /// 
        /// <returns>The response from the DeleteRegistry service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteRegistry">REST API Reference for DeleteRegistry Operation</seealso>
        public virtual DeleteRegistryResponse DeleteRegistry(DeleteRegistryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistryResponseUnmarshaller.Instance;

            return Invoke<DeleteRegistryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRegistry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistry operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRegistry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteRegistry">REST API Reference for DeleteRegistry Operation</seealso>
        public virtual IAsyncResult BeginDeleteRegistry(DeleteRegistryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRegistry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRegistry.</param>
        /// 
        /// <returns>Returns a  DeleteRegistryResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteRegistry">REST API Reference for DeleteRegistry Operation</seealso>
        public virtual DeleteRegistryResponse EndDeleteRegistry(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRegistryResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResourcePolicy

        /// <summary>
        /// Deletes a specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConditionCheckFailureException">
        /// A specified condition was not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSchema

        /// <summary>
        /// Deletes the entire schema set, including the schema set and all of its versions. To
        /// get the status of the delete operation, you can call <code>GetSchema</code> API after
        /// the asynchronous call. Deleting a registry will deactivate all online operations for
        /// the schema, such as the <code>GetSchemaByDefinition</code>, and <code>RegisterSchemaVersion</code>
        /// APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema service method.</param>
        /// 
        /// <returns>The response from the DeleteSchema service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public virtual DeleteSchemaResponse DeleteSchema(DeleteSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return Invoke<DeleteSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public virtual IAsyncResult BeginDeleteSchema(DeleteSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSchema.</param>
        /// 
        /// <returns>Returns a  DeleteSchemaResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public virtual DeleteSchemaResponse EndDeleteSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSchemaVersions

        /// <summary>
        /// Remove versions from the specified schema. A version number or range may be supplied.
        /// If the compatibility mode forbids deleting of a version that is necessary, such as
        /// BACKWARDS_FULL, an error is returned. Calling the <code>GetSchemaVersions</code> API
        /// after this call will list the status of the deleted versions.
        /// 
        ///  
        /// <para>
        /// When the range of version numbers contain check pointed version, the API will return
        /// a 409 conflict and will not proceed with the deletion. You have to remove the checkpoint
        /// first using the <code>DeleteSchemaCheckpoint</code> API before using this API.
        /// </para>
        ///  
        /// <para>
        /// You cannot use the <code>DeleteSchemaVersions</code> API to delete the first schema
        /// version in the schema set. The first schema version can only be deleted by the <code>DeleteSchema</code>
        /// API. This operation will also delete the attached <code>SchemaVersionMetadata</code>
        /// under the schema versions. Hard deletes will be enforced on the database.
        /// </para>
        ///  
        /// <para>
        /// If the compatibility mode forbids deleting of a version that is necessary, such as
        /// BACKWARDS_FULL, an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaVersions service method.</param>
        /// 
        /// <returns>The response from the DeleteSchemaVersions service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteSchemaVersions">REST API Reference for DeleteSchemaVersions Operation</seealso>
        public virtual DeleteSchemaVersionsResponse DeleteSchemaVersions(DeleteSchemaVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSchemaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaVersionsResponseUnmarshaller.Instance;

            return Invoke<DeleteSchemaVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSchemaVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaVersions operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSchemaVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteSchemaVersions">REST API Reference for DeleteSchemaVersions Operation</seealso>
        public virtual IAsyncResult BeginDeleteSchemaVersions(DeleteSchemaVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSchemaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSchemaVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSchemaVersions.</param>
        /// 
        /// <returns>Returns a  DeleteSchemaVersionsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteSchemaVersions">REST API Reference for DeleteSchemaVersions Operation</seealso>
        public virtual DeleteSchemaVersionsResponse EndDeleteSchemaVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSchemaVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSecurityConfiguration

        /// <summary>
        /// Deletes a specified security configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteSecurityConfiguration service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteSecurityConfiguration">REST API Reference for DeleteSecurityConfiguration Operation</seealso>
        public virtual DeleteSecurityConfigurationResponse DeleteSecurityConfiguration(DeleteSecurityConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityConfiguration operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSecurityConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteSecurityConfiguration">REST API Reference for DeleteSecurityConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteSecurityConfiguration(DeleteSecurityConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSecurityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSecurityConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteSecurityConfigurationResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteSecurityConfiguration">REST API Reference for DeleteSecurityConfiguration Operation</seealso>
        public virtual DeleteSecurityConfigurationResponse EndDeleteSecurityConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSecurityConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSession

        /// <summary>
        /// Deletes the session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSession service method.</param>
        /// 
        /// <returns>The response from the DeleteSession service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IllegalSessionStateException">
        /// The session is in an invalid state to perform a requested operation.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteSession">REST API Reference for DeleteSession Operation</seealso>
        public virtual DeleteSessionResponse DeleteSession(DeleteSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSessionResponseUnmarshaller.Instance;

            return Invoke<DeleteSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSession operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteSession">REST API Reference for DeleteSession Operation</seealso>
        public virtual IAsyncResult BeginDeleteSession(DeleteSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSession.</param>
        /// 
        /// <returns>Returns a  DeleteSessionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteSession">REST API Reference for DeleteSession Operation</seealso>
        public virtual DeleteSessionResponse EndDeleteSession(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTable

        /// <summary>
        /// Removes a table definition from the Data Catalog.
        /// 
        ///  <note> 
        /// <para>
        /// After completing this operation, you no longer have access to the table versions and
        /// partitions that belong to the deleted table. Glue deletes these "orphaned" resources
        /// asynchronously in a timely manner, at the discretion of the service.
        /// </para>
        ///  
        /// <para>
        /// To ensure the immediate deletion of all related resources, before calling <code>DeleteTable</code>,
        /// use <code>DeleteTableVersion</code> or <code>BatchDeleteTableVersion</code>, and <code>DeletePartition</code>
        /// or <code>BatchDeletePartition</code>, to delete any resources that belong to the table.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable service method.</param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNotReadyException">
        /// A resource was not ready for a transaction.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        public virtual DeleteTableResponse DeleteTable(DeleteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableResponseUnmarshaller.Instance;

            return Invoke<DeleteTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        public virtual IAsyncResult BeginDeleteTable(DeleteTableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTable.</param>
        /// 
        /// <returns>Returns a  DeleteTableResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        public virtual DeleteTableResponse EndDeleteTable(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTableResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTableVersion

        /// <summary>
        /// Deletes a specified version of a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteTableVersion service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTableVersion">REST API Reference for DeleteTableVersion Operation</seealso>
        public virtual DeleteTableVersionResponse DeleteTableVersion(DeleteTableVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTableVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteTableVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTableVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableVersion operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTableVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTableVersion">REST API Reference for DeleteTableVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteTableVersion(DeleteTableVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTableVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTableVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTableVersion.</param>
        /// 
        /// <returns>Returns a  DeleteTableVersionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTableVersion">REST API Reference for DeleteTableVersion Operation</seealso>
        public virtual DeleteTableVersionResponse EndDeleteTableVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTableVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTrigger

        /// <summary>
        /// Deletes a specified trigger. If the trigger is not found, no exception is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrigger service method.</param>
        /// 
        /// <returns>The response from the DeleteTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTrigger">REST API Reference for DeleteTrigger Operation</seealso>
        public virtual DeleteTriggerResponse DeleteTrigger(DeleteTriggerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTriggerResponseUnmarshaller.Instance;

            return Invoke<DeleteTriggerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrigger operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrigger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTrigger">REST API Reference for DeleteTrigger Operation</seealso>
        public virtual IAsyncResult BeginDeleteTrigger(DeleteTriggerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTriggerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrigger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrigger.</param>
        /// 
        /// <returns>Returns a  DeleteTriggerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteTrigger">REST API Reference for DeleteTrigger Operation</seealso>
        public virtual DeleteTriggerResponse EndDeleteTrigger(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTriggerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUserDefinedFunction

        /// <summary>
        /// Deletes an existing function definition from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserDefinedFunction service method.</param>
        /// 
        /// <returns>The response from the DeleteUserDefinedFunction service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteUserDefinedFunction">REST API Reference for DeleteUserDefinedFunction Operation</seealso>
        public virtual DeleteUserDefinedFunctionResponse DeleteUserDefinedFunction(DeleteUserDefinedFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserDefinedFunctionResponseUnmarshaller.Instance;

            return Invoke<DeleteUserDefinedFunctionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserDefinedFunction operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserDefinedFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteUserDefinedFunction">REST API Reference for DeleteUserDefinedFunction Operation</seealso>
        public virtual IAsyncResult BeginDeleteUserDefinedFunction(DeleteUserDefinedFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserDefinedFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserDefinedFunction.</param>
        /// 
        /// <returns>Returns a  DeleteUserDefinedFunctionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteUserDefinedFunction">REST API Reference for DeleteUserDefinedFunction Operation</seealso>
        public virtual DeleteUserDefinedFunctionResponse EndDeleteUserDefinedFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserDefinedFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWorkflow

        /// <summary>
        /// Deletes a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkflow service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        public virtual DeleteWorkflowResponse DeleteWorkflow(DeleteWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        public virtual IAsyncResult BeginDeleteWorkflow(DeleteWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkflow.</param>
        /// 
        /// <returns>Returns a  DeleteWorkflowResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        public virtual DeleteWorkflowResponse EndDeleteWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBlueprint

        /// <summary>
        /// Retrieves the details of a blueprint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprint service method.</param>
        /// 
        /// <returns>The response from the GetBlueprint service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetBlueprint">REST API Reference for GetBlueprint Operation</seealso>
        public virtual GetBlueprintResponse GetBlueprint(GetBlueprintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlueprintResponseUnmarshaller.Instance;

            return Invoke<GetBlueprintResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBlueprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprint operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBlueprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetBlueprint">REST API Reference for GetBlueprint Operation</seealso>
        public virtual IAsyncResult BeginGetBlueprint(GetBlueprintRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlueprintResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBlueprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBlueprint.</param>
        /// 
        /// <returns>Returns a  GetBlueprintResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetBlueprint">REST API Reference for GetBlueprint Operation</seealso>
        public virtual GetBlueprintResponse EndGetBlueprint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBlueprintResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBlueprintRun

        /// <summary>
        /// Retrieves the details of a blueprint run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprintRun service method.</param>
        /// 
        /// <returns>The response from the GetBlueprintRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetBlueprintRun">REST API Reference for GetBlueprintRun Operation</seealso>
        public virtual GetBlueprintRunResponse GetBlueprintRun(GetBlueprintRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlueprintRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlueprintRunResponseUnmarshaller.Instance;

            return Invoke<GetBlueprintRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBlueprintRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprintRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBlueprintRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetBlueprintRun">REST API Reference for GetBlueprintRun Operation</seealso>
        public virtual IAsyncResult BeginGetBlueprintRun(GetBlueprintRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlueprintRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlueprintRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBlueprintRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBlueprintRun.</param>
        /// 
        /// <returns>Returns a  GetBlueprintRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetBlueprintRun">REST API Reference for GetBlueprintRun Operation</seealso>
        public virtual GetBlueprintRunResponse EndGetBlueprintRun(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBlueprintRunResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBlueprintRuns

        /// <summary>
        /// Retrieves the details of blueprint runs for a specified blueprint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprintRuns service method.</param>
        /// 
        /// <returns>The response from the GetBlueprintRuns service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetBlueprintRuns">REST API Reference for GetBlueprintRuns Operation</seealso>
        public virtual GetBlueprintRunsResponse GetBlueprintRuns(GetBlueprintRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlueprintRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlueprintRunsResponseUnmarshaller.Instance;

            return Invoke<GetBlueprintRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBlueprintRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprintRuns operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBlueprintRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetBlueprintRuns">REST API Reference for GetBlueprintRuns Operation</seealso>
        public virtual IAsyncResult BeginGetBlueprintRuns(GetBlueprintRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlueprintRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlueprintRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBlueprintRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBlueprintRuns.</param>
        /// 
        /// <returns>Returns a  GetBlueprintRunsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetBlueprintRuns">REST API Reference for GetBlueprintRuns Operation</seealso>
        public virtual GetBlueprintRunsResponse EndGetBlueprintRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBlueprintRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCatalogImportStatus

        /// <summary>
        /// Retrieves the status of a migration operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCatalogImportStatus service method.</param>
        /// 
        /// <returns>The response from the GetCatalogImportStatus service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCatalogImportStatus">REST API Reference for GetCatalogImportStatus Operation</seealso>
        public virtual GetCatalogImportStatusResponse GetCatalogImportStatus(GetCatalogImportStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCatalogImportStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCatalogImportStatusResponseUnmarshaller.Instance;

            return Invoke<GetCatalogImportStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCatalogImportStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCatalogImportStatus operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCatalogImportStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCatalogImportStatus">REST API Reference for GetCatalogImportStatus Operation</seealso>
        public virtual IAsyncResult BeginGetCatalogImportStatus(GetCatalogImportStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCatalogImportStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCatalogImportStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCatalogImportStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCatalogImportStatus.</param>
        /// 
        /// <returns>Returns a  GetCatalogImportStatusResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCatalogImportStatus">REST API Reference for GetCatalogImportStatus Operation</seealso>
        public virtual GetCatalogImportStatusResponse EndGetCatalogImportStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCatalogImportStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetClassifier

        /// <summary>
        /// Retrieve a classifier by name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassifier service method.</param>
        /// 
        /// <returns>The response from the GetClassifier service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifier">REST API Reference for GetClassifier Operation</seealso>
        public virtual GetClassifierResponse GetClassifier(GetClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClassifierResponseUnmarshaller.Instance;

            return Invoke<GetClassifierResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClassifier operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetClassifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifier">REST API Reference for GetClassifier Operation</seealso>
        public virtual IAsyncResult BeginGetClassifier(GetClassifierRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClassifierResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetClassifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClassifier.</param>
        /// 
        /// <returns>Returns a  GetClassifierResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifier">REST API Reference for GetClassifier Operation</seealso>
        public virtual GetClassifierResponse EndGetClassifier(IAsyncResult asyncResult)
        {
            return EndInvoke<GetClassifierResponse>(asyncResult);
        }

        #endregion
        
        #region  GetClassifiers

        /// <summary>
        /// Lists all classifier objects in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClassifiers service method.</param>
        /// 
        /// <returns>The response from the GetClassifiers service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifiers">REST API Reference for GetClassifiers Operation</seealso>
        public virtual GetClassifiersResponse GetClassifiers(GetClassifiersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClassifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClassifiersResponseUnmarshaller.Instance;

            return Invoke<GetClassifiersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetClassifiers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClassifiers operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetClassifiers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifiers">REST API Reference for GetClassifiers Operation</seealso>
        public virtual IAsyncResult BeginGetClassifiers(GetClassifiersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClassifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClassifiersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetClassifiers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClassifiers.</param>
        /// 
        /// <returns>Returns a  GetClassifiersResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetClassifiers">REST API Reference for GetClassifiers Operation</seealso>
        public virtual GetClassifiersResponse EndGetClassifiers(IAsyncResult asyncResult)
        {
            return EndInvoke<GetClassifiersResponse>(asyncResult);
        }

        #endregion
        
        #region  GetColumnStatisticsForPartition

        /// <summary>
        /// Retrieves partition statistics of columns.
        /// 
        ///  
        /// <para>
        /// The Identity and Access Management (IAM) permission required for this operation is
        /// <code>GetPartition</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetColumnStatisticsForPartition service method.</param>
        /// 
        /// <returns>The response from the GetColumnStatisticsForPartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetColumnStatisticsForPartition">REST API Reference for GetColumnStatisticsForPartition Operation</seealso>
        public virtual GetColumnStatisticsForPartitionResponse GetColumnStatisticsForPartition(GetColumnStatisticsForPartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetColumnStatisticsForPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetColumnStatisticsForPartitionResponseUnmarshaller.Instance;

            return Invoke<GetColumnStatisticsForPartitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetColumnStatisticsForPartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetColumnStatisticsForPartition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetColumnStatisticsForPartition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetColumnStatisticsForPartition">REST API Reference for GetColumnStatisticsForPartition Operation</seealso>
        public virtual IAsyncResult BeginGetColumnStatisticsForPartition(GetColumnStatisticsForPartitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetColumnStatisticsForPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetColumnStatisticsForPartitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetColumnStatisticsForPartition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetColumnStatisticsForPartition.</param>
        /// 
        /// <returns>Returns a  GetColumnStatisticsForPartitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetColumnStatisticsForPartition">REST API Reference for GetColumnStatisticsForPartition Operation</seealso>
        public virtual GetColumnStatisticsForPartitionResponse EndGetColumnStatisticsForPartition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetColumnStatisticsForPartitionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetColumnStatisticsForTable

        /// <summary>
        /// Retrieves table statistics of columns.
        /// 
        ///  
        /// <para>
        /// The Identity and Access Management (IAM) permission required for this operation is
        /// <code>GetTable</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetColumnStatisticsForTable service method.</param>
        /// 
        /// <returns>The response from the GetColumnStatisticsForTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetColumnStatisticsForTable">REST API Reference for GetColumnStatisticsForTable Operation</seealso>
        public virtual GetColumnStatisticsForTableResponse GetColumnStatisticsForTable(GetColumnStatisticsForTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetColumnStatisticsForTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetColumnStatisticsForTableResponseUnmarshaller.Instance;

            return Invoke<GetColumnStatisticsForTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetColumnStatisticsForTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetColumnStatisticsForTable operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetColumnStatisticsForTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetColumnStatisticsForTable">REST API Reference for GetColumnStatisticsForTable Operation</seealso>
        public virtual IAsyncResult BeginGetColumnStatisticsForTable(GetColumnStatisticsForTableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetColumnStatisticsForTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetColumnStatisticsForTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetColumnStatisticsForTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetColumnStatisticsForTable.</param>
        /// 
        /// <returns>Returns a  GetColumnStatisticsForTableResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetColumnStatisticsForTable">REST API Reference for GetColumnStatisticsForTable Operation</seealso>
        public virtual GetColumnStatisticsForTableResponse EndGetColumnStatisticsForTable(IAsyncResult asyncResult)
        {
            return EndInvoke<GetColumnStatisticsForTableResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConnection

        /// <summary>
        /// Retrieves a connection definition from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// 
        /// <returns>The response from the GetConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual GetConnectionResponse GetConnection(GetConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return Invoke<GetConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnection operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual IAsyncResult BeginGetConnection(GetConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnection.</param>
        /// 
        /// <returns>Returns a  GetConnectionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual GetConnectionResponse EndGetConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConnections

        /// <summary>
        /// Retrieves a list of connection definitions from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnections service method.</param>
        /// 
        /// <returns>The response from the GetConnections service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnections">REST API Reference for GetConnections Operation</seealso>
        public virtual GetConnectionsResponse GetConnections(GetConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionsResponseUnmarshaller.Instance;

            return Invoke<GetConnectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnections operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnections">REST API Reference for GetConnections Operation</seealso>
        public virtual IAsyncResult BeginGetConnections(GetConnectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnections.</param>
        /// 
        /// <returns>Returns a  GetConnectionsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetConnections">REST API Reference for GetConnections Operation</seealso>
        public virtual GetConnectionsResponse EndGetConnections(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCrawler

        /// <summary>
        /// Retrieves metadata for a specified crawler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCrawler service method.</param>
        /// 
        /// <returns>The response from the GetCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawler">REST API Reference for GetCrawler Operation</seealso>
        public virtual GetCrawlerResponse GetCrawler(GetCrawlerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCrawlerResponseUnmarshaller.Instance;

            return Invoke<GetCrawlerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCrawler operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCrawler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawler">REST API Reference for GetCrawler Operation</seealso>
        public virtual IAsyncResult BeginGetCrawler(GetCrawlerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCrawlerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCrawler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCrawler.</param>
        /// 
        /// <returns>Returns a  GetCrawlerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawler">REST API Reference for GetCrawler Operation</seealso>
        public virtual GetCrawlerResponse EndGetCrawler(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCrawlerResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCrawlerMetrics

        /// <summary>
        /// Retrieves metrics about specified crawlers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCrawlerMetrics service method.</param>
        /// 
        /// <returns>The response from the GetCrawlerMetrics service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlerMetrics">REST API Reference for GetCrawlerMetrics Operation</seealso>
        public virtual GetCrawlerMetricsResponse GetCrawlerMetrics(GetCrawlerMetricsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCrawlerMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCrawlerMetricsResponseUnmarshaller.Instance;

            return Invoke<GetCrawlerMetricsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCrawlerMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCrawlerMetrics operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCrawlerMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlerMetrics">REST API Reference for GetCrawlerMetrics Operation</seealso>
        public virtual IAsyncResult BeginGetCrawlerMetrics(GetCrawlerMetricsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCrawlerMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCrawlerMetricsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCrawlerMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCrawlerMetrics.</param>
        /// 
        /// <returns>Returns a  GetCrawlerMetricsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlerMetrics">REST API Reference for GetCrawlerMetrics Operation</seealso>
        public virtual GetCrawlerMetricsResponse EndGetCrawlerMetrics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCrawlerMetricsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCrawlers

        /// <summary>
        /// Retrieves metadata for all crawlers defined in the customer account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCrawlers service method.</param>
        /// 
        /// <returns>The response from the GetCrawlers service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlers">REST API Reference for GetCrawlers Operation</seealso>
        public virtual GetCrawlersResponse GetCrawlers(GetCrawlersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCrawlersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCrawlersResponseUnmarshaller.Instance;

            return Invoke<GetCrawlersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCrawlers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCrawlers operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCrawlers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlers">REST API Reference for GetCrawlers Operation</seealso>
        public virtual IAsyncResult BeginGetCrawlers(GetCrawlersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCrawlersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCrawlersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCrawlers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCrawlers.</param>
        /// 
        /// <returns>Returns a  GetCrawlersResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCrawlers">REST API Reference for GetCrawlers Operation</seealso>
        public virtual GetCrawlersResponse EndGetCrawlers(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCrawlersResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCustomEntityType

        /// <summary>
        /// Retrieves the details of a custom pattern by specifying its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomEntityType service method.</param>
        /// 
        /// <returns>The response from the GetCustomEntityType service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCustomEntityType">REST API Reference for GetCustomEntityType Operation</seealso>
        public virtual GetCustomEntityTypeResponse GetCustomEntityType(GetCustomEntityTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCustomEntityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomEntityTypeResponseUnmarshaller.Instance;

            return Invoke<GetCustomEntityTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCustomEntityType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCustomEntityType operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCustomEntityType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCustomEntityType">REST API Reference for GetCustomEntityType Operation</seealso>
        public virtual IAsyncResult BeginGetCustomEntityType(GetCustomEntityTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCustomEntityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomEntityTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCustomEntityType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCustomEntityType.</param>
        /// 
        /// <returns>Returns a  GetCustomEntityTypeResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetCustomEntityType">REST API Reference for GetCustomEntityType Operation</seealso>
        public virtual GetCustomEntityTypeResponse EndGetCustomEntityType(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCustomEntityTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDatabase

        /// <summary>
        /// Retrieves the definition of a specified database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase service method.</param>
        /// 
        /// <returns>The response from the GetDatabase service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
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
        /// <returns>Returns a  GetDatabaseResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        public virtual GetDatabaseResponse EndGetDatabase(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDatabaseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDatabases

        /// <summary>
        /// Retrieves all databases defined in a given Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatabases service method.</param>
        /// 
        /// <returns>The response from the GetDatabases service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabases">REST API Reference for GetDatabases Operation</seealso>
        public virtual GetDatabasesResponse GetDatabases(GetDatabasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatabasesResponseUnmarshaller.Instance;

            return Invoke<GetDatabasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDatabases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatabases operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDatabases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabases">REST API Reference for GetDatabases Operation</seealso>
        public virtual IAsyncResult BeginGetDatabases(GetDatabasesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatabasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDatabases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDatabases.</param>
        /// 
        /// <returns>Returns a  GetDatabasesResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDatabases">REST API Reference for GetDatabases Operation</seealso>
        public virtual GetDatabasesResponse EndGetDatabases(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDatabasesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataCatalogEncryptionSettings

        /// <summary>
        /// Retrieves the security configuration for a specified catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataCatalogEncryptionSettings service method.</param>
        /// 
        /// <returns>The response from the GetDataCatalogEncryptionSettings service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataCatalogEncryptionSettings">REST API Reference for GetDataCatalogEncryptionSettings Operation</seealso>
        public virtual GetDataCatalogEncryptionSettingsResponse GetDataCatalogEncryptionSettings(GetDataCatalogEncryptionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataCatalogEncryptionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataCatalogEncryptionSettingsResponseUnmarshaller.Instance;

            return Invoke<GetDataCatalogEncryptionSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataCatalogEncryptionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataCatalogEncryptionSettings operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataCatalogEncryptionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataCatalogEncryptionSettings">REST API Reference for GetDataCatalogEncryptionSettings Operation</seealso>
        public virtual IAsyncResult BeginGetDataCatalogEncryptionSettings(GetDataCatalogEncryptionSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataCatalogEncryptionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataCatalogEncryptionSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataCatalogEncryptionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataCatalogEncryptionSettings.</param>
        /// 
        /// <returns>Returns a  GetDataCatalogEncryptionSettingsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataCatalogEncryptionSettings">REST API Reference for GetDataCatalogEncryptionSettings Operation</seealso>
        public virtual GetDataCatalogEncryptionSettingsResponse EndGetDataCatalogEncryptionSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataCatalogEncryptionSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataflowGraph

        /// <summary>
        /// Transforms a Python script into a directed acyclic graph (DAG).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataflowGraph service method.</param>
        /// 
        /// <returns>The response from the GetDataflowGraph service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataflowGraph">REST API Reference for GetDataflowGraph Operation</seealso>
        public virtual GetDataflowGraphResponse GetDataflowGraph(GetDataflowGraphRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataflowGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataflowGraphResponseUnmarshaller.Instance;

            return Invoke<GetDataflowGraphResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataflowGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataflowGraph operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataflowGraph
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataflowGraph">REST API Reference for GetDataflowGraph Operation</seealso>
        public virtual IAsyncResult BeginGetDataflowGraph(GetDataflowGraphRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataflowGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataflowGraphResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataflowGraph operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataflowGraph.</param>
        /// 
        /// <returns>Returns a  GetDataflowGraphResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataflowGraph">REST API Reference for GetDataflowGraph Operation</seealso>
        public virtual GetDataflowGraphResponse EndGetDataflowGraph(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataflowGraphResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataQualityResult

        /// <summary>
        /// Retrieves the result of a data quality rule evaluation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataQualityResult service method.</param>
        /// 
        /// <returns>The response from the GetDataQualityResult service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataQualityResult">REST API Reference for GetDataQualityResult Operation</seealso>
        public virtual GetDataQualityResultResponse GetDataQualityResult(GetDataQualityResultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataQualityResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataQualityResultResponseUnmarshaller.Instance;

            return Invoke<GetDataQualityResultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataQualityResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataQualityResult operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataQualityResult
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataQualityResult">REST API Reference for GetDataQualityResult Operation</seealso>
        public virtual IAsyncResult BeginGetDataQualityResult(GetDataQualityResultRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataQualityResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataQualityResultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataQualityResult operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataQualityResult.</param>
        /// 
        /// <returns>Returns a  GetDataQualityResultResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataQualityResult">REST API Reference for GetDataQualityResult Operation</seealso>
        public virtual GetDataQualityResultResponse EndGetDataQualityResult(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataQualityResultResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataQualityRuleRecommendationRun

        /// <summary>
        /// Gets the specified recommendation run that was used to generate rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataQualityRuleRecommendationRun service method.</param>
        /// 
        /// <returns>The response from the GetDataQualityRuleRecommendationRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataQualityRuleRecommendationRun">REST API Reference for GetDataQualityRuleRecommendationRun Operation</seealso>
        public virtual GetDataQualityRuleRecommendationRunResponse GetDataQualityRuleRecommendationRun(GetDataQualityRuleRecommendationRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataQualityRuleRecommendationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataQualityRuleRecommendationRunResponseUnmarshaller.Instance;

            return Invoke<GetDataQualityRuleRecommendationRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataQualityRuleRecommendationRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataQualityRuleRecommendationRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataQualityRuleRecommendationRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataQualityRuleRecommendationRun">REST API Reference for GetDataQualityRuleRecommendationRun Operation</seealso>
        public virtual IAsyncResult BeginGetDataQualityRuleRecommendationRun(GetDataQualityRuleRecommendationRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataQualityRuleRecommendationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataQualityRuleRecommendationRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataQualityRuleRecommendationRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataQualityRuleRecommendationRun.</param>
        /// 
        /// <returns>Returns a  GetDataQualityRuleRecommendationRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataQualityRuleRecommendationRun">REST API Reference for GetDataQualityRuleRecommendationRun Operation</seealso>
        public virtual GetDataQualityRuleRecommendationRunResponse EndGetDataQualityRuleRecommendationRun(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataQualityRuleRecommendationRunResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataQualityRuleset

        /// <summary>
        /// Returns an existing ruleset by identifier or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataQualityRuleset service method.</param>
        /// 
        /// <returns>The response from the GetDataQualityRuleset service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataQualityRuleset">REST API Reference for GetDataQualityRuleset Operation</seealso>
        public virtual GetDataQualityRulesetResponse GetDataQualityRuleset(GetDataQualityRulesetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataQualityRulesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataQualityRulesetResponseUnmarshaller.Instance;

            return Invoke<GetDataQualityRulesetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataQualityRuleset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataQualityRuleset operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataQualityRuleset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataQualityRuleset">REST API Reference for GetDataQualityRuleset Operation</seealso>
        public virtual IAsyncResult BeginGetDataQualityRuleset(GetDataQualityRulesetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataQualityRulesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataQualityRulesetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataQualityRuleset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataQualityRuleset.</param>
        /// 
        /// <returns>Returns a  GetDataQualityRulesetResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataQualityRuleset">REST API Reference for GetDataQualityRuleset Operation</seealso>
        public virtual GetDataQualityRulesetResponse EndGetDataQualityRuleset(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataQualityRulesetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataQualityRulesetEvaluationRun

        /// <summary>
        /// Retrieves a specific run where a ruleset is evaluated against a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataQualityRulesetEvaluationRun service method.</param>
        /// 
        /// <returns>The response from the GetDataQualityRulesetEvaluationRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataQualityRulesetEvaluationRun">REST API Reference for GetDataQualityRulesetEvaluationRun Operation</seealso>
        public virtual GetDataQualityRulesetEvaluationRunResponse GetDataQualityRulesetEvaluationRun(GetDataQualityRulesetEvaluationRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataQualityRulesetEvaluationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataQualityRulesetEvaluationRunResponseUnmarshaller.Instance;

            return Invoke<GetDataQualityRulesetEvaluationRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataQualityRulesetEvaluationRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataQualityRulesetEvaluationRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataQualityRulesetEvaluationRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataQualityRulesetEvaluationRun">REST API Reference for GetDataQualityRulesetEvaluationRun Operation</seealso>
        public virtual IAsyncResult BeginGetDataQualityRulesetEvaluationRun(GetDataQualityRulesetEvaluationRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataQualityRulesetEvaluationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataQualityRulesetEvaluationRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataQualityRulesetEvaluationRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataQualityRulesetEvaluationRun.</param>
        /// 
        /// <returns>Returns a  GetDataQualityRulesetEvaluationRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDataQualityRulesetEvaluationRun">REST API Reference for GetDataQualityRulesetEvaluationRun Operation</seealso>
        public virtual GetDataQualityRulesetEvaluationRunResponse EndGetDataQualityRulesetEvaluationRun(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataQualityRulesetEvaluationRunResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDevEndpoint

        /// <summary>
        /// Retrieves information about a specified development endpoint.
        /// 
        ///  <note> 
        /// <para>
        /// When you create a development endpoint in a virtual private cloud (VPC), Glue returns
        /// only a private IP address, and the public IP address field is not populated. When
        /// you create a non-VPC development endpoint, Glue returns only a public IP address.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetDevEndpoint service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoint">REST API Reference for GetDevEndpoint Operation</seealso>
        public virtual GetDevEndpointResponse GetDevEndpoint(GetDevEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevEndpointResponseUnmarshaller.Instance;

            return Invoke<GetDevEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevEndpoint operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoint">REST API Reference for GetDevEndpoint Operation</seealso>
        public virtual IAsyncResult BeginGetDevEndpoint(GetDevEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevEndpoint.</param>
        /// 
        /// <returns>Returns a  GetDevEndpointResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoint">REST API Reference for GetDevEndpoint Operation</seealso>
        public virtual GetDevEndpointResponse EndGetDevEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDevEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDevEndpoints

        /// <summary>
        /// Retrieves all the development endpoints in this Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// When you create a development endpoint in a virtual private cloud (VPC), Glue returns
        /// only a private IP address and the public IP address field is not populated. When you
        /// create a non-VPC development endpoint, Glue returns only a public IP address.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevEndpoints service method.</param>
        /// 
        /// <returns>The response from the GetDevEndpoints service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoints">REST API Reference for GetDevEndpoints Operation</seealso>
        public virtual GetDevEndpointsResponse GetDevEndpoints(GetDevEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevEndpointsResponseUnmarshaller.Instance;

            return Invoke<GetDevEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevEndpoints operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoints">REST API Reference for GetDevEndpoints Operation</seealso>
        public virtual IAsyncResult BeginGetDevEndpoints(GetDevEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevEndpoints.</param>
        /// 
        /// <returns>Returns a  GetDevEndpointsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetDevEndpoints">REST API Reference for GetDevEndpoints Operation</seealso>
        public virtual GetDevEndpointsResponse EndGetDevEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDevEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJob

        /// <summary>
        /// Retrieves an existing job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual GetJobResponse GetJob(GetJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return Invoke<GetJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJob operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual IAsyncResult BeginGetJob(GetJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJob.</param>
        /// 
        /// <returns>Returns a  GetJobResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual GetJobResponse EndGetJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJobBookmark

        /// <summary>
        /// Returns information on a job bookmark entry.
        /// 
        ///  
        /// <para>
        /// For more information about enabling and using job bookmarks, see:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/glue/latest/dg/monitor-continuations.html">Tracking
        /// processed data using job bookmarks</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-programming-etl-glue-arguments.html">Job
        /// parameters used by Glue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-api-jobs-job.html#aws-glue-api-jobs-job-Job">Job
        /// structure</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobBookmark service method.</param>
        /// 
        /// <returns>The response from the GetJobBookmark service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ValidationException">
        /// A value could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobBookmark">REST API Reference for GetJobBookmark Operation</seealso>
        public virtual GetJobBookmarkResponse GetJobBookmark(GetJobBookmarkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobBookmarkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobBookmarkResponseUnmarshaller.Instance;

            return Invoke<GetJobBookmarkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJobBookmark operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobBookmark operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJobBookmark
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobBookmark">REST API Reference for GetJobBookmark Operation</seealso>
        public virtual IAsyncResult BeginGetJobBookmark(GetJobBookmarkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobBookmarkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobBookmarkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJobBookmark operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJobBookmark.</param>
        /// 
        /// <returns>Returns a  GetJobBookmarkResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobBookmark">REST API Reference for GetJobBookmark Operation</seealso>
        public virtual GetJobBookmarkResponse EndGetJobBookmark(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobBookmarkResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJobRun

        /// <summary>
        /// Retrieves the metadata for a given job run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobRun service method.</param>
        /// 
        /// <returns>The response from the GetJobRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRun">REST API Reference for GetJobRun Operation</seealso>
        public virtual GetJobRunResponse GetJobRun(GetJobRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobRunResponseUnmarshaller.Instance;

            return Invoke<GetJobRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJobRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRun">REST API Reference for GetJobRun Operation</seealso>
        public virtual IAsyncResult BeginGetJobRun(GetJobRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJobRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJobRun.</param>
        /// 
        /// <returns>Returns a  GetJobRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRun">REST API Reference for GetJobRun Operation</seealso>
        public virtual GetJobRunResponse EndGetJobRun(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobRunResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJobRuns

        /// <summary>
        /// Retrieves metadata for all runs of a given job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobRuns service method.</param>
        /// 
        /// <returns>The response from the GetJobRuns service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRuns">REST API Reference for GetJobRuns Operation</seealso>
        public virtual GetJobRunsResponse GetJobRuns(GetJobRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobRunsResponseUnmarshaller.Instance;

            return Invoke<GetJobRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJobRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobRuns operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJobRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRuns">REST API Reference for GetJobRuns Operation</seealso>
        public virtual IAsyncResult BeginGetJobRuns(GetJobRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJobRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJobRuns.</param>
        /// 
        /// <returns>Returns a  GetJobRunsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobRuns">REST API Reference for GetJobRuns Operation</seealso>
        public virtual GetJobRunsResponse EndGetJobRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJobs

        /// <summary>
        /// Retrieves all current job definitions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobs service method.</param>
        /// 
        /// <returns>The response from the GetJobs service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobs">REST API Reference for GetJobs Operation</seealso>
        public virtual GetJobsResponse GetJobs(GetJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobsResponseUnmarshaller.Instance;

            return Invoke<GetJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobs operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobs">REST API Reference for GetJobs Operation</seealso>
        public virtual IAsyncResult BeginGetJobs(GetJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJobs.</param>
        /// 
        /// <returns>Returns a  GetJobsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetJobs">REST API Reference for GetJobs Operation</seealso>
        public virtual GetJobsResponse EndGetJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMapping

        /// <summary>
        /// Creates mappings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMapping service method.</param>
        /// 
        /// <returns>The response from the GetMapping service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMapping">REST API Reference for GetMapping Operation</seealso>
        public virtual GetMappingResponse GetMapping(GetMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMappingResponseUnmarshaller.Instance;

            return Invoke<GetMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMapping operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMapping">REST API Reference for GetMapping Operation</seealso>
        public virtual IAsyncResult BeginGetMapping(GetMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMapping.</param>
        /// 
        /// <returns>Returns a  GetMappingResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMapping">REST API Reference for GetMapping Operation</seealso>
        public virtual GetMappingResponse EndGetMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMLTaskRun

        /// <summary>
        /// Gets details for a specific task run on a machine learning transform. Machine learning
        /// task runs are asynchronous tasks that Glue runs on your behalf as part of various
        /// machine learning workflows. You can check the stats of any task run by calling <code>GetMLTaskRun</code>
        /// with the <code>TaskRunID</code> and its parent transform's <code>TransformID</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLTaskRun service method.</param>
        /// 
        /// <returns>The response from the GetMLTaskRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMLTaskRun">REST API Reference for GetMLTaskRun Operation</seealso>
        public virtual GetMLTaskRunResponse GetMLTaskRun(GetMLTaskRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMLTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLTaskRunResponseUnmarshaller.Instance;

            return Invoke<GetMLTaskRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMLTaskRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMLTaskRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMLTaskRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMLTaskRun">REST API Reference for GetMLTaskRun Operation</seealso>
        public virtual IAsyncResult BeginGetMLTaskRun(GetMLTaskRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMLTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLTaskRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMLTaskRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMLTaskRun.</param>
        /// 
        /// <returns>Returns a  GetMLTaskRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMLTaskRun">REST API Reference for GetMLTaskRun Operation</seealso>
        public virtual GetMLTaskRunResponse EndGetMLTaskRun(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMLTaskRunResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMLTaskRuns

        /// <summary>
        /// Gets a list of runs for a machine learning transform. Machine learning task runs are
        /// asynchronous tasks that Glue runs on your behalf as part of various machine learning
        /// workflows. You can get a sortable, filterable list of machine learning task runs by
        /// calling <code>GetMLTaskRuns</code> with their parent transform's <code>TransformID</code>
        /// and other optional parameters as documented in this section.
        /// 
        ///  
        /// <para>
        /// This operation returns a list of historic runs and must be paginated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLTaskRuns service method.</param>
        /// 
        /// <returns>The response from the GetMLTaskRuns service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMLTaskRuns">REST API Reference for GetMLTaskRuns Operation</seealso>
        public virtual GetMLTaskRunsResponse GetMLTaskRuns(GetMLTaskRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMLTaskRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLTaskRunsResponseUnmarshaller.Instance;

            return Invoke<GetMLTaskRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMLTaskRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMLTaskRuns operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMLTaskRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMLTaskRuns">REST API Reference for GetMLTaskRuns Operation</seealso>
        public virtual IAsyncResult BeginGetMLTaskRuns(GetMLTaskRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMLTaskRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLTaskRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMLTaskRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMLTaskRuns.</param>
        /// 
        /// <returns>Returns a  GetMLTaskRunsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMLTaskRuns">REST API Reference for GetMLTaskRuns Operation</seealso>
        public virtual GetMLTaskRunsResponse EndGetMLTaskRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMLTaskRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMLTransform

        /// <summary>
        /// Gets an Glue machine learning transform artifact and all its corresponding metadata.
        /// Machine learning transforms are a special type of transform that use machine learning
        /// to learn the details of the transformation to be performed by learning from examples
        /// provided by humans. These transformations are then saved by Glue. You can retrieve
        /// their metadata by calling <code>GetMLTransform</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLTransform service method.</param>
        /// 
        /// <returns>The response from the GetMLTransform service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMLTransform">REST API Reference for GetMLTransform Operation</seealso>
        public virtual GetMLTransformResponse GetMLTransform(GetMLTransformRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMLTransformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLTransformResponseUnmarshaller.Instance;

            return Invoke<GetMLTransformResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMLTransform operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMLTransform operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMLTransform
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMLTransform">REST API Reference for GetMLTransform Operation</seealso>
        public virtual IAsyncResult BeginGetMLTransform(GetMLTransformRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMLTransformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLTransformResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMLTransform operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMLTransform.</param>
        /// 
        /// <returns>Returns a  GetMLTransformResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMLTransform">REST API Reference for GetMLTransform Operation</seealso>
        public virtual GetMLTransformResponse EndGetMLTransform(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMLTransformResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMLTransforms

        /// <summary>
        /// Gets a sortable, filterable list of existing Glue machine learning transforms. Machine
        /// learning transforms are a special type of transform that use machine learning to learn
        /// the details of the transformation to be performed by learning from examples provided
        /// by humans. These transformations are then saved by Glue, and you can retrieve their
        /// metadata by calling <code>GetMLTransforms</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLTransforms service method.</param>
        /// 
        /// <returns>The response from the GetMLTransforms service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMLTransforms">REST API Reference for GetMLTransforms Operation</seealso>
        public virtual GetMLTransformsResponse GetMLTransforms(GetMLTransformsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMLTransformsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLTransformsResponseUnmarshaller.Instance;

            return Invoke<GetMLTransformsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMLTransforms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMLTransforms operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMLTransforms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMLTransforms">REST API Reference for GetMLTransforms Operation</seealso>
        public virtual IAsyncResult BeginGetMLTransforms(GetMLTransformsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMLTransformsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLTransformsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMLTransforms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMLTransforms.</param>
        /// 
        /// <returns>Returns a  GetMLTransformsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetMLTransforms">REST API Reference for GetMLTransforms Operation</seealso>
        public virtual GetMLTransformsResponse EndGetMLTransforms(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMLTransformsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPartition

        /// <summary>
        /// Retrieves information about a specified partition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartition service method.</param>
        /// 
        /// <returns>The response from the GetPartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartition">REST API Reference for GetPartition Operation</seealso>
        public virtual GetPartitionResponse GetPartition(GetPartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartitionResponseUnmarshaller.Instance;

            return Invoke<GetPartitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPartition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPartition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartition">REST API Reference for GetPartition Operation</seealso>
        public virtual IAsyncResult BeginGetPartition(GetPartitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPartition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPartition.</param>
        /// 
        /// <returns>Returns a  GetPartitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartition">REST API Reference for GetPartition Operation</seealso>
        public virtual GetPartitionResponse EndGetPartition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPartitionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPartitionIndexes

        /// <summary>
        /// Retrieves the partition indexes associated with a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartitionIndexes service method.</param>
        /// 
        /// <returns>The response from the GetPartitionIndexes service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConflictException">
        /// The <code>CreatePartitions</code> API was called on a table that has indexes enabled.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartitionIndexes">REST API Reference for GetPartitionIndexes Operation</seealso>
        public virtual GetPartitionIndexesResponse GetPartitionIndexes(GetPartitionIndexesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartitionIndexesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartitionIndexesResponseUnmarshaller.Instance;

            return Invoke<GetPartitionIndexesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPartitionIndexes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPartitionIndexes operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPartitionIndexes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartitionIndexes">REST API Reference for GetPartitionIndexes Operation</seealso>
        public virtual IAsyncResult BeginGetPartitionIndexes(GetPartitionIndexesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartitionIndexesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartitionIndexesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPartitionIndexes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPartitionIndexes.</param>
        /// 
        /// <returns>Returns a  GetPartitionIndexesResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartitionIndexes">REST API Reference for GetPartitionIndexes Operation</seealso>
        public virtual GetPartitionIndexesResponse EndGetPartitionIndexes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPartitionIndexesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPartitions

        /// <summary>
        /// Retrieves information about the partitions in a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartitions service method.</param>
        /// 
        /// <returns>The response from the GetPartitions service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidStateException">
        /// An error that indicates your data is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNotReadyException">
        /// A resource was not ready for a transaction.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartitions">REST API Reference for GetPartitions Operation</seealso>
        public virtual GetPartitionsResponse GetPartitions(GetPartitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartitionsResponseUnmarshaller.Instance;

            return Invoke<GetPartitionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPartitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPartitions operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPartitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartitions">REST API Reference for GetPartitions Operation</seealso>
        public virtual IAsyncResult BeginGetPartitions(GetPartitionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartitionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPartitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPartitions.</param>
        /// 
        /// <returns>Returns a  GetPartitionsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPartitions">REST API Reference for GetPartitions Operation</seealso>
        public virtual GetPartitionsResponse EndGetPartitions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPartitionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPlan

        /// <summary>
        /// Gets code to perform a specified mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlan service method.</param>
        /// 
        /// <returns>The response from the GetPlan service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPlan">REST API Reference for GetPlan Operation</seealso>
        public virtual GetPlanResponse GetPlan(GetPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanResponseUnmarshaller.Instance;

            return Invoke<GetPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlan operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPlan">REST API Reference for GetPlan Operation</seealso>
        public virtual IAsyncResult BeginGetPlan(GetPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlan.</param>
        /// 
        /// <returns>Returns a  GetPlanResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetPlan">REST API Reference for GetPlan Operation</seealso>
        public virtual GetPlanResponse EndGetPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPlanResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRegistry

        /// <summary>
        /// Describes the specified registry in detail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistry service method.</param>
        /// 
        /// <returns>The response from the GetRegistry service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetRegistry">REST API Reference for GetRegistry Operation</seealso>
        public virtual GetRegistryResponse GetRegistry(GetRegistryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegistryResponseUnmarshaller.Instance;

            return Invoke<GetRegistryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRegistry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRegistry operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRegistry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetRegistry">REST API Reference for GetRegistry Operation</seealso>
        public virtual IAsyncResult BeginGetRegistry(GetRegistryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegistryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRegistry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRegistry.</param>
        /// 
        /// <returns>Returns a  GetRegistryResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetRegistry">REST API Reference for GetRegistry Operation</seealso>
        public virtual GetRegistryResponse EndGetRegistry(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRegistryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourcePolicies

        /// <summary>
        /// Retrieves the resource policies set on individual resources by Resource Access Manager
        /// during cross-account permission grants. Also retrieves the Data Catalog resource policy.
        /// 
        ///  
        /// <para>
        /// If you enabled metadata encryption in Data Catalog settings, and you do not have permission
        /// on the KMS key, the operation can't return the Data Catalog resource policy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicies service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicies service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        public virtual GetResourcePoliciesResponse GetResourcePolicies(GetResourcePoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePoliciesResponseUnmarshaller.Instance;

            return Invoke<GetResourcePoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicies operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        public virtual IAsyncResult BeginGetResourcePolicies(GetResourcePoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicies.</param>
        /// 
        /// <returns>Returns a  GetResourcePoliciesResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        public virtual GetResourcePoliciesResponse EndGetResourcePolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourcePoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourcePolicy

        /// <summary>
        /// Retrieves a specified resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSchema

        /// <summary>
        /// Describes the specified schema in detail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchema service method.</param>
        /// 
        /// <returns>The response from the GetSchema service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSchema">REST API Reference for GetSchema Operation</seealso>
        public virtual GetSchemaResponse GetSchema(GetSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaResponseUnmarshaller.Instance;

            return Invoke<GetSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSchema operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSchema">REST API Reference for GetSchema Operation</seealso>
        public virtual IAsyncResult BeginGetSchema(GetSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSchema.</param>
        /// 
        /// <returns>Returns a  GetSchemaResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSchema">REST API Reference for GetSchema Operation</seealso>
        public virtual GetSchemaResponse EndGetSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSchemaByDefinition

        /// <summary>
        /// Retrieves a schema by the <code>SchemaDefinition</code>. The schema definition is
        /// sent to the Schema Registry, canonicalized, and hashed. If the hash is matched within
        /// the scope of the <code>SchemaName</code> or ARN (or the default registry, if none
        /// is supplied), that schema’s metadata is returned. Otherwise, a 404 or NotFound error
        /// is returned. Schema versions in <code>Deleted</code> statuses will not be included
        /// in the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaByDefinition service method.</param>
        /// 
        /// <returns>The response from the GetSchemaByDefinition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSchemaByDefinition">REST API Reference for GetSchemaByDefinition Operation</seealso>
        public virtual GetSchemaByDefinitionResponse GetSchemaByDefinition(GetSchemaByDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaByDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaByDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetSchemaByDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSchemaByDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaByDefinition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSchemaByDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSchemaByDefinition">REST API Reference for GetSchemaByDefinition Operation</seealso>
        public virtual IAsyncResult BeginGetSchemaByDefinition(GetSchemaByDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaByDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaByDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSchemaByDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSchemaByDefinition.</param>
        /// 
        /// <returns>Returns a  GetSchemaByDefinitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSchemaByDefinition">REST API Reference for GetSchemaByDefinition Operation</seealso>
        public virtual GetSchemaByDefinitionResponse EndGetSchemaByDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSchemaByDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSchemaVersion

        /// <summary>
        /// Get the specified schema by its unique ID assigned when a version of the schema is
        /// created or registered. Schema versions in Deleted status will not be included in the
        /// results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaVersion service method.</param>
        /// 
        /// <returns>The response from the GetSchemaVersion service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSchemaVersion">REST API Reference for GetSchemaVersion Operation</seealso>
        public virtual GetSchemaVersionResponse GetSchemaVersion(GetSchemaVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaVersionResponseUnmarshaller.Instance;

            return Invoke<GetSchemaVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSchemaVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaVersion operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSchemaVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSchemaVersion">REST API Reference for GetSchemaVersion Operation</seealso>
        public virtual IAsyncResult BeginGetSchemaVersion(GetSchemaVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSchemaVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSchemaVersion.</param>
        /// 
        /// <returns>Returns a  GetSchemaVersionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSchemaVersion">REST API Reference for GetSchemaVersion Operation</seealso>
        public virtual GetSchemaVersionResponse EndGetSchemaVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSchemaVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSchemaVersionsDiff

        /// <summary>
        /// Fetches the schema version difference in the specified difference type between two
        /// stored schema versions in the Schema Registry.
        /// 
        ///  
        /// <para>
        /// This API allows you to compare two schema versions between two schema definitions
        /// under the same schema.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaVersionsDiff service method.</param>
        /// 
        /// <returns>The response from the GetSchemaVersionsDiff service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSchemaVersionsDiff">REST API Reference for GetSchemaVersionsDiff Operation</seealso>
        public virtual GetSchemaVersionsDiffResponse GetSchemaVersionsDiff(GetSchemaVersionsDiffRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaVersionsDiffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaVersionsDiffResponseUnmarshaller.Instance;

            return Invoke<GetSchemaVersionsDiffResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSchemaVersionsDiff operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaVersionsDiff operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSchemaVersionsDiff
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSchemaVersionsDiff">REST API Reference for GetSchemaVersionsDiff Operation</seealso>
        public virtual IAsyncResult BeginGetSchemaVersionsDiff(GetSchemaVersionsDiffRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaVersionsDiffRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaVersionsDiffResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSchemaVersionsDiff operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSchemaVersionsDiff.</param>
        /// 
        /// <returns>Returns a  GetSchemaVersionsDiffResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSchemaVersionsDiff">REST API Reference for GetSchemaVersionsDiff Operation</seealso>
        public virtual GetSchemaVersionsDiffResponse EndGetSchemaVersionsDiff(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSchemaVersionsDiffResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSecurityConfiguration

        /// <summary>
        /// Retrieves a specified security configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetSecurityConfiguration service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSecurityConfiguration">REST API Reference for GetSecurityConfiguration Operation</seealso>
        public virtual GetSecurityConfigurationResponse GetSecurityConfiguration(GetSecurityConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetSecurityConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSecurityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityConfiguration operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSecurityConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSecurityConfiguration">REST API Reference for GetSecurityConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetSecurityConfiguration(GetSecurityConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSecurityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSecurityConfiguration.</param>
        /// 
        /// <returns>Returns a  GetSecurityConfigurationResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSecurityConfiguration">REST API Reference for GetSecurityConfiguration Operation</seealso>
        public virtual GetSecurityConfigurationResponse EndGetSecurityConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSecurityConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSecurityConfigurations

        /// <summary>
        /// Retrieves a list of all security configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityConfigurations service method.</param>
        /// 
        /// <returns>The response from the GetSecurityConfigurations service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSecurityConfigurations">REST API Reference for GetSecurityConfigurations Operation</seealso>
        public virtual GetSecurityConfigurationsResponse GetSecurityConfigurations(GetSecurityConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecurityConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityConfigurationsResponseUnmarshaller.Instance;

            return Invoke<GetSecurityConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSecurityConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityConfigurations operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSecurityConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSecurityConfigurations">REST API Reference for GetSecurityConfigurations Operation</seealso>
        public virtual IAsyncResult BeginGetSecurityConfigurations(GetSecurityConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecurityConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSecurityConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSecurityConfigurations.</param>
        /// 
        /// <returns>Returns a  GetSecurityConfigurationsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSecurityConfigurations">REST API Reference for GetSecurityConfigurations Operation</seealso>
        public virtual GetSecurityConfigurationsResponse EndGetSecurityConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSecurityConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSession

        /// <summary>
        /// Retrieves the session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSession">REST API Reference for GetSession Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the GetSession operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSession">REST API Reference for GetSession Operation</seealso>
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
        /// <returns>Returns a  GetSessionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual GetSessionResponse EndGetSession(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStatement

        /// <summary>
        /// Retrieves the statement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStatement service method.</param>
        /// 
        /// <returns>The response from the GetStatement service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IllegalSessionStateException">
        /// The session is in an invalid state to perform a requested operation.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetStatement">REST API Reference for GetStatement Operation</seealso>
        public virtual GetStatementResponse GetStatement(GetStatementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStatementResponseUnmarshaller.Instance;

            return Invoke<GetStatementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStatement operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetStatement">REST API Reference for GetStatement Operation</seealso>
        public virtual IAsyncResult BeginGetStatement(GetStatementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStatementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStatement.</param>
        /// 
        /// <returns>Returns a  GetStatementResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetStatement">REST API Reference for GetStatement Operation</seealso>
        public virtual GetStatementResponse EndGetStatement(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStatementResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTable

        /// <summary>
        /// Retrieves the <code>Table</code> definition in a Data Catalog for a specified table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTable service method.</param>
        /// 
        /// <returns>The response from the GetTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNotReadyException">
        /// A resource was not ready for a transaction.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTable">REST API Reference for GetTable Operation</seealso>
        public virtual GetTableResponse GetTable(GetTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableResponseUnmarshaller.Instance;

            return Invoke<GetTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTable operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTable">REST API Reference for GetTable Operation</seealso>
        public virtual IAsyncResult BeginGetTable(GetTableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTable.</param>
        /// 
        /// <returns>Returns a  GetTableResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTable">REST API Reference for GetTable Operation</seealso>
        public virtual GetTableResponse EndGetTable(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTableResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTables

        /// <summary>
        /// Retrieves the definitions of some or all of the tables in a given <code>Database</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTables service method.</param>
        /// 
        /// <returns>The response from the GetTables service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTables">REST API Reference for GetTables Operation</seealso>
        public virtual GetTablesResponse GetTables(GetTablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTablesResponseUnmarshaller.Instance;

            return Invoke<GetTablesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTables operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTables">REST API Reference for GetTables Operation</seealso>
        public virtual IAsyncResult BeginGetTables(GetTablesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTablesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTables.</param>
        /// 
        /// <returns>Returns a  GetTablesResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTables">REST API Reference for GetTables Operation</seealso>
        public virtual GetTablesResponse EndGetTables(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTablesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTableVersion

        /// <summary>
        /// Retrieves a specified version of a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableVersion service method.</param>
        /// 
        /// <returns>The response from the GetTableVersion service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersion">REST API Reference for GetTableVersion Operation</seealso>
        public virtual GetTableVersionResponse GetTableVersion(GetTableVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableVersionResponseUnmarshaller.Instance;

            return Invoke<GetTableVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableVersion operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersion">REST API Reference for GetTableVersion Operation</seealso>
        public virtual IAsyncResult BeginGetTableVersion(GetTableVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableVersion.</param>
        /// 
        /// <returns>Returns a  GetTableVersionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersion">REST API Reference for GetTableVersion Operation</seealso>
        public virtual GetTableVersionResponse EndGetTableVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTableVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTableVersions

        /// <summary>
        /// Retrieves a list of strings that identify available versions of a specified table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableVersions service method.</param>
        /// 
        /// <returns>The response from the GetTableVersions service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersions">REST API Reference for GetTableVersions Operation</seealso>
        public virtual GetTableVersionsResponse GetTableVersions(GetTableVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableVersionsResponseUnmarshaller.Instance;

            return Invoke<GetTableVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableVersions operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersions">REST API Reference for GetTableVersions Operation</seealso>
        public virtual IAsyncResult BeginGetTableVersions(GetTableVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableVersions.</param>
        /// 
        /// <returns>Returns a  GetTableVersionsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTableVersions">REST API Reference for GetTableVersions Operation</seealso>
        public virtual GetTableVersionsResponse EndGetTableVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTableVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTags

        /// <summary>
        /// Retrieves a list of tags associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
        /// 
        /// <returns>The response from the GetTags service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTags">REST API Reference for GetTags Operation</seealso>
        public virtual GetTagsResponse GetTags(GetTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;

            return Invoke<GetTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTags operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTags">REST API Reference for GetTags Operation</seealso>
        public virtual IAsyncResult BeginGetTags(GetTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTags.</param>
        /// 
        /// <returns>Returns a  GetTagsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTags">REST API Reference for GetTags Operation</seealso>
        public virtual GetTagsResponse EndGetTags(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTrigger

        /// <summary>
        /// Retrieves the definition of a trigger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrigger service method.</param>
        /// 
        /// <returns>The response from the GetTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTrigger">REST API Reference for GetTrigger Operation</seealso>
        public virtual GetTriggerResponse GetTrigger(GetTriggerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTriggerResponseUnmarshaller.Instance;

            return Invoke<GetTriggerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrigger operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrigger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTrigger">REST API Reference for GetTrigger Operation</seealso>
        public virtual IAsyncResult BeginGetTrigger(GetTriggerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTriggerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrigger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrigger.</param>
        /// 
        /// <returns>Returns a  GetTriggerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTrigger">REST API Reference for GetTrigger Operation</seealso>
        public virtual GetTriggerResponse EndGetTrigger(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTriggerResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTriggers

        /// <summary>
        /// Gets all the triggers associated with a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTriggers service method.</param>
        /// 
        /// <returns>The response from the GetTriggers service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTriggers">REST API Reference for GetTriggers Operation</seealso>
        public virtual GetTriggersResponse GetTriggers(GetTriggersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTriggersResponseUnmarshaller.Instance;

            return Invoke<GetTriggersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTriggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTriggers operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTriggers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTriggers">REST API Reference for GetTriggers Operation</seealso>
        public virtual IAsyncResult BeginGetTriggers(GetTriggersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTriggersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTriggers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTriggers.</param>
        /// 
        /// <returns>Returns a  GetTriggersResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetTriggers">REST API Reference for GetTriggers Operation</seealso>
        public virtual GetTriggersResponse EndGetTriggers(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTriggersResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUnfilteredPartitionMetadata

        /// <summary>
        /// Retrieves partition metadata from the Data Catalog that contains unfiltered metadata.
        /// 
        ///  
        /// <para>
        /// For IAM authorization, the public IAM action associated with this API is <code>glue:GetPartition</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUnfilteredPartitionMetadata service method.</param>
        /// 
        /// <returns>The response from the GetUnfilteredPartitionMetadata service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.PermissionTypeMismatchException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUnfilteredPartitionMetadata">REST API Reference for GetUnfilteredPartitionMetadata Operation</seealso>
        public virtual GetUnfilteredPartitionMetadataResponse GetUnfilteredPartitionMetadata(GetUnfilteredPartitionMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUnfilteredPartitionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUnfilteredPartitionMetadataResponseUnmarshaller.Instance;

            return Invoke<GetUnfilteredPartitionMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUnfilteredPartitionMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUnfilteredPartitionMetadata operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUnfilteredPartitionMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUnfilteredPartitionMetadata">REST API Reference for GetUnfilteredPartitionMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetUnfilteredPartitionMetadata(GetUnfilteredPartitionMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUnfilteredPartitionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUnfilteredPartitionMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUnfilteredPartitionMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUnfilteredPartitionMetadata.</param>
        /// 
        /// <returns>Returns a  GetUnfilteredPartitionMetadataResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUnfilteredPartitionMetadata">REST API Reference for GetUnfilteredPartitionMetadata Operation</seealso>
        public virtual GetUnfilteredPartitionMetadataResponse EndGetUnfilteredPartitionMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUnfilteredPartitionMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUnfilteredPartitionsMetadata

        /// <summary>
        /// Retrieves partition metadata from the Data Catalog that contains unfiltered metadata.
        /// 
        ///  
        /// <para>
        /// For IAM authorization, the public IAM action associated with this API is <code>glue:GetPartitions</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUnfilteredPartitionsMetadata service method.</param>
        /// 
        /// <returns>The response from the GetUnfilteredPartitionsMetadata service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.PermissionTypeMismatchException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUnfilteredPartitionsMetadata">REST API Reference for GetUnfilteredPartitionsMetadata Operation</seealso>
        public virtual GetUnfilteredPartitionsMetadataResponse GetUnfilteredPartitionsMetadata(GetUnfilteredPartitionsMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUnfilteredPartitionsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUnfilteredPartitionsMetadataResponseUnmarshaller.Instance;

            return Invoke<GetUnfilteredPartitionsMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUnfilteredPartitionsMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUnfilteredPartitionsMetadata operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUnfilteredPartitionsMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUnfilteredPartitionsMetadata">REST API Reference for GetUnfilteredPartitionsMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetUnfilteredPartitionsMetadata(GetUnfilteredPartitionsMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUnfilteredPartitionsMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUnfilteredPartitionsMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUnfilteredPartitionsMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUnfilteredPartitionsMetadata.</param>
        /// 
        /// <returns>Returns a  GetUnfilteredPartitionsMetadataResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUnfilteredPartitionsMetadata">REST API Reference for GetUnfilteredPartitionsMetadata Operation</seealso>
        public virtual GetUnfilteredPartitionsMetadataResponse EndGetUnfilteredPartitionsMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUnfilteredPartitionsMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUnfilteredTableMetadata

        /// <summary>
        /// Retrieves table metadata from the Data Catalog that contains unfiltered metadata.
        /// 
        ///  
        /// <para>
        /// For IAM authorization, the public IAM action associated with this API is <code>glue:GetTable</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUnfilteredTableMetadata service method.</param>
        /// 
        /// <returns>The response from the GetUnfilteredTableMetadata service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.PermissionTypeMismatchException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUnfilteredTableMetadata">REST API Reference for GetUnfilteredTableMetadata Operation</seealso>
        public virtual GetUnfilteredTableMetadataResponse GetUnfilteredTableMetadata(GetUnfilteredTableMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUnfilteredTableMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUnfilteredTableMetadataResponseUnmarshaller.Instance;

            return Invoke<GetUnfilteredTableMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUnfilteredTableMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUnfilteredTableMetadata operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUnfilteredTableMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUnfilteredTableMetadata">REST API Reference for GetUnfilteredTableMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetUnfilteredTableMetadata(GetUnfilteredTableMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUnfilteredTableMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUnfilteredTableMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUnfilteredTableMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUnfilteredTableMetadata.</param>
        /// 
        /// <returns>Returns a  GetUnfilteredTableMetadataResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUnfilteredTableMetadata">REST API Reference for GetUnfilteredTableMetadata Operation</seealso>
        public virtual GetUnfilteredTableMetadataResponse EndGetUnfilteredTableMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUnfilteredTableMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUserDefinedFunction

        /// <summary>
        /// Retrieves a specified function definition from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserDefinedFunction service method.</param>
        /// 
        /// <returns>The response from the GetUserDefinedFunction service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunction">REST API Reference for GetUserDefinedFunction Operation</seealso>
        public virtual GetUserDefinedFunctionResponse GetUserDefinedFunction(GetUserDefinedFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserDefinedFunctionResponseUnmarshaller.Instance;

            return Invoke<GetUserDefinedFunctionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserDefinedFunction operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserDefinedFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunction">REST API Reference for GetUserDefinedFunction Operation</seealso>
        public virtual IAsyncResult BeginGetUserDefinedFunction(GetUserDefinedFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserDefinedFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserDefinedFunction.</param>
        /// 
        /// <returns>Returns a  GetUserDefinedFunctionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunction">REST API Reference for GetUserDefinedFunction Operation</seealso>
        public virtual GetUserDefinedFunctionResponse EndGetUserDefinedFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserDefinedFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUserDefinedFunctions

        /// <summary>
        /// Retrieves multiple function definitions from the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserDefinedFunctions service method.</param>
        /// 
        /// <returns>The response from the GetUserDefinedFunctions service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunctions">REST API Reference for GetUserDefinedFunctions Operation</seealso>
        public virtual GetUserDefinedFunctionsResponse GetUserDefinedFunctions(GetUserDefinedFunctionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserDefinedFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserDefinedFunctionsResponseUnmarshaller.Instance;

            return Invoke<GetUserDefinedFunctionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserDefinedFunctions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserDefinedFunctions operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserDefinedFunctions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunctions">REST API Reference for GetUserDefinedFunctions Operation</seealso>
        public virtual IAsyncResult BeginGetUserDefinedFunctions(GetUserDefinedFunctionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserDefinedFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserDefinedFunctionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserDefinedFunctions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserDefinedFunctions.</param>
        /// 
        /// <returns>Returns a  GetUserDefinedFunctionsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetUserDefinedFunctions">REST API Reference for GetUserDefinedFunctions Operation</seealso>
        public virtual GetUserDefinedFunctionsResponse EndGetUserDefinedFunctions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserDefinedFunctionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWorkflow

        /// <summary>
        /// Retrieves resource metadata for a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
        /// 
        /// <returns>The response from the GetWorkflow service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        public virtual GetWorkflowResponse GetWorkflow(GetWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        public virtual IAsyncResult BeginGetWorkflow(GetWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflow.</param>
        /// 
        /// <returns>Returns a  GetWorkflowResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        public virtual GetWorkflowResponse EndGetWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWorkflowRun

        /// <summary>
        /// Retrieves the metadata for a given workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRun service method.</param>
        /// 
        /// <returns>The response from the GetWorkflowRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetWorkflowRun">REST API Reference for GetWorkflowRun Operation</seealso>
        public virtual GetWorkflowRunResponse GetWorkflowRun(GetWorkflowRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowRunResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflowRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetWorkflowRun">REST API Reference for GetWorkflowRun Operation</seealso>
        public virtual IAsyncResult BeginGetWorkflowRun(GetWorkflowRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflowRun.</param>
        /// 
        /// <returns>Returns a  GetWorkflowRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetWorkflowRun">REST API Reference for GetWorkflowRun Operation</seealso>
        public virtual GetWorkflowRunResponse EndGetWorkflowRun(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkflowRunResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWorkflowRunProperties

        /// <summary>
        /// Retrieves the workflow run properties which were set during the run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRunProperties service method.</param>
        /// 
        /// <returns>The response from the GetWorkflowRunProperties service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetWorkflowRunProperties">REST API Reference for GetWorkflowRunProperties Operation</seealso>
        public virtual GetWorkflowRunPropertiesResponse GetWorkflowRunProperties(GetWorkflowRunPropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowRunPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowRunPropertiesResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowRunPropertiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflowRunProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRunProperties operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflowRunProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetWorkflowRunProperties">REST API Reference for GetWorkflowRunProperties Operation</seealso>
        public virtual IAsyncResult BeginGetWorkflowRunProperties(GetWorkflowRunPropertiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowRunPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowRunPropertiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflowRunProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflowRunProperties.</param>
        /// 
        /// <returns>Returns a  GetWorkflowRunPropertiesResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetWorkflowRunProperties">REST API Reference for GetWorkflowRunProperties Operation</seealso>
        public virtual GetWorkflowRunPropertiesResponse EndGetWorkflowRunProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkflowRunPropertiesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWorkflowRuns

        /// <summary>
        /// Retrieves metadata for all runs of a given workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRuns service method.</param>
        /// 
        /// <returns>The response from the GetWorkflowRuns service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetWorkflowRuns">REST API Reference for GetWorkflowRuns Operation</seealso>
        public virtual GetWorkflowRunsResponse GetWorkflowRuns(GetWorkflowRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowRunsResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflowRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRuns operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflowRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetWorkflowRuns">REST API Reference for GetWorkflowRuns Operation</seealso>
        public virtual IAsyncResult BeginGetWorkflowRuns(GetWorkflowRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflowRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflowRuns.</param>
        /// 
        /// <returns>Returns a  GetWorkflowRunsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/GetWorkflowRuns">REST API Reference for GetWorkflowRuns Operation</seealso>
        public virtual GetWorkflowRunsResponse EndGetWorkflowRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkflowRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportCatalogToGlue

        /// <summary>
        /// Imports an existing Amazon Athena Data Catalog to Glue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCatalogToGlue service method.</param>
        /// 
        /// <returns>The response from the ImportCatalogToGlue service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ImportCatalogToGlue">REST API Reference for ImportCatalogToGlue Operation</seealso>
        public virtual ImportCatalogToGlueResponse ImportCatalogToGlue(ImportCatalogToGlueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportCatalogToGlueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCatalogToGlueResponseUnmarshaller.Instance;

            return Invoke<ImportCatalogToGlueResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportCatalogToGlue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportCatalogToGlue operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportCatalogToGlue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ImportCatalogToGlue">REST API Reference for ImportCatalogToGlue Operation</seealso>
        public virtual IAsyncResult BeginImportCatalogToGlue(ImportCatalogToGlueRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportCatalogToGlueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCatalogToGlueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportCatalogToGlue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportCatalogToGlue.</param>
        /// 
        /// <returns>Returns a  ImportCatalogToGlueResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ImportCatalogToGlue">REST API Reference for ImportCatalogToGlue Operation</seealso>
        public virtual ImportCatalogToGlueResponse EndImportCatalogToGlue(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportCatalogToGlueResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBlueprints

        /// <summary>
        /// Lists all the blueprint names in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBlueprints service method.</param>
        /// 
        /// <returns>The response from the ListBlueprints service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListBlueprints">REST API Reference for ListBlueprints Operation</seealso>
        public virtual ListBlueprintsResponse ListBlueprints(ListBlueprintsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBlueprintsResponseUnmarshaller.Instance;

            return Invoke<ListBlueprintsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBlueprints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBlueprints operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBlueprints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListBlueprints">REST API Reference for ListBlueprints Operation</seealso>
        public virtual IAsyncResult BeginListBlueprints(ListBlueprintsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBlueprintsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBlueprints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBlueprints.</param>
        /// 
        /// <returns>Returns a  ListBlueprintsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListBlueprints">REST API Reference for ListBlueprints Operation</seealso>
        public virtual ListBlueprintsResponse EndListBlueprints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBlueprintsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCrawlers

        /// <summary>
        /// Retrieves the names of all crawler resources in this Amazon Web Services account,
        /// or the resources with the specified tag. This operation allows you to see which resources
        /// are available in your account, and their names.
        /// 
        ///  
        /// <para>
        /// This operation takes the optional <code>Tags</code> field, which you can use as a
        /// filter on the response so that tagged resources can be retrieved as a group. If you
        /// choose to use tags filtering, only resources with the tag are retrieved.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCrawlers service method.</param>
        /// 
        /// <returns>The response from the ListCrawlers service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListCrawlers">REST API Reference for ListCrawlers Operation</seealso>
        public virtual ListCrawlersResponse ListCrawlers(ListCrawlersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCrawlersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCrawlersResponseUnmarshaller.Instance;

            return Invoke<ListCrawlersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCrawlers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCrawlers operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCrawlers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListCrawlers">REST API Reference for ListCrawlers Operation</seealso>
        public virtual IAsyncResult BeginListCrawlers(ListCrawlersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCrawlersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCrawlersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCrawlers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCrawlers.</param>
        /// 
        /// <returns>Returns a  ListCrawlersResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListCrawlers">REST API Reference for ListCrawlers Operation</seealso>
        public virtual ListCrawlersResponse EndListCrawlers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCrawlersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCrawls

        /// <summary>
        /// Returns all the crawls of a specified crawler. Returns only the crawls that have occurred
        /// since the launch date of the crawler history feature, and only retains up to 12 months
        /// of crawls. Older crawls will not be returned.
        /// 
        ///  
        /// <para>
        /// You may use this API to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Retrive all the crawls of a specified crawler.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Retrieve all the crawls of a specified crawler within a limited count.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Retrieve all the crawls of a specified crawler in a specific time range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Retrieve all the crawls of a specified crawler with a particular state, crawl ID,
        /// or DPU hour value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCrawls service method.</param>
        /// 
        /// <returns>The response from the ListCrawls service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListCrawls">REST API Reference for ListCrawls Operation</seealso>
        public virtual ListCrawlsResponse ListCrawls(ListCrawlsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCrawlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCrawlsResponseUnmarshaller.Instance;

            return Invoke<ListCrawlsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCrawls operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCrawls operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCrawls
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListCrawls">REST API Reference for ListCrawls Operation</seealso>
        public virtual IAsyncResult BeginListCrawls(ListCrawlsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCrawlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCrawlsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCrawls operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCrawls.</param>
        /// 
        /// <returns>Returns a  ListCrawlsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListCrawls">REST API Reference for ListCrawls Operation</seealso>
        public virtual ListCrawlsResponse EndListCrawls(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCrawlsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCustomEntityTypes

        /// <summary>
        /// Lists all the custom patterns that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomEntityTypes service method.</param>
        /// 
        /// <returns>The response from the ListCustomEntityTypes service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListCustomEntityTypes">REST API Reference for ListCustomEntityTypes Operation</seealso>
        public virtual ListCustomEntityTypesResponse ListCustomEntityTypes(ListCustomEntityTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomEntityTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomEntityTypesResponseUnmarshaller.Instance;

            return Invoke<ListCustomEntityTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomEntityTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomEntityTypes operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomEntityTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListCustomEntityTypes">REST API Reference for ListCustomEntityTypes Operation</seealso>
        public virtual IAsyncResult BeginListCustomEntityTypes(ListCustomEntityTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomEntityTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomEntityTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomEntityTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomEntityTypes.</param>
        /// 
        /// <returns>Returns a  ListCustomEntityTypesResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListCustomEntityTypes">REST API Reference for ListCustomEntityTypes Operation</seealso>
        public virtual ListCustomEntityTypesResponse EndListCustomEntityTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCustomEntityTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataQualityResults

        /// <summary>
        /// Returns all data quality execution results for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataQualityResults service method.</param>
        /// 
        /// <returns>The response from the ListDataQualityResults service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListDataQualityResults">REST API Reference for ListDataQualityResults Operation</seealso>
        public virtual ListDataQualityResultsResponse ListDataQualityResults(ListDataQualityResultsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataQualityResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataQualityResultsResponseUnmarshaller.Instance;

            return Invoke<ListDataQualityResultsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataQualityResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataQualityResults operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataQualityResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListDataQualityResults">REST API Reference for ListDataQualityResults Operation</seealso>
        public virtual IAsyncResult BeginListDataQualityResults(ListDataQualityResultsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataQualityResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataQualityResultsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataQualityResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataQualityResults.</param>
        /// 
        /// <returns>Returns a  ListDataQualityResultsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListDataQualityResults">REST API Reference for ListDataQualityResults Operation</seealso>
        public virtual ListDataQualityResultsResponse EndListDataQualityResults(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataQualityResultsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataQualityRuleRecommendationRuns

        /// <summary>
        /// Lists the recommendation runs meeting the filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataQualityRuleRecommendationRuns service method.</param>
        /// 
        /// <returns>The response from the ListDataQualityRuleRecommendationRuns service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListDataQualityRuleRecommendationRuns">REST API Reference for ListDataQualityRuleRecommendationRuns Operation</seealso>
        public virtual ListDataQualityRuleRecommendationRunsResponse ListDataQualityRuleRecommendationRuns(ListDataQualityRuleRecommendationRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataQualityRuleRecommendationRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataQualityRuleRecommendationRunsResponseUnmarshaller.Instance;

            return Invoke<ListDataQualityRuleRecommendationRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataQualityRuleRecommendationRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataQualityRuleRecommendationRuns operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataQualityRuleRecommendationRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListDataQualityRuleRecommendationRuns">REST API Reference for ListDataQualityRuleRecommendationRuns Operation</seealso>
        public virtual IAsyncResult BeginListDataQualityRuleRecommendationRuns(ListDataQualityRuleRecommendationRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataQualityRuleRecommendationRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataQualityRuleRecommendationRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataQualityRuleRecommendationRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataQualityRuleRecommendationRuns.</param>
        /// 
        /// <returns>Returns a  ListDataQualityRuleRecommendationRunsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListDataQualityRuleRecommendationRuns">REST API Reference for ListDataQualityRuleRecommendationRuns Operation</seealso>
        public virtual ListDataQualityRuleRecommendationRunsResponse EndListDataQualityRuleRecommendationRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataQualityRuleRecommendationRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataQualityRulesetEvaluationRuns

        /// <summary>
        /// Lists all the runs meeting the filter criteria, where a ruleset is evaluated against
        /// a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataQualityRulesetEvaluationRuns service method.</param>
        /// 
        /// <returns>The response from the ListDataQualityRulesetEvaluationRuns service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListDataQualityRulesetEvaluationRuns">REST API Reference for ListDataQualityRulesetEvaluationRuns Operation</seealso>
        public virtual ListDataQualityRulesetEvaluationRunsResponse ListDataQualityRulesetEvaluationRuns(ListDataQualityRulesetEvaluationRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataQualityRulesetEvaluationRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataQualityRulesetEvaluationRunsResponseUnmarshaller.Instance;

            return Invoke<ListDataQualityRulesetEvaluationRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataQualityRulesetEvaluationRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataQualityRulesetEvaluationRuns operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataQualityRulesetEvaluationRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListDataQualityRulesetEvaluationRuns">REST API Reference for ListDataQualityRulesetEvaluationRuns Operation</seealso>
        public virtual IAsyncResult BeginListDataQualityRulesetEvaluationRuns(ListDataQualityRulesetEvaluationRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataQualityRulesetEvaluationRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataQualityRulesetEvaluationRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataQualityRulesetEvaluationRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataQualityRulesetEvaluationRuns.</param>
        /// 
        /// <returns>Returns a  ListDataQualityRulesetEvaluationRunsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListDataQualityRulesetEvaluationRuns">REST API Reference for ListDataQualityRulesetEvaluationRuns Operation</seealso>
        public virtual ListDataQualityRulesetEvaluationRunsResponse EndListDataQualityRulesetEvaluationRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataQualityRulesetEvaluationRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataQualityRulesets

        /// <summary>
        /// Returns a paginated list of rulesets for the specified list of Glue tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataQualityRulesets service method.</param>
        /// 
        /// <returns>The response from the ListDataQualityRulesets service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListDataQualityRulesets">REST API Reference for ListDataQualityRulesets Operation</seealso>
        public virtual ListDataQualityRulesetsResponse ListDataQualityRulesets(ListDataQualityRulesetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataQualityRulesetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataQualityRulesetsResponseUnmarshaller.Instance;

            return Invoke<ListDataQualityRulesetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataQualityRulesets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataQualityRulesets operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataQualityRulesets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListDataQualityRulesets">REST API Reference for ListDataQualityRulesets Operation</seealso>
        public virtual IAsyncResult BeginListDataQualityRulesets(ListDataQualityRulesetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataQualityRulesetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataQualityRulesetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataQualityRulesets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataQualityRulesets.</param>
        /// 
        /// <returns>Returns a  ListDataQualityRulesetsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListDataQualityRulesets">REST API Reference for ListDataQualityRulesets Operation</seealso>
        public virtual ListDataQualityRulesetsResponse EndListDataQualityRulesets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataQualityRulesetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDevEndpoints

        /// <summary>
        /// Retrieves the names of all <code>DevEndpoint</code> resources in this Amazon Web Services
        /// account, or the resources with the specified tag. This operation allows you to see
        /// which resources are available in your account, and their names.
        /// 
        ///  
        /// <para>
        /// This operation takes the optional <code>Tags</code> field, which you can use as a
        /// filter on the response so that tagged resources can be retrieved as a group. If you
        /// choose to use tags filtering, only resources with the tag are retrieved.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListDevEndpoints service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListDevEndpoints">REST API Reference for ListDevEndpoints Operation</seealso>
        public virtual ListDevEndpointsResponse ListDevEndpoints(ListDevEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListDevEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevEndpoints operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListDevEndpoints">REST API Reference for ListDevEndpoints Operation</seealso>
        public virtual IAsyncResult BeginListDevEndpoints(ListDevEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevEndpoints.</param>
        /// 
        /// <returns>Returns a  ListDevEndpointsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListDevEndpoints">REST API Reference for ListDevEndpoints Operation</seealso>
        public virtual ListDevEndpointsResponse EndListDevEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDevEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListJobs

        /// <summary>
        /// Retrieves the names of all job resources in this Amazon Web Services account, or the
        /// resources with the specified tag. This operation allows you to see which resources
        /// are available in your account, and their names.
        /// 
        ///  
        /// <para>
        /// This operation takes the optional <code>Tags</code> field, which you can use as a
        /// filter on the response so that tagged resources can be retrieved as a group. If you
        /// choose to use tags filtering, only resources with the tag are retrieved.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a  ListJobsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual ListJobsResponse EndListJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMLTransforms

        /// <summary>
        /// Retrieves a sortable, filterable list of existing Glue machine learning transforms
        /// in this Amazon Web Services account, or the resources with the specified tag. This
        /// operation takes the optional <code>Tags</code> field, which you can use as a filter
        /// of the responses so that tagged resources can be retrieved as a group. If you choose
        /// to use tag filtering, only resources with the tags are retrieved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLTransforms service method.</param>
        /// 
        /// <returns>The response from the ListMLTransforms service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListMLTransforms">REST API Reference for ListMLTransforms Operation</seealso>
        public virtual ListMLTransformsResponse ListMLTransforms(ListMLTransformsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMLTransformsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMLTransformsResponseUnmarshaller.Instance;

            return Invoke<ListMLTransformsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMLTransforms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMLTransforms operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMLTransforms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListMLTransforms">REST API Reference for ListMLTransforms Operation</seealso>
        public virtual IAsyncResult BeginListMLTransforms(ListMLTransformsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMLTransformsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMLTransformsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMLTransforms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMLTransforms.</param>
        /// 
        /// <returns>Returns a  ListMLTransformsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListMLTransforms">REST API Reference for ListMLTransforms Operation</seealso>
        public virtual ListMLTransformsResponse EndListMLTransforms(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMLTransformsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRegistries

        /// <summary>
        /// Returns a list of registries that you have created, with minimal registry information.
        /// Registries in the <code>Deleting</code> status will not be included in the results.
        /// Empty results will be returned if there are no registries available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistries service method.</param>
        /// 
        /// <returns>The response from the ListRegistries service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListRegistries">REST API Reference for ListRegistries Operation</seealso>
        public virtual ListRegistriesResponse ListRegistries(ListRegistriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRegistriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegistriesResponseUnmarshaller.Instance;

            return Invoke<ListRegistriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRegistries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRegistries operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRegistries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListRegistries">REST API Reference for ListRegistries Operation</seealso>
        public virtual IAsyncResult BeginListRegistries(ListRegistriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRegistriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegistriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRegistries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRegistries.</param>
        /// 
        /// <returns>Returns a  ListRegistriesResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListRegistries">REST API Reference for ListRegistries Operation</seealso>
        public virtual ListRegistriesResponse EndListRegistries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRegistriesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSchemas

        /// <summary>
        /// Returns a list of schemas with minimal details. Schemas in Deleting status will not
        /// be included in the results. Empty results will be returned if there are no schemas
        /// available.
        /// 
        ///  
        /// <para>
        /// When the <code>RegistryId</code> is not provided, all the schemas across registries
        /// will be part of the API response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSchemas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
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
        /// <returns>Returns a  ListSchemasResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        public virtual ListSchemasResponse EndListSchemas(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSchemasResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSchemaVersions

        /// <summary>
        /// Returns a list of schema versions that you have created, with minimal information.
        /// Schema versions in Deleted status will not be included in the results. Empty results
        /// will be returned if there are no schema versions available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaVersions service method.</param>
        /// 
        /// <returns>The response from the ListSchemaVersions service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListSchemaVersions">REST API Reference for ListSchemaVersions Operation</seealso>
        public virtual ListSchemaVersionsResponse ListSchemaVersions(ListSchemaVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaVersionsResponseUnmarshaller.Instance;

            return Invoke<ListSchemaVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSchemaVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaVersions operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSchemaVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListSchemaVersions">REST API Reference for ListSchemaVersions Operation</seealso>
        public virtual IAsyncResult BeginListSchemaVersions(ListSchemaVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchemaVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchemaVersions.</param>
        /// 
        /// <returns>Returns a  ListSchemaVersionsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListSchemaVersions">REST API Reference for ListSchemaVersions Operation</seealso>
        public virtual ListSchemaVersionsResponse EndListSchemaVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSchemaVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSessions

        /// <summary>
        /// Retrieve a list of sessions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// 
        /// <returns>The response from the ListSessions service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListSessions">REST API Reference for ListSessions Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListSessions operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListSessions">REST API Reference for ListSessions Operation</seealso>
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
        /// <returns>Returns a  ListSessionsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual ListSessionsResponse EndListSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStatements

        /// <summary>
        /// Lists statements for the session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStatements service method.</param>
        /// 
        /// <returns>The response from the ListStatements service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IllegalSessionStateException">
        /// The session is in an invalid state to perform a requested operation.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListStatements">REST API Reference for ListStatements Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListStatements operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStatements
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListStatements">REST API Reference for ListStatements Operation</seealso>
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
        /// <returns>Returns a  ListStatementsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListStatements">REST API Reference for ListStatements Operation</seealso>
        public virtual ListStatementsResponse EndListStatements(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStatementsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTriggers

        /// <summary>
        /// Retrieves the names of all trigger resources in this Amazon Web Services account,
        /// or the resources with the specified tag. This operation allows you to see which resources
        /// are available in your account, and their names.
        /// 
        ///  
        /// <para>
        /// This operation takes the optional <code>Tags</code> field, which you can use as a
        /// filter on the response so that tagged resources can be retrieved as a group. If you
        /// choose to use tags filtering, only resources with the tag are retrieved.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTriggers service method.</param>
        /// 
        /// <returns>The response from the ListTriggers service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListTriggers">REST API Reference for ListTriggers Operation</seealso>
        public virtual ListTriggersResponse ListTriggers(ListTriggersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTriggersResponseUnmarshaller.Instance;

            return Invoke<ListTriggersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTriggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTriggers operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTriggers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListTriggers">REST API Reference for ListTriggers Operation</seealso>
        public virtual IAsyncResult BeginListTriggers(ListTriggersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTriggersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTriggers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTriggers.</param>
        /// 
        /// <returns>Returns a  ListTriggersResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListTriggers">REST API Reference for ListTriggers Operation</seealso>
        public virtual ListTriggersResponse EndListTriggers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTriggersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWorkflows

        /// <summary>
        /// Lists names of workflows created in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// 
        /// <returns>The response from the ListWorkflows service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        public virtual ListWorkflowsResponse ListWorkflows(ListWorkflowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkflows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkflows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        public virtual IAsyncResult BeginListWorkflows(ListWorkflowsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkflows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkflows.</param>
        /// 
        /// <returns>Returns a  ListWorkflowsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        public virtual ListWorkflowsResponse EndListWorkflows(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWorkflowsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutDataCatalogEncryptionSettings

        /// <summary>
        /// Sets the security configuration for a specified catalog. After the configuration has
        /// been set, the specified encryption is applied to every catalog write thereafter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDataCatalogEncryptionSettings service method.</param>
        /// 
        /// <returns>The response from the PutDataCatalogEncryptionSettings service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/PutDataCatalogEncryptionSettings">REST API Reference for PutDataCatalogEncryptionSettings Operation</seealso>
        public virtual PutDataCatalogEncryptionSettingsResponse PutDataCatalogEncryptionSettings(PutDataCatalogEncryptionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDataCatalogEncryptionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDataCatalogEncryptionSettingsResponseUnmarshaller.Instance;

            return Invoke<PutDataCatalogEncryptionSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutDataCatalogEncryptionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDataCatalogEncryptionSettings operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDataCatalogEncryptionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/PutDataCatalogEncryptionSettings">REST API Reference for PutDataCatalogEncryptionSettings Operation</seealso>
        public virtual IAsyncResult BeginPutDataCatalogEncryptionSettings(PutDataCatalogEncryptionSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDataCatalogEncryptionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDataCatalogEncryptionSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDataCatalogEncryptionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDataCatalogEncryptionSettings.</param>
        /// 
        /// <returns>Returns a  PutDataCatalogEncryptionSettingsResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/PutDataCatalogEncryptionSettings">REST API Reference for PutDataCatalogEncryptionSettings Operation</seealso>
        public virtual PutDataCatalogEncryptionSettingsResponse EndPutDataCatalogEncryptionSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDataCatalogEncryptionSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutResourcePolicy

        /// <summary>
        /// Sets the Data Catalog resource policy for access control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConditionCheckFailureException">
        /// A specified condition was not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutSchemaVersionMetadata

        /// <summary>
        /// Puts the metadata key value pair for a specified schema version ID. A maximum of 10
        /// key value pairs will be allowed per schema version. They can be added over one or
        /// more calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSchemaVersionMetadata service method.</param>
        /// 
        /// <returns>The response from the PutSchemaVersionMetadata service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/PutSchemaVersionMetadata">REST API Reference for PutSchemaVersionMetadata Operation</seealso>
        public virtual PutSchemaVersionMetadataResponse PutSchemaVersionMetadata(PutSchemaVersionMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSchemaVersionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSchemaVersionMetadataResponseUnmarshaller.Instance;

            return Invoke<PutSchemaVersionMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutSchemaVersionMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSchemaVersionMetadata operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSchemaVersionMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/PutSchemaVersionMetadata">REST API Reference for PutSchemaVersionMetadata Operation</seealso>
        public virtual IAsyncResult BeginPutSchemaVersionMetadata(PutSchemaVersionMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSchemaVersionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSchemaVersionMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutSchemaVersionMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSchemaVersionMetadata.</param>
        /// 
        /// <returns>Returns a  PutSchemaVersionMetadataResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/PutSchemaVersionMetadata">REST API Reference for PutSchemaVersionMetadata Operation</seealso>
        public virtual PutSchemaVersionMetadataResponse EndPutSchemaVersionMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<PutSchemaVersionMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  PutWorkflowRunProperties

        /// <summary>
        /// Puts the specified workflow run properties for the given workflow run. If a property
        /// already exists for the specified run, then it overrides the value otherwise adds the
        /// property to existing properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWorkflowRunProperties service method.</param>
        /// 
        /// <returns>The response from the PutWorkflowRunProperties service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/PutWorkflowRunProperties">REST API Reference for PutWorkflowRunProperties Operation</seealso>
        public virtual PutWorkflowRunPropertiesResponse PutWorkflowRunProperties(PutWorkflowRunPropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutWorkflowRunPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWorkflowRunPropertiesResponseUnmarshaller.Instance;

            return Invoke<PutWorkflowRunPropertiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutWorkflowRunProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutWorkflowRunProperties operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutWorkflowRunProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/PutWorkflowRunProperties">REST API Reference for PutWorkflowRunProperties Operation</seealso>
        public virtual IAsyncResult BeginPutWorkflowRunProperties(PutWorkflowRunPropertiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutWorkflowRunPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWorkflowRunPropertiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutWorkflowRunProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutWorkflowRunProperties.</param>
        /// 
        /// <returns>Returns a  PutWorkflowRunPropertiesResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/PutWorkflowRunProperties">REST API Reference for PutWorkflowRunProperties Operation</seealso>
        public virtual PutWorkflowRunPropertiesResponse EndPutWorkflowRunProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<PutWorkflowRunPropertiesResponse>(asyncResult);
        }

        #endregion
        
        #region  QuerySchemaVersionMetadata

        /// <summary>
        /// Queries for the schema version metadata information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QuerySchemaVersionMetadata service method.</param>
        /// 
        /// <returns>The response from the QuerySchemaVersionMetadata service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/QuerySchemaVersionMetadata">REST API Reference for QuerySchemaVersionMetadata Operation</seealso>
        public virtual QuerySchemaVersionMetadataResponse QuerySchemaVersionMetadata(QuerySchemaVersionMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QuerySchemaVersionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QuerySchemaVersionMetadataResponseUnmarshaller.Instance;

            return Invoke<QuerySchemaVersionMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QuerySchemaVersionMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QuerySchemaVersionMetadata operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQuerySchemaVersionMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/QuerySchemaVersionMetadata">REST API Reference for QuerySchemaVersionMetadata Operation</seealso>
        public virtual IAsyncResult BeginQuerySchemaVersionMetadata(QuerySchemaVersionMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QuerySchemaVersionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QuerySchemaVersionMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QuerySchemaVersionMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQuerySchemaVersionMetadata.</param>
        /// 
        /// <returns>Returns a  QuerySchemaVersionMetadataResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/QuerySchemaVersionMetadata">REST API Reference for QuerySchemaVersionMetadata Operation</seealso>
        public virtual QuerySchemaVersionMetadataResponse EndQuerySchemaVersionMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<QuerySchemaVersionMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterSchemaVersion

        /// <summary>
        /// Adds a new version to the existing schema. Returns an error if new version of schema
        /// does not meet the compatibility requirements of the schema set. This API will not
        /// create a new schema set and will return a 404 error if the schema set is not already
        /// present in the Schema Registry.
        /// 
        ///  
        /// <para>
        /// If this is the first schema definition to be registered in the Schema Registry, this
        /// API will store the schema version and return immediately. Otherwise, this call has
        /// the potential to run longer than other operations due to compatibility modes. You
        /// can call the <code>GetSchemaVersion</code> API with the <code>SchemaVersionId</code>
        /// to check compatibility modes.
        /// </para>
        ///  
        /// <para>
        /// If the same schema definition is already stored in Schema Registry as a version, the
        /// schema ID of the existing schema is returned to the caller.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterSchemaVersion service method.</param>
        /// 
        /// <returns>The response from the RegisterSchemaVersion service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/RegisterSchemaVersion">REST API Reference for RegisterSchemaVersion Operation</seealso>
        public virtual RegisterSchemaVersionResponse RegisterSchemaVersion(RegisterSchemaVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterSchemaVersionResponseUnmarshaller.Instance;

            return Invoke<RegisterSchemaVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterSchemaVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterSchemaVersion operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterSchemaVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/RegisterSchemaVersion">REST API Reference for RegisterSchemaVersion Operation</seealso>
        public virtual IAsyncResult BeginRegisterSchemaVersion(RegisterSchemaVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterSchemaVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterSchemaVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterSchemaVersion.</param>
        /// 
        /// <returns>Returns a  RegisterSchemaVersionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/RegisterSchemaVersion">REST API Reference for RegisterSchemaVersion Operation</seealso>
        public virtual RegisterSchemaVersionResponse EndRegisterSchemaVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterSchemaVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveSchemaVersionMetadata

        /// <summary>
        /// Removes a key value pair from the schema version metadata for the specified schema
        /// version ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveSchemaVersionMetadata service method.</param>
        /// 
        /// <returns>The response from the RemoveSchemaVersionMetadata service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/RemoveSchemaVersionMetadata">REST API Reference for RemoveSchemaVersionMetadata Operation</seealso>
        public virtual RemoveSchemaVersionMetadataResponse RemoveSchemaVersionMetadata(RemoveSchemaVersionMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveSchemaVersionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveSchemaVersionMetadataResponseUnmarshaller.Instance;

            return Invoke<RemoveSchemaVersionMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveSchemaVersionMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveSchemaVersionMetadata operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveSchemaVersionMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/RemoveSchemaVersionMetadata">REST API Reference for RemoveSchemaVersionMetadata Operation</seealso>
        public virtual IAsyncResult BeginRemoveSchemaVersionMetadata(RemoveSchemaVersionMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveSchemaVersionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveSchemaVersionMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveSchemaVersionMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveSchemaVersionMetadata.</param>
        /// 
        /// <returns>Returns a  RemoveSchemaVersionMetadataResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/RemoveSchemaVersionMetadata">REST API Reference for RemoveSchemaVersionMetadata Operation</seealso>
        public virtual RemoveSchemaVersionMetadataResponse EndRemoveSchemaVersionMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveSchemaVersionMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  ResetJobBookmark

        /// <summary>
        /// Resets a bookmark entry.
        /// 
        ///  
        /// <para>
        /// For more information about enabling and using job bookmarks, see:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/glue/latest/dg/monitor-continuations.html">Tracking
        /// processed data using job bookmarks</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-programming-etl-glue-arguments.html">Job
        /// parameters used by Glue</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-api-jobs-job.html#aws-glue-api-jobs-job-Job">Job
        /// structure</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetJobBookmark service method.</param>
        /// 
        /// <returns>The response from the ResetJobBookmark service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ResetJobBookmark">REST API Reference for ResetJobBookmark Operation</seealso>
        public virtual ResetJobBookmarkResponse ResetJobBookmark(ResetJobBookmarkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetJobBookmarkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetJobBookmarkResponseUnmarshaller.Instance;

            return Invoke<ResetJobBookmarkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetJobBookmark operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetJobBookmark operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetJobBookmark
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ResetJobBookmark">REST API Reference for ResetJobBookmark Operation</seealso>
        public virtual IAsyncResult BeginResetJobBookmark(ResetJobBookmarkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetJobBookmarkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetJobBookmarkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetJobBookmark operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetJobBookmark.</param>
        /// 
        /// <returns>Returns a  ResetJobBookmarkResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ResetJobBookmark">REST API Reference for ResetJobBookmark Operation</seealso>
        public virtual ResetJobBookmarkResponse EndResetJobBookmark(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetJobBookmarkResponse>(asyncResult);
        }

        #endregion
        
        #region  ResumeWorkflowRun

        /// <summary>
        /// Restarts selected nodes of a previous partially completed workflow run and resumes
        /// the workflow run. The selected nodes and all nodes that are downstream from the selected
        /// nodes are run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeWorkflowRun service method.</param>
        /// 
        /// <returns>The response from the ResumeWorkflowRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentRunsExceededException">
        /// Too many jobs are being run concurrently.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IllegalWorkflowStateException">
        /// The workflow is in an invalid state to perform a requested operation.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ResumeWorkflowRun">REST API Reference for ResumeWorkflowRun Operation</seealso>
        public virtual ResumeWorkflowRunResponse ResumeWorkflowRun(ResumeWorkflowRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeWorkflowRunResponseUnmarshaller.Instance;

            return Invoke<ResumeWorkflowRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResumeWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeWorkflowRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResumeWorkflowRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ResumeWorkflowRun">REST API Reference for ResumeWorkflowRun Operation</seealso>
        public virtual IAsyncResult BeginResumeWorkflowRun(ResumeWorkflowRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeWorkflowRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResumeWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResumeWorkflowRun.</param>
        /// 
        /// <returns>Returns a  ResumeWorkflowRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/ResumeWorkflowRun">REST API Reference for ResumeWorkflowRun Operation</seealso>
        public virtual ResumeWorkflowRunResponse EndResumeWorkflowRun(IAsyncResult asyncResult)
        {
            return EndInvoke<ResumeWorkflowRunResponse>(asyncResult);
        }

        #endregion
        
        #region  RunStatement

        /// <summary>
        /// Executes the statement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunStatement service method.</param>
        /// 
        /// <returns>The response from the RunStatement service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IllegalSessionStateException">
        /// The session is in an invalid state to perform a requested operation.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ValidationException">
        /// A value could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/RunStatement">REST API Reference for RunStatement Operation</seealso>
        public virtual RunStatementResponse RunStatement(RunStatementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunStatementResponseUnmarshaller.Instance;

            return Invoke<RunStatementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RunStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunStatement operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRunStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/RunStatement">REST API Reference for RunStatement Operation</seealso>
        public virtual IAsyncResult BeginRunStatement(RunStatementRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunStatementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RunStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunStatement.</param>
        /// 
        /// <returns>Returns a  RunStatementResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/RunStatement">REST API Reference for RunStatement Operation</seealso>
        public virtual RunStatementResponse EndRunStatement(IAsyncResult asyncResult)
        {
            return EndInvoke<RunStatementResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchTables

        /// <summary>
        /// Searches a set of tables based on properties in the table metadata as well as on the
        /// parent database. You can search against text or filter conditions. 
        /// 
        ///  
        /// <para>
        /// You can only get tables that you have access to based on the security policies defined
        /// in Lake Formation. You need at least a read-only access to the table for it to be
        /// returned. If you do not have access to all the columns in the table, these columns
        /// will not be searched against when returning the list of tables back to you. If you
        /// have access to the columns but not the data in the columns, those columns and the
        /// associated metadata for those columns will be included in the search. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTables service method.</param>
        /// 
        /// <returns>The response from the SearchTables service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/SearchTables">REST API Reference for SearchTables Operation</seealso>
        public virtual SearchTablesResponse SearchTables(SearchTablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTablesResponseUnmarshaller.Instance;

            return Invoke<SearchTablesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchTables operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchTables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/SearchTables">REST API Reference for SearchTables Operation</seealso>
        public virtual IAsyncResult BeginSearchTables(SearchTablesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTablesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchTables.</param>
        /// 
        /// <returns>Returns a  SearchTablesResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/SearchTables">REST API Reference for SearchTables Operation</seealso>
        public virtual SearchTablesResponse EndSearchTables(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchTablesResponse>(asyncResult);
        }

        #endregion
        
        #region  StartBlueprintRun

        /// <summary>
        /// Starts a new run of the specified blueprint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBlueprintRun service method.</param>
        /// 
        /// <returns>The response from the StartBlueprintRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IllegalBlueprintStateException">
        /// The blueprint is in an invalid state to perform a requested operation.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartBlueprintRun">REST API Reference for StartBlueprintRun Operation</seealso>
        public virtual StartBlueprintRunResponse StartBlueprintRun(StartBlueprintRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBlueprintRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBlueprintRunResponseUnmarshaller.Instance;

            return Invoke<StartBlueprintRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartBlueprintRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartBlueprintRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartBlueprintRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartBlueprintRun">REST API Reference for StartBlueprintRun Operation</seealso>
        public virtual IAsyncResult BeginStartBlueprintRun(StartBlueprintRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBlueprintRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBlueprintRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartBlueprintRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartBlueprintRun.</param>
        /// 
        /// <returns>Returns a  StartBlueprintRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartBlueprintRun">REST API Reference for StartBlueprintRun Operation</seealso>
        public virtual StartBlueprintRunResponse EndStartBlueprintRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartBlueprintRunResponse>(asyncResult);
        }

        #endregion
        
        #region  StartCrawler

        /// <summary>
        /// Starts a crawl using the specified crawler, regardless of what is scheduled. If the
        /// crawler is already running, returns a <a href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-api-exceptions.html#aws-glue-api-exceptions-CrawlerRunningException">CrawlerRunningException</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCrawler service method.</param>
        /// 
        /// <returns>The response from the StartCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.CrawlerRunningException">
        /// The operation cannot be performed because the crawler is already running.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawler">REST API Reference for StartCrawler Operation</seealso>
        public virtual StartCrawlerResponse StartCrawler(StartCrawlerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCrawlerResponseUnmarshaller.Instance;

            return Invoke<StartCrawlerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCrawler operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCrawler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawler">REST API Reference for StartCrawler Operation</seealso>
        public virtual IAsyncResult BeginStartCrawler(StartCrawlerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCrawlerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartCrawler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCrawler.</param>
        /// 
        /// <returns>Returns a  StartCrawlerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawler">REST API Reference for StartCrawler Operation</seealso>
        public virtual StartCrawlerResponse EndStartCrawler(IAsyncResult asyncResult)
        {
            return EndInvoke<StartCrawlerResponse>(asyncResult);
        }

        #endregion
        
        #region  StartCrawlerSchedule

        /// <summary>
        /// Changes the schedule state of the specified crawler to <code>SCHEDULED</code>, unless
        /// the crawler is already running or the schedule state is already <code>SCHEDULED</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCrawlerSchedule service method.</param>
        /// 
        /// <returns>The response from the StartCrawlerSchedule service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.NoScheduleException">
        /// There is no applicable schedule.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.SchedulerRunningException">
        /// The specified scheduler is already running.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.SchedulerTransitioningException">
        /// The specified scheduler is transitioning.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawlerSchedule">REST API Reference for StartCrawlerSchedule Operation</seealso>
        public virtual StartCrawlerScheduleResponse StartCrawlerSchedule(StartCrawlerScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCrawlerScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCrawlerScheduleResponseUnmarshaller.Instance;

            return Invoke<StartCrawlerScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCrawlerSchedule operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCrawlerSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawlerSchedule">REST API Reference for StartCrawlerSchedule Operation</seealso>
        public virtual IAsyncResult BeginStartCrawlerSchedule(StartCrawlerScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCrawlerScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCrawlerScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCrawlerSchedule.</param>
        /// 
        /// <returns>Returns a  StartCrawlerScheduleResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartCrawlerSchedule">REST API Reference for StartCrawlerSchedule Operation</seealso>
        public virtual StartCrawlerScheduleResponse EndStartCrawlerSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<StartCrawlerScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDataQualityRuleRecommendationRun

        /// <summary>
        /// Starts a recommendation run that is used to generate rules when you don't know what
        /// rules to write. Glue Data Quality analyzes the data and comes up with recommendations
        /// for a potential ruleset. You can then triage the ruleset and modify the generated
        /// ruleset to your liking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataQualityRuleRecommendationRun service method.</param>
        /// 
        /// <returns>The response from the StartDataQualityRuleRecommendationRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConflictException">
        /// The <code>CreatePartitions</code> API was called on a table that has indexes enabled.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartDataQualityRuleRecommendationRun">REST API Reference for StartDataQualityRuleRecommendationRun Operation</seealso>
        public virtual StartDataQualityRuleRecommendationRunResponse StartDataQualityRuleRecommendationRun(StartDataQualityRuleRecommendationRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDataQualityRuleRecommendationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataQualityRuleRecommendationRunResponseUnmarshaller.Instance;

            return Invoke<StartDataQualityRuleRecommendationRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDataQualityRuleRecommendationRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataQualityRuleRecommendationRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDataQualityRuleRecommendationRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartDataQualityRuleRecommendationRun">REST API Reference for StartDataQualityRuleRecommendationRun Operation</seealso>
        public virtual IAsyncResult BeginStartDataQualityRuleRecommendationRun(StartDataQualityRuleRecommendationRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDataQualityRuleRecommendationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataQualityRuleRecommendationRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDataQualityRuleRecommendationRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDataQualityRuleRecommendationRun.</param>
        /// 
        /// <returns>Returns a  StartDataQualityRuleRecommendationRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartDataQualityRuleRecommendationRun">REST API Reference for StartDataQualityRuleRecommendationRun Operation</seealso>
        public virtual StartDataQualityRuleRecommendationRunResponse EndStartDataQualityRuleRecommendationRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDataQualityRuleRecommendationRunResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDataQualityRulesetEvaluationRun

        /// <summary>
        /// Once you have a ruleset definition (either recommended or your own), you call this
        /// operation to evaluate the ruleset against a data source (Glue table). The evaluation
        /// computes results which you can retrieve with the <code>GetDataQualityResult</code>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataQualityRulesetEvaluationRun service method.</param>
        /// 
        /// <returns>The response from the StartDataQualityRulesetEvaluationRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConflictException">
        /// The <code>CreatePartitions</code> API was called on a table that has indexes enabled.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartDataQualityRulesetEvaluationRun">REST API Reference for StartDataQualityRulesetEvaluationRun Operation</seealso>
        public virtual StartDataQualityRulesetEvaluationRunResponse StartDataQualityRulesetEvaluationRun(StartDataQualityRulesetEvaluationRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDataQualityRulesetEvaluationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataQualityRulesetEvaluationRunResponseUnmarshaller.Instance;

            return Invoke<StartDataQualityRulesetEvaluationRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDataQualityRulesetEvaluationRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataQualityRulesetEvaluationRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDataQualityRulesetEvaluationRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartDataQualityRulesetEvaluationRun">REST API Reference for StartDataQualityRulesetEvaluationRun Operation</seealso>
        public virtual IAsyncResult BeginStartDataQualityRulesetEvaluationRun(StartDataQualityRulesetEvaluationRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDataQualityRulesetEvaluationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataQualityRulesetEvaluationRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDataQualityRulesetEvaluationRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDataQualityRulesetEvaluationRun.</param>
        /// 
        /// <returns>Returns a  StartDataQualityRulesetEvaluationRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartDataQualityRulesetEvaluationRun">REST API Reference for StartDataQualityRulesetEvaluationRun Operation</seealso>
        public virtual StartDataQualityRulesetEvaluationRunResponse EndStartDataQualityRulesetEvaluationRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDataQualityRulesetEvaluationRunResponse>(asyncResult);
        }

        #endregion
        
        #region  StartExportLabelsTaskRun

        /// <summary>
        /// Begins an asynchronous task to export all labeled data for a particular transform.
        /// This task is the only label-related API call that is not part of the typical active
        /// learning workflow. You typically use <code>StartExportLabelsTaskRun</code> when you
        /// want to work with all of your existing labels at the same time, such as when you want
        /// to remove or change labels that were previously submitted as truth. This API operation
        /// accepts the <code>TransformId</code> whose labels you want to export and an Amazon
        /// Simple Storage Service (Amazon S3) path to export the labels to. The operation returns
        /// a <code>TaskRunId</code>. You can check on the status of your task run by calling
        /// the <code>GetMLTaskRun</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExportLabelsTaskRun service method.</param>
        /// 
        /// <returns>The response from the StartExportLabelsTaskRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartExportLabelsTaskRun">REST API Reference for StartExportLabelsTaskRun Operation</seealso>
        public virtual StartExportLabelsTaskRunResponse StartExportLabelsTaskRun(StartExportLabelsTaskRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartExportLabelsTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExportLabelsTaskRunResponseUnmarshaller.Instance;

            return Invoke<StartExportLabelsTaskRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartExportLabelsTaskRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartExportLabelsTaskRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartExportLabelsTaskRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartExportLabelsTaskRun">REST API Reference for StartExportLabelsTaskRun Operation</seealso>
        public virtual IAsyncResult BeginStartExportLabelsTaskRun(StartExportLabelsTaskRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartExportLabelsTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExportLabelsTaskRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartExportLabelsTaskRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartExportLabelsTaskRun.</param>
        /// 
        /// <returns>Returns a  StartExportLabelsTaskRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartExportLabelsTaskRun">REST API Reference for StartExportLabelsTaskRun Operation</seealso>
        public virtual StartExportLabelsTaskRunResponse EndStartExportLabelsTaskRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartExportLabelsTaskRunResponse>(asyncResult);
        }

        #endregion
        
        #region  StartImportLabelsTaskRun

        /// <summary>
        /// Enables you to provide additional labels (examples of truth) to be used to teach the
        /// machine learning transform and improve its quality. This API operation is generally
        /// used as part of the active learning workflow that starts with the <code>StartMLLabelingSetGenerationTaskRun</code>
        /// call and that ultimately results in improving the quality of your machine learning
        /// transform. 
        /// 
        ///  
        /// <para>
        /// After the <code>StartMLLabelingSetGenerationTaskRun</code> finishes, Glue machine
        /// learning will have generated a series of questions for humans to answer. (Answering
        /// these questions is often called 'labeling' in the machine learning workflows). In
        /// the case of the <code>FindMatches</code> transform, these questions are of the form,
        /// “What is the correct way to group these rows together into groups composed entirely
        /// of matching records?” After the labeling process is finished, users upload their answers/labels
        /// with a call to <code>StartImportLabelsTaskRun</code>. After <code>StartImportLabelsTaskRun</code>
        /// finishes, all future runs of the machine learning transform use the new and improved
        /// labels and perform a higher-quality transformation.
        /// </para>
        ///  
        /// <para>
        /// By default, <code>StartMLLabelingSetGenerationTaskRun</code> continually learns from
        /// and combines all labels that you upload unless you set <code>Replace</code> to true.
        /// If you set <code>Replace</code> to true, <code>StartImportLabelsTaskRun</code> deletes
        /// and forgets all previously uploaded labels and learns only from the exact set that
        /// you upload. Replacing labels can be helpful if you realize that you previously uploaded
        /// incorrect labels, and you believe that they are having a negative effect on your transform
        /// quality.
        /// </para>
        ///  
        /// <para>
        /// You can check on the status of your task run by calling the <code>GetMLTaskRun</code>
        /// operation. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImportLabelsTaskRun service method.</param>
        /// 
        /// <returns>The response from the StartImportLabelsTaskRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartImportLabelsTaskRun">REST API Reference for StartImportLabelsTaskRun Operation</seealso>
        public virtual StartImportLabelsTaskRunResponse StartImportLabelsTaskRun(StartImportLabelsTaskRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImportLabelsTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportLabelsTaskRunResponseUnmarshaller.Instance;

            return Invoke<StartImportLabelsTaskRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartImportLabelsTaskRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartImportLabelsTaskRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartImportLabelsTaskRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartImportLabelsTaskRun">REST API Reference for StartImportLabelsTaskRun Operation</seealso>
        public virtual IAsyncResult BeginStartImportLabelsTaskRun(StartImportLabelsTaskRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartImportLabelsTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportLabelsTaskRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartImportLabelsTaskRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartImportLabelsTaskRun.</param>
        /// 
        /// <returns>Returns a  StartImportLabelsTaskRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartImportLabelsTaskRun">REST API Reference for StartImportLabelsTaskRun Operation</seealso>
        public virtual StartImportLabelsTaskRunResponse EndStartImportLabelsTaskRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartImportLabelsTaskRunResponse>(asyncResult);
        }

        #endregion
        
        #region  StartJobRun

        /// <summary>
        /// Starts a job run using a job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun service method.</param>
        /// 
        /// <returns>The response from the StartJobRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentRunsExceededException">
        /// Too many jobs are being run concurrently.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        public virtual StartJobRunResponse StartJobRun(StartJobRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobRunResponseUnmarshaller.Instance;

            return Invoke<StartJobRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartJobRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        public virtual IAsyncResult BeginStartJobRun(StartJobRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartJobRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartJobRun.</param>
        /// 
        /// <returns>Returns a  StartJobRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        public virtual StartJobRunResponse EndStartJobRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartJobRunResponse>(asyncResult);
        }

        #endregion
        
        #region  StartMLEvaluationTaskRun

        /// <summary>
        /// Starts a task to estimate the quality of the transform. 
        /// 
        ///  
        /// <para>
        /// When you provide label sets as examples of truth, Glue machine learning uses some
        /// of those examples to learn from them. The rest of the labels are used as a test to
        /// estimate quality.
        /// </para>
        ///  
        /// <para>
        /// Returns a unique identifier for the run. You can call <code>GetMLTaskRun</code> to
        /// get more information about the stats of the <code>EvaluationTaskRun</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMLEvaluationTaskRun service method.</param>
        /// 
        /// <returns>The response from the StartMLEvaluationTaskRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentRunsExceededException">
        /// Too many jobs are being run concurrently.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.MLTransformNotReadyException">
        /// The machine learning transform is not ready to run.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartMLEvaluationTaskRun">REST API Reference for StartMLEvaluationTaskRun Operation</seealso>
        public virtual StartMLEvaluationTaskRunResponse StartMLEvaluationTaskRun(StartMLEvaluationTaskRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMLEvaluationTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMLEvaluationTaskRunResponseUnmarshaller.Instance;

            return Invoke<StartMLEvaluationTaskRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMLEvaluationTaskRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMLEvaluationTaskRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMLEvaluationTaskRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartMLEvaluationTaskRun">REST API Reference for StartMLEvaluationTaskRun Operation</seealso>
        public virtual IAsyncResult BeginStartMLEvaluationTaskRun(StartMLEvaluationTaskRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMLEvaluationTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMLEvaluationTaskRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMLEvaluationTaskRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMLEvaluationTaskRun.</param>
        /// 
        /// <returns>Returns a  StartMLEvaluationTaskRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartMLEvaluationTaskRun">REST API Reference for StartMLEvaluationTaskRun Operation</seealso>
        public virtual StartMLEvaluationTaskRunResponse EndStartMLEvaluationTaskRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMLEvaluationTaskRunResponse>(asyncResult);
        }

        #endregion
        
        #region  StartMLLabelingSetGenerationTaskRun

        /// <summary>
        /// Starts the active learning workflow for your machine learning transform to improve
        /// the transform's quality by generating label sets and adding labels.
        /// 
        ///  
        /// <para>
        /// When the <code>StartMLLabelingSetGenerationTaskRun</code> finishes, Glue will have
        /// generated a "labeling set" or a set of questions for humans to answer.
        /// </para>
        ///  
        /// <para>
        /// In the case of the <code>FindMatches</code> transform, these questions are of the
        /// form, “What is the correct way to group these rows together into groups composed entirely
        /// of matching records?” 
        /// </para>
        ///  
        /// <para>
        /// After the labeling process is finished, you can upload your labels with a call to
        /// <code>StartImportLabelsTaskRun</code>. After <code>StartImportLabelsTaskRun</code>
        /// finishes, all future runs of the machine learning transform will use the new and improved
        /// labels and perform a higher-quality transformation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMLLabelingSetGenerationTaskRun service method.</param>
        /// 
        /// <returns>The response from the StartMLLabelingSetGenerationTaskRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentRunsExceededException">
        /// Too many jobs are being run concurrently.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartMLLabelingSetGenerationTaskRun">REST API Reference for StartMLLabelingSetGenerationTaskRun Operation</seealso>
        public virtual StartMLLabelingSetGenerationTaskRunResponse StartMLLabelingSetGenerationTaskRun(StartMLLabelingSetGenerationTaskRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMLLabelingSetGenerationTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMLLabelingSetGenerationTaskRunResponseUnmarshaller.Instance;

            return Invoke<StartMLLabelingSetGenerationTaskRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMLLabelingSetGenerationTaskRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMLLabelingSetGenerationTaskRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMLLabelingSetGenerationTaskRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartMLLabelingSetGenerationTaskRun">REST API Reference for StartMLLabelingSetGenerationTaskRun Operation</seealso>
        public virtual IAsyncResult BeginStartMLLabelingSetGenerationTaskRun(StartMLLabelingSetGenerationTaskRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMLLabelingSetGenerationTaskRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMLLabelingSetGenerationTaskRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMLLabelingSetGenerationTaskRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMLLabelingSetGenerationTaskRun.</param>
        /// 
        /// <returns>Returns a  StartMLLabelingSetGenerationTaskRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartMLLabelingSetGenerationTaskRun">REST API Reference for StartMLLabelingSetGenerationTaskRun Operation</seealso>
        public virtual StartMLLabelingSetGenerationTaskRunResponse EndStartMLLabelingSetGenerationTaskRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMLLabelingSetGenerationTaskRunResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTrigger

        /// <summary>
        /// Starts an existing trigger. See <a href="https://docs.aws.amazon.com/glue/latest/dg/trigger-job.html">Triggering
        /// Jobs</a> for information about how different types of trigger are started.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTrigger service method.</param>
        /// 
        /// <returns>The response from the StartTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentRunsExceededException">
        /// Too many jobs are being run concurrently.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartTrigger">REST API Reference for StartTrigger Operation</seealso>
        public virtual StartTriggerResponse StartTrigger(StartTriggerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTriggerResponseUnmarshaller.Instance;

            return Invoke<StartTriggerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTrigger operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTrigger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartTrigger">REST API Reference for StartTrigger Operation</seealso>
        public virtual IAsyncResult BeginStartTrigger(StartTriggerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTriggerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTrigger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTrigger.</param>
        /// 
        /// <returns>Returns a  StartTriggerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartTrigger">REST API Reference for StartTrigger Operation</seealso>
        public virtual StartTriggerResponse EndStartTrigger(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTriggerResponse>(asyncResult);
        }

        #endregion
        
        #region  StartWorkflowRun

        /// <summary>
        /// Starts a new run of the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflowRun service method.</param>
        /// 
        /// <returns>The response from the StartWorkflowRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentRunsExceededException">
        /// Too many jobs are being run concurrently.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartWorkflowRun">REST API Reference for StartWorkflowRun Operation</seealso>
        public virtual StartWorkflowRunResponse StartWorkflowRun(StartWorkflowRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkflowRunResponseUnmarshaller.Instance;

            return Invoke<StartWorkflowRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflowRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartWorkflowRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartWorkflowRun">REST API Reference for StartWorkflowRun Operation</seealso>
        public virtual IAsyncResult BeginStartWorkflowRun(StartWorkflowRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkflowRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartWorkflowRun.</param>
        /// 
        /// <returns>Returns a  StartWorkflowRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StartWorkflowRun">REST API Reference for StartWorkflowRun Operation</seealso>
        public virtual StartWorkflowRunResponse EndStartWorkflowRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartWorkflowRunResponse>(asyncResult);
        }

        #endregion
        
        #region  StopCrawler

        /// <summary>
        /// If the specified crawler is running, stops the crawl.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCrawler service method.</param>
        /// 
        /// <returns>The response from the StopCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.CrawlerNotRunningException">
        /// The specified crawler is not running.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.CrawlerStoppingException">
        /// The specified crawler is stopping.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawler">REST API Reference for StopCrawler Operation</seealso>
        public virtual StopCrawlerResponse StopCrawler(StopCrawlerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCrawlerResponseUnmarshaller.Instance;

            return Invoke<StopCrawlerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCrawler operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopCrawler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawler">REST API Reference for StopCrawler Operation</seealso>
        public virtual IAsyncResult BeginStopCrawler(StopCrawlerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCrawlerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopCrawler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopCrawler.</param>
        /// 
        /// <returns>Returns a  StopCrawlerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawler">REST API Reference for StopCrawler Operation</seealso>
        public virtual StopCrawlerResponse EndStopCrawler(IAsyncResult asyncResult)
        {
            return EndInvoke<StopCrawlerResponse>(asyncResult);
        }

        #endregion
        
        #region  StopCrawlerSchedule

        /// <summary>
        /// Sets the schedule state of the specified crawler to <code>NOT_SCHEDULED</code>, but
        /// does not stop the crawler if it is already running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCrawlerSchedule service method.</param>
        /// 
        /// <returns>The response from the StopCrawlerSchedule service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.SchedulerNotRunningException">
        /// The specified scheduler is not running.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.SchedulerTransitioningException">
        /// The specified scheduler is transitioning.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawlerSchedule">REST API Reference for StopCrawlerSchedule Operation</seealso>
        public virtual StopCrawlerScheduleResponse StopCrawlerSchedule(StopCrawlerScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCrawlerScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCrawlerScheduleResponseUnmarshaller.Instance;

            return Invoke<StopCrawlerScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCrawlerSchedule operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopCrawlerSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawlerSchedule">REST API Reference for StopCrawlerSchedule Operation</seealso>
        public virtual IAsyncResult BeginStopCrawlerSchedule(StopCrawlerScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCrawlerScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCrawlerScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopCrawlerSchedule.</param>
        /// 
        /// <returns>Returns a  StopCrawlerScheduleResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopCrawlerSchedule">REST API Reference for StopCrawlerSchedule Operation</seealso>
        public virtual StopCrawlerScheduleResponse EndStopCrawlerSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<StopCrawlerScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  StopSession

        /// <summary>
        /// Stops the session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSession service method.</param>
        /// 
        /// <returns>The response from the StopSession service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IllegalSessionStateException">
        /// The session is in an invalid state to perform a requested operation.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopSession">REST API Reference for StopSession Operation</seealso>
        public virtual StopSessionResponse StopSession(StopSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSessionResponseUnmarshaller.Instance;

            return Invoke<StopSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopSession operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopSession">REST API Reference for StopSession Operation</seealso>
        public virtual IAsyncResult BeginStopSession(StopSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopSession.</param>
        /// 
        /// <returns>Returns a  StopSessionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopSession">REST API Reference for StopSession Operation</seealso>
        public virtual StopSessionResponse EndStopSession(IAsyncResult asyncResult)
        {
            return EndInvoke<StopSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  StopTrigger

        /// <summary>
        /// Stops a specified trigger.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTrigger service method.</param>
        /// 
        /// <returns>The response from the StopTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopTrigger">REST API Reference for StopTrigger Operation</seealso>
        public virtual StopTriggerResponse StopTrigger(StopTriggerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTriggerResponseUnmarshaller.Instance;

            return Invoke<StopTriggerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTrigger operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTrigger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopTrigger">REST API Reference for StopTrigger Operation</seealso>
        public virtual IAsyncResult BeginStopTrigger(StopTriggerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTriggerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopTrigger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTrigger.</param>
        /// 
        /// <returns>Returns a  StopTriggerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopTrigger">REST API Reference for StopTrigger Operation</seealso>
        public virtual StopTriggerResponse EndStopTrigger(IAsyncResult asyncResult)
        {
            return EndInvoke<StopTriggerResponse>(asyncResult);
        }

        #endregion
        
        #region  StopWorkflowRun

        /// <summary>
        /// Stops the execution of the specified workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopWorkflowRun service method.</param>
        /// 
        /// <returns>The response from the StopWorkflowRun service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IllegalWorkflowStateException">
        /// The workflow is in an invalid state to perform a requested operation.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopWorkflowRun">REST API Reference for StopWorkflowRun Operation</seealso>
        public virtual StopWorkflowRunResponse StopWorkflowRun(StopWorkflowRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopWorkflowRunResponseUnmarshaller.Instance;

            return Invoke<StopWorkflowRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopWorkflowRun operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopWorkflowRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopWorkflowRun">REST API Reference for StopWorkflowRun Operation</seealso>
        public virtual IAsyncResult BeginStopWorkflowRun(StopWorkflowRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopWorkflowRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopWorkflowRun.</param>
        /// 
        /// <returns>Returns a  StopWorkflowRunResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/StopWorkflowRun">REST API Reference for StopWorkflowRun Operation</seealso>
        public virtual StopWorkflowRunResponse EndStopWorkflowRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StopWorkflowRunResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds tags to a resource. A tag is a label you can assign to an Amazon Web Services
        /// resource. In Glue, you can tag only certain resources. For information about what
        /// resources you can tag, see <a href="https://docs.aws.amazon.com/glue/latest/dg/monitor-tags.html">Amazon
        /// Web Services Tags in Glue</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBlueprint

        /// <summary>
        /// Updates a registered blueprint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBlueprint service method.</param>
        /// 
        /// <returns>The response from the UpdateBlueprint service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IllegalBlueprintStateException">
        /// The blueprint is in an invalid state to perform a requested operation.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateBlueprint">REST API Reference for UpdateBlueprint Operation</seealso>
        public virtual UpdateBlueprintResponse UpdateBlueprint(UpdateBlueprintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBlueprintResponseUnmarshaller.Instance;

            return Invoke<UpdateBlueprintResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBlueprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBlueprint operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBlueprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateBlueprint">REST API Reference for UpdateBlueprint Operation</seealso>
        public virtual IAsyncResult BeginUpdateBlueprint(UpdateBlueprintRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBlueprintResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBlueprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBlueprint.</param>
        /// 
        /// <returns>Returns a  UpdateBlueprintResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateBlueprint">REST API Reference for UpdateBlueprint Operation</seealso>
        public virtual UpdateBlueprintResponse EndUpdateBlueprint(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBlueprintResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateClassifier

        /// <summary>
        /// Modifies an existing classifier (a <code>GrokClassifier</code>, an <code>XMLClassifier</code>,
        /// a <code>JsonClassifier</code>, or a <code>CsvClassifier</code>, depending on which
        /// field is present).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassifier service method.</param>
        /// 
        /// <returns>The response from the UpdateClassifier service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.VersionMismatchException">
        /// There was a version conflict.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateClassifier">REST API Reference for UpdateClassifier Operation</seealso>
        public virtual UpdateClassifierResponse UpdateClassifier(UpdateClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClassifierResponseUnmarshaller.Instance;

            return Invoke<UpdateClassifierResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClassifier operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateClassifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateClassifier">REST API Reference for UpdateClassifier Operation</seealso>
        public virtual IAsyncResult BeginUpdateClassifier(UpdateClassifierRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClassifierResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateClassifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateClassifier.</param>
        /// 
        /// <returns>Returns a  UpdateClassifierResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateClassifier">REST API Reference for UpdateClassifier Operation</seealso>
        public virtual UpdateClassifierResponse EndUpdateClassifier(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateClassifierResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateColumnStatisticsForPartition

        /// <summary>
        /// Creates or updates partition statistics of columns.
        /// 
        ///  
        /// <para>
        /// The Identity and Access Management (IAM) permission required for this operation is
        /// <code>UpdatePartition</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateColumnStatisticsForPartition service method.</param>
        /// 
        /// <returns>The response from the UpdateColumnStatisticsForPartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateColumnStatisticsForPartition">REST API Reference for UpdateColumnStatisticsForPartition Operation</seealso>
        public virtual UpdateColumnStatisticsForPartitionResponse UpdateColumnStatisticsForPartition(UpdateColumnStatisticsForPartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateColumnStatisticsForPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateColumnStatisticsForPartitionResponseUnmarshaller.Instance;

            return Invoke<UpdateColumnStatisticsForPartitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateColumnStatisticsForPartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateColumnStatisticsForPartition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateColumnStatisticsForPartition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateColumnStatisticsForPartition">REST API Reference for UpdateColumnStatisticsForPartition Operation</seealso>
        public virtual IAsyncResult BeginUpdateColumnStatisticsForPartition(UpdateColumnStatisticsForPartitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateColumnStatisticsForPartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateColumnStatisticsForPartitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateColumnStatisticsForPartition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateColumnStatisticsForPartition.</param>
        /// 
        /// <returns>Returns a  UpdateColumnStatisticsForPartitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateColumnStatisticsForPartition">REST API Reference for UpdateColumnStatisticsForPartition Operation</seealso>
        public virtual UpdateColumnStatisticsForPartitionResponse EndUpdateColumnStatisticsForPartition(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateColumnStatisticsForPartitionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateColumnStatisticsForTable

        /// <summary>
        /// Creates or updates table statistics of columns.
        /// 
        ///  
        /// <para>
        /// The Identity and Access Management (IAM) permission required for this operation is
        /// <code>UpdateTable</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateColumnStatisticsForTable service method.</param>
        /// 
        /// <returns>The response from the UpdateColumnStatisticsForTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateColumnStatisticsForTable">REST API Reference for UpdateColumnStatisticsForTable Operation</seealso>
        public virtual UpdateColumnStatisticsForTableResponse UpdateColumnStatisticsForTable(UpdateColumnStatisticsForTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateColumnStatisticsForTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateColumnStatisticsForTableResponseUnmarshaller.Instance;

            return Invoke<UpdateColumnStatisticsForTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateColumnStatisticsForTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateColumnStatisticsForTable operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateColumnStatisticsForTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateColumnStatisticsForTable">REST API Reference for UpdateColumnStatisticsForTable Operation</seealso>
        public virtual IAsyncResult BeginUpdateColumnStatisticsForTable(UpdateColumnStatisticsForTableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateColumnStatisticsForTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateColumnStatisticsForTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateColumnStatisticsForTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateColumnStatisticsForTable.</param>
        /// 
        /// <returns>Returns a  UpdateColumnStatisticsForTableResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateColumnStatisticsForTable">REST API Reference for UpdateColumnStatisticsForTable Operation</seealso>
        public virtual UpdateColumnStatisticsForTableResponse EndUpdateColumnStatisticsForTable(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateColumnStatisticsForTableResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConnection

        /// <summary>
        /// Updates a connection definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection service method.</param>
        /// 
        /// <returns>The response from the UpdateConnection service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        public virtual UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        public virtual IAsyncResult BeginUpdateConnection(UpdateConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnection.</param>
        /// 
        /// <returns>Returns a  UpdateConnectionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        public virtual UpdateConnectionResponse EndUpdateConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCrawler

        /// <summary>
        /// Updates a crawler. If a crawler is running, you must stop it using <code>StopCrawler</code>
        /// before updating it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrawler service method.</param>
        /// 
        /// <returns>The response from the UpdateCrawler service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.CrawlerRunningException">
        /// The operation cannot be performed because the crawler is already running.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.VersionMismatchException">
        /// There was a version conflict.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawler">REST API Reference for UpdateCrawler Operation</seealso>
        public virtual UpdateCrawlerResponse UpdateCrawler(UpdateCrawlerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCrawlerResponseUnmarshaller.Instance;

            return Invoke<UpdateCrawlerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCrawler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrawler operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCrawler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawler">REST API Reference for UpdateCrawler Operation</seealso>
        public virtual IAsyncResult BeginUpdateCrawler(UpdateCrawlerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCrawlerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCrawlerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCrawler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCrawler.</param>
        /// 
        /// <returns>Returns a  UpdateCrawlerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawler">REST API Reference for UpdateCrawler Operation</seealso>
        public virtual UpdateCrawlerResponse EndUpdateCrawler(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCrawlerResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCrawlerSchedule

        /// <summary>
        /// Updates the schedule of a crawler using a <code>cron</code> expression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrawlerSchedule service method.</param>
        /// 
        /// <returns>The response from the UpdateCrawlerSchedule service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.SchedulerTransitioningException">
        /// The specified scheduler is transitioning.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.VersionMismatchException">
        /// There was a version conflict.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawlerSchedule">REST API Reference for UpdateCrawlerSchedule Operation</seealso>
        public virtual UpdateCrawlerScheduleResponse UpdateCrawlerSchedule(UpdateCrawlerScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCrawlerScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCrawlerScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateCrawlerScheduleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrawlerSchedule operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCrawlerSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawlerSchedule">REST API Reference for UpdateCrawlerSchedule Operation</seealso>
        public virtual IAsyncResult BeginUpdateCrawlerSchedule(UpdateCrawlerScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCrawlerScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCrawlerScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCrawlerSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCrawlerSchedule.</param>
        /// 
        /// <returns>Returns a  UpdateCrawlerScheduleResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateCrawlerSchedule">REST API Reference for UpdateCrawlerSchedule Operation</seealso>
        public virtual UpdateCrawlerScheduleResponse EndUpdateCrawlerSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCrawlerScheduleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDatabase

        /// <summary>
        /// Updates an existing database definition in a Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatabase service method.</param>
        /// 
        /// <returns>The response from the UpdateDatabase service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDatabase">REST API Reference for UpdateDatabase Operation</seealso>
        public virtual UpdateDatabaseResponse UpdateDatabase(UpdateDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatabaseResponseUnmarshaller.Instance;

            return Invoke<UpdateDatabaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatabase operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDatabase">REST API Reference for UpdateDatabase Operation</seealso>
        public virtual IAsyncResult BeginUpdateDatabase(UpdateDatabaseRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatabaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDatabase.</param>
        /// 
        /// <returns>Returns a  UpdateDatabaseResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDatabase">REST API Reference for UpdateDatabase Operation</seealso>
        public virtual UpdateDatabaseResponse EndUpdateDatabase(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDatabaseResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataQualityRuleset

        /// <summary>
        /// Updates the specified data quality ruleset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataQualityRuleset service method.</param>
        /// 
        /// <returns>The response from the UpdateDataQualityRuleset service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.IdempotentParameterMismatchException">
        /// The same unique identifier was associated with two different records.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDataQualityRuleset">REST API Reference for UpdateDataQualityRuleset Operation</seealso>
        public virtual UpdateDataQualityRulesetResponse UpdateDataQualityRuleset(UpdateDataQualityRulesetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataQualityRulesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataQualityRulesetResponseUnmarshaller.Instance;

            return Invoke<UpdateDataQualityRulesetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataQualityRuleset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataQualityRuleset operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataQualityRuleset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDataQualityRuleset">REST API Reference for UpdateDataQualityRuleset Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataQualityRuleset(UpdateDataQualityRulesetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataQualityRulesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataQualityRulesetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataQualityRuleset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataQualityRuleset.</param>
        /// 
        /// <returns>Returns a  UpdateDataQualityRulesetResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDataQualityRuleset">REST API Reference for UpdateDataQualityRuleset Operation</seealso>
        public virtual UpdateDataQualityRulesetResponse EndUpdateDataQualityRuleset(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataQualityRulesetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDevEndpoint

        /// <summary>
        /// Updates a specified development endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateDevEndpoint service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ValidationException">
        /// A value could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDevEndpoint">REST API Reference for UpdateDevEndpoint Operation</seealso>
        public virtual UpdateDevEndpointResponse UpdateDevEndpoint(UpdateDevEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDevEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateDevEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevEndpoint operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDevEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDevEndpoint">REST API Reference for UpdateDevEndpoint Operation</seealso>
        public virtual IAsyncResult BeginUpdateDevEndpoint(UpdateDevEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDevEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDevEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDevEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateDevEndpointResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateDevEndpoint">REST API Reference for UpdateDevEndpoint Operation</seealso>
        public virtual UpdateDevEndpointResponse EndUpdateDevEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDevEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateJob

        /// <summary>
        /// Updates an existing job definition. The previous job definition is completely overwritten
        /// by this information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob service method.</param>
        /// 
        /// <returns>The response from the UpdateJob service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        public virtual UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return Invoke<UpdateJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        public virtual IAsyncResult BeginUpdateJob(UpdateJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJob.</param>
        /// 
        /// <returns>Returns a  UpdateJobResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        public virtual UpdateJobResponse EndUpdateJob(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateJobResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateJobFromSourceControl

        /// <summary>
        /// Synchronizes a job from the source control repository. This operation takes the job
        /// artifacts that are located in the remote repository and updates the Glue internal
        /// stores with these artifacts.
        /// 
        ///  
        /// <para>
        /// This API supports optional parameters which take in the repository information.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobFromSourceControl service method.</param>
        /// 
        /// <returns>The response from the UpdateJobFromSourceControl service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ValidationException">
        /// A value could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateJobFromSourceControl">REST API Reference for UpdateJobFromSourceControl Operation</seealso>
        public virtual UpdateJobFromSourceControlResponse UpdateJobFromSourceControl(UpdateJobFromSourceControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobFromSourceControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobFromSourceControlResponseUnmarshaller.Instance;

            return Invoke<UpdateJobFromSourceControlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJobFromSourceControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobFromSourceControl operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJobFromSourceControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateJobFromSourceControl">REST API Reference for UpdateJobFromSourceControl Operation</seealso>
        public virtual IAsyncResult BeginUpdateJobFromSourceControl(UpdateJobFromSourceControlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobFromSourceControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobFromSourceControlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJobFromSourceControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJobFromSourceControl.</param>
        /// 
        /// <returns>Returns a  UpdateJobFromSourceControlResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateJobFromSourceControl">REST API Reference for UpdateJobFromSourceControl Operation</seealso>
        public virtual UpdateJobFromSourceControlResponse EndUpdateJobFromSourceControl(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateJobFromSourceControlResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMLTransform

        /// <summary>
        /// Updates an existing machine learning transform. Call this operation to tune the algorithm
        /// parameters to achieve better results.
        /// 
        ///  
        /// <para>
        /// After calling this operation, you can call the <code>StartMLEvaluationTaskRun</code>
        /// operation to assess how well your new parameters achieved your goals (such as improving
        /// the quality of your machine learning transform, or making it more cost-effective).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMLTransform service method.</param>
        /// 
        /// <returns>The response from the UpdateMLTransform service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateMLTransform">REST API Reference for UpdateMLTransform Operation</seealso>
        public virtual UpdateMLTransformResponse UpdateMLTransform(UpdateMLTransformRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMLTransformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMLTransformResponseUnmarshaller.Instance;

            return Invoke<UpdateMLTransformResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMLTransform operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMLTransform operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMLTransform
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateMLTransform">REST API Reference for UpdateMLTransform Operation</seealso>
        public virtual IAsyncResult BeginUpdateMLTransform(UpdateMLTransformRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMLTransformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMLTransformResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMLTransform operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMLTransform.</param>
        /// 
        /// <returns>Returns a  UpdateMLTransformResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateMLTransform">REST API Reference for UpdateMLTransform Operation</seealso>
        public virtual UpdateMLTransformResponse EndUpdateMLTransform(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMLTransformResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePartition

        /// <summary>
        /// Updates a partition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartition service method.</param>
        /// 
        /// <returns>The response from the UpdatePartition service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdatePartition">REST API Reference for UpdatePartition Operation</seealso>
        public virtual UpdatePartitionResponse UpdatePartition(UpdatePartitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartitionResponseUnmarshaller.Instance;

            return Invoke<UpdatePartitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePartition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartition operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePartition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdatePartition">REST API Reference for UpdatePartition Operation</seealso>
        public virtual IAsyncResult BeginUpdatePartition(UpdatePartitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePartitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePartition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePartition.</param>
        /// 
        /// <returns>Returns a  UpdatePartitionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdatePartition">REST API Reference for UpdatePartition Operation</seealso>
        public virtual UpdatePartitionResponse EndUpdatePartition(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePartitionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRegistry

        /// <summary>
        /// Updates an existing registry which is used to hold a collection of schemas. The updated
        /// properties relate to the registry, and do not modify any of the schemas within the
        /// registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistry service method.</param>
        /// 
        /// <returns>The response from the UpdateRegistry service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateRegistry">REST API Reference for UpdateRegistry Operation</seealso>
        public virtual UpdateRegistryResponse UpdateRegistry(UpdateRegistryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegistryResponseUnmarshaller.Instance;

            return Invoke<UpdateRegistryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRegistry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistry operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRegistry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateRegistry">REST API Reference for UpdateRegistry Operation</seealso>
        public virtual IAsyncResult BeginUpdateRegistry(UpdateRegistryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegistryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRegistry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRegistry.</param>
        /// 
        /// <returns>Returns a  UpdateRegistryResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateRegistry">REST API Reference for UpdateRegistry Operation</seealso>
        public virtual UpdateRegistryResponse EndUpdateRegistry(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRegistryResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSchema

        /// <summary>
        /// Updates the description, compatibility setting, or version checkpoint for a schema
        /// set.
        /// 
        ///  
        /// <para>
        /// For updating the compatibility setting, the call will not validate compatibility for
        /// the entire set of schema versions with the new compatibility setting. If the value
        /// for <code>Compatibility</code> is provided, the <code>VersionNumber</code> (a checkpoint)
        /// is also required. The API will validate the checkpoint version number for consistency.
        /// </para>
        ///  
        /// <para>
        /// If the value for the <code>VersionNumber</code> (checkpoint) is provided, <code>Compatibility</code>
        /// is optional and this can be used to set/reset a checkpoint for the schema.
        /// </para>
        ///  
        /// <para>
        /// This update will happen only if the schema is in the AVAILABLE state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchema service method.</param>
        /// 
        /// <returns>The response from the UpdateSchema service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        public virtual UpdateSchemaResponse UpdateSchema(UpdateSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return Invoke<UpdateSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchema operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        public virtual IAsyncResult BeginUpdateSchema(UpdateSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSchema.</param>
        /// 
        /// <returns>Returns a  UpdateSchemaResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        public virtual UpdateSchemaResponse EndUpdateSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSourceControlFromJob

        /// <summary>
        /// Synchronizes a job to the source control repository. This operation takes the job
        /// artifacts from the Glue internal stores and makes a commit to the remote repository
        /// that is configured on the job.
        /// 
        ///  
        /// <para>
        /// This API supports optional parameters which take in the repository information.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceControlFromJob service method.</param>
        /// 
        /// <returns>The response from the UpdateSourceControlFromJob service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.AccessDeniedException">
        /// Access to a resource was denied.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.AlreadyExistsException">
        /// A resource to be created or added already exists.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ValidationException">
        /// A value could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateSourceControlFromJob">REST API Reference for UpdateSourceControlFromJob Operation</seealso>
        public virtual UpdateSourceControlFromJobResponse UpdateSourceControlFromJob(UpdateSourceControlFromJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSourceControlFromJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSourceControlFromJobResponseUnmarshaller.Instance;

            return Invoke<UpdateSourceControlFromJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSourceControlFromJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceControlFromJob operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSourceControlFromJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateSourceControlFromJob">REST API Reference for UpdateSourceControlFromJob Operation</seealso>
        public virtual IAsyncResult BeginUpdateSourceControlFromJob(UpdateSourceControlFromJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSourceControlFromJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSourceControlFromJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSourceControlFromJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSourceControlFromJob.</param>
        /// 
        /// <returns>Returns a  UpdateSourceControlFromJobResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateSourceControlFromJob">REST API Reference for UpdateSourceControlFromJob Operation</seealso>
        public virtual UpdateSourceControlFromJobResponse EndUpdateSourceControlFromJob(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSourceControlFromJobResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTable

        /// <summary>
        /// Updates a metadata table in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable service method.</param>
        /// 
        /// <returns>The response from the UpdateTable service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNotReadyException">
        /// A resource was not ready for a transaction.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.ResourceNumberLimitExceededException">
        /// A resource numerical limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        public virtual UpdateTableResponse UpdateTable(UpdateTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableResponseUnmarshaller.Instance;

            return Invoke<UpdateTableResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        public virtual IAsyncResult BeginUpdateTable(UpdateTableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTable.</param>
        /// 
        /// <returns>Returns a  UpdateTableResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        public virtual UpdateTableResponse EndUpdateTable(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTableResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTrigger

        /// <summary>
        /// Updates a trigger definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrigger service method.</param>
        /// 
        /// <returns>The response from the UpdateTrigger service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTrigger">REST API Reference for UpdateTrigger Operation</seealso>
        public virtual UpdateTriggerResponse UpdateTrigger(UpdateTriggerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTriggerResponseUnmarshaller.Instance;

            return Invoke<UpdateTriggerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrigger operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrigger operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrigger
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTrigger">REST API Reference for UpdateTrigger Operation</seealso>
        public virtual IAsyncResult BeginUpdateTrigger(UpdateTriggerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTriggerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTriggerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrigger operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrigger.</param>
        /// 
        /// <returns>Returns a  UpdateTriggerResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateTrigger">REST API Reference for UpdateTrigger Operation</seealso>
        public virtual UpdateTriggerResponse EndUpdateTrigger(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTriggerResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUserDefinedFunction

        /// <summary>
        /// Updates an existing function definition in the Data Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserDefinedFunction service method.</param>
        /// 
        /// <returns>The response from the UpdateUserDefinedFunction service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.GlueEncryptionException">
        /// An encryption operation failed.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateUserDefinedFunction">REST API Reference for UpdateUserDefinedFunction Operation</seealso>
        public virtual UpdateUserDefinedFunctionResponse UpdateUserDefinedFunction(UpdateUserDefinedFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserDefinedFunctionResponseUnmarshaller.Instance;

            return Invoke<UpdateUserDefinedFunctionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserDefinedFunction operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserDefinedFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateUserDefinedFunction">REST API Reference for UpdateUserDefinedFunction Operation</seealso>
        public virtual IAsyncResult BeginUpdateUserDefinedFunction(UpdateUserDefinedFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserDefinedFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserDefinedFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserDefinedFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserDefinedFunction.</param>
        /// 
        /// <returns>Returns a  UpdateUserDefinedFunctionResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateUserDefinedFunction">REST API Reference for UpdateUserDefinedFunction Operation</seealso>
        public virtual UpdateUserDefinedFunctionResponse EndUpdateUserDefinedFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserDefinedFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWorkflow

        /// <summary>
        /// Updates an existing workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflow service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkflow service method, as returned by Glue.</returns>
        /// <exception cref="Amazon.Glue.Model.ConcurrentModificationException">
        /// Two processes are trying to modify a resource simultaneously.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.EntityNotFoundException">
        /// A specified entity does not exist
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InternalServiceException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.InvalidInputException">
        /// The input provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.Glue.Model.OperationTimeoutException">
        /// The operation timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateWorkflow">REST API Reference for UpdateWorkflow Operation</seealso>
        public virtual UpdateWorkflowResponse UpdateWorkflow(UpdateWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflow operation on AmazonGlueClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateWorkflow">REST API Reference for UpdateWorkflow Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorkflow(UpdateWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkflow.</param>
        /// 
        /// <returns>Returns a  UpdateWorkflowResult from Glue.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glue-2017-03-31/UpdateWorkflow">REST API Reference for UpdateWorkflow Operation</seealso>
        public virtual UpdateWorkflowResponse EndUpdateWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkflowResponse>(asyncResult);
        }

        #endregion
        
    }
}