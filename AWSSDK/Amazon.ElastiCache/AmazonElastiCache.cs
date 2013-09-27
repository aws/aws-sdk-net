/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.ElastiCache;
using Amazon.ElastiCache.Model;

namespace Amazon.ElastiCache
{
    /// <summary>
    /// Interface for accessing AmazonElastiCache.
    ///  
    ///  Amazon ElastiCache <para>Amazon ElastiCache is a web service that makes it easier to set up, operate, and scale a distributed cache in the
    /// cloud.</para> <para>With ElastiCache, customers gain all of the benefits of a high-performance, in-memory cache with far less of the
    /// administrative burden of launching and managing a distributed cache. The service makes set-up, scaling, and cluster failure handling much
    /// simpler than in a self-managed cache deployment.</para> <para>In addition, through integration with Amazon CloudWatch, customers get
    /// enhanced visibility into the key performance statistics associated with their cache and can receive alarms if a part of their cache runs
    /// hot.</para>
    /// </summary>
    public interface AmazonElastiCache : IDisposable
    {
        

        #region DescribeReservedCacheNodesOfferings

        /// <summary>
        /// <para>The <i>DescribeReservedCacheNodesOfferings</i> operation lists available reserved cache node offerings.</para>
        /// </summary>
        /// 
        /// <param name="describeReservedCacheNodesOfferingsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedCacheNodesOfferings service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodesOfferings service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="ReservedCacheNodesOfferingNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        DescribeReservedCacheNodesOfferingsResponse DescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest describeReservedCacheNodesOfferingsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedCacheNodesOfferings operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeReservedCacheNodesOfferings"/>
        /// </summary>
        /// 
        /// <param name="describeReservedCacheNodesOfferingsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedCacheNodesOfferings operation on AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReservedCacheNodesOfferings operation.</returns>
        IAsyncResult BeginDescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest describeReservedCacheNodesOfferingsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReservedCacheNodesOfferings operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeReservedCacheNodesOfferings"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedCacheNodesOfferings.</param>
        /// 
        /// <returns>Returns a DescribeReservedCacheNodesOfferingsResult from AmazonElastiCache.</returns>
        DescribeReservedCacheNodesOfferingsResponse EndDescribeReservedCacheNodesOfferings(IAsyncResult asyncResult);

        /// <summary>
        /// <para>The <i>DescribeReservedCacheNodesOfferings</i> operation lists available reserved cache node offerings.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodesOfferings service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="ReservedCacheNodesOfferingNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        DescribeReservedCacheNodesOfferingsResponse DescribeReservedCacheNodesOfferings();
        
        #endregion
        
    

        #region DeleteReplicationGroup

