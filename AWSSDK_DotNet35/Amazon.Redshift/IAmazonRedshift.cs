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

using Amazon.Redshift;
using Amazon.Redshift.Model;

namespace Amazon.Redshift
{
    /// <summary>
    /// Interface for accessing AmazonRedshift.
    ///  
    ///  Amazon Redshift <b>Overview</b> <para> This is an interface reference for Amazon Redshift. It contains documentation for one of the
    /// programming or command line interfaces you can use to manage Amazon Redshift clusters. Note that Amazon Redshift is asynchronous, which
    /// means that some interfaces may require techniques, such as polling or asynchronous callback handlers, to determine when a command has been
    /// applied. In this reference, the parameter descriptions indicate whether a change is applied immediately, on the next instance reboot, or
    /// during the next maintenance window. For a summary of the Amazon Redshift cluster management interfaces, go to <a
    /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/using-aws-sdk.html" >Using the Amazon Redshift Management Interfaces </a> .</para>
    /// <para> Amazon Redshift manages all the work of setting up, operating, and scaling a data warehouse: provisioning capacity, monitoring and
    /// backing up the cluster, and applying patches and upgrades to the Amazon Redshift engine. You can focus on using your data to acquire new
    /// insights for your business and customers. </para> <para>If you are a first-time user of Amazon Redshift, we recommend that you begin by
    /// reading the The <a href="http://docs.aws.amazon.com/redshift/latest/gsg/getting-started.html" >Amazon Redshift Getting Started Guide</a>
    /// </para> <para>If you are a database developer, the <a href="http://docs.aws.amazon.com/redshift/latest/dg/welcome.html" >Amazon Redshift
    /// Database Developer Guide</a> explains how to design, build, query, and maintain the databases that make up your data warehouse. </para>
    /// </summary>
    public partial interface IAmazonRedshift : IDisposable
    {


        #region AuthorizeClusterSecurityGroupIngress

