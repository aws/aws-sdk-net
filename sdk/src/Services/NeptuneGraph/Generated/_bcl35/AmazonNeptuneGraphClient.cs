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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.NeptuneGraph.Model;
using Amazon.NeptuneGraph.Model.Internal.MarshallTransformations;
using Amazon.NeptuneGraph.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.NeptuneGraph
{
    /// <summary>
    /// <para>Implementation for accessing NeptuneGraph</para>
    ///
    /// Neptune Analytics is a new analytics database engine for Amazon Neptune that helps
    /// customers get to insights faster by quickly processing large amounts of graph data,
    /// invoking popular graph analytic algorithms in low-latency queries, and getting analytics
    /// results in seconds.
    /// </summary>
    public partial class AmazonNeptuneGraphClient : AmazonServiceClient, IAmazonNeptuneGraph
    {
        private static IServiceMetadata serviceMetadata = new AmazonNeptuneGraphMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private INeptuneGraphPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public INeptuneGraphPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new NeptuneGraphPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonNeptuneGraphClient with the credentials loaded from the application's
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
        public AmazonNeptuneGraphClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonNeptuneGraphConfig()) { }

        /// <summary>
        /// Constructs AmazonNeptuneGraphClient with the credentials loaded from the application's
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
        public AmazonNeptuneGraphClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonNeptuneGraphConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonNeptuneGraphClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonNeptuneGraphClient Configuration Object</param>
        public AmazonNeptuneGraphClient(AmazonNeptuneGraphConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonNeptuneGraphClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonNeptuneGraphClient(AWSCredentials credentials)
            : this(credentials, new AmazonNeptuneGraphConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneGraphClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNeptuneGraphClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonNeptuneGraphConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneGraphClient with AWS Credentials and an
        /// AmazonNeptuneGraphClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonNeptuneGraphClient Configuration Object</param>
        public AmazonNeptuneGraphClient(AWSCredentials credentials, AmazonNeptuneGraphConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneGraphClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonNeptuneGraphClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNeptuneGraphConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneGraphClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNeptuneGraphClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNeptuneGraphConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneGraphClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNeptuneGraphClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonNeptuneGraphClient Configuration Object</param>
        public AmazonNeptuneGraphClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonNeptuneGraphConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneGraphClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonNeptuneGraphClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNeptuneGraphConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneGraphClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNeptuneGraphClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNeptuneGraphConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneGraphClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNeptuneGraphClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonNeptuneGraphClient Configuration Object</param>
        public AmazonNeptuneGraphClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonNeptuneGraphConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNeptuneGraphEndpointResolver());
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


        #region  CancelExportTask

        /// <summary>
        /// Cancel the specified export task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask service method.</param>
        /// 
        /// <returns>The response from the CancelExportTask service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        public virtual CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelExportTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelExportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        public virtual IAsyncResult BeginCancelExportTask(CancelExportTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelExportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelExportTask.</param>
        /// 
        /// <returns>Returns a  CancelExportTaskResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        public virtual CancelExportTaskResponse EndCancelExportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelExportTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelImportTask

        /// <summary>
        /// Deletes the specified import task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelImportTask service method.</param>
        /// 
        /// <returns>The response from the CancelImportTask service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CancelImportTask">REST API Reference for CancelImportTask Operation</seealso>
        public virtual CancelImportTaskResponse CancelImportTask(CancelImportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelImportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelImportTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelImportTask operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelImportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CancelImportTask">REST API Reference for CancelImportTask Operation</seealso>
        public virtual IAsyncResult BeginCancelImportTask(CancelImportTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelImportTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelImportTask.</param>
        /// 
        /// <returns>Returns a  CancelImportTaskResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CancelImportTask">REST API Reference for CancelImportTask Operation</seealso>
        public virtual CancelImportTaskResponse EndCancelImportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelImportTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelQuery

        /// <summary>
        /// Cancels a specified query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelQuery service method.</param>
        /// 
        /// <returns>The response from the CancelQuery service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CancelQuery">REST API Reference for CancelQuery Operation</seealso>
        public virtual CancelQueryResponse CancelQuery(CancelQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelQueryResponseUnmarshaller.Instance;

            return Invoke<CancelQueryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelQuery operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CancelQuery">REST API Reference for CancelQuery Operation</seealso>
        public virtual IAsyncResult BeginCancelQuery(CancelQueryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelQueryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelQuery.</param>
        /// 
        /// <returns>Returns a  CancelQueryResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CancelQuery">REST API Reference for CancelQuery Operation</seealso>
        public virtual CancelQueryResponse EndCancelQuery(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelQueryResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGraph

        /// <summary>
        /// Creates a new Neptune Analytics graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGraph service method.</param>
        /// 
        /// <returns>The response from the CreateGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreateGraph">REST API Reference for CreateGraph Operation</seealso>
        public virtual CreateGraphResponse CreateGraph(CreateGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphResponseUnmarshaller.Instance;

            return Invoke<CreateGraphResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGraph operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGraph
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreateGraph">REST API Reference for CreateGraph Operation</seealso>
        public virtual IAsyncResult BeginCreateGraph(CreateGraphRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGraph operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGraph.</param>
        /// 
        /// <returns>Returns a  CreateGraphResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreateGraph">REST API Reference for CreateGraph Operation</seealso>
        public virtual CreateGraphResponse EndCreateGraph(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGraphResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGraphSnapshot

        /// <summary>
        /// Creates a snapshot of the specific graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGraphSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateGraphSnapshot service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreateGraphSnapshot">REST API Reference for CreateGraphSnapshot Operation</seealso>
        public virtual CreateGraphSnapshotResponse CreateGraphSnapshot(CreateGraphSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGraphSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateGraphSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGraphSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGraphSnapshot operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGraphSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreateGraphSnapshot">REST API Reference for CreateGraphSnapshot Operation</seealso>
        public virtual IAsyncResult BeginCreateGraphSnapshot(CreateGraphSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGraphSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGraphSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGraphSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateGraphSnapshotResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreateGraphSnapshot">REST API Reference for CreateGraphSnapshot Operation</seealso>
        public virtual CreateGraphSnapshotResponse EndCreateGraphSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGraphSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGraphUsingImportTask

        /// <summary>
        /// Creates a new Neptune Analytics graph and imports data into it, either from Amazon
        /// Simple Storage Service (S3) or from a Neptune database or a Neptune database snapshot.
        /// 
        ///  
        /// <para>
        /// The data can be loaded from files in S3 that in either the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format-gremlin.html">Gremlin
        /// CSV format</a> or the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format-opencypher.html">openCypher
        /// load format</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGraphUsingImportTask service method.</param>
        /// 
        /// <returns>The response from the CreateGraphUsingImportTask service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreateGraphUsingImportTask">REST API Reference for CreateGraphUsingImportTask Operation</seealso>
        public virtual CreateGraphUsingImportTaskResponse CreateGraphUsingImportTask(CreateGraphUsingImportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGraphUsingImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphUsingImportTaskResponseUnmarshaller.Instance;

            return Invoke<CreateGraphUsingImportTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGraphUsingImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGraphUsingImportTask operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGraphUsingImportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreateGraphUsingImportTask">REST API Reference for CreateGraphUsingImportTask Operation</seealso>
        public virtual IAsyncResult BeginCreateGraphUsingImportTask(CreateGraphUsingImportTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGraphUsingImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphUsingImportTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGraphUsingImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGraphUsingImportTask.</param>
        /// 
        /// <returns>Returns a  CreateGraphUsingImportTaskResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreateGraphUsingImportTask">REST API Reference for CreateGraphUsingImportTask Operation</seealso>
        public virtual CreateGraphUsingImportTaskResponse EndCreateGraphUsingImportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGraphUsingImportTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePrivateGraphEndpoint

        /// <summary>
        /// Create a private graph endpoint to allow private access from to the graph from within
        /// a VPC. You can attach security groups to the private graph endpoint.
        /// 
        ///  <note> 
        /// <para>
        /// VPC endpoint charges apply.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateGraphEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreatePrivateGraphEndpoint service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreatePrivateGraphEndpoint">REST API Reference for CreatePrivateGraphEndpoint Operation</seealso>
        public virtual CreatePrivateGraphEndpointResponse CreatePrivateGraphEndpoint(CreatePrivateGraphEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePrivateGraphEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrivateGraphEndpointResponseUnmarshaller.Instance;

            return Invoke<CreatePrivateGraphEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePrivateGraphEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateGraphEndpoint operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePrivateGraphEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreatePrivateGraphEndpoint">REST API Reference for CreatePrivateGraphEndpoint Operation</seealso>
        public virtual IAsyncResult BeginCreatePrivateGraphEndpoint(CreatePrivateGraphEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePrivateGraphEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrivateGraphEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePrivateGraphEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePrivateGraphEndpoint.</param>
        /// 
        /// <returns>Returns a  CreatePrivateGraphEndpointResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreatePrivateGraphEndpoint">REST API Reference for CreatePrivateGraphEndpoint Operation</seealso>
        public virtual CreatePrivateGraphEndpointResponse EndCreatePrivateGraphEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePrivateGraphEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGraph

        /// <summary>
        /// Deletes the specified graph. Graphs cannot be deleted if delete-protection is enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraph service method.</param>
        /// 
        /// <returns>The response from the DeleteGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/DeleteGraph">REST API Reference for DeleteGraph Operation</seealso>
        public virtual DeleteGraphResponse DeleteGraph(DeleteGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGraphResponseUnmarshaller.Instance;

            return Invoke<DeleteGraphResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraph operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGraph
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/DeleteGraph">REST API Reference for DeleteGraph Operation</seealso>
        public virtual IAsyncResult BeginDeleteGraph(DeleteGraphRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGraphResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGraph operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGraph.</param>
        /// 
        /// <returns>Returns a  DeleteGraphResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/DeleteGraph">REST API Reference for DeleteGraph Operation</seealso>
        public virtual DeleteGraphResponse EndDeleteGraph(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGraphResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGraphSnapshot

        /// <summary>
        /// Deletes the specifed graph snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraphSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteGraphSnapshot service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/DeleteGraphSnapshot">REST API Reference for DeleteGraphSnapshot Operation</seealso>
        public virtual DeleteGraphSnapshotResponse DeleteGraphSnapshot(DeleteGraphSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGraphSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGraphSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteGraphSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGraphSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraphSnapshot operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGraphSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/DeleteGraphSnapshot">REST API Reference for DeleteGraphSnapshot Operation</seealso>
        public virtual IAsyncResult BeginDeleteGraphSnapshot(DeleteGraphSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGraphSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGraphSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGraphSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGraphSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteGraphSnapshotResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/DeleteGraphSnapshot">REST API Reference for DeleteGraphSnapshot Operation</seealso>
        public virtual DeleteGraphSnapshotResponse EndDeleteGraphSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGraphSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePrivateGraphEndpoint

        /// <summary>
        /// Deletes a private graph endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrivateGraphEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeletePrivateGraphEndpoint service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/DeletePrivateGraphEndpoint">REST API Reference for DeletePrivateGraphEndpoint Operation</seealso>
        public virtual DeletePrivateGraphEndpointResponse DeletePrivateGraphEndpoint(DeletePrivateGraphEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePrivateGraphEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrivateGraphEndpointResponseUnmarshaller.Instance;

            return Invoke<DeletePrivateGraphEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePrivateGraphEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePrivateGraphEndpoint operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePrivateGraphEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/DeletePrivateGraphEndpoint">REST API Reference for DeletePrivateGraphEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDeletePrivateGraphEndpoint(DeletePrivateGraphEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePrivateGraphEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrivateGraphEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePrivateGraphEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePrivateGraphEndpoint.</param>
        /// 
        /// <returns>Returns a  DeletePrivateGraphEndpointResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/DeletePrivateGraphEndpoint">REST API Reference for DeletePrivateGraphEndpoint Operation</seealso>
        public virtual DeletePrivateGraphEndpointResponse EndDeletePrivateGraphEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePrivateGraphEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  ExecuteQuery

        /// <summary>
        /// Execute an openCypher query.
        /// 
        ///  
        /// <para>
        ///  When invoking this operation in a Neptune Analytics cluster, the IAM user or role
        /// making the request must have a policy attached that allows one of the following IAM
        /// actions in that cluster, depending on the query: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// neptune-graph:ReadDataViaQuery
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// neptune-graph:WriteDataViaQuery
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// neptune-graph:DeleteDataViaQuery
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteQuery service method.</param>
        /// 
        /// <returns>The response from the ExecuteQuery service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.UnprocessableException">
        /// Request cannot be processed due to known reasons. Eg. partition full.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        public virtual ExecuteQueryResponse ExecuteQuery(ExecuteQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteQueryResponseUnmarshaller.Instance;

            return Invoke<ExecuteQueryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteQuery operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        public virtual IAsyncResult BeginExecuteQuery(ExecuteQueryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteQueryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteQuery.</param>
        /// 
        /// <returns>Returns a  ExecuteQueryResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        public virtual ExecuteQueryResponse EndExecuteQuery(IAsyncResult asyncResult)
        {
            return EndInvoke<ExecuteQueryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetExportTask

        /// <summary>
        /// Retrieves a specified export task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExportTask service method.</param>
        /// 
        /// <returns>The response from the GetExportTask service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetExportTask">REST API Reference for GetExportTask Operation</seealso>
        public virtual GetExportTaskResponse GetExportTask(GetExportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportTaskResponseUnmarshaller.Instance;

            return Invoke<GetExportTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExportTask operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetExportTask">REST API Reference for GetExportTask Operation</seealso>
        public virtual IAsyncResult BeginGetExportTask(GetExportTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExportTask.</param>
        /// 
        /// <returns>Returns a  GetExportTaskResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetExportTask">REST API Reference for GetExportTask Operation</seealso>
        public virtual GetExportTaskResponse EndGetExportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExportTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGraph

        /// <summary>
        /// Gets information about a specified graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGraph service method.</param>
        /// 
        /// <returns>The response from the GetGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetGraph">REST API Reference for GetGraph Operation</seealso>
        public virtual GetGraphResponse GetGraph(GetGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphResponseUnmarshaller.Instance;

            return Invoke<GetGraphResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGraph operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGraph
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetGraph">REST API Reference for GetGraph Operation</seealso>
        public virtual IAsyncResult BeginGetGraph(GetGraphRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGraph operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGraph.</param>
        /// 
        /// <returns>Returns a  GetGraphResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetGraph">REST API Reference for GetGraph Operation</seealso>
        public virtual GetGraphResponse EndGetGraph(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGraphResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGraphSnapshot

        /// <summary>
        /// Retrieves a specified graph snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGraphSnapshot service method.</param>
        /// 
        /// <returns>The response from the GetGraphSnapshot service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetGraphSnapshot">REST API Reference for GetGraphSnapshot Operation</seealso>
        public virtual GetGraphSnapshotResponse GetGraphSnapshot(GetGraphSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetGraphSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGraphSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGraphSnapshot operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGraphSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetGraphSnapshot">REST API Reference for GetGraphSnapshot Operation</seealso>
        public virtual IAsyncResult BeginGetGraphSnapshot(GetGraphSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGraphSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGraphSnapshot.</param>
        /// 
        /// <returns>Returns a  GetGraphSnapshotResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetGraphSnapshot">REST API Reference for GetGraphSnapshot Operation</seealso>
        public virtual GetGraphSnapshotResponse EndGetGraphSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGraphSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGraphSummary

        /// <summary>
        /// Gets a graph summary for a property graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGraphSummary service method.</param>
        /// 
        /// <returns>The response from the GetGraphSummary service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetGraphSummary">REST API Reference for GetGraphSummary Operation</seealso>
        public virtual GetGraphSummaryResponse GetGraphSummary(GetGraphSummaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphSummaryResponseUnmarshaller.Instance;

            return Invoke<GetGraphSummaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGraphSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGraphSummary operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGraphSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetGraphSummary">REST API Reference for GetGraphSummary Operation</seealso>
        public virtual IAsyncResult BeginGetGraphSummary(GetGraphSummaryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphSummaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGraphSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGraphSummary.</param>
        /// 
        /// <returns>Returns a  GetGraphSummaryResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetGraphSummary">REST API Reference for GetGraphSummary Operation</seealso>
        public virtual GetGraphSummaryResponse EndGetGraphSummary(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGraphSummaryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetImportTask

        /// <summary>
        /// Retrieves a specified import task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportTask service method.</param>
        /// 
        /// <returns>The response from the GetImportTask service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetImportTask">REST API Reference for GetImportTask Operation</seealso>
        public virtual GetImportTaskResponse GetImportTask(GetImportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportTaskResponseUnmarshaller.Instance;

            return Invoke<GetImportTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportTask operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetImportTask">REST API Reference for GetImportTask Operation</seealso>
        public virtual IAsyncResult BeginGetImportTask(GetImportTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImportTask.</param>
        /// 
        /// <returns>Returns a  GetImportTaskResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetImportTask">REST API Reference for GetImportTask Operation</seealso>
        public virtual GetImportTaskResponse EndGetImportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetImportTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPrivateGraphEndpoint

        /// <summary>
        /// Retrieves information about a specified private endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPrivateGraphEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetPrivateGraphEndpoint service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetPrivateGraphEndpoint">REST API Reference for GetPrivateGraphEndpoint Operation</seealso>
        public virtual GetPrivateGraphEndpointResponse GetPrivateGraphEndpoint(GetPrivateGraphEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPrivateGraphEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPrivateGraphEndpointResponseUnmarshaller.Instance;

            return Invoke<GetPrivateGraphEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPrivateGraphEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPrivateGraphEndpoint operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPrivateGraphEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetPrivateGraphEndpoint">REST API Reference for GetPrivateGraphEndpoint Operation</seealso>
        public virtual IAsyncResult BeginGetPrivateGraphEndpoint(GetPrivateGraphEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPrivateGraphEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPrivateGraphEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPrivateGraphEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPrivateGraphEndpoint.</param>
        /// 
        /// <returns>Returns a  GetPrivateGraphEndpointResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetPrivateGraphEndpoint">REST API Reference for GetPrivateGraphEndpoint Operation</seealso>
        public virtual GetPrivateGraphEndpointResponse EndGetPrivateGraphEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPrivateGraphEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  GetQuery

        /// <summary>
        /// Retrieves the status of a specified query.
        /// 
        ///  <note> 
        /// <para>
        ///  When invoking this operation in a Neptune Analytics cluster, the IAM user or role
        /// making the request must have the <c>neptune-graph:GetQueryStatus</c> IAM action attached.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQuery service method.</param>
        /// 
        /// <returns>The response from the GetQuery service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetQuery">REST API Reference for GetQuery Operation</seealso>
        public virtual GetQueryResponse GetQuery(GetQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResponseUnmarshaller.Instance;

            return Invoke<GetQueryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQuery operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetQuery">REST API Reference for GetQuery Operation</seealso>
        public virtual IAsyncResult BeginGetQuery(GetQueryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQuery.</param>
        /// 
        /// <returns>Returns a  GetQueryResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetQuery">REST API Reference for GetQuery Operation</seealso>
        public virtual GetQueryResponse EndGetQuery(IAsyncResult asyncResult)
        {
            return EndInvoke<GetQueryResponse>(asyncResult);
        }

        #endregion
        
        #region  ListExportTasks

        /// <summary>
        /// Retrieves a list of export tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExportTasks service method.</param>
        /// 
        /// <returns>The response from the ListExportTasks service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListExportTasks">REST API Reference for ListExportTasks Operation</seealso>
        public virtual ListExportTasksResponse ListExportTasks(ListExportTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportTasksResponseUnmarshaller.Instance;

            return Invoke<ListExportTasksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListExportTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExportTasks operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExportTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListExportTasks">REST API Reference for ListExportTasks Operation</seealso>
        public virtual IAsyncResult BeginListExportTasks(ListExportTasksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportTasksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExportTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExportTasks.</param>
        /// 
        /// <returns>Returns a  ListExportTasksResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListExportTasks">REST API Reference for ListExportTasks Operation</seealso>
        public virtual ListExportTasksResponse EndListExportTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExportTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGraphs

        /// <summary>
        /// Lists available Neptune Analytics graphs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGraphs service method.</param>
        /// 
        /// <returns>The response from the ListGraphs service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListGraphs">REST API Reference for ListGraphs Operation</seealso>
        public virtual ListGraphsResponse ListGraphs(ListGraphsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGraphsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGraphsResponseUnmarshaller.Instance;

            return Invoke<ListGraphsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGraphs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGraphs operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGraphs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListGraphs">REST API Reference for ListGraphs Operation</seealso>
        public virtual IAsyncResult BeginListGraphs(ListGraphsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGraphsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGraphsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGraphs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGraphs.</param>
        /// 
        /// <returns>Returns a  ListGraphsResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListGraphs">REST API Reference for ListGraphs Operation</seealso>
        public virtual ListGraphsResponse EndListGraphs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGraphsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGraphSnapshots

        /// <summary>
        /// Lists available snapshots of a specified Neptune Analytics graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGraphSnapshots service method.</param>
        /// 
        /// <returns>The response from the ListGraphSnapshots service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListGraphSnapshots">REST API Reference for ListGraphSnapshots Operation</seealso>
        public virtual ListGraphSnapshotsResponse ListGraphSnapshots(ListGraphSnapshotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGraphSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGraphSnapshotsResponseUnmarshaller.Instance;

            return Invoke<ListGraphSnapshotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGraphSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGraphSnapshots operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGraphSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListGraphSnapshots">REST API Reference for ListGraphSnapshots Operation</seealso>
        public virtual IAsyncResult BeginListGraphSnapshots(ListGraphSnapshotsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGraphSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGraphSnapshotsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGraphSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGraphSnapshots.</param>
        /// 
        /// <returns>Returns a  ListGraphSnapshotsResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListGraphSnapshots">REST API Reference for ListGraphSnapshots Operation</seealso>
        public virtual ListGraphSnapshotsResponse EndListGraphSnapshots(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGraphSnapshotsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListImportTasks

        /// <summary>
        /// Lists import tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportTasks service method.</param>
        /// 
        /// <returns>The response from the ListImportTasks service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListImportTasks">REST API Reference for ListImportTasks Operation</seealso>
        public virtual ListImportTasksResponse ListImportTasks(ListImportTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportTasksResponseUnmarshaller.Instance;

            return Invoke<ListImportTasksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListImportTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImportTasks operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImportTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListImportTasks">REST API Reference for ListImportTasks Operation</seealso>
        public virtual IAsyncResult BeginListImportTasks(ListImportTasksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportTasksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListImportTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImportTasks.</param>
        /// 
        /// <returns>Returns a  ListImportTasksResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListImportTasks">REST API Reference for ListImportTasks Operation</seealso>
        public virtual ListImportTasksResponse EndListImportTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListImportTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPrivateGraphEndpoints

        /// <summary>
        /// Lists private endpoints for a specified Neptune Analytics graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrivateGraphEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListPrivateGraphEndpoints service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListPrivateGraphEndpoints">REST API Reference for ListPrivateGraphEndpoints Operation</seealso>
        public virtual ListPrivateGraphEndpointsResponse ListPrivateGraphEndpoints(ListPrivateGraphEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPrivateGraphEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrivateGraphEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListPrivateGraphEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPrivateGraphEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrivateGraphEndpoints operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPrivateGraphEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListPrivateGraphEndpoints">REST API Reference for ListPrivateGraphEndpoints Operation</seealso>
        public virtual IAsyncResult BeginListPrivateGraphEndpoints(ListPrivateGraphEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPrivateGraphEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrivateGraphEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPrivateGraphEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPrivateGraphEndpoints.</param>
        /// 
        /// <returns>Returns a  ListPrivateGraphEndpointsResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListPrivateGraphEndpoints">REST API Reference for ListPrivateGraphEndpoints Operation</seealso>
        public virtual ListPrivateGraphEndpointsResponse EndListPrivateGraphEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPrivateGraphEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListQueries

        /// <summary>
        /// Lists active openCypher queries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueries service method.</param>
        /// 
        /// <returns>The response from the ListQueries service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListQueries">REST API Reference for ListQueries Operation</seealso>
        public virtual ListQueriesResponse ListQueries(ListQueriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueriesResponseUnmarshaller.Instance;

            return Invoke<ListQueriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListQueries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueries operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQueries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListQueries">REST API Reference for ListQueries Operation</seealso>
        public virtual IAsyncResult BeginListQueries(ListQueriesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListQueries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQueries.</param>
        /// 
        /// <returns>Returns a  ListQueriesResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListQueries">REST API Reference for ListQueries Operation</seealso>
        public virtual ListQueriesResponse EndListQueries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListQueriesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists tags associated with a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ResetGraph

        /// <summary>
        /// Empties the data from a specified Neptune Analytics graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetGraph service method.</param>
        /// 
        /// <returns>The response from the ResetGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ResetGraph">REST API Reference for ResetGraph Operation</seealso>
        public virtual ResetGraphResponse ResetGraph(ResetGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetGraphResponseUnmarshaller.Instance;

            return Invoke<ResetGraphResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetGraph operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetGraph
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ResetGraph">REST API Reference for ResetGraph Operation</seealso>
        public virtual IAsyncResult BeginResetGraph(ResetGraphRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetGraphResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetGraph operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetGraph.</param>
        /// 
        /// <returns>Returns a  ResetGraphResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ResetGraph">REST API Reference for ResetGraph Operation</seealso>
        public virtual ResetGraphResponse EndResetGraph(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetGraphResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreGraphFromSnapshot

        /// <summary>
        /// Restores a graph from a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreGraphFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreGraphFromSnapshot service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/RestoreGraphFromSnapshot">REST API Reference for RestoreGraphFromSnapshot Operation</seealso>
        public virtual RestoreGraphFromSnapshotResponse RestoreGraphFromSnapshot(RestoreGraphFromSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreGraphFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreGraphFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreGraphFromSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreGraphFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreGraphFromSnapshot operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreGraphFromSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/RestoreGraphFromSnapshot">REST API Reference for RestoreGraphFromSnapshot Operation</seealso>
        public virtual IAsyncResult BeginRestoreGraphFromSnapshot(RestoreGraphFromSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreGraphFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreGraphFromSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreGraphFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreGraphFromSnapshot.</param>
        /// 
        /// <returns>Returns a  RestoreGraphFromSnapshotResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/RestoreGraphFromSnapshot">REST API Reference for RestoreGraphFromSnapshot Operation</seealso>
        public virtual RestoreGraphFromSnapshotResponse EndRestoreGraphFromSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreGraphFromSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  StartExportTask

        /// <summary>
        /// Export data from an existing Neptune Analytics graph to Amazon S3. The graph state
        /// should be <c>AVAILABLE</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExportTask service method.</param>
        /// 
        /// <returns>The response from the StartExportTask service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/StartExportTask">REST API Reference for StartExportTask Operation</seealso>
        public virtual StartExportTaskResponse StartExportTask(StartExportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExportTaskResponseUnmarshaller.Instance;

            return Invoke<StartExportTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartExportTask operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartExportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/StartExportTask">REST API Reference for StartExportTask Operation</seealso>
        public virtual IAsyncResult BeginStartExportTask(StartExportTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExportTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartExportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartExportTask.</param>
        /// 
        /// <returns>Returns a  StartExportTaskResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/StartExportTask">REST API Reference for StartExportTask Operation</seealso>
        public virtual StartExportTaskResponse EndStartExportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StartExportTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  StartGraph

        /// <summary>
        /// Starts the specific graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartGraph service method.</param>
        /// 
        /// <returns>The response from the StartGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/StartGraph">REST API Reference for StartGraph Operation</seealso>
        public virtual StartGraphResponse StartGraph(StartGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGraphResponseUnmarshaller.Instance;

            return Invoke<StartGraphResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartGraph operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartGraph
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/StartGraph">REST API Reference for StartGraph Operation</seealso>
        public virtual IAsyncResult BeginStartGraph(StartGraphRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGraphResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartGraph operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartGraph.</param>
        /// 
        /// <returns>Returns a  StartGraphResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/StartGraph">REST API Reference for StartGraph Operation</seealso>
        public virtual StartGraphResponse EndStartGraph(IAsyncResult asyncResult)
        {
            return EndInvoke<StartGraphResponse>(asyncResult);
        }

        #endregion
        
        #region  StartImportTask

        /// <summary>
        /// Import data into existing Neptune Analytics graph from Amazon Simple Storage Service
        /// (S3). The graph needs to be empty and in the AVAILABLE state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImportTask service method.</param>
        /// 
        /// <returns>The response from the StartImportTask service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/StartImportTask">REST API Reference for StartImportTask Operation</seealso>
        public virtual StartImportTaskResponse StartImportTask(StartImportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportTaskResponseUnmarshaller.Instance;

            return Invoke<StartImportTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartImportTask operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartImportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/StartImportTask">REST API Reference for StartImportTask Operation</seealso>
        public virtual IAsyncResult BeginStartImportTask(StartImportTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartImportTask.</param>
        /// 
        /// <returns>Returns a  StartImportTaskResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/StartImportTask">REST API Reference for StartImportTask Operation</seealso>
        public virtual StartImportTaskResponse EndStartImportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StartImportTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  StopGraph

        /// <summary>
        /// Stops the specific graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopGraph service method.</param>
        /// 
        /// <returns>The response from the StopGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/StopGraph">REST API Reference for StopGraph Operation</seealso>
        public virtual StopGraphResponse StopGraph(StopGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopGraphResponseUnmarshaller.Instance;

            return Invoke<StopGraphResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopGraph operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopGraph
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/StopGraph">REST API Reference for StopGraph Operation</seealso>
        public virtual IAsyncResult BeginStopGraph(StopGraphRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopGraphResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopGraph operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopGraph.</param>
        /// 
        /// <returns>Returns a  StopGraphResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/StopGraph">REST API Reference for StopGraph Operation</seealso>
        public virtual StopGraphResponse EndStopGraph(IAsyncResult asyncResult)
        {
            return EndInvoke<StopGraphResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGraph

        /// <summary>
        /// Updates the configuration of a specified Neptune Analytics graph
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGraph service method.</param>
        /// 
        /// <returns>The response from the UpdateGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/UpdateGraph">REST API Reference for UpdateGraph Operation</seealso>
        public virtual UpdateGraphResponse UpdateGraph(UpdateGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGraphResponseUnmarshaller.Instance;

            return Invoke<UpdateGraphResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGraph operation on AmazonNeptuneGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGraph
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/UpdateGraph">REST API Reference for UpdateGraph Operation</seealso>
        public virtual IAsyncResult BeginUpdateGraph(UpdateGraphRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGraphResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGraph operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGraph.</param>
        /// 
        /// <returns>Returns a  UpdateGraphResult from NeptuneGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/UpdateGraph">REST API Reference for UpdateGraph Operation</seealso>
        public virtual UpdateGraphResponse EndUpdateGraph(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGraphResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonNeptuneGraphEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}