        /// <summary>
        /// <para>The <i>DeleteReplicationGroup</i> operation deletes an existing replication group. <i>DeleteReplicationGroup</i> deletes the primary
        /// cache cluster and all of the read replicas in the replication group. When you receive a successful response from this operation, Amazon
        /// ElastiCache immediately begins deleting the entire replication group; you cannot cancel or revert this operation.</para>
        /// </summary>
        /// 
        /// <param name="deleteReplicationGroupRequest">Container for the necessary parameters to execute the DeleteReplicationGroup service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DeleteReplicationGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidReplicationGroupStateException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="ReplicationGroupNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        DeleteReplicationGroupResponse DeleteReplicationGroup(DeleteReplicationGroupRequest deleteReplicationGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteReplicationGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteReplicationGroupRequest">Container for the necessary parameters to execute the DeleteReplicationGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteReplicationGroup operation.</returns>
        IAsyncResult BeginDeleteReplicationGroup(DeleteReplicationGroupRequest deleteReplicationGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteReplicationGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationGroup.</param>
        /// 
        /// <returns>Returns a ReplicationGroup from AmazonElastiCache.</returns>
        DeleteReplicationGroupResponse EndDeleteReplicationGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ModifyCacheCluster

        /// <summary>
        /// <para>The <i>ModifyCacheCluster</i> operation modifies the settings for a cache cluster. You can use this operation to change one or more
        /// cluster configuration parameters by specifying the parameters and the new values.</para>
        /// </summary>
        /// 
        /// <param name="modifyCacheClusterRequest">Container for the necessary parameters to execute the ModifyCacheCluster service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="NodeQuotaForCustomerExceededException"/>
        /// <exception cref="NodeQuotaForClusterExceededException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidCacheSecurityGroupStateException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        /// <exception cref="CacheClusterNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        /// <exception cref="InvalidCacheClusterStateException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
        ModifyCacheClusterResponse ModifyCacheCluster(ModifyCacheClusterRequest modifyCacheClusterRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ModifyCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="modifyCacheClusterRequest">Container for the necessary parameters to execute the ModifyCacheCluster operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyCacheCluster operation.</returns>
        IAsyncResult BeginModifyCacheCluster(ModifyCacheClusterRequest modifyCacheClusterRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ModifyCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCacheCluster.</param>
        /// 
        /// <returns>Returns a CacheCluster from AmazonElastiCache.</returns>
        ModifyCacheClusterResponse EndModifyCacheCluster(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RevokeCacheSecurityGroupIngress

        /// <summary>
        /// <para>The <i>RevokeCacheSecurityGroupIngress</i> operation revokes ingress from a cache security group. Use this operation to disallow
        /// access from an Amazon EC2 security group that had been previously authorized.</para>
        /// </summary>
        /// 
        /// <param name="revokeCacheSecurityGroupIngressRequest">Container for the necessary parameters to execute the RevokeCacheSecurityGroupIngress
        ///          service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the RevokeCacheSecurityGroupIngress service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidCacheSecurityGroupStateException"/>
        /// <exception cref="AuthorizationNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
        RevokeCacheSecurityGroupIngressResponse RevokeCacheSecurityGroupIngress(RevokeCacheSecurityGroupIngressRequest revokeCacheSecurityGroupIngressRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeCacheSecurityGroupIngress operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.RevokeCacheSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="revokeCacheSecurityGroupIngressRequest">Container for the necessary parameters to execute the RevokeCacheSecurityGroupIngress
        ///          operation on AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRevokeCacheSecurityGroupIngress operation.</returns>
        IAsyncResult BeginRevokeCacheSecurityGroupIngress(RevokeCacheSecurityGroupIngressRequest revokeCacheSecurityGroupIngressRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RevokeCacheSecurityGroupIngress operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.RevokeCacheSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeCacheSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a CacheSecurityGroup from AmazonElastiCache.</returns>
        RevokeCacheSecurityGroupIngressResponse EndRevokeCacheSecurityGroupIngress(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeReplicationGroups

        /// <summary>
        /// <para>The <i>DescribeReplicationGroups</i> operation returns information about a particular replication group. If no identifier is
        /// specified, <i>DescribeReplicationGroups</i> returns information about all replication groups.</para>
        /// </summary>
        /// 
        /// <param name="describeReplicationGroupsRequest">Container for the necessary parameters to execute the DescribeReplicationGroups service
        ///          method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeReplicationGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="ReplicationGroupNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        DescribeReplicationGroupsResponse DescribeReplicationGroups(DescribeReplicationGroupsRequest describeReplicationGroupsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationGroups operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeReplicationGroups"/>
        /// </summary>
        /// 
        /// <param name="describeReplicationGroupsRequest">Container for the necessary parameters to execute the DescribeReplicationGroups operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReplicationGroups operation.</returns>
        IAsyncResult BeginDescribeReplicationGroups(DescribeReplicationGroupsRequest describeReplicationGroupsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReplicationGroups operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeReplicationGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationGroups.</param>
        /// 
        /// <returns>Returns a DescribeReplicationGroupsResult from AmazonElastiCache.</returns>
        DescribeReplicationGroupsResponse EndDescribeReplicationGroups(IAsyncResult asyncResult);

        /// <summary>
        /// <para>The <i>DescribeReplicationGroups</i> operation returns information about a particular replication group. If no identifier is
        /// specified, <i>DescribeReplicationGroups</i> returns information about all replication groups.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReplicationGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="ReplicationGroupNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        DescribeReplicationGroupsResponse DescribeReplicationGroups();
        
        #endregion
        
    

        #region CreateCacheCluster

        /// <summary>
        /// <para>The <i>CreateCacheCluster</i> operation creates a new cache cluster. All nodes in the cache cluster run the same protocol-compliant
        /// cache engine software - either Memcached or Redis.</para>
        /// </summary>
        /// 
        /// <param name="createCacheClusterRequest">Container for the necessary parameters to execute the CreateCacheCluster service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="NodeQuotaForCustomerExceededException"/>
        /// <exception cref="ClusterQuotaForCustomerExceededException"/>
        /// <exception cref="CacheClusterAlreadyExistsException"/>
        /// <exception cref="InsufficientCacheClusterCapacityException"/>
        /// <exception cref="ReplicationGroupNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
        /// <exception cref="NodeQuotaForClusterExceededException"/>
        /// <exception cref="CacheSubnetGroupNotFoundException"/>
        /// <exception cref="InvalidReplicationGroupStateException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        CreateCacheClusterResponse CreateCacheCluster(CreateCacheClusterRequest createCacheClusterRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="createCacheClusterRequest">Container for the necessary parameters to execute the CreateCacheCluster operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateCacheCluster operation.</returns>
        IAsyncResult BeginCreateCacheCluster(CreateCacheClusterRequest createCacheClusterRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCacheCluster.</param>
        /// 
        /// <returns>Returns a CacheCluster from AmazonElastiCache.</returns>
        CreateCacheClusterResponse EndCreateCacheCluster(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateReplicationGroup

        /// <summary>
        /// <para>The <i>CreateReplicationGroup</i> operation creates a replication group. A replication group is a collection of cache clusters, where
        /// one of the clusters is a read/write primary and the other clusters are read-only replicas. Writes to the primary are automatically
        /// propagated to the replicas.</para> <para>When you create a replication group, you must specify an existing cache cluster that is in the
        /// primary role. When the replication group has been successfully created, you can add one or more read replica replicas to it, up to a total
        /// of five read replicas.</para>
        /// </summary>
        /// 
        /// <param name="createReplicationGroupRequest">Container for the necessary parameters to execute the CreateReplicationGroup service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateReplicationGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="ReplicationGroupAlreadyExistsException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="CacheClusterNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="InvalidCacheClusterStateException"/>
        CreateReplicationGroupResponse CreateReplicationGroup(CreateReplicationGroupRequest createReplicationGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateReplicationGroup"/>
        /// </summary>
        /// 
        /// <param name="createReplicationGroupRequest">Container for the necessary parameters to execute the CreateReplicationGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateReplicationGroup operation.</returns>
        IAsyncResult BeginCreateReplicationGroup(CreateReplicationGroupRequest createReplicationGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateReplicationGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicationGroup.</param>
        /// 
        /// <returns>Returns a ReplicationGroup from AmazonElastiCache.</returns>
        CreateReplicationGroupResponse EndCreateReplicationGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteCacheCluster

        /// <summary>
        /// <para>The <i>DeleteCacheCluster</i> operation deletes a previously provisioned cache cluster. <i>DeleteCacheCluster</i> deletes all
        /// associated cache nodes, node endpoints and the cache cluster itself. When you receive a successful response from this operation, Amazon
        /// ElastiCache immediately begins deleting the cache cluster; you cannot cancel or revert this operation.</para>
        /// </summary>
        /// 
        /// <param name="deleteCacheClusterRequest">Container for the necessary parameters to execute the DeleteCacheCluster service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DeleteCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="CacheClusterNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="InvalidCacheClusterStateException"/>
        DeleteCacheClusterResponse DeleteCacheCluster(DeleteCacheClusterRequest deleteCacheClusterRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="deleteCacheClusterRequest">Container for the necessary parameters to execute the DeleteCacheCluster operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteCacheCluster operation.</returns>
        IAsyncResult BeginDeleteCacheCluster(DeleteCacheClusterRequest deleteCacheClusterRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCacheCluster.</param>
        /// 
        /// <returns>Returns a CacheCluster from AmazonElastiCache.</returns>
        DeleteCacheClusterResponse EndDeleteCacheCluster(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeCacheSecurityGroups

        /// <summary>
        /// <para>The <i>DescribeCacheSecurityGroups</i> operation returns a list of cache security group descriptions. If a cache security group name
        /// is specified, the list will contain only the description of that group.</para>
        /// </summary>
        /// 
        /// <param name="describeCacheSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeCacheSecurityGroups service
        ///          method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheSecurityGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
        DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest describeCacheSecurityGroupsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheSecurityGroups operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="describeCacheSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeCacheSecurityGroups operation
        ///          on AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeCacheSecurityGroups operation.</returns>
        IAsyncResult BeginDescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest describeCacheSecurityGroupsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCacheSecurityGroups operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheSecurityGroups.</param>
        /// 
        /// <returns>Returns a DescribeCacheSecurityGroupsResult from AmazonElastiCache.</returns>
        DescribeCacheSecurityGroupsResponse EndDescribeCacheSecurityGroups(IAsyncResult asyncResult);

        /// <summary>
        /// <para>The <i>DescribeCacheSecurityGroups</i> operation returns a list of cache security group descriptions. If a cache security group name
        /// is specified, the list will contain only the description of that group.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheSecurityGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
        DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups();
        
        #endregion
        
    

        #region ModifyReplicationGroup

        /// <summary>
        /// <para>The <i>ModifyReplicationGroup</i> operation modifies the settings for a replication group.</para>
        /// </summary>
        /// 
        /// <param name="modifyReplicationGroupRequest">Container for the necessary parameters to execute the ModifyReplicationGroup service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyReplicationGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidReplicationGroupStateException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidCacheSecurityGroupStateException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        /// <exception cref="ReplicationGroupNotFoundException"/>
        /// <exception cref="CacheClusterNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        /// <exception cref="InvalidCacheClusterStateException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
        ModifyReplicationGroupResponse ModifyReplicationGroup(ModifyReplicationGroupRequest modifyReplicationGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ModifyReplicationGroup"/>
        /// </summary>
        /// 
        /// <param name="modifyReplicationGroupRequest">Container for the necessary parameters to execute the ModifyReplicationGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyReplicationGroup operation.</returns>
        IAsyncResult BeginModifyReplicationGroup(ModifyReplicationGroupRequest modifyReplicationGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyReplicationGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ModifyReplicationGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyReplicationGroup.</param>
        /// 
        /// <returns>Returns a ReplicationGroup from AmazonElastiCache.</returns>
        ModifyReplicationGroupResponse EndModifyReplicationGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeCacheClusters

        /// <summary>
        /// <para>The <i>DescribeCacheClusters</i> operation returns information about all provisioned cache clusters if no cache cluster identifier is
        /// specified, or about a specific cache cluster if a cache cluster identifier is supplied.</para> <para>By default, abbreviated information
        /// about the cache clusters(s) will be returned. You can use the optional <i>ShowDetails</i> flag to retrieve detailed information about the
        /// cache nodes associated with the cache clusters. These details include the DNS address and port for the cache node endpoint.</para> <para>If
        /// the cluster is in the CREATING state, only cluster level information will be displayed until all of the nodes are successfully
        /// provisioned.</para> <para>If the cluster is in the DELETING state, only cluster level information will be displayed.</para> <para>If cache
        /// nodes are currently being added to the cache cluster, node endpoint information and creation time for the additional nodes will not be
        /// displayed until they are completely provisioned. When the cache cluster state is <i>available</i> , the cluster is ready for use.</para>
        /// <para>If cache nodes are currently being removed from the cache cluster, no endpoint information for the removed nodes is displayed.</para>
        /// </summary>
        /// 
        /// <param name="describeCacheClustersRequest">Container for the necessary parameters to execute the DescribeCacheClusters service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheClusters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="CacheClusterNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        DescribeCacheClustersResponse DescribeCacheClusters(DescribeCacheClustersRequest describeCacheClustersRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheClusters operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheClusters"/>
        /// </summary>
        /// 
        /// <param name="describeCacheClustersRequest">Container for the necessary parameters to execute the DescribeCacheClusters operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeCacheClusters operation.</returns>
        IAsyncResult BeginDescribeCacheClusters(DescribeCacheClustersRequest describeCacheClustersRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCacheClusters operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheClusters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheClusters.</param>
        /// 
        /// <returns>Returns a DescribeCacheClustersResult from AmazonElastiCache.</returns>
        DescribeCacheClustersResponse EndDescribeCacheClusters(IAsyncResult asyncResult);

        /// <summary>
        /// <para>The <i>DescribeCacheClusters</i> operation returns information about all provisioned cache clusters if no cache cluster identifier is
        /// specified, or about a specific cache cluster if a cache cluster identifier is supplied.</para> <para>By default, abbreviated information
        /// about the cache clusters(s) will be returned. You can use the optional <i>ShowDetails</i> flag to retrieve detailed information about the
        /// cache nodes associated with the cache clusters. These details include the DNS address and port for the cache node endpoint.</para> <para>If
        /// the cluster is in the CREATING state, only cluster level information will be displayed until all of the nodes are successfully
        /// provisioned.</para> <para>If the cluster is in the DELETING state, only cluster level information will be displayed.</para> <para>If cache
        /// nodes are currently being added to the cache cluster, node endpoint information and creation time for the additional nodes will not be
        /// displayed until they are completely provisioned. When the cache cluster state is <i>available</i> , the cluster is ready for use.</para>
        /// <para>If cache nodes are currently being removed from the cache cluster, no endpoint information for the removed nodes is displayed.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheClusters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="CacheClusterNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        DescribeCacheClustersResponse DescribeCacheClusters();
        
        #endregion
        
    

        #region CreateCacheParameterGroup

        /// <summary>
        /// <para>The <i>CreateCacheParameterGroup</i> operation creates a new cache parameter group. A cache parameter group is a collection of
        /// parameters that you apply to all of the nodes in a cache cluster.</para>
        /// </summary>
        /// 
        /// <param name="createCacheParameterGroupRequest">Container for the necessary parameters to execute the CreateCacheParameterGroup service
        ///          method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheParameterGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="CacheParameterGroupQuotaExceededException"/>
        /// <exception cref="CacheParameterGroupAlreadyExistsException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="InvalidCacheParameterGroupStateException"/>
        CreateCacheParameterGroupResponse CreateCacheParameterGroup(CreateCacheParameterGroupRequest createCacheParameterGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="createCacheParameterGroupRequest">Container for the necessary parameters to execute the CreateCacheParameterGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateCacheParameterGroup operation.</returns>
        IAsyncResult BeginCreateCacheParameterGroup(CreateCacheParameterGroupRequest createCacheParameterGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCacheParameterGroup.</param>
        /// 
        /// <returns>Returns a CacheParameterGroup from AmazonElastiCache.</returns>
        CreateCacheParameterGroupResponse EndCreateCacheParameterGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeCacheParameterGroups

        /// <summary>
        /// <para>The <i>DescribeCacheParameterGroups</i> operation returns a list of cache parameter group descriptions. If a cache parameter group
        /// name is specified, the list will contain only the descriptions for that group.</para>
        /// </summary>
        /// 
        /// <param name="describeCacheParameterGroupsRequest">Container for the necessary parameters to execute the DescribeCacheParameterGroups service
        ///          method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheParameterGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest describeCacheParameterGroupsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheParameterGroups operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheParameterGroups"/>
        /// </summary>
        /// 
        /// <param name="describeCacheParameterGroupsRequest">Container for the necessary parameters to execute the DescribeCacheParameterGroups
        ///          operation on AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeCacheParameterGroups operation.</returns>
        IAsyncResult BeginDescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest describeCacheParameterGroupsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCacheParameterGroups operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheParameterGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheParameterGroups.</param>
        /// 
        /// <returns>Returns a DescribeCacheParameterGroupsResult from AmazonElastiCache.</returns>
        DescribeCacheParameterGroupsResponse EndDescribeCacheParameterGroups(IAsyncResult asyncResult);

        /// <summary>
        /// <para>The <i>DescribeCacheParameterGroups</i> operation returns a list of cache parameter group descriptions. If a cache parameter group
        /// name is specified, the list will contain only the descriptions for that group.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheParameterGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups();
        
        #endregion
        
    

        #region DescribeCacheSubnetGroups

        /// <summary>
        /// <para>The <i>DescribeCacheSubnetGroups</i> operation returns a list of cache subnet group descriptions. If a subnet group name is specified,
        /// the list will contain only the description of that group.</para>
        /// </summary>
        /// 
        /// <param name="describeCacheSubnetGroupsRequest">Container for the necessary parameters to execute the DescribeCacheSubnetGroups service
        ///          method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="CacheSubnetGroupNotFoundException"/>
        DescribeCacheSubnetGroupsResponse DescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest describeCacheSubnetGroupsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheSubnetGroups operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheSubnetGroups"/>
        /// </summary>
        /// 
        /// <param name="describeCacheSubnetGroupsRequest">Container for the necessary parameters to execute the DescribeCacheSubnetGroups operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeCacheSubnetGroups operation.</returns>
        IAsyncResult BeginDescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest describeCacheSubnetGroupsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCacheSubnetGroups operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheSubnetGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheSubnetGroups.</param>
        /// 
        /// <returns>Returns a DescribeCacheSubnetGroupsResult from AmazonElastiCache.</returns>
        DescribeCacheSubnetGroupsResponse EndDescribeCacheSubnetGroups(IAsyncResult asyncResult);

        /// <summary>
        /// <para>The <i>DescribeCacheSubnetGroups</i> operation returns a list of cache subnet group descriptions. If a subnet group name is specified,
        /// the list will contain only the description of that group.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="CacheSubnetGroupNotFoundException"/>
        DescribeCacheSubnetGroupsResponse DescribeCacheSubnetGroups();
        
        #endregion
        
    

        #region ModifyCacheSubnetGroup

        /// <summary>
        /// <para>The <i>ModifyCacheSubnetGroup</i> operation modifies an existing cache subnet group.</para>
        /// </summary>
        /// 
        /// <param name="modifyCacheSubnetGroupRequest">Container for the necessary parameters to execute the ModifyCacheSubnetGroup service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyCacheSubnetGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="CacheSubnetGroupNotFoundException"/>
        /// <exception cref="CacheSubnetQuotaExceededException"/>
        /// <exception cref="InvalidSubnetException"/>
        /// <exception cref="SubnetInUseException"/>
        ModifyCacheSubnetGroupResponse ModifyCacheSubnetGroup(ModifyCacheSubnetGroupRequest modifyCacheSubnetGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ModifyCacheSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="modifyCacheSubnetGroupRequest">Container for the necessary parameters to execute the ModifyCacheSubnetGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyCacheSubnetGroup operation.</returns>
        IAsyncResult BeginModifyCacheSubnetGroup(ModifyCacheSubnetGroupRequest modifyCacheSubnetGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ModifyCacheSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCacheSubnetGroup.</param>
        /// 
        /// <returns>Returns a CacheSubnetGroup from AmazonElastiCache.</returns>
        ModifyCacheSubnetGroupResponse EndModifyCacheSubnetGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteCacheParameterGroup

        /// <summary>
        /// <para>The <i>DeleteCacheParameterGroup</i> operation deletes the specified cache parameter group. You cannot delete a cache parameter group
        /// if it is associated with any cache clusters.</para>
        /// </summary>
        /// 
        /// <param name="deleteCacheParameterGroupRequest">Container for the necessary parameters to execute the DeleteCacheParameterGroup service
        ///          method on AmazonElastiCache.</param>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="InvalidCacheParameterGroupStateException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        DeleteCacheParameterGroupResponse DeleteCacheParameterGroup(DeleteCacheParameterGroupRequest deleteCacheParameterGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteCacheParameterGroupRequest">Container for the necessary parameters to execute the DeleteCacheParameterGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteCacheParameterGroup(DeleteCacheParameterGroupRequest deleteCacheParameterGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCacheParameterGroup.</param>
        DeleteCacheParameterGroupResponse EndDeleteCacheParameterGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeCacheParameters

        /// <summary>
        /// <para>The <i>DescribeCacheParameters</i> operation returns the detailed parameter list for a particular cache parameter group.</para>
        /// </summary>
        /// 
        /// <param name="describeCacheParametersRequest">Container for the necessary parameters to execute the DescribeCacheParameters service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheParameters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        DescribeCacheParametersResponse DescribeCacheParameters(DescribeCacheParametersRequest describeCacheParametersRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheParameters operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheParameters"/>
        /// </summary>
        /// 
        /// <param name="describeCacheParametersRequest">Container for the necessary parameters to execute the DescribeCacheParameters operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeCacheParameters operation.</returns>
        IAsyncResult BeginDescribeCacheParameters(DescribeCacheParametersRequest describeCacheParametersRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCacheParameters operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheParameters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheParameters.</param>
        /// 
        /// <returns>Returns a DescribeCacheParametersResult from AmazonElastiCache.</returns>
        DescribeCacheParametersResponse EndDescribeCacheParameters(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeReservedCacheNodes

        /// <summary>
        /// <para>The <i>DescribeReservedCacheNodes</i> operation returns information about reserved cache nodes for this account, or about a specified
        /// reserved cache node.</para>
        /// </summary>
        /// 
        /// <param name="describeReservedCacheNodesRequest">Container for the necessary parameters to execute the DescribeReservedCacheNodes service
        ///          method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodes service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="ReservedCacheNodeNotFoundException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        DescribeReservedCacheNodesResponse DescribeReservedCacheNodes(DescribeReservedCacheNodesRequest describeReservedCacheNodesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedCacheNodes operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeReservedCacheNodes"/>
        /// </summary>
        /// 
        /// <param name="describeReservedCacheNodesRequest">Container for the necessary parameters to execute the DescribeReservedCacheNodes operation
        ///          on AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReservedCacheNodes operation.</returns>
        IAsyncResult BeginDescribeReservedCacheNodes(DescribeReservedCacheNodesRequest describeReservedCacheNodesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReservedCacheNodes operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeReservedCacheNodes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedCacheNodes.</param>
        /// 
        /// <returns>Returns a DescribeReservedCacheNodesResult from AmazonElastiCache.</returns>
        DescribeReservedCacheNodesResponse EndDescribeReservedCacheNodes(IAsyncResult asyncResult);

        /// <summary>
        /// <para>The <i>DescribeReservedCacheNodes</i> operation returns information about reserved cache nodes for this account, or about a specified
        /// reserved cache node.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodes service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="ReservedCacheNodeNotFoundException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        DescribeReservedCacheNodesResponse DescribeReservedCacheNodes();
        
        #endregion
        
    

        #region DeleteCacheSubnetGroup

        /// <summary>
        /// <para>The <i>DeleteCacheSubnetGroup</i> operation deletes a cache subnet group.</para> <para><b>NOTE:</b>You cannot delete a cache subnet
        /// group if it is associated with any cache clusters.</para>
        /// </summary>
        /// 
        /// <param name="deleteCacheSubnetGroupRequest">Container for the necessary parameters to execute the DeleteCacheSubnetGroup service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <exception cref="CacheSubnetGroupNotFoundException"/>
        /// <exception cref="CacheSubnetGroupInUseException"/>
        DeleteCacheSubnetGroupResponse DeleteCacheSubnetGroup(DeleteCacheSubnetGroupRequest deleteCacheSubnetGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteCacheSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteCacheSubnetGroupRequest">Container for the necessary parameters to execute the DeleteCacheSubnetGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteCacheSubnetGroup(DeleteCacheSubnetGroupRequest deleteCacheSubnetGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteCacheSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCacheSubnetGroup.</param>
        DeleteCacheSubnetGroupResponse EndDeleteCacheSubnetGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeEvents

        /// <summary>
        /// <para>The <i>DescribeEvents</i> operation returns events related to cache clusters, cache security groups, and cache parameter groups. You
        /// can obtain events specific to a particular cache cluster, cache security group, or cache parameter group by providing the name as a
        /// parameter.</para> <para>By default, only the events occurring within the last hour are returned; however, you can retrieve up to 14 days'
        /// worth of events if necessary.</para>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest describeEventsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeEvents"/>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        IAsyncResult BeginDescribeEvents(DescribeEventsRequest describeEventsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeEvents"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a DescribeEventsResult from AmazonElastiCache.</returns>
        DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult);

        /// <summary>
        /// <para>The <i>DescribeEvents</i> operation returns events related to cache clusters, cache security groups, and cache parameter groups. You
        /// can obtain events specific to a particular cache cluster, cache security group, or cache parameter group by providing the name as a
        /// parameter.</para> <para>By default, only the events occurring within the last hour are returned; however, you can retrieve up to 14 days'
        /// worth of events if necessary.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        DescribeEventsResponse DescribeEvents();
        
        #endregion
        
    

        #region DeleteCacheSecurityGroup

        /// <summary>
        /// <para>The <i>DeleteCacheSecurityGroup</i> operation deletes a cache security group.</para> <para><b>NOTE:</b>You cannot delete a cache
        /// security group if it is associated with any cache clusters.</para>
        /// </summary>
        /// 
        /// <param name="deleteCacheSecurityGroupRequest">Container for the necessary parameters to execute the DeleteCacheSecurityGroup service method
        ///          on AmazonElastiCache.</param>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidCacheSecurityGroupStateException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
        DeleteCacheSecurityGroupResponse DeleteCacheSecurityGroup(DeleteCacheSecurityGroupRequest deleteCacheSecurityGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheSecurityGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteCacheSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteCacheSecurityGroupRequest">Container for the necessary parameters to execute the DeleteCacheSecurityGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteCacheSecurityGroup(DeleteCacheSecurityGroupRequest deleteCacheSecurityGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteCacheSecurityGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteCacheSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCacheSecurityGroup.</param>
        DeleteCacheSecurityGroupResponse EndDeleteCacheSecurityGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeEngineDefaultParameters

        /// <summary>
        /// <para>The <i>DescribeEngineDefaultParameters</i> operation returns the default engine and system parameter information for the specified
        /// cache engine.</para>
        /// </summary>
        /// 
        /// <param name="describeEngineDefaultParametersRequest">Container for the necessary parameters to execute the DescribeEngineDefaultParameters
        ///          service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest describeEngineDefaultParametersRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeEngineDefaultParameters"/>
        /// </summary>
        /// 
        /// <param name="describeEngineDefaultParametersRequest">Container for the necessary parameters to execute the DescribeEngineDefaultParameters
        ///          operation on AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeEngineDefaultParameters operation.</returns>
        IAsyncResult BeginDescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest describeEngineDefaultParametersRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeEngineDefaultParameters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEngineDefaultParameters.</param>
        /// 
        /// <returns>Returns a EngineDefaults from AmazonElastiCache.</returns>
        DescribeEngineDefaultParametersResponse EndDescribeEngineDefaultParameters(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AuthorizeCacheSecurityGroupIngress

        /// <summary>
        /// <para>The <i>AuthorizeCacheSecurityGroupIngress</i> operation allows network ingress to a cache security group. Applications using
        /// ElastiCache must be running on Amazon EC2, and Amazon EC2 security groups are used as the authorization mechanism.</para> <para><b>NOTE:</b>
        /// You cannot authorize ingress from an Amazon EC2 security group in one Region to an ElastiCache cluster in another Region. </para>
        /// </summary>
        /// 
        /// <param name="authorizeCacheSecurityGroupIngressRequest">Container for the necessary parameters to execute the
        ///          AuthorizeCacheSecurityGroupIngress service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the AuthorizeCacheSecurityGroupIngress service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="AuthorizationAlreadyExistsException"/>
        /// <exception cref="InvalidCacheSecurityGroupStateException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
        AuthorizeCacheSecurityGroupIngressResponse AuthorizeCacheSecurityGroupIngress(AuthorizeCacheSecurityGroupIngressRequest authorizeCacheSecurityGroupIngressRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeCacheSecurityGroupIngress operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.AuthorizeCacheSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="authorizeCacheSecurityGroupIngressRequest">Container for the necessary parameters to execute the
        ///          AuthorizeCacheSecurityGroupIngress operation on AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAuthorizeCacheSecurityGroupIngress operation.</returns>
        IAsyncResult BeginAuthorizeCacheSecurityGroupIngress(AuthorizeCacheSecurityGroupIngressRequest authorizeCacheSecurityGroupIngressRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AuthorizeCacheSecurityGroupIngress operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.AuthorizeCacheSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeCacheSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a CacheSecurityGroup from AmazonElastiCache.</returns>
        AuthorizeCacheSecurityGroupIngressResponse EndAuthorizeCacheSecurityGroupIngress(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateCacheSubnetGroup

        /// <summary>
        /// <para>The <i>CreateCacheSubnetGroup</i> operation creates a new cache subnet group.</para> <para>Use this parameter only when you are
        /// creating a cluster in an Amazon Virtual Private Cloud (VPC).</para>
        /// </summary>
        /// 
        /// <param name="createCacheSubnetGroupRequest">Container for the necessary parameters to execute the CreateCacheSubnetGroup service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheSubnetGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="CacheSubnetGroupAlreadyExistsException"/>
        /// <exception cref="CacheSubnetGroupQuotaExceededException"/>
        /// <exception cref="CacheSubnetQuotaExceededException"/>
        /// <exception cref="InvalidSubnetException"/>
        CreateCacheSubnetGroupResponse CreateCacheSubnetGroup(CreateCacheSubnetGroupRequest createCacheSubnetGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateCacheSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="createCacheSubnetGroupRequest">Container for the necessary parameters to execute the CreateCacheSubnetGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateCacheSubnetGroup operation.</returns>
        IAsyncResult BeginCreateCacheSubnetGroup(CreateCacheSubnetGroupRequest createCacheSubnetGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateCacheSubnetGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateCacheSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCacheSubnetGroup.</param>
        /// 
        /// <returns>Returns a CacheSubnetGroup from AmazonElastiCache.</returns>
        CreateCacheSubnetGroupResponse EndCreateCacheSubnetGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeCacheEngineVersions

        /// <summary>
        /// <para>The <i>DescribeCacheEngineVersions</i> operation returns a list of the available cache engines and their versions.</para>
        /// </summary>
        /// 
        /// <param name="describeCacheEngineVersionsRequest">Container for the necessary parameters to execute the DescribeCacheEngineVersions service
        ///          method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by AmazonElastiCache.</returns>
        /// 
        DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest describeCacheEngineVersionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheEngineVersions operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheEngineVersions"/>
        /// </summary>
        /// 
        /// <param name="describeCacheEngineVersionsRequest">Container for the necessary parameters to execute the DescribeCacheEngineVersions operation
        ///          on AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeCacheEngineVersions operation.</returns>
        IAsyncResult BeginDescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest describeCacheEngineVersionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCacheEngineVersions operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DescribeCacheEngineVersions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheEngineVersions.</param>
        /// 
        /// <returns>Returns a DescribeCacheEngineVersionsResult from AmazonElastiCache.</returns>
        DescribeCacheEngineVersionsResponse EndDescribeCacheEngineVersions(IAsyncResult asyncResult);

        /// <summary>
        /// <para>The <i>DescribeCacheEngineVersions</i> operation returns a list of the available cache engines and their versions.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by AmazonElastiCache.</returns>
        /// 
        DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions();
        
        #endregion
        
    

        #region CreateCacheSecurityGroup

        /// <summary>
        /// <para>The <i>CreateCacheSecurityGroup</i> operation creates a new cache security group. Use a cache security group to control access to one
        /// or more cache clusters.</para> <para>Cache security groups are only used when you are creating a cluster outside of an Amazon Virtual
        /// Private Cloud (VPC). If you are creating a cluster inside of a VPC, use a cache subnet group instead. For more information, see
        /// <i>CreateCacheSubnetGroup</i> .</para>
        /// </summary>
        /// 
        /// <param name="createCacheSecurityGroupRequest">Container for the necessary parameters to execute the CreateCacheSecurityGroup service method
        ///          on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheSecurityGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="CacheSecurityGroupAlreadyExistsException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="CacheSecurityGroupQuotaExceededException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        CreateCacheSecurityGroupResponse CreateCacheSecurityGroup(CreateCacheSecurityGroupRequest createCacheSecurityGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheSecurityGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateCacheSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="createCacheSecurityGroupRequest">Container for the necessary parameters to execute the CreateCacheSecurityGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateCacheSecurityGroup operation.</returns>
        IAsyncResult BeginCreateCacheSecurityGroup(CreateCacheSecurityGroupRequest createCacheSecurityGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateCacheSecurityGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.CreateCacheSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCacheSecurityGroup.</param>
        /// 
        /// <returns>Returns a CacheSecurityGroup from AmazonElastiCache.</returns>
        CreateCacheSecurityGroupResponse EndCreateCacheSecurityGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region PurchaseReservedCacheNodesOffering

        /// <summary>
        /// <para>The <i>PurchaseReservedCacheNodesOffering</i> operation allows you to purchase a reserved cache node offering.</para>
        /// </summary>
        /// 
        /// <param name="purchaseReservedCacheNodesOfferingRequest">Container for the necessary parameters to execute the
        ///          PurchaseReservedCacheNodesOffering service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the PurchaseReservedCacheNodesOffering service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="ReservedCacheNodeQuotaExceededException"/>
        /// <exception cref="ReservedCacheNodeAlreadyExistsException"/>
        /// <exception cref="ReservedCacheNodesOfferingNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        PurchaseReservedCacheNodesOfferingResponse PurchaseReservedCacheNodesOffering(PurchaseReservedCacheNodesOfferingRequest purchaseReservedCacheNodesOfferingRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedCacheNodesOffering operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.PurchaseReservedCacheNodesOffering"/>
        /// </summary>
        /// 
        /// <param name="purchaseReservedCacheNodesOfferingRequest">Container for the necessary parameters to execute the
        ///          PurchaseReservedCacheNodesOffering operation on AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndPurchaseReservedCacheNodesOffering operation.</returns>
        IAsyncResult BeginPurchaseReservedCacheNodesOffering(PurchaseReservedCacheNodesOfferingRequest purchaseReservedCacheNodesOfferingRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PurchaseReservedCacheNodesOffering operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.PurchaseReservedCacheNodesOffering"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedCacheNodesOffering.</param>
        /// 
        /// <returns>Returns a ReservedCacheNode from AmazonElastiCache.</returns>
        PurchaseReservedCacheNodesOfferingResponse EndPurchaseReservedCacheNodesOffering(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ResetCacheParameterGroup

        /// <summary>
        /// <para>The <i>ResetCacheParameterGroup</i> operation modifies the parameters of a cache parameter group to the engine or system default
        /// value. You can reset specific parameters by submitting a list of parameter names. To reset the entire cache parameter group, specify the
        /// <i>ResetAllParameters</i> and <i>CacheParameterGroupName</i> parameters.</para>
        /// </summary>
        /// 
        /// <param name="resetCacheParameterGroupRequest">Container for the necessary parameters to execute the ResetCacheParameterGroup service method
        ///          on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ResetCacheParameterGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="InvalidCacheParameterGroupStateException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        ResetCacheParameterGroupResponse ResetCacheParameterGroup(ResetCacheParameterGroupRequest resetCacheParameterGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ResetCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="resetCacheParameterGroupRequest">Container for the necessary parameters to execute the ResetCacheParameterGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndResetCacheParameterGroup operation.</returns>
        IAsyncResult BeginResetCacheParameterGroup(ResetCacheParameterGroupRequest resetCacheParameterGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ResetCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ResetCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetCacheParameterGroup.</param>
        /// 
        /// <returns>Returns a ResetCacheParameterGroupResult from AmazonElastiCache.</returns>
        ResetCacheParameterGroupResponse EndResetCacheParameterGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ModifyCacheParameterGroup

        /// <summary>
        /// <para>The <i>ModifyCacheParameterGroup</i> operation modifies the parameters of a cache parameter group. You can modify up to 20 parameters
        /// in a single request by submitting a list parameter name and value pairs.</para>
        /// </summary>
        /// 
        /// <param name="modifyCacheParameterGroupRequest">Container for the necessary parameters to execute the ModifyCacheParameterGroup service
        ///          method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyCacheParameterGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        /// <exception cref="InvalidCacheParameterGroupStateException"/>
        ModifyCacheParameterGroupResponse ModifyCacheParameterGroup(ModifyCacheParameterGroupRequest modifyCacheParameterGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ModifyCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="modifyCacheParameterGroupRequest">Container for the necessary parameters to execute the ModifyCacheParameterGroup operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyCacheParameterGroup operation.</returns>
        IAsyncResult BeginModifyCacheParameterGroup(ModifyCacheParameterGroupRequest modifyCacheParameterGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyCacheParameterGroup operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.ModifyCacheParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCacheParameterGroup.</param>
        /// 
        /// <returns>Returns a ModifyCacheParameterGroupResult from AmazonElastiCache.</returns>
        ModifyCacheParameterGroupResponse EndModifyCacheParameterGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RebootCacheCluster

        /// <summary>
        /// <para>The <i>RebootCacheCluster</i> operation reboots some, or all, of the cache cluster nodes within a provisioned cache cluster. This API
        /// will apply any modified cache parameter groups to the cache cluster. The reboot action takes place as soon as possible, and results in a
        /// momentary outage to the cache cluster. During the reboot, the cache cluster status is set to REBOOTING.</para> <para>The reboot causes the
        /// contents of the cache (for each cache cluster node being rebooted) to be lost.</para> <para>When the reboot is complete, a cache cluster
        /// event is created.</para>
        /// </summary>
        /// 
        /// <param name="rebootCacheClusterRequest">Container for the necessary parameters to execute the RebootCacheCluster service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the RebootCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="CacheClusterNotFoundException"/>
        /// <exception cref="InvalidCacheClusterStateException"/>
        RebootCacheClusterResponse RebootCacheCluster(RebootCacheClusterRequest rebootCacheClusterRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RebootCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.RebootCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="rebootCacheClusterRequest">Container for the necessary parameters to execute the RebootCacheCluster operation on
        ///          AmazonElastiCache.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRebootCacheCluster operation.</returns>
        IAsyncResult BeginRebootCacheCluster(RebootCacheClusterRequest rebootCacheClusterRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RebootCacheCluster operation.
        /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.RebootCacheCluster"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootCacheCluster.</param>
        /// 
        /// <returns>Returns a CacheCluster from AmazonElastiCache.</returns>
        RebootCacheClusterResponse EndRebootCacheCluster(IAsyncResult asyncResult);
        
        #endregion
        
    
    }
}
    
