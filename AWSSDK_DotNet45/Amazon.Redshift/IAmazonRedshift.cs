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
using System.Threading;
using System.Threading.Tasks;

using Amazon.Redshift.Model;

namespace Amazon.Redshift
{
    /// <summary>
    /// Interface for accessing AmazonRedshift.
    /// 
    /// Amazon Redshift <b>Overview</b> <para> This is an interface reference for Amazon Redshift. It contains documentation for one of the
    /// programming or command line interfaces you can use to manage Amazon Redshift clusters. Note that Amazon Redshift is asynchronous, which
    /// means that some interfaces may require techniques, such as polling or asynchronous callback handlers, to determine when a command has been
    /// applied. In this reference, the parameter descriptions indicate whether a change is applied immediately, on the next instance reboot, or
    /// during the next maintenance window. For a summary of the Amazon Redshift cluster management interfaces, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/using-aws-sdk.html">Using the Amazon Redshift Management Interfaces </a> .</para>
    /// <para> Amazon Redshift manages all the work of setting up, operating, and scaling a data warehouse: provisioning capacity, monitoring and
    /// backing up the cluster, and applying patches and upgrades to the Amazon Redshift engine. You can focus on using your data to acquire new
    /// insights for your business and customers. </para> <para>If you are a first-time user of Amazon Redshift, we recommend that you begin by
    /// reading the The <a href="http://docs.aws.amazon.com/redshift/latest/gsg/getting-started.html">Amazon Redshift Getting Started Guide</a>
    /// </para> <para>If you are a database developer, the <a href="http://docs.aws.amazon.com/redshift/latest/dg/welcome.html">Amazon Redshift
    /// Database Developer Guide</a> explains how to design, build, query, and maintain the databases that make up your data warehouse. </para>
    /// </summary>
	public partial interface IAmazonRedshift : IDisposable
    {
 

