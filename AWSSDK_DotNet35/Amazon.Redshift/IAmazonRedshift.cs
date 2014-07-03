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


using System;

using Amazon.Redshift.Model;

namespace Amazon.Redshift
{
    /// <summary>
    /// Implementation for accessing Redshift
    ///
    /// Amazon Redshift        <b>Overview</b>        
    /// <para>
    ///             This is an interface reference for Amazon Redshift. It contains documentation
    /// for one of the            programming or command line interfaces you can use to manage
    /// Amazon Redshift clusters. Note            that Amazon Redshift is asynchronous, which
    /// means that some interfaces may require techniques,            such as polling or asynchronous
    /// callback handlers, to determine when a command has been            applied. In this
    /// reference, the parameter descriptions indicate whether a change is            applied
    /// immediately, on the next instance reboot, or during the next maintenance         
    ///   window. For a summary of the Amazon Redshift cluster management interfaces, go to
    /// <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/using-aws-sdk.html">Using
    /// the Amazon Redshift Management Interfaces            </a>.
    /// </para>
    ///         
    /// <para>
    ///             Amazon Redshift manages all the work of setting up, operating, and scaling
    /// a data warehouse:             provisioning capacity, monitoring and backing up the
    /// cluster, and applying patches and             upgrades to the Amazon Redshift engine.
    /// You can focus on using your data to acquire new             insights for your business
    /// and customers.        
    /// </para>
    ///         
    /// <para>
    /// If you are a first-time user of Amazon Redshift, we recommend that you begin by reading
    /// the            The <a href="http://docs.aws.amazon.com/redshift/latest/gsg/getting-started.html">Amazon
    /// Redshift Getting Started Guide</a>
    /// </para>
    ///         
    /// <para>
    /// If you are a database developer, the <a href="http://docs.aws.amazon.com/redshift/latest/dg/welcome.html">Amazon
    /// Redshift Database Developer Guide</a>            explains how to design, build, query,
    /// and maintain the databases that make up your            data warehouse. 
    /// </para>
    /// </summary>
    public partial interface IAmazonRedshift : IDisposable
    {

        
        #region  AuthorizeClusterSecurityGroupIngress


