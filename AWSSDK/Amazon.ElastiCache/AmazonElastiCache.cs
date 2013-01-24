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
    ///  Amazon ElastiCache <para> Amazon ElastiCache is a web service that makes it easier to set up, operate, and scale a distributed cache in the
    /// cloud. </para> <para> With Amazon ElastiCache, customers gain all of the benefits of a high-performance, in-memory cache with far less of
    /// the administrative burden of launching and managing a distributed cache. The service makes set-up, scaling, and cluster failure handling
    /// much simpler than in a self-managed cache deployment. </para> <para> In addition, through integration with Amazon CloudWatch, customers get
    /// enhanced visibility into the key performance statistics associated with their cache and can receive alarms if a part of their cache runs
    /// hot. </para>
    /// </summary>
    public interface AmazonElastiCache : IDisposable
    {
        

        #region AuthorizeCacheSecurityGroupIngress

        /// <summary>
        /// <para> Authorizes ingress to a CacheSecurityGroup using EC2 Security Groups as authorization (therefore the application using the cache must
        /// be running on EC2 clusters). This API requires the following parameters: EC2SecurityGroupName and EC2SecurityGroupOwnerId. </para>
        /// <para><b>NOTE:</b> You cannot authorize ingress from an EC2 security group in one Region to an Amazon Cache Cluster in another. </para>
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
        /// <para> Creates a new Cache Subnet Group. </para>
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
        
    

        #region PurchaseReservedCacheNodesOffering

        /// <summary>
        /// <para> Purchases a reserved Cache Node offering. </para>
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
        
    

        #region RebootCacheCluster

        /// <summary>
        /// <para> Reboots some (or all) of the cache cluster nodes within a previously provisioned ElastiCache cluster. This API results in the
        /// application of modified CacheParameterGroup parameters to the cache cluster. This action is taken as soon as possible, and results in a
        /// momentary outage to the cache cluster during which the cache cluster status is set to rebooting. During that momentary outage, the contents
        /// of the cache (for each cache cluster node being rebooted) are lost. A CacheCluster event is created when the reboot is completed. </para>
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
        
    

        #region RevokeCacheSecurityGroupIngress

        /// <summary>
        /// <para> Revokes ingress from a CacheSecurityGroup for previously authorized EC2 Security Groups. </para>
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
        
    

        #region DescribeCacheSubnetGroups

        /// <summary>
        /// <para> Returns a list of CacheSubnetGroup descriptions. If a CacheSubnetGroupName is specified, the list will contain only the description
        /// of the specified Cache Subnet Group. </para>
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
        /// <para> Returns a list of CacheSubnetGroup descriptions. If a CacheSubnetGroupName is specified, the list will contain only the description
        /// of the specified Cache Subnet Group. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="CacheSubnetGroupNotFoundException"/>
        DescribeCacheSubnetGroupsResponse DescribeCacheSubnetGroups();
        
        #endregion
        
    

        #region CreateCacheSecurityGroup

        /// <summary>
        /// <para> Creates a new Cache Security Group. Cache Security groups control access to one or more Cache Clusters. </para> <para> Only use cache
        /// security groups when you are creating a cluster outside of an Amazon Virtual Private Cloud (VPC). Inside of a VPC, use VPC security groups.
        /// </para>
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
        
    

        #region CreateCacheCluster

        /// <summary>
        /// <para> Creates a new Cache Cluster. </para>
        /// </summary>
        /// 
        /// <param name="createCacheClusterRequest">Container for the necessary parameters to execute the CreateCacheCluster service method on
        ///          AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="NodeQuotaForCustomerExceededException"/>
        /// <exception cref="NodeQuotaForClusterExceededException"/>
        /// <exception cref="CacheSubnetGroupNotFoundException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="ClusterQuotaForCustomerExceededException"/>
        /// <exception cref="CacheClusterAlreadyExistsException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        /// <exception cref="InsufficientCacheClusterCapacityException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
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
        
    

        #region DescribeEvents

        /// <summary>
        /// <para> Returns events related to Cache Clusters, Cache Security Groups, and Cache Parameter Groups for the past 14 days. Events specific to
        /// a particular Cache Cluster, Cache Security Group, or Cache Parameter Group can be obtained by providing the name as a parameter. By default,
        /// the past hour of events are returned. </para>
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
        /// <para> Returns events related to Cache Clusters, Cache Security Groups, and Cache Parameter Groups for the past 14 days. Events specific to
        /// a particular Cache Cluster, Cache Security Group, or Cache Parameter Group can be obtained by providing the name as a parameter. By default,
        /// the past hour of events are returned. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        DescribeEventsResponse DescribeEvents();
        
        #endregion
        
    

        #region DescribeReservedCacheNodes

        /// <summary>
        /// <para> Returns information about reserved Cache Nodes for this account, or about a specified reserved Cache Node. </para>
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
        /// <para> Returns information about reserved Cache Nodes for this account, or about a specified reserved Cache Node. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodes service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="ReservedCacheNodeNotFoundException"/>
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        DescribeReservedCacheNodesResponse DescribeReservedCacheNodes();
        
        #endregion
        
    

        #region DescribeCacheEngineVersions

        /// <summary>
        /// <para> Returns a list of the available cache engines and their versions. </para>
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
        /// <para> Returns a list of the available cache engines and their versions. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by AmazonElastiCache.</returns>
        /// 
        DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions();
        
        #endregion
        
    

        #region DeleteCacheParameterGroup

        /// <summary>
        /// <para> Deletes the specified CacheParameterGroup. The CacheParameterGroup cannot be deleted if it is associated with any cache clusters.
        /// </para>
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
        
    

        #region ModifyCacheParameterGroup

        /// <summary>
        /// <para> Modifies the parameters of a CacheParameterGroup. To modify more than one parameter, submit a list of ParameterName and
        /// ParameterValue parameters. A maximum of 20 parameters can be modified in a single request. </para>
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
        
    

        #region DescribeEngineDefaultParameters

        /// <summary>
        /// <para> Returns the default engine and system parameter information for the specified cache engine. </para>
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
        
    

        #region DeleteCacheSubnetGroup

        /// <summary>
        /// <para> Deletes a Cache Subnet Group. </para> <para><b>NOTE:</b>The specified Cache Subnet Group must not be associated with any Cache
        /// Clusters.</para>
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
        
    

        #region CreateCacheParameterGroup

        /// <summary>
        /// <para> Creates a new Cache Parameter Group. Cache Parameter groups control the parameters for a Cache Cluster.</para>
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
        
    

        #region DescribeCacheSecurityGroups

        /// <summary>
        /// <para> Returns a list of CacheSecurityGroup descriptions. If a CacheSecurityGroupName is specified, the list will contain only the
        /// description of the specified CacheSecurityGroup. </para>
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
        /// <para> Returns a list of CacheSecurityGroup descriptions. If a CacheSecurityGroupName is specified, the list will contain only the
        /// description of the specified CacheSecurityGroup. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheSecurityGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheSecurityGroupNotFoundException"/>
        DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups();
        
        #endregion
        
    

        #region DescribeCacheParameterGroups

        /// <summary>
        /// <para> Returns a list of CacheParameterGroup descriptions. If a CacheParameterGroupName is specified, the list will contain only the
        /// descriptions of the specified CacheParameterGroup. </para>
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
        /// <para> Returns a list of CacheParameterGroup descriptions. If a CacheParameterGroupName is specified, the list will contain only the
        /// descriptions of the specified CacheParameterGroup. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheParameterGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="CacheParameterGroupNotFoundException"/>
        DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups();
        
        #endregion
        
    

        #region DescribeCacheClusters

        /// <summary>
        /// <para> Returns information about all provisioned Cache Clusters if no Cache Cluster identifier is specified, or about a specific Cache
        /// Cluster if a Cache Cluster identifier is supplied. </para> <para> Cluster information will be returned by default. An optional
        /// <i>ShowDetails</i> flag can be used to retrieve detailed information about the Cache Nodes associated with the Cache Cluster. Details
        /// include the DNS address and port for the Cache Node endpoint. </para> <para> If the cluster is in the CREATING state, only cluster level
        /// information will be displayed until all of the nodes are successfully provisioned. </para> <para> If the cluster is in the DELETING state,
        /// only cluster level information will be displayed. </para> <para> While adding Cache Nodes, node endpoint information and creation time for
        /// the additional nodes will not be displayed until they are completely provisioned. The cluster lifecycle tells the customer when new nodes
        /// are AVAILABLE. </para> <para> While removing existing Cache Nodes from an cluster, endpoint information for the removed nodes will not be
        /// displayed. </para> <para>DescribeCacheClusters supports pagination.</para>
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
        /// <para> Returns information about all provisioned Cache Clusters if no Cache Cluster identifier is specified, or about a specific Cache
        /// Cluster if a Cache Cluster identifier is supplied. </para> <para> Cluster information will be returned by default. An optional
        /// <i>ShowDetails</i> flag can be used to retrieve detailed information about the Cache Nodes associated with the Cache Cluster. Details
        /// include the DNS address and port for the Cache Node endpoint. </para> <para> If the cluster is in the CREATING state, only cluster level
        /// information will be displayed until all of the nodes are successfully provisioned. </para> <para> If the cluster is in the DELETING state,
        /// only cluster level information will be displayed. </para> <para> While adding Cache Nodes, node endpoint information and creation time for
        /// the additional nodes will not be displayed until they are completely provisioned. The cluster lifecycle tells the customer when new nodes
        /// are AVAILABLE. </para> <para> While removing existing Cache Nodes from an cluster, endpoint information for the removed nodes will not be
        /// displayed. </para> <para>DescribeCacheClusters supports pagination.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCacheClusters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="CacheClusterNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        DescribeCacheClustersResponse DescribeCacheClusters();
        
        #endregion
        
    

        #region ResetCacheParameterGroup

        /// <summary>
        /// <para> Modifies the parameters of a CacheParameterGroup to the engine or system default value. To reset specific parameters submit a list of
        /// the parameter names. To reset the entire CacheParameterGroup, specify the CacheParameterGroup name and ResetAllParameters parameters.
        /// </para>
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
        
    

        #region DeleteCacheSecurityGroup

        /// <summary>
        /// <para> Deletes a Cache Security Group. </para> <para><b>NOTE:</b>The specified Cache Security Group must not be associated with any Cache
        /// Clusters.</para>
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
        
    

        #region ModifyCacheCluster

        /// <summary>
        /// <para> Modifies the Cache Cluster settings. You can change one or more Cache Cluster configuration parameters by specifying the parameters
        /// and the new values in the request. </para>
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
        
    

        #region DeleteCacheCluster

        /// <summary>
        /// <para> Deletes a previously provisioned Cache Cluster. A successful response from the web service indicates the request was received
        /// correctly. This action cannot be canceled or reverted. DeleteCacheCluster deletes all associated Cache Nodes, node endpoints and the Cache
        /// Cluster itself. </para>
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
        
    

        #region DescribeReservedCacheNodesOfferings

        /// <summary>
        /// <para> Lists available reserved Cache Node offerings. </para>
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
        /// <para> Lists available reserved Cache Node offerings. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodesOfferings service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="ReservedCacheNodesOfferingNotFoundException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        DescribeReservedCacheNodesOfferingsResponse DescribeReservedCacheNodesOfferings();
        
        #endregion
        
    

        #region DescribeCacheParameters

        /// <summary>
        /// <para> Returns the detailed parameter list for a particular CacheParameterGroup. </para>
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
        
    

        #region ModifyCacheSubnetGroup

        /// <summary>
        /// <para> Modifies an existing Cache Subnet Group. </para>
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
        
    
    }
}
    