        /// <summary>
        /// <para> Adds an inbound (ingress) rule to an Amazon Redshift security group. Depending on whether the application accessing your cluster is
        /// running on the Internet or an EC2 instance, you can authorize inbound access to either a Classless Interdomain Routing (CIDR) IP address
        /// range or an EC2 security group. You can add as many as 20 ingress rules to an Amazon Redshift security group. </para> <para><b>NOTE:</b> The
        /// EC2 security group must be defined in the AWS region where the cluster resides. </para> <para>For an overview of CIDR blocks, see the
        /// Wikipedia article on <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing" >Classless Inter-Domain Routing</a> .
        /// </para> <para> You must also associate the security group with a cluster so that clients running on these IP addresses or the EC2
        /// instance are authorized to connect to the cluster. For information about managing security groups, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html" >Working with Security Groups</a> in the <i>Amazon
        /// Redshift Management Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="authorizeClusterSecurityGroupIngressRequest">Container for the necessary parameters to execute the
        ///          AuthorizeClusterSecurityGroupIngress service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the AuthorizeClusterSecurityGroupIngress service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="InvalidClusterSecurityGroupStateException"/>
        /// <exception cref="AuthorizationAlreadyExistsException"/>
        /// <exception cref="AuthorizationQuotaExceededException"/>
        /// <exception cref="ClusterSecurityGroupNotFoundException"/>
        AuthorizeClusterSecurityGroupIngressResponse AuthorizeClusterSecurityGroupIngress(AuthorizeClusterSecurityGroupIngressRequest authorizeClusterSecurityGroupIngressRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeClusterSecurityGroupIngress operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.AuthorizeClusterSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="authorizeClusterSecurityGroupIngressRequest">Container for the necessary parameters to execute the
        ///          AuthorizeClusterSecurityGroupIngress operation on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAuthorizeClusterSecurityGroupIngress operation.</returns>
        IAsyncResult BeginAuthorizeClusterSecurityGroupIngress(AuthorizeClusterSecurityGroupIngressRequest authorizeClusterSecurityGroupIngressRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AuthorizeClusterSecurityGroupIngress operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.AuthorizeClusterSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeClusterSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a ClusterSecurityGroup from AmazonRedshift.</returns>
        AuthorizeClusterSecurityGroupIngressResponse EndAuthorizeClusterSecurityGroupIngress(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AuthorizeSnapshotAccess

        /// <summary>
        /// <para> Authorizes the specified AWS customer account to restore the specified snapshot. </para> <para> For more information about working
        /// with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html" >Amazon Redshift Snapshots</a>
        /// in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="authorizeSnapshotAccessRequest">Container for the necessary parameters to execute the AuthorizeSnapshotAccess service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the AuthorizeSnapshotAccess service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="AuthorizationAlreadyExistsException"/>
        /// <exception cref="ClusterSnapshotNotFoundException"/>
        /// <exception cref="AuthorizationQuotaExceededException"/>
        AuthorizeSnapshotAccessResponse AuthorizeSnapshotAccess(AuthorizeSnapshotAccessRequest authorizeSnapshotAccessRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSnapshotAccess operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.AuthorizeSnapshotAccess"/>
        /// </summary>
        /// 
        /// <param name="authorizeSnapshotAccessRequest">Container for the necessary parameters to execute the AuthorizeSnapshotAccess operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAuthorizeSnapshotAccess operation.</returns>
        IAsyncResult BeginAuthorizeSnapshotAccess(AuthorizeSnapshotAccessRequest authorizeSnapshotAccessRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AuthorizeSnapshotAccess operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.AuthorizeSnapshotAccess"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeSnapshotAccess.</param>
        /// 
        /// <returns>Returns a Snapshot from AmazonRedshift.</returns>
        AuthorizeSnapshotAccessResponse EndAuthorizeSnapshotAccess(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CopyClusterSnapshot

        /// <summary>
        /// <para> Copies the specified automated cluster snapshot to a new manual cluster snapshot. The source must be an automated snapshot and it
        /// must be in the available state. </para> <para> When you delete a cluster, Amazon Redshift deletes any automated snapshots of the cluster.
        /// Also, when the retention period of the snapshot expires, Amazon Redshift automatically deletes it. If you want to keep an automated snapshot
        /// for a longer period, you can make a manual copy of the snapshot. Manual snapshots are retained until you delete them. </para> <para> For
        /// more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html"
        /// >Amazon Redshift Snapshots</a> in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="copyClusterSnapshotRequest">Container for the necessary parameters to execute the CopyClusterSnapshot service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CopyClusterSnapshot service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterSnapshotAlreadyExistsException"/>
        /// <exception cref="ClusterSnapshotNotFoundException"/>
        /// <exception cref="ClusterSnapshotQuotaExceededException"/>
        /// <exception cref="InvalidClusterSnapshotStateException"/>
        CopyClusterSnapshotResponse CopyClusterSnapshot(CopyClusterSnapshotRequest copyClusterSnapshotRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CopyClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CopyClusterSnapshot"/>
        /// </summary>
        /// 
        /// <param name="copyClusterSnapshotRequest">Container for the necessary parameters to execute the CopyClusterSnapshot operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCopyClusterSnapshot operation.</returns>
        IAsyncResult BeginCopyClusterSnapshot(CopyClusterSnapshotRequest copyClusterSnapshotRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CopyClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CopyClusterSnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyClusterSnapshot.</param>
        /// 
        /// <returns>Returns a Snapshot from AmazonRedshift.</returns>
        CopyClusterSnapshotResponse EndCopyClusterSnapshot(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateCluster

        /// <summary>
        /// <para> Creates a new cluster. To create the cluster in virtual private cloud (VPC), you must provide cluster subnet group name. If you don't
        /// provide a cluster subnet group name or the cluster security group parameter, Amazon Redshift creates a non-VPC cluster, it associates the
        /// default cluster security group with the cluster. For more information about managing clusters, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html" >Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createClusterRequest">Container for the necessary parameters to execute the CreateCluster service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="InvalidElasticIpException"/>
        /// <exception cref="InvalidSubnetException"/>
        /// <exception cref="HsmConfigurationNotFoundException"/>
        /// <exception cref="ClusterSubnetGroupNotFoundException"/>
        /// <exception cref="InvalidClusterSubnetGroupStateException"/>
        /// <exception cref="ClusterAlreadyExistsException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        /// <exception cref="ClusterParameterGroupNotFoundException"/>
        /// <exception cref="InsufficientClusterCapacityException"/>
        /// <exception cref="UnauthorizedOperationException"/>
        /// <exception cref="NumberOfNodesQuotaExceededException"/>
        /// <exception cref="NumberOfNodesPerClusterLimitExceededException"/>
        /// <exception cref="HsmClientCertificateNotFoundException"/>
        /// <exception cref="ClusterQuotaExceededException"/>
        /// <exception cref="ClusterSecurityGroupNotFoundException"/>
        CreateClusterResponse CreateCluster(CreateClusterRequest createClusterRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateCluster"/>
        /// </summary>
        /// 
        /// <param name="createClusterRequest">Container for the necessary parameters to execute the CreateCluster operation on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCluster
        ///         operation.</returns>
        IAsyncResult BeginCreateCluster(CreateClusterRequest createClusterRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateCluster"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCluster.</param>
        /// 
        /// <returns>Returns a Cluster from AmazonRedshift.</returns>
        CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateClusterParameterGroup

        /// <summary>
        /// <para> Creates an Amazon Redshift parameter group. </para> <para>Creating parameter groups is independent of creating clusters. You can
        /// associate a cluster with a parameter group when you create the cluster. You can also associate an existing cluster with a parameter group
        /// after the cluster is created by using ModifyCluster. </para> <para> Parameters in the parameter group define specific behavior that applies
        /// to the databases you create on the cluster. For more information about managing parameter groups, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html" >Amazon Redshift Parameter Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createClusterParameterGroupRequest">Container for the necessary parameters to execute the CreateClusterParameterGroup service
        ///          method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateClusterParameterGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterParameterGroupQuotaExceededException"/>
        /// <exception cref="ClusterParameterGroupAlreadyExistsException"/>
        CreateClusterParameterGroupResponse CreateClusterParameterGroup(CreateClusterParameterGroupRequest createClusterParameterGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateClusterParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="createClusterParameterGroupRequest">Container for the necessary parameters to execute the CreateClusterParameterGroup operation
        ///          on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateClusterParameterGroup operation.</returns>
        IAsyncResult BeginCreateClusterParameterGroup(CreateClusterParameterGroupRequest createClusterParameterGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateClusterParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a ClusterParameterGroup from AmazonRedshift.</returns>
        CreateClusterParameterGroupResponse EndCreateClusterParameterGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateClusterSecurityGroup

        /// <summary>
        /// <para> Creates a new Amazon Redshift security group. You use security groups to control access to non-VPC clusters. </para> <para> For
        /// information about managing security groups, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html" >Amazon Redshift Cluster Security Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createClusterSecurityGroupRequest">Container for the necessary parameters to execute the CreateClusterSecurityGroup service
        ///          method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateClusterSecurityGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterSecurityGroupQuotaExceededException"/>
        /// <exception cref="ClusterSecurityGroupAlreadyExistsException"/>
        CreateClusterSecurityGroupResponse CreateClusterSecurityGroup(CreateClusterSecurityGroupRequest createClusterSecurityGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSecurityGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateClusterSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="createClusterSecurityGroupRequest">Container for the necessary parameters to execute the CreateClusterSecurityGroup operation
        ///          on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateClusterSecurityGroup operation.</returns>
        IAsyncResult BeginCreateClusterSecurityGroup(CreateClusterSecurityGroupRequest createClusterSecurityGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateClusterSecurityGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateClusterSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterSecurityGroup.</param>
        /// 
        /// <returns>Returns a ClusterSecurityGroup from AmazonRedshift.</returns>
        CreateClusterSecurityGroupResponse EndCreateClusterSecurityGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateClusterSnapshot

        /// <summary>
        /// <para> Creates a manual snapshot of the specified cluster. The cluster must be in the "available" state. </para> <para> For more information
        /// about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html" >Amazon Redshift
        /// Snapshots</a> in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createClusterSnapshotRequest">Container for the necessary parameters to execute the CreateClusterSnapshot service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateClusterSnapshot service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterSnapshotAlreadyExistsException"/>
        /// <exception cref="InvalidClusterStateException"/>
        /// <exception cref="ClusterNotFoundException"/>
        /// <exception cref="ClusterSnapshotQuotaExceededException"/>
        CreateClusterSnapshotResponse CreateClusterSnapshot(CreateClusterSnapshotRequest createClusterSnapshotRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateClusterSnapshot"/>
        /// </summary>
        /// 
        /// <param name="createClusterSnapshotRequest">Container for the necessary parameters to execute the CreateClusterSnapshot operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateClusterSnapshot operation.</returns>
        IAsyncResult BeginCreateClusterSnapshot(CreateClusterSnapshotRequest createClusterSnapshotRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateClusterSnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterSnapshot.</param>
        /// 
        /// <returns>Returns a Snapshot from AmazonRedshift.</returns>
        CreateClusterSnapshotResponse EndCreateClusterSnapshot(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateClusterSubnetGroup

        /// <summary>
        /// <para> Creates a new Amazon Redshift subnet group. You must provide a list of one or more subnets in your existing Amazon Virtual Private
        /// Cloud (Amazon VPC) when creating Amazon Redshift subnet group. </para> <para> For information about subnet groups, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-cluster-subnet-groups.html" >Amazon Redshift Cluster Subnet Groups</a> in
        /// the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createClusterSubnetGroupRequest">Container for the necessary parameters to execute the CreateClusterSubnetGroup service method
        ///          on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateClusterSubnetGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="InvalidSubnetException"/>
        /// <exception cref="UnauthorizedOperationException"/>
        /// <exception cref="ClusterSubnetQuotaExceededException"/>
        /// <exception cref="ClusterSubnetGroupAlreadyExistsException"/>
        /// <exception cref="ClusterSubnetGroupQuotaExceededException"/>
        CreateClusterSubnetGroupResponse CreateClusterSubnetGroup(CreateClusterSubnetGroupRequest createClusterSubnetGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateClusterSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="createClusterSubnetGroupRequest">Container for the necessary parameters to execute the CreateClusterSubnetGroup operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateClusterSubnetGroup operation.</returns>
        IAsyncResult BeginCreateClusterSubnetGroup(CreateClusterSubnetGroupRequest createClusterSubnetGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateClusterSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterSubnetGroup.</param>
        /// 
        /// <returns>Returns a ClusterSubnetGroup from AmazonRedshift.</returns>
        CreateClusterSubnetGroupResponse EndCreateClusterSubnetGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateEventSubscription

        /// <summary>
        /// <para> Creates an Amazon Redshift event notification subscription. This action requires an ARN (Amazon Resource Name) of an Amazon SNS topic
        /// created by either the Amazon Redshift console, the Amazon SNS console, or the Amazon SNS API. To obtain an ARN with Amazon SNS, you must
        /// create a topic in Amazon SNS and subscribe to the topic. The ARN is displayed in the SNS console. </para> <para> You can specify the source
        /// type, and lists of Amazon Redshift source IDs, event categories, and event severities. Notifications will be sent for all events you want
        /// that match those criteria. For example, you can specify source type = cluster, source ID = my-cluster-1 and mycluster2, event categories =
        /// Availability, Backup, and severity = ERROR. The subsription will only send notifications for those ERROR events in the Availability and
        /// Backup categores for the specified clusters. </para> <para> If you specify both the source type and source IDs, such as source type =
        /// cluster and source identifier = my-cluster-1, notifiactions will be sent for all the cluster events for my-cluster-1. If you specify a
        /// source type but do not specify a source identifier, you will receive notice of the events for the objects of that type in your AWS account.
        /// If you do not specify either the SourceType nor the SourceIdentifier, you will be notified of events generated from all Amazon Redshift
        /// sources belonging to your AWS account. You must specify a source type if you specify a source ID. </para>
        /// </summary>
        /// 
        /// <param name="createEventSubscriptionRequest">Container for the necessary parameters to execute the CreateEventSubscription service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="SubscriptionCategoryNotFoundException"/>
        /// <exception cref="SubscriptionAlreadyExistException"/>
        /// <exception cref="EventSubscriptionQuotaExceededException"/>
        /// <exception cref="SubscriptionEventIdNotFoundException"/>
        /// <exception cref="SubscriptionSeverityNotFoundException"/>
        /// <exception cref="SourceNotFoundException"/>
        /// <exception cref="SNSNoAuthorizationException"/>
        /// <exception cref="SNSTopicArnNotFoundException"/>
        /// <exception cref="SNSInvalidTopicException"/>
        CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest createEventSubscriptionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateEventSubscription"/>
        /// </summary>
        /// 
        /// <param name="createEventSubscriptionRequest">Container for the necessary parameters to execute the CreateEventSubscription operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateEventSubscription operation.</returns>
        IAsyncResult BeginCreateEventSubscription(CreateEventSubscriptionRequest createEventSubscriptionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateEventSubscription"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventSubscription.</param>
        /// 
        /// <returns>Returns a EventSubscription from AmazonRedshift.</returns>
        CreateEventSubscriptionResponse EndCreateEventSubscription(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateHsmClientCertificate

        /// <summary>
        /// <para>Creates an HSM client certificate that an Amazon Redshift cluster will use to connect to the client's HSM in order to store and
        /// retrieve the keys used to encrypt the cluster databases.</para> <para>The command returns a public key, which you must store in the HSM.
        /// After creating the HSM certificate, you must create an Amazon Redshift HSM configuration that provides a cluster the information needed to
        /// store and retrieve database encryption keys in the HSM. For more information, go to aLinkToHSMTopic in the Amazon Redshift Management
        /// Guide.</para>
        /// </summary>
        /// 
        /// <param name="createHsmClientCertificateRequest">Container for the necessary parameters to execute the CreateHsmClientCertificate service
        ///          method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateHsmClientCertificate service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="HsmClientCertificateQuotaExceededException"/>
        /// <exception cref="HsmClientCertificateAlreadyExistsException"/>
        CreateHsmClientCertificateResponse CreateHsmClientCertificate(CreateHsmClientCertificateRequest createHsmClientCertificateRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmClientCertificate operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateHsmClientCertificate"/>
        /// </summary>
        /// 
        /// <param name="createHsmClientCertificateRequest">Container for the necessary parameters to execute the CreateHsmClientCertificate operation
        ///          on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateHsmClientCertificate operation.</returns>
        IAsyncResult BeginCreateHsmClientCertificate(CreateHsmClientCertificateRequest createHsmClientCertificateRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateHsmClientCertificate operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateHsmClientCertificate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHsmClientCertificate.</param>
        /// 
        /// <returns>Returns a HsmClientCertificate from AmazonRedshift.</returns>
        CreateHsmClientCertificateResponse EndCreateHsmClientCertificate(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateHsmConfiguration

        /// <summary>
        /// <para>Creates an HSM configuration that contains the information required by an Amazon Redshift cluster to store and retrieve database
        /// encryption keys in a Hardware Storeage Module (HSM). After creating the HSM configuration, you can specify it as a parameter when creating a
        /// cluster. The cluster will then store its encryption keys in the HSM.</para> <para>Before creating an HSM configuration, you must have first
        /// created an HSM client certificate. For more information, go to aLinkToHSMTopic in the Amazon Redshift Management Guide.</para>
        /// </summary>
        /// 
        /// <param name="createHsmConfigurationRequest">Container for the necessary parameters to execute the CreateHsmConfiguration service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateHsmConfiguration service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="HsmConfigurationQuotaExceededException"/>
        /// <exception cref="HsmConfigurationAlreadyExistsException"/>
        CreateHsmConfigurationResponse CreateHsmConfiguration(CreateHsmConfigurationRequest createHsmConfigurationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmConfiguration operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateHsmConfiguration"/>
        /// </summary>
        /// 
        /// <param name="createHsmConfigurationRequest">Container for the necessary parameters to execute the CreateHsmConfiguration operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateHsmConfiguration operation.</returns>
        IAsyncResult BeginCreateHsmConfiguration(CreateHsmConfigurationRequest createHsmConfigurationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateHsmConfiguration operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateHsmConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHsmConfiguration.</param>
        /// 
        /// <returns>Returns a HsmConfiguration from AmazonRedshift.</returns>
        CreateHsmConfigurationResponse EndCreateHsmConfiguration(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteCluster

        /// <summary>
        /// <para> Deletes a previously provisioned cluster. A successful response from the web service indicates that the request was received
        /// correctly. If a final cluster snapshot is requested the status of the cluster will be "final-snapshot" while the snapshot is being taken,
        /// then it's "deleting" once Amazon Redshift begins deleting the cluster. Use DescribeClusters to monitor the status of the deletion. The
        /// delete operation cannot be canceled or reverted once submitted. For more information about managing clusters, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html" >Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="deleteClusterRequest">Container for the necessary parameters to execute the DeleteCluster service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterSnapshotAlreadyExistsException"/>
        /// <exception cref="InvalidClusterStateException"/>
        /// <exception cref="ClusterNotFoundException"/>
        /// <exception cref="ClusterSnapshotQuotaExceededException"/>
        DeleteClusterResponse DeleteCluster(DeleteClusterRequest deleteClusterRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteCluster"/>
        /// </summary>
        /// 
        /// <param name="deleteClusterRequest">Container for the necessary parameters to execute the DeleteCluster operation on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCluster
        ///         operation.</returns>
        IAsyncResult BeginDeleteCluster(DeleteClusterRequest deleteClusterRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteCluster"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCluster.</param>
        /// 
        /// <returns>Returns a Cluster from AmazonRedshift.</returns>
        DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteClusterParameterGroup

        /// <summary>
        /// <para> Deletes a specified Amazon Redshift parameter group. <para><b>NOTE:</b>You cannot delete a parameter group if it is associated with a
        /// cluster.</para> </para>
        /// </summary>
        /// 
        /// <param name="deleteClusterParameterGroupRequest">Container for the necessary parameters to execute the DeleteClusterParameterGroup service
        ///          method on AmazonRedshift.</param>
        /// 
        /// <exception cref="InvalidClusterParameterGroupStateException"/>
        /// <exception cref="ClusterParameterGroupNotFoundException"/>
        DeleteClusterParameterGroupResponse DeleteClusterParameterGroup(DeleteClusterParameterGroupRequest deleteClusterParameterGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteClusterParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteClusterParameterGroupRequest">Container for the necessary parameters to execute the DeleteClusterParameterGroup operation
        ///          on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteClusterParameterGroup(DeleteClusterParameterGroupRequest deleteClusterParameterGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteClusterParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterParameterGroup.</param>
        DeleteClusterParameterGroupResponse EndDeleteClusterParameterGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteClusterSecurityGroup

        /// <summary>
        /// <para> Deletes an Amazon Redshift security group. </para> <para><b>NOTE:</b>You cannot delete a security group that is associated with any
        /// clusters. You cannot delete the default security group.</para> <para> For information about managing security groups, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html" >Amazon Redshift Cluster Security Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="deleteClusterSecurityGroupRequest">Container for the necessary parameters to execute the DeleteClusterSecurityGroup service
        ///          method on AmazonRedshift.</param>
        /// 
        /// <exception cref="InvalidClusterSecurityGroupStateException"/>
        /// <exception cref="ClusterSecurityGroupNotFoundException"/>
        DeleteClusterSecurityGroupResponse DeleteClusterSecurityGroup(DeleteClusterSecurityGroupRequest deleteClusterSecurityGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSecurityGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteClusterSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteClusterSecurityGroupRequest">Container for the necessary parameters to execute the DeleteClusterSecurityGroup operation
        ///          on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteClusterSecurityGroup(DeleteClusterSecurityGroupRequest deleteClusterSecurityGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteClusterSecurityGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteClusterSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterSecurityGroup.</param>
        DeleteClusterSecurityGroupResponse EndDeleteClusterSecurityGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteClusterSnapshot

        /// <summary>
        /// <para> Deletes the specified manual snapshot. The snapshot must be in the "available" state, with no other users authorized to access the
        /// snapshot. </para> <para> Unlike automated snapshots, manual snapshots are retained even after you delete your cluster. Amazon Redshift does
        /// not delete your manual snapshots. You must delete manual snapshot explicitly to avoid getting charged. If other accounts are authorized to
        /// access the snapshot, you must revoke all of the authorizations before you can delete the snapshot. </para>
        /// </summary>
        /// 
        /// <param name="deleteClusterSnapshotRequest">Container for the necessary parameters to execute the DeleteClusterSnapshot service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DeleteClusterSnapshot service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterSnapshotNotFoundException"/>
        /// <exception cref="InvalidClusterSnapshotStateException"/>
        DeleteClusterSnapshotResponse DeleteClusterSnapshot(DeleteClusterSnapshotRequest deleteClusterSnapshotRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteClusterSnapshot"/>
        /// </summary>
        /// 
        /// <param name="deleteClusterSnapshotRequest">Container for the necessary parameters to execute the DeleteClusterSnapshot operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteClusterSnapshot operation.</returns>
        IAsyncResult BeginDeleteClusterSnapshot(DeleteClusterSnapshotRequest deleteClusterSnapshotRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteClusterSnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterSnapshot.</param>
        /// 
        /// <returns>Returns a Snapshot from AmazonRedshift.</returns>
        DeleteClusterSnapshotResponse EndDeleteClusterSnapshot(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteClusterSubnetGroup

        /// <summary>
        /// <para> Deletes the specified cluster subnet group. </para>
        /// </summary>
        /// 
        /// <param name="deleteClusterSubnetGroupRequest">Container for the necessary parameters to execute the DeleteClusterSubnetGroup service method
        ///          on AmazonRedshift.</param>
        /// 
        /// <exception cref="InvalidClusterSubnetStateException"/>
        /// <exception cref="ClusterSubnetGroupNotFoundException"/>
        /// <exception cref="InvalidClusterSubnetGroupStateException"/>
        DeleteClusterSubnetGroupResponse DeleteClusterSubnetGroup(DeleteClusterSubnetGroupRequest deleteClusterSubnetGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteClusterSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteClusterSubnetGroupRequest">Container for the necessary parameters to execute the DeleteClusterSubnetGroup operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteClusterSubnetGroup(DeleteClusterSubnetGroupRequest deleteClusterSubnetGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteClusterSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterSubnetGroup.</param>
        DeleteClusterSubnetGroupResponse EndDeleteClusterSubnetGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteEventSubscription

        /// <summary>
        /// <para> Deletes an Amazon Redshift event notification subscription. </para>
        /// </summary>
        /// 
        /// <param name="deleteEventSubscriptionRequest">Container for the necessary parameters to execute the DeleteEventSubscription service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <exception cref="SubscriptionNotFoundException"/>
        DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest deleteEventSubscriptionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteEventSubscription"/>
        /// </summary>
        /// 
        /// <param name="deleteEventSubscriptionRequest">Container for the necessary parameters to execute the DeleteEventSubscription operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteEventSubscription(DeleteEventSubscriptionRequest deleteEventSubscriptionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteEventSubscription"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventSubscription.</param>
        DeleteEventSubscriptionResponse EndDeleteEventSubscription(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteHsmClientCertificate

        /// <summary>
        /// <para>Deletes the specified HSM client certificate.</para>
        /// </summary>
        /// 
        /// <param name="deleteHsmClientCertificateRequest">Container for the necessary parameters to execute the DeleteHsmClientCertificate service
        ///          method on AmazonRedshift.</param>
        /// 
        /// <exception cref="InvalidHsmClientCertificateStateException"/>
        /// <exception cref="HsmClientCertificateNotFoundException"/>
        DeleteHsmClientCertificateResponse DeleteHsmClientCertificate(DeleteHsmClientCertificateRequest deleteHsmClientCertificateRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmClientCertificate operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteHsmClientCertificate"/>
        /// </summary>
        /// 
        /// <param name="deleteHsmClientCertificateRequest">Container for the necessary parameters to execute the DeleteHsmClientCertificate operation
        ///          on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteHsmClientCertificate(DeleteHsmClientCertificateRequest deleteHsmClientCertificateRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteHsmClientCertificate operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteHsmClientCertificate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHsmClientCertificate.</param>
        DeleteHsmClientCertificateResponse EndDeleteHsmClientCertificate(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteHsmConfiguration

        /// <summary>
        /// <para>Deletes the specified Amazon Redshift HSM configuration.</para>
        /// </summary>
        /// 
        /// <param name="deleteHsmConfigurationRequest">Container for the necessary parameters to execute the DeleteHsmConfiguration service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <exception cref="HsmConfigurationNotFoundException"/>
        /// <exception cref="InvalidHsmConfigurationStateException"/>
        DeleteHsmConfigurationResponse DeleteHsmConfiguration(DeleteHsmConfigurationRequest deleteHsmConfigurationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmConfiguration operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteHsmConfiguration"/>
        /// </summary>
        /// 
        /// <param name="deleteHsmConfigurationRequest">Container for the necessary parameters to execute the DeleteHsmConfiguration operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteHsmConfiguration(DeleteHsmConfigurationRequest deleteHsmConfigurationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteHsmConfiguration operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteHsmConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHsmConfiguration.</param>
        DeleteHsmConfigurationResponse EndDeleteHsmConfiguration(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeClusterParameterGroups

        /// <summary>
        /// <para> Returns a list of Amazon Redshift parameter groups, including parameter groups you created and the default parameter group. For each
        /// parameter group, the response includes the parameter group name, description, and parameter group family name. You can optionally specify a
        /// name to retrieve the description of a specific parameter group. </para> <para> For more information about managing parameter groups, go to
        /// <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html" >Amazon Redshift Parameter Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeClusterParameterGroupsRequest">Container for the necessary parameters to execute the DescribeClusterParameterGroups
        ///          service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterParameterGroupNotFoundException"/>
        DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest describeClusterParameterGroupsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameterGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusterParameterGroups"/>
        /// </summary>
        /// 
        /// <param name="describeClusterParameterGroupsRequest">Container for the necessary parameters to execute the DescribeClusterParameterGroups
        ///          operation on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeClusterParameterGroups operation.</returns>
        IAsyncResult BeginDescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest describeClusterParameterGroupsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeClusterParameterGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusterParameterGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterParameterGroups.</param>
        /// 
        /// <returns>Returns a DescribeClusterParameterGroupsResult from AmazonRedshift.</returns>
        DescribeClusterParameterGroupsResponse EndDescribeClusterParameterGroups(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns a list of Amazon Redshift parameter groups, including parameter groups you created and the default parameter group. For each
        /// parameter group, the response includes the parameter group name, description, and parameter group family name. You can optionally specify a
        /// name to retrieve the description of a specific parameter group. </para> <para> For more information about managing parameter groups, go to
        /// <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html" >Amazon Redshift Parameter Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterParameterGroupNotFoundException"/>
        DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups();
        
        #endregion
        
    

        #region DescribeClusterParameters

        /// <summary>
        /// <para> Returns a detailed list of parameters contained within the specified Amazon Redshift parameter group. For each parameter the response
        /// includes information such as parameter name, description, data type, value, whether the parameter value is modifiable, and so on. </para>
        /// <para>You can specify <i>source</i> filter to retrieve parameters of only specific type. For example, to retrieve parameters that were
        /// modified by a user action such as from ModifyClusterParameterGroup, you can specify <i>source</i> equal to <i>user</i> .</para> <para> For
        /// more information about managing parameter groups, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html" >Amazon Redshift Parameter Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeClusterParametersRequest">Container for the necessary parameters to execute the DescribeClusterParameters service
        ///          method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterParameters service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterParameterGroupNotFoundException"/>
        DescribeClusterParametersResponse DescribeClusterParameters(DescribeClusterParametersRequest describeClusterParametersRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusterParameters"/>
        /// </summary>
        /// 
        /// <param name="describeClusterParametersRequest">Container for the necessary parameters to execute the DescribeClusterParameters operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeClusterParameters operation.</returns>
        IAsyncResult BeginDescribeClusterParameters(DescribeClusterParametersRequest describeClusterParametersRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeClusterParameters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusterParameters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterParameters.</param>
        /// 
        /// <returns>Returns a DescribeClusterParametersResult from AmazonRedshift.</returns>
        DescribeClusterParametersResponse EndDescribeClusterParameters(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeClusterSecurityGroups

        /// <summary>
        /// <para> Returns information about Amazon Redshift security groups. If the name of a security group is specified, the response will contain
        /// only information about only that security group. </para> <para> For information about managing security groups, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html" >Amazon Redshift Cluster Security Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeClusterSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeClusterSecurityGroups
        ///          service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterSecurityGroupNotFoundException"/>
        DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest describeClusterSecurityGroupsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSecurityGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusterSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="describeClusterSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeClusterSecurityGroups
        ///          operation on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeClusterSecurityGroups operation.</returns>
        IAsyncResult BeginDescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest describeClusterSecurityGroupsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeClusterSecurityGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusterSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterSecurityGroups.</param>
        /// 
        /// <returns>Returns a DescribeClusterSecurityGroupsResult from AmazonRedshift.</returns>
        DescribeClusterSecurityGroupsResponse EndDescribeClusterSecurityGroups(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns information about Amazon Redshift security groups. If the name of a security group is specified, the response will contain
        /// only information about only that security group. </para> <para> For information about managing security groups, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html" >Amazon Redshift Cluster Security Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterSecurityGroupNotFoundException"/>
        DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups();
        
        #endregion
        
    

        #region DescribeClusterSnapshots

        /// <summary>
        /// <para> Returns one or more snapshot objects, which contain metadata about your cluster snapshots. By default, this operation returns
        /// information about all snapshots of all clusters that are owned by you AWS customer account. No information is returned for snapshots owned
        /// by inactive AWS customer accounts. </para>
        /// </summary>
        /// 
        /// <param name="describeClusterSnapshotsRequest">Container for the necessary parameters to execute the DescribeClusterSnapshots service method
        ///          on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterSnapshotNotFoundException"/>
        DescribeClusterSnapshotsResponse DescribeClusterSnapshots(DescribeClusterSnapshotsRequest describeClusterSnapshotsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSnapshots operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusterSnapshots"/>
        /// </summary>
        /// 
        /// <param name="describeClusterSnapshotsRequest">Container for the necessary parameters to execute the DescribeClusterSnapshots operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeClusterSnapshots operation.</returns>
        IAsyncResult BeginDescribeClusterSnapshots(DescribeClusterSnapshotsRequest describeClusterSnapshotsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeClusterSnapshots operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusterSnapshots"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterSnapshots.</param>
        /// 
        /// <returns>Returns a DescribeClusterSnapshotsResult from AmazonRedshift.</returns>
        DescribeClusterSnapshotsResponse EndDescribeClusterSnapshots(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns one or more snapshot objects, which contain metadata about your cluster snapshots. By default, this operation returns
        /// information about all snapshots of all clusters that are owned by you AWS customer account. No information is returned for snapshots owned
        /// by inactive AWS customer accounts. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterSnapshotNotFoundException"/>
        DescribeClusterSnapshotsResponse DescribeClusterSnapshots();
        
        #endregion
        
    

        #region DescribeClusterSubnetGroups

        /// <summary>
        /// <para> Returns one or more cluster subnet group objects, which contain metadata about your cluster subnet groups. By default, this
        /// operation returns information about all cluster subnet groups that are defined in you AWS account. </para>
        /// </summary>
        /// 
        /// <param name="describeClusterSubnetGroupsRequest">Container for the necessary parameters to execute the DescribeClusterSubnetGroups service
        ///          method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterSubnetGroupNotFoundException"/>
        DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest describeClusterSubnetGroupsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSubnetGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusterSubnetGroups"/>
        /// </summary>
        /// 
        /// <param name="describeClusterSubnetGroupsRequest">Container for the necessary parameters to execute the DescribeClusterSubnetGroups operation
        ///          on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeClusterSubnetGroups operation.</returns>
        IAsyncResult BeginDescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest describeClusterSubnetGroupsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeClusterSubnetGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusterSubnetGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterSubnetGroups.</param>
        /// 
        /// <returns>Returns a DescribeClusterSubnetGroupsResult from AmazonRedshift.</returns>
        DescribeClusterSubnetGroupsResponse EndDescribeClusterSubnetGroups(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns one or more cluster subnet group objects, which contain metadata about your cluster subnet groups. By default, this
        /// operation returns information about all cluster subnet groups that are defined in you AWS account. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterSubnetGroupNotFoundException"/>
        DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups();
        
        #endregion
        
    

        #region DescribeClusterVersions

        /// <summary>
        /// <para> Returns descriptions of the available Amazon Redshift cluster versions. You can call this operation even before creating any
        /// clusters to learn more about the Amazon Redshift versions. For more information about managing clusters, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html" >Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> </para>
        /// </summary>
        /// 
        /// <param name="describeClusterVersionsRequest">Container for the necessary parameters to execute the DescribeClusterVersions service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by AmazonRedshift.</returns>
        /// 
        DescribeClusterVersionsResponse DescribeClusterVersions(DescribeClusterVersionsRequest describeClusterVersionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterVersions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusterVersions"/>
        /// </summary>
        /// 
        /// <param name="describeClusterVersionsRequest">Container for the necessary parameters to execute the DescribeClusterVersions operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeClusterVersions operation.</returns>
        IAsyncResult BeginDescribeClusterVersions(DescribeClusterVersionsRequest describeClusterVersionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeClusterVersions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusterVersions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterVersions.</param>
        /// 
        /// <returns>Returns a DescribeClusterVersionsResult from AmazonRedshift.</returns>
        DescribeClusterVersionsResponse EndDescribeClusterVersions(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns descriptions of the available Amazon Redshift cluster versions. You can call this operation even before creating any
        /// clusters to learn more about the Amazon Redshift versions. For more information about managing clusters, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html" >Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by AmazonRedshift.</returns>
        /// 
        DescribeClusterVersionsResponse DescribeClusterVersions();
        
        #endregion
        
    

        #region DescribeClusters

        /// <summary>
        /// <para> Returns properties of provisioned clusters including general cluster properties, cluster database properties, maintenance and backup
        /// properties, and security and access properties. This operation supports pagination. For more information about managing clusters, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html" >Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeClustersRequest">Container for the necessary parameters to execute the DescribeClusters service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterNotFoundException"/>
        DescribeClustersResponse DescribeClusters(DescribeClustersRequest describeClustersRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusters"/>
        /// </summary>
        /// 
        /// <param name="describeClustersRequest">Container for the necessary parameters to execute the DescribeClusters operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusters
        ///         operation.</returns>
        IAsyncResult BeginDescribeClusters(DescribeClustersRequest describeClustersRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeClusters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusters.</param>
        /// 
        /// <returns>Returns a DescribeClustersResult from AmazonRedshift.</returns>
        DescribeClustersResponse EndDescribeClusters(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns properties of provisioned clusters including general cluster properties, cluster database properties, maintenance and backup
        /// properties, and security and access properties. This operation supports pagination. For more information about managing clusters, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html" >Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterNotFoundException"/>
        DescribeClustersResponse DescribeClusters();
        
        #endregion
        
    

        #region DescribeDefaultClusterParameters

        /// <summary>
        /// <para> Returns a list of parameter settings for the specified parameter group family. </para> <para> For more information about managing
        /// parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html" >Amazon Redshift
        /// Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeDefaultClusterParametersRequest">Container for the necessary parameters to execute the DescribeDefaultClusterParameters
        ///          service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeDefaultClusterParameters service method, as returned by AmazonRedshift.</returns>
        /// 
        DescribeDefaultClusterParametersResponse DescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest describeDefaultClusterParametersRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultClusterParameters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeDefaultClusterParameters"/>
        /// </summary>
        /// 
        /// <param name="describeDefaultClusterParametersRequest">Container for the necessary parameters to execute the DescribeDefaultClusterParameters
        ///          operation on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDefaultClusterParameters operation.</returns>
        IAsyncResult BeginDescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest describeDefaultClusterParametersRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDefaultClusterParameters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeDefaultClusterParameters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDefaultClusterParameters.</param>
        /// 
        /// <returns>Returns a DefaultClusterParameters from AmazonRedshift.</returns>
        DescribeDefaultClusterParametersResponse EndDescribeDefaultClusterParameters(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeEventCategories

        /// <summary>
        /// <para>Displays a list of event categories for all event source types, or for a specified source type. For a list of the event categories and
        /// source types, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html" >Amazon Redshift Event
        /// Notifications</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeEventCategoriesRequest">Container for the necessary parameters to execute the DescribeEventCategories service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by AmazonRedshift.</returns>
        /// 
        DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest describeEventCategoriesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeEventCategories"/>
        /// </summary>
        /// 
        /// <param name="describeEventCategoriesRequest">Container for the necessary parameters to execute the DescribeEventCategories operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeEventCategories operation.</returns>
        IAsyncResult BeginDescribeEventCategories(DescribeEventCategoriesRequest describeEventCategoriesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEventCategories operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeEventCategories"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventCategories.</param>
        /// 
        /// <returns>Returns a DescribeEventCategoriesResult from AmazonRedshift.</returns>
        DescribeEventCategoriesResponse EndDescribeEventCategories(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Displays a list of event categories for all event source types, or for a specified source type. For a list of the event categories and
        /// source types, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html" >Amazon Redshift Event
        /// Notifications</a> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by AmazonRedshift.</returns>
        /// 
        DescribeEventCategoriesResponse DescribeEventCategories();
        
        #endregion
        
    

        #region DescribeEventSubscriptions

        /// <summary>
        /// <para> Lists descriptions of all the Amazon Redshift event notifications subscription for a customer account. If you specify a subscription
        /// name, lists the description for that subscription. </para>
        /// </summary>
        /// 
        /// <param name="describeEventSubscriptionsRequest">Container for the necessary parameters to execute the DescribeEventSubscriptions service
        ///          method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="SubscriptionNotFoundException"/>
        DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest describeEventSubscriptionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeEventSubscriptions"/>
        /// </summary>
        /// 
        /// <param name="describeEventSubscriptionsRequest">Container for the necessary parameters to execute the DescribeEventSubscriptions operation
        ///          on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeEventSubscriptions operation.</returns>
        IAsyncResult BeginDescribeEventSubscriptions(DescribeEventSubscriptionsRequest describeEventSubscriptionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEventSubscriptions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeEventSubscriptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventSubscriptions.</param>
        /// 
        /// <returns>Returns a DescribeEventSubscriptionsResult from AmazonRedshift.</returns>
        DescribeEventSubscriptionsResponse EndDescribeEventSubscriptions(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Lists descriptions of all the Amazon Redshift event notifications subscription for a customer account. If you specify a subscription
        /// name, lists the description for that subscription. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="SubscriptionNotFoundException"/>
        DescribeEventSubscriptionsResponse DescribeEventSubscriptions();
        
        #endregion
        
    

        #region DescribeEvents

        /// <summary>
        /// <para> Returns events related to clusters, security groups, snapshots, and parameter groups for the past 14 days. Events specific to a
        /// particular cluster, security group, snapshot or parameter group can be obtained by providing the name as a parameter. By default, the past
        /// hour of events are returned. </para>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonRedshift.</returns>
        /// 
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest describeEventsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeEvents"/>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        IAsyncResult BeginDescribeEvents(DescribeEventsRequest describeEventsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeEvents"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a DescribeEventsResult from AmazonRedshift.</returns>
        DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns events related to clusters, security groups, snapshots, and parameter groups for the past 14 days. Events specific to a
        /// particular cluster, security group, snapshot or parameter group can be obtained by providing the name as a parameter. By default, the past
        /// hour of events are returned. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonRedshift.</returns>
        /// 
        DescribeEventsResponse DescribeEvents();
        
        #endregion
        
    

        #region DescribeHsmClientCertificates

        /// <summary>
        /// <para>Returns information about the specified HSM client certificate. If no certificate ID is specified, returns information about all the
        /// HSM certificates owned by your AWS customer account.</para>
        /// </summary>
        /// 
        /// <param name="describeHsmClientCertificatesRequest">Container for the necessary parameters to execute the DescribeHsmClientCertificates
        ///          service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="HsmClientCertificateNotFoundException"/>
        DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest describeHsmClientCertificatesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmClientCertificates operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeHsmClientCertificates"/>
        /// </summary>
        /// 
        /// <param name="describeHsmClientCertificatesRequest">Container for the necessary parameters to execute the DescribeHsmClientCertificates
        ///          operation on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeHsmClientCertificates operation.</returns>
        IAsyncResult BeginDescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest describeHsmClientCertificatesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeHsmClientCertificates operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeHsmClientCertificates"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHsmClientCertificates.</param>
        /// 
        /// <returns>Returns a DescribeHsmClientCertificatesResult from AmazonRedshift.</returns>
        DescribeHsmClientCertificatesResponse EndDescribeHsmClientCertificates(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns information about the specified HSM client certificate. If no certificate ID is specified, returns information about all the
        /// HSM certificates owned by your AWS customer account.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="HsmClientCertificateNotFoundException"/>
        DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates();
        
        #endregion
        
    

        #region DescribeHsmConfigurations

        /// <summary>
        /// <para>Returns information about the specified Amazon Redshift HSM configuration. If no configuration ID is specified, returns information
        /// about all the HSM configurations owned by your AWS customer account.</para>
        /// </summary>
        /// 
        /// <param name="describeHsmConfigurationsRequest">Container for the necessary parameters to execute the DescribeHsmConfigurations service
        ///          method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="HsmConfigurationNotFoundException"/>
        DescribeHsmConfigurationsResponse DescribeHsmConfigurations(DescribeHsmConfigurationsRequest describeHsmConfigurationsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmConfigurations operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeHsmConfigurations"/>
        /// </summary>
        /// 
        /// <param name="describeHsmConfigurationsRequest">Container for the necessary parameters to execute the DescribeHsmConfigurations operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeHsmConfigurations operation.</returns>
        IAsyncResult BeginDescribeHsmConfigurations(DescribeHsmConfigurationsRequest describeHsmConfigurationsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeHsmConfigurations operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeHsmConfigurations"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHsmConfigurations.</param>
        /// 
        /// <returns>Returns a DescribeHsmConfigurationsResult from AmazonRedshift.</returns>
        DescribeHsmConfigurationsResponse EndDescribeHsmConfigurations(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns information about the specified Amazon Redshift HSM configuration. If no configuration ID is specified, returns information
        /// about all the HSM configurations owned by your AWS customer account.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="HsmConfigurationNotFoundException"/>
        DescribeHsmConfigurationsResponse DescribeHsmConfigurations();
        
        #endregion
        
    

        #region DescribeLoggingStatus

        /// <summary>
        /// <para>Describes whether information, such as queries and connection attempts, is being logged for the specified Amazon Redshift
        /// cluster.</para>
        /// </summary>
        /// 
        /// <param name="describeLoggingStatusRequest">Container for the necessary parameters to execute the DescribeLoggingStatus service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeLoggingStatus service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterNotFoundException"/>
        DescribeLoggingStatusResponse DescribeLoggingStatus(DescribeLoggingStatusRequest describeLoggingStatusRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoggingStatus operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeLoggingStatus"/>
        /// </summary>
        /// 
        /// <param name="describeLoggingStatusRequest">Container for the necessary parameters to execute the DescribeLoggingStatus operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeLoggingStatus operation.</returns>
        IAsyncResult BeginDescribeLoggingStatus(DescribeLoggingStatusRequest describeLoggingStatusRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeLoggingStatus operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeLoggingStatus"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoggingStatus.</param>
        /// 
        /// <returns>Returns a DescribeLoggingStatusResult from AmazonRedshift.</returns>
        DescribeLoggingStatusResponse EndDescribeLoggingStatus(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeOrderableClusterOptions

        /// <summary>
        /// <para> Returns a list of orderable cluster options. Before you create a new cluster you can use this operation to find what options are
        /// available, such as the EC2 Availability Zones (AZ) in the specific AWS region that you can specify, and the node types you can request. The
        /// node types differ by available storage, memory, CPU and price. With the cost involved you might want to obtain a list of cluster options in
        /// the specific region and specify values when creating a cluster. For more information about managing clusters, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html" >Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> </para>
        /// </summary>
        /// 
        /// <param name="describeOrderableClusterOptionsRequest">Container for the necessary parameters to execute the DescribeOrderableClusterOptions
        ///          service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by AmazonRedshift.</returns>
        /// 
        DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest describeOrderableClusterOptionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableClusterOptions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeOrderableClusterOptions"/>
        /// </summary>
        /// 
        /// <param name="describeOrderableClusterOptionsRequest">Container for the necessary parameters to execute the DescribeOrderableClusterOptions
        ///          operation on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeOrderableClusterOptions operation.</returns>
        IAsyncResult BeginDescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest describeOrderableClusterOptionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeOrderableClusterOptions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeOrderableClusterOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrderableClusterOptions.</param>
        /// 
        /// <returns>Returns a DescribeOrderableClusterOptionsResult from AmazonRedshift.</returns>
        DescribeOrderableClusterOptionsResponse EndDescribeOrderableClusterOptions(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns a list of orderable cluster options. Before you create a new cluster you can use this operation to find what options are
        /// available, such as the EC2 Availability Zones (AZ) in the specific AWS region that you can specify, and the node types you can request. The
        /// node types differ by available storage, memory, CPU and price. With the cost involved you might want to obtain a list of cluster options in
        /// the specific region and specify values when creating a cluster. For more information about managing clusters, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html" >Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by AmazonRedshift.</returns>
        /// 
        DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions();
        
        #endregion
        
    

        #region DescribeReservedNodeOfferings

        /// <summary>
        /// <para> Returns a list of the available reserved node offerings by Amazon Redshift with their descriptions including the node type, the fixed
        /// and recurring costs of reserving the node and duration the node will be reserved for you. These descriptions help you determine which
        /// reserve node offering you want to purchase. You then use the unique offering ID in you call to PurchaseReservedNodeOffering to reserve one
        /// or more nodes for your Amazon Redshift cluster. </para> <para> For more information about managing parameter groups, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html" >Purchasing Reserved Nodes</a> in the <i>Amazon
        /// Redshift Management Guide</i> .
        /// 
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeReservedNodeOfferingsRequest">Container for the necessary parameters to execute the DescribeReservedNodeOfferings
        ///          service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ReservedNodeOfferingNotFoundException"/>
        DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest describeReservedNodeOfferingsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodeOfferings operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeReservedNodeOfferings"/>
        /// </summary>
        /// 
        /// <param name="describeReservedNodeOfferingsRequest">Container for the necessary parameters to execute the DescribeReservedNodeOfferings
        ///          operation on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReservedNodeOfferings operation.</returns>
        IAsyncResult BeginDescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest describeReservedNodeOfferingsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReservedNodeOfferings operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeReservedNodeOfferings"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedNodeOfferings.</param>
        /// 
        /// <returns>Returns a DescribeReservedNodeOfferingsResult from AmazonRedshift.</returns>
        DescribeReservedNodeOfferingsResponse EndDescribeReservedNodeOfferings(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns a list of the available reserved node offerings by Amazon Redshift with their descriptions including the node type, the fixed
        /// and recurring costs of reserving the node and duration the node will be reserved for you. These descriptions help you determine which
        /// reserve node offering you want to purchase. You then use the unique offering ID in you call to PurchaseReservedNodeOffering to reserve one
        /// or more nodes for your Amazon Redshift cluster. </para> <para> For more information about managing parameter groups, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html" >Purchasing Reserved Nodes</a> in the <i>Amazon
        /// Redshift Management Guide</i> .
        /// 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ReservedNodeOfferingNotFoundException"/>
        DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings();
        
        #endregion
        
    

        #region DescribeReservedNodes

        /// <summary>
        /// <para> Returns the descriptions of the reserved nodes. </para>
        /// </summary>
        /// 
        /// <param name="describeReservedNodesRequest">Container for the necessary parameters to execute the DescribeReservedNodes service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ReservedNodeNotFoundException"/>
        DescribeReservedNodesResponse DescribeReservedNodes(DescribeReservedNodesRequest describeReservedNodesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodes operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeReservedNodes"/>
        /// </summary>
        /// 
        /// <param name="describeReservedNodesRequest">Container for the necessary parameters to execute the DescribeReservedNodes operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReservedNodes operation.</returns>
        IAsyncResult BeginDescribeReservedNodes(DescribeReservedNodesRequest describeReservedNodesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReservedNodes operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeReservedNodes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedNodes.</param>
        /// 
        /// <returns>Returns a DescribeReservedNodesResult from AmazonRedshift.</returns>
        DescribeReservedNodesResponse EndDescribeReservedNodes(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns the descriptions of the reserved nodes. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ReservedNodeNotFoundException"/>
        DescribeReservedNodesResponse DescribeReservedNodes();
        
        #endregion
        
    

        #region DescribeResize

        /// <summary>
        /// <para> Returns information about the last resize operation for the specified cluster. If no resize operation has ever been initiated for the
        /// specified cluster, a <c>HTTP 404</c> error is returned. If a resize operation was initiated and completed, the status of the resize remains
        /// as <c>SUCCEEDED</c> until the next resize. </para> <para> A resize operation can be requested using ModifyCluster and specifying a different
        /// number or type of nodes for the cluster. </para>
        /// </summary>
        /// 
        /// <param name="describeResizeRequest">Container for the necessary parameters to execute the DescribeResize service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeResize service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterNotFoundException"/>
        /// <exception cref="ResizeNotFoundException"/>
        DescribeResizeResponse DescribeResize(DescribeResizeRequest describeResizeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResize operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeResize"/>
        /// </summary>
        /// 
        /// <param name="describeResizeRequest">Container for the necessary parameters to execute the DescribeResize operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResize
        ///         operation.</returns>
        IAsyncResult BeginDescribeResize(DescribeResizeRequest describeResizeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeResize operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeResize"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResize.</param>
        /// 
        /// <returns>Returns a DescribeResizeResult from AmazonRedshift.</returns>
        DescribeResizeResponse EndDescribeResize(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DisableLogging

        /// <summary>
        /// <para>Stops logging information, such as queries and connection attempts, for the specified Amazon Redshift cluster.</para>
        /// </summary>
        /// 
        /// <param name="disableLoggingRequest">Container for the necessary parameters to execute the DisableLogging service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DisableLogging service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ClusterNotFoundException"/>
        DisableLoggingResponse DisableLogging(DisableLoggingRequest disableLoggingRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableLogging operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DisableLogging"/>
        /// </summary>
        /// 
        /// <param name="disableLoggingRequest">Container for the necessary parameters to execute the DisableLogging operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableLogging
        ///         operation.</returns>
        IAsyncResult BeginDisableLogging(DisableLoggingRequest disableLoggingRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DisableLogging operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DisableLogging"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableLogging.</param>
        /// 
        /// <returns>Returns a DisableLoggingResult from AmazonRedshift.</returns>
        DisableLoggingResponse EndDisableLogging(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DisableSnapshotCopy

        /// <summary>
        /// <para>Disables the automatic copying of snapshots from one region to another region for a specified cluster.</para>
        /// </summary>
        /// 
        /// <param name="disableSnapshotCopyRequest">Container for the necessary parameters to execute the DisableSnapshotCopy service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DisableSnapshotCopy service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="SnapshotCopyAlreadyDisabledException"/>
        /// <exception cref="UnauthorizedOperationException"/>
        /// <exception cref="ClusterNotFoundException"/>
        DisableSnapshotCopyResponse DisableSnapshotCopy(DisableSnapshotCopyRequest disableSnapshotCopyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableSnapshotCopy operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DisableSnapshotCopy"/>
        /// </summary>
        /// 
        /// <param name="disableSnapshotCopyRequest">Container for the necessary parameters to execute the DisableSnapshotCopy operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDisableSnapshotCopy operation.</returns>
        IAsyncResult BeginDisableSnapshotCopy(DisableSnapshotCopyRequest disableSnapshotCopyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DisableSnapshotCopy operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DisableSnapshotCopy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableSnapshotCopy.</param>
        /// 
        /// <returns>Returns a Cluster from AmazonRedshift.</returns>
        DisableSnapshotCopyResponse EndDisableSnapshotCopy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region EnableLogging

        /// <summary>
        /// <para>Starts logging information, such as queries and connection attempts, for the specified Amazon Redshift cluster.</para>
        /// </summary>
        /// 
        /// <param name="enableLoggingRequest">Container for the necessary parameters to execute the EnableLogging service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the EnableLogging service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="InvalidS3KeyPrefixException"/>
        /// <exception cref="InvalidS3BucketNameException"/>
        /// <exception cref="BucketNotFoundException"/>
        /// <exception cref="ClusterNotFoundException"/>
        /// <exception cref="InsufficientS3BucketPolicyException"/>
        EnableLoggingResponse EnableLogging(EnableLoggingRequest enableLoggingRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableLogging operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.EnableLogging"/>
        /// </summary>
        /// 
        /// <param name="enableLoggingRequest">Container for the necessary parameters to execute the EnableLogging operation on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableLogging
        ///         operation.</returns>
        IAsyncResult BeginEnableLogging(EnableLoggingRequest enableLoggingRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the EnableLogging operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.EnableLogging"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableLogging.</param>
        /// 
        /// <returns>Returns a EnableLoggingResult from AmazonRedshift.</returns>
        EnableLoggingResponse EndEnableLogging(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region EnableSnapshotCopy

        /// <summary>
        /// <para>Enables the automatic copy of snapshots from one region to another region for a specified cluster.</para>
        /// </summary>
        /// 
        /// <param name="enableSnapshotCopyRequest">Container for the necessary parameters to execute the EnableSnapshotCopy service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the EnableSnapshotCopy service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="CopyToRegionDisabledException"/>
        /// <exception cref="UnauthorizedOperationException"/>
        /// <exception cref="InvalidClusterStateException"/>
        /// <exception cref="ClusterNotFoundException"/>
        /// <exception cref="IncompatibleOrderableOptionsException"/>
        /// <exception cref="SnapshotCopyAlreadyEnabledException"/>
        /// <exception cref="UnknownSnapshotCopyRegionException"/>
        EnableSnapshotCopyResponse EnableSnapshotCopy(EnableSnapshotCopyRequest enableSnapshotCopyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableSnapshotCopy operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.EnableSnapshotCopy"/>
        /// </summary>
        /// 
        /// <param name="enableSnapshotCopyRequest">Container for the necessary parameters to execute the EnableSnapshotCopy operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndEnableSnapshotCopy operation.</returns>
        IAsyncResult BeginEnableSnapshotCopy(EnableSnapshotCopyRequest enableSnapshotCopyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the EnableSnapshotCopy operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.EnableSnapshotCopy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableSnapshotCopy.</param>
        /// 
        /// <returns>Returns a Cluster from AmazonRedshift.</returns>
        EnableSnapshotCopyResponse EndEnableSnapshotCopy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ModifyCluster

        /// <summary>
        /// <para> Modifies the settings for a cluster. For example, you can add another security or parameter group, update the preferred maintenance
        /// window, or change the master user password. Resetting a cluster password or modifying the security groups associated with a cluster do not
        /// need a reboot. However, modifying parameter group requires a reboot for parameters to take effect. For more information about managing
        /// clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html" >Amazon Redshift Clusters</a> in the
        /// <i>Amazon Redshift Management Guide</i> </para> <para>You can also change node type and the number of nodes to scale up or down the cluster.
        /// When resizing a cluster, you must specify both the number of nodes and the node type even if one of the parameters does not change. If you
        /// specify the same number of nodes and node type that are already configured for the cluster, an error is returned.</para>
        /// </summary>
        /// 
        /// <param name="modifyClusterRequest">Container for the necessary parameters to execute the ModifyCluster service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ModifyCluster service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="InvalidClusterSecurityGroupStateException"/>
        /// <exception cref="HsmConfigurationNotFoundException"/>
        /// <exception cref="InsufficientClusterCapacityException"/>
        /// <exception cref="UnauthorizedOperationException"/>
        /// <exception cref="InvalidClusterStateException"/>
        /// <exception cref="NumberOfNodesQuotaExceededException"/>
        /// <exception cref="ClusterNotFoundException"/>
        /// <exception cref="UnsupportedOptionException"/>
        /// <exception cref="ClusterSecurityGroupNotFoundException"/>
        /// <exception cref="HsmClientCertificateNotFoundException"/>
        /// <exception cref="ClusterParameterGroupNotFoundException"/>
        ModifyClusterResponse ModifyCluster(ModifyClusterRequest modifyClusterRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.ModifyCluster"/>
        /// </summary>
        /// 
        /// <param name="modifyClusterRequest">Container for the necessary parameters to execute the ModifyCluster operation on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyCluster
        ///         operation.</returns>
        IAsyncResult BeginModifyCluster(ModifyClusterRequest modifyClusterRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.ModifyCluster"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCluster.</param>
        /// 
        /// <returns>Returns a Cluster from AmazonRedshift.</returns>
        ModifyClusterResponse EndModifyCluster(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ModifyClusterParameterGroup

        /// <summary>
        /// <para> Modifies the parameters of a parameter group. </para> <para> For more information about managing parameter groups, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html" >Amazon Redshift Parameter Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="modifyClusterParameterGroupRequest">Container for the necessary parameters to execute the ModifyClusterParameterGroup service
        ///          method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ModifyClusterParameterGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="InvalidClusterParameterGroupStateException"/>
        /// <exception cref="ClusterParameterGroupNotFoundException"/>
        ModifyClusterParameterGroupResponse ModifyClusterParameterGroup(ModifyClusterParameterGroupRequest modifyClusterParameterGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.ModifyClusterParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="modifyClusterParameterGroupRequest">Container for the necessary parameters to execute the ModifyClusterParameterGroup operation
        ///          on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyClusterParameterGroup operation.</returns>
        IAsyncResult BeginModifyClusterParameterGroup(ModifyClusterParameterGroupRequest modifyClusterParameterGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.ModifyClusterParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a ModifyClusterParameterGroupResult from AmazonRedshift.</returns>
        ModifyClusterParameterGroupResponse EndModifyClusterParameterGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ModifyClusterSubnetGroup

        /// <summary>
        /// <para> Modifies a cluster subnet group to include the specified list of VPC subnets. The operation replaces the existing list of subnets
        /// with the new list of subnets. </para>
        /// </summary>
        /// 
        /// <param name="modifyClusterSubnetGroupRequest">Container for the necessary parameters to execute the ModifyClusterSubnetGroup service method
        ///          on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ModifyClusterSubnetGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="SubnetAlreadyInUseException"/>
        /// <exception cref="InvalidSubnetException"/>
        /// <exception cref="UnauthorizedOperationException"/>
        /// <exception cref="ClusterSubnetQuotaExceededException"/>
        /// <exception cref="ClusterSubnetGroupNotFoundException"/>
        ModifyClusterSubnetGroupResponse ModifyClusterSubnetGroup(ModifyClusterSubnetGroupRequest modifyClusterSubnetGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.ModifyClusterSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="modifyClusterSubnetGroupRequest">Container for the necessary parameters to execute the ModifyClusterSubnetGroup operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyClusterSubnetGroup operation.</returns>
        IAsyncResult BeginModifyClusterSubnetGroup(ModifyClusterSubnetGroupRequest modifyClusterSubnetGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.ModifyClusterSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyClusterSubnetGroup.</param>
        /// 
        /// <returns>Returns a ClusterSubnetGroup from AmazonRedshift.</returns>
        ModifyClusterSubnetGroupResponse EndModifyClusterSubnetGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ModifyEventSubscription

        /// <summary>
        /// <para> Modifies an existing Amazon Redshift event notification subscription. </para>
        /// </summary>
        /// 
        /// <param name="modifyEventSubscriptionRequest">Container for the necessary parameters to execute the ModifyEventSubscription service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="SubscriptionCategoryNotFoundException"/>
        /// <exception cref="SubscriptionEventIdNotFoundException"/>
        /// <exception cref="SubscriptionSeverityNotFoundException"/>
        /// <exception cref="SourceNotFoundException"/>
        /// <exception cref="SNSNoAuthorizationException"/>
        /// <exception cref="SNSTopicArnNotFoundException"/>
        /// <exception cref="SubscriptionNotFoundException"/>
        /// <exception cref="SNSInvalidTopicException"/>
        ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest modifyEventSubscriptionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.ModifyEventSubscription"/>
        /// </summary>
        /// 
        /// <param name="modifyEventSubscriptionRequest">Container for the necessary parameters to execute the ModifyEventSubscription operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyEventSubscription operation.</returns>
        IAsyncResult BeginModifyEventSubscription(ModifyEventSubscriptionRequest modifyEventSubscriptionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.ModifyEventSubscription"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyEventSubscription.</param>
        /// 
        /// <returns>Returns a EventSubscription from AmazonRedshift.</returns>
        ModifyEventSubscriptionResponse EndModifyEventSubscription(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ModifySnapshotCopyRetentionPeriod

        /// <summary>
        /// <para> Modifies the number of days to retain automated snapshots in the destination region after they are copied from the source region.
        /// </para>
        /// </summary>
        /// 
        /// <param name="modifySnapshotCopyRetentionPeriodRequest">Container for the necessary parameters to execute the
        ///          ModifySnapshotCopyRetentionPeriod service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ModifySnapshotCopyRetentionPeriod service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="SnapshotCopyDisabledException"/>
        /// <exception cref="UnauthorizedOperationException"/>
        /// <exception cref="ClusterNotFoundException"/>
        ModifySnapshotCopyRetentionPeriodResponse ModifySnapshotCopyRetentionPeriod(ModifySnapshotCopyRetentionPeriodRequest modifySnapshotCopyRetentionPeriodRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotCopyRetentionPeriod operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.ModifySnapshotCopyRetentionPeriod"/>
        /// </summary>
        /// 
        /// <param name="modifySnapshotCopyRetentionPeriodRequest">Container for the necessary parameters to execute the
        ///          ModifySnapshotCopyRetentionPeriod operation on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifySnapshotCopyRetentionPeriod operation.</returns>
        IAsyncResult BeginModifySnapshotCopyRetentionPeriod(ModifySnapshotCopyRetentionPeriodRequest modifySnapshotCopyRetentionPeriodRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ModifySnapshotCopyRetentionPeriod operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.ModifySnapshotCopyRetentionPeriod"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySnapshotCopyRetentionPeriod.</param>
        /// 
        /// <returns>Returns a Cluster from AmazonRedshift.</returns>
        ModifySnapshotCopyRetentionPeriodResponse EndModifySnapshotCopyRetentionPeriod(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region PurchaseReservedNodeOffering

        /// <summary>
        /// <para> Allows you to purchase reserved nodes. Amazon Redshift offers a predefined set of reserved node offerings. You can purchase one of
        /// the offerings. You can call the DescribeReservedNodeOfferings API to obtain the available reserved node offerings. You can call this API by
        /// providing a specific reserved node offering and the number of nodes you want to reserve. </para> <para> For more information about managing
        /// parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html" >Purchasing Reserved
        /// Nodes</a> in the <i>Amazon Redshift Management Guide</i> .
        /// 
        /// </para>
        /// </summary>
        /// 
        /// <param name="purchaseReservedNodeOfferingRequest">Container for the necessary parameters to execute the PurchaseReservedNodeOffering service
        ///          method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the PurchaseReservedNodeOffering service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="ReservedNodeAlreadyExistsException"/>
        /// <exception cref="ReservedNodeOfferingNotFoundException"/>
        /// <exception cref="ReservedNodeQuotaExceededException"/>
        PurchaseReservedNodeOfferingResponse PurchaseReservedNodeOffering(PurchaseReservedNodeOfferingRequest purchaseReservedNodeOfferingRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedNodeOffering operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.PurchaseReservedNodeOffering"/>
        /// </summary>
        /// 
        /// <param name="purchaseReservedNodeOfferingRequest">Container for the necessary parameters to execute the PurchaseReservedNodeOffering
        ///          operation on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndPurchaseReservedNodeOffering operation.</returns>
        IAsyncResult BeginPurchaseReservedNodeOffering(PurchaseReservedNodeOfferingRequest purchaseReservedNodeOfferingRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PurchaseReservedNodeOffering operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.PurchaseReservedNodeOffering"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedNodeOffering.</param>
        /// 
        /// <returns>Returns a ReservedNode from AmazonRedshift.</returns>
        PurchaseReservedNodeOfferingResponse EndPurchaseReservedNodeOffering(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RebootCluster

        /// <summary>
        /// <para> Reboots a cluster. This action is taken as soon as possible. It results in a momentary outage to the cluster, during which the
        /// cluster status is set to <c>rebooting</c> . A cluster event is created when the reboot is completed. Any pending cluster modifications (see
        /// ModifyCluster) are applied at this reboot. For more information about managing clusters, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html" >Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> </para>
        /// </summary>
        /// 
        /// <param name="rebootClusterRequest">Container for the necessary parameters to execute the RebootCluster service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the RebootCluster service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="InvalidClusterStateException"/>
        /// <exception cref="ClusterNotFoundException"/>
        RebootClusterResponse RebootCluster(RebootClusterRequest rebootClusterRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RebootCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.RebootCluster"/>
        /// </summary>
        /// 
        /// <param name="rebootClusterRequest">Container for the necessary parameters to execute the RebootCluster operation on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootCluster
        ///         operation.</returns>
        IAsyncResult BeginRebootCluster(RebootClusterRequest rebootClusterRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RebootCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.RebootCluster"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootCluster.</param>
        /// 
        /// <returns>Returns a Cluster from AmazonRedshift.</returns>
        RebootClusterResponse EndRebootCluster(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ResetClusterParameterGroup

        /// <summary>
        /// <para> Sets one or more parameters of the specified parameter group to their default values and sets the source values of the parameters to
        /// "engine-default". To reset the entire parameter group specify the <i>ResetAllParameters</i> parameter. For parameter changes to take effect
        /// you must reboot any associated clusters. </para>
        /// </summary>
        /// 
        /// <param name="resetClusterParameterGroupRequest">Container for the necessary parameters to execute the ResetClusterParameterGroup service
        ///          method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ResetClusterParameterGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="InvalidClusterParameterGroupStateException"/>
        /// <exception cref="ClusterParameterGroupNotFoundException"/>
        ResetClusterParameterGroupResponse ResetClusterParameterGroup(ResetClusterParameterGroupRequest resetClusterParameterGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.ResetClusterParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="resetClusterParameterGroupRequest">Container for the necessary parameters to execute the ResetClusterParameterGroup operation
        ///          on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndResetClusterParameterGroup operation.</returns>
        IAsyncResult BeginResetClusterParameterGroup(ResetClusterParameterGroupRequest resetClusterParameterGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ResetClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.ResetClusterParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a ResetClusterParameterGroupResult from AmazonRedshift.</returns>
        ResetClusterParameterGroupResponse EndResetClusterParameterGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RestoreFromClusterSnapshot

        /// <summary>
        /// <para> Creates a new cluster from a snapshot. Amazon Redshift creates the resulting cluster with the same configuration as the original
        /// cluster from which the snapshot was created, except that the new cluster is created with the default cluster security and parameter group.
        /// After Amazon Redshift creates the cluster you can use the ModifyCluster API to associate a different security group and different parameter
        /// group with the restored cluster. </para> <para> If a snapshot is taken of a cluster in VPC, you can restore it only in VPC. In this case,
        /// you must provide a cluster subnet group where you want the cluster restored. If snapshot is taken of a cluster outside VPC, then you can
        /// restore it only outside VPC.</para> <para> For more information about working with snapshots, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html" >Amazon Redshift Snapshots</a> in the <i>Amazon Redshift
        /// Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="restoreFromClusterSnapshotRequest">Container for the necessary parameters to execute the RestoreFromClusterSnapshot service
        ///          method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the RestoreFromClusterSnapshot service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="InvalidElasticIpException"/>
        /// <exception cref="InvalidSubnetException"/>
        /// <exception cref="HsmConfigurationNotFoundException"/>
        /// <exception cref="ClusterSubnetGroupNotFoundException"/>
        /// <exception cref="InvalidClusterSubnetGroupStateException"/>
        /// <exception cref="ClusterAlreadyExistsException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        /// <exception cref="InvalidClusterSnapshotStateException"/>
        /// <exception cref="AccessToSnapshotDeniedException"/>
        /// <exception cref="InvalidRestoreException"/>
        /// <exception cref="UnauthorizedOperationException"/>
        /// <exception cref="InsufficientClusterCapacityException"/>
        /// <exception cref="NumberOfNodesQuotaExceededException"/>
        /// <exception cref="NumberOfNodesPerClusterLimitExceededException"/>
        /// <exception cref="ClusterSnapshotNotFoundException"/>
        /// <exception cref="ClusterQuotaExceededException"/>
        /// <exception cref="HsmClientCertificateNotFoundException"/>
        RestoreFromClusterSnapshotResponse RestoreFromClusterSnapshot(RestoreFromClusterSnapshotRequest restoreFromClusterSnapshotRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreFromClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.RestoreFromClusterSnapshot"/>
        /// </summary>
        /// 
        /// <param name="restoreFromClusterSnapshotRequest">Container for the necessary parameters to execute the RestoreFromClusterSnapshot operation
        ///          on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRestoreFromClusterSnapshot operation.</returns>
        IAsyncResult BeginRestoreFromClusterSnapshot(RestoreFromClusterSnapshotRequest restoreFromClusterSnapshotRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RestoreFromClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.RestoreFromClusterSnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreFromClusterSnapshot.</param>
        /// 
        /// <returns>Returns a Cluster from AmazonRedshift.</returns>
        RestoreFromClusterSnapshotResponse EndRestoreFromClusterSnapshot(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RevokeClusterSecurityGroupIngress

        /// <summary>
        /// <para> Revokes an ingress rule in an Amazon Redshift security group for a previously authorized IP range or Amazon EC2 security group. To
        /// add an ingress rule, see AuthorizeClusterSecurityGroupIngress. For information about managing security groups, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html" >Amazon Redshift Cluster Security Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="revokeClusterSecurityGroupIngressRequest">Container for the necessary parameters to execute the
        ///          RevokeClusterSecurityGroupIngress service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the RevokeClusterSecurityGroupIngress service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="InvalidClusterSecurityGroupStateException"/>
        /// <exception cref="AuthorizationNotFoundException"/>
        /// <exception cref="ClusterSecurityGroupNotFoundException"/>
        RevokeClusterSecurityGroupIngressResponse RevokeClusterSecurityGroupIngress(RevokeClusterSecurityGroupIngressRequest revokeClusterSecurityGroupIngressRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeClusterSecurityGroupIngress operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.RevokeClusterSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="revokeClusterSecurityGroupIngressRequest">Container for the necessary parameters to execute the
        ///          RevokeClusterSecurityGroupIngress operation on AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRevokeClusterSecurityGroupIngress operation.</returns>
        IAsyncResult BeginRevokeClusterSecurityGroupIngress(RevokeClusterSecurityGroupIngressRequest revokeClusterSecurityGroupIngressRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RevokeClusterSecurityGroupIngress operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.RevokeClusterSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeClusterSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a ClusterSecurityGroup from AmazonRedshift.</returns>
        RevokeClusterSecurityGroupIngressResponse EndRevokeClusterSecurityGroupIngress(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RevokeSnapshotAccess

        /// <summary>
        /// <para> Removes the ability of the specified AWS customer account to restore the specified snapshot. If the account is currently restoring
        /// the snapshot, the restore will run to completion. </para> <para> For more information about working with snapshots, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html" >Amazon Redshift Snapshots</a> in the <i>Amazon Redshift
        /// Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="revokeSnapshotAccessRequest">Container for the necessary parameters to execute the RevokeSnapshotAccess service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the RevokeSnapshotAccess service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="AccessToSnapshotDeniedException"/>
        /// <exception cref="ClusterSnapshotNotFoundException"/>
        /// <exception cref="AuthorizationNotFoundException"/>
        RevokeSnapshotAccessResponse RevokeSnapshotAccess(RevokeSnapshotAccessRequest revokeSnapshotAccessRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSnapshotAccess operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.RevokeSnapshotAccess"/>
        /// </summary>
        /// 
        /// <param name="revokeSnapshotAccessRequest">Container for the necessary parameters to execute the RevokeSnapshotAccess operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRevokeSnapshotAccess operation.</returns>
        IAsyncResult BeginRevokeSnapshotAccess(RevokeSnapshotAccessRequest revokeSnapshotAccessRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RevokeSnapshotAccess operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.RevokeSnapshotAccess"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeSnapshotAccess.</param>
        /// 
        /// <returns>Returns a Snapshot from AmazonRedshift.</returns>
        RevokeSnapshotAccessResponse EndRevokeSnapshotAccess(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RotateEncryptionKey

        /// <summary>
        /// <para> Rotates the encryption keys for a cluster. </para>
        /// </summary>
        /// 
        /// <param name="rotateEncryptionKeyRequest">Container for the necessary parameters to execute the RotateEncryptionKey service method on
        ///          AmazonRedshift.</param>
        /// 
        /// <returns>The response from the RotateEncryptionKey service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="InvalidClusterStateException"/>
        /// <exception cref="ClusterNotFoundException"/>
        RotateEncryptionKeyResponse RotateEncryptionKey(RotateEncryptionKeyRequest rotateEncryptionKeyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RotateEncryptionKey operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.RotateEncryptionKey"/>
        /// </summary>
        /// 
        /// <param name="rotateEncryptionKeyRequest">Container for the necessary parameters to execute the RotateEncryptionKey operation on
        ///          AmazonRedshift.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRotateEncryptionKey operation.</returns>
        IAsyncResult BeginRotateEncryptionKey(RotateEncryptionKeyRequest rotateEncryptionKeyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RotateEncryptionKey operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.RotateEncryptionKey"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRotateEncryptionKey.</param>
        /// 
        /// <returns>Returns a Cluster from AmazonRedshift.</returns>
        RotateEncryptionKeyResponse EndRotateEncryptionKey(IAsyncResult asyncResult);
        
        #endregion
        
    
    }
}
    