        /// <summary>
        /// Adds an inbound (ingress) rule to an Amazon Redshift security group. 
        ///                       Depending on whether the application accessing your cluster
        /// is running            on the Internet or an EC2 instance, you can            authorize
        /// inbound access to either a Classless Interdomain Routing (CIDR) IP address range 
        ///          or an EC2 security group.               You can add as many as 20 ingress
        /// rules to an Amazon Redshift security group.         
        /// 
        ///         <note>            The EC2 security group must be defined in the AWS region
        /// where the cluster resides.        </note>        
        /// <para>
        /// For an overview of CIDR blocks, see the Wikipedia article on               <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
        /// Inter-Domain Routing</a>.        
        /// </para>
        ///         
        /// <para>
        ///             You must also associate the security group with a cluster so that clients
        ///             running on these IP addresses or the EC2 instance are authorized to connect
        /// to the cluster.            For information about managing security groups, go to 
        ///           <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Working
        /// with Security Groups</a> in the             <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClusterSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the AuthorizeClusterSecurityGroupIngress service method, as returned by Redshift.</returns>
        /// <exception cref="AuthorizationAlreadyExistsException">
        /// The specified CIDR block or EC2 security group is already authorized for
        /// the specified cluster security group.
        /// </exception>
        /// <exception cref="AuthorizationQuotaExceededException">
        /// The authorization quota for the cluster security group has been reached.
        /// </exception>
        /// <exception cref="ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster
        /// security group.
        /// </exception>
        /// <exception cref="InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        AuthorizeClusterSecurityGroupIngressResponse AuthorizeClusterSecurityGroupIngress(AuthorizeClusterSecurityGroupIngressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeClusterSecurityGroupIngress operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClusterSecurityGroupIngress operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAuthorizeClusterSecurityGroupIngress
        ///         operation.</returns>
        IAsyncResult BeginAuthorizeClusterSecurityGroupIngress(AuthorizeClusterSecurityGroupIngressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeClusterSecurityGroupIngress operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeClusterSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a  AuthorizeClusterSecurityGroupIngressResult from Redshift.</returns>
        AuthorizeClusterSecurityGroupIngressResponse EndAuthorizeClusterSecurityGroupIngress(IAsyncResult asyncResult);

        #endregion
        
        #region  AuthorizeSnapshotAccess


        /// <summary>
        /// Authorizes the specified AWS customer account to restore the specified
        /// snapshot.        
        /// 
        ///         
        /// <para>
        /// For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSnapshotAccess service method.</param>
        /// 
        /// <returns>The response from the AuthorizeSnapshotAccess service method, as returned by Redshift.</returns>
        /// <exception cref="AuthorizationAlreadyExistsException">
        /// The specified CIDR block or EC2 security group is already authorized for
        /// the specified cluster security group.
        /// </exception>
        /// <exception cref="AuthorizationQuotaExceededException">
        /// The authorization quota for the cluster security group has been reached.
        /// </exception>
        /// <exception cref="ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        AuthorizeSnapshotAccessResponse AuthorizeSnapshotAccess(AuthorizeSnapshotAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSnapshotAccess operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSnapshotAccess operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAuthorizeSnapshotAccess
        ///         operation.</returns>
        IAsyncResult BeginAuthorizeSnapshotAccess(AuthorizeSnapshotAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeSnapshotAccess operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeSnapshotAccess.</param>
        /// 
        /// <returns>Returns a  AuthorizeSnapshotAccessResult from Redshift.</returns>
        AuthorizeSnapshotAccessResponse EndAuthorizeSnapshotAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  CopyClusterSnapshot


        /// <summary>
        /// Copies the specified automated cluster snapshot to a new manual cluster snapshot.
        ///         The source must be an automated snapshot and it must be in the available state.
        ///        
        /// 
        ///         
        /// <para>
        ///             When you delete a cluster, Amazon Redshift deletes any automated snapshots
        ///             of the cluster. Also, when the retention period of the snapshot expires,
        ///            Amazon Redshift automatically deletes it. If you want to keep an      
        ///       automated snapshot for a longer period, you can make a manual            copy
        /// of the snapshot. Manual snapshots are retained until you delete them.         
        /// </para>
        ///         
        /// <para>
        /// For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CopyClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing
        /// snapshot.
        /// </exception>
        /// <exception cref="ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster
        /// snapshots.
        /// </exception>
        /// <exception cref="InvalidClusterSnapshotStateException">
        /// The state of the cluster snapshot is not <code>available</code>, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        CopyClusterSnapshotResponse CopyClusterSnapshot(CopyClusterSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopyClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyClusterSnapshot
        ///         operation.</returns>
        IAsyncResult BeginCopyClusterSnapshot(CopyClusterSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CopyClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  CopyClusterSnapshotResult from Redshift.</returns>
        CopyClusterSnapshotResponse EndCopyClusterSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCluster


        /// <summary>
        /// Creates a new cluster. To create the cluster in virtual private cloud
        /// (VPC), you must provide cluster subnet group name. If             you don't provide
        /// a cluster subnet group name or the cluster security group parameter, Amazon Redshift
        ///             creates a non-VPC cluster, it associates the default cluster security
        /// group with the cluster.            For more information about managing clusters, go
        /// to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an        existing parameter group.
        /// </exception>
        /// <exception cref="ClusterQuotaExceededException">
        /// The request would exceed the allowed number of cluster instances for this
        /// account. For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        /// <exception cref="ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster
        /// security group.
        /// </exception>
        /// <exception cref="ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet
        /// group.
        /// </exception>
        /// <exception cref="HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same
        /// VPC.
        /// </exception>
        /// <exception cref="InvalidVPCNetworkStateException">
        /// The cluster subnet group does not cover all Availability Zones.
        /// </exception>
        /// <exception cref="NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        /// <exception cref="UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        CreateClusterResponse CreateCluster(CreateClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCluster
        ///         operation.</returns>
        IAsyncResult BeginCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCluster.</param>
        /// 
        /// <returns>Returns a  CreateClusterResult from Redshift.</returns>
        CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateClusterParameterGroup


        /// <summary>
        /// Creates an Amazon Redshift parameter group. 
        /// 
        ///             
        /// <para>
        /// Creating parameter groups is independent of creating clusters.                   
        /// You can associate a cluster with a parameter group             when you create the
        /// cluster. You can also associate an existing cluster            with a parameter group
        /// after the cluster is created by using <a>ModifyCluster</a>.        
        /// </para>
        ///         
        /// <para>
        ///                      Parameters in the parameter group define specific behavior that
        /// applies to the          databases you create on the cluster.          For more information
        /// about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i>.    
        ///    
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterParameterGroupAlreadyExistsException">
        /// A cluster parameter group with the same name already exists.
        /// </exception>
        /// <exception cref="ClusterParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed        number of
        /// cluster parameter groups. For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        CreateClusterParameterGroupResponse CreateClusterParameterGroup(CreateClusterParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterParameterGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClusterParameterGroup
        ///         operation.</returns>
        IAsyncResult BeginCreateClusterParameterGroup(CreateClusterParameterGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  CreateClusterParameterGroupResult from Redshift.</returns>
        CreateClusterParameterGroupResponse EndCreateClusterParameterGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateClusterSecurityGroup


        /// <summary>
        /// Creates a new Amazon Redshift security group. You use security       
        ///      groups to control access to non-VPC clusters.         
        /// 
        ///         
        /// <para>
        ///             For information about managing security groups, go to<a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        ///        
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the CreateClusterSecurityGroup service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSecurityGroupAlreadyExistsException">
        /// A cluster security group with the same name already exists.
        /// </exception>
        /// <exception cref="ClusterSecurityGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster
        /// security groups. For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        CreateClusterSecurityGroupResponse CreateClusterSecurityGroup(CreateClusterSecurityGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSecurityGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSecurityGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClusterSecurityGroup
        ///         operation.</returns>
        IAsyncResult BeginCreateClusterSecurityGroup(CreateClusterSecurityGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClusterSecurityGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterSecurityGroup.</param>
        /// 
        /// <returns>Returns a  CreateClusterSecurityGroupResult from Redshift.</returns>
        CreateClusterSecurityGroupResponse EndCreateClusterSecurityGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateClusterSnapshot


        /// <summary>
        /// Creates a manual snapshot of the specified cluster.         The cluster must
        /// be in the <code>available</code> state.        
        /// 
        ///         
        /// <para>
        /// For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing
        /// snapshot.
        /// </exception>
        /// <exception cref="ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster
        /// snapshots.
        /// </exception>
        /// <exception cref="InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        CreateClusterSnapshotResponse CreateClusterSnapshot(CreateClusterSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClusterSnapshot
        ///         operation.</returns>
        IAsyncResult BeginCreateClusterSnapshot(CreateClusterSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateClusterSnapshotResult from Redshift.</returns>
        CreateClusterSnapshotResponse EndCreateClusterSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateClusterSubnetGroup


        /// <summary>
        /// Creates a new Amazon Redshift subnet group. You must provide a list of
        /// one or more subnets in             your existing Amazon Virtual Private Cloud (Amazon
        /// VPC) when creating Amazon Redshift subnet group.                   
        /// 
        ///         
        /// <para>
        ///  For information about subnet groups, go to<a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-cluster-subnet-groups.html">Amazon
        /// Redshift Cluster Subnet Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        ///        
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSubnetGroupAlreadyExistsException">
        /// A <i>ClusterSubnetGroupName</i> is already used by an existing cluster subnet
        /// group.
        /// </exception>
        /// <exception cref="ClusterSubnetGroupQuotaExceededException">
        /// The request would result in user exceeding the allowed number of cluster
        /// subnet groups. For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        /// <exception cref="ClusterSubnetQuotaExceededException">
        /// The request would result in user exceeding the allowed number of subnets
        /// in a cluster subnet groups. For information about increasing your quota, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        /// <exception cref="InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same
        /// VPC.
        /// </exception>
        /// <exception cref="UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        CreateClusterSubnetGroupResponse CreateClusterSubnetGroup(CreateClusterSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSubnetGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClusterSubnetGroup
        ///         operation.</returns>
        IAsyncResult BeginCreateClusterSubnetGroup(CreateClusterSubnetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterSubnetGroup.</param>
        /// 
        /// <returns>Returns a  CreateClusterSubnetGroupResult from Redshift.</returns>
        CreateClusterSubnetGroupResponse EndCreateClusterSubnetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEventSubscription


        /// <summary>
        /// Creates an Amazon Redshift event notification subscription. This action
        /// requires an ARN (Amazon Resource Name) of            an Amazon SNS topic created by
        /// either the Amazon Redshift console, the Amazon SNS console, or the             Amazon
        /// SNS API. To obtain an ARN with Amazon SNS, you must create a topic in Amazon SNS and
        /// subscribe to the topic.            The ARN is displayed in the SNS console.      
        ///  
        /// 
        ///         
        /// <para>
        ///             You can specify the source type, and lists of Amazon Redshift source IDs,
        /// event categories, and event severities.            Notifications will be sent for
        /// all events you want that match those criteria. For example, you can specify      
        ///      source type = cluster, source ID = my-cluster-1 and mycluster2, event categories
        /// = Availability, Backup, and            severity = ERROR. The subscription will only
        /// send notifications for those ERROR events in the Availability and            Backup
        /// categories for the specified clusters.        
        /// </para>
        ///         
        /// <para>
        ///             If you specify both the source type and source IDs, such as source type
        /// = cluster and source identifier =             my-cluster-1, notifications will be
        /// sent for all the cluster events for my-cluster-1. If you specify a source type   
        ///         but do not specify a source identifier, you will receive notice of the events
        /// for the objects of that type in your            AWS account. If you do not specify
        /// either the SourceType nor the SourceIdentifier, you will be notified of events   
        ///         generated from all Amazon Redshift sources belonging to your AWS account.
        /// You must specify a source type if you            specify a source ID.        
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="EventSubscriptionQuotaExceededException">
        /// The request would exceed the allowed number of event subscriptions for
        /// this account. For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        /// <exception cref="SNSInvalidTopicException">
        /// Amazon SNS has responded that there is a problem with the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="SNSNoAuthorizationException">
        /// You do not have permission to publish to the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="SNSTopicArnNotFoundException">
        /// An Amazon SNS topic with the specified Amazon Resource Name (ARN) does not exist.
        /// </exception>
        /// <exception cref="SourceNotFoundException">
        /// The specified Amazon Redshift event source could not be found.
        /// </exception>
        /// <exception cref="SubscriptionAlreadyExistException">
        /// There is already an existing event notification subscription with the specified name.
        /// </exception>
        /// <exception cref="SubscriptionCategoryNotFoundException">
        /// The value specified for the event category was not one of the allowed values, or 
        ///           it specified a category that does not apply to the specified source type.
        /// The allowed            values are Configuration, Management, Monitoring, and Security.
        /// </exception>
        /// <exception cref="SubscriptionEventIdNotFoundException">
        /// An Amazon Redshift event with the specified event ID does not exist.
        /// </exception>
        /// <exception cref="SubscriptionSeverityNotFoundException">
        /// The value specified for the event severity was not one of the allowed values, or 
        ///           it specified a severity that does not apply to the specified source type.
        /// The allowed            values are ERROR and INFO.
        /// </exception>
        CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventSubscription
        ///         operation.</returns>
        IAsyncResult BeginCreateEventSubscription(CreateEventSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventSubscription.</param>
        /// 
        /// <returns>Returns a  CreateEventSubscriptionResult from Redshift.</returns>
        CreateEventSubscriptionResponse EndCreateEventSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateHsmClientCertificate


        /// <summary>
        /// Creates an HSM client certificate that an Amazon Redshift cluster will use to connect
        /// to the client's HSM            in order to store and retrieve the keys used to encrypt
        /// the cluster databases.
        /// 
        ///         
        /// <para>
        /// The command returns a public key, which you must store in the HSM. In addition to
        /// creating the HSM certificate,            you must create an Amazon Redshift HSM configuration
        /// that provides a cluster the information needed to            store and use encryption
        /// keys in the HSM. For more information, go to            <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-HSM.html">Hardware
        /// Security Modules</a> in the Amazon Redshift Management Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmClientCertificate service method.</param>
        /// 
        /// <returns>The response from the CreateHsmClientCertificate service method, as returned by Redshift.</returns>
        /// <exception cref="HsmClientCertificateAlreadyExistsException">
        /// There is already an existing Amazon Redshift HSM client certificate with the specified
        /// identifier.
        /// </exception>
        /// <exception cref="HsmClientCertificateQuotaExceededException">
        /// The quota for HSM client certificates has been reached. For information
        /// about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        CreateHsmClientCertificateResponse CreateHsmClientCertificate(CreateHsmClientCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmClientCertificate operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmClientCertificate operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHsmClientCertificate
        ///         operation.</returns>
        IAsyncResult BeginCreateHsmClientCertificate(CreateHsmClientCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHsmClientCertificate operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHsmClientCertificate.</param>
        /// 
        /// <returns>Returns a  CreateHsmClientCertificateResult from Redshift.</returns>
        CreateHsmClientCertificateResponse EndCreateHsmClientCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateHsmConfiguration


        /// <summary>
        /// Creates an HSM configuration that contains the information required by an Amazon Redshift
        /// cluster            to store and use database encryption keys in a Hardware Security
        /// Module (HSM). After            creating the HSM configuration, you can specify it
        /// as a parameter when creating a cluster.            The cluster will then store its
        /// encryption keys in the HSM.
        /// 
        ///         
        /// <para>
        /// In addition to creating an HSM configuration, you must also create an HSM client certificate.
        ///            For more information, go to            <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-HSM.html">Hardware
        /// Security Modules</a> in the Amazon Redshift Management Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateHsmConfiguration service method, as returned by Redshift.</returns>
        /// <exception cref="HsmConfigurationAlreadyExistsException">
        /// There is already an existing Amazon Redshift HSM configuration with the specified
        /// identifier.
        /// </exception>
        /// <exception cref="HsmConfigurationQuotaExceededException">
        /// The quota for HSM configurations has been reached. For information about
        /// increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        CreateHsmConfigurationResponse CreateHsmConfiguration(CreateHsmConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmConfiguration operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmConfiguration operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHsmConfiguration
        ///         operation.</returns>
        IAsyncResult BeginCreateHsmConfiguration(CreateHsmConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHsmConfiguration operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHsmConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateHsmConfigurationResult from Redshift.</returns>
        CreateHsmConfigurationResponse EndCreateHsmConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCluster


        /// <summary>
        /// Deletes a previously provisioned cluster. A successful response      
        ///      from the web service indicates that the request was received correctly. If a
        /// final cluster snapshot is requested            the status of the cluster will be "final-snapshot"
        /// while the snapshot is being taken, then it's "deleting" once Amazon Redshift begins
        /// deleting the cluster. Use <a>DescribeClusters</a>             to monitor the status
        /// of the deletion. The delete operation cannot be canceled or reverted once submitted.
        ///             For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing
        /// snapshot.
        /// </exception>
        /// <exception cref="ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster
        /// snapshots.
        /// </exception>
        /// <exception cref="InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        DeleteClusterResponse DeleteCluster(DeleteClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCluster
        ///         operation.</returns>
        IAsyncResult BeginDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCluster.</param>
        /// 
        /// <returns>Returns a  DeleteClusterResult from Redshift.</returns>
        DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteClusterParameterGroup


        /// <summary>
        /// Deletes a specified Amazon Redshift parameter group.             <note>You
        /// cannot delete a parameter group if it is associated with a cluster.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an        existing parameter group.
        /// </exception>
        /// <exception cref="InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because         another
        /// task is in progress that involves the parameter group.         Wait a few moments
        /// and try the operation again.
        /// </exception>
        DeleteClusterParameterGroupResponse DeleteClusterParameterGroup(DeleteClusterParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterParameterGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClusterParameterGroup
        ///         operation.</returns>
        IAsyncResult BeginDeleteClusterParameterGroup(DeleteClusterParameterGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  DeleteClusterParameterGroupResult from Redshift.</returns>
        DeleteClusterParameterGroupResponse EndDeleteClusterParameterGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteClusterSecurityGroup


        /// <summary>
        /// Deletes an Amazon Redshift security group.         
        /// 
        ///         <note>You cannot delete a security group that is associated with any clusters.
        /// You cannot        delete the default security group.</note>        
        /// <para>
        /// For information about managing security groups, go to<a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterSecurityGroup service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster
        /// security group.
        /// </exception>
        /// <exception cref="InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        DeleteClusterSecurityGroupResponse DeleteClusterSecurityGroup(DeleteClusterSecurityGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSecurityGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSecurityGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClusterSecurityGroup
        ///         operation.</returns>
        IAsyncResult BeginDeleteClusterSecurityGroup(DeleteClusterSecurityGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClusterSecurityGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterSecurityGroup.</param>
        /// 
        /// <returns>Returns a  DeleteClusterSecurityGroupResult from Redshift.</returns>
        DeleteClusterSecurityGroupResponse EndDeleteClusterSecurityGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteClusterSnapshot


        /// <summary>
        /// Deletes the specified manual snapshot. The snapshot must be in the <code>available</code>
        /// state, with no other users authorized to access the snapshot.         
        /// 
        ///         
        /// <para>
        ///             Unlike automated snapshots, manual snapshots are retained even after you
        ///             delete your cluster.                       Amazon Redshift does not delete
        /// your manual snapshots. You must delete manual snapshot             explicitly to avoid
        /// getting charged.            If other accounts are authorized to access the snapshot,
        /// you must revoke all of the authorizations before you can delete the snapshot.    
        ///    
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="InvalidClusterSnapshotStateException">
        /// The state of the cluster snapshot is not <code>available</code>, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        DeleteClusterSnapshotResponse DeleteClusterSnapshot(DeleteClusterSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClusterSnapshot
        ///         operation.</returns>
        IAsyncResult BeginDeleteClusterSnapshot(DeleteClusterSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteClusterSnapshotResult from Redshift.</returns>
        DeleteClusterSnapshotResponse EndDeleteClusterSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteClusterSubnetGroup


        /// <summary>
        /// Deletes the specified cluster subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet
        /// group.
        /// </exception>
        /// <exception cref="InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="InvalidClusterSubnetStateException">
        /// The state of the subnet is invalid.
        /// </exception>
        DeleteClusterSubnetGroupResponse DeleteClusterSubnetGroup(DeleteClusterSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSubnetGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClusterSubnetGroup
        ///         operation.</returns>
        IAsyncResult BeginDeleteClusterSubnetGroup(DeleteClusterSubnetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterSubnetGroup.</param>
        /// 
        /// <returns>Returns a  DeleteClusterSubnetGroupResult from Redshift.</returns>
        DeleteClusterSubnetGroupResponse EndDeleteClusterSubnetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEventSubscription


        /// <summary>
        /// Deletes an Amazon Redshift event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="InvalidSubscriptionStateException">
        /// The subscription request is invalid because it is a duplicate request.
        /// This subscription request is already in progress.
        /// </exception>
        /// <exception cref="SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventSubscription
        ///         operation.</returns>
        IAsyncResult BeginDeleteEventSubscription(DeleteEventSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteEventSubscriptionResult from Redshift.</returns>
        DeleteEventSubscriptionResponse EndDeleteEventSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteHsmClientCertificate


        /// <summary>
        /// Deletes the specified HSM client certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmClientCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteHsmClientCertificate service method, as returned by Redshift.</returns>
        /// <exception cref="HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="InvalidHsmClientCertificateStateException">
        /// The specified HSM client certificate is not in the <code>available</code> state, or
        /// it is still in            use by one or more Amazon Redshift clusters.
        /// </exception>
        DeleteHsmClientCertificateResponse DeleteHsmClientCertificate(DeleteHsmClientCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmClientCertificate operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmClientCertificate operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHsmClientCertificate
        ///         operation.</returns>
        IAsyncResult BeginDeleteHsmClientCertificate(DeleteHsmClientCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHsmClientCertificate operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHsmClientCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteHsmClientCertificateResult from Redshift.</returns>
        DeleteHsmClientCertificateResponse EndDeleteHsmClientCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteHsmConfiguration


        /// <summary>
        /// Deletes the specified Amazon Redshift HSM configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteHsmConfiguration service method, as returned by Redshift.</returns>
        /// <exception cref="HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="InvalidHsmConfigurationStateException">
        /// The specified HSM configuration is not in the <code>available</code> state, or it
        /// is still in            use by one or more Amazon Redshift clusters.
        /// </exception>
        DeleteHsmConfigurationResponse DeleteHsmConfiguration(DeleteHsmConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmConfiguration operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmConfiguration operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHsmConfiguration
        ///         operation.</returns>
        IAsyncResult BeginDeleteHsmConfiguration(DeleteHsmConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHsmConfiguration operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHsmConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteHsmConfigurationResult from Redshift.</returns>
        DeleteHsmConfigurationResponse EndDeleteHsmConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeClusterParameterGroups

        /// <summary>
        /// Returns a list of Amazon Redshift parameter groups, including parameter
        ///             groups you created and the default parameter             group. For each
        /// parameter group, the response             includes the parameter group name, description,
        /// and parameter group family name.             You can optionally specify a name   
        ///          to retrieve the description of             a specific parameter group.  
        ///                  
        /// 
        ///         
        /// <para>
        /// For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an        existing parameter group.
        /// </exception>
        DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups();

        /// <summary>
        /// Returns a list of Amazon Redshift parameter groups, including parameter
        ///             groups you created and the default parameter             group. For each
        /// parameter group, the response             includes the parameter group name, description,
        /// and parameter group family name.             You can optionally specify a name   
        ///          to retrieve the description of             a specific parameter group.  
        ///                  
        /// 
        ///         
        /// <para>
        /// For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an        existing parameter group.
        /// </exception>
        DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameterGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameterGroups operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterParameterGroups
        ///         operation.</returns>
        IAsyncResult BeginDescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterParameterGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterParameterGroups.</param>
        /// 
        /// <returns>Returns a  DescribeClusterParameterGroupsResult from Redshift.</returns>
        DescribeClusterParameterGroupsResponse EndDescribeClusterParameterGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeClusterParameters


        /// <summary>
        /// Returns a detailed list of parameters contained within the specified Amazon
        /// Redshift         parameter group. For each parameter the response includes information
        ///         such as parameter name, description,         data type, value, whether the
        /// parameter value is modifiable, and so on.        
        /// 
        ///         
        /// <para>
        /// You can specify <i>source</i> filter to retrieve parameters of only specific type.
        ///            For example, to retrieve parameters that were modified by a user action
        /// such as from             <a>ModifyClusterParameterGroup</a>, you can specify <i>source</i>
        /// equal to <i>user</i>.
        /// </para>
        ///         
        /// <para>
        /// For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterParameters service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an        existing parameter group.
        /// </exception>
        DescribeClusterParametersResponse DescribeClusterParameters(DescribeClusterParametersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameters operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterParameters
        ///         operation.</returns>
        IAsyncResult BeginDescribeClusterParameters(DescribeClusterParametersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterParameters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterParameters.</param>
        /// 
        /// <returns>Returns a  DescribeClusterParametersResult from Redshift.</returns>
        DescribeClusterParametersResponse EndDescribeClusterParameters(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeClusters

        /// <summary>
        /// Returns properties of provisioned clusters including general cluster properties,
        /// cluster database properties,            maintenance and backup properties, and security
        /// and access properties. This operation supports pagination.             For more information
        /// about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        DescribeClustersResponse DescribeClusters();

        /// <summary>
        /// Returns properties of provisioned clusters including general cluster properties,
        /// cluster database properties,            maintenance and backup properties, and security
        /// and access properties. This operation supports pagination.             For more information
        /// about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        DescribeClustersResponse DescribeClusters(DescribeClustersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusters
        ///         operation.</returns>
        IAsyncResult BeginDescribeClusters(DescribeClustersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusters.</param>
        /// 
        /// <returns>Returns a  DescribeClustersResult from Redshift.</returns>
        DescribeClustersResponse EndDescribeClusters(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeClusterSecurityGroups

        /// <summary>
        /// Returns information about Amazon Redshift security groups.           
        ///  If the name of a security group is specified,             the response will contain
        /// only information about only that security group.         
        /// 
        ///         
        /// <para>
        /// For information about managing security groups, go to<a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster
        /// security group.
        /// </exception>
        DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups();

        /// <summary>
        /// Returns information about Amazon Redshift security groups.           
        ///  If the name of a security group is specified,             the response will contain
        /// only information about only that security group.         
        /// 
        ///         
        /// <para>
        /// For information about managing security groups, go to<a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster
        /// security group.
        /// </exception>
        DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSecurityGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSecurityGroups operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterSecurityGroups
        ///         operation.</returns>
        IAsyncResult BeginDescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterSecurityGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterSecurityGroups.</param>
        /// 
        /// <returns>Returns a  DescribeClusterSecurityGroupsResult from Redshift.</returns>
        DescribeClusterSecurityGroupsResponse EndDescribeClusterSecurityGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeClusterSnapshots

        /// <summary>
        /// Returns one or more snapshot objects, which contain metadata about your cluster
        /// snapshots.        By default, this operation returns information about all snapshots
        /// of all clusters that are        owned by you AWS customer account. No information
        /// is returned for snapshots owned by inactive AWS customer accounts.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        DescribeClusterSnapshotsResponse DescribeClusterSnapshots();

        /// <summary>
        /// Returns one or more snapshot objects, which contain metadata about your cluster
        /// snapshots.        By default, this operation returns information about all snapshots
        /// of all clusters that are        owned by you AWS customer account. No information
        /// is returned for snapshots owned by inactive AWS customer accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        DescribeClusterSnapshotsResponse DescribeClusterSnapshots(DescribeClusterSnapshotsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSnapshots operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSnapshots operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterSnapshots
        ///         operation.</returns>
        IAsyncResult BeginDescribeClusterSnapshots(DescribeClusterSnapshotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterSnapshots operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterSnapshots.</param>
        /// 
        /// <returns>Returns a  DescribeClusterSnapshotsResult from Redshift.</returns>
        DescribeClusterSnapshotsResponse EndDescribeClusterSnapshots(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeClusterSubnetGroups

        /// <summary>
        /// Returns one or more cluster subnet group objects, which contain metadata
        /// about your            cluster subnet groups.  By default, this operation returns information
        /// about            all cluster subnet groups that are defined in you AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet
        /// group.
        /// </exception>
        DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups();

        /// <summary>
        /// Returns one or more cluster subnet group objects, which contain metadata
        /// about your            cluster subnet groups.  By default, this operation returns information
        /// about            all cluster subnet groups that are defined in you AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet
        /// group.
        /// </exception>
        DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSubnetGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSubnetGroups operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterSubnetGroups
        ///         operation.</returns>
        IAsyncResult BeginDescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterSubnetGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterSubnetGroups.</param>
        /// 
        /// <returns>Returns a  DescribeClusterSubnetGroupsResult from Redshift.</returns>
        DescribeClusterSubnetGroupsResponse EndDescribeClusterSubnetGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeClusterVersions

        /// <summary>
        /// Returns  descriptions of the available Amazon Redshift cluster versions. You can
        /// call this     operation even before creating any clusters to learn more about the
        /// Amazon Redshift versions.     For more information about managing clusters, go to
        /// <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by Redshift.</returns>
        DescribeClusterVersionsResponse DescribeClusterVersions();

        /// <summary>
        /// Returns  descriptions of the available Amazon Redshift cluster versions. You can
        /// call this     operation even before creating any clusters to learn more about the
        /// Amazon Redshift versions.     For more information about managing clusters, go to
        /// <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by Redshift.</returns>
        DescribeClusterVersionsResponse DescribeClusterVersions(DescribeClusterVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterVersions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterVersions
        ///         operation.</returns>
        IAsyncResult BeginDescribeClusterVersions(DescribeClusterVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterVersions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterVersions.</param>
        /// 
        /// <returns>Returns a  DescribeClusterVersionsResult from Redshift.</returns>
        DescribeClusterVersionsResponse EndDescribeClusterVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDefaultClusterParameters


        /// <summary>
        /// Returns a list of parameter settings for the specified parameter group family.
        ///        
        /// 
        ///         
        /// <para>
        /// For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeDefaultClusterParameters service method, as returned by Redshift.</returns>
        DescribeDefaultClusterParametersResponse DescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultClusterParameters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultClusterParameters operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDefaultClusterParameters
        ///         operation.</returns>
        IAsyncResult BeginDescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDefaultClusterParameters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDefaultClusterParameters.</param>
        /// 
        /// <returns>Returns a  DescribeDefaultClusterParametersResult from Redshift.</returns>
        DescribeDefaultClusterParametersResponse EndDescribeDefaultClusterParameters(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEventCategories

        /// <summary>
        /// Displays a list of event categories for all event source types, or for a         
        ///  specified source type. For a list of the event categories and source types,     
        ///      go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon
        /// Redshift Event Notifications</a>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Redshift.</returns>
        DescribeEventCategoriesResponse DescribeEventCategories();

        /// <summary>
        /// Displays a list of event categories for all event source types, or for a         
        ///  specified source type. For a list of the event categories and source types,     
        ///      go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon
        /// Redshift Event Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Redshift.</returns>
        DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventCategories
        ///         operation.</returns>
        IAsyncResult BeginDescribeEventCategories(DescribeEventCategoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventCategories operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventCategories.</param>
        /// 
        /// <returns>Returns a  DescribeEventCategoriesResult from Redshift.</returns>
        DescribeEventCategoriesResponse EndDescribeEventCategories(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEvents

        /// <summary>
        /// Returns events related to clusters, security groups, snapshots, and parameter
        ///        groups for the past 14 days. Events specific to a particular cluster, security
        /// group,        snapshot or parameter group can be obtained by providing the name as
        /// a parameter.        By default, the past hour of events are returned.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Redshift.</returns>
        DescribeEventsResponse DescribeEvents();

        /// <summary>
        /// Returns events related to clusters, security groups, snapshots, and parameter
        ///        groups for the past 14 days. Events specific to a particular cluster, security
        /// group,        snapshot or parameter group can be obtained by providing the name as
        /// a parameter.        By default, the past hour of events are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Redshift.</returns>
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        IAsyncResult BeginDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEvents operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a  DescribeEventsResult from Redshift.</returns>
        DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEventSubscriptions

        /// <summary>
        /// Lists descriptions of all the Amazon Redshift event notifications subscription
        /// for a  customer account.            If you specify a subscription name, lists the
        /// description for that subscription.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Redshift.</returns>
        /// <exception cref="SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        DescribeEventSubscriptionsResponse DescribeEventSubscriptions();

        /// <summary>
        /// Lists descriptions of all the Amazon Redshift event notifications subscription
        /// for a  customer account.            If you specify a subscription name, lists the
        /// description for that subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Redshift.</returns>
        /// <exception cref="SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventSubscriptions
        ///         operation.</returns>
        IAsyncResult BeginDescribeEventSubscriptions(DescribeEventSubscriptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventSubscriptions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventSubscriptions.</param>
        /// 
        /// <returns>Returns a  DescribeEventSubscriptionsResult from Redshift.</returns>
        DescribeEventSubscriptionsResponse EndDescribeEventSubscriptions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeHsmClientCertificates

        /// <summary>
        /// Returns information about the specified HSM client certificate. If no certificate
        /// ID is specified,            returns information about all the HSM certificates owned
        /// by your AWS customer account.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by Redshift.</returns>
        /// <exception cref="HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates();

        /// <summary>
        /// Returns information about the specified HSM client certificate. If no certificate
        /// ID is specified,            returns information about all the HSM certificates owned
        /// by your AWS customer account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmClientCertificates service method.</param>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by Redshift.</returns>
        /// <exception cref="HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmClientCertificates operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmClientCertificates operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHsmClientCertificates
        ///         operation.</returns>
        IAsyncResult BeginDescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHsmClientCertificates operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHsmClientCertificates.</param>
        /// 
        /// <returns>Returns a  DescribeHsmClientCertificatesResult from Redshift.</returns>
        DescribeHsmClientCertificatesResponse EndDescribeHsmClientCertificates(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeHsmConfigurations

        /// <summary>
        /// Returns information about the specified Amazon Redshift HSM configuration. If no configuration
        /// ID is            specified, returns information about all the HSM configurations owned
        /// by your AWS customer account.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by Redshift.</returns>
        /// <exception cref="HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        DescribeHsmConfigurationsResponse DescribeHsmConfigurations();

        /// <summary>
        /// Returns information about the specified Amazon Redshift HSM configuration. If no configuration
        /// ID is            specified, returns information about all the HSM configurations owned
        /// by your AWS customer account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by Redshift.</returns>
        /// <exception cref="HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        DescribeHsmConfigurationsResponse DescribeHsmConfigurations(DescribeHsmConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmConfigurations operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmConfigurations operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHsmConfigurations
        ///         operation.</returns>
        IAsyncResult BeginDescribeHsmConfigurations(DescribeHsmConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHsmConfigurations operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHsmConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeHsmConfigurationsResult from Redshift.</returns>
        DescribeHsmConfigurationsResponse EndDescribeHsmConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLoggingStatus


        /// <summary>
        /// Describes whether information, such as queries and connection attempts,          
        ///  is being logged for the specified Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeLoggingStatus service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        DescribeLoggingStatusResponse DescribeLoggingStatus(DescribeLoggingStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoggingStatus operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingStatus operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoggingStatus
        ///         operation.</returns>
        IAsyncResult BeginDescribeLoggingStatus(DescribeLoggingStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoggingStatus operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoggingStatus.</param>
        /// 
        /// <returns>Returns a  DescribeLoggingStatusResult from Redshift.</returns>
        DescribeLoggingStatusResponse EndDescribeLoggingStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeOrderableClusterOptions

        /// <summary>
        /// Returns a list of orderable cluster options. Before you create a         new cluster
        /// you can use this operation to find what options are         available, such as the
        /// EC2 Availability Zones (AZ) in the specific         AWS region that you can specify,
        ///         and the node types you can request. The node types differ by available   
        ///      storage, memory, CPU and price. With the cost involved you might want to    
        ///     obtain a list of cluster options in the specific region and specify values   
        ///      when creating a cluster.         For more information about managing clusters,
        /// go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by Redshift.</returns>
        DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions();

        /// <summary>
        /// Returns a list of orderable cluster options. Before you create a         new cluster
        /// you can use this operation to find what options are         available, such as the
        /// EC2 Availability Zones (AZ) in the specific         AWS region that you can specify,
        ///         and the node types you can request. The node types differ by available   
        ///      storage, memory, CPU and price. With the cost involved you might want to    
        ///     obtain a list of cluster options in the specific region and specify values   
        ///      when creating a cluster.         For more information about managing clusters,
        /// go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableClusterOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by Redshift.</returns>
        DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableClusterOptions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableClusterOptions operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrderableClusterOptions
        ///         operation.</returns>
        IAsyncResult BeginDescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOrderableClusterOptions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrderableClusterOptions.</param>
        /// 
        /// <returns>Returns a  DescribeOrderableClusterOptionsResult from Redshift.</returns>
        DescribeOrderableClusterOptionsResponse EndDescribeOrderableClusterOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReservedNodeOfferings

        /// <summary>
        /// Returns a list of the            available reserved node offerings by
        /// Amazon Redshift with their descriptions including             the node type, the fixed
        /// and recurring costs of reserving the node and duration the node will             be
        /// reserved for you. These descriptions help you             determine which reserve
        /// node offering you want to purchase. You then use the unique offering ID          
        ///   in you call to <a>PurchaseReservedNodeOffering</a> to reserve one or more nodes
        /// for your             Amazon Redshift cluster.        
        /// 
        ///         
        /// <para>
        ///             For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Management Guide</i>.               
        ///      
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings();

        /// <summary>
        /// Returns a list of the            available reserved node offerings by
        /// Amazon Redshift with their descriptions including             the node type, the fixed
        /// and recurring costs of reserving the node and duration the node will             be
        /// reserved for you. These descriptions help you             determine which reserve
        /// node offering you want to purchase. You then use the unique offering ID          
        ///   in you call to <a>PurchaseReservedNodeOffering</a> to reserve one or more nodes
        /// for your             Amazon Redshift cluster.        
        /// 
        ///         
        /// <para>
        ///             For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Management Guide</i>.               
        ///      
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodeOfferings operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeOfferings operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedNodeOfferings
        ///         operation.</returns>
        IAsyncResult BeginDescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedNodeOfferings operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedNodeOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeReservedNodeOfferingsResult from Redshift.</returns>
        DescribeReservedNodeOfferingsResponse EndDescribeReservedNodeOfferings(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReservedNodes

        /// <summary>
        /// Returns the descriptions of the reserved nodes.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by Redshift.</returns>
        /// <exception cref="ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        DescribeReservedNodesResponse DescribeReservedNodes();

        /// <summary>
        /// Returns the descriptions of the reserved nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by Redshift.</returns>
        /// <exception cref="ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        DescribeReservedNodesResponse DescribeReservedNodes(DescribeReservedNodesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodes operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedNodes
        ///         operation.</returns>
        IAsyncResult BeginDescribeReservedNodes(DescribeReservedNodesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedNodes operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedNodes.</param>
        /// 
        /// <returns>Returns a  DescribeReservedNodesResult from Redshift.</returns>
        DescribeReservedNodesResponse EndDescribeReservedNodes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeResize


        /// <summary>
        /// Returns information about the last resize operation for the specified cluster.
        ///         If no resize operation has ever been initiated for the specified cluster,
        /// a <code>HTTP 404</code> error is returned.            If a resize operation was initiated
        /// and completed, the status of the resize remains as <code>SUCCEEDED</code> until  
        ///          the next resize.        
        /// 
        ///        
        /// <para>
        ///             A resize operation can be requested using         <a>ModifyCluster</a>
        /// and specifying a different number or type of nodes for the cluster.        
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResize service method.</param>
        /// 
        /// <returns>The response from the DescribeResize service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="ResizeNotFoundException">
        /// A resize operation for the specified cluster is not found.
        /// </exception>
        DescribeResizeResponse DescribeResize(DescribeResizeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResize operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResize operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResize
        ///         operation.</returns>
        IAsyncResult BeginDescribeResize(DescribeResizeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResize operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResize.</param>
        /// 
        /// <returns>Returns a  DescribeResizeResult from Redshift.</returns>
        DescribeResizeResponse EndDescribeResize(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableLogging


        /// <summary>
        /// Stops logging information, such as queries and connection attempts,           for
        /// the specified Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableLogging service method.</param>
        /// 
        /// <returns>The response from the DisableLogging service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        DisableLoggingResponse DisableLogging(DisableLoggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableLogging operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableLogging operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableLogging
        ///         operation.</returns>
        IAsyncResult BeginDisableLogging(DisableLoggingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableLogging operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableLogging.</param>
        /// 
        /// <returns>Returns a  DisableLoggingResult from Redshift.</returns>
        DisableLoggingResponse EndDisableLogging(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableSnapshotCopy


        /// <summary>
        /// Disables the automatic copying of snapshots from one region to another region for
        /// a specified cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSnapshotCopy service method.</param>
        /// 
        /// <returns>The response from the DisableSnapshotCopy service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="SnapshotCopyAlreadyDisabledException">
        /// The cluster already has cross-region snapshot copy disabled.
        /// </exception>
        /// <exception cref="UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        DisableSnapshotCopyResponse DisableSnapshotCopy(DisableSnapshotCopyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableSnapshotCopy operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableSnapshotCopy operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableSnapshotCopy
        ///         operation.</returns>
        IAsyncResult BeginDisableSnapshotCopy(DisableSnapshotCopyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableSnapshotCopy operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableSnapshotCopy.</param>
        /// 
        /// <returns>Returns a  DisableSnapshotCopyResult from Redshift.</returns>
        DisableSnapshotCopyResponse EndDisableSnapshotCopy(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableLogging


        /// <summary>
        /// Starts logging information, such as queries and connection attempts,            for
        /// the specified Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableLogging service method.</param>
        /// 
        /// <returns>The response from the EnableLogging service method, as returned by Redshift.</returns>
        /// <exception cref="BucketNotFoundException">
        /// Could not find the specified S3 bucket.
        /// </exception>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="InsufficientS3BucketPolicyException">
        /// The cluster does not have read bucket or put object permissions      
        ///      on the S3 bucket specified when enabling logging.
        /// </exception>
        /// <exception cref="InvalidS3BucketNameException">
        /// The S3 bucket name is invalid. For more information about naming rules, go to <a href="http://docs.aws.amazon.com/AmazonS3/latest/dev/BucketRestrictions.html">Bucket
        /// Restrictions and Limitations</a> in the Amazon Simple Storage Service (S3) Developer
        /// Guide.
        /// </exception>
        /// <exception cref="InvalidS3KeyPrefixException">
        /// The string specified for the logging S3 key prefix does not comply with
        ///            the documented constraints.
        /// </exception>
        EnableLoggingResponse EnableLogging(EnableLoggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableLogging operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableLogging operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableLogging
        ///         operation.</returns>
        IAsyncResult BeginEnableLogging(EnableLoggingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableLogging operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableLogging.</param>
        /// 
        /// <returns>Returns a  EnableLoggingResult from Redshift.</returns>
        EnableLoggingResponse EndEnableLogging(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableSnapshotCopy


        /// <summary>
        /// Enables the automatic copy of snapshots from one region to another region for a specified
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSnapshotCopy service method.</param>
        /// 
        /// <returns>The response from the EnableSnapshotCopy service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="CopyToRegionDisabledException">
        /// Cross-region snapshot copy was temporarily disabled. Try your request
        /// again.
        /// </exception>
        /// <exception cref="IncompatibleOrderableOptionsException">
        /// The specified options are incompatible.
        /// </exception>
        /// <exception cref="InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="SnapshotCopyAlreadyEnabledException">
        /// The cluster already has cross-region snapshot copy enabled.
        /// </exception>
        /// <exception cref="UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="UnknownSnapshotCopyRegionException">
        /// The specified region is incorrect or does not exist.
        /// </exception>
        EnableSnapshotCopyResponse EnableSnapshotCopy(EnableSnapshotCopyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableSnapshotCopy operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSnapshotCopy operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableSnapshotCopy
        ///         operation.</returns>
        IAsyncResult BeginEnableSnapshotCopy(EnableSnapshotCopyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableSnapshotCopy operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableSnapshotCopy.</param>
        /// 
        /// <returns>Returns a  EnableSnapshotCopyResult from Redshift.</returns>
        EnableSnapshotCopyResponse EndEnableSnapshotCopy(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyCluster


        /// <summary>
        /// Modifies the settings for a cluster.         For example, you can add
        /// another security or parameter group,         update the preferred maintenance window,
        /// or change the master user password.          Resetting a cluster password or modifying
        /// the security groups associated         with a cluster do not need a reboot. However,
        /// modifying a parameter group         requires a reboot for parameters to take effect.
        ///                For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>        
        /// 
        ///         
        /// <para>
        /// You can also change node type and the number of nodes to scale up or down the cluster.
        ///             When resizing a cluster, you must specify            both the number of
        /// nodes and the node type even if one of the parameters does             not change.
        /// If you specify        the same number of nodes and node type that are already configured
        /// for the cluster,         an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyCluster service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an        existing parameter group.
        /// </exception>
        /// <exception cref="ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster
        /// security group.
        /// </exception>
        /// <exception cref="HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <exception cref="InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        /// <exception cref="UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="UnsupportedOptionException">
        /// A request option was specified that is not supported.
        /// </exception>
        ModifyClusterResponse ModifyCluster(ModifyClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyCluster
        ///         operation.</returns>
        IAsyncResult BeginModifyCluster(ModifyClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCluster.</param>
        /// 
        /// <returns>Returns a  ModifyClusterResult from Redshift.</returns>
        ModifyClusterResponse EndModifyCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyClusterParameterGroup


        /// <summary>
        /// Modifies the parameters of a parameter group.         
        /// 
        ///         
        /// <para>
        /// For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an        existing parameter group.
        /// </exception>
        /// <exception cref="InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because         another
        /// task is in progress that involves the parameter group.         Wait a few moments
        /// and try the operation again.
        /// </exception>
        ModifyClusterParameterGroupResponse ModifyClusterParameterGroup(ModifyClusterParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterParameterGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyClusterParameterGroup
        ///         operation.</returns>
        IAsyncResult BeginModifyClusterParameterGroup(ModifyClusterParameterGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  ModifyClusterParameterGroupResult from Redshift.</returns>
        ModifyClusterParameterGroupResponse EndModifyClusterParameterGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyClusterSubnetGroup


        /// <summary>
        /// Modifies a cluster subnet group to include the specified list of VPC subnets.
        ///         The operation replaces the existing list of subnets with the new list of subnets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet
        /// group.
        /// </exception>
        /// <exception cref="ClusterSubnetQuotaExceededException">
        /// The request would result in user exceeding the allowed number of subnets
        /// in a cluster subnet groups. For information about increasing your quota, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        /// <exception cref="InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same
        /// VPC.
        /// </exception>
        /// <exception cref="SubnetAlreadyInUseException">
        /// A specified subnet is already in use by another cluster.
        /// </exception>
        /// <exception cref="UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        ModifyClusterSubnetGroupResponse ModifyClusterSubnetGroup(ModifyClusterSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSubnetGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyClusterSubnetGroup
        ///         operation.</returns>
        IAsyncResult BeginModifyClusterSubnetGroup(ModifyClusterSubnetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyClusterSubnetGroup.</param>
        /// 
        /// <returns>Returns a  ModifyClusterSubnetGroupResult from Redshift.</returns>
        ModifyClusterSubnetGroupResponse EndModifyClusterSubnetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyEventSubscription


        /// <summary>
        /// Modifies an existing Amazon Redshift event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="InvalidSubscriptionStateException">
        /// The subscription request is invalid because it is a duplicate request.
        /// This subscription request is already in progress.
        /// </exception>
        /// <exception cref="SNSInvalidTopicException">
        /// Amazon SNS has responded that there is a problem with the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="SNSNoAuthorizationException">
        /// You do not have permission to publish to the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="SNSTopicArnNotFoundException">
        /// An Amazon SNS topic with the specified Amazon Resource Name (ARN) does not exist.
        /// </exception>
        /// <exception cref="SourceNotFoundException">
        /// The specified Amazon Redshift event source could not be found.
        /// </exception>
        /// <exception cref="SubscriptionCategoryNotFoundException">
        /// The value specified for the event category was not one of the allowed values, or 
        ///           it specified a category that does not apply to the specified source type.
        /// The allowed            values are Configuration, Management, Monitoring, and Security.
        /// </exception>
        /// <exception cref="SubscriptionEventIdNotFoundException">
        /// An Amazon Redshift event with the specified event ID does not exist.
        /// </exception>
        /// <exception cref="SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <exception cref="SubscriptionSeverityNotFoundException">
        /// The value specified for the event severity was not one of the allowed values, or 
        ///           it specified a severity that does not apply to the specified source type.
        /// The allowed            values are ERROR and INFO.
        /// </exception>
        ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyEventSubscription
        ///         operation.</returns>
        IAsyncResult BeginModifyEventSubscription(ModifyEventSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyEventSubscription.</param>
        /// 
        /// <returns>Returns a  ModifyEventSubscriptionResult from Redshift.</returns>
        ModifyEventSubscriptionResponse EndModifyEventSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifySnapshotCopyRetentionPeriod


        /// <summary>
        /// Modifies the number of days to retain automated snapshots in the destination
        /// region after they are copied from the source region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotCopyRetentionPeriod service method.</param>
        /// 
        /// <returns>The response from the ModifySnapshotCopyRetentionPeriod service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="SnapshotCopyDisabledException">
        /// Cross-region snapshot copy was temporarily disabled. Try your request
        /// again.
        /// </exception>
        /// <exception cref="UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        ModifySnapshotCopyRetentionPeriodResponse ModifySnapshotCopyRetentionPeriod(ModifySnapshotCopyRetentionPeriodRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotCopyRetentionPeriod operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotCopyRetentionPeriod operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifySnapshotCopyRetentionPeriod
        ///         operation.</returns>
        IAsyncResult BeginModifySnapshotCopyRetentionPeriod(ModifySnapshotCopyRetentionPeriodRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifySnapshotCopyRetentionPeriod operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySnapshotCopyRetentionPeriod.</param>
        /// 
        /// <returns>Returns a  ModifySnapshotCopyRetentionPeriodResult from Redshift.</returns>
        ModifySnapshotCopyRetentionPeriodResponse EndModifySnapshotCopyRetentionPeriod(IAsyncResult asyncResult);

        #endregion
        
        #region  PurchaseReservedNodeOffering


        /// <summary>
        /// Allows you to purchase reserved nodes. Amazon Redshift offers a predefined
        /// set of reserved node offerings.           You can purchase one of the offerings. You
        /// can call the           <a>DescribeReservedNodeOfferings</a> API to obtain the available
        /// reserved node offerings. You can call this            API by providing a specific
        /// reserved node offering and the number of nodes you want to reserve.       
        /// 
        ///        
        /// <para>
        ///            For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Management Guide</i>.               
        ///     
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodeOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedNodeOffering service method, as returned by Redshift.</returns>
        /// <exception cref="ReservedNodeAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="ReservedNodeQuotaExceededException">
        /// Request would exceed the user's compute node quota. For information about
        /// increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        PurchaseReservedNodeOfferingResponse PurchaseReservedNodeOffering(PurchaseReservedNodeOfferingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedNodeOffering operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodeOffering operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseReservedNodeOffering
        ///         operation.</returns>
        IAsyncResult BeginPurchaseReservedNodeOffering(PurchaseReservedNodeOfferingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseReservedNodeOffering operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedNodeOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseReservedNodeOfferingResult from Redshift.</returns>
        PurchaseReservedNodeOfferingResponse EndPurchaseReservedNodeOffering(IAsyncResult asyncResult);

        #endregion
        
        #region  RebootCluster


        /// <summary>
        /// Reboots a cluster.         This action is taken as soon as possible. It results
        /// in a momentary outage to the cluster,        during which the cluster status is set
        /// to <code>rebooting</code>. A cluster event is created            when the reboot is
        /// completed.                    Any pending cluster modifications (see <a>ModifyCluster</a>)
        /// are applied at this reboot.        For more information about managing clusters, go
        /// to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootCluster service method.</param>
        /// 
        /// <returns>The response from the RebootCluster service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        RebootClusterResponse RebootCluster(RebootClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RebootCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootCluster operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootCluster
        ///         operation.</returns>
        IAsyncResult BeginRebootCluster(RebootClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RebootCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootCluster.</param>
        /// 
        /// <returns>Returns a  RebootClusterResult from Redshift.</returns>
        RebootClusterResponse EndRebootCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetClusterParameterGroup


        /// <summary>
        /// Sets one or more parameters of the specified parameter group to their
        /// default values and sets the             source values of the parameters to "engine-default".
        ///             To reset the entire parameter group specify the <i>ResetAllParameters</i>
        /// parameter.             For parameter changes to take effect you must reboot any associated
        /// clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an        existing parameter group.
        /// </exception>
        /// <exception cref="InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because         another
        /// task is in progress that involves the parameter group.         Wait a few moments
        /// and try the operation again.
        /// </exception>
        ResetClusterParameterGroupResponse ResetClusterParameterGroup(ResetClusterParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetClusterParameterGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetClusterParameterGroup
        ///         operation.</returns>
        IAsyncResult BeginResetClusterParameterGroup(ResetClusterParameterGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  ResetClusterParameterGroupResult from Redshift.</returns>
        ResetClusterParameterGroupResponse EndResetClusterParameterGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  RestoreFromClusterSnapshot


        /// <summary>
        /// Creates a new cluster from a snapshot. Amazon Redshift creates the resulting
        /// cluster         with the same configuration as the original cluster from which the
        /// snapshot was created,         except that the new cluster        is created with the
        /// default cluster security and parameter group.                 After Amazon Redshift
        /// creates the cluster you can use the <a>ModifyCluster</a>             API to associate
        /// a different security group and different parameter group with the            restored
        /// cluster.        
        /// 
        ///         
        /// <para>
        ///  If you restore a cluster into a VPC, you must provide a cluster subnet group where
        /// you want the cluster             restored.        
        /// </para>
        ///         
        /// <para>
        /// For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreFromClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="AccessToSnapshotDeniedException">
        /// The owner of the specified snapshot has not authorized your account to
        /// access the snapshot.
        /// </exception>
        /// <exception cref="ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an        existing parameter group.
        /// </exception>
        /// <exception cref="ClusterQuotaExceededException">
        /// The request would exceed the allowed number of cluster instances for this
        /// account. For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        /// <exception cref="ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster
        /// security group.
        /// </exception>
        /// <exception cref="ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet
        /// group.
        /// </exception>
        /// <exception cref="HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="InvalidClusterSnapshotStateException">
        /// The state of the cluster snapshot is not <code>available</code>, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="InvalidRestoreException">
        /// The restore is invalid.
        /// </exception>
        /// <exception cref="InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same
        /// VPC.
        /// </exception>
        /// <exception cref="InvalidVPCNetworkStateException">
        /// The cluster subnet group does not cover all Availability Zones.
        /// </exception>
        /// <exception cref="NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        /// <exception cref="UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        RestoreFromClusterSnapshotResponse RestoreFromClusterSnapshot(RestoreFromClusterSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreFromClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromClusterSnapshot operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreFromClusterSnapshot
        ///         operation.</returns>
        IAsyncResult BeginRestoreFromClusterSnapshot(RestoreFromClusterSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreFromClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreFromClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  RestoreFromClusterSnapshotResult from Redshift.</returns>
        RestoreFromClusterSnapshotResponse EndRestoreFromClusterSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  RevokeClusterSecurityGroupIngress


        /// <summary>
        /// Revokes an ingress rule in an Amazon Redshift security group for a previously
        /// authorized IP range or         Amazon EC2 security group. To add        an ingress
        /// rule, see <a>AuthorizeClusterSecurityGroupIngress</a>.             For information
        /// about managing security groups, go to<a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeClusterSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the RevokeClusterSecurityGroupIngress service method, as returned by Redshift.</returns>
        /// <exception cref="AuthorizationNotFoundException">
        /// The specified CIDR IP range or EC2 security group is not authorized      
        ///  for the specified cluster security group.
        /// </exception>
        /// <exception cref="ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster
        /// security group.
        /// </exception>
        /// <exception cref="InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        RevokeClusterSecurityGroupIngressResponse RevokeClusterSecurityGroupIngress(RevokeClusterSecurityGroupIngressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeClusterSecurityGroupIngress operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeClusterSecurityGroupIngress operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeClusterSecurityGroupIngress
        ///         operation.</returns>
        IAsyncResult BeginRevokeClusterSecurityGroupIngress(RevokeClusterSecurityGroupIngressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeClusterSecurityGroupIngress operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeClusterSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a  RevokeClusterSecurityGroupIngressResult from Redshift.</returns>
        RevokeClusterSecurityGroupIngressResponse EndRevokeClusterSecurityGroupIngress(IAsyncResult asyncResult);

        #endregion
        
        #region  RevokeSnapshotAccess


        /// <summary>
        /// Removes the ability of the specified AWS customer account to restore the
        /// specified snapshot.            If the account is currently restoring the snapshot,
        /// the restore will run to completion.        
        /// 
        ///         
        /// <para>
        /// For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSnapshotAccess service method.</param>
        /// 
        /// <returns>The response from the RevokeSnapshotAccess service method, as returned by Redshift.</returns>
        /// <exception cref="AccessToSnapshotDeniedException">
        /// The owner of the specified snapshot has not authorized your account to
        /// access the snapshot.
        /// </exception>
        /// <exception cref="AuthorizationNotFoundException">
        /// The specified CIDR IP range or EC2 security group is not authorized      
        ///  for the specified cluster security group.
        /// </exception>
        /// <exception cref="ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        RevokeSnapshotAccessResponse RevokeSnapshotAccess(RevokeSnapshotAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSnapshotAccess operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSnapshotAccess operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeSnapshotAccess
        ///         operation.</returns>
        IAsyncResult BeginRevokeSnapshotAccess(RevokeSnapshotAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeSnapshotAccess operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeSnapshotAccess.</param>
        /// 
        /// <returns>Returns a  RevokeSnapshotAccessResult from Redshift.</returns>
        RevokeSnapshotAccessResponse EndRevokeSnapshotAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  RotateEncryptionKey


        /// <summary>
        /// Rotates the encryption keys for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the RotateEncryptionKey service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        RotateEncryptionKeyResponse RotateEncryptionKey(RotateEncryptionKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RotateEncryptionKey operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RotateEncryptionKey operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRotateEncryptionKey
        ///         operation.</returns>
        IAsyncResult BeginRotateEncryptionKey(RotateEncryptionKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RotateEncryptionKey operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRotateEncryptionKey.</param>
        /// 
        /// <returns>Returns a  RotateEncryptionKeyResult from Redshift.</returns>
        RotateEncryptionKeyResponse EndRotateEncryptionKey(IAsyncResult asyncResult);

        #endregion
        
    }
}