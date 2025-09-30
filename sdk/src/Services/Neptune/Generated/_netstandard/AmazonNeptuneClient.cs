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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Neptune.Model;
using Amazon.Neptune.Model.Internal.MarshallTransformations;
using Amazon.Neptune.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Neptune
{
    /// <summary>
    /// <para>Implementation for accessing Neptune</para>
    ///
    /// Amazon Neptune 
    /// <para>
    /// Amazon Neptune is a fast, reliable, fully-managed graph database service that makes
    /// it easy to build and run applications that work with highly connected datasets. The
    /// core of Amazon Neptune is a purpose-built, high-performance graph database engine
    /// optimized for storing billions of relationships and querying the graph with milliseconds
    /// latency. Amazon Neptune supports popular graph models Property Graph and W3C's RDF,
    /// and their respective query languages Apache TinkerPop Gremlin and SPARQL, allowing
    /// you to easily build queries that efficiently navigate highly connected datasets. Neptune
    /// powers graph use cases such as recommendation engines, fraud detection, knowledge
    /// graphs, drug discovery, and network security.
    /// </para>
    ///  
    /// <para>
    /// This interface reference for Amazon Neptune contains documentation for a programming
    /// or command line interface you can use to manage Amazon Neptune. Note that Amazon Neptune
    /// is asynchronous, which means that some interfaces might require techniques such as
    /// polling or callback functions to determine when a command has been applied. In this
    /// reference, the parameter descriptions indicate whether a command is applied immediately,
    /// on the next instance reboot, or during the maintenance window. The reference structure
    /// is as follows, and we list following some related topics from the user guide.
    /// </para>
    /// </summary>
    public partial class AmazonNeptuneClient : AmazonServiceClient, IAmazonNeptune
    {
        private static IServiceMetadata serviceMetadata = new AmazonNeptuneMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonNeptuneClient with the credentials loaded from the application's
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
        public AmazonNeptuneClient()
            : base(new AmazonNeptuneConfig()) { }

        /// <summary>
        /// Constructs AmazonNeptuneClient with the credentials loaded from the application's
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
        public AmazonNeptuneClient(RegionEndpoint region)
            : base(new AmazonNeptuneConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonNeptuneClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonNeptuneClient Configuration Object</param>
        public AmazonNeptuneClient(AmazonNeptuneConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonNeptuneClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonNeptuneClient(AWSCredentials credentials)
            : this(credentials, new AmazonNeptuneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNeptuneClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonNeptuneConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneClient with AWS Credentials and an
        /// AmazonNeptuneClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonNeptuneClient Configuration Object</param>
        public AmazonNeptuneClient(AWSCredentials credentials, AmazonNeptuneConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonNeptuneClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNeptuneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNeptuneClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNeptuneConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNeptuneClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonNeptuneClient Configuration Object</param>
        public AmazonNeptuneClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonNeptuneConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonNeptuneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNeptuneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNeptuneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNeptuneConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNeptuneClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonNeptuneClient Configuration Object</param>
        public AmazonNeptuneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonNeptuneConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private INeptunePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public INeptunePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new NeptunePaginatorFactory(this);
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
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.Neptune.Internal.PreSignedUrlRequestHandler(this.ExplicitAWSCredentials ?? this.Config.DefaultAWSCredentials));
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNeptuneEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNeptuneAuthSchemeHandler());
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


        #region  AddRoleToDBCluster

        internal virtual AddRoleToDBClusterResponse AddRoleToDBCluster(AddRoleToDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddRoleToDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRoleToDBClusterResponseUnmarshaller.Instance;

            return Invoke<AddRoleToDBClusterResponse>(request, options);
        }



        /// <summary>
        /// Associates an Identity and Access Management (IAM) role with an Neptune DB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddRoleToDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterRoleAlreadyExistsException">
        /// The specified IAM role Amazon Resource Name (ARN) is already associated with the specified
        /// DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterRoleQuotaExceededException">
        /// You have exceeded the maximum number of IAM roles that can be associated with the
        /// specified DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/AddRoleToDBCluster">REST API Reference for AddRoleToDBCluster Operation</seealso>
        public virtual Task<AddRoleToDBClusterResponse> AddRoleToDBClusterAsync(AddRoleToDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddRoleToDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRoleToDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<AddRoleToDBClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddSourceIdentifierToSubscription

        internal virtual AddSourceIdentifierToSubscriptionResponse AddSourceIdentifierToSubscription(AddSourceIdentifierToSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddSourceIdentifierToSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance;

            return Invoke<AddSourceIdentifierToSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Adds a source identifier to an existing event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddSourceIdentifierToSubscription service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.SourceNotFoundException">
        /// The source could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionNotFoundException">
        /// The designated subscription could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/AddSourceIdentifierToSubscription">REST API Reference for AddSourceIdentifierToSubscription Operation</seealso>
        public virtual Task<AddSourceIdentifierToSubscriptionResponse> AddSourceIdentifierToSubscriptionAsync(AddSourceIdentifierToSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddSourceIdentifierToSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<AddSourceIdentifierToSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddTagsToResource

        internal virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds metadata tags to an Amazon Neptune resource. These tags can also be used with
        /// cost allocation reporting to track cost associated with Amazon Neptune resources,
        /// or used in a Condition statement in an IAM policy for Amazon Neptune.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ApplyPendingMaintenanceAction

        internal virtual ApplyPendingMaintenanceActionResponse ApplyPendingMaintenanceAction(ApplyPendingMaintenanceActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApplyPendingMaintenanceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance;

            return Invoke<ApplyPendingMaintenanceActionResponse>(request, options);
        }



        /// <summary>
        /// Applies a pending maintenance action to a resource (for example, to a DB instance).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ApplyPendingMaintenanceAction service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        public virtual Task<ApplyPendingMaintenanceActionResponse> ApplyPendingMaintenanceActionAsync(ApplyPendingMaintenanceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApplyPendingMaintenanceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance;

            return InvokeAsync<ApplyPendingMaintenanceActionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CopyDBClusterParameterGroup

        internal virtual CopyDBClusterParameterGroupResponse CopyDBClusterParameterGroup(CopyDBClusterParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CopyDBClusterParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Copies the specified DB cluster parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyDBClusterParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB parameter groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CopyDBClusterParameterGroup">REST API Reference for CopyDBClusterParameterGroup Operation</seealso>
        public virtual Task<CopyDBClusterParameterGroupResponse> CopyDBClusterParameterGroupAsync(CopyDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CopyDBClusterParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CopyDBClusterSnapshot

        internal virtual CopyDBClusterSnapshotResponse CopyDBClusterSnapshot(CopyDBClusterSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyDBClusterSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Copies a snapshot of a DB cluster.
        /// 
        ///  
        /// <para>
        /// To copy a DB cluster snapshot from a shared manual DB cluster snapshot, <c>SourceDBClusterSnapshotIdentifier</c>
        /// must be the Amazon Resource Name (ARN) of the shared DB cluster snapshot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyDBClusterSnapshot service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotAlreadyExistsException">
        /// User already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CopyDBClusterSnapshot">REST API Reference for CopyDBClusterSnapshot Operation</seealso>
        public virtual Task<CopyDBClusterSnapshotResponse> CopyDBClusterSnapshotAsync(CopyDBClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopyDBClusterSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CopyDBParameterGroup

        internal virtual CopyDBParameterGroupResponse CopyDBParameterGroup(CopyDBParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CopyDBParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Copies the specified DB parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyDBParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB parameter groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CopyDBParameterGroup">REST API Reference for CopyDBParameterGroup Operation</seealso>
        public virtual Task<CopyDBParameterGroupResponse> CopyDBParameterGroupAsync(CopyDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CopyDBParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDBCluster

        internal virtual CreateDBClusterResponse CreateDBCluster(CreateDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Amazon Neptune DB cluster.
        /// 
        ///  
        /// <para>
        /// You can use the <c>ReplicationSourceIdentifier</c> parameter to create the DB cluster
        /// as a Read Replica of another DB cluster or Amazon Neptune DB instance.
        /// </para>
        ///  
        /// <para>
        /// Note that when you create a new cluster using <c>CreateDBCluster</c> directly, deletion
        /// protection is disabled by default (when you create a new production cluster in the
        /// console, deletion protection is enabled by default). You can only delete a DB cluster
        /// if its <c>DeletionProtection</c> field is set to <c>false</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterAlreadyExistsException">
        /// User already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterParameterGroupNotFoundException">
        /// <i>DBClusterParameterGroupName</i> does not refer to an existing DB Cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterQuotaExceededException">
        /// User attempted to create a new DB cluster and the user has already reached the maximum
        /// allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You may be able to
        /// resolve this error by updating your subnet group to use different Availability Zones
        /// that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBCluster">REST API Reference for CreateDBCluster Operation</seealso>
        public virtual Task<CreateDBClusterResponse> CreateDBClusterAsync(CreateDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDBClusterEndpoint

        internal virtual CreateDBClusterEndpointResponse CreateDBClusterEndpoint(CreateDBClusterEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterEndpointResponse>(request, options);
        }



        /// <summary>
        /// Creates a new custom endpoint and associates it with an Amazon Neptune DB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBClusterEndpoint service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterEndpointAlreadyExistsException">
        /// The specified custom endpoint cannot be created because it already exists.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterEndpointQuotaExceededException">
        /// The cluster already has the maximum number of custom endpoints.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBClusterEndpoint">REST API Reference for CreateDBClusterEndpoint Operation</seealso>
        public virtual Task<CreateDBClusterEndpointResponse> CreateDBClusterEndpointAsync(CreateDBClusterEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBClusterEndpointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDBClusterParameterGroup

        internal virtual CreateDBClusterParameterGroupResponse CreateDBClusterParameterGroup(CreateDBClusterParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new DB cluster parameter group.
        /// 
        ///  
        /// <para>
        /// Parameters in a DB cluster parameter group apply to all of the instances in a DB cluster.
        /// </para>
        ///  
        /// <para>
        ///  A DB cluster parameter group is initially created with the default parameters for
        /// the database engine used by instances in the DB cluster. To provide custom values
        /// for any of the parameters, you must modify the group after creating it using <a>ModifyDBClusterParameterGroup</a>.
        /// Once you've created a DB cluster parameter group, you need to associate it with your
        /// DB cluster using <a>ModifyDBCluster</a>. When you associate a new DB cluster parameter
        /// group with a running DB cluster, you need to reboot the DB instances in the DB cluster
        /// without failover for the new DB cluster parameter group and associated settings to
        /// take effect.
        /// </para>
        ///  <important> 
        /// <para>
        /// After you create a DB cluster parameter group, you should wait at least 5 minutes
        /// before creating your first DB cluster that uses that DB cluster parameter group as
        /// the default parameter group. This allows Amazon Neptune to fully complete the create
        /// action before the DB cluster parameter group is used as the default for a new DB cluster.
        /// This is especially important for parameters that are critical when creating the default
        /// database for a DB cluster, such as the character set for the default database defined
        /// by the <c>character_set_database</c> parameter. You can use the <i>Parameter Groups</i>
        /// option of the <a href="https://console.aws.amazon.com/rds/">Amazon Neptune console</a>
        /// or the <a>DescribeDBClusterParameters</a> command to verify that your DB cluster parameter
        /// group has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBClusterParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB parameter groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBClusterParameterGroup">REST API Reference for CreateDBClusterParameterGroup Operation</seealso>
        public virtual Task<CreateDBClusterParameterGroupResponse> CreateDBClusterParameterGroupAsync(CreateDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBClusterParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDBClusterSnapshot

        internal virtual CreateDBClusterSnapshotResponse CreateDBClusterSnapshot(CreateDBClusterSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot of a DB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBClusterSnapshot service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotAlreadyExistsException">
        /// User already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBClusterSnapshot">REST API Reference for CreateDBClusterSnapshot Operation</seealso>
        public virtual Task<CreateDBClusterSnapshotResponse> CreateDBClusterSnapshotAsync(CreateDBClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBClusterSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDBInstance

        internal virtual CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateDBInstanceResponse>(request, options);
        }



        /// <summary>
        /// Creates a new DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBInstance service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.AuthorizationNotFoundException">
        /// Specified CIDRIP or EC2 security group is not authorized for the specified DB security
        /// group.
        /// 
        ///  
        /// <para>
        /// Neptune may not also be authorized via IAM to perform necessary actions on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceAlreadyExistsException">
        /// User already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DomainNotFoundException">
        /// <i>Domain</i> does not refer to an existing Active Directory Domain.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InstanceQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientDBInstanceCapacityException">
        /// Specified DB instance class is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.OptionGroupNotFoundException">
        /// The designated option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageTypeNotSupportedException">
        /// <i>StorageType</i> specified cannot be associated with the DB Instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBInstance">REST API Reference for CreateDBInstance Operation</seealso>
        public virtual Task<CreateDBInstanceResponse> CreateDBInstanceAsync(CreateDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBInstanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDBParameterGroup

        internal virtual CreateDBParameterGroupResponse CreateDBParameterGroup(CreateDBParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new DB parameter group.
        /// 
        ///  
        /// <para>
        /// A DB parameter group is initially created with the default parameters for the database
        /// engine used by the DB instance. To provide custom values for any of the parameters,
        /// you must modify the group after creating it using <i>ModifyDBParameterGroup</i>. Once
        /// you've created a DB parameter group, you need to associate it with your DB instance
        /// using <i>ModifyDBInstance</i>. When you associate a new DB parameter group with a
        /// running DB instance, you need to reboot the DB instance without failover for the new
        /// DB parameter group and associated settings to take effect.
        /// </para>
        ///  <important> 
        /// <para>
        /// After you create a DB parameter group, you should wait at least 5 minutes before creating
        /// your first DB instance that uses that DB parameter group as the default parameter
        /// group. This allows Amazon Neptune to fully complete the create action before the parameter
        /// group is used as the default for a new DB instance. This is especially important for
        /// parameters that are critical when creating the default database for a DB instance,
        /// such as the character set for the default database defined by the <c>character_set_database</c>
        /// parameter. You can use the <i>Parameter Groups</i> option of the Amazon Neptune console
        /// or the <i>DescribeDBParameters</i> command to verify that your DB parameter group
        /// has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB parameter groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBParameterGroup">REST API Reference for CreateDBParameterGroup Operation</seealso>
        public virtual Task<CreateDBParameterGroupResponse> CreateDBParameterGroupAsync(CreateDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDBSubnetGroup

        internal virtual CreateDBSubnetGroupResponse CreateDBSubnetGroup(CreateDBSubnetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBSubnetGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new DB subnet group. DB subnet groups must contain at least one subnet in
        /// at least two AZs in the Amazon Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBSubnetGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupAlreadyExistsException">
        /// <i>DBSubnetGroupName</i> is already used by an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB subnet groups.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetQuotaExceededException">
        /// Request would result in user exceeding the allowed number of subnets in a DB subnet
        /// groups.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBSubnetGroup">REST API Reference for CreateDBSubnetGroup Operation</seealso>
        public virtual Task<CreateDBSubnetGroupResponse> CreateDBSubnetGroupAsync(CreateDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBSubnetGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEventSubscription

        internal virtual CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateEventSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Creates an event notification subscription. This action requires a topic ARN (Amazon
        /// Resource Name) created by either the Neptune console, the SNS console, or the SNS
        /// API. To obtain an ARN with SNS, you must create a topic in Amazon SNS and subscribe
        /// to the topic. The ARN is displayed in the SNS console.
        /// 
        ///  
        /// <para>
        /// You can specify the type of source (SourceType) you want to be notified of, provide
        /// a list of Neptune sources (SourceIds) that triggers the events, and provide a list
        /// of event categories (EventCategories) for events you want to be notified of. For example,
        /// you can specify SourceType = db-instance, SourceIds = mydbinstance1, mydbinstance2
        /// and EventCategories = Availability, Backup.
        /// </para>
        ///  
        /// <para>
        /// If you specify both the SourceType and SourceIds, such as SourceType = db-instance
        /// and SourceIdentifier = myDBInstance1, you are notified of all the db-instance events
        /// for the specified source. If you specify a SourceType but do not specify a SourceIdentifier,
        /// you receive notice of the events for that source type for all your Neptune sources.
        /// If you do not specify either the SourceType nor the SourceIdentifier, you are notified
        /// of events generated from all Neptune sources belonging to your customer account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.EventSubscriptionQuotaExceededException">
        /// You have exceeded the number of events you can subscribe to.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SNSInvalidTopicException">
        /// The SNS topic is invalid.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SNSNoAuthorizationException">
        /// There is no SNS authorization.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SNSTopicArnNotFoundException">
        /// The ARN of the SNS topic could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SourceNotFoundException">
        /// The source could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionAlreadyExistException">
        /// This subscription already exists.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionCategoryNotFoundException">
        /// The designated subscription category could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEventSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGlobalCluster

        internal virtual CreateGlobalClusterResponse CreateGlobalCluster(CreateGlobalClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<CreateGlobalClusterResponse>(request, options);
        }



        /// <summary>
        /// Creates a Neptune global database spread across multiple Amazon Regions. The global
        /// database contains a single primary cluster with read-write capability, and read-only
        /// secondary clusters that receive data from the primary cluster through high-speed replication
        /// performed by the Neptune storage subsystem.
        /// 
        ///  
        /// <para>
        /// You can create a global database that is initially empty, and then add a primary cluster
        /// and secondary clusters to it, or you can specify an existing Neptune cluster during
        /// the create operation to become the primary cluster of the global database.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGlobalCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.GlobalClusterAlreadyExistsException">
        /// The <c>GlobalClusterIdentifier</c> already exists. Choose a new global database identifier
        /// (unique name) to create a new global database cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.GlobalClusterQuotaExceededException">
        /// The number of global database clusters for this account is already at the maximum
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateGlobalCluster">REST API Reference for CreateGlobalCluster Operation</seealso>
        public virtual Task<CreateGlobalClusterResponse> CreateGlobalClusterAsync(CreateGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGlobalClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDBCluster

        internal virtual DeleteDBClusterResponse DeleteDBCluster(DeleteDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterResponse>(request, options);
        }



        /// <summary>
        /// The DeleteDBCluster action deletes a previously provisioned DB cluster. When you delete
        /// a DB cluster, all automated backups for that DB cluster are deleted and can't be recovered.
        /// Manual DB cluster snapshots of the specified DB cluster are not deleted.
        /// 
        ///  
        /// <para>
        /// Note that the DB Cluster cannot be deleted if deletion protection is enabled. To delete
        /// it, you must first set its <c>DeletionProtection</c> field to <c>False</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotAlreadyExistsException">
        /// User already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBCluster">REST API Reference for DeleteDBCluster Operation</seealso>
        public virtual Task<DeleteDBClusterResponse> DeleteDBClusterAsync(DeleteDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDBClusterEndpoint

        internal virtual DeleteDBClusterEndpointResponse DeleteDBClusterEndpoint(DeleteDBClusterEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterEndpointResponse>(request, options);
        }



        /// <summary>
        /// Deletes a custom endpoint and removes it from an Amazon Neptune DB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBClusterEndpoint service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterEndpointNotFoundException">
        /// The specified custom endpoint doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterEndpointStateException">
        /// The requested operation cannot be performed on the endpoint while the endpoint is
        /// in this state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBClusterEndpoint">REST API Reference for DeleteDBClusterEndpoint Operation</seealso>
        public virtual Task<DeleteDBClusterEndpointResponse> DeleteDBClusterEndpointAsync(DeleteDBClusterEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBClusterEndpointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDBClusterParameterGroup

        internal virtual DeleteDBClusterParameterGroupResponse DeleteDBClusterParameterGroup(DeleteDBClusterParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a specified DB cluster parameter group. The DB cluster parameter group to
        /// be deleted can't be associated with any DB clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBClusterParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you cannot delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBClusterParameterGroup">REST API Reference for DeleteDBClusterParameterGroup Operation</seealso>
        public virtual Task<DeleteDBClusterParameterGroupResponse> DeleteDBClusterParameterGroupAsync(DeleteDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBClusterParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDBClusterSnapshot

        internal virtual DeleteDBClusterSnapshotResponse DeleteDBClusterSnapshot(DeleteDBClusterSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Deletes a DB cluster snapshot. If the snapshot is being copied, the copy operation
        /// is terminated.
        /// 
        ///  <note> 
        /// <para>
        /// The DB cluster snapshot must be in the <c>available</c> state to be deleted.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBClusterSnapshot service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBClusterSnapshot">REST API Reference for DeleteDBClusterSnapshot Operation</seealso>
        public virtual Task<DeleteDBClusterSnapshotResponse> DeleteDBClusterSnapshotAsync(DeleteDBClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBClusterSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDBInstance

        internal virtual DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteDBInstanceResponse>(request, options);
        }



        /// <summary>
        /// The DeleteDBInstance action deletes a previously provisioned DB instance. When you
        /// delete a DB instance, all automated backups for that instance are deleted and can't
        /// be recovered. Manual DB snapshots of the DB instance to be deleted by <c>DeleteDBInstance</c>
        /// are not deleted.
        /// 
        ///  
        /// <para>
        ///  If you request a final DB snapshot the status of the Amazon Neptune DB instance is
        /// <c>deleting</c> until the DB snapshot is created. The API action <c>DescribeDBInstance</c>
        /// is used to monitor the status of this operation. The action can't be canceled or reverted
        /// once submitted.
        /// </para>
        ///  
        /// <para>
        /// Note that when a DB instance is in a failure state and has a status of <c>failed</c>,
        /// <c>incompatible-restore</c>, or <c>incompatible-network</c>, you can only delete it
        /// when the <c>SkipFinalSnapshot</c> parameter is set to <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// You can't delete a DB instance if it is the only instance in the DB cluster, or if
        /// it has deletion protection enabled.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBInstance service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSnapshotAlreadyExistsException">
        /// <i>DBSnapshotIdentifier</i> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBInstance">REST API Reference for DeleteDBInstance Operation</seealso>
        public virtual Task<DeleteDBInstanceResponse> DeleteDBInstanceAsync(DeleteDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBInstanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDBParameterGroup

        internal virtual DeleteDBParameterGroupResponse DeleteDBParameterGroup(DeleteDBParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a specified DBParameterGroup. The DBParameterGroup to be deleted can't be
        /// associated with any DB instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you cannot delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBParameterGroup">REST API Reference for DeleteDBParameterGroup Operation</seealso>
        public virtual Task<DeleteDBParameterGroupResponse> DeleteDBParameterGroupAsync(DeleteDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDBSubnetGroup

        internal virtual DeleteDBSubnetGroupResponse DeleteDBSubnetGroup(DeleteDBSubnetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSubnetGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a DB subnet group.
        /// 
        ///  <note> 
        /// <para>
        /// The specified database subnet group must not be associated with any DB instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBSubnetGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSubnetStateException">
        /// The DB subnet is not in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBSubnetGroup">REST API Reference for DeleteDBSubnetGroup Operation</seealso>
        public virtual Task<DeleteDBSubnetGroupResponse> DeleteDBSubnetGroupAsync(DeleteDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBSubnetGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEventSubscription

        internal virtual DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Deletes an event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.InvalidEventSubscriptionStateException">
        /// The event subscription is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionNotFoundException">
        /// The designated subscription could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteGlobalCluster

        internal virtual DeleteGlobalClusterResponse DeleteGlobalCluster(DeleteGlobalClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteGlobalClusterResponse>(request, options);
        }



        /// <summary>
        /// Deletes a global database. The primary and all secondary clusters must already be
        /// detached or deleted first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGlobalCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteGlobalCluster">REST API Reference for DeleteGlobalCluster Operation</seealso>
        public virtual Task<DeleteGlobalClusterResponse> DeleteGlobalClusterAsync(DeleteGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlobalClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGlobalClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDBClusterEndpoints

        internal virtual DescribeDBClusterEndpointsResponse DescribeDBClusterEndpoints(DescribeDBClusterEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterEndpointsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about endpoints for an Amazon Neptune DB cluster.
        /// 
        ///  <note> 
        /// <para>
        /// This operation can also return information for Amazon RDS clusters and Amazon DocDB
        /// clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterEndpoints service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusterEndpoints">REST API Reference for DescribeDBClusterEndpoints Operation</seealso>
        public virtual Task<DescribeDBClusterEndpointsResponse> DescribeDBClusterEndpointsAsync(DescribeDBClusterEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClusterEndpointsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDBClusterParameterGroups

        internal virtual DescribeDBClusterParameterGroupsResponse DescribeDBClusterParameterGroups(DescribeDBClusterParameterGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterParameterGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of <c>DBClusterParameterGroup</c> descriptions. If a <c>DBClusterParameterGroupName</c>
        /// parameter is specified, the list will contain only the description of the specified
        /// DB cluster parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameterGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameterGroups service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusterParameterGroups">REST API Reference for DescribeDBClusterParameterGroups Operation</seealso>
        public virtual Task<DescribeDBClusterParameterGroupsResponse> DescribeDBClusterParameterGroupsAsync(DescribeDBClusterParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterParameterGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClusterParameterGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDBClusterParameters

        internal virtual DescribeDBClusterParametersResponse DescribeDBClusterParameters(DescribeDBClusterParametersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterParametersResponse>(request, options);
        }



        /// <summary>
        /// Returns the detailed parameter list for a particular DB cluster parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameters service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusterParameters">REST API Reference for DescribeDBClusterParameters Operation</seealso>
        public virtual Task<DescribeDBClusterParametersResponse> DescribeDBClusterParametersAsync(DescribeDBClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClusterParametersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDBClusters

        internal virtual DescribeDBClustersResponse DescribeDBClusters(DescribeDBClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClustersResponse>(request, options);
        }



        /// <summary>
        /// Returns information about provisioned DB clusters, and supports pagination.
        /// 
        ///  <note> 
        /// <para>
        /// This operation can also return information for Amazon RDS clusters and Amazon DocDB
        /// clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusters service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusters">REST API Reference for DescribeDBClusters Operation</seealso>
        public virtual Task<DescribeDBClustersResponse> DescribeDBClustersAsync(DescribeDBClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClustersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDBClusterSnapshotAttributes

        internal virtual DescribeDBClusterSnapshotAttributesResponse DescribeDBClusterSnapshotAttributes(DescribeDBClusterSnapshotAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterSnapshotAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterSnapshotAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterSnapshotAttributesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of DB cluster snapshot attribute names and values for a manual DB cluster
        /// snapshot.
        /// 
        ///  
        /// <para>
        /// When sharing snapshots with other Amazon accounts, <c>DescribeDBClusterSnapshotAttributes</c>
        /// returns the <c>restore</c> attribute and a list of IDs for the Amazon accounts that
        /// are authorized to copy or restore the manual DB cluster snapshot. If <c>all</c> is
        /// included in the list of values for the <c>restore</c> attribute, then the manual DB
        /// cluster snapshot is public and can be copied or restored by all Amazon accounts.
        /// </para>
        ///  
        /// <para>
        /// To add or remove access for an Amazon account to copy or restore a manual DB cluster
        /// snapshot, or to make the manual DB cluster snapshot public or private, use the <a>ModifyDBClusterSnapshotAttribute</a>
        /// API action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshotAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshotAttributes service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusterSnapshotAttributes">REST API Reference for DescribeDBClusterSnapshotAttributes Operation</seealso>
        public virtual Task<DescribeDBClusterSnapshotAttributesResponse> DescribeDBClusterSnapshotAttributesAsync(DescribeDBClusterSnapshotAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterSnapshotAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterSnapshotAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClusterSnapshotAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDBClusterSnapshots

        internal virtual DescribeDBClusterSnapshotsResponse DescribeDBClusterSnapshots(DescribeDBClusterSnapshotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about DB cluster snapshots. This API action supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshots service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusterSnapshots">REST API Reference for DescribeDBClusterSnapshots Operation</seealso>
        public virtual Task<DescribeDBClusterSnapshotsResponse> DescribeDBClusterSnapshotsAsync(DescribeDBClusterSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClusterSnapshotsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDBEngineVersions

        internal virtual DescribeDBEngineVersionsResponse DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBEngineVersionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the available DB engines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        public virtual Task<DescribeDBEngineVersionsResponse> DescribeDBEngineVersionsAsync(DescribeDBEngineVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBEngineVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDBInstances

        internal virtual DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBInstancesResponse>(request, options);
        }



        /// <summary>
        /// Returns information about provisioned instances, and supports pagination.
        /// 
        ///  <note> 
        /// <para>
        /// This operation can also return information for Amazon RDS instances and Amazon DocDB
        /// instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(DescribeDBInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBInstancesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDBParameterGroups

        internal virtual DescribeDBParameterGroupsResponse DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBParameterGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of <c>DBParameterGroup</c> descriptions. If a <c>DBParameterGroupName</c>
        /// is specified, the list will contain only the description of the specified DB parameter
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameterGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBParameterGroups">REST API Reference for DescribeDBParameterGroups Operation</seealso>
        public virtual Task<DescribeDBParameterGroupsResponse> DescribeDBParameterGroupsAsync(DescribeDBParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBParameterGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDBParameters

        internal virtual DescribeDBParametersResponse DescribeDBParameters(DescribeDBParametersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBParametersResponse>(request, options);
        }



        /// <summary>
        /// Returns the detailed parameter list for a particular DB parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBParameters service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBParameters">REST API Reference for DescribeDBParameters Operation</seealso>
        public virtual Task<DescribeDBParametersResponse> DescribeDBParametersAsync(DescribeDBParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBParametersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDBSubnetGroups

        internal virtual DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSubnetGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of DBSubnetGroup descriptions. If a DBSubnetGroupName is specified,
        /// the list will contain only the descriptions of the specified DBSubnetGroup.
        /// 
        ///  
        /// <para>
        /// For an overview of CIDR ranges, go to the <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Wikipedia
        /// Tutorial</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSubnetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        public virtual Task<DescribeDBSubnetGroupsResponse> DescribeDBSubnetGroupsAsync(DescribeDBSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBSubnetGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeEngineDefaultClusterParameters

        internal virtual DescribeEngineDefaultClusterParametersResponse DescribeEngineDefaultClusterParameters(DescribeEngineDefaultClusterParametersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEngineDefaultClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineDefaultClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeEngineDefaultClusterParametersResponse>(request, options);
        }



        /// <summary>
        /// Returns the default engine and system parameter information for the cluster database
        /// engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultClusterParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultClusterParameters service method, as returned by Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEngineDefaultClusterParameters">REST API Reference for DescribeEngineDefaultClusterParameters Operation</seealso>
        public virtual Task<DescribeEngineDefaultClusterParametersResponse> DescribeEngineDefaultClusterParametersAsync(DescribeEngineDefaultClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEngineDefaultClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineDefaultClusterParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEngineDefaultClusterParametersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeEngineDefaultParameters

        internal virtual DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEngineDefaultParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeEngineDefaultParametersResponse>(request, options);
        }



        /// <summary>
        /// Returns the default engine and system parameter information for the specified database
        /// engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEngineDefaultParameters">REST API Reference for DescribeEngineDefaultParameters Operation</seealso>
        public virtual Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEngineDefaultParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEngineDefaultParametersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeEventCategories

        internal virtual DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventCategoriesResponse>(request, options);
        }



        /// <summary>
        /// Displays a list of categories for all event source types, or, if specified, for a
        /// specified source type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventCategoriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeEvents

        internal virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsResponse>(request, options);
        }



        /// <summary>
        /// Returns events related to DB instances, DB security groups, DB snapshots, and DB parameter
        /// groups for the past 14 days. Events specific to a particular DB instance, DB security
        /// group, database snapshot, or DB parameter group can be obtained by providing the name
        /// as a parameter. By default, the past hour of events are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeEventSubscriptions

        internal virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSubscriptionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the subscription descriptions for a customer account. The description for
        /// a subscription includes SubscriptionName, SNSTopicARN, CustomerID, SourceType, SourceID,
        /// CreationTime, and Status.
        /// 
        ///  
        /// <para>
        /// If you specify a SubscriptionName, lists the description for that subscription.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionNotFoundException">
        /// The designated subscription could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventSubscriptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeGlobalClusters

        internal virtual DescribeGlobalClustersResponse DescribeGlobalClusters(DescribeGlobalClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGlobalClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeGlobalClustersResponse>(request, options);
        }



        /// <summary>
        /// Returns information about Neptune global database clusters. This API supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGlobalClusters service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeGlobalClusters">REST API Reference for DescribeGlobalClusters Operation</seealso>
        public virtual Task<DescribeGlobalClustersResponse> DescribeGlobalClustersAsync(DescribeGlobalClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGlobalClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGlobalClustersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeOrderableDBInstanceOptions

        internal virtual DescribeOrderableDBInstanceOptionsResponse DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrderableDBInstanceOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOrderableDBInstanceOptionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of orderable DB instance options for the specified engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrderableDBInstanceOptions service method, as returned by Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeOrderableDBInstanceOptions">REST API Reference for DescribeOrderableDBInstanceOptions Operation</seealso>
        public virtual Task<DescribeOrderableDBInstanceOptionsResponse> DescribeOrderableDBInstanceOptionsAsync(DescribeOrderableDBInstanceOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrderableDBInstanceOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOrderableDBInstanceOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribePendingMaintenanceActions

        internal virtual DescribePendingMaintenanceActionsResponse DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePendingMaintenanceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance;

            return Invoke<DescribePendingMaintenanceActionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of resources (for example, DB instances) that have at least one pending
        /// maintenance action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingMaintenanceActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePendingMaintenanceActions service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        public virtual Task<DescribePendingMaintenanceActionsResponse> DescribePendingMaintenanceActionsAsync(DescribePendingMaintenanceActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePendingMaintenanceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePendingMaintenanceActionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeValidDBInstanceModifications

        internal virtual DescribeValidDBInstanceModificationsResponse DescribeValidDBInstanceModifications(DescribeValidDBInstanceModificationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeValidDBInstanceModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeValidDBInstanceModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeValidDBInstanceModificationsResponse>(request, options);
        }



        /// <summary>
        /// You can call <a>DescribeValidDBInstanceModifications</a> to learn what modifications
        /// you can make to your DB instance. You can use this information when you call <a>ModifyDBInstance</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeValidDBInstanceModifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeValidDBInstanceModifications service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeValidDBInstanceModifications">REST API Reference for DescribeValidDBInstanceModifications Operation</seealso>
        public virtual Task<DescribeValidDBInstanceModificationsResponse> DescribeValidDBInstanceModificationsAsync(DescribeValidDBInstanceModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeValidDBInstanceModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeValidDBInstanceModificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeValidDBInstanceModificationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  FailoverDBCluster

        internal virtual FailoverDBClusterResponse FailoverDBCluster(FailoverDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FailoverDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverDBClusterResponseUnmarshaller.Instance;

            return Invoke<FailoverDBClusterResponse>(request, options);
        }



        /// <summary>
        /// Forces a failover for a DB cluster.
        /// 
        ///  
        /// <para>
        /// A failover for a DB cluster promotes one of the Read Replicas (read-only instances)
        /// in the DB cluster to be the primary instance (the cluster writer).
        /// </para>
        ///  
        /// <para>
        /// Amazon Neptune will automatically fail over to a Read Replica, if one exists, when
        /// the primary instance fails. You can force a failover when you want to simulate a failure
        /// of a primary instance for testing. Because each instance in a DB cluster has its own
        /// endpoint address, you will need to clean up and re-establish any existing connections
        /// that use those endpoint addresses when the failover is complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FailoverDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/FailoverDBCluster">REST API Reference for FailoverDBCluster Operation</seealso>
        public virtual Task<FailoverDBClusterResponse> FailoverDBClusterAsync(FailoverDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FailoverDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<FailoverDBClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  FailoverGlobalCluster

        internal virtual FailoverGlobalClusterResponse FailoverGlobalCluster(FailoverGlobalClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FailoverGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<FailoverGlobalClusterResponse>(request, options);
        }



        /// <summary>
        /// Initiates the failover process for a Neptune global database.
        /// 
        ///  
        /// <para>
        /// A failover for a Neptune global database promotes one of secondary read-only DB clusters
        /// to be the primary DB cluster and demotes the primary DB cluster to being a secondary
        /// (read-only) DB cluster. In other words, the role of the current primary DB cluster
        /// and the selected target secondary DB cluster are switched. The selected secondary
        /// DB cluster assumes full read/write capabilities for the Neptune global database.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action applies <b>only</b> to Neptune global databases. This action is only intended
        /// for use on healthy Neptune global databases with healthy Neptune DB clusters and no
        /// region-wide outages, to test disaster recovery scenarios or to reconfigure the global
        /// database topology.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FailoverGlobalCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/FailoverGlobalCluster">REST API Reference for FailoverGlobalCluster Operation</seealso>
        public virtual Task<FailoverGlobalClusterResponse> FailoverGlobalClusterAsync(FailoverGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FailoverGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverGlobalClusterResponseUnmarshaller.Instance;

            return InvokeAsync<FailoverGlobalClusterResponse>(request, options, cancellationToken);
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
        /// Lists all tags on an Amazon Neptune resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyDBCluster

        internal virtual ModifyDBClusterResponse ModifyDBCluster(ModifyDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterResponse>(request, options);
        }



        /// <summary>
        /// Modify a setting for a DB cluster. You can change one or more database configuration
        /// parameters by specifying these parameters and the new values in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterAlreadyExistsException">
        /// User already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterParameterGroupNotFoundException">
        /// <i>DBClusterParameterGroupName</i> does not refer to an existing DB Cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageTypeNotSupportedException">
        /// <i>StorageType</i> specified cannot be associated with the DB Instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBCluster">REST API Reference for ModifyDBCluster Operation</seealso>
        public virtual Task<ModifyDBClusterResponse> ModifyDBClusterAsync(ModifyDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyDBClusterEndpoint

        internal virtual ModifyDBClusterEndpointResponse ModifyDBClusterEndpoint(ModifyDBClusterEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterEndpointResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterEndpointResponse>(request, options);
        }



        /// <summary>
        /// Modifies the properties of an endpoint in an Amazon Neptune DB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBClusterEndpoint service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterEndpointNotFoundException">
        /// The specified custom endpoint doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterEndpointStateException">
        /// The requested operation cannot be performed on the endpoint while the endpoint is
        /// in this state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBClusterEndpoint">REST API Reference for ModifyDBClusterEndpoint Operation</seealso>
        public virtual Task<ModifyDBClusterEndpointResponse> ModifyDBClusterEndpointAsync(ModifyDBClusterEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBClusterEndpointResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyDBClusterParameterGroup

        internal virtual ModifyDBClusterParameterGroupResponse ModifyDBClusterParameterGroup(ModifyDBClusterParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies the parameters of a DB cluster parameter group. To modify more than one
        /// parameter, submit a list of the following: <c>ParameterName</c>, <c>ParameterValue</c>,
        /// and <c>ApplyMethod</c>. A maximum of 20 parameters can be modified in a single request.
        /// 
        ///  <note> 
        /// <para>
        /// Changes to dynamic parameters are applied immediately. Changes to static parameters
        /// require a reboot without failover to the DB cluster associated with the parameter
        /// group before the change can take effect.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// After you create a DB cluster parameter group, you should wait at least 5 minutes
        /// before creating your first DB cluster that uses that DB cluster parameter group as
        /// the default parameter group. This allows Amazon Neptune to fully complete the create
        /// action before the parameter group is used as the default for a new DB cluster. This
        /// is especially important for parameters that are critical when creating the default
        /// database for a DB cluster, such as the character set for the default database defined
        /// by the <c>character_set_database</c> parameter. You can use the <i>Parameter Groups</i>
        /// option of the Amazon Neptune console or the <a>DescribeDBClusterParameters</a> command
        /// to verify that your DB cluster parameter group has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBClusterParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you cannot delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBClusterParameterGroup">REST API Reference for ModifyDBClusterParameterGroup Operation</seealso>
        public virtual Task<ModifyDBClusterParameterGroupResponse> ModifyDBClusterParameterGroupAsync(ModifyDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBClusterParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyDBClusterSnapshotAttribute

        internal virtual ModifyDBClusterSnapshotAttributeResponse ModifyDBClusterSnapshotAttribute(ModifyDBClusterSnapshotAttributeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterSnapshotAttributeResponse>(request, options);
        }



        /// <summary>
        /// Adds an attribute and values to, or removes an attribute and values from, a manual
        /// DB cluster snapshot.
        /// 
        ///  
        /// <para>
        /// To share a manual DB cluster snapshot with other Amazon accounts, specify <c>restore</c>
        /// as the <c>AttributeName</c> and use the <c>ValuesToAdd</c> parameter to add a list
        /// of IDs of the Amazon accounts that are authorized to restore the manual DB cluster
        /// snapshot. Use the value <c>all</c> to make the manual DB cluster snapshot public,
        /// which means that it can be copied or restored by all Amazon accounts. Do not add the
        /// <c>all</c> value for any manual DB cluster snapshots that contain private information
        /// that you don't want available to all Amazon accounts. If a manual DB cluster snapshot
        /// is encrypted, it can be shared, but only by specifying a list of authorized Amazon
        /// account IDs for the <c>ValuesToAdd</c> parameter. You can't use <c>all</c> as a value
        /// for that parameter in this case.
        /// </para>
        ///  
        /// <para>
        /// To view which Amazon accounts have access to copy or restore a manual DB cluster snapshot,
        /// or whether a manual DB cluster snapshot public or private, use the <a>DescribeDBClusterSnapshotAttributes</a>
        /// API action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterSnapshotAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBClusterSnapshotAttribute service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SharedSnapshotQuotaExceededException">
        /// You have exceeded the maximum number of accounts that you can share a manual DB snapshot
        /// with.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBClusterSnapshotAttribute">REST API Reference for ModifyDBClusterSnapshotAttribute Operation</seealso>
        public virtual Task<ModifyDBClusterSnapshotAttributeResponse> ModifyDBClusterSnapshotAttributeAsync(ModifyDBClusterSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterSnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBClusterSnapshotAttributeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyDBInstance

        internal virtual ModifyDBInstanceResponse ModifyDBInstance(ModifyDBInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBInstanceResponseUnmarshaller.Instance;

            return Invoke<ModifyDBInstanceResponse>(request, options);
        }



        /// <summary>
        /// Modifies settings for a DB instance. You can change one or more database configuration
        /// parameters by specifying these parameters and the new values in the request. To learn
        /// what modifications you can make to your DB instance, call <a>DescribeValidDBInstanceModifications</a>
        /// before you call <a>ModifyDBInstance</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBInstance service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.AuthorizationNotFoundException">
        /// Specified CIDRIP or EC2 security group is not authorized for the specified DB security
        /// group.
        /// 
        ///  
        /// <para>
        /// Neptune may not also be authorized via IAM to perform necessary actions on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.CertificateNotFoundException">
        /// <i>CertificateIdentifier</i> does not refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceAlreadyExistsException">
        /// User already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBUpgradeDependencyFailureException">
        /// The DB upgrade failed because a resource the DB depends on could not be modified.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DomainNotFoundException">
        /// <i>Domain</i> does not refer to an existing Active Directory Domain.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientDBInstanceCapacityException">
        /// Specified DB instance class is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.OptionGroupNotFoundException">
        /// The designated option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageTypeNotSupportedException">
        /// <i>StorageType</i> specified cannot be associated with the DB Instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBInstance">REST API Reference for ModifyDBInstance Operation</seealso>
        public virtual Task<ModifyDBInstanceResponse> ModifyDBInstanceAsync(ModifyDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBInstanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyDBParameterGroup

        internal virtual ModifyDBParameterGroupResponse ModifyDBParameterGroup(ModifyDBParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies the parameters of a DB parameter group. To modify more than one parameter,
        /// submit a list of the following: <c>ParameterName</c>, <c>ParameterValue</c>, and <c>ApplyMethod</c>.
        /// A maximum of 20 parameters can be modified in a single request.
        /// 
        ///  <note> 
        /// <para>
        /// Changes to dynamic parameters are applied immediately. Changes to static parameters
        /// require a reboot without failover to the DB instance associated with the parameter
        /// group before the change can take effect.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// After you modify a DB parameter group, you should wait at least 5 minutes before creating
        /// your first DB instance that uses that DB parameter group as the default parameter
        /// group. This allows Amazon Neptune to fully complete the modify action before the parameter
        /// group is used as the default for a new DB instance. This is especially important for
        /// parameters that are critical when creating the default database for a DB instance,
        /// such as the character set for the default database defined by the <c>character_set_database</c>
        /// parameter. You can use the <i>Parameter Groups</i> option of the Amazon Neptune console
        /// or the <i>DescribeDBParameters</i> command to verify that your DB parameter group
        /// has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you cannot delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBParameterGroup">REST API Reference for ModifyDBParameterGroup Operation</seealso>
        public virtual Task<ModifyDBParameterGroupResponse> ModifyDBParameterGroupAsync(ModifyDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyDBSubnetGroup

        internal virtual ModifyDBSubnetGroupResponse ModifyDBSubnetGroup(ModifyDBSubnetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBSubnetGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies an existing DB subnet group. DB subnet groups must contain at least one subnet
        /// in at least two AZs in the Amazon Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBSubnetGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetQuotaExceededException">
        /// Request would result in user exceeding the allowed number of subnets in a DB subnet
        /// groups.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubnetAlreadyInUseException">
        /// The DB subnet is already in use in the Availability Zone.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBSubnetGroup">REST API Reference for ModifyDBSubnetGroup Operation</seealso>
        public virtual Task<ModifyDBSubnetGroupResponse> ModifyDBSubnetGroupAsync(ModifyDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBSubnetGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyEventSubscription

        internal virtual ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ModifyEventSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Modifies an existing event notification subscription. Note that you can't modify the
        /// source identifiers using this call; to change source identifiers for a subscription,
        /// use the <a>AddSourceIdentifierToSubscription</a> and <a>RemoveSourceIdentifierFromSubscription</a>
        /// calls.
        /// 
        ///  
        /// <para>
        /// You can see a list of the event categories for a given SourceType by using the <b>DescribeEventCategories</b>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.EventSubscriptionQuotaExceededException">
        /// You have exceeded the number of events you can subscribe to.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SNSInvalidTopicException">
        /// The SNS topic is invalid.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SNSNoAuthorizationException">
        /// There is no SNS authorization.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SNSTopicArnNotFoundException">
        /// The ARN of the SNS topic could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionCategoryNotFoundException">
        /// The designated subscription category could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionNotFoundException">
        /// The designated subscription could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyEventSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyGlobalCluster

        internal virtual ModifyGlobalClusterResponse ModifyGlobalCluster(ModifyGlobalClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyGlobalClusterResponse>(request, options);
        }



        /// <summary>
        /// Modify a setting for an Amazon Neptune global cluster. You can change one or more
        /// database configuration parameters by specifying these parameters and their new values
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyGlobalCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyGlobalCluster">REST API Reference for ModifyGlobalCluster Operation</seealso>
        public virtual Task<ModifyGlobalClusterResponse> ModifyGlobalClusterAsync(ModifyGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyGlobalClusterResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyGlobalClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PromoteReadReplicaDBCluster

        internal virtual PromoteReadReplicaDBClusterResponse PromoteReadReplicaDBCluster(PromoteReadReplicaDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PromoteReadReplicaDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromoteReadReplicaDBClusterResponseUnmarshaller.Instance;

            return Invoke<PromoteReadReplicaDBClusterResponse>(request, options);
        }



        /// <summary>
        /// Not supported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplicaDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PromoteReadReplicaDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/PromoteReadReplicaDBCluster">REST API Reference for PromoteReadReplicaDBCluster Operation</seealso>
        public virtual Task<PromoteReadReplicaDBClusterResponse> PromoteReadReplicaDBClusterAsync(PromoteReadReplicaDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PromoteReadReplicaDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromoteReadReplicaDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<PromoteReadReplicaDBClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RebootDBInstance

        internal virtual RebootDBInstanceResponse RebootDBInstance(RebootDBInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDBInstanceResponseUnmarshaller.Instance;

            return Invoke<RebootDBInstanceResponse>(request, options);
        }



        /// <summary>
        /// You might need to reboot your DB instance, usually for maintenance reasons. For example,
        /// if you make certain modifications, or if you change the DB parameter group associated
        /// with the DB instance, you must reboot the instance for the changes to take effect.
        /// 
        ///  
        /// <para>
        /// Rebooting a DB instance restarts the database engine service. Rebooting a DB instance
        /// results in a momentary outage, during which the DB instance status is set to rebooting.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootDBInstance service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RebootDBInstance">REST API Reference for RebootDBInstance Operation</seealso>
        public virtual Task<RebootDBInstanceResponse> RebootDBInstanceAsync(RebootDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RebootDBInstanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveFromGlobalCluster

        internal virtual RemoveFromGlobalClusterResponse RemoveFromGlobalCluster(RemoveFromGlobalClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFromGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFromGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<RemoveFromGlobalClusterResponse>(request, options);
        }



        /// <summary>
        /// Detaches a Neptune DB cluster from a Neptune global database. A secondary cluster
        /// becomes a normal standalone cluster with read-write capability instead of being read-only,
        /// and no longer receives data from a the primary cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFromGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveFromGlobalCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RemoveFromGlobalCluster">REST API Reference for RemoveFromGlobalCluster Operation</seealso>
        public virtual Task<RemoveFromGlobalClusterResponse> RemoveFromGlobalClusterAsync(RemoveFromGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFromGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFromGlobalClusterResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveFromGlobalClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveRoleFromDBCluster

        internal virtual RemoveRoleFromDBClusterResponse RemoveRoleFromDBCluster(RemoveRoleFromDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveRoleFromDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRoleFromDBClusterResponseUnmarshaller.Instance;

            return Invoke<RemoveRoleFromDBClusterResponse>(request, options);
        }



        /// <summary>
        /// Disassociates an Identity and Access Management (IAM) role from a DB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveRoleFromDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterRoleNotFoundException">
        /// The specified IAM role Amazon Resource Name (ARN) is not associated with the specified
        /// DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RemoveRoleFromDBCluster">REST API Reference for RemoveRoleFromDBCluster Operation</seealso>
        public virtual Task<RemoveRoleFromDBClusterResponse> RemoveRoleFromDBClusterAsync(RemoveRoleFromDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveRoleFromDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRoleFromDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveRoleFromDBClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveSourceIdentifierFromSubscription

        internal virtual RemoveSourceIdentifierFromSubscriptionResponse RemoveSourceIdentifierFromSubscription(RemoveSourceIdentifierFromSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveSourceIdentifierFromSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance;

            return Invoke<RemoveSourceIdentifierFromSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Removes a source identifier from an existing event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveSourceIdentifierFromSubscription service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.SourceNotFoundException">
        /// The source could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionNotFoundException">
        /// The designated subscription could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RemoveSourceIdentifierFromSubscription">REST API Reference for RemoveSourceIdentifierFromSubscription Operation</seealso>
        public virtual Task<RemoveSourceIdentifierFromSubscriptionResponse> RemoveSourceIdentifierFromSubscriptionAsync(RemoveSourceIdentifierFromSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveSourceIdentifierFromSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveSourceIdentifierFromSubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveTagsFromResource

        internal virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes metadata tags from an Amazon Neptune resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ResetDBClusterParameterGroup

        internal virtual ResetDBClusterParameterGroupResponse ResetDBClusterParameterGroup(ResetDBClusterParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetDBClusterParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies the parameters of a DB cluster parameter group to the default value. To
        /// reset specific parameters submit a list of the following: <c>ParameterName</c> and
        /// <c>ApplyMethod</c>. To reset the entire DB cluster parameter group, specify the <c>DBClusterParameterGroupName</c>
        /// and <c>ResetAllParameters</c> parameters.
        /// 
        ///  
        /// <para>
        ///  When resetting the entire group, dynamic parameters are updated immediately and static
        /// parameters are set to <c>pending-reboot</c> to take effect on the next DB instance
        /// restart or <a>RebootDBInstance</a> request. You must call <a>RebootDBInstance</a>
        /// for every DB instance in your DB cluster that you want the updated static parameter
        /// to apply to.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDBClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetDBClusterParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you cannot delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ResetDBClusterParameterGroup">REST API Reference for ResetDBClusterParameterGroup Operation</seealso>
        public virtual Task<ResetDBClusterParameterGroupResponse> ResetDBClusterParameterGroupAsync(ResetDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDBClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ResetDBClusterParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ResetDBParameterGroup

        internal virtual ResetDBParameterGroupResponse ResetDBParameterGroup(ResetDBParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetDBParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies the parameters of a DB parameter group to the engine/system default value.
        /// To reset specific parameters, provide a list of the following: <c>ParameterName</c>
        /// and <c>ApplyMethod</c>. To reset the entire DB parameter group, specify the <c>DBParameterGroup</c>
        /// name and <c>ResetAllParameters</c> parameters. When resetting the entire group, dynamic
        /// parameters are updated immediately and static parameters are set to <c>pending-reboot</c>
        /// to take effect on the next DB instance restart or <c>RebootDBInstance</c> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDBParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetDBParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you cannot delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ResetDBParameterGroup">REST API Reference for ResetDBParameterGroup Operation</seealso>
        public virtual Task<ResetDBParameterGroupResponse> ResetDBParameterGroupAsync(ResetDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ResetDBParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RestoreDBClusterFromSnapshot

        internal virtual RestoreDBClusterFromSnapshotResponse RestoreDBClusterFromSnapshot(RestoreDBClusterFromSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreDBClusterFromSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a new DB cluster from a DB snapshot or DB cluster snapshot.
        /// 
        ///  
        /// <para>
        /// If a DB snapshot is specified, the target DB cluster is created from the source DB
        /// snapshot with a default configuration and default security group.
        /// </para>
        ///  
        /// <para>
        /// If a DB cluster snapshot is specified, the target DB cluster is created from the source
        /// DB cluster restore point with the same configuration as the original source DB cluster,
        /// except that the new DB cluster is created with the default security group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreDBClusterFromSnapshot service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterAlreadyExistsException">
        /// User already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterParameterGroupNotFoundException">
        /// <i>DBClusterParameterGroupName</i> does not refer to an existing DB Cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterQuotaExceededException">
        /// User attempted to create a new DB cluster and the user has already reached the maximum
        /// allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientDBClusterCapacityException">
        /// The DB cluster does not have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You may be able to
        /// resolve this error by updating your subnet group to use different Availability Zones
        /// that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidRestoreException">
        /// Cannot restore from vpc backup to non-vpc DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.OptionGroupNotFoundException">
        /// The designated option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RestoreDBClusterFromSnapshot">REST API Reference for RestoreDBClusterFromSnapshot Operation</seealso>
        public virtual Task<RestoreDBClusterFromSnapshotResponse> RestoreDBClusterFromSnapshotAsync(RestoreDBClusterFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreDBClusterFromSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RestoreDBClusterToPointInTime

        internal virtual RestoreDBClusterToPointInTimeResponse RestoreDBClusterToPointInTime(RestoreDBClusterToPointInTimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance;

            return Invoke<RestoreDBClusterToPointInTimeResponse>(request, options);
        }



        /// <summary>
        /// Restores a DB cluster to an arbitrary point in time. Users can restore to any point
        /// in time before <c>LatestRestorableTime</c> for up to <c>BackupRetentionPeriod</c>
        /// days. The target DB cluster is created from the source DB cluster with the same configuration
        /// as the original DB cluster, except that the new DB cluster is created with the default
        /// DB security group.
        /// 
        ///  <note> 
        /// <para>
        /// This action only restores the DB cluster, not the DB instances for that DB cluster.
        /// You must invoke the <a>CreateDBInstance</a> action to create DB instances for the
        /// restored DB cluster, specifying the identifier of the restored DB cluster in <c>DBClusterIdentifier</c>.
        /// You can create DB instances only after the <c>RestoreDBClusterToPointInTime</c> action
        /// has completed and the DB cluster is available.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterToPointInTime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreDBClusterToPointInTime service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterAlreadyExistsException">
        /// User already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterParameterGroupNotFoundException">
        /// <i>DBClusterParameterGroupName</i> does not refer to an existing DB Cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterQuotaExceededException">
        /// User attempted to create a new DB cluster and the user has already reached the maximum
        /// allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientDBClusterCapacityException">
        /// The DB cluster does not have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You may be able to
        /// resolve this error by updating your subnet group to use different Availability Zones
        /// that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidRestoreException">
        /// Cannot restore from vpc backup to non-vpc DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.OptionGroupNotFoundException">
        /// The designated option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RestoreDBClusterToPointInTime">REST API Reference for RestoreDBClusterToPointInTime Operation</seealso>
        public virtual Task<RestoreDBClusterToPointInTimeResponse> RestoreDBClusterToPointInTimeAsync(RestoreDBClusterToPointInTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreDBClusterToPointInTimeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartDBCluster

        internal virtual StartDBClusterResponse StartDBCluster(StartDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBClusterResponseUnmarshaller.Instance;

            return Invoke<StartDBClusterResponse>(request, options);
        }



        /// <summary>
        /// Starts an Amazon Neptune DB cluster that was stopped using the Amazon console, the
        /// Amazon CLI stop-db-cluster command, or the StopDBCluster API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/StartDBCluster">REST API Reference for StartDBCluster Operation</seealso>
        public virtual Task<StartDBClusterResponse> StartDBClusterAsync(StartDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<StartDBClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopDBCluster

        internal virtual StopDBClusterResponse StopDBCluster(StopDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBClusterResponseUnmarshaller.Instance;

            return Invoke<StopDBClusterResponse>(request, options);
        }



        /// <summary>
        /// Stops an Amazon Neptune DB cluster. When you stop a DB cluster, Neptune retains the
        /// DB cluster's metadata, including its endpoints and DB parameter groups.
        /// 
        ///  
        /// <para>
        /// Neptune also retains the transaction logs so you can do a point-in-time restore if
        /// necessary.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/StopDBCluster">REST API Reference for StopDBCluster Operation</seealso>
        public virtual Task<StopDBClusterResponse> StopDBClusterAsync(StopDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<StopDBClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SwitchoverGlobalCluster

        internal virtual SwitchoverGlobalClusterResponse SwitchoverGlobalCluster(SwitchoverGlobalClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SwitchoverGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwitchoverGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<SwitchoverGlobalClusterResponse>(request, options);
        }



        /// <summary>
        /// Switches over the specified secondary DB cluster to be the new primary DB cluster
        /// in the global database cluster. Switchover operations were previously called "managed
        /// planned failovers."
        /// 
        ///  
        /// <para>
        /// Promotes the specified secondary cluster to assume full read/write capabilities and
        /// demotes the current primary cluster to a secondary (read-only) cluster, maintaining
        /// the original replication topology. All secondary clusters are synchronized with the
        /// primary at the beginning of the process so the new primary continues operations for
        /// the global database without losing any data. Your database is unavailable for a short
        /// time while the primary and selected secondary clusters are assuming their new roles.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is intended for controlled environments, for operations such as "regional
        /// rotation" or to fall back to the original primary after a global database failover.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwitchoverGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SwitchoverGlobalCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/SwitchoverGlobalCluster">REST API Reference for SwitchoverGlobalCluster Operation</seealso>
        public virtual Task<SwitchoverGlobalClusterResponse> SwitchoverGlobalClusterAsync(SwitchoverGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SwitchoverGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwitchoverGlobalClusterResponseUnmarshaller.Instance;

            return InvokeAsync<SwitchoverGlobalClusterResponse>(request, options, cancellationToken);
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