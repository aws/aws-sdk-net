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
 * Do not modify this file. This file is generated from the docdb-elastic-2022-11-28.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DocDBElastic.Model;
using Amazon.DocDBElastic.Model.Internal.MarshallTransformations;
using Amazon.DocDBElastic.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.DocDBElastic
{
    /// <summary>
    /// <para>Implementation for accessing DocDBElastic</para>
    ///
    /// Amazon DocumentDB elastic clusters 
    /// <para>
    /// Amazon DocumentDB elastic-clusters support workloads with millions of reads/writes
    /// per second and petabytes of storage capacity. Amazon DocumentDB elastic clusters also
    /// simplify how developers interact with Amazon DocumentDB elastic-clusters by eliminating
    /// the need to choose, manage or upgrade instances.
    /// 
    ///  
    /// <para>
    /// Amazon DocumentDB elastic-clusters were created to:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// provide a solution for customers looking for a database that provides virtually limitless
    /// scale with rich query capabilities and MongoDB API compatibility.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// give customers higher connection limits, and to reduce downtime from patching.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// continue investing in a cloud-native, elastic, and class leading architecture for
    /// JSON workloads.
    /// </para>
    ///  </li> </ul>
    /// </para>
    /// </summary>
    public partial class AmazonDocDBElasticClient : AmazonServiceClient, IAmazonDocDBElastic
    {
        private static IServiceMetadata serviceMetadata = new AmazonDocDBElasticMetadata();
        private IDocDBElasticPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDocDBElasticPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DocDBElasticPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with the credentials loaded from the application's
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
        public AmazonDocDBElasticClient()
            : base(new AmazonDocDBElasticConfig()) { }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with the credentials loaded from the application's
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
        public AmazonDocDBElasticClient(RegionEndpoint region)
            : base(new AmazonDocDBElasticConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDocDBElasticClient Configuration Object</param>
        public AmazonDocDBElasticClient(AmazonDocDBElasticConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDocDBElasticClient(AWSCredentials credentials)
            : this(credentials, new AmazonDocDBElasticConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDocDBElasticClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDocDBElasticConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with AWS Credentials and an
        /// AmazonDocDBElasticClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDocDBElasticClient Configuration Object</param>
        public AmazonDocDBElasticClient(AWSCredentials credentials, AmazonDocDBElasticConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDocDBElasticClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDocDBElasticConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDocDBElasticClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDocDBElasticConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDocDBElasticClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDocDBElasticClient Configuration Object</param>
        public AmazonDocDBElasticClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDocDBElasticConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDocDBElasticClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDocDBElasticConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDocDBElasticClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDocDBElasticConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDocDBElasticClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDocDBElasticClient Configuration Object</param>
        public AmazonDocDBElasticClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDocDBElasticConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDocDBElasticEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDocDBElasticAuthSchemeHandler());
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


        #region  ApplyPendingMaintenanceAction


        /// <summary>
        /// The type of pending maintenance action to be applied to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction service method.</param>
        /// 
        /// <returns>The response from the ApplyPendingMaintenanceAction service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        public virtual ApplyPendingMaintenanceActionResponse ApplyPendingMaintenanceAction(ApplyPendingMaintenanceActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApplyPendingMaintenanceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance;

            return Invoke<ApplyPendingMaintenanceActionResponse>(request, options);
        }


        /// <summary>
        /// The type of pending maintenance action to be applied to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ApplyPendingMaintenanceAction service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        public virtual Task<ApplyPendingMaintenanceActionResponse> ApplyPendingMaintenanceActionAsync(ApplyPendingMaintenanceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApplyPendingMaintenanceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ApplyPendingMaintenanceActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyClusterSnapshot


        /// <summary>
        /// Copies a snapshot of an elastic cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CopyClusterSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ServiceQuotaExceededException">
        /// The service quota for the action was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CopyClusterSnapshot">REST API Reference for CopyClusterSnapshot Operation</seealso>
        public virtual CopyClusterSnapshotResponse CopyClusterSnapshot(CopyClusterSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyClusterSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Copies a snapshot of an elastic cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyClusterSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ServiceQuotaExceededException">
        /// The service quota for the action was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CopyClusterSnapshot">REST API Reference for CopyClusterSnapshot Operation</seealso>
        public virtual Task<CopyClusterSnapshotResponse> CopyClusterSnapshotAsync(CopyClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyClusterSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<CopyClusterSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCluster


        /// <summary>
        /// Creates a new Amazon DocumentDB elastic cluster and returns its cluster structure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ServiceQuotaExceededException">
        /// The service quota for the action was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }


        /// <summary>
        /// Creates a new Amazon DocumentDB elastic cluster and returns its cluster structure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ServiceQuotaExceededException">
        /// The service quota for the action was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateClusterSnapshot


        /// <summary>
        /// Creates a snapshot of an elastic cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateClusterSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ServiceQuotaExceededException">
        /// The service quota for the action was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CreateClusterSnapshot">REST API Reference for CreateClusterSnapshot Operation</seealso>
        public virtual CreateClusterSnapshotResponse CreateClusterSnapshot(CreateClusterSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateClusterSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Creates a snapshot of an elastic cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateClusterSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ServiceQuotaExceededException">
        /// The service quota for the action was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CreateClusterSnapshot">REST API Reference for CreateClusterSnapshot Operation</seealso>
        public virtual Task<CreateClusterSnapshotResponse> CreateClusterSnapshotAsync(CreateClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateClusterSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCluster


        /// <summary>
        /// Delete an elastic cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }


        /// <summary>
        /// Delete an elastic cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteClusterSnapshot


        /// <summary>
        /// Delete an elastic cluster snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/DeleteClusterSnapshot">REST API Reference for DeleteClusterSnapshot Operation</seealso>
        public virtual DeleteClusterSnapshotResponse DeleteClusterSnapshot(DeleteClusterSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Delete an elastic cluster snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteClusterSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/DeleteClusterSnapshot">REST API Reference for DeleteClusterSnapshot Operation</seealso>
        public virtual Task<DeleteClusterSnapshotResponse> DeleteClusterSnapshotAsync(DeleteClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteClusterSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCluster


        /// <summary>
        /// Returns information about a specific elastic cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCluster service method.</param>
        /// 
        /// <returns>The response from the GetCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetCluster">REST API Reference for GetCluster Operation</seealso>
        public virtual GetClusterResponse GetCluster(GetClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterResponseUnmarshaller.Instance;

            return Invoke<GetClusterResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a specific elastic cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetCluster">REST API Reference for GetCluster Operation</seealso>
        public virtual Task<GetClusterResponse> GetClusterAsync(GetClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetClusterSnapshot


        /// <summary>
        /// Returns information about a specific elastic cluster snapshot
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the GetClusterSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetClusterSnapshot">REST API Reference for GetClusterSnapshot Operation</seealso>
        public virtual GetClusterSnapshotResponse GetClusterSnapshot(GetClusterSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetClusterSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a specific elastic cluster snapshot
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetClusterSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetClusterSnapshot">REST API Reference for GetClusterSnapshot Operation</seealso>
        public virtual Task<GetClusterSnapshotResponse> GetClusterSnapshotAsync(GetClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetClusterSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPendingMaintenanceAction


        /// <summary>
        /// Retrieves all maintenance actions that are pending.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPendingMaintenanceAction service method.</param>
        /// 
        /// <returns>The response from the GetPendingMaintenanceAction service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetPendingMaintenanceAction">REST API Reference for GetPendingMaintenanceAction Operation</seealso>
        public virtual GetPendingMaintenanceActionResponse GetPendingMaintenanceAction(GetPendingMaintenanceActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPendingMaintenanceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPendingMaintenanceActionResponseUnmarshaller.Instance;

            return Invoke<GetPendingMaintenanceActionResponse>(request, options);
        }


        /// <summary>
        /// Retrieves all maintenance actions that are pending.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPendingMaintenanceAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPendingMaintenanceAction service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetPendingMaintenanceAction">REST API Reference for GetPendingMaintenanceAction Operation</seealso>
        public virtual Task<GetPendingMaintenanceActionResponse> GetPendingMaintenanceActionAsync(GetPendingMaintenanceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPendingMaintenanceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPendingMaintenanceActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPendingMaintenanceActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListClusters


        /// <summary>
        /// Returns information about provisioned Amazon DocumentDB elastic clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersResponse>(request, options);
        }


        /// <summary>
        /// Returns information about provisioned Amazon DocumentDB elastic clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListClusterSnapshots


        /// <summary>
        /// Returns information about snapshots for a specified elastic cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusterSnapshots service method.</param>
        /// 
        /// <returns>The response from the ListClusterSnapshots service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListClusterSnapshots">REST API Reference for ListClusterSnapshots Operation</seealso>
        public virtual ListClusterSnapshotsResponse ListClusterSnapshots(ListClusterSnapshotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<ListClusterSnapshotsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about snapshots for a specified elastic cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusterSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusterSnapshots service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListClusterSnapshots">REST API Reference for ListClusterSnapshots Operation</seealso>
        public virtual Task<ListClusterSnapshotsResponse> ListClusterSnapshotsAsync(ListClusterSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClusterSnapshotsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListClusterSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPendingMaintenanceActions


        /// <summary>
        /// Retrieves a list of all maintenance actions that are pending.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPendingMaintenanceActions service method.</param>
        /// 
        /// <returns>The response from the ListPendingMaintenanceActions service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListPendingMaintenanceActions">REST API Reference for ListPendingMaintenanceActions Operation</seealso>
        public virtual ListPendingMaintenanceActionsResponse ListPendingMaintenanceActions(ListPendingMaintenanceActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPendingMaintenanceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPendingMaintenanceActionsResponseUnmarshaller.Instance;

            return Invoke<ListPendingMaintenanceActionsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of all maintenance actions that are pending.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPendingMaintenanceActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPendingMaintenanceActions service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListPendingMaintenanceActions">REST API Reference for ListPendingMaintenanceActions Operation</seealso>
        public virtual Task<ListPendingMaintenanceActionsResponse> ListPendingMaintenanceActionsAsync(ListPendingMaintenanceActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPendingMaintenanceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPendingMaintenanceActionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPendingMaintenanceActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags on a elastic cluster resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists all tags on a elastic cluster resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreClusterFromSnapshot


        /// <summary>
        /// Restores an elastic cluster from a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreClusterFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreClusterFromSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ServiceQuotaExceededException">
        /// The service quota for the action was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/RestoreClusterFromSnapshot">REST API Reference for RestoreClusterFromSnapshot Operation</seealso>
        public virtual RestoreClusterFromSnapshotResponse RestoreClusterFromSnapshot(RestoreClusterFromSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreClusterFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreClusterFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreClusterFromSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Restores an elastic cluster from a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreClusterFromSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreClusterFromSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ServiceQuotaExceededException">
        /// The service quota for the action was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/RestoreClusterFromSnapshot">REST API Reference for RestoreClusterFromSnapshot Operation</seealso>
        public virtual Task<RestoreClusterFromSnapshotResponse> RestoreClusterFromSnapshotAsync(RestoreClusterFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreClusterFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreClusterFromSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<RestoreClusterFromSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartCluster


        /// <summary>
        /// Restarts the stopped elastic cluster that is specified by <c>clusterARN</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCluster service method.</param>
        /// 
        /// <returns>The response from the StartCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/StartCluster">REST API Reference for StartCluster Operation</seealso>
        public virtual StartClusterResponse StartCluster(StartClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartClusterResponseUnmarshaller.Instance;

            return Invoke<StartClusterResponse>(request, options);
        }


        /// <summary>
        /// Restarts the stopped elastic cluster that is specified by <c>clusterARN</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/StartCluster">REST API Reference for StartCluster Operation</seealso>
        public virtual Task<StartClusterResponse> StartClusterAsync(StartClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopCluster


        /// <summary>
        /// Stops the running elastic cluster that is specified by <c>clusterArn</c>. The elastic
        /// cluster must be in the <i>available</i> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCluster service method.</param>
        /// 
        /// <returns>The response from the StopCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/StopCluster">REST API Reference for StopCluster Operation</seealso>
        public virtual StopClusterResponse StopCluster(StopClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopClusterResponseUnmarshaller.Instance;

            return Invoke<StopClusterResponse>(request, options);
        }


        /// <summary>
        /// Stops the running elastic cluster that is specified by <c>clusterArn</c>. The elastic
        /// cluster must be in the <i>available</i> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/StopCluster">REST API Reference for StopCluster Operation</seealso>
        public virtual Task<StopClusterResponse> StopClusterAsync(StopClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds metadata tags to an elastic cluster resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds metadata tags to an elastic cluster resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes metadata tags from an elastic cluster resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes metadata tags from an elastic cluster resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCluster


        /// <summary>
        /// Modifies an elastic cluster. This includes updating admin-username/password, upgrading
        /// the API version, and setting up a backup window and maintenance window
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// 
        /// <returns>The response from the UpdateCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        public virtual UpdateClusterResponse UpdateCluster(UpdateClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterResponse>(request, options);
        }


        /// <summary>
        /// Modifies an elastic cluster. This includes updating admin-username/password, upgrading
        /// the API version, and setting up a backup window and maintenance window
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        public virtual Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateClusterResponse>(request, options, cancellationToken);
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