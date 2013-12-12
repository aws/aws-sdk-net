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

using Amazon.RDS.Model;

namespace Amazon.RDS
{
    /// <summary>
    /// Interface for accessing AmazonRDS.
    /// 
    /// Amazon Relational Database Service <para> Amazon Relational Database Service (Amazon RDS) is a web service that makes it easier to set up,
    /// operate, and scale a relational database in the cloud. It provides cost-efficient, resizable capacity for an industry-standard relational
    /// database and manages common database administration tasks, freeing up developers to focus on what makes their applications and businesses
    /// unique. </para> <para> Amazon RDS gives you access to the capabilities of a familiar MySQL or Oracle database server. This means the code,
    /// applications, and tools you already use today with your existing MySQL or Oracle databases work with Amazon RDS without modification. Amazon
    /// RDS automatically backs up your database and maintains the database software that powers your DB instance. Amazon RDS is flexible: you can
    /// scale your database instance's compute resources and storage capacity to meet your application's demand. As with all Amazon Web Services,
    /// there are no up-front investments, and you pay only for the resources you use. </para> <para> This is an interface reference for Amazon RDS.
    /// It contains documentation for a programming or command line interface you can use to manage Amazon RDS. Note that Amazon RDS is
    /// asynchronous, which means that some interfaces may require techniques such as polling or callback functions to determine when a command has
    /// been applied. In this reference, the parameter descriptions indicate whether a command is applied immediately, on the next instance reboot,
    /// or during the maintenance window. For a summary of the Amazon RDS interfaces, go to <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Welcome.html#Welcome.Interfaces">Available RDS Interfaces</a> .
    /// </para>
    /// </summary>
	public partial interface IAmazonRDS : IDisposable
    {
 
