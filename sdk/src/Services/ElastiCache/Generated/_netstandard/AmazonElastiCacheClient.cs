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
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ElastiCache
{
    /// <summary>
    /// <para>Implementation for accessing ElastiCache</para>
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
            : base(new AmazonElastiCacheConfig()) { }

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
            : base(new AmazonElastiCacheConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
        private IElastiCachePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IElastiCachePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ElastiCachePaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonElastiCacheEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonElastiCacheAuthSchemeHandler());
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceResponse>(request, options);
        }



        /// <summary>
        /// A tag is a key-value pair where the key and value are case-sensitive. You can use
        /// tags to categorize and track all your ElastiCache resources, with the exception of
        /// global replication group. When you add or remove tags on replication groups, those
        /// actions will be replicated to all nodes in the replication group. For more information,
        /// see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/IAM.ResourceLevelPermissions.html">Resource-level
        /// permissions</a>.
        /// 
        ///  
        /// <para>
        ///  For example, you can use cost-allocation tags to your ElastiCache resources, Amazon
        /// generates a cost allocation report as a comma-separated value (CSV) file with your
        /// usage and costs aggregated by your tags. You can apply tags that represent business
        /// categories (such as cost centers, application names, or owners) to organize your costs
        /// across multiple services.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/Tagging.html">Using
        /// Cost Allocation Tags in Amazon ElastiCache</a> in the <i>ElastiCache User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidARNException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidServerlessCacheSnapshotStateException">
        /// The state of the serverless cache snapshot was not received. Available for Valkey,
        /// Redis OSS and Serverless Memcached only.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidServerlessCacheStateException">
        /// The account for these credentials is not currently active.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReservedCacheNodeNotFoundException">
        /// The requested reserved cache node was not found.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheNotFoundException">
        /// The serverless cache was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheSnapshotNotFoundException">
        /// This serverless cache snapshot could not be found or does not exist. Available for
        /// Valkey, Redis OSS and Serverless Memcached only.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotNotFoundException">
        /// The requested snapshot name does not refer to an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.TagQuotaPerResourceExceededException">
        /// The request cannot be processed because it would cause the resource to have more than
        /// the allowed number of tags. The maximum number of tags permitted on a resource is
        /// 50.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserGroupNotFoundException">
        /// The user group was not found or does not exist
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserNotFoundException">
        /// The user does not exist or could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AuthorizeCacheSecurityGroupIngress

        internal virtual AuthorizeCacheSecurityGroupIngressResponse AuthorizeCacheSecurityGroupIngress(AuthorizeCacheSecurityGroupIngressRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AuthorizeCacheSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeCacheSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeCacheSecurityGroupIngressResponse>(request, options);
        }



        /// <summary>
        /// Allows network ingress to a cache security group. Applications using ElastiCache must
        /// be running on Amazon EC2, and Amazon EC2 security groups are used as the authorization
        /// mechanism.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot authorize ingress from an Amazon EC2 security group in one region to an
        /// ElastiCache cluster in another region.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeCacheSecurityGroupIngress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AuthorizeCacheSecurityGroupIngress service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.AuthorizationAlreadyExistsException">
        /// The specified Amazon EC2 security group is already authorized for the specified cache
        /// security group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException">
        /// The current state of the cache security group does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/AuthorizeCacheSecurityGroupIngress">REST API Reference for AuthorizeCacheSecurityGroupIngress Operation</seealso>
        public virtual Task<AuthorizeCacheSecurityGroupIngressResponse> AuthorizeCacheSecurityGroupIngressAsync(AuthorizeCacheSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AuthorizeCacheSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeCacheSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeCacheSecurityGroupIngressResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchApplyUpdateAction

        internal virtual BatchApplyUpdateActionResponse BatchApplyUpdateAction(BatchApplyUpdateActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchApplyUpdateActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchApplyUpdateActionResponseUnmarshaller.Instance;

            return Invoke<BatchApplyUpdateActionResponse>(request, options);
        }



        /// <summary>
        /// Apply the service update. For more information on service updates and applying them,
        /// see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/applying-updates.html">Applying
        /// Service Updates</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchApplyUpdateAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchApplyUpdateAction service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceUpdateNotFoundException">
        /// The service update doesn't exist
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/BatchApplyUpdateAction">REST API Reference for BatchApplyUpdateAction Operation</seealso>
        public virtual Task<BatchApplyUpdateActionResponse> BatchApplyUpdateActionAsync(BatchApplyUpdateActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchApplyUpdateActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchApplyUpdateActionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchApplyUpdateActionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchStopUpdateAction

        internal virtual BatchStopUpdateActionResponse BatchStopUpdateAction(BatchStopUpdateActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchStopUpdateActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchStopUpdateActionResponseUnmarshaller.Instance;

            return Invoke<BatchStopUpdateActionResponse>(request, options);
        }



        /// <summary>
        /// Stop the service update. For more information on service updates and stopping them,
        /// see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/stopping-self-service-updates.html">Stopping
        /// Service Updates</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchStopUpdateAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchStopUpdateAction service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceUpdateNotFoundException">
        /// The service update doesn't exist
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/BatchStopUpdateAction">REST API Reference for BatchStopUpdateAction Operation</seealso>
        public virtual Task<BatchStopUpdateActionResponse> BatchStopUpdateActionAsync(BatchStopUpdateActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchStopUpdateActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchStopUpdateActionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchStopUpdateActionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CompleteMigration

        internal virtual CompleteMigrationResponse CompleteMigration(CompleteMigrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CompleteMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteMigrationResponseUnmarshaller.Instance;

            return Invoke<CompleteMigrationResponse>(request, options);
        }



        /// <summary>
        /// Complete the migration of data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteMigration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CompleteMigration service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotUnderMigrationException">
        /// The designated replication group is not available for data migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CompleteMigration">REST API Reference for CompleteMigration Operation</seealso>
        public virtual Task<CompleteMigrationResponse> CompleteMigrationAsync(CompleteMigrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CompleteMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteMigrationResponseUnmarshaller.Instance;

            return InvokeAsync<CompleteMigrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CopyServerlessCacheSnapshot

        internal virtual CopyServerlessCacheSnapshotResponse CopyServerlessCacheSnapshot(CopyServerlessCacheSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyServerlessCacheSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyServerlessCacheSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyServerlessCacheSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a copy of an existing serverless cache’s snapshot. Available for Valkey, Redis
        /// OSS and Serverless Memcached only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyServerlessCacheSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyServerlessCacheSnapshot service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidServerlessCacheSnapshotStateException">
        /// The state of the serverless cache snapshot was not received. Available for Valkey,
        /// Redis OSS and Serverless Memcached only.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheSnapshotAlreadyExistsException">
        /// A serverless cache snapshot with this name already exists. Available for Valkey, Redis
        /// OSS and Serverless Memcached only.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheSnapshotNotFoundException">
        /// This serverless cache snapshot could not be found or does not exist. Available for
        /// Valkey, Redis OSS and Serverless Memcached only.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheSnapshotQuotaExceededException">
        /// The number of serverless cache snapshots exceeds the customer snapshot quota. Available
        /// for Valkey, Redis OSS and Serverless Memcached only.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.TagQuotaPerResourceExceededException">
        /// The request cannot be processed because it would cause the resource to have more than
        /// the allowed number of tags. The maximum number of tags permitted on a resource is
        /// 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CopyServerlessCacheSnapshot">REST API Reference for CopyServerlessCacheSnapshot Operation</seealso>
        public virtual Task<CopyServerlessCacheSnapshotResponse> CopyServerlessCacheSnapshotAsync(CopyServerlessCacheSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyServerlessCacheSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyServerlessCacheSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopyServerlessCacheSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CopySnapshot

        internal virtual CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopySnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return Invoke<CopySnapshotResponse>(request, options);
        }



        /// <summary>
        /// Makes a copy of an existing snapshot.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is valid for Valkey or Redis OSS only.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Users or groups that have permissions to use the <c>CopySnapshot</c> operation can
        /// create their own Amazon S3 buckets and copy snapshots to it. To control access to
        /// your snapshots, use an IAM policy to control who has the ability to use the <c>CopySnapshot</c>
        /// operation. For more information about using IAM to control the use of ElastiCache
        /// operations, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/backups-exporting.html">Exporting
        /// Snapshots</a> and <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/IAM.html">Authentication
        /// &amp; Access Control</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// You could receive the following error messages.
        /// </para>
        ///  
        /// <para>
        ///  <b>Error Messages</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Error Message:</b> The S3 bucket %s is outside of the region.
        /// </para>
        ///  
        /// <para>
        ///  <b>Solution:</b> Create an Amazon S3 bucket in the same region as your snapshot.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/backups-exporting.html#backups-exporting-create-s3-bucket">Step
        /// 1: Create an Amazon S3 Bucket</a> in the ElastiCache User Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Error Message:</b> The S3 bucket %s does not exist.
        /// </para>
        ///  
        /// <para>
        ///  <b>Solution:</b> Create an Amazon S3 bucket in the same region as your snapshot.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/backups-exporting.html#backups-exporting-create-s3-bucket">Step
        /// 1: Create an Amazon S3 Bucket</a> in the ElastiCache User Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Error Message:</b> The S3 bucket %s is not owned by the authenticated user.
        /// </para>
        ///  
        /// <para>
        ///  <b>Solution:</b> Create an Amazon S3 bucket in the same region as your snapshot.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/backups-exporting.html#backups-exporting-create-s3-bucket">Step
        /// 1: Create an Amazon S3 Bucket</a> in the ElastiCache User Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Error Message:</b> The authenticated user does not have sufficient permissions
        /// to perform the desired activity.
        /// </para>
        ///  
        /// <para>
        ///  <b>Solution:</b> Contact your system administrator to get the needed permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Error Message:</b> The S3 bucket %s already contains an object with key %s.
        /// </para>
        ///  
        /// <para>
        ///  <b>Solution:</b> Give the <c>TargetSnapshotName</c> a new and unique value. If exporting
        /// a snapshot, you could alternatively create a new Amazon S3 bucket and use this same
        /// value for <c>TargetSnapshotName</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Error Message: </b> ElastiCache has not been granted READ permissions %s on the
        /// S3 Bucket.
        /// </para>
        ///  
        /// <para>
        ///  <b>Solution:</b> Add List and Read permissions on the bucket. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/backups-exporting.html#backups-exporting-grant-access">Step
        /// 2: Grant ElastiCache Access to Your Amazon S3 Bucket</a> in the ElastiCache User Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Error Message: </b> ElastiCache has not been granted WRITE permissions %s on the
        /// S3 Bucket.
        /// </para>
        ///  
        /// <para>
        ///  <b>Solution:</b> Add Upload/Delete permissions on the bucket. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/backups-exporting.html#backups-exporting-grant-access">Step
        /// 2: Grant ElastiCache Access to Your Amazon S3 Bucket</a> in the ElastiCache User Guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Error Message: </b> ElastiCache has not been granted READ_ACP permissions %s on
        /// the S3 Bucket.
        /// </para>
        ///  
        /// <para>
        ///  <b>Solution:</b> Add View Permissions on the bucket. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/backups-exporting.html#backups-exporting-grant-access">Step
        /// 2: Grant ElastiCache Access to Your Amazon S3 Bucket</a> in the ElastiCache User Guide.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopySnapshot service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidSnapshotStateException">
        /// The current state of the snapshot does not allow the requested operation to occur.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotAlreadyExistsException">
        /// You already have a snapshot with the given name.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotNotFoundException">
        /// The requested snapshot name does not refer to an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum number of snapshots.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.TagQuotaPerResourceExceededException">
        /// The request cannot be processed because it would cause the resource to have more than
        /// the allowed number of tags. The maximum number of tags permitted on a resource is
        /// 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
        public virtual Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopySnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopySnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCacheCluster

        internal virtual CreateCacheClusterResponse CreateCacheCluster(CreateCacheClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCacheClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCacheClusterResponseUnmarshaller.Instance;

            return Invoke<CreateCacheClusterResponse>(request, options);
        }



        /// <summary>
        /// Creates a cluster. All nodes in the cluster run the same protocol-compliant cache
        /// engine software, either Memcached, Valkey or Redis OSS.
        /// 
        ///  
        /// <para>
        /// This operation is not supported for Valkey or Redis OSS (cluster mode enabled) clusters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCacheCluster service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterAlreadyExistsException">
        /// You already have a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ClusterQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of clusters
        /// per customer.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InsufficientCacheClusterCapacityException">
        /// The requested cache node type is not available in the specified Availability Zone.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/ErrorMessages.html#ErrorMessages.INSUFFICIENT_CACHE_CLUSTER_CAPACITY">InsufficientCacheClusterCapacity</a>
        /// in the ElastiCache User Guide.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidVPCNetworkStateException">
        /// The VPC network is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeQuotaForClusterExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes in a single cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes per customer.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.TagQuotaPerResourceExceededException">
        /// The request cannot be processed because it would cause the resource to have more than
        /// the allowed number of tags. The maximum number of tags permitted on a resource is
        /// 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CreateCacheCluster">REST API Reference for CreateCacheCluster Operation</seealso>
        public virtual Task<CreateCacheClusterResponse> CreateCacheClusterAsync(CreateCacheClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCacheClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCacheClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCacheClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCacheParameterGroup

        internal virtual CreateCacheParameterGroupResponse CreateCacheParameterGroup(CreateCacheParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCacheParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCacheParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateCacheParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Amazon ElastiCache cache parameter group. An ElastiCache cache parameter
        /// group is a collection of parameters and their values that are applied to all of the
        /// nodes in any cluster or replication group using the CacheParameterGroup.
        /// 
        ///  
        /// <para>
        /// A newly created CacheParameterGroup is an exact duplicate of the default parameter
        /// group for the CacheParameterGroupFamily. To customize the newly created CacheParameterGroup
        /// you can change the values of specific parameters. For more information, see:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/APIReference/API_ModifyCacheParameterGroup.html">ModifyCacheParameterGroup</a>
        /// in the ElastiCache API Reference.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/ParameterGroups.html">Parameters
        /// and Parameter Groups</a> in the ElastiCache User Guide.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCacheParameterGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheParameterGroupAlreadyExistsException">
        /// A cache parameter group with the requested name already exists.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheParameterGroupQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum number of cache
        /// security groups.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException">
        /// The current state of the cache parameter group does not allow the requested operation
        /// to occur.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.TagQuotaPerResourceExceededException">
        /// The request cannot be processed because it would cause the resource to have more than
        /// the allowed number of tags. The maximum number of tags permitted on a resource is
        /// 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CreateCacheParameterGroup">REST API Reference for CreateCacheParameterGroup Operation</seealso>
        public virtual Task<CreateCacheParameterGroupResponse> CreateCacheParameterGroupAsync(CreateCacheParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCacheParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCacheParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCacheParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCacheSecurityGroup

        internal virtual CreateCacheSecurityGroupResponse CreateCacheSecurityGroup(CreateCacheSecurityGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCacheSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCacheSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateCacheSecurityGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new cache security group. Use a cache security group to control access to
        /// one or more clusters.
        /// 
        ///  
        /// <para>
        /// Cache security groups are only used when you are creating a cluster outside of an
        /// Amazon Virtual Private Cloud (Amazon VPC). If you are creating a cluster inside of
        /// a VPC, use a cache subnet group instead. For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/APIReference/API_CreateCacheSubnetGroup.html">CreateCacheSubnetGroup</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCacheSecurityGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSecurityGroupAlreadyExistsException">
        /// A cache security group with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSecurityGroupQuotaExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// security groups.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.TagQuotaPerResourceExceededException">
        /// The request cannot be processed because it would cause the resource to have more than
        /// the allowed number of tags. The maximum number of tags permitted on a resource is
        /// 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CreateCacheSecurityGroup">REST API Reference for CreateCacheSecurityGroup Operation</seealso>
        public virtual Task<CreateCacheSecurityGroupResponse> CreateCacheSecurityGroupAsync(CreateCacheSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCacheSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCacheSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCacheSecurityGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCacheSubnetGroup

        internal virtual CreateCacheSubnetGroupResponse CreateCacheSubnetGroup(CreateCacheSubnetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCacheSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCacheSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateCacheSubnetGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new cache subnet group.
        /// 
        ///  
        /// <para>
        /// Use this parameter only when you are creating a cluster in an Amazon Virtual Private
        /// Cloud (Amazon VPC).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCacheSubnetGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetGroupAlreadyExistsException">
        /// The requested cache subnet group name is already in use by an existing cache subnet
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetGroupQuotaExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// subnet groups.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetQuotaExceededException">
        /// The request cannot be processed because it would exceed the allowed number of subnets
        /// in a cache subnet group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidSubnetException">
        /// An invalid subnet identifier was specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SubnetNotAllowedException">
        /// At least one subnet ID does not match the other subnet IDs. This mismatch typically
        /// occurs when a user sets one subnet ID to a regional Availability Zone and a different
        /// one to an outpost. Or when a user sets the subnet ID to an Outpost when not subscribed
        /// on this service.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.TagQuotaPerResourceExceededException">
        /// The request cannot be processed because it would cause the resource to have more than
        /// the allowed number of tags. The maximum number of tags permitted on a resource is
        /// 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CreateCacheSubnetGroup">REST API Reference for CreateCacheSubnetGroup Operation</seealso>
        public virtual Task<CreateCacheSubnetGroupResponse> CreateCacheSubnetGroupAsync(CreateCacheSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCacheSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCacheSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCacheSubnetGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGlobalReplicationGroup

        internal virtual CreateGlobalReplicationGroupResponse CreateGlobalReplicationGroup(CreateGlobalReplicationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlobalReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalReplicationGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGlobalReplicationGroupResponse>(request, options);
        }



        /// <summary>
        /// Global Datastore offers fully managed, fast, reliable and secure cross-region replication.
        /// Using Global Datastore with Valkey or Redis OSS, you can create cross-region read
        /// replica clusters for ElastiCache to enable low-latency reads and disaster recovery
        /// across regions. For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/Redis-Global-Datastore.html">Replication
        /// Across Regions Using Global Datastore</a>. 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <b>GlobalReplicationGroupIdSuffix</b> is the name of the Global datastore.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <b>PrimaryReplicationGroupId</b> represents the name of the primary cluster that
        /// accepts writes and will replicate updates to the secondary cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalReplicationGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGlobalReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.GlobalReplicationGroupAlreadyExistsException">
        /// The Global datastore name already exists.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CreateGlobalReplicationGroup">REST API Reference for CreateGlobalReplicationGroup Operation</seealso>
        public virtual Task<CreateGlobalReplicationGroupResponse> CreateGlobalReplicationGroupAsync(CreateGlobalReplicationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlobalReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalReplicationGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGlobalReplicationGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateReplicationGroup

        internal virtual CreateReplicationGroupResponse CreateReplicationGroup(CreateReplicationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationGroupResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a Valkey or Redis OSS (cluster mode disabled) or a Valkey or Redis OSS (cluster
        /// mode enabled) replication group.
        /// 
        ///  
        /// <para>
        /// This API can be used to create a standalone regional replication group or a secondary
        /// replication group associated with a Global datastore.
        /// </para>
        ///  
        /// <para>
        /// A Valkey or Redis OSS (cluster mode disabled) replication group is a collection of
        /// nodes, where one of the nodes is a read/write primary and the others are read-only
        /// replicas. Writes to the primary are asynchronously propagated to the replicas.
        /// </para>
        ///  
        /// <para>
        /// A Valkey or Redis OSS cluster-mode enabled cluster is comprised of from 1 to 90 shards
        /// (API/CLI: node groups). Each shard has a primary node and up to 5 read-only replica
        /// nodes. The configuration can range from 90 shards and 0 replicas to 15 shards and
        /// 5 replicas, which is the maximum number or replicas allowed. 
        /// </para>
        ///  
        /// <para>
        /// The node or shard limit can be increased to a maximum of 500 per cluster if the Valkey
        /// or Redis OSS engine version is 5.0.6 or higher. For example, you can choose to configure
        /// a 500 node cluster that ranges between 83 shards (one primary and 5 replicas per shard)
        /// and 500 shards (single primary and no replicas). Make sure there are enough available
        /// IP addresses to accommodate the increase. Common pitfalls include the subnets in the
        /// subnet group have too small a CIDR range or the subnets are shared and heavily used
        /// by other clusters. For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/SubnetGroups.Creating.html">Creating
        /// a Subnet Group</a>. For versions below 5.0.6, the limit is 250 per cluster.
        /// </para>
        ///  
        /// <para>
        /// To request a limit increase, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">Amazon
        /// Service Limits</a> and choose the limit type <b>Nodes per cluster per instance type</b>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// When a Valkey or Redis OSS (cluster mode disabled) replication group has been successfully
        /// created, you can add one or more read replicas to it, up to a total of 5 read replicas.
        /// If you need to increase or decrease the number of node groups (console: shards), you
        /// can use scaling. For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/Scaling.html">Scaling
        /// self-designed clusters</a> in the <i>ElastiCache User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is valid for Valkey and Redis OSS only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ClusterQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of clusters
        /// per customer.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.GlobalReplicationGroupNotFoundException">
        /// The Global datastore does not exist
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InsufficientCacheClusterCapacityException">
        /// The requested cache node type is not available in the specified Availability Zone.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/ErrorMessages.html#ErrorMessages.INSUFFICIENT_CACHE_CLUSTER_CAPACITY">InsufficientCacheClusterCapacity</a>
        /// in the ElastiCache User Guide.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidGlobalReplicationGroupStateException">
        /// The Global datastore is not available or in primary-only state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidUserGroupStateException">
        /// The user group is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidVPCNetworkStateException">
        /// The VPC network is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeGroupsPerReplicationGroupQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum allowed number
        /// of node groups (shards) in a single replication group. The default maximum is 90
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeQuotaForClusterExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes in a single cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes per customer.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupAlreadyExistsException">
        /// The specified replication group already exists.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.TagQuotaPerResourceExceededException">
        /// The request cannot be processed because it would cause the resource to have more than
        /// the allowed number of tags. The maximum number of tags permitted on a resource is
        /// 50.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserGroupNotFoundException">
        /// The user group was not found or does not exist
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CreateReplicationGroup">REST API Reference for CreateReplicationGroup Operation</seealso>
        public virtual Task<CreateReplicationGroupResponse> CreateReplicationGroupAsync(CreateReplicationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReplicationGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateServerlessCache

        internal virtual CreateServerlessCacheResponse CreateServerlessCache(CreateServerlessCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateServerlessCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServerlessCacheResponseUnmarshaller.Instance;

            return Invoke<CreateServerlessCacheResponse>(request, options);
        }



        /// <summary>
        /// Creates a serverless cache.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServerlessCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateServerlessCache service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCredentialsException">
        /// You must enter valid credentials.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidServerlessCacheStateException">
        /// The account for these credentials is not currently active.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidUserGroupStateException">
        /// The user group is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheAlreadyExistsException">
        /// A serverless cache with this name already exists.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheNotFoundException">
        /// The serverless cache was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheQuotaForCustomerExceededException">
        /// The number of serverless caches exceeds the customer quota.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.TagQuotaPerResourceExceededException">
        /// The request cannot be processed because it would cause the resource to have more than
        /// the allowed number of tags. The maximum number of tags permitted on a resource is
        /// 50.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserGroupNotFoundException">
        /// The user group was not found or does not exist
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CreateServerlessCache">REST API Reference for CreateServerlessCache Operation</seealso>
        public virtual Task<CreateServerlessCacheResponse> CreateServerlessCacheAsync(CreateServerlessCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateServerlessCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServerlessCacheResponseUnmarshaller.Instance;

            return InvokeAsync<CreateServerlessCacheResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateServerlessCacheSnapshot

        internal virtual CreateServerlessCacheSnapshotResponse CreateServerlessCacheSnapshot(CreateServerlessCacheSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateServerlessCacheSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServerlessCacheSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateServerlessCacheSnapshotResponse>(request, options);
        }



        /// <summary>
        /// This API creates a copy of an entire ServerlessCache at a specific moment in time.
        /// Available for Valkey, Redis OSS and Serverless Memcached only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServerlessCacheSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateServerlessCacheSnapshot service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidServerlessCacheStateException">
        /// The account for these credentials is not currently active.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheNotFoundException">
        /// The serverless cache was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheSnapshotAlreadyExistsException">
        /// A serverless cache snapshot with this name already exists. Available for Valkey, Redis
        /// OSS and Serverless Memcached only.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheSnapshotQuotaExceededException">
        /// The number of serverless cache snapshots exceeds the customer snapshot quota. Available
        /// for Valkey, Redis OSS and Serverless Memcached only.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.TagQuotaPerResourceExceededException">
        /// The request cannot be processed because it would cause the resource to have more than
        /// the allowed number of tags. The maximum number of tags permitted on a resource is
        /// 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CreateServerlessCacheSnapshot">REST API Reference for CreateServerlessCacheSnapshot Operation</seealso>
        public virtual Task<CreateServerlessCacheSnapshotResponse> CreateServerlessCacheSnapshotAsync(CreateServerlessCacheSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateServerlessCacheSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServerlessCacheSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateServerlessCacheSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSnapshot

        internal virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a copy of an entire cluster or replication group at a specific moment in time.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is valid for Valkey or Redis OSS only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotAlreadyExistsException">
        /// You already have a snapshot with the given name.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotFeatureNotSupportedException">
        /// You attempted one of the following operations:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Creating a snapshot of a Valkey or Redis OSS cluster running on a <c>cache.t1.micro</c>
        /// cache node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Creating a snapshot of a cluster that is running Memcached rather than Valkey or Redis
        /// OSS.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Neither of these are supported by ElastiCache.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum number of snapshots.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.TagQuotaPerResourceExceededException">
        /// The request cannot be processed because it would cause the resource to have more than
        /// the allowed number of tags. The maximum number of tags permitted on a resource is
        /// 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateUser

        internal virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserResponse>(request, options);
        }



        /// <summary>
        /// For Valkey engine version 7.2 onwards and Redis OSS 6.0 to 7.1: Creates a user. For
        /// more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/Clusters.RBAC.html">Using
        /// Role Based Access Control (RBAC)</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.DuplicateUserNameException">
        /// A user with this username already exists.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.TagQuotaPerResourceExceededException">
        /// The request cannot be processed because it would cause the resource to have more than
        /// the allowed number of tags. The maximum number of tags permitted on a resource is
        /// 50.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserAlreadyExistsException">
        /// A user with this ID already exists.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserQuotaExceededException">
        /// The quota of users has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateUserGroup

        internal virtual CreateUserGroupResponse CreateUserGroup(CreateUserGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserGroupResponseUnmarshaller.Instance;

            return Invoke<CreateUserGroupResponse>(request, options);
        }



        /// <summary>
        /// For Valkey engine version 7.2 onwards and Redis OSS 6.0 to 7.1: Creates a user group.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/Clusters.RBAC.html">Using
        /// Role Based Access Control (RBAC)</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUserGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.DefaultUserRequiredException">
        /// You must add default user to a user group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.DuplicateUserNameException">
        /// A user with this username already exists.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.TagQuotaPerResourceExceededException">
        /// The request cannot be processed because it would cause the resource to have more than
        /// the allowed number of tags. The maximum number of tags permitted on a resource is
        /// 50.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserGroupAlreadyExistsException">
        /// The user group with this ID already exists.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserGroupQuotaExceededException">
        /// The number of users exceeds the user group limit.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserNotFoundException">
        /// The user does not exist or could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/CreateUserGroup">REST API Reference for CreateUserGroup Operation</seealso>
        public virtual Task<CreateUserGroupResponse> CreateUserGroupAsync(CreateUserGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DecreaseNodeGroupsInGlobalReplicationGroup

        internal virtual DecreaseNodeGroupsInGlobalReplicationGroupResponse DecreaseNodeGroupsInGlobalReplicationGroup(DecreaseNodeGroupsInGlobalReplicationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DecreaseNodeGroupsInGlobalReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecreaseNodeGroupsInGlobalReplicationGroupResponseUnmarshaller.Instance;

            return Invoke<DecreaseNodeGroupsInGlobalReplicationGroupResponse>(request, options);
        }



        /// <summary>
        /// Decreases the number of node groups in a Global datastore
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DecreaseNodeGroupsInGlobalReplicationGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DecreaseNodeGroupsInGlobalReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.GlobalReplicationGroupNotFoundException">
        /// The Global datastore does not exist
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidGlobalReplicationGroupStateException">
        /// The Global datastore is not available or in primary-only state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DecreaseNodeGroupsInGlobalReplicationGroup">REST API Reference for DecreaseNodeGroupsInGlobalReplicationGroup Operation</seealso>
        public virtual Task<DecreaseNodeGroupsInGlobalReplicationGroupResponse> DecreaseNodeGroupsInGlobalReplicationGroupAsync(DecreaseNodeGroupsInGlobalReplicationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DecreaseNodeGroupsInGlobalReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecreaseNodeGroupsInGlobalReplicationGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DecreaseNodeGroupsInGlobalReplicationGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DecreaseReplicaCount

        internal virtual DecreaseReplicaCountResponse DecreaseReplicaCount(DecreaseReplicaCountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DecreaseReplicaCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecreaseReplicaCountResponseUnmarshaller.Instance;

            return Invoke<DecreaseReplicaCountResponse>(request, options);
        }



        /// <summary>
        /// Dynamically decreases the number of replicas in a Valkey or Redis OSS (cluster mode
        /// disabled) replication group or the number of replica nodes in one or more node groups
        /// (shards) of a Valkey or Redis OSS (cluster mode enabled) replication group. This operation
        /// is performed with no cluster down time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DecreaseReplicaCount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DecreaseReplicaCount service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.ClusterQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of clusters
        /// per customer.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InsufficientCacheClusterCapacityException">
        /// The requested cache node type is not available in the specified Availability Zone.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/ErrorMessages.html#ErrorMessages.INSUFFICIENT_CACHE_CLUSTER_CAPACITY">InsufficientCacheClusterCapacity</a>
        /// in the ElastiCache User Guide.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidVPCNetworkStateException">
        /// The VPC network is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeGroupsPerReplicationGroupQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum allowed number
        /// of node groups (shards) in a single replication group. The default maximum is 90
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes per customer.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NoOperationException">
        /// The operation was not performed because no changes were required.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DecreaseReplicaCount">REST API Reference for DecreaseReplicaCount Operation</seealso>
        public virtual Task<DecreaseReplicaCountResponse> DecreaseReplicaCountAsync(DecreaseReplicaCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DecreaseReplicaCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecreaseReplicaCountResponseUnmarshaller.Instance;

            return InvokeAsync<DecreaseReplicaCountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCacheCluster

        internal virtual DeleteCacheClusterResponse DeleteCacheCluster(DeleteCacheClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCacheClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCacheClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteCacheClusterResponse>(request, options);
        }



        /// <summary>
        /// Deletes a previously provisioned cluster. <c>DeleteCacheCluster</c> deletes all associated
        /// cache nodes, node endpoints and the cluster itself. When you receive a successful
        /// response from this operation, Amazon ElastiCache immediately begins deleting the cluster;
        /// you cannot cancel or revert this operation.
        /// 
        ///  
        /// <para>
        /// This operation is not valid for:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Valkey or Redis OSS (cluster mode enabled) clusters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valkey or Redis OSS (cluster mode disabled) clusters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster that is the last read replica of a replication group
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster that is the primary node of a replication group
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A node group (shard) that has Multi-AZ mode enabled
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster from a Valkey or Redis OSS (cluster mode enabled) replication group
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster that is not in the <c>available</c> state
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCacheCluster service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotAlreadyExistsException">
        /// You already have a snapshot with the given name.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotFeatureNotSupportedException">
        /// You attempted one of the following operations:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Creating a snapshot of a Valkey or Redis OSS cluster running on a <c>cache.t1.micro</c>
        /// cache node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Creating a snapshot of a cluster that is running Memcached rather than Valkey or Redis
        /// OSS.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Neither of these are supported by ElastiCache.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum number of snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DeleteCacheCluster">REST API Reference for DeleteCacheCluster Operation</seealso>
        public virtual Task<DeleteCacheClusterResponse> DeleteCacheClusterAsync(DeleteCacheClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCacheClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCacheClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCacheClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCacheParameterGroup

        internal virtual DeleteCacheParameterGroupResponse DeleteCacheParameterGroup(DeleteCacheParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCacheParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCacheParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteCacheParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified cache parameter group. You cannot delete a cache parameter group
        /// if it is associated with any cache clusters. You cannot delete the default cache parameter
        /// groups in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCacheParameterGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException">
        /// The current state of the cache parameter group does not allow the requested operation
        /// to occur.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DeleteCacheParameterGroup">REST API Reference for DeleteCacheParameterGroup Operation</seealso>
        public virtual Task<DeleteCacheParameterGroupResponse> DeleteCacheParameterGroupAsync(DeleteCacheParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCacheParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCacheParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCacheParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCacheSecurityGroup

        internal virtual DeleteCacheSecurityGroupResponse DeleteCacheSecurityGroup(DeleteCacheSecurityGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCacheSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCacheSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteCacheSecurityGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a cache security group.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete a cache security group if it is associated with any clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCacheSecurityGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException">
        /// The current state of the cache security group does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DeleteCacheSecurityGroup">REST API Reference for DeleteCacheSecurityGroup Operation</seealso>
        public virtual Task<DeleteCacheSecurityGroupResponse> DeleteCacheSecurityGroupAsync(DeleteCacheSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCacheSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCacheSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCacheSecurityGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCacheSubnetGroup

        internal virtual DeleteCacheSubnetGroupResponse DeleteCacheSubnetGroup(DeleteCacheSubnetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCacheSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCacheSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteCacheSubnetGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a cache subnet group.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete a default cache subnet group or one that is associated with any
        /// clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCacheSubnetGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetGroupInUseException">
        /// The requested cache subnet group is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DeleteCacheSubnetGroup">REST API Reference for DeleteCacheSubnetGroup Operation</seealso>
        public virtual Task<DeleteCacheSubnetGroupResponse> DeleteCacheSubnetGroupAsync(DeleteCacheSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCacheSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCacheSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCacheSubnetGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteGlobalReplicationGroup

        internal virtual DeleteGlobalReplicationGroupResponse DeleteGlobalReplicationGroup(DeleteGlobalReplicationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlobalReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlobalReplicationGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGlobalReplicationGroupResponse>(request, options);
        }



        /// <summary>
        /// Deleting a Global datastore is a two-step process: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// First, you must <a>DisassociateGlobalReplicationGroup</a> to remove the secondary
        /// clusters in the Global datastore.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Once the Global datastore contains only the primary cluster, you can use the <c>DeleteGlobalReplicationGroup</c>
        /// API to delete the Global datastore while retainining the primary cluster using <c>RetainPrimaryReplicationGroup=true</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Since the Global Datastore has only a primary cluster, you can delete the Global Datastore
        /// while retaining the primary by setting <c>RetainPrimaryReplicationGroup=true</c>.
        /// The primary cluster is never deleted when deleting a Global Datastore. It can only
        /// be deleted when it no longer is associated with any Global Datastore.
        /// </para>
        ///  
        /// <para>
        /// When you receive a successful response from this operation, Amazon ElastiCache immediately
        /// begins deleting the selected resources; you cannot cancel or revert this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlobalReplicationGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGlobalReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.GlobalReplicationGroupNotFoundException">
        /// The Global datastore does not exist
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidGlobalReplicationGroupStateException">
        /// The Global datastore is not available or in primary-only state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DeleteGlobalReplicationGroup">REST API Reference for DeleteGlobalReplicationGroup Operation</seealso>
        public virtual Task<DeleteGlobalReplicationGroupResponse> DeleteGlobalReplicationGroupAsync(DeleteGlobalReplicationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlobalReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlobalReplicationGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGlobalReplicationGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteReplicationGroup

        internal virtual DeleteReplicationGroupResponse DeleteReplicationGroup(DeleteReplicationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing replication group. By default, this operation deletes the entire
        /// replication group, including the primary/primaries and all of the read replicas. If
        /// the replication group has only one primary, you can optionally delete only the read
        /// replicas, while retaining the primary by setting <c>RetainPrimaryCluster=true</c>.
        /// 
        ///  
        /// <para>
        /// When you receive a successful response from this operation, Amazon ElastiCache immediately
        /// begins deleting the selected resources; you cannot cancel or revert this operation.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        ///  <c>CreateSnapshot</c> permission is required to create a final snapshot. Without
        /// this permission, the API call will fail with an <c>Access Denied</c> exception.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This operation is valid for Redis OSS only.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotAlreadyExistsException">
        /// You already have a snapshot with the given name.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotFeatureNotSupportedException">
        /// You attempted one of the following operations:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Creating a snapshot of a Valkey or Redis OSS cluster running on a <c>cache.t1.micro</c>
        /// cache node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Creating a snapshot of a cluster that is running Memcached rather than Valkey or Redis
        /// OSS.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Neither of these are supported by ElastiCache.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum number of snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DeleteReplicationGroup">REST API Reference for DeleteReplicationGroup Operation</seealso>
        public virtual Task<DeleteReplicationGroupResponse> DeleteReplicationGroupAsync(DeleteReplicationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReplicationGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteServerlessCache

        internal virtual DeleteServerlessCacheResponse DeleteServerlessCache(DeleteServerlessCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServerlessCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServerlessCacheResponseUnmarshaller.Instance;

            return Invoke<DeleteServerlessCacheResponse>(request, options);
        }



        /// <summary>
        /// Deletes a specified existing serverless cache.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>CreateServerlessCacheSnapshot</c> permission is required to create a final snapshot.
        /// Without this permission, the API call will fail with an <c>Access Denied</c> exception.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerlessCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServerlessCache service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCredentialsException">
        /// You must enter valid credentials.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidServerlessCacheStateException">
        /// The account for these credentials is not currently active.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheNotFoundException">
        /// The serverless cache was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheSnapshotAlreadyExistsException">
        /// A serverless cache snapshot with this name already exists. Available for Valkey, Redis
        /// OSS and Serverless Memcached only.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DeleteServerlessCache">REST API Reference for DeleteServerlessCache Operation</seealso>
        public virtual Task<DeleteServerlessCacheResponse> DeleteServerlessCacheAsync(DeleteServerlessCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServerlessCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServerlessCacheResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServerlessCacheResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteServerlessCacheSnapshot

        internal virtual DeleteServerlessCacheSnapshotResponse DeleteServerlessCacheSnapshot(DeleteServerlessCacheSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServerlessCacheSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServerlessCacheSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteServerlessCacheSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing serverless cache snapshot. Available for Valkey, Redis OSS and
        /// Serverless Memcached only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerlessCacheSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServerlessCacheSnapshot service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidServerlessCacheSnapshotStateException">
        /// The state of the serverless cache snapshot was not received. Available for Valkey,
        /// Redis OSS and Serverless Memcached only.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheSnapshotNotFoundException">
        /// This serverless cache snapshot could not be found or does not exist. Available for
        /// Valkey, Redis OSS and Serverless Memcached only.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DeleteServerlessCacheSnapshot">REST API Reference for DeleteServerlessCacheSnapshot Operation</seealso>
        public virtual Task<DeleteServerlessCacheSnapshotResponse> DeleteServerlessCacheSnapshotAsync(DeleteServerlessCacheSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServerlessCacheSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServerlessCacheSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServerlessCacheSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSnapshot

        internal virtual DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing snapshot. When you receive a successful response from this operation,
        /// ElastiCache immediately begins deleting the snapshot; you cannot cancel or revert
        /// this operation.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is valid for Valkey or Redis OSS only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidSnapshotStateException">
        /// The current state of the snapshot does not allow the requested operation to occur.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotNotFoundException">
        /// The requested snapshot name does not refer to an existing snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        public virtual Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteUser

        internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }



        /// <summary>
        /// For Valkey engine version 7.2 onwards and Redis OSS 6.0 onwards: Deletes a user. The
        /// user will be removed from all user groups and in turn removed from all replication
        /// groups. For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/Clusters.RBAC.html">Using
        /// Role Based Access Control (RBAC)</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.DefaultUserAssociatedToUserGroupException">
        /// The default user assigned to the user group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidUserStateException">
        /// The user is not in active state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserNotFoundException">
        /// The user does not exist or could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteUserGroup

        internal virtual DeleteUserGroupResponse DeleteUserGroup(DeleteUserGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUserGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteUserGroupResponse>(request, options);
        }



        /// <summary>
        /// For Valkey engine version 7.2 onwards and Redis OSS 6.0 onwards: Deletes a user group.
        /// The user group must first be disassociated from the replication group before it can
        /// be deleted. For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/Clusters.RBAC.html">Using
        /// Role Based Access Control (RBAC)</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidUserGroupStateException">
        /// The user group is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserGroupNotFoundException">
        /// The user group was not found or does not exist
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DeleteUserGroup">REST API Reference for DeleteUserGroup Operation</seealso>
        public virtual Task<DeleteUserGroupResponse> DeleteUserGroupAsync(DeleteUserGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUserGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeCacheClusters

        internal virtual DescribeCacheClustersResponse DescribeCacheClusters()
        {
            return DescribeCacheClusters(new DescribeCacheClustersRequest());
        }
        internal virtual DescribeCacheClustersResponse DescribeCacheClusters(DescribeCacheClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheClusters service method.</param>
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
        public virtual Task<DescribeCacheClustersResponse> DescribeCacheClustersAsync(DescribeCacheClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Returns a list of the available cache engines and their versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheEngineVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by ElastiCache.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheEngineVersions">REST API Reference for DescribeCacheEngineVersions Operation</seealso>
        public virtual Task<DescribeCacheEngineVersionsResponse> DescribeCacheEngineVersionsAsync(DescribeCacheEngineVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Returns a list of cache parameter group descriptions. If a cache parameter group name
        /// is specified, the list contains only the descriptions for that group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameterGroups service method.</param>
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
        public virtual Task<DescribeCacheParameterGroupsResponse> DescribeCacheParameterGroupsAsync(DescribeCacheParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCacheParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheParameterGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCacheParameterGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeCacheParameters

        internal virtual DescribeCacheParametersResponse DescribeCacheParameters(DescribeCacheParametersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCacheParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeCacheParametersResponse>(request, options);
        }



        /// <summary>
        /// Returns the detailed parameter list for a particular cache parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCacheParameters service method, as returned by ElastiCache.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheParameters">REST API Reference for DescribeCacheParameters Operation</seealso>
        public virtual Task<DescribeCacheParametersResponse> DescribeCacheParametersAsync(DescribeCacheParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCacheSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeCacheSecurityGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of cache security group descriptions. If a cache security group name
        /// is specified, the list contains only the description of that group. This applicable
        /// only when you have ElastiCache in Classic setup
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
        /// Returns a list of cache security group descriptions. If a cache security group name
        /// is specified, the list contains only the description of that group. This applicable
        /// only when you have ElastiCache in Classic setup
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSecurityGroups service method.</param>
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
        public virtual Task<DescribeCacheSecurityGroupsResponse> DescribeCacheSecurityGroupsAsync(DescribeCacheSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCacheSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeCacheSubnetGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of cache subnet group descriptions. If a subnet group name is specified,
        /// the list contains only the description of that group. This is applicable only when
        /// you have ElastiCache in VPC setup. All ElastiCache clusters now launch in VPC by default.
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
        /// Returns a list of cache subnet group descriptions. If a subnet group name is specified,
        /// the list contains only the description of that group. This is applicable only when
        /// you have ElastiCache in VPC setup. All ElastiCache clusters now launch in VPC by default.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSubnetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheSubnetGroups">REST API Reference for DescribeCacheSubnetGroups Operation</seealso>
        public virtual Task<DescribeCacheSubnetGroupsResponse> DescribeCacheSubnetGroupsAsync(DescribeCacheSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCacheSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCacheSubnetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCacheSubnetGroupsResponse>(request, options, cancellationToken);
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
        /// Returns the default engine and system parameter information for the specified cache
        /// engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeEngineDefaultParameters">REST API Reference for DescribeEngineDefaultParameters Operation</seealso>
        public virtual Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
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
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeGlobalReplicationGroups

        internal virtual DescribeGlobalReplicationGroupsResponse DescribeGlobalReplicationGroups(DescribeGlobalReplicationGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGlobalReplicationGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalReplicationGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeGlobalReplicationGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a particular global replication group. If no identifier
        /// is specified, returns information about all Global datastores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalReplicationGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGlobalReplicationGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.GlobalReplicationGroupNotFoundException">
        /// The Global datastore does not exist
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeGlobalReplicationGroups">REST API Reference for DescribeGlobalReplicationGroups Operation</seealso>
        public virtual Task<DescribeGlobalReplicationGroupsResponse> DescribeGlobalReplicationGroupsAsync(DescribeGlobalReplicationGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGlobalReplicationGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalReplicationGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGlobalReplicationGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeReplicationGroups

        internal virtual DescribeReplicationGroupsResponse DescribeReplicationGroups()
        {
            return DescribeReplicationGroups(new DescribeReplicationGroupsRequest());
        }
        internal virtual DescribeReplicationGroupsResponse DescribeReplicationGroups(DescribeReplicationGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReplicationGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a particular replication group. If no identifier is specified,
        /// <c>DescribeReplicationGroups</c> returns information about all replication groups.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is valid for Valkey or Redis OSS only.
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
        /// Returns information about a particular replication group. If no identifier is specified,
        /// <c>DescribeReplicationGroups</c> returns information about all replication groups.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is valid for Valkey or Redis OSS only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationGroups service method.</param>
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
        public virtual Task<DescribeReplicationGroupsResponse> DescribeReplicationGroupsAsync(DescribeReplicationGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Returns information about reserved cache nodes for this account, or about a specified
        /// reserved cache node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodes service method.</param>
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
        public virtual Task<DescribeReservedCacheNodesResponse> DescribeReservedCacheNodesAsync(DescribeReservedCacheNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Lists available reserved cache node offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodesOfferings service method.</param>
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
        public virtual Task<DescribeReservedCacheNodesOfferingsResponse> DescribeReservedCacheNodesOfferingsAsync(DescribeReservedCacheNodesOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReservedCacheNodesOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedCacheNodesOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedCacheNodesOfferingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeServerlessCaches

        internal virtual DescribeServerlessCachesResponse DescribeServerlessCaches(DescribeServerlessCachesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeServerlessCachesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServerlessCachesResponseUnmarshaller.Instance;

            return Invoke<DescribeServerlessCachesResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a specific serverless cache. If no identifier is specified,
        /// then the API returns information on all the serverless caches belonging to this Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServerlessCaches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServerlessCaches service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheNotFoundException">
        /// The serverless cache was not found or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeServerlessCaches">REST API Reference for DescribeServerlessCaches Operation</seealso>
        public virtual Task<DescribeServerlessCachesResponse> DescribeServerlessCachesAsync(DescribeServerlessCachesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeServerlessCachesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServerlessCachesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServerlessCachesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeServerlessCacheSnapshots

        internal virtual DescribeServerlessCacheSnapshotsResponse DescribeServerlessCacheSnapshots(DescribeServerlessCacheSnapshotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeServerlessCacheSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServerlessCacheSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeServerlessCacheSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about serverless cache snapshots. By default, this API lists all
        /// of the customer’s serverless cache snapshots. It can also describe a single serverless
        /// cache snapshot, or the snapshots associated with a particular serverless cache. Available
        /// for Valkey, Redis OSS and Serverless Memcached only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServerlessCacheSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServerlessCacheSnapshots service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheNotFoundException">
        /// The serverless cache was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheSnapshotNotFoundException">
        /// This serverless cache snapshot could not be found or does not exist. Available for
        /// Valkey, Redis OSS and Serverless Memcached only.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeServerlessCacheSnapshots">REST API Reference for DescribeServerlessCacheSnapshots Operation</seealso>
        public virtual Task<DescribeServerlessCacheSnapshotsResponse> DescribeServerlessCacheSnapshotsAsync(DescribeServerlessCacheSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeServerlessCacheSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServerlessCacheSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServerlessCacheSnapshotsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeServiceUpdates

        internal virtual DescribeServiceUpdatesResponse DescribeServiceUpdates(DescribeServiceUpdatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeServiceUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceUpdatesResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceUpdatesResponse>(request, options);
        }



        /// <summary>
        /// Returns details of the service updates
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceUpdates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServiceUpdates service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceUpdateNotFoundException">
        /// The service update doesn't exist
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeServiceUpdates">REST API Reference for DescribeServiceUpdates Operation</seealso>
        public virtual Task<DescribeServiceUpdatesResponse> DescribeServiceUpdatesAsync(DescribeServiceUpdatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeServiceUpdatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceUpdatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServiceUpdatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSnapshots

        internal virtual DescribeSnapshotsResponse DescribeSnapshots()
        {
            return DescribeSnapshots(new DescribeSnapshotsRequest());
        }
        internal virtual DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about cluster or replication group snapshots. By default, <c>DescribeSnapshots</c>
        /// lists all of your snapshots; it can optionally describe a single snapshot, or just
        /// the snapshots associated with a particular cache cluster.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is valid for Valkey or Redis OSS only.
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
        /// Returns information about cluster or replication group snapshots. By default, <c>DescribeSnapshots</c>
        /// lists all of your snapshots; it can optionally describe a single snapshot, or just
        /// the snapshots associated with a particular cache cluster.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is valid for Valkey or Redis OSS only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method.</param>
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
        public virtual Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeUpdateActions

        internal virtual DescribeUpdateActionsResponse DescribeUpdateActions(DescribeUpdateActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUpdateActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUpdateActionsResponseUnmarshaller.Instance;

            return Invoke<DescribeUpdateActionsResponse>(request, options);
        }



        /// <summary>
        /// Returns details of the update actions
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUpdateActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUpdateActions service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeUpdateActions">REST API Reference for DescribeUpdateActions Operation</seealso>
        public virtual Task<DescribeUpdateActionsResponse> DescribeUpdateActionsAsync(DescribeUpdateActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUpdateActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUpdateActionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUpdateActionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeUserGroups

        internal virtual DescribeUserGroupsResponse DescribeUserGroups(DescribeUserGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUserGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeUserGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of user groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUserGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserGroupNotFoundException">
        /// The user group was not found or does not exist
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeUserGroups">REST API Reference for DescribeUserGroups Operation</seealso>
        public virtual Task<DescribeUserGroupsResponse> DescribeUserGroupsAsync(DescribeUserGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUserGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUserGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeUsers

        internal virtual DescribeUsersResponse DescribeUsers(DescribeUsersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUsersResponseUnmarshaller.Instance;

            return Invoke<DescribeUsersResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUsers service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserNotFoundException">
        /// The user does not exist or could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeUsers">REST API Reference for DescribeUsers Operation</seealso>
        public virtual Task<DescribeUsersResponse> DescribeUsersAsync(DescribeUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUsersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUsersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateGlobalReplicationGroup

        internal virtual DisassociateGlobalReplicationGroupResponse DisassociateGlobalReplicationGroup(DisassociateGlobalReplicationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateGlobalReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateGlobalReplicationGroupResponseUnmarshaller.Instance;

            return Invoke<DisassociateGlobalReplicationGroupResponse>(request, options);
        }



        /// <summary>
        /// Remove a secondary cluster from the Global datastore using the Global datastore name.
        /// The secondary cluster will no longer receive updates from the primary cluster, but
        /// will remain as a standalone cluster in that Amazon region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateGlobalReplicationGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateGlobalReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.GlobalReplicationGroupNotFoundException">
        /// The Global datastore does not exist
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidGlobalReplicationGroupStateException">
        /// The Global datastore is not available or in primary-only state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DisassociateGlobalReplicationGroup">REST API Reference for DisassociateGlobalReplicationGroup Operation</seealso>
        public virtual Task<DisassociateGlobalReplicationGroupResponse> DisassociateGlobalReplicationGroupAsync(DisassociateGlobalReplicationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateGlobalReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateGlobalReplicationGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateGlobalReplicationGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExportServerlessCacheSnapshot

        internal virtual ExportServerlessCacheSnapshotResponse ExportServerlessCacheSnapshot(ExportServerlessCacheSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportServerlessCacheSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportServerlessCacheSnapshotResponseUnmarshaller.Instance;

            return Invoke<ExportServerlessCacheSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Provides the functionality to export the serverless cache snapshot data to Amazon
        /// S3. Available for Valkey and Redis OSS only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportServerlessCacheSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportServerlessCacheSnapshot service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidServerlessCacheSnapshotStateException">
        /// The state of the serverless cache snapshot was not received. Available for Valkey,
        /// Redis OSS and Serverless Memcached only.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheSnapshotNotFoundException">
        /// This serverless cache snapshot could not be found or does not exist. Available for
        /// Valkey, Redis OSS and Serverless Memcached only.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ExportServerlessCacheSnapshot">REST API Reference for ExportServerlessCacheSnapshot Operation</seealso>
        public virtual Task<ExportServerlessCacheSnapshotResponse> ExportServerlessCacheSnapshotAsync(ExportServerlessCacheSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportServerlessCacheSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportServerlessCacheSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<ExportServerlessCacheSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  FailoverGlobalReplicationGroup

        internal virtual FailoverGlobalReplicationGroupResponse FailoverGlobalReplicationGroup(FailoverGlobalReplicationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FailoverGlobalReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverGlobalReplicationGroupResponseUnmarshaller.Instance;

            return Invoke<FailoverGlobalReplicationGroupResponse>(request, options);
        }



        /// <summary>
        /// Used to failover the primary region to a secondary region. The secondary region will
        /// become primary, and all other clusters will become secondary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverGlobalReplicationGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FailoverGlobalReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.GlobalReplicationGroupNotFoundException">
        /// The Global datastore does not exist
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidGlobalReplicationGroupStateException">
        /// The Global datastore is not available or in primary-only state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/FailoverGlobalReplicationGroup">REST API Reference for FailoverGlobalReplicationGroup Operation</seealso>
        public virtual Task<FailoverGlobalReplicationGroupResponse> FailoverGlobalReplicationGroupAsync(FailoverGlobalReplicationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FailoverGlobalReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverGlobalReplicationGroupResponseUnmarshaller.Instance;

            return InvokeAsync<FailoverGlobalReplicationGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  IncreaseNodeGroupsInGlobalReplicationGroup

        internal virtual IncreaseNodeGroupsInGlobalReplicationGroupResponse IncreaseNodeGroupsInGlobalReplicationGroup(IncreaseNodeGroupsInGlobalReplicationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IncreaseNodeGroupsInGlobalReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IncreaseNodeGroupsInGlobalReplicationGroupResponseUnmarshaller.Instance;

            return Invoke<IncreaseNodeGroupsInGlobalReplicationGroupResponse>(request, options);
        }



        /// <summary>
        /// Increase the number of node groups in the Global datastore
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IncreaseNodeGroupsInGlobalReplicationGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IncreaseNodeGroupsInGlobalReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.GlobalReplicationGroupNotFoundException">
        /// The Global datastore does not exist
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidGlobalReplicationGroupStateException">
        /// The Global datastore is not available or in primary-only state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/IncreaseNodeGroupsInGlobalReplicationGroup">REST API Reference for IncreaseNodeGroupsInGlobalReplicationGroup Operation</seealso>
        public virtual Task<IncreaseNodeGroupsInGlobalReplicationGroupResponse> IncreaseNodeGroupsInGlobalReplicationGroupAsync(IncreaseNodeGroupsInGlobalReplicationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IncreaseNodeGroupsInGlobalReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IncreaseNodeGroupsInGlobalReplicationGroupResponseUnmarshaller.Instance;

            return InvokeAsync<IncreaseNodeGroupsInGlobalReplicationGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  IncreaseReplicaCount

        internal virtual IncreaseReplicaCountResponse IncreaseReplicaCount(IncreaseReplicaCountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IncreaseReplicaCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IncreaseReplicaCountResponseUnmarshaller.Instance;

            return Invoke<IncreaseReplicaCountResponse>(request, options);
        }



        /// <summary>
        /// Dynamically increases the number of replicas in a Valkey or Redis OSS (cluster mode
        /// disabled) replication group or the number of replica nodes in one or more node groups
        /// (shards) of a Valkey or Redis OSS (cluster mode enabled) replication group. This operation
        /// is performed with no cluster down time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IncreaseReplicaCount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IncreaseReplicaCount service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.ClusterQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of clusters
        /// per customer.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InsufficientCacheClusterCapacityException">
        /// The requested cache node type is not available in the specified Availability Zone.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/ErrorMessages.html#ErrorMessages.INSUFFICIENT_CACHE_CLUSTER_CAPACITY">InsufficientCacheClusterCapacity</a>
        /// in the ElastiCache User Guide.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidKMSKeyException">
        /// The KMS key supplied is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidVPCNetworkStateException">
        /// The VPC network is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeGroupsPerReplicationGroupQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum allowed number
        /// of node groups (shards) in a single replication group. The default maximum is 90
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes per customer.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NoOperationException">
        /// The operation was not performed because no changes were required.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/IncreaseReplicaCount">REST API Reference for IncreaseReplicaCount Operation</seealso>
        public virtual Task<IncreaseReplicaCountResponse> IncreaseReplicaCountAsync(IncreaseReplicaCountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IncreaseReplicaCountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IncreaseReplicaCountResponseUnmarshaller.Instance;

            return InvokeAsync<IncreaseReplicaCountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAllowedNodeTypeModifications

        internal virtual ListAllowedNodeTypeModificationsResponse ListAllowedNodeTypeModifications(ListAllowedNodeTypeModificationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAllowedNodeTypeModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAllowedNodeTypeModificationsResponseUnmarshaller.Instance;

            return Invoke<ListAllowedNodeTypeModificationsResponse>(request, options);
        }



        /// <summary>
        /// Lists all available node types that you can scale with your cluster's replication
        /// group's current node type.
        /// 
        ///  
        /// <para>
        /// When you use the <c>ModifyCacheCluster</c> or <c>ModifyReplicationGroup</c> operations
        /// to scale your cluster or replication group, the value of the <c>CacheNodeType</c>
        /// parameter must be one of the node types returned by this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAllowedNodeTypeModifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAllowedNodeTypeModifications service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ListAllowedNodeTypeModifications">REST API Reference for ListAllowedNodeTypeModifications Operation</seealso>
        public virtual Task<ListAllowedNodeTypeModificationsResponse> ListAllowedNodeTypeModificationsAsync(ListAllowedNodeTypeModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAllowedNodeTypeModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAllowedNodeTypeModificationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAllowedNodeTypeModificationsResponse>(request, options, cancellationToken);
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
        /// Lists all tags currently on a named resource.
        /// 
        ///  
        /// <para>
        ///  A tag is a key-value pair where the key and value are case-sensitive. You can use
        /// tags to categorize and track all your ElastiCache resources, with the exception of
        /// global replication group. When you add or remove tags on replication groups, those
        /// actions will be replicated to all nodes in the replication group. For more information,
        /// see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/IAM.ResourceLevelPermissions.html">Resource-level
        /// permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// If the cluster is not in the <i>available</i> state, <c>ListTagsForResource</c> returns
        /// an error.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidARNException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidServerlessCacheSnapshotStateException">
        /// The state of the serverless cache snapshot was not received. Available for Valkey,
        /// Redis OSS and Serverless Memcached only.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidServerlessCacheStateException">
        /// The account for these credentials is not currently active.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReservedCacheNodeNotFoundException">
        /// The requested reserved cache node was not found.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheNotFoundException">
        /// The serverless cache was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheSnapshotNotFoundException">
        /// This serverless cache snapshot could not be found or does not exist. Available for
        /// Valkey, Redis OSS and Serverless Memcached only.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotNotFoundException">
        /// The requested snapshot name does not refer to an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserGroupNotFoundException">
        /// The user group was not found or does not exist
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserNotFoundException">
        /// The user does not exist or could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyCacheCluster

        internal virtual ModifyCacheClusterResponse ModifyCacheCluster(ModifyCacheClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyCacheClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCacheClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyCacheClusterResponse>(request, options);
        }



        /// <summary>
        /// Modifies the settings for a cluster. You can use this operation to change one or more
        /// cluster configuration parameters by specifying the parameters and the new values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyCacheCluster service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InsufficientCacheClusterCapacityException">
        /// The requested cache node type is not available in the specified Availability Zone.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/ErrorMessages.html#ErrorMessages.INSUFFICIENT_CACHE_CLUSTER_CAPACITY">InsufficientCacheClusterCapacity</a>
        /// in the ElastiCache User Guide.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException">
        /// The current state of the cache security group does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidVPCNetworkStateException">
        /// The VPC network is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeQuotaForClusterExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes in a single cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes per customer.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ModifyCacheCluster">REST API Reference for ModifyCacheCluster Operation</seealso>
        public virtual Task<ModifyCacheClusterResponse> ModifyCacheClusterAsync(ModifyCacheClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyCacheClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCacheClusterResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyCacheClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyCacheParameterGroup

        internal virtual ModifyCacheParameterGroupResponse ModifyCacheParameterGroup(ModifyCacheParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyCacheParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCacheParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyCacheParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies the parameters of a cache parameter group. You can modify up to 20 parameters
        /// in a single request by submitting a list parameter name and value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyCacheParameterGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException">
        /// The current state of the cache parameter group does not allow the requested operation
        /// to occur.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidGlobalReplicationGroupStateException">
        /// The Global datastore is not available or in primary-only state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ModifyCacheParameterGroup">REST API Reference for ModifyCacheParameterGroup Operation</seealso>
        public virtual Task<ModifyCacheParameterGroupResponse> ModifyCacheParameterGroupAsync(ModifyCacheParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyCacheParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCacheParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyCacheParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyCacheSubnetGroup

        internal virtual ModifyCacheSubnetGroupResponse ModifyCacheSubnetGroup(ModifyCacheSubnetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyCacheSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCacheSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyCacheSubnetGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies an existing cache subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyCacheSubnetGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetQuotaExceededException">
        /// The request cannot be processed because it would exceed the allowed number of subnets
        /// in a cache subnet group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidSubnetException">
        /// An invalid subnet identifier was specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SubnetInUseException">
        /// The requested subnet is being used by another cache subnet group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SubnetNotAllowedException">
        /// At least one subnet ID does not match the other subnet IDs. This mismatch typically
        /// occurs when a user sets one subnet ID to a regional Availability Zone and a different
        /// one to an outpost. Or when a user sets the subnet ID to an Outpost when not subscribed
        /// on this service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ModifyCacheSubnetGroup">REST API Reference for ModifyCacheSubnetGroup Operation</seealso>
        public virtual Task<ModifyCacheSubnetGroupResponse> ModifyCacheSubnetGroupAsync(ModifyCacheSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyCacheSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCacheSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyCacheSubnetGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyGlobalReplicationGroup

        internal virtual ModifyGlobalReplicationGroupResponse ModifyGlobalReplicationGroup(ModifyGlobalReplicationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyGlobalReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyGlobalReplicationGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyGlobalReplicationGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies the settings for a Global datastore.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyGlobalReplicationGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyGlobalReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.GlobalReplicationGroupNotFoundException">
        /// The Global datastore does not exist
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidGlobalReplicationGroupStateException">
        /// The Global datastore is not available or in primary-only state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ModifyGlobalReplicationGroup">REST API Reference for ModifyGlobalReplicationGroup Operation</seealso>
        public virtual Task<ModifyGlobalReplicationGroupResponse> ModifyGlobalReplicationGroupAsync(ModifyGlobalReplicationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyGlobalReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyGlobalReplicationGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyGlobalReplicationGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyReplicationGroup

        internal virtual ModifyReplicationGroupResponse ModifyReplicationGroup(ModifyReplicationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyReplicationGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies the settings for a replication group. This is limited to Valkey and Redis
        /// OSS 7 and above.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/scaling-redis-cluster-mode-enabled.html">Scaling
        /// for Valkey or Redis OSS (cluster mode enabled)</a> in the ElastiCache User Guide
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/APIReference/API_ModifyReplicationGroupShardConfiguration.html">ModifyReplicationGroupShardConfiguration</a>
        /// in the ElastiCache API Reference
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// This operation is valid for Valkey or Redis OSS only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InsufficientCacheClusterCapacityException">
        /// The requested cache node type is not available in the specified Availability Zone.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/ErrorMessages.html#ErrorMessages.INSUFFICIENT_CACHE_CLUSTER_CAPACITY">InsufficientCacheClusterCapacity</a>
        /// in the ElastiCache User Guide.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException">
        /// The current state of the cache security group does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidKMSKeyException">
        /// The KMS key supplied is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidUserGroupStateException">
        /// The user group is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidVPCNetworkStateException">
        /// The VPC network is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeQuotaForClusterExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes in a single cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes per customer.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserGroupNotFoundException">
        /// The user group was not found or does not exist
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ModifyReplicationGroup">REST API Reference for ModifyReplicationGroup Operation</seealso>
        public virtual Task<ModifyReplicationGroupResponse> ModifyReplicationGroupAsync(ModifyReplicationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyReplicationGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyReplicationGroupShardConfiguration

        internal virtual ModifyReplicationGroupShardConfigurationResponse ModifyReplicationGroupShardConfiguration(ModifyReplicationGroupShardConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyReplicationGroupShardConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationGroupShardConfigurationResponseUnmarshaller.Instance;

            return Invoke<ModifyReplicationGroupShardConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Modifies a replication group's shards (node groups) by allowing you to add shards,
        /// remove shards, or rebalance the keyspaces among existing shards.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationGroupShardConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyReplicationGroupShardConfiguration service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InsufficientCacheClusterCapacityException">
        /// The requested cache node type is not available in the specified Availability Zone.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/ErrorMessages.html#ErrorMessages.INSUFFICIENT_CACHE_CLUSTER_CAPACITY">InsufficientCacheClusterCapacity</a>
        /// in the ElastiCache User Guide.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidKMSKeyException">
        /// The KMS key supplied is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidVPCNetworkStateException">
        /// The VPC network is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeGroupsPerReplicationGroupQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum allowed number
        /// of node groups (shards) in a single replication group. The default maximum is 90
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes per customer.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ModifyReplicationGroupShardConfiguration">REST API Reference for ModifyReplicationGroupShardConfiguration Operation</seealso>
        public virtual Task<ModifyReplicationGroupShardConfigurationResponse> ModifyReplicationGroupShardConfigurationAsync(ModifyReplicationGroupShardConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyReplicationGroupShardConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationGroupShardConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyReplicationGroupShardConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyServerlessCache

        internal virtual ModifyServerlessCacheResponse ModifyServerlessCache(ModifyServerlessCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyServerlessCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyServerlessCacheResponseUnmarshaller.Instance;

            return Invoke<ModifyServerlessCacheResponse>(request, options);
        }



        /// <summary>
        /// This API modifies the attributes of a serverless cache.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyServerlessCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyServerlessCache service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCredentialsException">
        /// You must enter valid credentials.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidServerlessCacheStateException">
        /// The account for these credentials is not currently active.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidUserGroupStateException">
        /// The user group is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheNotFoundException">
        /// The serverless cache was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserGroupNotFoundException">
        /// The user group was not found or does not exist
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ModifyServerlessCache">REST API Reference for ModifyServerlessCache Operation</seealso>
        public virtual Task<ModifyServerlessCacheResponse> ModifyServerlessCacheAsync(ModifyServerlessCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyServerlessCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyServerlessCacheResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyServerlessCacheResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyUser

        internal virtual ModifyUserResponse ModifyUser(ModifyUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyUserResponseUnmarshaller.Instance;

            return Invoke<ModifyUserResponse>(request, options);
        }



        /// <summary>
        /// Changes user password(s) and/or access string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyUser service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidUserStateException">
        /// The user is not in active state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserNotFoundException">
        /// The user does not exist or could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ModifyUser">REST API Reference for ModifyUser Operation</seealso>
        public virtual Task<ModifyUserResponse> ModifyUserAsync(ModifyUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyUserResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyUserResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyUserGroup

        internal virtual ModifyUserGroupResponse ModifyUserGroup(ModifyUserGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyUserGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyUserGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyUserGroupResponse>(request, options);
        }



        /// <summary>
        /// Changes the list of users that belong to the user group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyUserGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyUserGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.DefaultUserRequiredException">
        /// You must add default user to a user group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.DuplicateUserNameException">
        /// A user with this username already exists.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidUserGroupStateException">
        /// The user group is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserGroupNotFoundException">
        /// The user group was not found or does not exist
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserNotFoundException">
        /// The user does not exist or could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ModifyUserGroup">REST API Reference for ModifyUserGroup Operation</seealso>
        public virtual Task<ModifyUserGroupResponse> ModifyUserGroupAsync(ModifyUserGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyUserGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyUserGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyUserGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PurchaseReservedCacheNodesOffering

        internal virtual PurchaseReservedCacheNodesOfferingResponse PurchaseReservedCacheNodesOffering(PurchaseReservedCacheNodesOfferingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PurchaseReservedCacheNodesOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedCacheNodesOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedCacheNodesOfferingResponse>(request, options);
        }



        /// <summary>
        /// Allows you to purchase a reserved cache node offering. Reserved nodes are not eligible
        /// for cancellation and are non-refundable. For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/reserved-nodes.html">Managing
        /// Costs with Reserved Nodes</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedCacheNodesOffering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseReservedCacheNodesOffering service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReservedCacheNodeAlreadyExistsException">
        /// You already have a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReservedCacheNodeQuotaExceededException">
        /// The request cannot be processed because it would exceed the user's cache node quota.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReservedCacheNodesOfferingNotFoundException">
        /// The requested cache node offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.TagQuotaPerResourceExceededException">
        /// The request cannot be processed because it would cause the resource to have more than
        /// the allowed number of tags. The maximum number of tags permitted on a resource is
        /// 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/PurchaseReservedCacheNodesOffering">REST API Reference for PurchaseReservedCacheNodesOffering Operation</seealso>
        public virtual Task<PurchaseReservedCacheNodesOfferingResponse> PurchaseReservedCacheNodesOfferingAsync(PurchaseReservedCacheNodesOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PurchaseReservedCacheNodesOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedCacheNodesOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseReservedCacheNodesOfferingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RebalanceSlotsInGlobalReplicationGroup

        internal virtual RebalanceSlotsInGlobalReplicationGroupResponse RebalanceSlotsInGlobalReplicationGroup(RebalanceSlotsInGlobalReplicationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebalanceSlotsInGlobalReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebalanceSlotsInGlobalReplicationGroupResponseUnmarshaller.Instance;

            return Invoke<RebalanceSlotsInGlobalReplicationGroupResponse>(request, options);
        }



        /// <summary>
        /// Redistribute slots to ensure uniform distribution across existing shards in the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebalanceSlotsInGlobalReplicationGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebalanceSlotsInGlobalReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.GlobalReplicationGroupNotFoundException">
        /// The Global datastore does not exist
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidGlobalReplicationGroupStateException">
        /// The Global datastore is not available or in primary-only state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/RebalanceSlotsInGlobalReplicationGroup">REST API Reference for RebalanceSlotsInGlobalReplicationGroup Operation</seealso>
        public virtual Task<RebalanceSlotsInGlobalReplicationGroupResponse> RebalanceSlotsInGlobalReplicationGroupAsync(RebalanceSlotsInGlobalReplicationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebalanceSlotsInGlobalReplicationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebalanceSlotsInGlobalReplicationGroupResponseUnmarshaller.Instance;

            return InvokeAsync<RebalanceSlotsInGlobalReplicationGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RebootCacheCluster

        internal virtual RebootCacheClusterResponse RebootCacheCluster(RebootCacheClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootCacheClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootCacheClusterResponseUnmarshaller.Instance;

            return Invoke<RebootCacheClusterResponse>(request, options);
        }



        /// <summary>
        /// Reboots some, or all, of the cache nodes within a provisioned cluster. This operation
        /// applies any modified cache parameter groups to the cluster. The reboot operation takes
        /// place as soon as possible, and results in a momentary outage to the cluster. During
        /// the reboot, the cluster status is set to REBOOTING.
        /// 
        ///  
        /// <para>
        /// The reboot causes the contents of the cache (for each cache node being rebooted) to
        /// be lost.
        /// </para>
        ///  
        /// <para>
        /// When the reboot is complete, a cluster event is created.
        /// </para>
        ///  
        /// <para>
        /// Rebooting a cluster is currently supported on Memcached, Valkey and Redis OSS (cluster
        /// mode disabled) clusters. Rebooting is not supported on Valkey or Redis OSS (cluster
        /// mode enabled) clusters.
        /// </para>
        ///  
        /// <para>
        /// If you make changes to parameters that require a Valkey or Redis OSS (cluster mode
        /// enabled) cluster reboot for the changes to be applied, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/nodes.rebooting.html">Rebooting
        /// a Cluster</a> for an alternate process.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootCacheCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootCacheCluster service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cluster is not in the <c>available</c> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/RebootCacheCluster">REST API Reference for RebootCacheCluster Operation</seealso>
        public virtual Task<RebootCacheClusterResponse> RebootCacheClusterAsync(RebootCacheClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootCacheClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootCacheClusterResponseUnmarshaller.Instance;

            return InvokeAsync<RebootCacheClusterResponse>(request, options, cancellationToken);
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
        /// Removes the tags identified by the <c>TagKeys</c> list from the named resource. A
        /// tag is a key-value pair where the key and value are case-sensitive. You can use tags
        /// to categorize and track all your ElastiCache resources, with the exception of global
        /// replication group. When you add or remove tags on replication groups, those actions
        /// will be replicated to all nodes in the replication group. For more information, see
        /// <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/IAM.ResourceLevelPermissions.html">Resource-level
        /// permissions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidARNException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidServerlessCacheSnapshotStateException">
        /// The state of the serverless cache snapshot was not received. Available for Valkey,
        /// Redis OSS and Serverless Memcached only.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidServerlessCacheStateException">
        /// The account for these credentials is not currently active.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReservedCacheNodeNotFoundException">
        /// The requested reserved cache node was not found.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheNotFoundException">
        /// The serverless cache was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServerlessCacheSnapshotNotFoundException">
        /// This serverless cache snapshot could not be found or does not exist. Available for
        /// Valkey, Redis OSS and Serverless Memcached only.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotNotFoundException">
        /// The requested snapshot name does not refer to an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.TagNotFoundException">
        /// The requested tag was not found on this resource.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserGroupNotFoundException">
        /// The user group was not found or does not exist
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.UserNotFoundException">
        /// The user does not exist or could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ResetCacheParameterGroup

        internal virtual ResetCacheParameterGroupResponse ResetCacheParameterGroup(ResetCacheParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetCacheParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetCacheParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetCacheParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies the parameters of a cache parameter group to the engine or system default
        /// value. You can reset specific parameters by submitting a list of parameter names.
        /// To reset the entire cache parameter group, specify the <c>ResetAllParameters</c> and
        /// <c>CacheParameterGroupName</c> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetCacheParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetCacheParameterGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException">
        /// The current state of the cache parameter group does not allow the requested operation
        /// to occur.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidGlobalReplicationGroupStateException">
        /// The Global datastore is not available or in primary-only state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/ResetCacheParameterGroup">REST API Reference for ResetCacheParameterGroup Operation</seealso>
        public virtual Task<ResetCacheParameterGroupResponse> ResetCacheParameterGroupAsync(ResetCacheParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetCacheParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetCacheParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ResetCacheParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RevokeCacheSecurityGroupIngress

        internal virtual RevokeCacheSecurityGroupIngressResponse RevokeCacheSecurityGroupIngress(RevokeCacheSecurityGroupIngressRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeCacheSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeCacheSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeCacheSecurityGroupIngressResponse>(request, options);
        }



        /// <summary>
        /// Revokes ingress from a cache security group. Use this operation to disallow access
        /// from an Amazon EC2 security group that had been previously authorized.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeCacheSecurityGroupIngress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeCacheSecurityGroupIngress service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.AuthorizationNotFoundException">
        /// The specified Amazon EC2 security group is not authorized for the specified cache
        /// security group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException">
        /// The requested cache security group name does not refer to an existing cache security
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException">
        /// The current state of the cache security group does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/RevokeCacheSecurityGroupIngress">REST API Reference for RevokeCacheSecurityGroupIngress Operation</seealso>
        public virtual Task<RevokeCacheSecurityGroupIngressResponse> RevokeCacheSecurityGroupIngressAsync(RevokeCacheSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeCacheSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeCacheSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeCacheSecurityGroupIngressResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartMigration

        internal virtual StartMigrationResponse StartMigration(StartMigrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMigrationResponseUnmarshaller.Instance;

            return Invoke<StartMigrationResponse>(request, options);
        }



        /// <summary>
        /// Start the migration of data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMigration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMigration service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupAlreadyUnderMigrationException">
        /// The targeted replication group is not available.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/StartMigration">REST API Reference for StartMigration Operation</seealso>
        public virtual Task<StartMigrationResponse> StartMigrationAsync(StartMigrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMigrationResponseUnmarshaller.Instance;

            return InvokeAsync<StartMigrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TestFailover

        internal virtual TestFailoverResponse TestFailover(TestFailoverRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestFailoverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestFailoverResponseUnmarshaller.Instance;

            return Invoke<TestFailoverResponse>(request, options);
        }



        /// <summary>
        /// Represents the input of a <c>TestFailover</c> operation which tests automatic failover
        /// on a specified node group (called shard in the console) in a replication group (called
        /// cluster in the console).
        /// 
        ///  
        /// <para>
        /// This API is designed for testing the behavior of your application in case of ElastiCache
        /// failover. It is not designed to be an operational tool for initiating a failover to
        /// overcome a problem you may have with the cluster. Moreover, in certain conditions
        /// such as large-scale operational events, Amazon may block this API. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Note the following</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A customer can use this operation to test automatic failover on up to 15 shards (called
        /// node groups in the ElastiCache API and Amazon CLI) in any rolling 24-hour period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If calling this operation on shards in different clusters (called replication groups
        /// in the API and CLI), the calls can be made concurrently.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If calling this operation multiple times on different shards in the same Valkey or
        /// Redis OSS (cluster mode enabled) replication group, the first node replacement must
        /// complete before a subsequent call can be made.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To determine whether the node replacement is complete you can check Events using the
        /// Amazon ElastiCache console, the Amazon CLI, or the ElastiCache API. Look for the following
        /// automatic failover related events, listed here in order of occurrance:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Replication group message: <c>Test Failover API called for node group &lt;node-group-id&gt;</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cache cluster message: <c>Failover from primary node &lt;primary-node-id&gt; to replica
        /// node &lt;node-id&gt; completed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Replication group message: <c>Failover from primary node &lt;primary-node-id&gt; to
        /// replica node &lt;node-id&gt; completed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cache cluster message: <c>Recovering cache nodes &lt;node-id&gt;</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cache cluster message: <c>Finished recovery for cache nodes &lt;node-id&gt;</c> 
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information see:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/ECEvents.Viewing.html">Viewing
        /// ElastiCache Events</a> in the <i>ElastiCache User Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/APIReference/API_DescribeEvents.html">DescribeEvents</a>
        /// in the ElastiCache API Reference
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// Also see, <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/AutoFailover.html#auto-failover-test">Testing
        /// Multi-AZ </a> in the <i>ElastiCache User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestFailover service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestFailover service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.APICallRateForCustomerExceededException">
        /// The customer has exceeded the allowed rate of API calls.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cluster is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidKMSKeyException">
        /// The KMS key supplied is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeGroupNotFoundException">
        /// The node group specified by the <c>NodeGroupId</c> parameter could not be found. Please
        /// verify that the node group exists and that you spelled the <c>NodeGroupId</c> value
        /// correctly.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.TestFailoverNotAvailableException">
        /// The <c>TestFailover</c> action is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/TestFailover">REST API Reference for TestFailover Operation</seealso>
        public virtual Task<TestFailoverResponse> TestFailoverAsync(TestFailoverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestFailoverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestFailoverResponseUnmarshaller.Instance;

            return InvokeAsync<TestFailoverResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TestMigration

        internal virtual TestMigrationResponse TestMigration(TestMigrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestMigrationResponseUnmarshaller.Instance;

            return Invoke<TestMigrationResponse>(request, options);
        }



        /// <summary>
        /// Async API to test connection between source and target replication group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestMigration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestMigration service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <c>available</c> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupAlreadyUnderMigrationException">
        /// The targeted replication group is not available.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/TestMigration">REST API Reference for TestMigration Operation</seealso>
        public virtual Task<TestMigrationResponse> TestMigrationAsync(TestMigrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestMigrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestMigrationResponseUnmarshaller.Instance;

            return InvokeAsync<TestMigrationResponse>(request, options, cancellationToken);
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