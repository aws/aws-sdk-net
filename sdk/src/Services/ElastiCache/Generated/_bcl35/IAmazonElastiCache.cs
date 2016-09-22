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
using System.Collections.Generic;

using Amazon.Runtime;
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
    /// cache. The service makes setup, scaling, and cluster failure handling much simpler
    /// than in a self-managed cache deployment.
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

        
        #region  AddTagsToResource


        /// <summary>
        /// The <i>AddTagsToResource</i> action adds up to 10 cost allocation tags to the named
        /// resource. A <i>cost allocation tag</i> is a key-value pair where the key and value
        /// are case-sensitive. Cost allocation tags can be used to categorize and track your
        /// AWS costs.
        /// 
        ///  
        /// <para>
        ///  When you apply tags to your ElastiCache resources, AWS generates a cost allocation
        /// report as a comma-separated value (CSV) file with your usage and costs aggregated
        /// by your tags. You can apply tags that represent business categories (such as cost
        /// centers, application names, or owners) to organize your costs across multiple services.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/Tagging.html">Using
        /// Cost Allocation Tags in Amazon ElastiCache</a> in the <i>ElastiCache User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidARNException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotNotFoundException">
        /// The requested snapshot name does not refer to an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.TagQuotaPerResourceExceededException">
        /// The request cannot be processed because it would cause the resource to have more than
        /// the allowed number of tags. The maximum number of tags permitted on a resource is
        /// 10.
        /// </exception>
        AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTagsToResource
        ///         operation.</returns>
        IAsyncResult BeginAddTagsToResource(AddTagsToResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTagsToResource.</param>
        /// 
        /// <returns>Returns a  AddTagsToResourceResult from ElastiCache.</returns>
        AddTagsToResourceResponse EndAddTagsToResource(IAsyncResult asyncResult);

        #endregion
        
        #region  AuthorizeCacheSecurityGroupIngress


        /// <summary>
        /// The <i>AuthorizeCacheSecurityGroupIngress</i> action allows network ingress to a cache
        /// security group. Applications using ElastiCache must be running on Amazon EC2, and
        /// Amazon EC2 security groups are used as the authorization mechanism.
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
        AuthorizeCacheSecurityGroupIngressResponse AuthorizeCacheSecurityGroupIngress(AuthorizeCacheSecurityGroupIngressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeCacheSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeCacheSecurityGroupIngress operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAuthorizeCacheSecurityGroupIngress
        ///         operation.</returns>
        IAsyncResult BeginAuthorizeCacheSecurityGroupIngress(AuthorizeCacheSecurityGroupIngressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeCacheSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeCacheSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a  AuthorizeCacheSecurityGroupIngressResult from ElastiCache.</returns>
        AuthorizeCacheSecurityGroupIngressResponse EndAuthorizeCacheSecurityGroupIngress(IAsyncResult asyncResult);

        #endregion
        
        #region  CopySnapshot


        /// <summary>
        /// The <i>CopySnapshot</i> action makes a copy of an existing snapshot.
        /// 
        ///  <important> 
        /// <para>
        /// Users or groups that have permissions to use the <i>CopySnapshot</i> API can create
        /// their own Amazon S3 buckets and copy snapshots to it. To control access to your snapshots,
        /// use an IAM policy to control who has the ability to use the <i>CopySnapshot</i> API.
        /// For more information about using IAM to control the use of ElastiCache APIs, see <a
        /// href="http://docs.aws.amazon.com/ElastiCache/latest/Snapshots.Exporting.html">Exporting
        /// Snapshots</a> and <a href="http://docs.aws.amazon.com/ElastiCache/latest/IAM.html">Authentication
        /// &amp; Access Control</a>.
        /// </para>
        ///  </important> <p class="title"> <b>Erorr Message:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Error Message:</b> The authenticated user does not have sufficient permissions
        /// to perform the desired activity.
        /// </para>
        ///  
        /// <para>
        ///  <b>Solution:</b> Contact your system administrator to get the needed permissions.
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
        /// The current state of the snapshot does not allow the requested action to occur.
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
        CopySnapshotResponse CopySnapshot(CopySnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopySnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopySnapshot
        ///         operation.</returns>
        IAsyncResult BeginCopySnapshot(CopySnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CopySnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopySnapshot.</param>
        /// 
        /// <returns>Returns a  CopySnapshotResult from ElastiCache.</returns>
        CopySnapshotResponse EndCopySnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCacheCluster


        /// <summary>
        /// The <i>CreateCacheCluster</i> action creates a cache cluster. All nodes in the cache
        /// cluster run the same protocol-compliant cache engine software, either Memcached or
        /// Redis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCacheCluster service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterAlreadyExistsException">
        /// You already have a cache cluster with the given identifier.
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
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// clusters per customer.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InsufficientCacheClusterCapacityException">
        /// The requested cache node type is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidVPCNetworkStateException">
        /// The VPC network is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeQuotaForClusterExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes in a single cache cluster.
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
        /// 10.
        /// </exception>
        CreateCacheClusterResponse CreateCacheCluster(CreateCacheClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheCluster operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCacheCluster
        ///         operation.</returns>
        IAsyncResult BeginCreateCacheCluster(CreateCacheClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCacheCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCacheCluster.</param>
        /// 
        /// <returns>Returns a  CreateCacheClusterResult from ElastiCache.</returns>
        CreateCacheClusterResponse EndCreateCacheCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCacheParameterGroup


        /// <summary>
        /// The <i>CreateCacheParameterGroup</i> action creates a new cache parameter group. A
        /// cache parameter group is a collection of parameters that you apply to all of the nodes
        /// in a cache cluster.
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
        /// The current state of the cache parameter group does not allow the requested action
        /// to occur.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        CreateCacheParameterGroupResponse CreateCacheParameterGroup(CreateCacheParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheParameterGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCacheParameterGroup
        ///         operation.</returns>
        IAsyncResult BeginCreateCacheParameterGroup(CreateCacheParameterGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCacheParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCacheParameterGroup.</param>
        /// 
        /// <returns>Returns a  CreateCacheParameterGroupResult from ElastiCache.</returns>
        CreateCacheParameterGroupResponse EndCreateCacheParameterGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCacheSecurityGroup


        /// <summary>
        /// The <i>CreateCacheSecurityGroup</i> action creates a new cache security group. Use
        /// a cache security group to control access to one or more cache clusters.
        /// 
        ///  
        /// <para>
        /// Cache security groups are only used when you are creating a cache cluster outside
        /// of an Amazon Virtual Private Cloud (VPC). If you are creating a cache cluster inside
        /// of a VPC, use a cache subnet group instead. For more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/APIReference/API_CreateCacheSubnetGroup.html">CreateCacheSubnetGroup</a>.
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
        CreateCacheSecurityGroupResponse CreateCacheSecurityGroup(CreateCacheSecurityGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSecurityGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCacheSecurityGroup
        ///         operation.</returns>
        IAsyncResult BeginCreateCacheSecurityGroup(CreateCacheSecurityGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCacheSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCacheSecurityGroup.</param>
        /// 
        /// <returns>Returns a  CreateCacheSecurityGroupResult from ElastiCache.</returns>
        CreateCacheSecurityGroupResponse EndCreateCacheSecurityGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCacheSubnetGroup


        /// <summary>
        /// The <i>CreateCacheSubnetGroup</i> action creates a new cache subnet group.
        /// 
        ///  
        /// <para>
        /// Use this parameter only when you are creating a cluster in an Amazon Virtual Private
        /// Cloud (VPC).
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
        CreateCacheSubnetGroupResponse CreateCacheSubnetGroup(CreateCacheSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCacheSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCacheSubnetGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCacheSubnetGroup
        ///         operation.</returns>
        IAsyncResult BeginCreateCacheSubnetGroup(CreateCacheSubnetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCacheSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCacheSubnetGroup.</param>
        /// 
        /// <returns>Returns a  CreateCacheSubnetGroupResult from ElastiCache.</returns>
        CreateCacheSubnetGroupResponse EndCreateCacheSubnetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateReplicationGroup


        /// <summary>
        /// The <i>CreateReplicationGroup</i> action creates a replication group. A replication
        /// group is a collection of cache clusters, where one of the cache clusters is a read/write
        /// primary and the others are read-only replicas. Writes to the primary are automatically
        /// propagated to the replicas.
        /// 
        ///  
        /// <para>
        /// When you create a replication group, you must specify an existing cache cluster that
        /// is in the primary role. When the replication group has been successfully created,
        /// you can add one or more read replica replicas to it, up to a total of five read replicas.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action is valid only for Redis.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationGroup service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
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
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// clusters per customer.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InsufficientCacheClusterCapacityException">
        /// The requested cache node type is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cache cluster is not in the <i>available</i> state.
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
        /// nodes in a single cache cluster.
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
        /// 10.
        /// </exception>
        CreateReplicationGroupResponse CreateReplicationGroup(CreateReplicationGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReplicationGroup
        ///         operation.</returns>
        IAsyncResult BeginCreateReplicationGroup(CreateReplicationGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReplicationGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicationGroup.</param>
        /// 
        /// <returns>Returns a  CreateReplicationGroupResult from ElastiCache.</returns>
        CreateReplicationGroupResponse EndCreateReplicationGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSnapshot


        /// <summary>
        /// The <i>CreateSnapshot</i> action creates a copy of an entire cache cluster at a specific
        /// moment in time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cache cluster is not in the <i>available</i> state.
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
        /// You attempted one of the following actions:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Creating a snapshot of a Redis cache cluster running on a <i>t1.micro</i> cache node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Creating a snapshot of a cache cluster that is running Memcached rather than Redis.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Neither of these are supported by ElastiCache.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum number of snapshots.
        /// </exception>
        CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshot
        ///         operation.</returns>
        IAsyncResult BeginCreateSnapshot(CreateSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotResult from ElastiCache.</returns>
        CreateSnapshotResponse EndCreateSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCacheCluster


        /// <summary>
        /// The <i>DeleteCacheCluster</i> action deletes a previously provisioned cache cluster.
        /// <i>DeleteCacheCluster</i> deletes all associated cache nodes, node endpoints and the
        /// cache cluster itself. When you receive a successful response from this action, Amazon
        /// ElastiCache immediately begins deleting the cache cluster; you cannot cancel or revert
        /// this action.
        /// 
        ///  
        /// <para>
        /// This API cannot be used to delete a cache cluster that is the last read replica of
        /// a replication group that has Multi-AZ mode enabled.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCacheCluster service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cache cluster is not in the <i>available</i> state.
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
        /// You attempted one of the following actions:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Creating a snapshot of a Redis cache cluster running on a <i>t1.micro</i> cache node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Creating a snapshot of a cache cluster that is running Memcached rather than Redis.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Neither of these are supported by ElastiCache.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum number of snapshots.
        /// </exception>
        DeleteCacheClusterResponse DeleteCacheCluster(DeleteCacheClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheCluster operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCacheCluster
        ///         operation.</returns>
        IAsyncResult BeginDeleteCacheCluster(DeleteCacheClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCacheCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCacheCluster.</param>
        /// 
        /// <returns>Returns a  DeleteCacheClusterResult from ElastiCache.</returns>
        DeleteCacheClusterResponse EndDeleteCacheCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCacheParameterGroup


        /// <summary>
        /// The <i>DeleteCacheParameterGroup</i> action deletes the specified cache parameter
        /// group. You cannot delete a cache parameter group if it is associated with any cache
        /// clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteCacheParameterGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException">
        /// The current state of the cache parameter group does not allow the requested action
        /// to occur.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        DeleteCacheParameterGroupResponse DeleteCacheParameterGroup(DeleteCacheParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheParameterGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCacheParameterGroup
        ///         operation.</returns>
        IAsyncResult BeginDeleteCacheParameterGroup(DeleteCacheParameterGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCacheParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCacheParameterGroup.</param>
        /// 
        /// <returns>Returns a  DeleteCacheParameterGroupResult from ElastiCache.</returns>
        DeleteCacheParameterGroupResponse EndDeleteCacheParameterGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCacheSecurityGroup


        /// <summary>
        /// The <i>DeleteCacheSecurityGroup</i> action deletes a cache security group.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete a cache security group if it is associated with any cache clusters.
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
        DeleteCacheSecurityGroupResponse DeleteCacheSecurityGroup(DeleteCacheSecurityGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSecurityGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCacheSecurityGroup
        ///         operation.</returns>
        IAsyncResult BeginDeleteCacheSecurityGroup(DeleteCacheSecurityGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCacheSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCacheSecurityGroup.</param>
        /// 
        /// <returns>Returns a  DeleteCacheSecurityGroupResult from ElastiCache.</returns>
        DeleteCacheSecurityGroupResponse EndDeleteCacheSecurityGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCacheSubnetGroup


        /// <summary>
        /// The <i>DeleteCacheSubnetGroup</i> action deletes a cache subnet group.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete a cache subnet group if it is associated with any cache clusters.
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
        DeleteCacheSubnetGroupResponse DeleteCacheSubnetGroup(DeleteCacheSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCacheSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCacheSubnetGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCacheSubnetGroup
        ///         operation.</returns>
        IAsyncResult BeginDeleteCacheSubnetGroup(DeleteCacheSubnetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCacheSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCacheSubnetGroup.</param>
        /// 
        /// <returns>Returns a  DeleteCacheSubnetGroupResult from ElastiCache.</returns>
        DeleteCacheSubnetGroupResponse EndDeleteCacheSubnetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteReplicationGroup


        /// <summary>
        /// The <i>DeleteReplicationGroup</i> action deletes an existing replication group. By
        /// default, this action deletes the entire replication group, including the primary cluster
        /// and all of the read replicas. You can optionally delete only the read replicas, while
        /// retaining the primary cluster.
        /// 
        ///  
        /// <para>
        /// When you receive a successful response from this action, Amazon ElastiCache immediately
        /// begins deleting the selected resources; you cannot cancel or revert this action.
        /// </para>
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
        /// The requested replication group is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotAlreadyExistsException">
        /// You already have a snapshot with the given name.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotFeatureNotSupportedException">
        /// You attempted one of the following actions:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Creating a snapshot of a Redis cache cluster running on a <i>t1.micro</i> cache node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Creating a snapshot of a cache cluster that is running Memcached rather than Redis.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Neither of these are supported by ElastiCache.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotQuotaExceededException">
        /// The request cannot be processed because it would exceed the maximum number of snapshots.
        /// </exception>
        DeleteReplicationGroupResponse DeleteReplicationGroup(DeleteReplicationGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicationGroup
        ///         operation.</returns>
        IAsyncResult BeginDeleteReplicationGroup(DeleteReplicationGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicationGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationGroup.</param>
        /// 
        /// <returns>Returns a  DeleteReplicationGroupResult from ElastiCache.</returns>
        DeleteReplicationGroupResponse EndDeleteReplicationGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSnapshot


        /// <summary>
        /// The <i>DeleteSnapshot</i> action deletes an existing snapshot. When you receive a
        /// successful response from this action, ElastiCache immediately begins deleting the
        /// snapshot; you cannot cancel or revert this action.
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
        /// The current state of the snapshot does not allow the requested action to occur.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotNotFoundException">
        /// The requested snapshot name does not refer to an existing snapshot.
        /// </exception>
        DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSnapshot
        ///         operation.</returns>
        IAsyncResult BeginDeleteSnapshot(DeleteSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteSnapshotResult from ElastiCache.</returns>
        DeleteSnapshotResponse EndDeleteSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCacheClusters


        /// <summary>
        /// The <i>DescribeCacheClusters</i> action returns information about all provisioned
        /// cache clusters if no cache cluster identifier is specified, or about a specific cache
        /// cluster if a cache cluster identifier is supplied.
        /// 
        ///  
        /// <para>
        /// By default, abbreviated information about the cache clusters(s) will be returned.
        /// You can use the optional <i>ShowDetails</i> flag to retrieve detailed information
        /// about the cache nodes associated with the cache clusters. These details include the
        /// DNS address and port for the cache node endpoint.
        /// </para>
        ///  
        /// <para>
        /// If the cluster is in the CREATING state, only cluster level information will be displayed
        /// until all of the nodes are successfully provisioned.
        /// </para>
        ///  
        /// <para>
        /// If the cluster is in the DELETING state, only cluster level information will be displayed.
        /// </para>
        ///  
        /// <para>
        /// If cache nodes are currently being added to the cache cluster, node endpoint information
        /// and creation time for the additional nodes will not be displayed until they are completely
        /// provisioned. When the cache cluster state is <i>available</i>, the cluster is ready
        /// for use.
        /// </para>
        ///  
        /// <para>
        /// If cache nodes are currently being removed from the cache cluster, no endpoint information
        /// for the removed nodes is displayed.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheClusters service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        DescribeCacheClustersResponse DescribeCacheClusters();

        /// <summary>
        /// The <i>DescribeCacheClusters</i> action returns information about all provisioned
        /// cache clusters if no cache cluster identifier is specified, or about a specific cache
        /// cluster if a cache cluster identifier is supplied.
        /// 
        ///  
        /// <para>
        /// By default, abbreviated information about the cache clusters(s) will be returned.
        /// You can use the optional <i>ShowDetails</i> flag to retrieve detailed information
        /// about the cache nodes associated with the cache clusters. These details include the
        /// DNS address and port for the cache node endpoint.
        /// </para>
        ///  
        /// <para>
        /// If the cluster is in the CREATING state, only cluster level information will be displayed
        /// until all of the nodes are successfully provisioned.
        /// </para>
        ///  
        /// <para>
        /// If the cluster is in the DELETING state, only cluster level information will be displayed.
        /// </para>
        ///  
        /// <para>
        /// If cache nodes are currently being added to the cache cluster, node endpoint information
        /// and creation time for the additional nodes will not be displayed until they are completely
        /// provisioned. When the cache cluster state is <i>available</i>, the cluster is ready
        /// for use.
        /// </para>
        ///  
        /// <para>
        /// If cache nodes are currently being removed from the cache cluster, no endpoint information
        /// for the removed nodes is displayed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeCacheClusters service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        DescribeCacheClustersResponse DescribeCacheClusters(DescribeCacheClustersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheClusters operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCacheClusters
        ///         operation.</returns>
        IAsyncResult BeginDescribeCacheClusters(DescribeCacheClustersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCacheClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheClusters.</param>
        /// 
        /// <returns>Returns a  DescribeCacheClustersResult from ElastiCache.</returns>
        DescribeCacheClustersResponse EndDescribeCacheClusters(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCacheEngineVersions


        /// <summary>
        /// The <i>DescribeCacheEngineVersions</i> action returns a list of the available cache
        /// engines and their versions.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by ElastiCache.</returns>
        DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions();

        /// <summary>
        /// The <i>DescribeCacheEngineVersions</i> action returns a list of the available cache
        /// engines and their versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheEngineVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by ElastiCache.</returns>
        DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheEngineVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheEngineVersions operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCacheEngineVersions
        ///         operation.</returns>
        IAsyncResult BeginDescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCacheEngineVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheEngineVersions.</param>
        /// 
        /// <returns>Returns a  DescribeCacheEngineVersionsResult from ElastiCache.</returns>
        DescribeCacheEngineVersionsResponse EndDescribeCacheEngineVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCacheParameterGroups


        /// <summary>
        /// The <i>DescribeCacheParameterGroups</i> action returns a list of cache parameter group
        /// descriptions. If a cache parameter group name is specified, the list will contain
        /// only the descriptions for that group.
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
        DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups();

        /// <summary>
        /// The <i>DescribeCacheParameterGroups</i> action returns a list of cache parameter group
        /// descriptions. If a cache parameter group name is specified, the list will contain
        /// only the descriptions for that group.
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
        DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameterGroups operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCacheParameterGroups
        ///         operation.</returns>
        IAsyncResult BeginDescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCacheParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheParameterGroups.</param>
        /// 
        /// <returns>Returns a  DescribeCacheParameterGroupsResult from ElastiCache.</returns>
        DescribeCacheParameterGroupsResponse EndDescribeCacheParameterGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCacheParameters


        /// <summary>
        /// The <i>DescribeCacheParameters</i> action returns the detailed parameter list for
        /// a particular cache parameter group.
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
        DescribeCacheParametersResponse DescribeCacheParameters(DescribeCacheParametersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheParameters operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCacheParameters
        ///         operation.</returns>
        IAsyncResult BeginDescribeCacheParameters(DescribeCacheParametersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCacheParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheParameters.</param>
        /// 
        /// <returns>Returns a  DescribeCacheParametersResult from ElastiCache.</returns>
        DescribeCacheParametersResponse EndDescribeCacheParameters(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCacheSecurityGroups


        /// <summary>
        /// The <i>DescribeCacheSecurityGroups</i> action returns a list of cache security group
        /// descriptions. If a cache security group name is specified, the list will contain only
        /// the description of that group.
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
        DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups();

        /// <summary>
        /// The <i>DescribeCacheSecurityGroups</i> action returns a list of cache security group
        /// descriptions. If a cache security group name is specified, the list will contain only
        /// the description of that group.
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
        DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSecurityGroups operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCacheSecurityGroups
        ///         operation.</returns>
        IAsyncResult BeginDescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCacheSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheSecurityGroups.</param>
        /// 
        /// <returns>Returns a  DescribeCacheSecurityGroupsResult from ElastiCache.</returns>
        DescribeCacheSecurityGroupsResponse EndDescribeCacheSecurityGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCacheSubnetGroups


        /// <summary>
        /// The <i>DescribeCacheSubnetGroups</i> action returns a list of cache subnet group descriptions.
        /// If a subnet group name is specified, the list will contain only the description of
        /// that group.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        DescribeCacheSubnetGroupsResponse DescribeCacheSubnetGroups();

        /// <summary>
        /// The <i>DescribeCacheSubnetGroups</i> action returns a list of cache subnet group descriptions.
        /// If a subnet group name is specified, the list will contain only the description of
        /// that group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException">
        /// The requested cache subnet group name does not refer to an existing cache subnet group.
        /// </exception>
        DescribeCacheSubnetGroupsResponse DescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCacheSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCacheSubnetGroups operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCacheSubnetGroups
        ///         operation.</returns>
        IAsyncResult BeginDescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCacheSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCacheSubnetGroups.</param>
        /// 
        /// <returns>Returns a  DescribeCacheSubnetGroupsResult from ElastiCache.</returns>
        DescribeCacheSubnetGroupsResponse EndDescribeCacheSubnetGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEngineDefaultParameters


        /// <summary>
        /// The <i>DescribeEngineDefaultParameters</i> action returns the default engine and system
        /// parameter information for the specified cache engine.
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
        DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEngineDefaultParameters
        ///         operation.</returns>
        IAsyncResult BeginDescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEngineDefaultParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEngineDefaultParameters.</param>
        /// 
        /// <returns>Returns a  DescribeEngineDefaultParametersResult from ElastiCache.</returns>
        DescribeEngineDefaultParametersResponse EndDescribeEngineDefaultParameters(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEvents


        /// <summary>
        /// The <i>DescribeEvents</i> action returns events related to cache clusters, cache security
        /// groups, and cache parameter groups. You can obtain events specific to a particular
        /// cache cluster, cache security group, or cache parameter group by providing the name
        /// as a parameter.
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
        DescribeEventsResponse DescribeEvents();

        /// <summary>
        /// The <i>DescribeEvents</i> action returns events related to cache clusters, cache security
        /// groups, and cache parameter groups. You can obtain events specific to a particular
        /// cache cluster, cache security group, or cache parameter group by providing the name
        /// as a parameter.
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
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        IAsyncResult BeginDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a  DescribeEventsResult from ElastiCache.</returns>
        DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReplicationGroups


        /// <summary>
        /// The <i>DescribeReplicationGroups</i> action returns information about a particular
        /// replication group. If no identifier is specified, <i>DescribeReplicationGroups</i>
        /// returns information about all replication groups.
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
        DescribeReplicationGroupsResponse DescribeReplicationGroups();

        /// <summary>
        /// The <i>DescribeReplicationGroups</i> action returns information about a particular
        /// replication group. If no identifier is specified, <i>DescribeReplicationGroups</i>
        /// returns information about all replication groups.
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
        DescribeReplicationGroupsResponse DescribeReplicationGroups(DescribeReplicationGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationGroups operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicationGroups
        ///         operation.</returns>
        IAsyncResult BeginDescribeReplicationGroups(DescribeReplicationGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicationGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationGroups.</param>
        /// 
        /// <returns>Returns a  DescribeReplicationGroupsResult from ElastiCache.</returns>
        DescribeReplicationGroupsResponse EndDescribeReplicationGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReservedCacheNodes


        /// <summary>
        /// The <i>DescribeReservedCacheNodes</i> action returns information about reserved cache
        /// nodes for this account, or about a specified reserved cache node.
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
        DescribeReservedCacheNodesResponse DescribeReservedCacheNodes();

        /// <summary>
        /// The <i>DescribeReservedCacheNodes</i> action returns information about reserved cache
        /// nodes for this account, or about a specified reserved cache node.
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
        DescribeReservedCacheNodesResponse DescribeReservedCacheNodes(DescribeReservedCacheNodesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedCacheNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodes operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedCacheNodes
        ///         operation.</returns>
        IAsyncResult BeginDescribeReservedCacheNodes(DescribeReservedCacheNodesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedCacheNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedCacheNodes.</param>
        /// 
        /// <returns>Returns a  DescribeReservedCacheNodesResult from ElastiCache.</returns>
        DescribeReservedCacheNodesResponse EndDescribeReservedCacheNodes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReservedCacheNodesOfferings


        /// <summary>
        /// The <i>DescribeReservedCacheNodesOfferings</i> action lists available reserved cache
        /// node offerings.
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
        DescribeReservedCacheNodesOfferingsResponse DescribeReservedCacheNodesOfferings();

        /// <summary>
        /// The <i>DescribeReservedCacheNodesOfferings</i> action lists available reserved cache
        /// node offerings.
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
        DescribeReservedCacheNodesOfferingsResponse DescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedCacheNodesOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedCacheNodesOfferings operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedCacheNodesOfferings
        ///         operation.</returns>
        IAsyncResult BeginDescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedCacheNodesOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedCacheNodesOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeReservedCacheNodesOfferingsResult from ElastiCache.</returns>
        DescribeReservedCacheNodesOfferingsResponse EndDescribeReservedCacheNodesOfferings(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSnapshots


        /// <summary>
        /// The <i>DescribeSnapshots</i> action returns information about cache cluster snapshots.
        /// By default, <i>DescribeSnapshots</i> lists all of your snapshots; it can optionally
        /// describe a single snapshot, or just the snapshots associated with a particular cache
        /// cluster.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
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
        DescribeSnapshotsResponse DescribeSnapshots();

        /// <summary>
        /// The <i>DescribeSnapshots</i> action returns information about cache cluster snapshots.
        /// By default, <i>DescribeSnapshots</i> lists all of your snapshots; it can optionally
        /// describe a single snapshot, or just the snapshots associated with a particular cache
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
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
        DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSnapshots
        ///         operation.</returns>
        IAsyncResult BeginDescribeSnapshots(DescribeSnapshotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshots.</param>
        /// 
        /// <returns>Returns a  DescribeSnapshotsResult from ElastiCache.</returns>
        DescribeSnapshotsResponse EndDescribeSnapshots(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAllowedNodeTypeModifications


        /// <summary>
        /// The <code>ListAllowedNodeTypeModifications</code> action lists all available node
        /// types that you can scale your Redis cluster's or replication group's current node
        /// type up to.
        /// 
        ///  
        /// <para>
        /// When you use the <code>ModifyCacheCluster</code> or <code>ModifyReplicationGroup</code>
        /// APIs to scale up your cluster or replication group, the value of the <i>CacheNodeType</i>
        /// parameter must be one of the node types returned by this action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAllowedNodeTypeModifications service method.</param>
        /// 
        /// <returns>The response from the ListAllowedNodeTypeModifications service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
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
        ListAllowedNodeTypeModificationsResponse ListAllowedNodeTypeModifications(ListAllowedNodeTypeModificationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAllowedNodeTypeModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAllowedNodeTypeModifications operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAllowedNodeTypeModifications
        ///         operation.</returns>
        IAsyncResult BeginListAllowedNodeTypeModifications(ListAllowedNodeTypeModificationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAllowedNodeTypeModifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAllowedNodeTypeModifications.</param>
        /// 
        /// <returns>Returns a  ListAllowedNodeTypeModificationsResult from ElastiCache.</returns>
        ListAllowedNodeTypeModificationsResponse EndListAllowedNodeTypeModifications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// The <i>ListTagsForResource</i> action lists all cost allocation tags currently on
        /// the named resource. A <i>cost allocation tag</i> is a key-value pair where the key
        /// is case-sensitive and the value is optional. Cost allocation tags can be used to categorize
        /// and track your AWS costs.
        /// 
        ///  
        /// <para>
        /// You can have a maximum of 10 cost allocation tags on an ElastiCache resource. For
        /// more information, see <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/BestPractices.html">Using
        /// Cost Allocation Tags in Amazon ElastiCache</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidARNException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotNotFoundException">
        /// The requested snapshot name does not refer to an existing snapshot.
        /// </exception>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ElastiCache.</returns>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyCacheCluster


        /// <summary>
        /// The <i>ModifyCacheCluster</i> action modifies the settings for a cache cluster. You
        /// can use this action to change one or more cluster configuration parameters by specifying
        /// the parameters and the new values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyCacheCluster service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
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
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cache cluster is not in the <i>available</i> state.
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
        /// nodes in a single cache cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes per customer.
        /// </exception>
        ModifyCacheClusterResponse ModifyCacheCluster(ModifyCacheClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheCluster operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyCacheCluster
        ///         operation.</returns>
        IAsyncResult BeginModifyCacheCluster(ModifyCacheClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyCacheCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCacheCluster.</param>
        /// 
        /// <returns>Returns a  ModifyCacheClusterResult from ElastiCache.</returns>
        ModifyCacheClusterResponse EndModifyCacheCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyCacheParameterGroup


        /// <summary>
        /// The <i>ModifyCacheParameterGroup</i> action modifies the parameters of a cache parameter
        /// group. You can modify up to 20 parameters in a single request by submitting a list
        /// parameter name and value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyCacheParameterGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException">
        /// The current state of the cache parameter group does not allow the requested action
        /// to occur.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        ModifyCacheParameterGroupResponse ModifyCacheParameterGroup(ModifyCacheParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheParameterGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyCacheParameterGroup
        ///         operation.</returns>
        IAsyncResult BeginModifyCacheParameterGroup(ModifyCacheParameterGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyCacheParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCacheParameterGroup.</param>
        /// 
        /// <returns>Returns a  ModifyCacheParameterGroupResult from ElastiCache.</returns>
        ModifyCacheParameterGroupResponse EndModifyCacheParameterGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyCacheSubnetGroup


        /// <summary>
        /// The <i>ModifyCacheSubnetGroup</i> action modifies an existing cache subnet group.
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
        ModifyCacheSubnetGroupResponse ModifyCacheSubnetGroup(ModifyCacheSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCacheSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCacheSubnetGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyCacheSubnetGroup
        ///         operation.</returns>
        IAsyncResult BeginModifyCacheSubnetGroup(ModifyCacheSubnetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyCacheSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCacheSubnetGroup.</param>
        /// 
        /// <returns>Returns a  ModifyCacheSubnetGroupResult from ElastiCache.</returns>
        ModifyCacheSubnetGroupResponse EndModifyCacheSubnetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyReplicationGroup


        /// <summary>
        /// The <i>ModifyReplicationGroup</i> action modifies the settings for a replication group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyReplicationGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
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
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cache cluster is not in the <i>available</i> state.
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
        /// <exception cref="Amazon.ElastiCache.Model.InvalidReplicationGroupStateException">
        /// The requested replication group is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidVPCNetworkStateException">
        /// The VPC network is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeQuotaForClusterExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes in a single cache cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.NodeQuotaForCustomerExceededException">
        /// The request cannot be processed because it would exceed the allowed number of cache
        /// nodes per customer.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.ReplicationGroupNotFoundException">
        /// The specified replication group does not exist.
        /// </exception>
        ModifyReplicationGroupResponse ModifyReplicationGroup(ModifyReplicationGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyReplicationGroup
        ///         operation.</returns>
        IAsyncResult BeginModifyReplicationGroup(ModifyReplicationGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyReplicationGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyReplicationGroup.</param>
        /// 
        /// <returns>Returns a  ModifyReplicationGroupResult from ElastiCache.</returns>
        ModifyReplicationGroupResponse EndModifyReplicationGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  PurchaseReservedCacheNodesOffering


        /// <summary>
        /// The <i>PurchaseReservedCacheNodesOffering</i> action allows you to purchase a reserved
        /// cache node offering.
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
        PurchaseReservedCacheNodesOfferingResponse PurchaseReservedCacheNodesOffering(PurchaseReservedCacheNodesOfferingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedCacheNodesOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedCacheNodesOffering operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseReservedCacheNodesOffering
        ///         operation.</returns>
        IAsyncResult BeginPurchaseReservedCacheNodesOffering(PurchaseReservedCacheNodesOfferingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseReservedCacheNodesOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedCacheNodesOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseReservedCacheNodesOfferingResult from ElastiCache.</returns>
        PurchaseReservedCacheNodesOfferingResponse EndPurchaseReservedCacheNodesOffering(IAsyncResult asyncResult);

        #endregion
        
        #region  RebootCacheCluster


        /// <summary>
        /// The <i>RebootCacheCluster</i> action reboots some, or all, of the cache nodes within
        /// a provisioned cache cluster. This API will apply any modified cache parameter groups
        /// to the cache cluster. The reboot action takes place as soon as possible, and results
        /// in a momentary outage to the cache cluster. During the reboot, the cache cluster status
        /// is set to REBOOTING.
        /// 
        ///  
        /// <para>
        /// The reboot causes the contents of the cache (for each cache node being rebooted) to
        /// be lost.
        /// </para>
        ///  
        /// <para>
        /// When the reboot is complete, a cache cluster event is created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootCacheCluster service method.</param>
        /// 
        /// <returns>The response from the RebootCacheCluster service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheClusterStateException">
        /// The requested cache cluster is not in the <i>available</i> state.
        /// </exception>
        RebootCacheClusterResponse RebootCacheCluster(RebootCacheClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RebootCacheCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootCacheCluster operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootCacheCluster
        ///         operation.</returns>
        IAsyncResult BeginRebootCacheCluster(RebootCacheClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RebootCacheCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootCacheCluster.</param>
        /// 
        /// <returns>Returns a  RebootCacheClusterResult from ElastiCache.</returns>
        RebootCacheClusterResponse EndRebootCacheCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveTagsFromResource


        /// <summary>
        /// The <i>RemoveTagsFromResource</i> action removes the tags identified by the <code>TagKeys</code>
        /// list from the named resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheClusterNotFoundException">
        /// The requested cache cluster ID does not refer to an existing cache cluster.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidARNException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.SnapshotNotFoundException">
        /// The requested snapshot name does not refer to an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.TagNotFoundException">
        /// The requested tag was not found on this resource.
        /// </exception>
        RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTagsFromResource
        ///         operation.</returns>
        IAsyncResult BeginRemoveTagsFromResource(RemoveTagsFromResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTagsFromResource.</param>
        /// 
        /// <returns>Returns a  RemoveTagsFromResourceResult from ElastiCache.</returns>
        RemoveTagsFromResourceResponse EndRemoveTagsFromResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetCacheParameterGroup


        /// <summary>
        /// The <i>ResetCacheParameterGroup</i> action modifies the parameters of a cache parameter
        /// group to the engine or system default value. You can reset specific parameters by
        /// submitting a list of parameter names. To reset the entire cache parameter group, specify
        /// the <i>ResetAllParameters</i> and <i>CacheParameterGroupName</i> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetCacheParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetCacheParameterGroup service method, as returned by ElastiCache.</returns>
        /// <exception cref="Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException">
        /// The requested cache parameter group name does not refer to an existing cache parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException">
        /// The current state of the cache parameter group does not allow the requested action
        /// to occur.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.ElastiCache.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        ResetCacheParameterGroupResponse ResetCacheParameterGroup(ResetCacheParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetCacheParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetCacheParameterGroup operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetCacheParameterGroup
        ///         operation.</returns>
        IAsyncResult BeginResetCacheParameterGroup(ResetCacheParameterGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetCacheParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetCacheParameterGroup.</param>
        /// 
        /// <returns>Returns a  ResetCacheParameterGroupResult from ElastiCache.</returns>
        ResetCacheParameterGroupResponse EndResetCacheParameterGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  RevokeCacheSecurityGroupIngress


        /// <summary>
        /// The <i>RevokeCacheSecurityGroupIngress</i> action revokes ingress from a cache security
        /// group. Use this action to disallow access from an Amazon EC2 security group that had
        /// been previously authorized.
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
        RevokeCacheSecurityGroupIngressResponse RevokeCacheSecurityGroupIngress(RevokeCacheSecurityGroupIngressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeCacheSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeCacheSecurityGroupIngress operation on AmazonElastiCacheClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeCacheSecurityGroupIngress
        ///         operation.</returns>
        IAsyncResult BeginRevokeCacheSecurityGroupIngress(RevokeCacheSecurityGroupIngressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeCacheSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeCacheSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a  RevokeCacheSecurityGroupIngressResult from ElastiCache.</returns>
        RevokeCacheSecurityGroupIngressResponse EndRevokeCacheSecurityGroupIngress(IAsyncResult asyncResult);

        #endregion
        
    }
}