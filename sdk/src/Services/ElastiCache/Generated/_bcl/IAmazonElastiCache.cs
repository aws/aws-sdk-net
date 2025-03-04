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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ElastiCache.Model;

#pragma warning disable CS1570
namespace Amazon.ElastiCache
{
    /// <summary>
    /// <para>Interface for accessing ElastiCache</para>
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
    public partial interface IAmazonElastiCache : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IElastiCachePaginatorFactory Paginators { get; }

        
        #region  AddTagsToResource


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
        AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request);



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
        Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AuthorizeCacheSecurityGroupIngress


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
        AuthorizeCacheSecurityGroupIngressResponse AuthorizeCacheSecurityGroupIngress(AuthorizeCacheSecurityGroupIngressRequest request);



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
        Task<AuthorizeCacheSecurityGroupIngressResponse> AuthorizeCacheSecurityGroupIngressAsync(AuthorizeCacheSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchApplyUpdateAction


        /// <summary>
        /// Apply the service update. For more information on service updates and applying them,
        /// see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/applying-updates.html">Applying
        /// Service Updates</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchApplyUpdateAction service method.</param>
        /// 
        /// <returns>The response from the BatchApplyUpdateAction service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceUpdateNotFoundException">
        /// The service update doesn't exist
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/BatchApplyUpdateAction">REST API Reference for BatchApplyUpdateAction Operation</seealso>
        BatchApplyUpdateActionResponse BatchApplyUpdateAction(BatchApplyUpdateActionRequest request);



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
        Task<BatchApplyUpdateActionResponse> BatchApplyUpdateActionAsync(BatchApplyUpdateActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchStopUpdateAction


        /// <summary>
        /// Stop the service update. For more information on service updates and stopping them,
        /// see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/stopping-self-service-updates.html">Stopping
        /// Service Updates</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchStopUpdateAction service method.</param>
        /// 
        /// <returns>The response from the BatchStopUpdateAction service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ServiceUpdateNotFoundException">
        /// The service update doesn't exist
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/BatchStopUpdateAction">REST API Reference for BatchStopUpdateAction Operation</seealso>
        BatchStopUpdateActionResponse BatchStopUpdateAction(BatchStopUpdateActionRequest request);



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
        Task<BatchStopUpdateActionResponse> BatchStopUpdateActionAsync(BatchStopUpdateActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CompleteMigration


        /// <summary>
        /// Complete the migration of data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteMigration service method.</param>
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
        CompleteMigrationResponse CompleteMigration(CompleteMigrationRequest request);



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
        Task<CompleteMigrationResponse> CompleteMigrationAsync(CompleteMigrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CopyServerlessCacheSnapshot


        /// <summary>
        /// Creates a copy of an existing serverless cache’s snapshot. Available for Valkey, Redis
        /// OSS and Serverless Memcached only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyServerlessCacheSnapshot service method.</param>
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
        CopyServerlessCacheSnapshotResponse CopyServerlessCacheSnapshot(CopyServerlessCacheSnapshotRequest request);



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
        Task<CopyServerlessCacheSnapshotResponse> CopyServerlessCacheSnapshotAsync(CopyServerlessCacheSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CopySnapshot


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
        CopySnapshotResponse CopySnapshot(CopySnapshotRequest request);



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
        Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCacheCluster


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
        CreateCacheClusterResponse CreateCacheCluster(CreateCacheClusterRequest request);



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
        Task<CreateCacheClusterResponse> CreateCacheClusterAsync(CreateCacheClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCacheParameterGroup


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
        CreateCacheParameterGroupResponse CreateCacheParameterGroup(CreateCacheParameterGroupRequest request);



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
        Task<CreateCacheParameterGroupResponse> CreateCacheParameterGroupAsync(CreateCacheParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCacheSecurityGroup


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
        CreateCacheSecurityGroupResponse CreateCacheSecurityGroup(CreateCacheSecurityGroupRequest request);



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
        Task<CreateCacheSecurityGroupResponse> CreateCacheSecurityGroupAsync(CreateCacheSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCacheSubnetGroup


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
        CreateCacheSubnetGroupResponse CreateCacheSubnetGroup(CreateCacheSubnetGroupRequest request);



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
        Task<CreateCacheSubnetGroupResponse> CreateCacheSubnetGroupAsync(CreateCacheSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateGlobalReplicationGroup


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
        CreateGlobalReplicationGroupResponse CreateGlobalReplicationGroup(CreateGlobalReplicationGroupRequest request);



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
        Task<CreateGlobalReplicationGroupResponse> CreateGlobalReplicationGroupAsync(CreateGlobalReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateReplicationGroup


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
        CreateReplicationGroupResponse CreateReplicationGroup(CreateReplicationGroupRequest request);



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
        Task<CreateReplicationGroupResponse> CreateReplicationGroupAsync(CreateReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateServerlessCache


        /// <summary>
        /// Creates a serverless cache.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServerlessCache service method.</param>
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
        CreateServerlessCacheResponse CreateServerlessCache(CreateServerlessCacheRequest request);



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
        Task<CreateServerlessCacheResponse> CreateServerlessCacheAsync(CreateServerlessCacheRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateServerlessCacheSnapshot


        /// <summary>
        /// This API creates a copy of an entire ServerlessCache at a specific moment in time.
        /// Available for Valkey, Redis OSS and Serverless Memcached only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServerlessCacheSnapshot service method.</param>
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
        CreateServerlessCacheSnapshotResponse CreateServerlessCacheSnapshot(CreateServerlessCacheSnapshotRequest request);



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
        Task<CreateServerlessCacheSnapshotResponse> CreateServerlessCacheSnapshotAsync(CreateServerlessCacheSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSnapshot


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
        CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request);



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
        Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// For Valkey engine version 7.2 onwards and Redis OSS 6.0 to 7.1: Creates a user. For
        /// more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/Clusters.RBAC.html">Using
        /// Role Based Access Control (RBAC)</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
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
        CreateUserResponse CreateUser(CreateUserRequest request);



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
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUserGroup


        /// <summary>
        /// For Valkey engine version 7.2 onwards and Redis OSS 6.0 to 7.1: Creates a user group.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/Clusters.RBAC.html">Using
        /// Role Based Access Control (RBAC)</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserGroup service method.</param>
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
        CreateUserGroupResponse CreateUserGroup(CreateUserGroupRequest request);



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
        Task<CreateUserGroupResponse> CreateUserGroupAsync(CreateUserGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DecreaseNodeGroupsInGlobalReplicationGroup


        /// <summary>
        /// Decreases the number of node groups in a Global datastore
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DecreaseNodeGroupsInGlobalReplicationGroup service method.</param>
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
        DecreaseNodeGroupsInGlobalReplicationGroupResponse DecreaseNodeGroupsInGlobalReplicationGroup(DecreaseNodeGroupsInGlobalReplicationGroupRequest request);



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
        Task<DecreaseNodeGroupsInGlobalReplicationGroupResponse> DecreaseNodeGroupsInGlobalReplicationGroupAsync(DecreaseNodeGroupsInGlobalReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DecreaseReplicaCount


        /// <summary>
        /// Dynamically decreases the number of replicas in a Valkey or Redis OSS (cluster mode
        /// disabled) replication group or the number of replica nodes in one or more node groups
        /// (shards) of a Valkey or Redis OSS (cluster mode enabled) replication group. This operation
        /// is performed with no cluster down time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DecreaseReplicaCount service method.</param>
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
        DecreaseReplicaCountResponse DecreaseReplicaCount(DecreaseReplicaCountRequest request);



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
        Task<DecreaseReplicaCountResponse> DecreaseReplicaCountAsync(DecreaseReplicaCountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCacheCluster


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
        DeleteCacheClusterResponse DeleteCacheCluster(DeleteCacheClusterRequest request);



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
        Task<DeleteCacheClusterResponse> DeleteCacheClusterAsync(DeleteCacheClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCacheParameterGroup


        /// <summary>
        /// Deletes the specified cache parameter group. You cannot delete a cache parameter group
        /// if it is associated with any cache clusters. You cannot delete the default cache parameter
        /// groups in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheParameterGroup service method.</param>
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
        DeleteCacheParameterGroupResponse DeleteCacheParameterGroup(DeleteCacheParameterGroupRequest request);



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
        Task<DeleteCacheParameterGroupResponse> DeleteCacheParameterGroupAsync(DeleteCacheParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCacheSecurityGroup


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
        DeleteCacheSecurityGroupResponse DeleteCacheSecurityGroup(DeleteCacheSecurityGroupRequest request);



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
        Task<DeleteCacheSecurityGroupResponse> DeleteCacheSecurityGroupAsync(DeleteCacheSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCacheSubnetGroup


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
        /// 
        /// <returns>The response from the DeleteCacheSubnetGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetGroupInUseException">
        /// The requested cache subnet group is currently in use.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DeleteCacheSubnetGroup">REST API Reference for DeleteCacheSubnetGroup Operation</seealso>
        DeleteCacheSubnetGroupResponse DeleteCacheSubnetGroup(DeleteCacheSubnetGroupRequest request);



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
        Task<DeleteCacheSubnetGroupResponse> DeleteCacheSubnetGroupAsync(DeleteCacheSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteGlobalReplicationGroup


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
        DeleteGlobalReplicationGroupResponse DeleteGlobalReplicationGroup(DeleteGlobalReplicationGroupRequest request);



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
        Task<DeleteGlobalReplicationGroupResponse> DeleteGlobalReplicationGroupAsync(DeleteGlobalReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteReplicationGroup


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
        DeleteReplicationGroupResponse DeleteReplicationGroup(DeleteReplicationGroupRequest request);



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
        Task<DeleteReplicationGroupResponse> DeleteReplicationGroupAsync(DeleteReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteServerlessCache


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
        DeleteServerlessCacheResponse DeleteServerlessCache(DeleteServerlessCacheRequest request);



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
        Task<DeleteServerlessCacheResponse> DeleteServerlessCacheAsync(DeleteServerlessCacheRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteServerlessCacheSnapshot


        /// <summary>
        /// Deletes an existing serverless cache snapshot. Available for Valkey, Redis OSS and
        /// Serverless Memcached only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerlessCacheSnapshot service method.</param>
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
        DeleteServerlessCacheSnapshotResponse DeleteServerlessCacheSnapshot(DeleteServerlessCacheSnapshotRequest request);



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
        Task<DeleteServerlessCacheSnapshotResponse> DeleteServerlessCacheSnapshotAsync(DeleteServerlessCacheSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSnapshot


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
        DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request);



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
        Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// For Valkey engine version 7.2 onwards and Redis OSS 6.0 onwards: Deletes a user. The
        /// user will be removed from all user groups and in turn removed from all replication
        /// groups. For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/Clusters.RBAC.html">Using
        /// Role Based Access Control (RBAC)</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
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
        DeleteUserResponse DeleteUser(DeleteUserRequest request);



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
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUserGroup


        /// <summary>
        /// For Valkey engine version 7.2 onwards and Redis OSS 6.0 onwards: Deletes a user group.
        /// The user group must first be disassociated from the replication group before it can
        /// be deleted. For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/Clusters.RBAC.html">Using
        /// Role Based Access Control (RBAC)</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserGroup service method.</param>
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
        DeleteUserGroupResponse DeleteUserGroup(DeleteUserGroupRequest request);



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
        Task<DeleteUserGroupResponse> DeleteUserGroupAsync(DeleteUserGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCacheClusters


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
        DescribeCacheClustersResponse DescribeCacheClusters();


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
        DescribeCacheClustersResponse DescribeCacheClusters(DescribeCacheClustersRequest request);


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
        Task<DescribeCacheClustersResponse> DescribeCacheClustersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



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
        Task<DescribeCacheClustersResponse> DescribeCacheClustersAsync(DescribeCacheClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCacheEngineVersions


        /// <summary>
        /// Returns a list of the available cache engines and their versions.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by ElastiCache.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheEngineVersions">REST API Reference for DescribeCacheEngineVersions Operation</seealso>
        DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions();


        /// <summary>
        /// Returns a list of the available cache engines and their versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheEngineVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by ElastiCache.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheEngineVersions">REST API Reference for DescribeCacheEngineVersions Operation</seealso>
        DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest request);


        /// <summary>
        /// Returns a list of the available cache engines and their versions.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by ElastiCache.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheEngineVersions">REST API Reference for DescribeCacheEngineVersions Operation</seealso>
        Task<DescribeCacheEngineVersionsResponse> DescribeCacheEngineVersionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



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
        Task<DescribeCacheEngineVersionsResponse> DescribeCacheEngineVersionsAsync(DescribeCacheEngineVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCacheParameterGroups


        /// <summary>
        /// Returns a list of cache parameter group descriptions. If a cache parameter group name
        /// is specified, the list contains only the descriptions for that group.
        /// </summary>
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
        DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups();


        /// <summary>
        /// Returns a list of cache parameter group descriptions. If a cache parameter group name
        /// is specified, the list contains only the descriptions for that group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameterGroups service method.</param>
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
        DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest request);


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
        Task<DescribeCacheParameterGroupsResponse> DescribeCacheParameterGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



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
        Task<DescribeCacheParameterGroupsResponse> DescribeCacheParameterGroupsAsync(DescribeCacheParameterGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCacheParameters


        /// <summary>
        /// Returns the detailed parameter list for a particular cache parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameters service method.</param>
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
        DescribeCacheParametersResponse DescribeCacheParameters(DescribeCacheParametersRequest request);



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
        Task<DescribeCacheParametersResponse> DescribeCacheParametersAsync(DescribeCacheParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCacheSecurityGroups


        /// <summary>
        /// Returns a list of cache security group descriptions. If a cache security group name
        /// is specified, the list contains only the description of that group. This applicable
        /// only when you have ElastiCache in Classic setup
        /// </summary>
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
        DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups();


        /// <summary>
        /// Returns a list of cache security group descriptions. If a cache security group name
        /// is specified, the list contains only the description of that group. This applicable
        /// only when you have ElastiCache in Classic setup
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSecurityGroups service method.</param>
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
        DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest request);


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
        Task<DescribeCacheSecurityGroupsResponse> DescribeCacheSecurityGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



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
        Task<DescribeCacheSecurityGroupsResponse> DescribeCacheSecurityGroupsAsync(DescribeCacheSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCacheSubnetGroups


        /// <summary>
        /// Returns a list of cache subnet group descriptions. If a subnet group name is specified,
        /// the list contains only the description of that group. This is applicable only when
        /// you have ElastiCache in VPC setup. All ElastiCache clusters now launch in VPC by default.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheSubnetGroups">REST API Reference for DescribeCacheSubnetGroups Operation</seealso>
        DescribeCacheSubnetGroupsResponse DescribeCacheSubnetGroups();


        /// <summary>
        /// Returns a list of cache subnet group descriptions. If a subnet group name is specified,
        /// the list contains only the description of that group. This is applicable only when
        /// you have ElastiCache in VPC setup. All ElastiCache clusters now launch in VPC by default.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeCacheSubnetGroups">REST API Reference for DescribeCacheSubnetGroups Operation</seealso>
        DescribeCacheSubnetGroupsResponse DescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest request);


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
        Task<DescribeCacheSubnetGroupsResponse> DescribeCacheSubnetGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



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
        Task<DescribeCacheSubnetGroupsResponse> DescribeCacheSubnetGroupsAsync(DescribeCacheSubnetGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEngineDefaultParameters


        /// <summary>
        /// Returns the default engine and system parameter information for the specified cache
        /// engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeEngineDefaultParameters">REST API Reference for DescribeEngineDefaultParameters Operation</seealso>
        DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request);



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
        Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEvents


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
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        DescribeEventsResponse DescribeEvents();


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
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest request);


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
        Task<DescribeEventsResponse> DescribeEventsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



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
        Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeGlobalReplicationGroups


        /// <summary>
        /// Returns information about a particular global replication group. If no identifier
        /// is specified, returns information about all Global datastores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalReplicationGroups service method.</param>
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
        DescribeGlobalReplicationGroupsResponse DescribeGlobalReplicationGroups(DescribeGlobalReplicationGroupsRequest request);



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
        Task<DescribeGlobalReplicationGroupsResponse> DescribeGlobalReplicationGroupsAsync(DescribeGlobalReplicationGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReplicationGroups


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
        DescribeReplicationGroupsResponse DescribeReplicationGroups();


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
        DescribeReplicationGroupsResponse DescribeReplicationGroups(DescribeReplicationGroupsRequest request);


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
        Task<DescribeReplicationGroupsResponse> DescribeReplicationGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



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
        Task<DescribeReplicationGroupsResponse> DescribeReplicationGroupsAsync(DescribeReplicationGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReservedCacheNodes


        /// <summary>
        /// Returns information about reserved cache nodes for this account, or about a specified
        /// reserved cache node.
        /// </summary>
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
        DescribeReservedCacheNodesResponse DescribeReservedCacheNodes();


        /// <summary>
        /// Returns information about reserved cache nodes for this account, or about a specified
        /// reserved cache node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodes service method.</param>
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
        DescribeReservedCacheNodesResponse DescribeReservedCacheNodes(DescribeReservedCacheNodesRequest request);


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
        Task<DescribeReservedCacheNodesResponse> DescribeReservedCacheNodesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



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
        Task<DescribeReservedCacheNodesResponse> DescribeReservedCacheNodesAsync(DescribeReservedCacheNodesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReservedCacheNodesOfferings


        /// <summary>
        /// Lists available reserved cache node offerings.
        /// </summary>
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
        DescribeReservedCacheNodesOfferingsResponse DescribeReservedCacheNodesOfferings();


        /// <summary>
        /// Lists available reserved cache node offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodesOfferings service method.</param>
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
        DescribeReservedCacheNodesOfferingsResponse DescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest request);


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
        Task<DescribeReservedCacheNodesOfferingsResponse> DescribeReservedCacheNodesOfferingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



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
        Task<DescribeReservedCacheNodesOfferingsResponse> DescribeReservedCacheNodesOfferingsAsync(DescribeReservedCacheNodesOfferingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeServerlessCaches


        /// <summary>
        /// Returns information about a specific serverless cache. If no identifier is specified,
        /// then the API returns information on all the serverless caches belonging to this Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServerlessCaches service method.</param>
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
        DescribeServerlessCachesResponse DescribeServerlessCaches(DescribeServerlessCachesRequest request);



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
        Task<DescribeServerlessCachesResponse> DescribeServerlessCachesAsync(DescribeServerlessCachesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeServerlessCacheSnapshots


        /// <summary>
        /// Returns information about serverless cache snapshots. By default, this API lists all
        /// of the customer’s serverless cache snapshots. It can also describe a single serverless
        /// cache snapshot, or the snapshots associated with a particular serverless cache. Available
        /// for Valkey, Redis OSS and Serverless Memcached only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServerlessCacheSnapshots service method.</param>
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
        DescribeServerlessCacheSnapshotsResponse DescribeServerlessCacheSnapshots(DescribeServerlessCacheSnapshotsRequest request);



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
        Task<DescribeServerlessCacheSnapshotsResponse> DescribeServerlessCacheSnapshotsAsync(DescribeServerlessCacheSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeServiceUpdates


        /// <summary>
        /// Returns details of the service updates
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceUpdates service method.</param>
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
        DescribeServiceUpdatesResponse DescribeServiceUpdates(DescribeServiceUpdatesRequest request);



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
        Task<DescribeServiceUpdatesResponse> DescribeServiceUpdatesAsync(DescribeServiceUpdatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSnapshots


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
        DescribeSnapshotsResponse DescribeSnapshots();


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
        DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request);


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
        Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



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
        Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUpdateActions


        /// <summary>
        /// Returns details of the update actions
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUpdateActions service method.</param>
        /// 
        /// <returns>The response from the DescribeUpdateActions service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/DescribeUpdateActions">REST API Reference for DescribeUpdateActions Operation</seealso>
        DescribeUpdateActionsResponse DescribeUpdateActions(DescribeUpdateActionsRequest request);



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
        Task<DescribeUpdateActionsResponse> DescribeUpdateActionsAsync(DescribeUpdateActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUserGroups


        /// <summary>
        /// Returns a list of user groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserGroups service method.</param>
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
        DescribeUserGroupsResponse DescribeUserGroups(DescribeUserGroupsRequest request);



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
        Task<DescribeUserGroupsResponse> DescribeUserGroupsAsync(DescribeUserGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUsers


        /// <summary>
        /// Returns a list of users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsers service method.</param>
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
        DescribeUsersResponse DescribeUsers(DescribeUsersRequest request);



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
        Task<DescribeUsersResponse> DescribeUsersAsync(DescribeUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateGlobalReplicationGroup


        /// <summary>
        /// Remove a secondary cluster from the Global datastore using the Global datastore name.
        /// The secondary cluster will no longer receive updates from the primary cluster, but
        /// will remain as a standalone cluster in that Amazon region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateGlobalReplicationGroup service method.</param>
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
        DisassociateGlobalReplicationGroupResponse DisassociateGlobalReplicationGroup(DisassociateGlobalReplicationGroupRequest request);



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
        Task<DisassociateGlobalReplicationGroupResponse> DisassociateGlobalReplicationGroupAsync(DisassociateGlobalReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExportServerlessCacheSnapshot


        /// <summary>
        /// Provides the functionality to export the serverless cache snapshot data to Amazon
        /// S3. Available for Valkey and Redis OSS only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportServerlessCacheSnapshot service method.</param>
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
        ExportServerlessCacheSnapshotResponse ExportServerlessCacheSnapshot(ExportServerlessCacheSnapshotRequest request);



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
        Task<ExportServerlessCacheSnapshotResponse> ExportServerlessCacheSnapshotAsync(ExportServerlessCacheSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  FailoverGlobalReplicationGroup


        /// <summary>
        /// Used to failover the primary region to a secondary region. The secondary region will
        /// become primary, and all other clusters will become secondary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverGlobalReplicationGroup service method.</param>
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
        FailoverGlobalReplicationGroupResponse FailoverGlobalReplicationGroup(FailoverGlobalReplicationGroupRequest request);



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
        Task<FailoverGlobalReplicationGroupResponse> FailoverGlobalReplicationGroupAsync(FailoverGlobalReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  IncreaseNodeGroupsInGlobalReplicationGroup


        /// <summary>
        /// Increase the number of node groups in the Global datastore
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IncreaseNodeGroupsInGlobalReplicationGroup service method.</param>
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
        IncreaseNodeGroupsInGlobalReplicationGroupResponse IncreaseNodeGroupsInGlobalReplicationGroup(IncreaseNodeGroupsInGlobalReplicationGroupRequest request);



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
        Task<IncreaseNodeGroupsInGlobalReplicationGroupResponse> IncreaseNodeGroupsInGlobalReplicationGroupAsync(IncreaseNodeGroupsInGlobalReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  IncreaseReplicaCount


        /// <summary>
        /// Dynamically increases the number of replicas in a Valkey or Redis OSS (cluster mode
        /// disabled) replication group or the number of replica nodes in one or more node groups
        /// (shards) of a Valkey or Redis OSS (cluster mode enabled) replication group. This operation
        /// is performed with no cluster down time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IncreaseReplicaCount service method.</param>
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
        IncreaseReplicaCountResponse IncreaseReplicaCount(IncreaseReplicaCountRequest request);



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
        Task<IncreaseReplicaCountResponse> IncreaseReplicaCountAsync(IncreaseReplicaCountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAllowedNodeTypeModifications


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
        ListAllowedNodeTypeModificationsResponse ListAllowedNodeTypeModifications(ListAllowedNodeTypeModificationsRequest request);



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
        Task<ListAllowedNodeTypeModificationsResponse> ListAllowedNodeTypeModificationsAsync(ListAllowedNodeTypeModificationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyCacheCluster


        /// <summary>
        /// Modifies the settings for a cluster. You can use this operation to change one or more
        /// cluster configuration parameters by specifying the parameters and the new values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheCluster service method.</param>
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
        ModifyCacheClusterResponse ModifyCacheCluster(ModifyCacheClusterRequest request);



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
        Task<ModifyCacheClusterResponse> ModifyCacheClusterAsync(ModifyCacheClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyCacheParameterGroup


        /// <summary>
        /// Modifies the parameters of a cache parameter group. You can modify up to 20 parameters
        /// in a single request by submitting a list parameter name and value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheParameterGroup service method.</param>
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
        ModifyCacheParameterGroupResponse ModifyCacheParameterGroup(ModifyCacheParameterGroupRequest request);



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
        Task<ModifyCacheParameterGroupResponse> ModifyCacheParameterGroupAsync(ModifyCacheParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyCacheSubnetGroup


        /// <summary>
        /// Modifies an existing cache subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheSubnetGroup service method.</param>
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
        ModifyCacheSubnetGroupResponse ModifyCacheSubnetGroup(ModifyCacheSubnetGroupRequest request);



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
        Task<ModifyCacheSubnetGroupResponse> ModifyCacheSubnetGroupAsync(ModifyCacheSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyGlobalReplicationGroup


        /// <summary>
        /// Modifies the settings for a Global datastore.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyGlobalReplicationGroup service method.</param>
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
        ModifyGlobalReplicationGroupResponse ModifyGlobalReplicationGroup(ModifyGlobalReplicationGroupRequest request);



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
        Task<ModifyGlobalReplicationGroupResponse> ModifyGlobalReplicationGroupAsync(ModifyGlobalReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyReplicationGroup


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
        ModifyReplicationGroupResponse ModifyReplicationGroup(ModifyReplicationGroupRequest request);



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
        Task<ModifyReplicationGroupResponse> ModifyReplicationGroupAsync(ModifyReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyReplicationGroupShardConfiguration


        /// <summary>
        /// Modifies a replication group's shards (node groups) by allowing you to add shards,
        /// remove shards, or rebalance the keyspaces among existing shards.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationGroupShardConfiguration service method.</param>
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
        ModifyReplicationGroupShardConfigurationResponse ModifyReplicationGroupShardConfiguration(ModifyReplicationGroupShardConfigurationRequest request);



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
        Task<ModifyReplicationGroupShardConfigurationResponse> ModifyReplicationGroupShardConfigurationAsync(ModifyReplicationGroupShardConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyServerlessCache


        /// <summary>
        /// This API modifies the attributes of a serverless cache.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyServerlessCache service method.</param>
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
        ModifyServerlessCacheResponse ModifyServerlessCache(ModifyServerlessCacheRequest request);



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
        Task<ModifyServerlessCacheResponse> ModifyServerlessCacheAsync(ModifyServerlessCacheRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyUser


        /// <summary>
        /// Changes user password(s) and/or access string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyUser service method.</param>
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
        ModifyUserResponse ModifyUser(ModifyUserRequest request);



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
        Task<ModifyUserResponse> ModifyUserAsync(ModifyUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyUserGroup


        /// <summary>
        /// Changes the list of users that belong to the user group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyUserGroup service method.</param>
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
        ModifyUserGroupResponse ModifyUserGroup(ModifyUserGroupRequest request);



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
        Task<ModifyUserGroupResponse> ModifyUserGroupAsync(ModifyUserGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PurchaseReservedCacheNodesOffering


        /// <summary>
        /// Allows you to purchase a reserved cache node offering. Reserved nodes are not eligible
        /// for cancellation and are non-refundable. For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/reserved-nodes.html">Managing
        /// Costs with Reserved Nodes</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedCacheNodesOffering service method.</param>
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
        PurchaseReservedCacheNodesOfferingResponse PurchaseReservedCacheNodesOffering(PurchaseReservedCacheNodesOfferingRequest request);



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
        Task<PurchaseReservedCacheNodesOfferingResponse> PurchaseReservedCacheNodesOfferingAsync(PurchaseReservedCacheNodesOfferingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RebalanceSlotsInGlobalReplicationGroup


        /// <summary>
        /// Redistribute slots to ensure uniform distribution across existing shards in the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebalanceSlotsInGlobalReplicationGroup service method.</param>
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
        RebalanceSlotsInGlobalReplicationGroupResponse RebalanceSlotsInGlobalReplicationGroup(RebalanceSlotsInGlobalReplicationGroupRequest request);



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
        Task<RebalanceSlotsInGlobalReplicationGroupResponse> RebalanceSlotsInGlobalReplicationGroupAsync(RebalanceSlotsInGlobalReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RebootCacheCluster


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
        /// 
        /// <returns>The response from the RebootCacheCluster service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cluster is not in the <c>available</c> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticache-2015-02-02/RebootCacheCluster">REST API Reference for RebootCacheCluster Operation</seealso>
        RebootCacheClusterResponse RebootCacheCluster(RebootCacheClusterRequest request);



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
        Task<RebootCacheClusterResponse> RebootCacheClusterAsync(RebootCacheClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveTagsFromResource


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
        RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request);



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
        Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResetCacheParameterGroup


        /// <summary>
        /// Modifies the parameters of a cache parameter group to the engine or system default
        /// value. You can reset specific parameters by submitting a list of parameter names.
        /// To reset the entire cache parameter group, specify the <c>ResetAllParameters</c> and
        /// <c>CacheParameterGroupName</c> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetCacheParameterGroup service method.</param>
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
        ResetCacheParameterGroupResponse ResetCacheParameterGroup(ResetCacheParameterGroupRequest request);



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
        Task<ResetCacheParameterGroupResponse> ResetCacheParameterGroupAsync(ResetCacheParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RevokeCacheSecurityGroupIngress


        /// <summary>
        /// Revokes ingress from a cache security group. Use this operation to disallow access
        /// from an Amazon EC2 security group that had been previously authorized.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeCacheSecurityGroupIngress service method.</param>
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
        RevokeCacheSecurityGroupIngressResponse RevokeCacheSecurityGroupIngress(RevokeCacheSecurityGroupIngressRequest request);



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
        Task<RevokeCacheSecurityGroupIngressResponse> RevokeCacheSecurityGroupIngressAsync(RevokeCacheSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartMigration


        /// <summary>
        /// Start the migration of data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMigration service method.</param>
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
        StartMigrationResponse StartMigration(StartMigrationRequest request);



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
        Task<StartMigrationResponse> StartMigrationAsync(StartMigrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TestFailover


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
        TestFailoverResponse TestFailover(TestFailoverRequest request);



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
        Task<TestFailoverResponse> TestFailoverAsync(TestFailoverRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TestMigration


        /// <summary>
        /// Async API to test connection between source and target replication group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestMigration service method.</param>
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
        TestMigrationResponse TestMigration(TestMigrationRequest request);



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
        Task<TestMigrationResponse> TestMigrationAsync(TestMigrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}