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
 * Do not modify this file. This file is generated from the elasticache-2014-07-15.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ElastiCache.Model;

namespace Amazon.ElastiCache
{
    /// <summary>
    /// Interface for accessing ElastiCache
    ///
    /// Amazon ElastiCache 
    /// <para>
    /// Amazon ElastiCache is a web service that makes it easier to set up, operate, and scale
    /// a distributed cache in the cloud.
    /// </para>
    ///  
    /// <para>
    /// With ElastiCache, customers gain all of the benefits of a high-performance, in-memory
    /// cache with far less of the administrative burden of launching and managing a distributed
    /// cache. The service makes set-up, scaling, and cluster failure handling much simpler
    /// than in a self-managed cache deployment.
    /// </para>
    ///  
    /// <para>
    /// In addition, through integration with Amazon CloudWatch, customers get enhanced visibility
    /// into the key performance statistics associated with their cache and can receive alarms
    /// if a part of their cache runs hot.
    /// </para>
    /// </summary>
    public partial interface IAmazonElastiCache : IDisposable
    {
                
        #region  AuthorizeCacheSecurityGroupIngress


        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeCacheSecurityGroupIngress operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeCacheSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AuthorizeCacheSecurityGroupIngressResponse> AuthorizeCacheSecurityGroupIngressAsync(AuthorizeCacheSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CopySnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the CopySnapshot operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCacheCluster


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateCacheClusterResponse> CreateCacheClusterAsync(CreateCacheClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCacheParameterGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateCacheParameterGroupResponse> CreateCacheParameterGroupAsync(CreateCacheParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCacheSecurityGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheSecurityGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateCacheSecurityGroupResponse> CreateCacheSecurityGroupAsync(CreateCacheSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCacheSubnetGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateCacheSubnetGroupResponse> CreateCacheSubnetGroupAsync(CreateCacheSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateReplicationGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateReplicationGroupResponse> CreateReplicationGroupAsync(CreateReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCacheCluster


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteCacheClusterResponse> DeleteCacheClusterAsync(DeleteCacheClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCacheParameterGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteCacheParameterGroupResponse> DeleteCacheParameterGroupAsync(DeleteCacheParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCacheSecurityGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheSecurityGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteCacheSecurityGroupResponse> DeleteCacheSecurityGroupAsync(DeleteCacheSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCacheSubnetGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteCacheSubnetGroupResponse> DeleteCacheSubnetGroupAsync(DeleteCacheSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteReplicationGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteReplicationGroupResponse> DeleteReplicationGroupAsync(DeleteReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCacheClusters


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheClusters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeCacheClustersResponse> DescribeCacheClustersAsync(DescribeCacheClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCacheEngineVersions


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheEngineVersions operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheEngineVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeCacheEngineVersionsResponse> DescribeCacheEngineVersionsAsync(DescribeCacheEngineVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCacheParameterGroups


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheParameterGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeCacheParameterGroupsResponse> DescribeCacheParameterGroupsAsync(DescribeCacheParameterGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCacheParameters


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheParameters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeCacheParametersResponse> DescribeCacheParametersAsync(DescribeCacheParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCacheSecurityGroups


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheSecurityGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeCacheSecurityGroupsResponse> DescribeCacheSecurityGroupsAsync(DescribeCacheSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCacheSubnetGroups


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheSubnetGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeCacheSubnetGroupsResponse> DescribeCacheSubnetGroupsAsync(DescribeCacheSubnetGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEngineDefaultParameters


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEvents


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReplicationGroups


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationGroups operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeReplicationGroupsResponse> DescribeReplicationGroupsAsync(DescribeReplicationGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReservedCacheNodes


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedCacheNodes operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeReservedCacheNodesResponse> DescribeReservedCacheNodesAsync(DescribeReservedCacheNodesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReservedCacheNodesOfferings


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedCacheNodesOfferings operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodesOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeReservedCacheNodesOfferingsResponse> DescribeReservedCacheNodesOfferingsAsync(DescribeReservedCacheNodesOfferingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSnapshots


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyCacheCluster


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyCacheClusterResponse> ModifyCacheClusterAsync(ModifyCacheClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyCacheParameterGroup


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyCacheParameterGroupResponse> ModifyCacheParameterGroupAsync(ModifyCacheParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyCacheSubnetGroup


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyCacheSubnetGroupResponse> ModifyCacheSubnetGroupAsync(ModifyCacheSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyReplicationGroup


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyReplicationGroupResponse> ModifyReplicationGroupAsync(ModifyReplicationGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PurchaseReservedCacheNodesOffering


        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedCacheNodesOffering operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedCacheNodesOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PurchaseReservedCacheNodesOfferingResponse> PurchaseReservedCacheNodesOfferingAsync(PurchaseReservedCacheNodesOfferingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RebootCacheCluster


        /// <summary>
        /// Initiates the asynchronous execution of the RebootCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootCacheCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RebootCacheClusterResponse> RebootCacheClusterAsync(RebootCacheClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetCacheParameterGroup


        /// <summary>
        /// Initiates the asynchronous execution of the ResetCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetCacheParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ResetCacheParameterGroupResponse> ResetCacheParameterGroupAsync(ResetCacheParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeCacheSecurityGroupIngress


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeCacheSecurityGroupIngress operation.
        /// <seealso cref="Amazon.ElastiCache.IAmazonElastiCache"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeCacheSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RevokeCacheSecurityGroupIngressResponse> RevokeCacheSecurityGroupIngressAsync(RevokeCacheSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}