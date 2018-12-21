/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ElastiCache.Model;
using Amazon.ElastiCache.Model.Internal.MarshallTransformations;
using Amazon.ElastiCache.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElastiCache
{
    /// <summary>
    /// Implementation for accessing ElastiCache
    ///
    /// Amazon ElastiCache 
    /// <para>
    /// Amazon ElastiCache is a web service that makes it easier to set up, operate, and scale
    /// a distributed cache in the cloud.
    /// </para>
    ///  
    /// <para>
    /// With ElastiCache, customers get all of the benefits of a high-performance, in-memory
    /// cache with less of the administrative burden involved in launching and managing a
    /// distributed cache. The service makes setup, scaling, and cluster failure handling
    /// much simpler than in a self-managed cache deployment.
    /// </para>
    ///  
    /// <para>
    /// In addition, through integration with Amazon CloudWatch, customers get enhanced visibility
    /// into the key performance statistics associated with their cache and can receive alarms
    /// if a part of their cache runs hot.
    /// </para>
    /// </summary>
    public partial class AmazonElastiCacheClient : AmazonServiceClient, IAmazonElastiCache
    {
        private static IServiceMetadata serviceMetadata = new AmazonElastiCacheMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonElastiCacheClient with the credentials loaded from the application's
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
        public AmazonElastiCacheClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElastiCacheConfig()) { }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with the credentials loaded from the application's
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
        public AmazonElastiCacheClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElastiCacheConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElastiCacheClient Configuration Object</param>
        public AmazonElastiCacheClient(AmazonElastiCacheConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElastiCacheClient(AWSCredentials credentials)
            : this(credentials, new AmazonElastiCacheConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElastiCacheClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElastiCacheConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Credentials and an
        /// AmazonElastiCacheClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElastiCacheClient Configuration Object</param>
        public AmazonElastiCacheClient(AWSCredentials credentials, AmazonElastiCacheConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElastiCacheConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElastiCacheConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElastiCacheClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElastiCacheClient Configuration Object</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElastiCacheConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElastiCacheConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElastiCacheConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElastiCacheClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElastiCacheClient Configuration Object</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElastiCacheConfig clientConfig)
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


        #region  AddTagsToResource

        internal virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeCacheSecurityGroupIngress

        internal virtual AuthorizeCacheSecurityGroupIngressResponse AuthorizeCacheSecurityGroupIngress(AuthorizeCacheSecurityGroupIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeCacheSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeCacheSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeCacheSecurityGroupIngressResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeCacheSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeCacheSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/AuthorizeCacheSecurityGroupIngress">REST API Reference for AuthorizeCacheSecurityGroupIngress Operation</seealso>
        public virtual Task<AuthorizeCacheSecurityGroupIngressResponse> AuthorizeCacheSecurityGroupIngressAsync(AuthorizeCacheSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeCacheSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeCacheSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeCacheSecurityGroupIngressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopySnapshot

        internal virtual CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopySnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return Invoke<CopySnapshotResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopySnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
        public virtual Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopySnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopySnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCacheCluster

        internal virtual CreateCacheClusterResponse CreateCacheCluster(CreateCacheClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCacheClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCacheClusterResponseUnmarshaller.Instance;

            return Invoke<CreateCacheClusterResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CreateCacheCluster">REST API Reference for CreateCacheCluster Operation</seealso>
        public virtual Task<CreateCacheClusterResponse> CreateCacheClusterAsync(CreateCacheClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCacheClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCacheClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCacheClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCacheParameterGroup

        internal virtual CreateCacheParameterGroupResponse CreateCacheParameterGroup(CreateCacheParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCacheParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCacheParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateCacheParameterGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CreateCacheParameterGroup">REST API Reference for CreateCacheParameterGroup Operation</seealso>
        public virtual Task<CreateCacheParameterGroupResponse> CreateCacheParameterGroupAsync(CreateCacheParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCacheParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCacheParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCacheParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCacheSecurityGroup

        internal virtual CreateCacheSecurityGroupResponse CreateCacheSecurityGroup(CreateCacheSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCacheSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCacheSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateCacheSecurityGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CreateCacheSecurityGroup">REST API Reference for CreateCacheSecurityGroup Operation</seealso>
        public virtual Task<CreateCacheSecurityGroupResponse> CreateCacheSecurityGroupAsync(CreateCacheSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCacheSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCacheSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCacheSecurityGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCacheSubnetGroup

        internal virtual CreateCacheSubnetGroupResponse CreateCacheSubnetGroup(CreateCacheSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCacheSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCacheSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateCacheSubnetGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CreateCacheSubnetGroup">REST API Reference for CreateCacheSubnetGroup Operation</seealso>
        public virtual Task<CreateCacheSubnetGroupResponse> CreateCacheSubnetGroupAsync(CreateCacheSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCacheSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCacheSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCacheSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateReplicationGroup

        internal virtual CreateReplicationGroupResponse CreateReplicationGroup(CreateReplicationGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationGroupResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CreateReplicationGroup">REST API Reference for CreateReplicationGroup Operation</seealso>
        public virtual Task<CreateReplicationGroupResponse> CreateReplicationGroupAsync(CreateReplicationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReplicationGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshot

        internal virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DecreaseReplicaCount

        internal virtual DecreaseReplicaCountResponse DecreaseReplicaCount(DecreaseReplicaCountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecreaseReplicaCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecreaseReplicaCountResponseUnmarshaller.Instance;

            return Invoke<DecreaseReplicaCountResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DecreaseReplicaCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DecreaseReplicaCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DecreaseReplicaCount">REST API Reference for DecreaseReplicaCount Operation</seealso>
        public virtual Task<DecreaseReplicaCountResponse> DecreaseReplicaCountAsync(DecreaseReplicaCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecreaseReplicaCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecreaseReplicaCountResponseUnmarshaller.Instance;

            return InvokeAsync<DecreaseReplicaCountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCacheCluster

        internal virtual DeleteCacheClusterResponse DeleteCacheCluster(DeleteCacheClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCacheClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCacheClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteCacheClusterResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DeleteCacheCluster">REST API Reference for DeleteCacheCluster Operation</seealso>
        public virtual Task<DeleteCacheClusterResponse> DeleteCacheClusterAsync(DeleteCacheClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCacheClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCacheClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCacheClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCacheParameterGroup

        internal virtual DeleteCacheParameterGroupResponse DeleteCacheParameterGroup(DeleteCacheParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCacheParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCacheParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteCacheParameterGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DeleteCacheParameterGroup">REST API Reference for DeleteCacheParameterGroup Operation</seealso>
        public virtual Task<DeleteCacheParameterGroupResponse> DeleteCacheParameterGroupAsync(DeleteCacheParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCacheParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCacheParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCacheParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCacheSecurityGroup

        internal virtual DeleteCacheSecurityGroupResponse DeleteCacheSecurityGroup(DeleteCacheSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCacheSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCacheSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteCacheSecurityGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DeleteCacheSecurityGroup">REST API Reference for DeleteCacheSecurityGroup Operation</seealso>
        public virtual Task<DeleteCacheSecurityGroupResponse> DeleteCacheSecurityGroupAsync(DeleteCacheSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCacheSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCacheSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCacheSecurityGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCacheSubnetGroup

        internal virtual DeleteCacheSubnetGroupResponse DeleteCacheSubnetGroup(DeleteCacheSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCacheSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCacheSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteCacheSubnetGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DeleteCacheSubnetGroup">REST API Reference for DeleteCacheSubnetGroup Operation</seealso>
        public virtual Task<DeleteCacheSubnetGroupResponse> DeleteCacheSubnetGroupAsync(DeleteCacheSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCacheSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCacheSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCacheSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteReplicationGroup

        internal virtual DeleteReplicationGroupResponse DeleteReplicationGroup(DeleteReplicationGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DeleteReplicationGroup">REST API Reference for DeleteReplicationGroup Operation</seealso>
        public virtual Task<DeleteReplicationGroupResponse> DeleteReplicationGroupAsync(DeleteReplicationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReplicationGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSnapshot

        internal virtual DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        public virtual Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCacheClusters

        internal virtual DescribeCacheClustersResponse DescribeCacheClusters()
        {
            return DescribeCacheClusters(new DescribeCacheClustersRequest());
        }
        internal virtual DescribeCacheClustersResponse DescribeCacheClusters(DescribeCacheClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCacheClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeCacheClustersResponse>(request, options);
        }


        /// <summary>
        /// Returns information about all provisioned clusters if no cluster identifier is specified,
        /// or about a specific cache cluster if a cluster identifier is supplied.
        /// 
        ///  
        /// <para>
        /// By default, abbreviated information about the clusters is returned. You can use the
        /// optional <i>ShowCacheNodeInfo</i> flag to retrieve detailed information about the
        /// cache nodes associated with the clusters. These details include the DNS address and
        /// port for the cache node endpoint.
        /// </para>
        ///  
        /// <para>
        /// If the cluster is in the <i>creating</i> state, only cluster-level information is
        /// displayed until all of the nodes are successfully provisioned.
        /// </para>
        ///  
        /// <para>
        /// If the cluster is in the <i>deleting</i> state, only cluster-level information is
        /// displayed.
        /// </para>
        ///  
        /// <para>
        /// If cache nodes are currently being added to the cluster, node endpoint information
        /// and creation time for the additional nodes are not displayed until they are completely
        /// provisioned. When the cluster state is <i>available</i>, the cluster is ready for
        /// use.
        /// </para>
        ///  
        /// <para>
        /// If cache nodes are currently being removed from the cluster, no endpoint information
        /// for the removed nodes is displayed.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCacheClusters service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheClusters">REST API Reference for DescribeCacheClusters Operation</seealso>
        public virtual Task<DescribeCacheClustersResponse> DescribeCacheClustersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeCacheClustersAsync(new DescribeCacheClustersRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheClusters">REST API Reference for DescribeCacheClusters Operation</seealso>
        public virtual Task<DescribeCacheClustersResponse> DescribeCacheClustersAsync(DescribeCacheClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCacheClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCacheClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCacheEngineVersions

        internal virtual DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions()
        {
            return DescribeCacheEngineVersions(new DescribeCacheEngineVersionsRequest());
        }
        internal virtual DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCacheEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheEngineVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeCacheEngineVersionsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the available cache engines and their versions.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by ElastiCache.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheEngineVersions">REST API Reference for DescribeCacheEngineVersions Operation</seealso>
        public virtual Task<DescribeCacheEngineVersionsResponse> DescribeCacheEngineVersionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeCacheEngineVersionsAsync(new DescribeCacheEngineVersionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheEngineVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheEngineVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheEngineVersions">REST API Reference for DescribeCacheEngineVersions Operation</seealso>
        public virtual Task<DescribeCacheEngineVersionsResponse> DescribeCacheEngineVersionsAsync(DescribeCacheEngineVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCacheEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheEngineVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCacheEngineVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCacheParameterGroups

        internal virtual DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups()
        {
            return DescribeCacheParameterGroups(new DescribeCacheParameterGroupsRequest());
        }
        internal virtual DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCacheParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeCacheParameterGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of cache parameter group descriptions. If a cache parameter group name
        /// is specified, the list contains only the descriptions for that group.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCacheParameterGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheParameterGroups">REST API Reference for DescribeCacheParameterGroups Operation</seealso>
        public virtual Task<DescribeCacheParameterGroupsResponse> DescribeCacheParameterGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeCacheParameterGroupsAsync(new DescribeCacheParameterGroupsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheParameterGroups">REST API Reference for DescribeCacheParameterGroups Operation</seealso>
        public virtual Task<DescribeCacheParameterGroupsResponse> DescribeCacheParameterGroupsAsync(DescribeCacheParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCacheParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheParameterGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCacheParameterGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCacheParameters

        internal virtual DescribeCacheParametersResponse DescribeCacheParameters(DescribeCacheParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCacheParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeCacheParametersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheParameters">REST API Reference for DescribeCacheParameters Operation</seealso>
        public virtual Task<DescribeCacheParametersResponse> DescribeCacheParametersAsync(DescribeCacheParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCacheParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCacheParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCacheSecurityGroups

        internal virtual DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups()
        {
            return DescribeCacheSecurityGroups(new DescribeCacheSecurityGroupsRequest());
        }
        internal virtual DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCacheSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeCacheSecurityGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of cache security group descriptions. If a cache security group name
        /// is specified, the list contains only the description of that group.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCacheSecurityGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheSecurityGroups">REST API Reference for DescribeCacheSecurityGroups Operation</seealso>
        public virtual Task<DescribeCacheSecurityGroupsResponse> DescribeCacheSecurityGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeCacheSecurityGroupsAsync(new DescribeCacheSecurityGroupsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheSecurityGroups">REST API Reference for DescribeCacheSecurityGroups Operation</seealso>
        public virtual Task<DescribeCacheSecurityGroupsResponse> DescribeCacheSecurityGroupsAsync(DescribeCacheSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCacheSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCacheSecurityGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCacheSubnetGroups

        internal virtual DescribeCacheSubnetGroupsResponse DescribeCacheSubnetGroups()
        {
            return DescribeCacheSubnetGroups(new DescribeCacheSubnetGroupsRequest());
        }
        internal virtual DescribeCacheSubnetGroupsResponse DescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCacheSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeCacheSubnetGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of cache subnet group descriptions. If a subnet group name is specified,
        /// the list contains only the description of that group.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheSubnetGroups">REST API Reference for DescribeCacheSubnetGroups Operation</seealso>
        public virtual Task<DescribeCacheSubnetGroupsResponse> DescribeCacheSubnetGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeCacheSubnetGroupsAsync(new DescribeCacheSubnetGroupsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheSubnetGroups">REST API Reference for DescribeCacheSubnetGroups Operation</seealso>
        public virtual Task<DescribeCacheSubnetGroupsResponse> DescribeCacheSubnetGroupsAsync(DescribeCacheSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCacheSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheSubnetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCacheSubnetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEngineDefaultParameters

        internal virtual DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEngineDefaultParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeEngineDefaultParametersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeEngineDefaultParameters">REST API Reference for DescribeEngineDefaultParameters Operation</seealso>
        public virtual Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEngineDefaultParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEngineDefaultParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvents

        internal virtual DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }
        internal virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsResponse>(request, options);
        }


        /// <summary>
        /// Returns events related to clusters, cache security groups, and cache parameter groups.
        /// You can obtain events specific to a particular cluster, cache security group, or cache
        /// parameter group by providing the name as a parameter.
        /// 
        ///  
        /// <para>
        /// By default, only the events occurring within the last hour are returned; however,
        /// you can retrieve up to 14 days' worth of events if necessary.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEventsAsync(new DescribeEventsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReplicationGroups

        internal virtual DescribeReplicationGroupsResponse DescribeReplicationGroups()
        {
            return DescribeReplicationGroups(new DescribeReplicationGroupsRequest());
        }
        internal virtual DescribeReplicationGroupsResponse DescribeReplicationGroups(DescribeReplicationGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a particular replication group. If no identifier is specified,
        /// <code>DescribeReplicationGroups</code> returns information about all replication groups.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is valid for Redis only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReplicationGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeReplicationGroups">REST API Reference for DescribeReplicationGroups Operation</seealso>
        public virtual Task<DescribeReplicationGroupsResponse> DescribeReplicationGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReplicationGroupsAsync(new DescribeReplicationGroupsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeReplicationGroups">REST API Reference for DescribeReplicationGroups Operation</seealso>
        public virtual Task<DescribeReplicationGroupsResponse> DescribeReplicationGroupsAsync(DescribeReplicationGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReplicationGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedCacheNodes

        internal virtual DescribeReservedCacheNodesResponse DescribeReservedCacheNodes()
        {
            return DescribeReservedCacheNodes(new DescribeReservedCacheNodesRequest());
        }
        internal virtual DescribeReservedCacheNodesResponse DescribeReservedCacheNodes(DescribeReservedCacheNodesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedCacheNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedCacheNodesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedCacheNodesResponse>(request, options);
        }


        /// <summary>
        /// Returns information about reserved cache nodes for this account, or about a specified
        /// reserved cache node.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodes service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReservedCacheNodeNotFoundException">
        /// The requested reserved cache node was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeReservedCacheNodes">REST API Reference for DescribeReservedCacheNodes Operation</seealso>
        public virtual Task<DescribeReservedCacheNodesResponse> DescribeReservedCacheNodesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedCacheNodesAsync(new DescribeReservedCacheNodesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedCacheNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeReservedCacheNodes">REST API Reference for DescribeReservedCacheNodes Operation</seealso>
        public virtual Task<DescribeReservedCacheNodesResponse> DescribeReservedCacheNodesAsync(DescribeReservedCacheNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedCacheNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedCacheNodesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedCacheNodesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedCacheNodesOfferings

        internal virtual DescribeReservedCacheNodesOfferingsResponse DescribeReservedCacheNodesOfferings()
        {
            return DescribeReservedCacheNodesOfferings(new DescribeReservedCacheNodesOfferingsRequest());
        }
        internal virtual DescribeReservedCacheNodesOfferingsResponse DescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedCacheNodesOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedCacheNodesOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedCacheNodesOfferingsResponse>(request, options);
        }


        /// <summary>
        /// Lists available reserved cache node offerings.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodesOfferings service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReservedCacheNodesOfferingNotFoundException">
        /// The requested cache node offering does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeReservedCacheNodesOfferings">REST API Reference for DescribeReservedCacheNodesOfferings Operation</seealso>
        public virtual Task<DescribeReservedCacheNodesOfferingsResponse> DescribeReservedCacheNodesOfferingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedCacheNodesOfferingsAsync(new DescribeReservedCacheNodesOfferingsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedCacheNodesOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodesOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeReservedCacheNodesOfferings">REST API Reference for DescribeReservedCacheNodesOfferings Operation</seealso>
        public virtual Task<DescribeReservedCacheNodesOfferingsResponse> DescribeReservedCacheNodesOfferingsAsync(DescribeReservedCacheNodesOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedCacheNodesOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedCacheNodesOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedCacheNodesOfferingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshots

        internal virtual DescribeSnapshotsResponse DescribeSnapshots()
        {
            return DescribeSnapshots(new DescribeSnapshotsRequest());
        }
        internal virtual DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about cluster or replication group snapshots. By default, <code>DescribeSnapshots</code>
        /// lists all of your snapshots; it can optionally describe a single snapshot, or just
        /// the snapshots associated with a particular cache cluster.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is valid for Redis only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotNotFoundException">
        /// The requested snapshot name does not refer to an existing snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        public virtual Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSnapshotsAsync(new DescribeSnapshotsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        public virtual Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  IncreaseReplicaCount

        internal virtual IncreaseReplicaCountResponse IncreaseReplicaCount(IncreaseReplicaCountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IncreaseReplicaCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IncreaseReplicaCountResponseUnmarshaller.Instance;

            return Invoke<IncreaseReplicaCountResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the IncreaseReplicaCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IncreaseReplicaCount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/IncreaseReplicaCount">REST API Reference for IncreaseReplicaCount Operation</seealso>
        public virtual Task<IncreaseReplicaCountResponse> IncreaseReplicaCountAsync(IncreaseReplicaCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IncreaseReplicaCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IncreaseReplicaCountResponseUnmarshaller.Instance;

            return InvokeAsync<IncreaseReplicaCountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAllowedNodeTypeModifications

        internal virtual ListAllowedNodeTypeModificationsResponse ListAllowedNodeTypeModifications(ListAllowedNodeTypeModificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAllowedNodeTypeModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAllowedNodeTypeModificationsResponseUnmarshaller.Instance;

            return Invoke<ListAllowedNodeTypeModificationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAllowedNodeTypeModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAllowedNodeTypeModifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ListAllowedNodeTypeModifications">REST API Reference for ListAllowedNodeTypeModifications Operation</seealso>
        public virtual Task<ListAllowedNodeTypeModificationsResponse> ListAllowedNodeTypeModificationsAsync(ListAllowedNodeTypeModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAllowedNodeTypeModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAllowedNodeTypeModificationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAllowedNodeTypeModificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyCacheCluster

        internal virtual ModifyCacheClusterResponse ModifyCacheCluster(ModifyCacheClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCacheClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCacheClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyCacheClusterResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ModifyCacheCluster">REST API Reference for ModifyCacheCluster Operation</seealso>
        public virtual Task<ModifyCacheClusterResponse> ModifyCacheClusterAsync(ModifyCacheClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCacheClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCacheClusterResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyCacheClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyCacheParameterGroup

        internal virtual ModifyCacheParameterGroupResponse ModifyCacheParameterGroup(ModifyCacheParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCacheParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCacheParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyCacheParameterGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ModifyCacheParameterGroup">REST API Reference for ModifyCacheParameterGroup Operation</seealso>
        public virtual Task<ModifyCacheParameterGroupResponse> ModifyCacheParameterGroupAsync(ModifyCacheParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCacheParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCacheParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyCacheParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyCacheSubnetGroup

        internal virtual ModifyCacheSubnetGroupResponse ModifyCacheSubnetGroup(ModifyCacheSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCacheSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCacheSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyCacheSubnetGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ModifyCacheSubnetGroup">REST API Reference for ModifyCacheSubnetGroup Operation</seealso>
        public virtual Task<ModifyCacheSubnetGroupResponse> ModifyCacheSubnetGroupAsync(ModifyCacheSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCacheSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCacheSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyCacheSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyReplicationGroup

        internal virtual ModifyReplicationGroupResponse ModifyReplicationGroup(ModifyReplicationGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyReplicationGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ModifyReplicationGroup">REST API Reference for ModifyReplicationGroup Operation</seealso>
        public virtual Task<ModifyReplicationGroupResponse> ModifyReplicationGroupAsync(ModifyReplicationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyReplicationGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyReplicationGroupShardConfiguration

        internal virtual ModifyReplicationGroupShardConfigurationResponse ModifyReplicationGroupShardConfiguration(ModifyReplicationGroupShardConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReplicationGroupShardConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationGroupShardConfigurationResponseUnmarshaller.Instance;

            return Invoke<ModifyReplicationGroupShardConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationGroupShardConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationGroupShardConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ModifyReplicationGroupShardConfiguration">REST API Reference for ModifyReplicationGroupShardConfiguration Operation</seealso>
        public virtual Task<ModifyReplicationGroupShardConfigurationResponse> ModifyReplicationGroupShardConfigurationAsync(ModifyReplicationGroupShardConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReplicationGroupShardConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationGroupShardConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyReplicationGroupShardConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurchaseReservedCacheNodesOffering

        internal virtual PurchaseReservedCacheNodesOfferingResponse PurchaseReservedCacheNodesOffering(PurchaseReservedCacheNodesOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedCacheNodesOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedCacheNodesOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedCacheNodesOfferingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedCacheNodesOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedCacheNodesOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/PurchaseReservedCacheNodesOffering">REST API Reference for PurchaseReservedCacheNodesOffering Operation</seealso>
        public virtual Task<PurchaseReservedCacheNodesOfferingResponse> PurchaseReservedCacheNodesOfferingAsync(PurchaseReservedCacheNodesOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedCacheNodesOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedCacheNodesOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseReservedCacheNodesOfferingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootCacheCluster

        internal virtual RebootCacheClusterResponse RebootCacheCluster(RebootCacheClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootCacheClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootCacheClusterResponseUnmarshaller.Instance;

            return Invoke<RebootCacheClusterResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RebootCacheCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootCacheCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/RebootCacheCluster">REST API Reference for RebootCacheCluster Operation</seealso>
        public virtual Task<RebootCacheClusterResponse> RebootCacheClusterAsync(RebootCacheClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootCacheClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootCacheClusterResponseUnmarshaller.Instance;

            return InvokeAsync<RebootCacheClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        internal virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetCacheParameterGroup

        internal virtual ResetCacheParameterGroupResponse ResetCacheParameterGroup(ResetCacheParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetCacheParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetCacheParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetCacheParameterGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResetCacheParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetCacheParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ResetCacheParameterGroup">REST API Reference for ResetCacheParameterGroup Operation</seealso>
        public virtual Task<ResetCacheParameterGroupResponse> ResetCacheParameterGroupAsync(ResetCacheParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetCacheParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetCacheParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ResetCacheParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeCacheSecurityGroupIngress

        internal virtual RevokeCacheSecurityGroupIngressResponse RevokeCacheSecurityGroupIngress(RevokeCacheSecurityGroupIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeCacheSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeCacheSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeCacheSecurityGroupIngressResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeCacheSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeCacheSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/RevokeCacheSecurityGroupIngress">REST API Reference for RevokeCacheSecurityGroupIngress Operation</seealso>
        public virtual Task<RevokeCacheSecurityGroupIngressResponse> RevokeCacheSecurityGroupIngressAsync(RevokeCacheSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeCacheSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeCacheSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeCacheSecurityGroupIngressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestFailover

        internal virtual TestFailoverResponse TestFailover(TestFailoverRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestFailoverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestFailoverResponseUnmarshaller.Instance;

            return Invoke<TestFailoverResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TestFailover operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestFailover operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/TestFailover">REST API Reference for TestFailover Operation</seealso>
        public virtual Task<TestFailoverResponse> TestFailoverAsync(TestFailoverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestFailoverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestFailoverResponseUnmarshaller.Instance;

            return InvokeAsync<TestFailoverResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}