        /// <summary>
        /// <para>Adds a source identifier to an existing RDS event notification subscription.</para>
        /// </summary>
        /// 
        /// <param name="addSourceIdentifierToSubscriptionRequest">Container for the necessary parameters to execute the
        /// AddSourceIdentifierToSubscription service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the AddSourceIdentifierToSubscription service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.SourceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.SubscriptionNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<AddSourceIdentifierToSubscriptionResponse> AddSourceIdentifierToSubscriptionAsync(AddSourceIdentifierToSubscriptionRequest addSourceIdentifierToSubscriptionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Adds metadata tags to an Amazon RDS resource. These tags can also be used with cost allocation reporting to track cost associated
        /// with Amazon RDS resources, or used in Condition statement in IAM policy for Amazon RDS.</para> <para>For an overview on tagging Amazon RDS
        /// resources, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging Amazon RDS Resources</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="addTagsToResourceRequest">Container for the necessary parameters to execute the AddTagsToResource service method on
        /// AmazonRDS.</param>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest addTagsToResourceRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Enables ingress to a DBSecurityGroup using one of two forms of authorization. First, EC2 or VPC security groups can be added to the
        /// DBSecurityGroup if the application using the database is running on EC2 or VPC instances. Second, IP ranges are available if the application
        /// accessing your database is running on the Internet. Required parameters for this API are one of CIDR range, EC2SecurityGroupId for VPC, or
        /// (EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId for non-VPC). </para> <para><b>NOTE:</b> You cannot authorize
        /// ingress from an EC2 security group in one Region to an Amazon RDS DB instance in another. You cannot authorize ingress from a VPC security
        /// group in one VPC to an Amazon RDS DB instance in another. </para> <para>For an overview of CIDR ranges, go to the <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Wikipedia Tutorial</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="authorizeDBSecurityGroupIngressRequest">Container for the necessary parameters to execute the AuthorizeDBSecurityGroupIngress
        /// service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the AuthorizeDBSecurityGroupIngress service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSecurityGroupStateException" />
        /// <exception cref="T:Amazon.RDS.Model.AuthorizationAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.AuthorizationQuotaExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<AuthorizeDBSecurityGroupIngressResponse> AuthorizeDBSecurityGroupIngressAsync(AuthorizeDBSecurityGroupIngressRequest authorizeDBSecurityGroupIngressRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Copies the specified DBSnapshot. The source DBSnapshot must be in the "available" state. </para>
        /// </summary>
        /// 
        /// <param name="copyDBSnapshotRequest">Container for the necessary parameters to execute the CopyDBSnapshot service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the CopyDBSnapshot service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSnapshotStateException" />
        /// <exception cref="T:Amazon.RDS.Model.SnapshotQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CopyDBSnapshotResponse> CopyDBSnapshotAsync(CopyDBSnapshotRequest copyDBSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates a new DB instance. </para>
        /// </summary>
        /// 
        /// <param name="createDBInstanceRequest">Container for the necessary parameters to execute the CreateDBInstance service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBInstance service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InstanceQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.StorageQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InsufficientDBInstanceCapacityException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateDBInstanceResponse> CreateDBInstanceAsync(CreateDBInstanceRequest createDBInstanceRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates a DB instance that acts as a read replica of a source DB instance. </para> <para> All read replica DB instances are created
        /// as Single-AZ deployments with backups disabled. All other DB instance attributes (including DB security groups and DB parameter groups) are
        /// inherited from the source DB instance, except as specified below. </para> <para><b>IMPORTANT:</b> The source DB instance must have backup
        /// retention enabled. </para>
        /// </summary>
        /// 
        /// <param name="createDBInstanceReadReplicaRequest">Container for the necessary parameters to execute the CreateDBInstanceReadReplica service
        /// method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBInstanceReadReplica service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSubnetGroupException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.RDS.Model.InstanceQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotAllowedException" />
        /// <exception cref="T:Amazon.RDS.Model.StorageQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBInstanceStateException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException" />
        /// <exception cref="T:Amazon.RDS.Model.InsufficientDBInstanceCapacityException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateDBInstanceReadReplicaResponse> CreateDBInstanceReadReplicaAsync(CreateDBInstanceReadReplicaRequest createDBInstanceReadReplicaRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates a new DB parameter group. </para> <para> A DB parameter group is initially created with the default parameters for the
        /// database engine used by the DB instance. To provide custom values for any of the parameters, you must modify the group after creating it
        /// using <i>ModifyDBParameterGroup</i> . Once you've created a DB parameter group, you need to associate it with your DB instance using
        /// <i>ModifyDBInstance</i> . When you associate a new DB parameter group with a running DB instance, you need to reboot the DB Instance for the
        /// new DB parameter group and associated settings to take effect. </para>
        /// </summary>
        /// 
        /// <param name="createDBParameterGroupRequest">Container for the necessary parameters to execute the CreateDBParameterGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBParameterGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupAlreadyExistsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateDBParameterGroupResponse> CreateDBParameterGroupAsync(CreateDBParameterGroupRequest createDBParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates a new DB security group. DB security groups control access to a DB instance. </para>
        /// </summary>
        /// 
        /// <param name="createDBSecurityGroupRequest">Container for the necessary parameters to execute the CreateDBSecurityGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBSecurityGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotSupportedException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupAlreadyExistsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateDBSecurityGroupResponse> CreateDBSecurityGroupAsync(CreateDBSecurityGroupRequest createDBSecurityGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates a DBSnapshot. The source DBInstance must be in "available" state. </para>
        /// </summary>
        /// 
        /// <param name="createDBSnapshotRequest">Container for the necessary parameters to execute the CreateDBSnapshot service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBSnapshot service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBInstanceStateException" />
        /// <exception cref="T:Amazon.RDS.Model.SnapshotQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotAlreadyExistsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateDBSnapshotResponse> CreateDBSnapshotAsync(CreateDBSnapshotRequest createDBSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates a new DB subnet group. DB subnet groups must contain at least one subnet in at least two AZs in the region. </para>
        /// </summary>
        /// 
        /// <param name="createDBSubnetGroupRequest">Container for the necessary parameters to execute the CreateDBSubnetGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBSubnetGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidSubnetException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateDBSubnetGroupResponse> CreateDBSubnetGroupAsync(CreateDBSubnetGroupRequest createDBSubnetGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Creates an RDS event notification subscription. This action requires a topic ARN (Amazon Resource Name) created by either the RDS
        /// console, the SNS console, or the SNS API. To obtain an ARN with SNS, you must create a topic in Amazon SNS and subscribe to the topic. The
        /// ARN is displayed in the SNS console.</para> <para>You can specify the type of source (SourceType) you want to be notified of, provide a list
        /// of RDS sources (SourceIds) that triggers the events, and provide a list of event categories (EventCategories) for events you want to be
        /// notified of. For example, you can specify SourceType = db-instance, SourceIds = mydbinstance1, mydbinstance2 and EventCategories =
        /// Availability, Backup.</para> <para>If you specify both the SourceType and SourceIds, such as SourceType = db-instance and SourceIdentifier =
        /// myDBInstance1, you will be notified of all the db-instance events for the specified source. If you specify a SourceType but do not specify a
        /// SourceIdentifier, you will receive notice of the events for that source type for all your RDS sources. If you do not specify either the
        /// SourceType nor the SourceIdentifier, you will be notified of events generated from all RDS sources belonging to your customer
        /// account.</para>
        /// </summary>
        /// 
        /// <param name="createEventSubscriptionRequest">Container for the necessary parameters to execute the CreateEventSubscription service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.SourceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.SNSTopicArnNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.SNSInvalidTopicException" />
        /// <exception cref="T:Amazon.RDS.Model.SubscriptionCategoryNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.SNSNoAuthorizationException" />
        /// <exception cref="T:Amazon.RDS.Model.EventSubscriptionQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.SubscriptionAlreadyExistException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest createEventSubscriptionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates a new option group. You can create up to 20 option groups. </para>
        /// </summary>
        /// 
        /// <param name="createOptionGroupRequest">Container for the necessary parameters to execute the CreateOptionGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateOptionGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupQuotaExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateOptionGroupResponse> CreateOptionGroupAsync(CreateOptionGroupRequest createOptionGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The DeleteDBInstance action deletes a previously provisioned DB instance. A successful response from the web service indicates the
        /// request was received correctly. When you delete a DB instance, all automated backups for that instance are deleted and cannot be recovered.
        /// Manual DB snapshots of the DB instance to be deleted are not deleted. </para> <para> If a final DB snapshot is requested the status of the
        /// RDS instance will be "deleting" until the DB snapshot is created. The API action <c>DescribeDBInstance</c> is used to monitor the status of
        /// this operation. The action cannot be canceled or reverted once submitted. </para>
        /// </summary>
        /// 
        /// <param name="deleteDBInstanceRequest">Container for the necessary parameters to execute the DeleteDBInstance service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DeleteDBInstance service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBInstanceStateException" />
        /// <exception cref="T:Amazon.RDS.Model.SnapshotQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotAlreadyExistsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteDBInstanceResponse> DeleteDBInstanceAsync(DeleteDBInstanceRequest deleteDBInstanceRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deletes a specified DBParameterGroup. The DBParameterGroup cannot be associated with any RDS instances to be deleted. </para>
        /// <para><b>NOTE:</b> The specified DB parameter group cannot be associated with any DB instances. </para>
        /// </summary>
        /// 
        /// <param name="deleteDBParameterGroupRequest">Container for the necessary parameters to execute the DeleteDBParameterGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBParameterGroupStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteDBParameterGroupResponse> DeleteDBParameterGroupAsync(DeleteDBParameterGroupRequest deleteDBParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deletes a DB security group. </para> <para><b>NOTE:</b>The specified DB security group must not be associated with any DB
        /// instances.</para>
        /// </summary>
        /// 
        /// <param name="deleteDBSecurityGroupRequest">Container for the necessary parameters to execute the DeleteDBSecurityGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSecurityGroupStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteDBSecurityGroupResponse> DeleteDBSecurityGroupAsync(DeleteDBSecurityGroupRequest deleteDBSecurityGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deletes a DBSnapshot. If the snapshot is being copied, the copy operation is terminated. </para> <para><b>NOTE:</b>The DBSnapshot
        /// must be in the available state to be deleted.</para>
        /// </summary>
        /// 
        /// <param name="deleteDBSnapshotRequest">Container for the necessary parameters to execute the DeleteDBSnapshot service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DeleteDBSnapshot service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSnapshotStateException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteDBSnapshotResponse> DeleteDBSnapshotAsync(DeleteDBSnapshotRequest deleteDBSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deletes a DB subnet group. </para> <para><b>NOTE:</b>The specified database subnet group must not be associated with any DB
        /// instances.</para>
        /// </summary>
        /// 
        /// <param name="deleteDBSubnetGroupRequest">Container for the necessary parameters to execute the DeleteDBSubnetGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSubnetGroupStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSubnetStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteDBSubnetGroupResponse> DeleteDBSubnetGroupAsync(DeleteDBSubnetGroupRequest deleteDBSubnetGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Deletes an RDS event notification subscription.</para>
        /// </summary>
        /// 
        /// <param name="deleteEventSubscriptionRequest">Container for the necessary parameters to execute the DeleteEventSubscription service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.SubscriptionNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidEventSubscriptionStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest deleteEventSubscriptionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deletes an existing option group. </para>
        /// </summary>
        /// 
        /// <param name="deleteOptionGroupRequest">Container for the necessary parameters to execute the DeleteOptionGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.InvalidOptionGroupStateException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteOptionGroupResponse> DeleteOptionGroupAsync(DeleteOptionGroupRequest deleteOptionGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of the available DB engines. </para>
        /// </summary>
        /// 
        /// <param name="describeDBEngineVersionsRequest">Container for the necessary parameters to execute the DescribeDBEngineVersions service method
        /// on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by AmazonRDS.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeDBEngineVersionsResponse> DescribeDBEngineVersionsAsync(DescribeDBEngineVersionsRequest describeDBEngineVersionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns information about provisioned RDS instances. This API supports pagination. </para>
        /// </summary>
        /// 
        /// <param name="describeDBInstancesRequest">Container for the necessary parameters to execute the DescribeDBInstances service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(DescribeDBInstancesRequest describeDBInstancesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of DB log files for the DB instance. </para>
        /// </summary>
        /// 
        /// <param name="describeDBLogFilesRequest">Container for the necessary parameters to execute the DescribeDBLogFiles service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBLogFiles service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeDBLogFilesResponse> DescribeDBLogFilesAsync(DescribeDBLogFilesRequest describeDBLogFilesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of <c>DBParameterGroup</c> descriptions. If a <c>DBParameterGroupName</c> is specified, the list will contain only the
        /// description of the specified DB parameter group. </para>
        /// </summary>
        /// 
        /// <param name="describeDBParameterGroupsRequest">Container for the necessary parameters to execute the DescribeDBParameterGroups service
        /// method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeDBParameterGroupsResponse> DescribeDBParameterGroupsAsync(DescribeDBParameterGroupsRequest describeDBParameterGroupsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns the detailed parameter list for a particular DB parameter group. </para>
        /// </summary>
        /// 
        /// <param name="describeDBParametersRequest">Container for the necessary parameters to execute the DescribeDBParameters service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBParameters service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeDBParametersResponse> DescribeDBParametersAsync(DescribeDBParametersRequest describeDBParametersRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of <c>DBSecurityGroup</c> descriptions. If a <c>DBSecurityGroupName</c> is specified, the list will contain only the
        /// descriptions of the specified DB security group. </para>
        /// </summary>
        /// 
        /// <param name="describeDBSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeDBSecurityGroups service method
        /// on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroupsAsync(DescribeDBSecurityGroupsRequest describeDBSecurityGroupsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns information about DB snapshots. This API supports pagination. </para>
        /// </summary>
        /// 
        /// <param name="describeDBSnapshotsRequest">Container for the necessary parameters to execute the DescribeDBSnapshots service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeDBSnapshotsResponse> DescribeDBSnapshotsAsync(DescribeDBSnapshotsRequest describeDBSnapshotsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of DBSubnetGroup descriptions. If a DBSubnetGroupName is specified, the list will contain only the descriptions of the
        /// specified DBSubnetGroup. </para> <para>For an overview of CIDR ranges, go to the <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Wikipedia Tutorial</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeDBSubnetGroupsRequest">Container for the necessary parameters to execute the DescribeDBSubnetGroups service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeDBSubnetGroupsResponse> DescribeDBSubnetGroupsAsync(DescribeDBSubnetGroupsRequest describeDBSubnetGroupsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns the default engine and system parameter information for the specified database engine. </para>
        /// </summary>
        /// 
        /// <param name="describeEngineDefaultParametersRequest">Container for the necessary parameters to execute the DescribeEngineDefaultParameters
        /// service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by AmazonRDS.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest describeEngineDefaultParametersRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Displays a list of categories for all event source types, or, if specified, for a specified source type. You can see a list of the
        /// event categories and source types in the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html"> Events</a> topic
        /// in the Amazon RDS User Guide.</para>
        /// </summary>
        /// 
        /// <param name="describeEventCategoriesRequest">Container for the necessary parameters to execute the DescribeEventCategories service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by AmazonRDS.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest describeEventCategoriesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns events related to DB instances, DB security groups, DB snapshots, and DB parameter groups for the past 14 days. Events
        /// specific to a particular DB instance, DB security group, database snapshot, or DB parameter group can be obtained by providing the name as a
        /// parameter. By default, the past hour of events are returned. </para>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonRDS.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest describeEventsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Lists all the subscription descriptions for a customer account. The description for a subscription includes SubscriptionName,
        /// SNSTopicARN, CustomerID, SourceType, SourceID, CreationTime, and Status. </para> <para>If you specify a SubscriptionName, lists the
        /// description for that subscription.</para>
        /// </summary>
        /// 
        /// <param name="describeEventSubscriptionsRequest">Container for the necessary parameters to execute the DescribeEventSubscriptions service
        /// method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.SubscriptionNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest describeEventSubscriptionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Describes all available options. </para>
        /// </summary>
        /// 
        /// <param name="describeOptionGroupOptionsRequest">Container for the necessary parameters to execute the DescribeOptionGroupOptions service
        /// method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeOptionGroupOptions service method, as returned by AmazonRDS.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeOptionGroupOptionsResponse> DescribeOptionGroupOptionsAsync(DescribeOptionGroupOptionsRequest describeOptionGroupOptionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Describes the available option groups. </para>
        /// </summary>
        /// 
        /// <param name="describeOptionGroupsRequest">Container for the necessary parameters to execute the DescribeOptionGroups service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeOptionGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeOptionGroupsResponse> DescribeOptionGroupsAsync(DescribeOptionGroupsRequest describeOptionGroupsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of orderable DB instance options for the specified engine. </para>
        /// </summary>
        /// 
        /// <param name="describeOrderableDBInstanceOptionsRequest">Container for the necessary parameters to execute the
        /// DescribeOrderableDBInstanceOptions service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeOrderableDBInstanceOptions service method, as returned by AmazonRDS.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeOrderableDBInstanceOptionsResponse> DescribeOrderableDBInstanceOptionsAsync(DescribeOrderableDBInstanceOptionsRequest describeOrderableDBInstanceOptionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns information about reserved DB instances for this account, or about a specified reserved DB instance. </para>
        /// </summary>
        /// 
        /// <param name="describeReservedDBInstancesRequest">Container for the necessary parameters to execute the DescribeReservedDBInstances service
        /// method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.ReservedDBInstanceNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeReservedDBInstancesResponse> DescribeReservedDBInstancesAsync(DescribeReservedDBInstancesRequest describeReservedDBInstancesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Lists available reserved DB instance offerings. </para>
        /// </summary>
        /// 
        /// <param name="describeReservedDBInstancesOfferingsRequest">Container for the necessary parameters to execute the
        /// DescribeReservedDBInstancesOfferings service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.ReservedDBInstancesOfferingNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeReservedDBInstancesOfferingsResponse> DescribeReservedDBInstancesOfferingsAsync(DescribeReservedDBInstancesOfferingsRequest describeReservedDBInstancesOfferingsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Downloads the last line of the specified log file. </para>
        /// </summary>
        /// 
        /// <param name="downloadDBLogFilePortionRequest">Container for the necessary parameters to execute the DownloadDBLogFilePortion service method
        /// on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DownloadDBLogFilePortion service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DownloadDBLogFilePortionResponse> DownloadDBLogFilePortionAsync(DownloadDBLogFilePortionRequest downloadDBLogFilePortionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Lists all tags on an Amazon RDS resource.</para> <para>For an overview on tagging an Amazon RDS resource, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging Amazon RDS Resources</a> .</para>
        /// </summary>
        /// 
        /// <param name="listTagsForResourceRequest">Container for the necessary parameters to execute the ListTagsForResource service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest listTagsForResourceRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Modify settings for a DB instance. You can change one or more database configuration parameters by specifying these parameters and
        /// the new values in the request. </para>
        /// </summary>
        /// 
        /// <param name="modifyDBInstanceRequest">Container for the necessary parameters to execute the ModifyDBInstance service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyDBInstance service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.StorageQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBInstanceStateException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSecurityGroupStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InsufficientDBInstanceCapacityException" />
        /// <exception cref="T:Amazon.RDS.Model.DBUpgradeDependencyFailureException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ModifyDBInstanceResponse> ModifyDBInstanceAsync(ModifyDBInstanceRequest modifyDBInstanceRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Modifies the parameters of a DB parameter group. To modify more than one parameter, submit a list of the following:
        /// <c>ParameterName</c> ,
        /// <c>ParameterValue</c> , and <c>ApplyMethod</c> . A maximum of 20 parameters can be modified in a single request. </para>
        /// <para><b>NOTE:</b> The apply-immediate method can be used only for dynamic parameters; the pending-reboot method can be used with MySQL and
        /// Oracle DB instances for either dynamic or static parameters. For Microsoft SQL Server DB instances, the pending-reboot method can be used
        /// only for static parameters. </para>
        /// </summary>
        /// 
        /// <param name="modifyDBParameterGroupRequest">Container for the necessary parameters to execute the ModifyDBParameterGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyDBParameterGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBParameterGroupStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ModifyDBParameterGroupResponse> ModifyDBParameterGroupAsync(ModifyDBParameterGroupRequest modifyDBParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Modifies an existing DB subnet group. DB subnet groups must contain at least one subnet in at least two AZs in the region. </para>
        /// </summary>
        /// 
        /// <param name="modifyDBSubnetGroupRequest">Container for the necessary parameters to execute the ModifyDBSubnetGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyDBSubnetGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.SubnetAlreadyInUseException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidSubnetException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ModifyDBSubnetGroupResponse> ModifyDBSubnetGroupAsync(ModifyDBSubnetGroupRequest modifyDBSubnetGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Modifies an existing RDS event notification subscription. Note that you cannot modify the source identifiers using this call; to
        /// change source identifiers for a subscription, use the AddSourceIdentifierToSubscription and RemoveSourceIdentifierFromSubscription
        /// calls.</para> <para>You can see a list of the event categories for a given SourceType in the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">Events</a> topic in the Amazon RDS User Guide or by using the
        /// <b>DescribeEventCategories</b> action.</para>
        /// </summary>
        /// 
        /// <param name="modifyEventSubscriptionRequest">Container for the necessary parameters to execute the ModifyEventSubscription service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.SNSTopicArnNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.SNSInvalidTopicException" />
        /// <exception cref="T:Amazon.RDS.Model.SubscriptionCategoryNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.SubscriptionNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.SNSNoAuthorizationException" />
        /// <exception cref="T:Amazon.RDS.Model.EventSubscriptionQuotaExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest modifyEventSubscriptionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Modifies an existing option group. </para>
        /// </summary>
        /// 
        /// <param name="modifyOptionGroupRequest">Container for the necessary parameters to execute the ModifyOptionGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyOptionGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.InvalidOptionGroupStateException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ModifyOptionGroupResponse> ModifyOptionGroupAsync(ModifyOptionGroupRequest modifyOptionGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Promotes a read replica DB instance to a standalone DB instance. </para>
        /// </summary>
        /// 
        /// <param name="promoteReadReplicaRequest">Container for the necessary parameters to execute the PromoteReadReplica service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the PromoteReadReplica service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBInstanceStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PromoteReadReplicaResponse> PromoteReadReplicaAsync(PromoteReadReplicaRequest promoteReadReplicaRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Purchases a reserved DB instance offering. </para>
        /// </summary>
        /// 
        /// <param name="purchaseReservedDBInstancesOfferingRequest">Container for the necessary parameters to execute the
        /// PurchaseReservedDBInstancesOffering service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the PurchaseReservedDBInstancesOffering service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.ReservedDBInstancesOfferingNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.ReservedDBInstanceQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.ReservedDBInstanceAlreadyExistsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PurchaseReservedDBInstancesOfferingResponse> PurchaseReservedDBInstancesOfferingAsync(PurchaseReservedDBInstancesOfferingRequest purchaseReservedDBInstancesOfferingRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Rebooting a DB instance restarts the database engine service. A reboot also applies to the DB instance any modifications to the
        /// associated DB parameter group that were pending. Rebooting a DB instance results in a momentary outage of the instance, during which the DB
        /// instance status is set to rebooting. If the RDS instance is configured for MultiAZ, it is possible that the reboot will be conducted through
        /// a failover. An Amazon RDS event is created when the reboot is completed. </para> <para> If your DB instance is deployed in multiple
        /// Availability Zones, you can force a failover from one AZ to the other during the reboot. You might force a failover to test the availability
        /// of your DB instance deployment or to restore operations to the original AZ after a failover occurs. </para> <para> The time required to
        /// reboot is a function of the specific database engine's crash recovery process. To improve the reboot time, we recommend that you reduce
        /// database activities as much as possible during the reboot process to reduce rollback activity for in-transit transactions. </para>
        /// </summary>
        /// 
        /// <param name="rebootDBInstanceRequest">Container for the necessary parameters to execute the RebootDBInstance service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the RebootDBInstance service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBInstanceStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RebootDBInstanceResponse> RebootDBInstanceAsync(RebootDBInstanceRequest rebootDBInstanceRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Removes a source identifier from an existing RDS event notification subscription.</para>
        /// </summary>
        /// 
        /// <param name="removeSourceIdentifierFromSubscriptionRequest">Container for the necessary parameters to execute the
        /// RemoveSourceIdentifierFromSubscription service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the RemoveSourceIdentifierFromSubscription service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.SourceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.SubscriptionNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RemoveSourceIdentifierFromSubscriptionResponse> RemoveSourceIdentifierFromSubscriptionAsync(RemoveSourceIdentifierFromSubscriptionRequest removeSourceIdentifierFromSubscriptionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Removes metadata tags from an Amazon RDS resource.</para> <para>For an overview on tagging an Amazon RDS resource, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging Amazon RDS Resources</a> .</para>
        /// </summary>
        /// 
        /// <param name="removeTagsFromResourceRequest">Container for the necessary parameters to execute the RemoveTagsFromResource service method on
        /// AmazonRDS.</param>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest removeTagsFromResourceRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Modifies the parameters of a DB parameter group to the engine/system default value. To reset specific parameters submit a list of the
        /// following: <c>ParameterName</c> and <c>ApplyMethod</c> . To reset the entire DB parameter group, specify the <c>DBParameterGroup</c> name
        /// and <c>ResetAllParameters</c> parameters. When resetting the entire group, dynamic parameters are updated immediately and static parameters
        /// are set to <c>pending-reboot</c> to take effect on the next DB instance restart or <c>RebootDBInstance</c> request. </para>
        /// </summary>
        /// 
        /// <param name="resetDBParameterGroupRequest">Container for the necessary parameters to execute the ResetDBParameterGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the ResetDBParameterGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBParameterGroupStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ResetDBParameterGroupResponse> ResetDBParameterGroupAsync(ResetDBParameterGroupRequest resetDBParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates a new DB instance from a DB snapshot. The target database is created from the source database restore point with the same
        /// configuration as the original source database, except that the new RDS instance is created with the default security group. </para>
        /// </summary>
        /// 
        /// <param name="restoreDBInstanceFromDBSnapshotRequest">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot
        /// service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the RestoreDBInstanceFromDBSnapshot service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.InvalidRestoreException" />
        /// <exception cref="T:Amazon.RDS.Model.InstanceQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.StorageQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSnapshotStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InsufficientDBInstanceCapacityException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RestoreDBInstanceFromDBSnapshotResponse> RestoreDBInstanceFromDBSnapshotAsync(RestoreDBInstanceFromDBSnapshotRequest restoreDBInstanceFromDBSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Restores a DB instance to an arbitrary point-in-time. Users can restore to any point in time before the latestRestorableTime for up
        /// to backupRetentionPeriod days. The target database is created from the source database with the same configuration as the original database
        /// except that the DB instance is created with the default DB security group. </para>
        /// </summary>
        /// 
        /// <param name="restoreDBInstanceToPointInTimeRequest">Container for the necessary parameters to execute the RestoreDBInstanceToPointInTime
        /// service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the RestoreDBInstanceToPointInTime service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.PointInTimeRestoreNotEnabledException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidRestoreException" />
        /// <exception cref="T:Amazon.RDS.Model.InstanceQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.StorageQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBInstanceStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InsufficientDBInstanceCapacityException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RestoreDBInstanceToPointInTimeResponse> RestoreDBInstanceToPointInTimeAsync(RestoreDBInstanceToPointInTimeRequest restoreDBInstanceToPointInTimeRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Revokes ingress from a DBSecurityGroup for previously authorized IP ranges or EC2 or VPC Security Groups. Required parameters for
        /// this API are one of CIDRIP, EC2SecurityGroupId for VPC, or (EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId).
        /// </para>
        /// </summary>
        /// 
        /// <param name="revokeDBSecurityGroupIngressRequest">Container for the necessary parameters to execute the RevokeDBSecurityGroupIngress service
        /// method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the RevokeDBSecurityGroupIngress service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSecurityGroupStateException" />
        /// <exception cref="T:Amazon.RDS.Model.AuthorizationNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RevokeDBSecurityGroupIngressResponse> RevokeDBSecurityGroupIngressAsync(RevokeDBSecurityGroupIngressRequest revokeDBSecurityGroupIngressRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
