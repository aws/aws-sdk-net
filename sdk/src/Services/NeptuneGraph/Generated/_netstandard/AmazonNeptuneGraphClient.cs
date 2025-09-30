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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.NeptuneGraph.Model;
using Amazon.NeptuneGraph.Model.Internal.MarshallTransformations;
using Amazon.NeptuneGraph.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

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
            : base(new AmazonNeptuneGraphConfig()) { }

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
            : base(new AmazonNeptuneGraphConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
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

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNeptuneGraphEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNeptuneGraphAuthSchemeHandler());
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

        internal virtual CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelExportTaskResponse>(request, options);
        }



        /// <summary>
        /// Cancel the specified export task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelExportTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelImportTask

        internal virtual CancelImportTaskResponse CancelImportTask(CancelImportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelImportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelImportTaskResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified import task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelImportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CancelImportTaskResponse> CancelImportTaskAsync(CancelImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelImportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelImportTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelQuery

        internal virtual CancelQueryResponse CancelQuery(CancelQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelQueryResponseUnmarshaller.Instance;

            return Invoke<CancelQueryResponse>(request, options);
        }



        /// <summary>
        /// Cancels a specified query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CancelQueryResponse> CancelQueryAsync(CancelQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelQueryResponseUnmarshaller.Instance;

            return InvokeAsync<CancelQueryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGraph

        internal virtual CreateGraphResponse CreateGraph(CreateGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphResponseUnmarshaller.Instance;

            return Invoke<CreateGraphResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Neptune Analytics graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateGraphResponse> CreateGraphAsync(CreateGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGraphResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGraphSnapshot

        internal virtual CreateGraphSnapshotResponse CreateGraphSnapshot(CreateGraphSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGraphSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateGraphSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot of the specific graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGraphSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateGraphSnapshotResponse> CreateGraphSnapshotAsync(CreateGraphSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGraphSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGraphSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGraphUsingImportTask

        internal virtual CreateGraphUsingImportTaskResponse CreateGraphUsingImportTask(CreateGraphUsingImportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGraphUsingImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphUsingImportTaskResponseUnmarshaller.Instance;

            return Invoke<CreateGraphUsingImportTaskResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateGraphUsingImportTaskResponse> CreateGraphUsingImportTaskAsync(CreateGraphUsingImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGraphUsingImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGraphUsingImportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGraphUsingImportTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePrivateGraphEndpoint

        internal virtual CreatePrivateGraphEndpointResponse CreatePrivateGraphEndpoint(CreatePrivateGraphEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePrivateGraphEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrivateGraphEndpointResponseUnmarshaller.Instance;

            return Invoke<CreatePrivateGraphEndpointResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreatePrivateGraphEndpointResponse> CreatePrivateGraphEndpointAsync(CreatePrivateGraphEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePrivateGraphEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrivateGraphEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePrivateGraphEndpointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteGraph

        internal virtual DeleteGraphResponse DeleteGraph(DeleteGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGraphResponseUnmarshaller.Instance;

            return Invoke<DeleteGraphResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified graph. Graphs cannot be deleted if delete-protection is enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteGraphResponse> DeleteGraphAsync(DeleteGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGraphResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGraphResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteGraphSnapshot

        internal virtual DeleteGraphSnapshotResponse DeleteGraphSnapshot(DeleteGraphSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGraphSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGraphSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteGraphSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specifed graph snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraphSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteGraphSnapshotResponse> DeleteGraphSnapshotAsync(DeleteGraphSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGraphSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGraphSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGraphSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePrivateGraphEndpoint

        internal virtual DeletePrivateGraphEndpointResponse DeletePrivateGraphEndpoint(DeletePrivateGraphEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePrivateGraphEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrivateGraphEndpointResponseUnmarshaller.Instance;

            return Invoke<DeletePrivateGraphEndpointResponse>(request, options);
        }



        /// <summary>
        /// Deletes a private graph endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrivateGraphEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeletePrivateGraphEndpointResponse> DeletePrivateGraphEndpointAsync(DeletePrivateGraphEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePrivateGraphEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrivateGraphEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePrivateGraphEndpointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExecuteQuery

        internal virtual ExecuteQueryResponse ExecuteQuery(ExecuteQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteQueryResponseUnmarshaller.Instance;

            return Invoke<ExecuteQueryResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ExecuteQueryResponse> ExecuteQueryAsync(ExecuteQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteQueryResponseUnmarshaller.Instance;

            return InvokeAsync<ExecuteQueryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetExportTask

        internal virtual GetExportTaskResponse GetExportTask(GetExportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportTaskResponseUnmarshaller.Instance;

            return Invoke<GetExportTaskResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a specified export task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetExportTaskResponse> GetExportTaskAsync(GetExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetExportTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetGraph

        internal virtual GetGraphResponse GetGraph(GetGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphResponseUnmarshaller.Instance;

            return Invoke<GetGraphResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a specified graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetGraphResponse> GetGraphAsync(GetGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphResponseUnmarshaller.Instance;

            return InvokeAsync<GetGraphResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetGraphSnapshot

        internal virtual GetGraphSnapshotResponse GetGraphSnapshot(GetGraphSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetGraphSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a specified graph snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGraphSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetGraphSnapshotResponse> GetGraphSnapshotAsync(GetGraphSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<GetGraphSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetGraphSummary

        internal virtual GetGraphSummaryResponse GetGraphSummary(GetGraphSummaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphSummaryResponseUnmarshaller.Instance;

            return Invoke<GetGraphSummaryResponse>(request, options);
        }



        /// <summary>
        /// Gets a graph summary for a property graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGraphSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetGraphSummaryResponse> GetGraphSummaryAsync(GetGraphSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGraphSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGraphSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<GetGraphSummaryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetImportTask

        internal virtual GetImportTaskResponse GetImportTask(GetImportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportTaskResponseUnmarshaller.Instance;

            return Invoke<GetImportTaskResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a specified import task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetImportTaskResponse> GetImportTaskAsync(GetImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetImportTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPrivateGraphEndpoint

        internal virtual GetPrivateGraphEndpointResponse GetPrivateGraphEndpoint(GetPrivateGraphEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPrivateGraphEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPrivateGraphEndpointResponseUnmarshaller.Instance;

            return Invoke<GetPrivateGraphEndpointResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a specified private endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPrivateGraphEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetPrivateGraphEndpointResponse> GetPrivateGraphEndpointAsync(GetPrivateGraphEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPrivateGraphEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPrivateGraphEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<GetPrivateGraphEndpointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetQuery

        internal virtual GetQueryResponse GetQuery(GetQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResponseUnmarshaller.Instance;

            return Invoke<GetQueryResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetQueryResponse> GetQueryAsync(GetQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListExportTasks

        internal virtual ListExportTasksResponse ListExportTasks(ListExportTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportTasksResponseUnmarshaller.Instance;

            return Invoke<ListExportTasksResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of export tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExportTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListExportTasksResponse> ListExportTasksAsync(ListExportTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListExportTasksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListGraphs

        internal virtual ListGraphsResponse ListGraphs(ListGraphsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGraphsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGraphsResponseUnmarshaller.Instance;

            return Invoke<ListGraphsResponse>(request, options);
        }



        /// <summary>
        /// Lists available Neptune Analytics graphs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGraphs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListGraphsResponse> ListGraphsAsync(ListGraphsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGraphsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGraphsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGraphsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListGraphSnapshots

        internal virtual ListGraphSnapshotsResponse ListGraphSnapshots(ListGraphSnapshotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGraphSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGraphSnapshotsResponseUnmarshaller.Instance;

            return Invoke<ListGraphSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Lists available snapshots of a specified Neptune Analytics graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGraphSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListGraphSnapshotsResponse> ListGraphSnapshotsAsync(ListGraphSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGraphSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGraphSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGraphSnapshotsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListImportTasks

        internal virtual ListImportTasksResponse ListImportTasks(ListImportTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportTasksResponseUnmarshaller.Instance;

            return Invoke<ListImportTasksResponse>(request, options);
        }



        /// <summary>
        /// Lists import tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListImportTasksResponse> ListImportTasksAsync(ListImportTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListImportTasksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPrivateGraphEndpoints

        internal virtual ListPrivateGraphEndpointsResponse ListPrivateGraphEndpoints(ListPrivateGraphEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPrivateGraphEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrivateGraphEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListPrivateGraphEndpointsResponse>(request, options);
        }



        /// <summary>
        /// Lists private endpoints for a specified Neptune Analytics graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrivateGraphEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListPrivateGraphEndpointsResponse> ListPrivateGraphEndpointsAsync(ListPrivateGraphEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPrivateGraphEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrivateGraphEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPrivateGraphEndpointsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListQueries

        internal virtual ListQueriesResponse ListQueries(ListQueriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueriesResponseUnmarshaller.Instance;

            return Invoke<ListQueriesResponse>(request, options);
        }



        /// <summary>
        /// Lists active openCypher queries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListQueriesResponse> ListQueriesAsync(ListQueriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListQueriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists tags associated with a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ResetGraph

        internal virtual ResetGraphResponse ResetGraph(ResetGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetGraphResponseUnmarshaller.Instance;

            return Invoke<ResetGraphResponse>(request, options);
        }



        /// <summary>
        /// Empties the data from a specified Neptune Analytics graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ResetGraphResponse> ResetGraphAsync(ResetGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetGraphResponseUnmarshaller.Instance;

            return InvokeAsync<ResetGraphResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RestoreGraphFromSnapshot

        internal virtual RestoreGraphFromSnapshotResponse RestoreGraphFromSnapshot(RestoreGraphFromSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreGraphFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreGraphFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreGraphFromSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Restores a graph from a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreGraphFromSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RestoreGraphFromSnapshotResponse> RestoreGraphFromSnapshotAsync(RestoreGraphFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreGraphFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreGraphFromSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreGraphFromSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartExportTask

        internal virtual StartExportTaskResponse StartExportTask(StartExportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExportTaskResponseUnmarshaller.Instance;

            return Invoke<StartExportTaskResponse>(request, options);
        }



        /// <summary>
        /// Export data from an existing Neptune Analytics graph to Amazon S3. The graph state
        /// should be <c>AVAILABLE</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartExportTaskResponse> StartExportTaskAsync(StartExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartExportTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartGraph

        internal virtual StartGraphResponse StartGraph(StartGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGraphResponseUnmarshaller.Instance;

            return Invoke<StartGraphResponse>(request, options);
        }



        /// <summary>
        /// Starts the specific graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartGraphResponse> StartGraphAsync(StartGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGraphResponseUnmarshaller.Instance;

            return InvokeAsync<StartGraphResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartImportTask

        internal virtual StartImportTaskResponse StartImportTask(StartImportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportTaskResponseUnmarshaller.Instance;

            return Invoke<StartImportTaskResponse>(request, options);
        }



        /// <summary>
        /// Import data into existing Neptune Analytics graph from Amazon Simple Storage Service
        /// (S3). The graph needs to be empty and in the AVAILABLE state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartImportTaskResponse> StartImportTaskAsync(StartImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartImportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartImportTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopGraph

        internal virtual StopGraphResponse StopGraph(StopGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopGraphResponseUnmarshaller.Instance;

            return Invoke<StopGraphResponse>(request, options);
        }



        /// <summary>
        /// Stops the specific graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StopGraphResponse> StopGraphAsync(StopGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopGraphResponseUnmarshaller.Instance;

            return InvokeAsync<StopGraphResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGraph

        internal virtual UpdateGraphResponse UpdateGraph(UpdateGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGraphResponseUnmarshaller.Instance;

            return Invoke<UpdateGraphResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of a specified Neptune Analytics graph
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateGraphResponse> UpdateGraphAsync(UpdateGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGraphResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGraphResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}