        /// <summary>
        /// <para> Adds an inbound (ingress) rule to an Amazon Redshift security group. Depending on whether the application accessing your cluster is
        /// running on the Internet or an EC2 instance, you can authorize inbound access to either a Classless Interdomain Routing (CIDR) IP address
        /// range or an EC2 security group. You can add as many as 20 ingress rules to an Amazon Redshift security group. </para> <para><b>NOTE:</b> The
        /// EC2 security group must be defined in the AWS region where the cluster resides. </para> <para>For an overview of CIDR blocks, see the
        /// Wikipedia article on <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless Inter-Domain Routing</a> .
        /// </para> <para> You must also associate the security group with a cluster so that clients running on these IP addresses or the EC2
        /// instance are authorized to connect to the cluster. For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Working with Security Groups</a> in the <i>Amazon
        /// Redshift Management Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// AuthorizeClusterSecurityGroupIngress service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the AuthorizeClusterSecurityGroupIngress service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.AuthorizationAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.AuthorizationQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
		AuthorizeClusterSecurityGroupIngressResponse AuthorizeClusterSecurityGroupIngress(AuthorizeClusterSecurityGroupIngressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeClusterSecurityGroupIngress operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.AuthorizeClusterSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClusterSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AuthorizeClusterSecurityGroupIngressResponse> AuthorizeClusterSecurityGroupIngressAsync(AuthorizeClusterSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Authorizes the specified AWS customer account to restore the specified snapshot. </para> <para> For more information about working
        /// with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon Redshift Snapshots</a>
        /// in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSnapshotAccess service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the AuthorizeSnapshotAccess service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.AuthorizationAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.AuthorizationQuotaExceededException" />
		AuthorizeSnapshotAccessResponse AuthorizeSnapshotAccess(AuthorizeSnapshotAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSnapshotAccess operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.AuthorizeSnapshotAccess"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSnapshotAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AuthorizeSnapshotAccessResponse> AuthorizeSnapshotAccessAsync(AuthorizeSnapshotAccessRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Copies the specified automated cluster snapshot to a new manual cluster snapshot. The source must be an automated snapshot and it
        /// must be in the available state. </para> <para> When you delete a cluster, Amazon Redshift deletes any automated snapshots of the cluster.
        /// Also, when the retention period of the snapshot expires, Amazon Redshift automatically deletes it. If you want to keep an automated snapshot
        /// for a longer period, you can make a manual copy of the snapshot. Manual snapshots are retained until you delete them. </para> <para> For
        /// more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon Redshift Snapshots</a> in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CopyClusterSnapshot service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSnapshotStateException" />
		CopyClusterSnapshotResponse CopyClusterSnapshot(CopyClusterSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopyClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CopyClusterSnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CopyClusterSnapshotResponse> CopyClusterSnapshotAsync(CopyClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates a new cluster. To create the cluster in virtual private cloud (VPC), you must provide cluster subnet group name. If you don't
        /// provide a cluster subnet group name or the cluster security group parameter, Amazon Redshift creates a non-VPC cluster, it associates the
        /// default cluster security group with the cluster. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidElasticIpException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.Redshift.Model.HsmConfigurationNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InsufficientClusterCapacityException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnauthorizedOperationException" />
        /// <exception cref="T:Amazon.Redshift.Model.NumberOfNodesQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.HsmClientCertificateNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
		CreateClusterResponse CreateCluster(CreateClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateCluster"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates an Amazon Redshift parameter group. </para> <para>Creating parameter groups is independent of creating clusters. You can
        /// associate a cluster with a parameter group when you create the cluster. You can also associate an existing cluster with a parameter group
        /// after the cluster is created by using ModifyCluster. </para> <para> Parameters in the parameter group define specific behavior that applies
        /// to the databases you create on the cluster. For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon Redshift Parameter Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterParameterGroup service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateClusterParameterGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupAlreadyExistsException" />
		CreateClusterParameterGroupResponse CreateClusterParameterGroup(CreateClusterParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateClusterParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateClusterParameterGroupResponse> CreateClusterParameterGroupAsync(CreateClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates a new Amazon Redshift security group. You use security groups to control access to non-VPC clusters. </para> <para> For
        /// information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon Redshift Cluster Security Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSecurityGroup service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateClusterSecurityGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupAlreadyExistsException" />
		CreateClusterSecurityGroupResponse CreateClusterSecurityGroup(CreateClusterSecurityGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSecurityGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateClusterSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateClusterSecurityGroupResponse> CreateClusterSecurityGroupAsync(CreateClusterSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates a manual snapshot of the specified cluster. The cluster must be in the "available" state. </para> <para> For more information
        /// about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon Redshift
        /// Snapshots</a> in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateClusterSnapshot service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException" />
		CreateClusterSnapshotResponse CreateClusterSnapshot(CreateClusterSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateClusterSnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateClusterSnapshotResponse> CreateClusterSnapshotAsync(CreateClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates a new Amazon Redshift subnet group. You must provide a list of one or more subnets in your existing Amazon Virtual Private
        /// Cloud (Amazon VPC) when creating Amazon Redshift subnet group. </para> <para> For information about subnet groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-cluster-subnet-groups.html">Amazon Redshift Cluster Subnet Groups</a> in
        /// the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSubnetGroup service method
        /// on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateClusterSubnetGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnauthorizedOperationException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupQuotaExceededException" />
		CreateClusterSubnetGroupResponse CreateClusterSubnetGroup(CreateClusterSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateClusterSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateClusterSubnetGroupResponse> CreateClusterSubnetGroupAsync(CreateClusterSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

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
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionCategoryNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionAlreadyExistException" />
        /// <exception cref="T:Amazon.Redshift.Model.EventSubscriptionQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionEventIdNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionSeverityNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SourceNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SNSNoAuthorizationException" />
        /// <exception cref="T:Amazon.Redshift.Model.SNSTopicArnNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SNSInvalidTopicException" />
		CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateEventSubscription"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Creates an HSM client certificate that an Amazon Redshift cluster will use to connect to the client's HSM in order to store and
        /// retrieve the keys used to encrypt the cluster databases.</para> <para>The command returns a public key, which you must store in the HSM.
        /// After creating the HSM certificate, you must create an Amazon Redshift HSM configuration that provides a cluster the information needed to
        /// store and retrieve database encryption keys in the HSM. For more information, go to aLinkToHSMTopic in the Amazon Redshift Management
        /// Guide.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmClientCertificate service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateHsmClientCertificate service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.HsmClientCertificateQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.HsmClientCertificateAlreadyExistsException" />
		CreateHsmClientCertificateResponse CreateHsmClientCertificate(CreateHsmClientCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmClientCertificate operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateHsmClientCertificate"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateHsmClientCertificateResponse> CreateHsmClientCertificateAsync(CreateHsmClientCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Creates an HSM configuration that contains the information required by an Amazon Redshift cluster to store and retrieve database
        /// encryption keys in a Hardware Storeage Module (HSM). After creating the HSM configuration, you can specify it as a parameter when creating a
        /// cluster. The cluster will then store its encryption keys in the HSM.</para> <para>Before creating an HSM configuration, you must have first
        /// created an HSM client certificate. For more information, go to aLinkToHSMTopic in the Amazon Redshift Management Guide.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmConfiguration service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateHsmConfiguration service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.HsmConfigurationQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.HsmConfigurationAlreadyExistsException" />
		CreateHsmConfigurationResponse CreateHsmConfiguration(CreateHsmConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmConfiguration operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.CreateHsmConfiguration"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateHsmConfigurationResponse> CreateHsmConfigurationAsync(CreateHsmConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes a previously provisioned cluster. A successful response from the web service indicates that the request was received
        /// correctly. If a final cluster snapshot is requested the status of the cluster will be "final-snapshot" while the snapshot is being taken,
        /// then it's "deleting" once Amazon Redshift begins deleting the cluster. Use DescribeClusters to monitor the status of the deletion. The
        /// delete operation cannot be canceled or reverted once submitted. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException" />
		DeleteClusterResponse DeleteCluster(DeleteClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteCluster"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes a specified Amazon Redshift parameter group. <para><b>NOTE:</b>You cannot delete a parameter group if it is associated with a
        /// cluster.</para> </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterParameterGroup service
        /// method on AmazonRedshift.</param>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterParameterGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
		DeleteClusterParameterGroupResponse DeleteClusterParameterGroup(DeleteClusterParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteClusterParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteClusterParameterGroupResponse> DeleteClusterParameterGroupAsync(DeleteClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes an Amazon Redshift security group. </para> <para><b>NOTE:</b>You cannot delete a security group that is associated with any
        /// clusters. You cannot delete the default security group.</para> <para> For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon Redshift Cluster Security Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSecurityGroup service
        /// method on AmazonRedshift.</param>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
		DeleteClusterSecurityGroupResponse DeleteClusterSecurityGroup(DeleteClusterSecurityGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSecurityGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteClusterSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteClusterSecurityGroupResponse> DeleteClusterSecurityGroupAsync(DeleteClusterSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes the specified manual snapshot. The snapshot must be in the "available" state, with no other users authorized to access the
        /// snapshot. </para> <para> Unlike automated snapshots, manual snapshots are retained even after you delete your cluster. Amazon Redshift does
        /// not delete your manual snapshots. You must delete manual snapshot explicitly to avoid getting charged. If other accounts are authorized to
        /// access the snapshot, you must revoke all of the authorizations before you can delete the snapshot. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DeleteClusterSnapshot service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSnapshotStateException" />
		DeleteClusterSnapshotResponse DeleteClusterSnapshot(DeleteClusterSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteClusterSnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteClusterSnapshotResponse> DeleteClusterSnapshotAsync(DeleteClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes the specified cluster subnet group. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSubnetGroup service method
        /// on AmazonRedshift.</param>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSubnetStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException" />
		DeleteClusterSubnetGroupResponse DeleteClusterSubnetGroup(DeleteClusterSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteClusterSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteClusterSubnetGroupResponse> DeleteClusterSubnetGroupAsync(DeleteClusterSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes an Amazon Redshift event notification subscription. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method on
        /// AmazonRedshift.</param>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionNotFoundException" />
		DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteEventSubscription"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the specified HSM client certificate.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmClientCertificate service
        /// method on AmazonRedshift.</param>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidHsmClientCertificateStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.HsmClientCertificateNotFoundException" />
		DeleteHsmClientCertificateResponse DeleteHsmClientCertificate(DeleteHsmClientCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmClientCertificate operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteHsmClientCertificate"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteHsmClientCertificateResponse> DeleteHsmClientCertificateAsync(DeleteHsmClientCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the specified Amazon Redshift HSM configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmConfiguration service method on
        /// AmazonRedshift.</param>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.HsmConfigurationNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidHsmConfigurationStateException" />
		DeleteHsmConfigurationResponse DeleteHsmConfiguration(DeleteHsmConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmConfiguration operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DeleteHsmConfiguration"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteHsmConfigurationResponse> DeleteHsmConfigurationAsync(DeleteHsmConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Returns a list of Amazon Redshift parameter groups, including parameter groups you created and the default parameter group. For each
        /// parameter group, the response includes the parameter group name, description, and parameter group family name. You can optionally specify a
        /// name to retrieve the description of a specific parameter group. </para> <para> For more information about managing parameter groups, go to
        /// <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon Redshift Parameter Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameterGroups
        /// service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
		DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameterGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusterParameterGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeClusterParameterGroupsResponse> DescribeClusterParameterGroupsAsync(DescribeClusterParameterGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of Amazon Redshift parameter groups, including parameter groups you created and the default parameter group. For each
        /// parameter group, the response includes the parameter group name, description, and parameter group family name. You can optionally specify a
        /// name to retrieve the description of a specific parameter group. </para> <para> For more information about managing parameter groups, go to
        /// <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon Redshift Parameter Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
		DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups();
 

        /// <summary>
        /// <para> Returns a detailed list of parameters contained within the specified Amazon Redshift parameter group. For each parameter the response
        /// includes information such as parameter name, description, data type, value, whether the parameter value is modifiable, and so on. </para>
        /// <para>You can specify <i>source</i> filter to retrieve parameters of only specific type. For example, to retrieve parameters that were
        /// modified by a user action such as from ModifyClusterParameterGroup, you can specify <i>source</i> equal to <i>user</i> .</para> <para> For
        /// more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon Redshift Parameter Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameters service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterParameters service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
		DescribeClusterParametersResponse DescribeClusterParameters(DescribeClusterParametersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusterParameters"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeClusterParametersResponse> DescribeClusterParametersAsync(DescribeClusterParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Returns properties of provisioned clusters including general cluster properties, cluster database properties, maintenance and backup
        /// properties, and security and access properties. This operation supports pagination. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
		DescribeClustersResponse DescribeClusters(DescribeClustersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusters"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns properties of provisioned clusters including general cluster properties, cluster database properties, maintenance and backup
        /// properties, and security and access properties. This operation supports pagination. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
		DescribeClustersResponse DescribeClusters();
 

        /// <summary>
        /// <para> Returns information about Amazon Redshift security groups. If the name of a security group is specified, the response will contain
        /// only information about only that security group. </para> <para> For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon Redshift Cluster Security Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSecurityGroups
        /// service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
		DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSecurityGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusterSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeClusterSecurityGroupsResponse> DescribeClusterSecurityGroupsAsync(DescribeClusterSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns information about Amazon Redshift security groups. If the name of a security group is specified, the response will contain
        /// only information about only that security group. </para> <para> For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon Redshift Cluster Security Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
		DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups();
 

        /// <summary>
        /// <para> Returns one or more snapshot objects, which contain metadata about your cluster snapshots. By default, this operation returns
        /// information about all snapshots of all clusters that are owned by you AWS customer account. No information is returned for snapshots owned
        /// by inactive AWS customer accounts. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSnapshots service method
        /// on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotNotFoundException" />
		DescribeClusterSnapshotsResponse DescribeClusterSnapshots(DescribeClusterSnapshotsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSnapshots operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusterSnapshots"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeClusterSnapshotsResponse> DescribeClusterSnapshotsAsync(DescribeClusterSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns one or more snapshot objects, which contain metadata about your cluster snapshots. By default, this operation returns
        /// information about all snapshots of all clusters that are owned by you AWS customer account. No information is returned for snapshots owned
        /// by inactive AWS customer accounts. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotNotFoundException" />
		DescribeClusterSnapshotsResponse DescribeClusterSnapshots();
 

        /// <summary>
        /// <para> Returns one or more cluster subnet group objects, which contain metadata about your cluster subnet groups. By default, this
        /// operation returns information about all cluster subnet groups that are defined in you AWS account. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSubnetGroups service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException" />
		DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSubnetGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusterSubnetGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeClusterSubnetGroupsResponse> DescribeClusterSubnetGroupsAsync(DescribeClusterSubnetGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns one or more cluster subnet group objects, which contain metadata about your cluster subnet groups. By default, this
        /// operation returns information about all cluster subnet groups that are defined in you AWS account. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException" />
		DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups();
 

        /// <summary>
        /// <para> Returns descriptions of the available Amazon Redshift cluster versions. You can call this operation even before creating any
        /// clusters to learn more about the Amazon Redshift versions. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by AmazonRedshift.</returns>
		DescribeClusterVersionsResponse DescribeClusterVersions(DescribeClusterVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterVersions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeClusterVersions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeClusterVersionsResponse> DescribeClusterVersionsAsync(DescribeClusterVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns descriptions of the available Amazon Redshift cluster versions. You can call this operation even before creating any
        /// clusters to learn more about the Amazon Redshift versions. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by AmazonRedshift.</returns>
		DescribeClusterVersionsResponse DescribeClusterVersions();
 

        /// <summary>
        /// <para> Returns a list of parameter settings for the specified parameter group family. </para> <para> For more information about managing
        /// parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon Redshift
        /// Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultClusterParameters
        /// service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeDefaultClusterParameters service method, as returned by AmazonRedshift.</returns>
		DescribeDefaultClusterParametersResponse DescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultClusterParameters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeDefaultClusterParameters"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultClusterParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeDefaultClusterParametersResponse> DescribeDefaultClusterParametersAsync(DescribeDefaultClusterParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Displays a list of event categories for all event source types, or for a specified source type. For a list of the event categories and
        /// source types, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon Redshift Event
        /// Notifications</a> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by AmazonRedshift.</returns>
		DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeEventCategories"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Displays a list of event categories for all event source types, or for a specified source type. For a list of the event categories and
        /// source types, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon Redshift Event
        /// Notifications</a> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by AmazonRedshift.</returns>
		DescribeEventCategoriesResponse DescribeEventCategories();
 

        /// <summary>
        /// <para> Returns events related to clusters, security groups, snapshots, and parameter groups for the past 14 days. Events specific to a
        /// particular cluster, security group, snapshot or parameter group can be obtained by providing the name as a parameter. By default, the past
        /// hour of events are returned. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonRedshift.</returns>
		DescribeEventsResponse DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeEvents"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns events related to clusters, security groups, snapshots, and parameter groups for the past 14 days. Events specific to a
        /// particular cluster, security group, snapshot or parameter group can be obtained by providing the name as a parameter. By default, the past
        /// hour of events are returned. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonRedshift.</returns>
		DescribeEventsResponse DescribeEvents();
 

        /// <summary>
        /// <para> Lists descriptions of all the Amazon Redshift event notifications subscription for a customer account. If you specify a subscription
        /// name, lists the description for that subscription. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionNotFoundException" />
		DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeEventSubscriptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Lists descriptions of all the Amazon Redshift event notifications subscription for a customer account. If you specify a subscription
        /// name, lists the description for that subscription. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionNotFoundException" />
		DescribeEventSubscriptionsResponse DescribeEventSubscriptions();
 

        /// <summary>
        /// <para>Returns information about the specified HSM client certificate. If no certificate ID is specified, returns information about all the
        /// HSM certificates owned by your AWS customer account.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmClientCertificates
        /// service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.HsmClientCertificateNotFoundException" />
		DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmClientCertificates operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeHsmClientCertificates"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmClientCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeHsmClientCertificatesResponse> DescribeHsmClientCertificatesAsync(DescribeHsmClientCertificatesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns information about the specified HSM client certificate. If no certificate ID is specified, returns information about all the
        /// HSM certificates owned by your AWS customer account.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.HsmClientCertificateNotFoundException" />
		DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates();
 

        /// <summary>
        /// <para>Returns information about the specified Amazon Redshift HSM configuration. If no configuration ID is specified, returns information
        /// about all the HSM configurations owned by your AWS customer account.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmConfigurations service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.HsmConfigurationNotFoundException" />
		DescribeHsmConfigurationsResponse DescribeHsmConfigurations(DescribeHsmConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmConfigurations operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeHsmConfigurations"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeHsmConfigurationsResponse> DescribeHsmConfigurationsAsync(DescribeHsmConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns information about the specified Amazon Redshift HSM configuration. If no configuration ID is specified, returns information
        /// about all the HSM configurations owned by your AWS customer account.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.HsmConfigurationNotFoundException" />
		DescribeHsmConfigurationsResponse DescribeHsmConfigurations();
 

        /// <summary>
        /// <para>Describes whether information, such as queries and connection attempts, is being logged for the specified Amazon Redshift
        /// cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingStatus service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeLoggingStatus service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
		DescribeLoggingStatusResponse DescribeLoggingStatus(DescribeLoggingStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoggingStatus operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeLoggingStatus"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeLoggingStatusResponse> DescribeLoggingStatusAsync(DescribeLoggingStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Returns a list of orderable cluster options. Before you create a new cluster you can use this operation to find what options are
        /// available, such as the EC2 Availability Zones (AZ) in the specific AWS region that you can specify, and the node types you can request. The
        /// node types differ by available storage, memory, CPU and price. With the cost involved you might want to obtain a list of cluster options in
        /// the specific region and specify values when creating a cluster. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableClusterOptions
        /// service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by AmazonRedshift.</returns>
		DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableClusterOptions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeOrderableClusterOptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableClusterOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeOrderableClusterOptionsResponse> DescribeOrderableClusterOptionsAsync(DescribeOrderableClusterOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of orderable cluster options. Before you create a new cluster you can use this operation to find what options are
        /// available, such as the EC2 Availability Zones (AZ) in the specific AWS region that you can specify, and the node types you can request. The
        /// node types differ by available storage, memory, CPU and price. With the cost involved you might want to obtain a list of cluster options in
        /// the specific region and specify values when creating a cluster. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by AmazonRedshift.</returns>
		DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions();
 

        /// <summary>
        /// <para> Returns a list of the available reserved node offerings by Amazon Redshift with their descriptions including the node type, the fixed
        /// and recurring costs of reserving the node and duration the node will be reserved for you. These descriptions help you determine which
        /// reserve node offering you want to purchase. You then use the unique offering ID in you call to PurchaseReservedNodeOffering to reserve one
        /// or more nodes for your Amazon Redshift cluster. </para> <para> For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing Reserved Nodes</a> in the <i>Amazon
        /// Redshift Management Guide</i> .
        /// 
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeOfferings
        /// service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException" />
		DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodeOfferings operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeReservedNodeOfferings"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeReservedNodeOfferingsResponse> DescribeReservedNodeOfferingsAsync(DescribeReservedNodeOfferingsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of the available reserved node offerings by Amazon Redshift with their descriptions including the node type, the fixed
        /// and recurring costs of reserving the node and duration the node will be reserved for you. These descriptions help you determine which
        /// reserve node offering you want to purchase. You then use the unique offering ID in you call to PurchaseReservedNodeOffering to reserve one
        /// or more nodes for your Amazon Redshift cluster. </para> <para> For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing Reserved Nodes</a> in the <i>Amazon
        /// Redshift Management Guide</i> .
        /// 
        /// </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException" />
		DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings();
 

        /// <summary>
        /// <para> Returns the descriptions of the reserved nodes. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ReservedNodeNotFoundException" />
		DescribeReservedNodesResponse DescribeReservedNodes(DescribeReservedNodesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodes operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeReservedNodes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeReservedNodesResponse> DescribeReservedNodesAsync(DescribeReservedNodesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns the descriptions of the reserved nodes. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ReservedNodeNotFoundException" />
		DescribeReservedNodesResponse DescribeReservedNodes();
 

        /// <summary>
        /// <para> Returns information about the last resize operation for the specified cluster. If no resize operation has ever been initiated for the
        /// specified cluster, a <c>HTTP 404</c> error is returned. If a resize operation was initiated and completed, the status of the resize remains
        /// as <c>SUCCEEDED</c> until the next resize. </para> <para> A resize operation can be requested using ModifyCluster and specifying a different
        /// number or type of nodes for the cluster. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResize service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeResize service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ResizeNotFoundException" />
		DescribeResizeResponse DescribeResize(DescribeResizeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResize operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DescribeResize"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResize operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeResizeResponse> DescribeResizeAsync(DescribeResizeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Stops logging information, such as queries and connection attempts, for the specified Amazon Redshift cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableLogging service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DisableLogging service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
		DisableLoggingResponse DisableLogging(DisableLoggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableLogging operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DisableLogging"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DisableLoggingResponse> DisableLoggingAsync(DisableLoggingRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Disables the automatic copying of snapshots from one region to another region for a specified cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableSnapshotCopy service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DisableSnapshotCopy service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.SnapshotCopyAlreadyDisabledException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnauthorizedOperationException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
		DisableSnapshotCopyResponse DisableSnapshotCopy(DisableSnapshotCopyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableSnapshotCopy operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.DisableSnapshotCopy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableSnapshotCopy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DisableSnapshotCopyResponse> DisableSnapshotCopyAsync(DisableSnapshotCopyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Starts logging information, such as queries and connection attempts, for the specified Amazon Redshift cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableLogging service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the EnableLogging service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidS3KeyPrefixException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidS3BucketNameException" />
        /// <exception cref="T:Amazon.Redshift.Model.BucketNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InsufficientS3BucketPolicyException" />
		EnableLoggingResponse EnableLogging(EnableLoggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableLogging operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.EnableLogging"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<EnableLoggingResponse> EnableLoggingAsync(EnableLoggingRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Enables the automatic copy of snapshots from one region to another region for a specified cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSnapshotCopy service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the EnableSnapshotCopy service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.CopyToRegionDisabledException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnauthorizedOperationException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.IncompatibleOrderableOptionsException" />
        /// <exception cref="T:Amazon.Redshift.Model.SnapshotCopyAlreadyEnabledException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnknownSnapshotCopyRegionException" />
		EnableSnapshotCopyResponse EnableSnapshotCopy(EnableSnapshotCopyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableSnapshotCopy operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.EnableSnapshotCopy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSnapshotCopy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<EnableSnapshotCopyResponse> EnableSnapshotCopyAsync(EnableSnapshotCopyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Modifies the settings for a cluster. For example, you can add another security or parameter group, update the preferred maintenance
        /// window, or change the master user password. Resetting a cluster password or modifying the security groups associated with a cluster do not
        /// need a reboot. However, modifying parameter group requires a reboot for parameters to take effect. For more information about managing
        /// clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon Redshift Clusters</a> in the
        /// <i>Amazon Redshift Management Guide</i> </para> <para>You can also change node type and the number of nodes to scale up or down the cluster.
        /// When resizing a cluster, you must specify both the number of nodes and the node type even if one of the parameters does not change. If you
        /// specify the same number of nodes and node type that are already configured for the cluster, an error is returned.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ModifyCluster service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.HsmConfigurationNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InsufficientClusterCapacityException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnauthorizedOperationException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.NumberOfNodesQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnsupportedOptionException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.HsmClientCertificateNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
		ModifyClusterResponse ModifyCluster(ModifyClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.ModifyCluster"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ModifyClusterResponse> ModifyClusterAsync(ModifyClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Modifies the parameters of a parameter group. </para> <para> For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon Redshift Parameter Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterParameterGroup service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ModifyClusterParameterGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterParameterGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
		ModifyClusterParameterGroupResponse ModifyClusterParameterGroup(ModifyClusterParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.ModifyClusterParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ModifyClusterParameterGroupResponse> ModifyClusterParameterGroupAsync(ModifyClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Modifies a cluster subnet group to include the specified list of VPC subnets. The operation replaces the existing list of subnets
        /// with the new list of subnets. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSubnetGroup service method
        /// on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ModifyClusterSubnetGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.SubnetAlreadyInUseException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnauthorizedOperationException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException" />
		ModifyClusterSubnetGroupResponse ModifyClusterSubnetGroup(ModifyClusterSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.ModifyClusterSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ModifyClusterSubnetGroupResponse> ModifyClusterSubnetGroupAsync(ModifyClusterSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Modifies an existing Amazon Redshift event notification subscription. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionCategoryNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionEventIdNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionSeverityNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SourceNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SNSNoAuthorizationException" />
        /// <exception cref="T:Amazon.Redshift.Model.SNSTopicArnNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SubscriptionNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.SNSInvalidTopicException" />
		ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.ModifyEventSubscription"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Modifies the number of days to retain automated snapshots in the destination region after they are copied from the source region.
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// ModifySnapshotCopyRetentionPeriod service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ModifySnapshotCopyRetentionPeriod service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.SnapshotCopyDisabledException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnauthorizedOperationException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
		ModifySnapshotCopyRetentionPeriodResponse ModifySnapshotCopyRetentionPeriod(ModifySnapshotCopyRetentionPeriodRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotCopyRetentionPeriod operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.ModifySnapshotCopyRetentionPeriod"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotCopyRetentionPeriod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ModifySnapshotCopyRetentionPeriodResponse> ModifySnapshotCopyRetentionPeriodAsync(ModifySnapshotCopyRetentionPeriodRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Allows you to purchase reserved nodes. Amazon Redshift offers a predefined set of reserved node offerings. You can purchase one of
        /// the offerings. You can call the DescribeReservedNodeOfferings API to obtain the available reserved node offerings. You can call this API by
        /// providing a specific reserved node offering and the number of nodes you want to reserve. </para> <para> For more information about managing
        /// parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing Reserved
        /// Nodes</a> in the <i>Amazon Redshift Management Guide</i> .
        /// 
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodeOffering service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the PurchaseReservedNodeOffering service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ReservedNodeAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ReservedNodeQuotaExceededException" />
		PurchaseReservedNodeOfferingResponse PurchaseReservedNodeOffering(PurchaseReservedNodeOfferingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedNodeOffering operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.PurchaseReservedNodeOffering"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodeOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PurchaseReservedNodeOfferingResponse> PurchaseReservedNodeOfferingAsync(PurchaseReservedNodeOfferingRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Reboots a cluster. This action is taken as soon as possible. It results in a momentary outage to the cluster, during which the
        /// cluster status is set to <c>rebooting</c> . A cluster event is created when the reboot is completed. Any pending cluster modifications (see
        /// ModifyCluster) are applied at this reboot. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon Redshift Clusters</a> in the <i>Amazon Redshift
        /// Management Guide</i> </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootCluster service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the RebootCluster service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
		RebootClusterResponse RebootCluster(RebootClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RebootCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.RebootCluster"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RebootClusterResponse> RebootClusterAsync(RebootClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Sets one or more parameters of the specified parameter group to their default values and sets the source values of the parameters to
        /// "engine-default". To reset the entire parameter group specify the <i>ResetAllParameters</i> parameter. For parameter changes to take effect
        /// you must reboot any associated clusters. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetClusterParameterGroup service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ResetClusterParameterGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterParameterGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
		ResetClusterParameterGroupResponse ResetClusterParameterGroup(ResetClusterParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.ResetClusterParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ResetClusterParameterGroupResponse> ResetClusterParameterGroupAsync(ResetClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates a new cluster from a snapshot. Amazon Redshift creates the resulting cluster with the same configuration as the original
        /// cluster from which the snapshot was created, except that the new cluster is created with the default cluster security and parameter group.
        /// After Amazon Redshift creates the cluster you can use the ModifyCluster API to associate a different security group and different parameter
        /// group with the restored cluster. </para> <para> If a snapshot is taken of a cluster in VPC, you can restore it only in VPC. In this case,
        /// you must provide a cluster subnet group where you want the cluster restored. If snapshot is taken of a cluster outside VPC, then you can
        /// restore it only outside VPC.</para> <para> For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon Redshift Snapshots</a> in the <i>Amazon Redshift
        /// Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromClusterSnapshot service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the RestoreFromClusterSnapshot service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidElasticIpException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.Redshift.Model.HsmConfigurationNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSnapshotStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.AccessToSnapshotDeniedException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidRestoreException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnauthorizedOperationException" />
        /// <exception cref="T:Amazon.Redshift.Model.InsufficientClusterCapacityException" />
        /// <exception cref="T:Amazon.Redshift.Model.NumberOfNodesQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.HsmClientCertificateNotFoundException" />
		RestoreFromClusterSnapshotResponse RestoreFromClusterSnapshot(RestoreFromClusterSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreFromClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.RestoreFromClusterSnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RestoreFromClusterSnapshotResponse> RestoreFromClusterSnapshotAsync(RestoreFromClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Revokes an ingress rule in an Amazon Redshift security group for a previously authorized IP range or Amazon EC2 security group. To
        /// add an ingress rule, see AuthorizeClusterSecurityGroupIngress. For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon Redshift Cluster Security Groups</a> in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// RevokeClusterSecurityGroupIngress service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the RevokeClusterSecurityGroupIngress service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.AuthorizationNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
		RevokeClusterSecurityGroupIngressResponse RevokeClusterSecurityGroupIngress(RevokeClusterSecurityGroupIngressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeClusterSecurityGroupIngress operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.RevokeClusterSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeClusterSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RevokeClusterSecurityGroupIngressResponse> RevokeClusterSecurityGroupIngressAsync(RevokeClusterSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Removes the ability of the specified AWS customer account to restore the specified snapshot. If the account is currently restoring
        /// the snapshot, the restore will run to completion. </para> <para> For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon Redshift Snapshots</a> in the <i>Amazon Redshift
        /// Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSnapshotAccess service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the RevokeSnapshotAccess service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.AccessToSnapshotDeniedException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.AuthorizationNotFoundException" />
		RevokeSnapshotAccessResponse RevokeSnapshotAccess(RevokeSnapshotAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSnapshotAccess operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.RevokeSnapshotAccess"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSnapshotAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RevokeSnapshotAccessResponse> RevokeSnapshotAccessAsync(RevokeSnapshotAccessRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Rotates the encryption keys for a cluster. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RotateEncryptionKey service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the RotateEncryptionKey service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
		RotateEncryptionKeyResponse RotateEncryptionKey(RotateEncryptionKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RotateEncryptionKey operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift.RotateEncryptionKey"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RotateEncryptionKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RotateEncryptionKeyResponse> RotateEncryptionKeyAsync(RotateEncryptionKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}
