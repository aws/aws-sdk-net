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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.RDS.Model;

namespace Amazon.RDS
{
    /// <summary>
    /// Interface for accessing RDS
    ///
    /// Amazon Relational Database Service 
    /// <para>
    ///  
    /// </para>
    ///  
    /// <para>
    /// Amazon Relational Database Service (Amazon RDS) is a web service that makes it easier
    /// to set up, operate, and scale a relational database in the cloud. It provides cost-efficient,
    /// resizeable capacity for an industry-standard relational database and manages common
    /// database administration tasks, freeing up developers to focus on what makes their
    /// applications and businesses unique.
    /// </para>
    ///  
    /// <para>
    /// Amazon RDS gives you access to the capabilities of a MySQL, MariaDB, PostgreSQL, Microsoft
    /// SQL Server, Oracle, or Amazon Aurora database server. These capabilities mean that
    /// the code, applications, and tools you already use today with your existing databases
    /// work with Amazon RDS without modification. Amazon RDS automatically backs up your
    /// database and maintains the database software that powers your DB instance. Amazon
    /// RDS is flexible: you can scale your database instance's compute resources and storage
    /// capacity to meet your application's demand. As with all Amazon Web Services, there
    /// are no up-front investments, and you pay only for the resources you use.
    /// </para>
    ///  
    /// <para>
    /// This interface reference for Amazon RDS contains documentation for a programming or
    /// command line interface you can use to manage Amazon RDS. Note that Amazon RDS is asynchronous,
    /// which means that some interfaces might require techniques such as polling or callback
    /// functions to determine when a command has been applied. In this reference, the parameter
    /// descriptions indicate whether a command is applied immediately, on the next instance
    /// reboot, or during the maintenance window. The reference structure is as follows, and
    /// we list following some related topics from the user guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>Amazon RDS API Reference</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For the alphabetical list of API actions, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_Operations.html">API
    /// Actions</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For the alphabetical list of data types, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_Types.html">Data
    /// Types</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a list of common query parameters, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/APIReference/CommonParameters.html">Common
    /// Parameters</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For descriptions of the error codes, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/APIReference/CommonErrors.html">Common
    /// Errors</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Amazon RDS User Guide</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For a summary of the Amazon RDS interfaces, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Welcome.html#Welcome.Interfaces">Available
    /// RDS Interfaces</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For more information about how to use the Query API, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Using_the_Query_API.html">Using
    /// the Query API</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonRDS : IDisposable
    {

        
        #region  AddSourceIdentifierToSubscription


        /// <summary>
        /// Adds a source identifier to an existing RDS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription service method.</param>
        /// 
        /// <returns>The response from the AddSourceIdentifierToSubscription service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        AddSourceIdentifierToSubscriptionResponse AddSourceIdentifierToSubscription(AddSourceIdentifierToSubscriptionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AddSourceIdentifierToSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddSourceIdentifierToSubscriptionResponse> AddSourceIdentifierToSubscriptionAsync(AddSourceIdentifierToSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddTagsToResource


        /// <summary>
        /// Adds metadata tags to an Amazon RDS resource. These tags can also be used with cost
        /// allocation reporting to track cost associated with Amazon RDS resources, or used in
        /// a Condition statement in an IAM policy for Amazon RDS.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging Amazon RDS resources, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging
        /// Amazon RDS Resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ApplyPendingMaintenanceAction


        /// <summary>
        /// Applies a pending maintenance action to a resource (for example, to a DB instance).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction service method.</param>
        /// 
        /// <returns>The response from the ApplyPendingMaintenanceAction service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        ApplyPendingMaintenanceActionResponse ApplyPendingMaintenanceAction(ApplyPendingMaintenanceActionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ApplyPendingMaintenanceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ApplyPendingMaintenanceActionResponse> ApplyPendingMaintenanceActionAsync(ApplyPendingMaintenanceActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AuthorizeDBSecurityGroupIngress


        /// <summary>
        /// Enables ingress to a DBSecurityGroup using one of two forms of authorization. First,
        /// EC2 or VPC security groups can be added to the DBSecurityGroup if the application
        /// using the database is running on EC2 or VPC instances. Second, IP ranges are available
        /// if the application accessing your database is running on the Internet. Required parameters
        /// for this API are one of CIDR range, EC2SecurityGroupId for VPC, or (EC2SecurityGroupOwnerId
        /// and either EC2SecurityGroupName or EC2SecurityGroupId for non-VPC).
        /// 
        ///  <note> 
        /// <para>
        /// You cannot authorize ingress from an EC2 security group in one region to an Amazon
        /// RDS DB instance in another. You cannot authorize ingress from a VPC security group
        /// in one VPC to an Amazon RDS DB instance in another.
        /// </para>
        ///  </note> 
        /// <para>
        /// For an overview of CIDR ranges, go to the <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Wikipedia
        /// Tutorial</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeDBSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the AuthorizeDBSecurityGroupIngress service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationAlreadyExistsException">
        /// The specified CIDRIP or EC2 security group is already authorized for the specified
        /// DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.AuthorizationQuotaExceededException">
        /// DB security group authorization quota has been reached.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group does not allow deletion.
        /// </exception>
        AuthorizeDBSecurityGroupIngressResponse AuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeDBSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeDBSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AuthorizeDBSecurityGroupIngressResponse> AuthorizeDBSecurityGroupIngressAsync(AuthorizeDBSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CopyDBClusterSnapshot


        /// <summary>
        /// Creates a snapshot of a DB cluster. For more information on Amazon Aurora, see <a
        /// href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CopyDBClusterSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotAlreadyExistsException">
        /// User already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        CopyDBClusterSnapshotResponse CopyDBClusterSnapshot(CopyDBClusterSnapshotRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CopyDBClusterSnapshotResponse> CopyDBClusterSnapshotAsync(CopyDBClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CopyDBParameterGroup


        /// <summary>
        /// Copies the specified DB parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CopyDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB parameter groups.
        /// </exception>
        CopyDBParameterGroupResponse CopyDBParameterGroup(CopyDBParameterGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CopyDBParameterGroupResponse> CopyDBParameterGroupAsync(CopyDBParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CopyDBSnapshot


        /// <summary>
        /// Copies the specified DB snapshot. The source DB snapshot must be in the "available"
        /// state.
        /// 
        ///  
        /// <para>
        /// If you are copying from a shared manual DB snapshot, the <code>SourceDBSnapshotIdentifier</code>
        /// must be the ARN of the shared DB snapshot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBSnapshot service method.</param>
        /// 
        /// <returns>The response from the CopyDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <i>DBSnapshotIdentifier</i> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        CopyDBSnapshotResponse CopyDBSnapshot(CopyDBSnapshotRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CopyDBSnapshotResponse> CopyDBSnapshotAsync(CopyDBSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CopyOptionGroup


        /// <summary>
        /// Copies the specified option group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyOptionGroup service method.</param>
        /// 
        /// <returns>The response from the CopyOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.OptionGroupAlreadyExistsException">
        /// The option group you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupQuotaExceededException">
        /// The quota of 20 option groups was exceeded for this AWS account.
        /// </exception>
        CopyOptionGroupResponse CopyOptionGroup(CopyOptionGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CopyOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CopyOptionGroupResponse> CopyOptionGroupAsync(CopyOptionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDBCluster


        /// <summary>
        /// Creates a new Amazon Aurora DB cluster.
        /// 
        ///  
        /// <para>
        /// You can use the <code>ReplicationSourceIdentifier</code> parameter to create the DB
        /// cluster as a Read Replica of another DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBCluster service method.</param>
        /// 
        /// <returns>The response from the CreateDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// User already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <i>DBClusterParameterGroupName</i> does not refer to an existing DB Cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// User attempted to create a new DB cluster and the user has already reached the maximum
        /// allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You may be able to
        /// resolve this error by updating your subnet group to use different Availability Zones
        /// that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        CreateDBClusterResponse CreateDBCluster(CreateDBClusterRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDBClusterResponse> CreateDBClusterAsync(CreateDBClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDBClusterParameterGroup


        /// <summary>
        /// Creates a new DB cluster parameter group.
        /// 
        ///  
        /// <para>
        /// Parameters in a DB cluster parameter group apply to all of the instances in a DB cluster.
        /// </para>
        ///  
        /// <para>
        ///  A DB cluster parameter group is initially created with the default parameters for
        /// the database engine used by instances in the DB cluster. To provide custom values
        /// for any of the parameters, you must modify the group after creating it using <a>ModifyDBClusterParameterGroup</a>.
        /// Once you've created a DB cluster parameter group, you need to associate it with your
        /// DB cluster using <a>ModifyDBCluster</a>. When you associate a new DB cluster parameter
        /// group with a running DB cluster, you need to reboot the DB instances in the DB cluster
        /// without failover for the new DB cluster parameter group and associated settings to
        /// take effect. 
        /// </para>
        ///  <important> 
        /// <para>
        /// After you create a DB cluster parameter group, you should wait at least 5 minutes
        /// before creating your first DB cluster that uses that DB cluster parameter group as
        /// the default parameter group. This allows Amazon RDS to fully complete the create action
        /// before the DB cluster parameter group is used as the default for a new DB cluster.
        /// This is especially important for parameters that are critical when creating the default
        /// database for a DB cluster, such as the character set for the default database defined
        /// by the <code>character_set_database</code> parameter. You can use the <i>Parameter
        /// Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon RDS
        /// console</a> or the <a>DescribeDBClusterParameters</a> command to verify that your
        /// DB cluster parameter group has been created or modified.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB parameter groups.
        /// </exception>
        CreateDBClusterParameterGroupResponse CreateDBClusterParameterGroup(CreateDBClusterParameterGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDBClusterParameterGroupResponse> CreateDBClusterParameterGroupAsync(CreateDBClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDBClusterSnapshot


        /// <summary>
        /// Creates a snapshot of a DB cluster. For more information on Amazon Aurora, see <a
        /// href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateDBClusterSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotAlreadyExistsException">
        /// User already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        CreateDBClusterSnapshotResponse CreateDBClusterSnapshot(CreateDBClusterSnapshotRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDBClusterSnapshotResponse> CreateDBClusterSnapshotAsync(CreateDBClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDBInstance


        /// <summary>
        /// Creates a new DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstance service method.</param>
        /// 
        /// <returns>The response from the CreateDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// Specified CIDRIP or EC2 security group is not authorized for the specified DB security
        /// group.
        /// 
        ///  
        /// <para>
        /// RDS may not also be authorized via IAM to perform necessary actions on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// User already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <i>Domain</i> does not refer to an existing Active Directory Domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InstanceQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// Specified DB instance class is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// <i>StorageType</i> specified cannot be associated with the DB Instance.
        /// </exception>
        CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDBInstanceResponse> CreateDBInstanceAsync(CreateDBInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDBInstanceReadReplica


        /// <summary>
        /// Creates a DB instance for a DB instance running MySQL, MariaDB, or PostgreSQL that
        /// acts as a Read Replica of a source DB instance.
        /// 
        ///  
        /// <para>
        /// All Read Replica DB instances are created as Single-AZ deployments with backups disabled.
        /// All other DB instance attributes (including DB security groups and DB parameter groups)
        /// are inherited from the source DB instance, except as specified below.
        /// </para>
        ///  <important> 
        /// <para>
        /// The source DB instance must have backup retention enabled.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstanceReadReplica service method.</param>
        /// 
        /// <returns>The response from the CreateDBInstanceReadReplica service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// User already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotAllowedException">
        /// Indicates that the DBSubnetGroup should not be specified while creating read replicas
        /// that lie in the same region as the source instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InstanceQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// Specified DB instance class is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupException">
        /// Indicates the DBSubnetGroup does not belong to the same VPC as that of an existing
        /// cross region read replica of the same source instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// <i>StorageType</i> specified cannot be associated with the DB Instance.
        /// </exception>
        CreateDBInstanceReadReplicaResponse CreateDBInstanceReadReplica(CreateDBInstanceReadReplicaRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstanceReadReplica operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstanceReadReplica operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDBInstanceReadReplicaResponse> CreateDBInstanceReadReplicaAsync(CreateDBInstanceReadReplicaRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDBParameterGroup


        /// <summary>
        /// Creates a new DB parameter group.
        /// 
        ///  
        /// <para>
        ///  A DB parameter group is initially created with the default parameters for the database
        /// engine used by the DB instance. To provide custom values for any of the parameters,
        /// you must modify the group after creating it using <i>ModifyDBParameterGroup</i>. Once
        /// you've created a DB parameter group, you need to associate it with your DB instance
        /// using <i>ModifyDBInstance</i>. When you associate a new DB parameter group with a
        /// running DB instance, you need to reboot the DB instance without failover for the new
        /// DB parameter group and associated settings to take effect. 
        /// </para>
        ///  <important> 
        /// <para>
        /// After you create a DB parameter group, you should wait at least 5 minutes before creating
        /// your first DB instance that uses that DB parameter group as the default parameter
        /// group. This allows Amazon RDS to fully complete the create action before the parameter
        /// group is used as the default for a new DB instance. This is especially important for
        /// parameters that are critical when creating the default database for a DB instance,
        /// such as the character set for the default database defined by the <code>character_set_database</code>
        /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
        /// RDS console</a> or the <i>DescribeDBParameters</i> command to verify that your DB
        /// parameter group has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB parameter groups.
        /// </exception>
        CreateDBParameterGroupResponse CreateDBParameterGroup(CreateDBParameterGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDBParameterGroupResponse> CreateDBParameterGroupAsync(CreateDBParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDBSecurityGroup


        /// <summary>
        /// Creates a new DB security group. DB security groups control access to a DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBSecurityGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupAlreadyExistsException">
        /// A DB security group with the name specified in <i>DBSecurityGroupName</i> already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotSupportedException">
        /// A DB security group is not allowed for this action.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB security groups.
        /// </exception>
        CreateDBSecurityGroupResponse CreateDBSecurityGroup(CreateDBSecurityGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDBSecurityGroupResponse> CreateDBSecurityGroupAsync(CreateDBSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDBSnapshot


        /// <summary>
        /// Creates a DBSnapshot. The source DBInstance must be in "available" state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <i>DBSnapshotIdentifier</i> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        CreateDBSnapshotResponse CreateDBSnapshot(CreateDBSnapshotRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDBSnapshotResponse> CreateDBSnapshotAsync(CreateDBSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDBSubnetGroup


        /// <summary>
        /// Creates a new DB subnet group. DB subnet groups must contain at least one subnet in
        /// at least two AZs in the region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBSubnetGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupAlreadyExistsException">
        /// <i>DBSubnetGroupName</i> is already used by an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB subnet groups.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetQuotaExceededException">
        /// Request would result in user exceeding the allowed number of subnets in a DB subnet
        /// groups.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        CreateDBSubnetGroupResponse CreateDBSubnetGroup(CreateDBSubnetGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDBSubnetGroupResponse> CreateDBSubnetGroupAsync(CreateDBSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEventSubscription


        /// <summary>
        /// Creates an RDS event notification subscription. This action requires a topic ARN (Amazon
        /// Resource Name) created by either the RDS console, the SNS console, or the SNS API.
        /// To obtain an ARN with SNS, you must create a topic in Amazon SNS and subscribe to
        /// the topic. The ARN is displayed in the SNS console.
        /// 
        ///  
        /// <para>
        /// You can specify the type of source (SourceType) you want to be notified of, provide
        /// a list of RDS sources (SourceIds) that triggers the events, and provide a list of
        /// event categories (EventCategories) for events you want to be notified of. For example,
        /// you can specify SourceType = db-instance, SourceIds = mydbinstance1, mydbinstance2
        /// and EventCategories = Availability, Backup.
        /// </para>
        ///  
        /// <para>
        /// If you specify both the SourceType and SourceIds, such as SourceType = db-instance
        /// and SourceIdentifier = myDBInstance1, you will be notified of all the db-instance
        /// events for the specified source. If you specify a SourceType but do not specify a
        /// SourceIdentifier, you will receive notice of the events for that source type for all
        /// your RDS sources. If you do not specify either the SourceType nor the SourceIdentifier,
        /// you will be notified of events generated from all RDS sources belonging to your customer
        /// account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.EventSubscriptionQuotaExceededException">
        /// You have reached the maximum number of event subscriptions.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SNSInvalidTopicException">
        /// SNS has responded that there is a problem with the SND topic specified.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the SNS topic ARN.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SNSTopicArnNotFoundException">
        /// The SNS topic ARN does not exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionAlreadyExistException">
        /// The supplied subscription name already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionCategoryNotFoundException">
        /// The supplied category does not exist.
        /// </exception>
        CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateOptionGroup


        /// <summary>
        /// Creates a new option group. You can create up to 20 option groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOptionGroup service method.</param>
        /// 
        /// <returns>The response from the CreateOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.OptionGroupAlreadyExistsException">
        /// The option group you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupQuotaExceededException">
        /// The quota of 20 option groups was exceeded for this AWS account.
        /// </exception>
        CreateOptionGroupResponse CreateOptionGroup(CreateOptionGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateOptionGroupResponse> CreateOptionGroupAsync(CreateOptionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDBCluster


        /// <summary>
        /// The DeleteDBCluster action deletes a previously provisioned DB cluster. When you delete
        /// a DB cluster, all automated backups for that DB cluster are deleted and cannot be
        /// recovered. Manual DB cluster snapshots of the specified DB cluster are not deleted.
        /// 
        ///   
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotAlreadyExistsException">
        /// User already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        DeleteDBClusterResponse DeleteDBCluster(DeleteDBClusterRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDBClusterResponse> DeleteDBClusterAsync(DeleteDBClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDBClusterParameterGroup


        /// <summary>
        /// Deletes a specified DB cluster parameter group. The DB cluster parameter group to
        /// be deleted cannot be associated with any DB clusters.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group cannot be deleted because it is in use.
        /// </exception>
        DeleteDBClusterParameterGroupResponse DeleteDBClusterParameterGroup(DeleteDBClusterParameterGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDBClusterParameterGroupResponse> DeleteDBClusterParameterGroupAsync(DeleteDBClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDBClusterSnapshot


        /// <summary>
        /// Deletes a DB cluster snapshot. If the snapshot is being copied, the copy operation
        /// is terminated.
        /// 
        ///  <note> 
        /// <para>
        /// The DB cluster snapshot must be in the <code>available</code> state to be deleted.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteDBClusterSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        DeleteDBClusterSnapshotResponse DeleteDBClusterSnapshot(DeleteDBClusterSnapshotRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDBClusterSnapshotResponse> DeleteDBClusterSnapshotAsync(DeleteDBClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDBInstance


        /// <summary>
        /// The DeleteDBInstance action deletes a previously provisioned DB instance. When you
        /// delete a DB instance, all automated backups for that instance are deleted and cannot
        /// be recovered. Manual DB snapshots of the DB instance to be deleted by <code>DeleteDBInstance</code>
        /// are not deleted.
        /// 
        ///  
        /// <para>
        ///  If you request a final DB snapshot the status of the Amazon RDS DB instance is <code>deleting</code>
        /// until the DB snapshot is created. The API action <code>DescribeDBInstance</code> is
        /// used to monitor the status of this operation. The action cannot be canceled or reverted
        /// once submitted. 
        /// </para>
        ///  
        /// <para>
        /// Note that when a DB instance is in a failure state and has a status of <code>failed</code>,
        /// <code>incompatible-restore</code>, or <code>incompatible-network</code>, you can only
        /// delete it when the <code>SkipFinalSnapshot</code> parameter is set to <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// If the specified DB instance is part of an Amazon Aurora DB cluster, you cannot delete
        /// the DB instance if the following are true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The DB cluster is a Read Replica of another Amazon Aurora DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The DB instance is the only instance in the DB cluster.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To delete a DB instance in this case, first call the <a>PromoteReadReplicaDBCluster</a>
        /// API action to promote the DB cluster so it's no longer a Read Replica. After the promotion
        /// completes, then call the <code>DeleteDBInstance</code> API action to delete the final
        /// instance in the DB cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <i>DBSnapshotIdentifier</i> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDBInstanceResponse> DeleteDBInstanceAsync(DeleteDBInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDBParameterGroup


        /// <summary>
        /// Deletes a specified DBParameterGroup. The DBParameterGroup to be deleted cannot be
        /// associated with any DB instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group cannot be deleted because it is in use.
        /// </exception>
        DeleteDBParameterGroupResponse DeleteDBParameterGroup(DeleteDBParameterGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDBParameterGroupResponse> DeleteDBParameterGroupAsync(DeleteDBParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDBSecurityGroup


        /// <summary>
        /// Deletes a DB security group.
        /// 
        ///  <note> 
        /// <para>
        /// The specified DB security group must not be associated with any DB instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBSecurityGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group does not allow deletion.
        /// </exception>
        DeleteDBSecurityGroupResponse DeleteDBSecurityGroup(DeleteDBSecurityGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDBSecurityGroupResponse> DeleteDBSecurityGroupAsync(DeleteDBSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDBSnapshot


        /// <summary>
        /// Deletes a DBSnapshot. If the snapshot is being copied, the copy operation is terminated.
        /// 
        ///  <note> 
        /// <para>
        /// The DBSnapshot must be in the <code>available</code> state to be deleted.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot does not allow deletion.
        /// </exception>
        DeleteDBSnapshotResponse DeleteDBSnapshot(DeleteDBSnapshotRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDBSnapshotResponse> DeleteDBSnapshotAsync(DeleteDBSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDBSubnetGroup


        /// <summary>
        /// Deletes a DB subnet group.
        /// 
        ///  <note> 
        /// <para>
        /// The specified database subnet group must not be associated with any DB instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBSubnetGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetStateException">
        /// The DB subnet is not in the <i>available</i> state.
        /// </exception>
        DeleteDBSubnetGroupResponse DeleteDBSubnetGroup(DeleteDBSubnetGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDBSubnetGroupResponse> DeleteDBSubnetGroupAsync(DeleteDBSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEventSubscription


        /// <summary>
        /// Deletes an RDS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InvalidEventSubscriptionStateException">
        /// This error can occur if someone else is modifying a subscription. You should retry
        /// the action.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteOptionGroup


        /// <summary>
        /// Deletes an existing option group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptionGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InvalidOptionGroupStateException">
        /// The option group is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        DeleteOptionGroupResponse DeleteOptionGroup(DeleteOptionGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteOptionGroupResponse> DeleteOptionGroupAsync(DeleteOptionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAccountAttributes


        /// <summary>
        /// Lists all of the attributes for a customer account. The attributes include Amazon
        /// RDS quotas for the account, such as the number of DB instances allowed. The description
        /// for a quota includes the quota name, current usage toward that quota, and the quota's
        /// maximum value.
        /// 
        ///  
        /// <para>
        /// This command does not take any parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by RDS.</returns>
        DescribeAccountAttributesResponse DescribeAccountAttributes();


        /// <summary>
        /// Lists all of the attributes for a customer account. The attributes include Amazon
        /// RDS quotas for the account, such as the number of DB instances allowed. The description
        /// for a quota includes the quota name, current usage toward that quota, and the quota's
        /// maximum value.
        /// 
        ///  
        /// <para>
        /// This command does not take any parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by RDS.</returns>
        DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request);


        /// <summary>
        /// Lists all of the attributes for a customer account. The attributes include Amazon
        /// RDS quotas for the account, such as the number of DB instances allowed. The description
        /// for a quota includes the quota name, current usage toward that quota, and the quota's
        /// maximum value.
        /// 
        ///  
        /// <para>
        /// This command does not take any parameters.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by RDS.</returns>
        Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCertificates


        /// <summary>
        /// Lists the set of CA certificates provided by Amazon RDS for this AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificates service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <i>CertificateIdentifier</i> does not refer to an existing certificate.
        /// </exception>
        DescribeCertificatesResponse DescribeCertificates(DescribeCertificatesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeCertificatesResponse> DescribeCertificatesAsync(DescribeCertificatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBClusterParameterGroups


        /// <summary>
        /// Returns a list of <code>DBClusterParameterGroup</code> descriptions. If a <code>DBClusterParameterGroupName</code>
        /// parameter is specified, the list will contain only the description of the specified
        /// DB cluster parameter group. 
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameterGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        DescribeDBClusterParameterGroupsResponse DescribeDBClusterParameterGroups(DescribeDBClusterParameterGroupsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBClusterParameterGroupsResponse> DescribeDBClusterParameterGroupsAsync(DescribeDBClusterParameterGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBClusterParameters


        /// <summary>
        /// Returns the detailed parameter list for a particular DB cluster parameter group.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameters service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        DescribeDBClusterParametersResponse DescribeDBClusterParameters(DescribeDBClusterParametersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBClusterParametersResponse> DescribeDBClusterParametersAsync(DescribeDBClusterParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBClusters


        /// <summary>
        /// Returns information about provisioned Aurora DB clusters. This API supports pagination.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusters service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        DescribeDBClustersResponse DescribeDBClusters(DescribeDBClustersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBClustersResponse> DescribeDBClustersAsync(DescribeDBClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBClusterSnapshotAttributes


        /// <summary>
        /// Returns a list of DB cluster snapshot attribute names and values for a manual DB cluster
        /// snapshot.
        /// 
        ///  
        /// <para>
        /// When sharing snapshots with other AWS accounts, <code>DescribeDBClusterSnapshotAttributes</code>
        /// returns the <code>restore</code> attribute and a list of IDs for the AWS accounts
        /// that are authorized to copy or restore the manual DB cluster snapshot. If <code>all</code>
        /// is included in the list of values for the <code>restore</code> attribute, then the
        /// manual DB cluster snapshot is public and can be copied or restored by all AWS accounts.
        /// </para>
        ///  
        /// <para>
        /// To add or remove access for an AWS account to copy or restore a manual DB cluster
        /// snapshot, or to make the manual DB cluster snapshot public or private, use the <a>ModifyDBClusterSnapshotAttribute</a>
        /// API action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshotAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshotAttributes service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        DescribeDBClusterSnapshotAttributesResponse DescribeDBClusterSnapshotAttributes(DescribeDBClusterSnapshotAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterSnapshotAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshotAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBClusterSnapshotAttributesResponse> DescribeDBClusterSnapshotAttributesAsync(DescribeDBClusterSnapshotAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBClusterSnapshots


        /// <summary>
        /// Returns information about DB cluster snapshots. This API action supports pagination.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshots service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        DescribeDBClusterSnapshotsResponse DescribeDBClusterSnapshots(DescribeDBClusterSnapshotsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBClusterSnapshotsResponse> DescribeDBClusterSnapshotsAsync(DescribeDBClusterSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBEngineVersions


        /// <summary>
        /// Returns a list of the available DB engines.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by RDS.</returns>
        DescribeDBEngineVersionsResponse DescribeDBEngineVersions();


        /// <summary>
        /// Returns a list of the available DB engines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by RDS.</returns>
        DescribeDBEngineVersionsResponse DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request);


        /// <summary>
        /// Returns a list of the available DB engines.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by RDS.</returns>
        Task<DescribeDBEngineVersionsResponse> DescribeDBEngineVersionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBEngineVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBEngineVersionsResponse> DescribeDBEngineVersionsAsync(DescribeDBEngineVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBInstances


        /// <summary>
        /// Returns information about provisioned RDS instances. This API supports pagination.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        DescribeDBInstancesResponse DescribeDBInstances();


        /// <summary>
        /// Returns information about provisioned RDS instances. This API supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request);


        /// <summary>
        /// Returns information about provisioned RDS instances. This API supports pagination.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(DescribeDBInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBLogFiles


        /// <summary>
        /// Returns a list of DB log files for the DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBLogFiles service method.</param>
        /// 
        /// <returns>The response from the DescribeDBLogFiles service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        DescribeDBLogFilesResponse DescribeDBLogFiles(DescribeDBLogFilesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBLogFiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBLogFiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBLogFilesResponse> DescribeDBLogFilesAsync(DescribeDBLogFilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBParameterGroups


        /// <summary>
        /// Returns a list of <code>DBParameterGroup</code> descriptions. If a <code>DBParameterGroupName</code>
        /// is specified, the list will contain only the description of the specified DB parameter
        /// group.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        DescribeDBParameterGroupsResponse DescribeDBParameterGroups();


        /// <summary>
        /// Returns a list of <code>DBParameterGroup</code> descriptions. If a <code>DBParameterGroupName</code>
        /// is specified, the list will contain only the description of the specified DB parameter
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        DescribeDBParameterGroupsResponse DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request);


        /// <summary>
        /// Returns a list of <code>DBParameterGroup</code> descriptions. If a <code>DBParameterGroupName</code>
        /// is specified, the list will contain only the description of the specified DB parameter
        /// group.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        Task<DescribeDBParameterGroupsResponse> DescribeDBParameterGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBParameterGroupsResponse> DescribeDBParameterGroupsAsync(DescribeDBParameterGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBParameters


        /// <summary>
        /// Returns the detailed parameter list for a particular DB parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeDBParameters service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        DescribeDBParametersResponse DescribeDBParameters(DescribeDBParametersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBParametersResponse> DescribeDBParametersAsync(DescribeDBParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBSecurityGroups


        /// <summary>
        /// Returns a list of <code>DBSecurityGroup</code> descriptions. If a <code>DBSecurityGroupName</code>
        /// is specified, the list will contain only the descriptions of the specified DB security
        /// group.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups();


        /// <summary>
        /// Returns a list of <code>DBSecurityGroup</code> descriptions. If a <code>DBSecurityGroupName</code>
        /// is specified, the list will contain only the descriptions of the specified DB security
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest request);


        /// <summary>
        /// Returns a list of <code>DBSecurityGroup</code> descriptions. If a <code>DBSecurityGroupName</code>
        /// is specified, the list will contain only the descriptions of the specified DB security
        /// group.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroupsAsync(DescribeDBSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBSnapshotAttributes


        /// <summary>
        /// Returns a list of DB snapshot attribute names and values for a manual DB snapshot.
        /// 
        ///  
        /// <para>
        /// When sharing snapshots with other AWS accounts, <code>DescribeDBSnapshotAttributes</code>
        /// returns the <code>restore</code> attribute and a list of IDs for the AWS accounts
        /// that are authorized to copy or restore the manual DB snapshot. If <code>all</code>
        /// is included in the list of values for the <code>restore</code> attribute, then the
        /// manual DB snapshot is public and can be copied or restored by all AWS accounts.
        /// </para>
        ///  
        /// <para>
        /// To add or remove access for an AWS account to copy or restore a manual DB snapshot,
        /// or to make the manual DB snapshot public or private, use the <a>ModifyDBSnapshotAttribute</a>
        /// API action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshotAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeDBSnapshotAttributes service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        DescribeDBSnapshotAttributesResponse DescribeDBSnapshotAttributes(DescribeDBSnapshotAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSnapshotAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshotAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBSnapshotAttributesResponse> DescribeDBSnapshotAttributesAsync(DescribeDBSnapshotAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBSnapshots


        /// <summary>
        /// Returns information about DB snapshots. This API action supports pagination.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        DescribeDBSnapshotsResponse DescribeDBSnapshots();


        /// <summary>
        /// Returns information about DB snapshots. This API action supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        DescribeDBSnapshotsResponse DescribeDBSnapshots(DescribeDBSnapshotsRequest request);


        /// <summary>
        /// Returns information about DB snapshots. This API action supports pagination.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        Task<DescribeDBSnapshotsResponse> DescribeDBSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBSnapshotsResponse> DescribeDBSnapshotsAsync(DescribeDBSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBSubnetGroups


        /// <summary>
        /// Returns a list of DBSubnetGroup descriptions. If a DBSubnetGroupName is specified,
        /// the list will contain only the descriptions of the specified DBSubnetGroup.
        /// 
        ///  
        /// <para>
        /// For an overview of CIDR ranges, go to the <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Wikipedia
        /// Tutorial</a>. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups();


        /// <summary>
        /// Returns a list of DBSubnetGroup descriptions. If a DBSubnetGroupName is specified,
        /// the list will contain only the descriptions of the specified DBSubnetGroup.
        /// 
        ///  
        /// <para>
        /// For an overview of CIDR ranges, go to the <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Wikipedia
        /// Tutorial</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request);


        /// <summary>
        /// Returns a list of DBSubnetGroup descriptions. If a DBSubnetGroupName is specified,
        /// the list will contain only the descriptions of the specified DBSubnetGroup.
        /// 
        ///  
        /// <para>
        /// For an overview of CIDR ranges, go to the <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Wikipedia
        /// Tutorial</a>. 
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        Task<DescribeDBSubnetGroupsResponse> DescribeDBSubnetGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBSubnetGroupsResponse> DescribeDBSubnetGroupsAsync(DescribeDBSubnetGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEngineDefaultClusterParameters


        /// <summary>
        /// Returns the default engine and system parameter information for the cluster database
        /// engine.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultClusterParameters service method, as returned by RDS.</returns>
        DescribeEngineDefaultClusterParametersResponse DescribeEngineDefaultClusterParameters(DescribeEngineDefaultClusterParametersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultClusterParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEngineDefaultClusterParametersResponse> DescribeEngineDefaultClusterParametersAsync(DescribeEngineDefaultClusterParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEngineDefaultParameters


        /// <summary>
        /// Returns the default engine and system parameter information for the specified database
        /// engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by RDS.</returns>
        DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEventCategories


        /// <summary>
        /// Displays a list of categories for all event source types, or, if specified, for a
        /// specified source type. You can see a list of the event categories and source types
        /// in the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">
        /// Events</a> topic in the <i>Amazon RDS User Guide.</i>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by RDS.</returns>
        DescribeEventCategoriesResponse DescribeEventCategories();


        /// <summary>
        /// Displays a list of categories for all event source types, or, if specified, for a
        /// specified source type. You can see a list of the event categories and source types
        /// in the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">
        /// Events</a> topic in the <i>Amazon RDS User Guide.</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by RDS.</returns>
        DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request);


        /// <summary>
        /// Displays a list of categories for all event source types, or, if specified, for a
        /// specified source type. You can see a list of the event categories and source types
        /// in the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">
        /// Events</a> topic in the <i>Amazon RDS User Guide.</i>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by RDS.</returns>
        Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEvents


        /// <summary>
        /// Returns events related to DB instances, DB security groups, DB snapshots, and DB parameter
        /// groups for the past 14 days. Events specific to a particular DB instance, DB security
        /// group, database snapshot, or DB parameter group can be obtained by providing the name
        /// as a parameter. By default, the past hour of events are returned.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by RDS.</returns>
        DescribeEventsResponse DescribeEvents();


        /// <summary>
        /// Returns events related to DB instances, DB security groups, DB snapshots, and DB parameter
        /// groups for the past 14 days. Events specific to a particular DB instance, DB security
        /// group, database snapshot, or DB parameter group can be obtained by providing the name
        /// as a parameter. By default, the past hour of events are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by RDS.</returns>
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest request);


        /// <summary>
        /// Returns events related to DB instances, DB security groups, DB snapshots, and DB parameter
        /// groups for the past 14 days. Events specific to a particular DB instance, DB security
        /// group, database snapshot, or DB parameter group can be obtained by providing the name
        /// as a parameter. By default, the past hour of events are returned.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by RDS.</returns>
        Task<DescribeEventsResponse> DescribeEventsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEventSubscriptions


        /// <summary>
        /// Lists all the subscription descriptions for a customer account. The description for
        /// a subscription includes SubscriptionName, SNSTopicARN, CustomerID, SourceType, SourceID,
        /// CreationTime, and Status.
        /// 
        ///  
        /// <para>
        /// If you specify a SubscriptionName, lists the description for that subscription.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        DescribeEventSubscriptionsResponse DescribeEventSubscriptions();


        /// <summary>
        /// Lists all the subscription descriptions for a customer account. The description for
        /// a subscription includes SubscriptionName, SNSTopicARN, CustomerID, SourceType, SourceID,
        /// CreationTime, and Status.
        /// 
        ///  
        /// <para>
        /// If you specify a SubscriptionName, lists the description for that subscription.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request);


        /// <summary>
        /// Lists all the subscription descriptions for a customer account. The description for
        /// a subscription includes SubscriptionName, SNSTopicARN, CustomerID, SourceType, SourceID,
        /// CreationTime, and Status.
        /// 
        ///  
        /// <para>
        /// If you specify a SubscriptionName, lists the description for that subscription.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeOptionGroupOptions


        /// <summary>
        /// Describes all available options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroupOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeOptionGroupOptions service method, as returned by RDS.</returns>
        DescribeOptionGroupOptionsResponse DescribeOptionGroupOptions(DescribeOptionGroupOptionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOptionGroupOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroupOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeOptionGroupOptionsResponse> DescribeOptionGroupOptionsAsync(DescribeOptionGroupOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeOptionGroups


        /// <summary>
        /// Describes the available option groups.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeOptionGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        DescribeOptionGroupsResponse DescribeOptionGroups();


        /// <summary>
        /// Describes the available option groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeOptionGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        DescribeOptionGroupsResponse DescribeOptionGroups(DescribeOptionGroupsRequest request);


        /// <summary>
        /// Describes the available option groups.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOptionGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        Task<DescribeOptionGroupsResponse> DescribeOptionGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOptionGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeOptionGroupsResponse> DescribeOptionGroupsAsync(DescribeOptionGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeOrderableDBInstanceOptions


        /// <summary>
        /// Returns a list of orderable DB instance options for the specified engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeOrderableDBInstanceOptions service method, as returned by RDS.</returns>
        DescribeOrderableDBInstanceOptionsResponse DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableDBInstanceOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeOrderableDBInstanceOptionsResponse> DescribeOrderableDBInstanceOptionsAsync(DescribeOrderableDBInstanceOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePendingMaintenanceActions


        /// <summary>
        /// Returns a list of resources (for example, DB instances) that have at least one pending
        /// maintenance action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingMaintenanceActions service method.</param>
        /// 
        /// <returns>The response from the DescribePendingMaintenanceActions service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        DescribePendingMaintenanceActionsResponse DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePendingMaintenanceActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingMaintenanceActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribePendingMaintenanceActionsResponse> DescribePendingMaintenanceActionsAsync(DescribePendingMaintenanceActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReservedDBInstances


        /// <summary>
        /// Returns information about reserved DB instances for this account, or about a specified
        /// reserved DB instance.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstanceNotFoundException">
        /// The specified reserved DB Instance not found.
        /// </exception>
        DescribeReservedDBInstancesResponse DescribeReservedDBInstances();


        /// <summary>
        /// Returns information about reserved DB instances for this account, or about a specified
        /// reserved DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstanceNotFoundException">
        /// The specified reserved DB Instance not found.
        /// </exception>
        DescribeReservedDBInstancesResponse DescribeReservedDBInstances(DescribeReservedDBInstancesRequest request);


        /// <summary>
        /// Returns information about reserved DB instances for this account, or about a specified
        /// reserved DB instance.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstanceNotFoundException">
        /// The specified reserved DB Instance not found.
        /// </exception>
        Task<DescribeReservedDBInstancesResponse> DescribeReservedDBInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedDBInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeReservedDBInstancesResponse> DescribeReservedDBInstancesAsync(DescribeReservedDBInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReservedDBInstancesOfferings


        /// <summary>
        /// Lists available reserved DB instance offerings.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstancesOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings();


        /// <summary>
        /// Lists available reserved DB instance offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstancesOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstancesOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest request);


        /// <summary>
        /// Lists available reserved DB instance offerings.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstancesOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        Task<DescribeReservedDBInstancesOfferingsResponse> DescribeReservedDBInstancesOfferingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedDBInstancesOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstancesOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeReservedDBInstancesOfferingsResponse> DescribeReservedDBInstancesOfferingsAsync(DescribeReservedDBInstancesOfferingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DownloadDBLogFilePortion


        /// <summary>
        /// Downloads all or a portion of the specified log file, up to 1 MB in size.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DownloadDBLogFilePortion service method.</param>
        /// 
        /// <returns>The response from the DownloadDBLogFilePortion service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBLogFileNotFoundException">
        /// <i>LogFileName</i> does not refer to an existing DB log file.
        /// </exception>
        DownloadDBLogFilePortionResponse DownloadDBLogFilePortion(DownloadDBLogFilePortionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DownloadDBLogFilePortion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DownloadDBLogFilePortion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DownloadDBLogFilePortionResponse> DownloadDBLogFilePortionAsync(DownloadDBLogFilePortionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  FailoverDBCluster


        /// <summary>
        /// Forces a failover for a DB cluster.
        /// 
        ///  
        /// <para>
        /// A failover for a DB cluster promotes one of the read-only instances in the DB cluster
        /// to the master DB instance (the cluster writer) and deletes the current primary instance.
        /// </para>
        ///  
        /// <para>
        /// Amazon Aurora will automatically fail over to a read-only instance, if one exists,
        /// when the primary instance fails. You can force a failover when you want to simulate
        /// a failure of a DB instance for testing. Because each instance in a DB cluster has
        /// its own endpoint address, you will need to clean up and re-establish any existing
        /// connections that use those endpoint addresses when the failover is complete.
        /// </para>
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverDBCluster service method.</param>
        /// 
        /// <returns>The response from the FailoverDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        FailoverDBClusterResponse FailoverDBCluster(FailoverDBClusterRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the FailoverDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FailoverDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<FailoverDBClusterResponse> FailoverDBClusterAsync(FailoverDBClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags on an Amazon RDS resource.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging an Amazon RDS resource, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging
        /// Amazon RDS Resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyDBCluster


        /// <summary>
        /// Modify a setting for an Amazon Aurora DB cluster. You can change one or more database
        /// configuration parameters by specifying these parameters and the new values in the
        /// request. For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// User already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <i>DBClusterParameterGroupName</i> does not refer to an existing DB Cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        ModifyDBClusterResponse ModifyDBCluster(ModifyDBClusterRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyDBClusterResponse> ModifyDBClusterAsync(ModifyDBClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyDBClusterParameterGroup


        /// <summary>
        /// Modifies the parameters of a DB cluster parameter group. To modify more than one
        /// parameter, submit a list of the following: <code>ParameterName</code>, <code>ParameterValue</code>,
        /// and <code>ApplyMethod</code>. A maximum of 20 parameters can be modified in a single
        /// request. 
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// Changes to dynamic parameters are applied immediately. Changes to static parameters
        /// require a reboot without failover to the DB cluster associated with the parameter
        /// group before the change can take effect.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// After you create a DB cluster parameter group, you should wait at least 5 minutes
        /// before creating your first DB cluster that uses that DB cluster parameter group as
        /// the default parameter group. This allows Amazon RDS to fully complete the create action
        /// before the parameter group is used as the default for a new DB cluster. This is especially
        /// important for parameters that are critical when creating the default database for
        /// a DB cluster, such as the character set for the default database defined by the <code>character_set_database</code>
        /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
        /// RDS console</a> or the <a>DescribeDBClusterParameters</a> command to verify that your
        /// DB cluster parameter group has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group cannot be deleted because it is in use.
        /// </exception>
        ModifyDBClusterParameterGroupResponse ModifyDBClusterParameterGroup(ModifyDBClusterParameterGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyDBClusterParameterGroupResponse> ModifyDBClusterParameterGroupAsync(ModifyDBClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyDBClusterSnapshotAttribute


        /// <summary>
        /// Adds an attribute and values to, or removes an attribute and values from, a manual
        /// DB cluster snapshot.
        /// 
        ///  
        /// <para>
        /// To share a manual DB cluster snapshot with other AWS accounts, specify <code>restore</code>
        /// as the <code>AttributeName</code> and use the <code>ValuesToAdd</code> parameter to
        /// add a list of IDs of the AWS accounts that are authorized to restore the manual DB
        /// cluster snapshot. Use the value <code>all</code> to make the manual DB cluster snapshot
        /// public, which means that it can be copied or restored by all AWS accounts. Do not
        /// add the <code>all</code> value for any manual DB cluster snapshots that contain private
        /// information that you don't want available to all AWS accounts.
        /// </para>
        ///  
        /// <para>
        /// To view which AWS accounts have access to copy or restore a manual DB cluster snapshot,
        /// or whether a manual DB cluster snapshot public or private, use the <a>DescribeDBClusterSnapshotAttributes</a>
        /// API action.
        /// </para>
        ///  
        /// <para>
        /// If a manual DB cluster snapshot is encrypted, it cannot be shared.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterSnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyDBClusterSnapshotAttribute service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SharedSnapshotQuotaExceededException">
        /// You have exceeded the maximum number of accounts that you can share a manual DB snapshot
        /// with.
        /// </exception>
        ModifyDBClusterSnapshotAttributeResponse ModifyDBClusterSnapshotAttribute(ModifyDBClusterSnapshotAttributeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBClusterSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterSnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyDBClusterSnapshotAttributeResponse> ModifyDBClusterSnapshotAttributeAsync(ModifyDBClusterSnapshotAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyDBInstance


        /// <summary>
        /// Modify settings for a DB instance. You can change one or more database configuration
        /// parameters by specifying these parameters and the new values in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance service method.</param>
        /// 
        /// <returns>The response from the ModifyDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// Specified CIDRIP or EC2 security group is not authorized for the specified DB security
        /// group.
        /// 
        ///  
        /// <para>
        /// RDS may not also be authorized via IAM to perform necessary actions on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <i>CertificateIdentifier</i> does not refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// User already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBUpgradeDependencyFailureException">
        /// The DB upgrade failed because a resource the DB depends on could not be modified.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <i>Domain</i> does not refer to an existing Active Directory Domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// Specified DB instance class is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// <i>StorageType</i> specified cannot be associated with the DB Instance.
        /// </exception>
        ModifyDBInstanceResponse ModifyDBInstance(ModifyDBInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyDBInstanceResponse> ModifyDBInstanceAsync(ModifyDBInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyDBParameterGroup


        /// <summary>
        /// Modifies the parameters of a DB parameter group. To modify more than one parameter,
        /// submit a list of the following: <code>ParameterName</code>, <code>ParameterValue</code>,
        /// and <code>ApplyMethod</code>. A maximum of 20 parameters can be modified in a single
        /// request. 
        /// 
        ///  <note> 
        /// <para>
        /// Changes to dynamic parameters are applied immediately. Changes to static parameters
        /// require a reboot without failover to the DB instance associated with the parameter
        /// group before the change can take effect.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// After you modify a DB parameter group, you should wait at least 5 minutes before creating
        /// your first DB instance that uses that DB parameter group as the default parameter
        /// group. This allows Amazon RDS to fully complete the modify action before the parameter
        /// group is used as the default for a new DB instance. This is especially important for
        /// parameters that are critical when creating the default database for a DB instance,
        /// such as the character set for the default database defined by the <code>character_set_database</code>
        /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
        /// RDS console</a> or the <i>DescribeDBParameters</i> command to verify that your DB
        /// parameter group has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group cannot be deleted because it is in use.
        /// </exception>
        ModifyDBParameterGroupResponse ModifyDBParameterGroup(ModifyDBParameterGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyDBParameterGroupResponse> ModifyDBParameterGroupAsync(ModifyDBParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyDBSnapshotAttribute


        /// <summary>
        /// Adds an attribute and values to, or removes an attribute and values from, a manual
        /// DB snapshot.
        /// 
        ///  
        /// <para>
        /// To share a manual DB snapshot with other AWS accounts, specify <code>restore</code>
        /// as the <code>AttributeName</code> and use the <code>ValuesToAdd</code> parameter to
        /// add a list of IDs of the AWS accounts that are authorized to restore the manual DB
        /// snapshot. Uses the value <code>all</code> to make the manual DB snapshot public, which
        /// means it can be copied or restored by all AWS accounts. Do not add the <code>all</code>
        /// value for any manual DB snapshots that contain private information that you don't
        /// want available to all AWS accounts.
        /// </para>
        ///  
        /// <para>
        /// To view which AWS accounts have access to copy or restore a manual DB snapshot, or
        /// whether a manual DB snapshot public or private, use the <a>DescribeDBSnapshotAttributes</a>
        /// API action.
        /// </para>
        ///  
        /// <para>
        /// If the manual DB snapshot is encrypted, it cannot be shared.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyDBSnapshotAttribute service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SharedSnapshotQuotaExceededException">
        /// You have exceeded the maximum number of accounts that you can share a manual DB snapshot
        /// with.
        /// </exception>
        ModifyDBSnapshotAttributeResponse ModifyDBSnapshotAttribute(ModifyDBSnapshotAttributeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyDBSnapshotAttributeResponse> ModifyDBSnapshotAttributeAsync(ModifyDBSnapshotAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyDBSubnetGroup


        /// <summary>
        /// Modifies an existing DB subnet group. DB subnet groups must contain at least one subnet
        /// in at least two AZs in the region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBSubnetGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetQuotaExceededException">
        /// Request would result in user exceeding the allowed number of subnets in a DB subnet
        /// groups.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubnetAlreadyInUseException">
        /// The DB subnet is already in use in the Availability Zone.
        /// </exception>
        ModifyDBSubnetGroupResponse ModifyDBSubnetGroup(ModifyDBSubnetGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyDBSubnetGroupResponse> ModifyDBSubnetGroupAsync(ModifyDBSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyEventSubscription


        /// <summary>
        /// Modifies an existing RDS event notification subscription. Note that you cannot modify
        /// the source identifiers using this call; to change source identifiers for a subscription,
        /// use the <a>AddSourceIdentifierToSubscription</a> and <a>RemoveSourceIdentifierFromSubscription</a>
        /// calls.
        /// 
        ///  
        /// <para>
        /// You can see a list of the event categories for a given SourceType in the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">Events</a>
        /// topic in the Amazon RDS User Guide or by using the <b>DescribeEventCategories</b>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.EventSubscriptionQuotaExceededException">
        /// You have reached the maximum number of event subscriptions.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SNSInvalidTopicException">
        /// SNS has responded that there is a problem with the SND topic specified.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the SNS topic ARN.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SNSTopicArnNotFoundException">
        /// The SNS topic ARN does not exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionCategoryNotFoundException">
        /// The supplied category does not exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyOptionGroup


        /// <summary>
        /// Modifies an existing option group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyOptionGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InvalidOptionGroupStateException">
        /// The option group is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        ModifyOptionGroupResponse ModifyOptionGroup(ModifyOptionGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyOptionGroupResponse> ModifyOptionGroupAsync(ModifyOptionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PromoteReadReplica


        /// <summary>
        /// Promotes a Read Replica DB instance to a standalone DB instance.
        /// 
        ///  <note> 
        /// <para>
        /// We recommend that you enable automated backups on your Read Replica before promoting
        /// the Read Replica. This ensures that no backup is taken during the promotion process.
        /// Once the instance is promoted to a primary instance, backups are taken based on your
        /// backup settings.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplica service method.</param>
        /// 
        /// <returns>The response from the PromoteReadReplica service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        PromoteReadReplicaResponse PromoteReadReplica(PromoteReadReplicaRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PromoteReadReplica operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplica operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PromoteReadReplicaResponse> PromoteReadReplicaAsync(PromoteReadReplicaRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PromoteReadReplicaDBCluster


        /// <summary>
        /// Promotes a Read Replica DB cluster to a standalone DB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplicaDBCluster service method.</param>
        /// 
        /// <returns>The response from the PromoteReadReplicaDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        PromoteReadReplicaDBClusterResponse PromoteReadReplicaDBCluster(PromoteReadReplicaDBClusterRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PromoteReadReplicaDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplicaDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PromoteReadReplicaDBClusterResponse> PromoteReadReplicaDBClusterAsync(PromoteReadReplicaDBClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PurchaseReservedDBInstancesOffering


        /// <summary>
        /// Purchases a reserved DB instance offering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedDBInstancesOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedDBInstancesOffering service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstanceAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstanceQuotaExceededException">
        /// Request would exceed the user's DB Instance quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstancesOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        PurchaseReservedDBInstancesOfferingResponse PurchaseReservedDBInstancesOffering(PurchaseReservedDBInstancesOfferingRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedDBInstancesOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedDBInstancesOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PurchaseReservedDBInstancesOfferingResponse> PurchaseReservedDBInstancesOfferingAsync(PurchaseReservedDBInstancesOfferingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RebootDBInstance


        /// <summary>
        /// Rebooting a DB instance restarts the database engine service. A reboot also applies
        /// to the DB instance any modifications to the associated DB parameter group that were
        /// pending. Rebooting a DB instance results in a momentary outage of the instance, during
        /// which the DB instance status is set to rebooting. If the RDS instance is configured
        /// for MultiAZ, it is possible that the reboot will be conducted through a failover.
        /// An Amazon RDS event is created when the reboot is completed.
        /// 
        ///  
        /// <para>
        /// If your DB instance is deployed in multiple Availability Zones, you can force a failover
        /// from one AZ to the other during the reboot. You might force a failover to test the
        /// availability of your DB instance deployment or to restore operations to the original
        /// AZ after a failover occurs.
        /// </para>
        ///  
        /// <para>
        /// The time required to reboot is a function of the specific database engine's crash
        /// recovery process. To improve the reboot time, we recommend that you reduce database
        /// activities as much as possible during the reboot process to reduce rollback activity
        /// for in-transit transactions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance service method.</param>
        /// 
        /// <returns>The response from the RebootDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        RebootDBInstanceResponse RebootDBInstance(RebootDBInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RebootDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RebootDBInstanceResponse> RebootDBInstanceAsync(RebootDBInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveSourceIdentifierFromSubscription


        /// <summary>
        /// Removes a source identifier from an existing RDS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription service method.</param>
        /// 
        /// <returns>The response from the RemoveSourceIdentifierFromSubscription service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        RemoveSourceIdentifierFromSubscriptionResponse RemoveSourceIdentifierFromSubscription(RemoveSourceIdentifierFromSubscriptionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveSourceIdentifierFromSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RemoveSourceIdentifierFromSubscriptionResponse> RemoveSourceIdentifierFromSubscriptionAsync(RemoveSourceIdentifierFromSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveTagsFromResource


        /// <summary>
        /// Removes metadata tags from an Amazon RDS resource.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging an Amazon RDS resource, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging
        /// Amazon RDS Resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResetDBClusterParameterGroup


        /// <summary>
        /// Modifies the parameters of a DB cluster parameter group to the default value. To
        /// reset specific parameters submit a list of the following: <code>ParameterName</code>
        /// and <code>ApplyMethod</code>. To reset the entire DB cluster parameter group, specify
        /// the <code>DBClusterParameterGroupName</code> and <code>ResetAllParameters</code> parameters.
        /// 
        /// 
        ///  
        /// <para>
        ///  When resetting the entire group, dynamic parameters are updated immediately and static
        /// parameters are set to <code>pending-reboot</code> to take effect on the next DB instance
        /// restart or <a>RebootDBInstance</a> request. You must call <a>RebootDBInstance</a>
        /// for every DB instance in your DB cluster that you want the updated static parameter
        /// to apply to.
        /// </para>
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group cannot be deleted because it is in use.
        /// </exception>
        ResetDBClusterParameterGroupResponse ResetDBClusterParameterGroup(ResetDBClusterParameterGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ResetDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetDBClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ResetDBClusterParameterGroupResponse> ResetDBClusterParameterGroupAsync(ResetDBClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResetDBParameterGroup


        /// <summary>
        /// Modifies the parameters of a DB parameter group to the engine/system default value.
        /// To reset specific parameters submit a list of the following: <code>ParameterName</code>
        /// and <code>ApplyMethod</code>. To reset the entire DB parameter group, specify the
        /// <code>DBParameterGroup</code> name and <code>ResetAllParameters</code> parameters.
        /// When resetting the entire group, dynamic parameters are updated immediately and static
        /// parameters are set to <code>pending-reboot</code> to take effect on the next DB instance
        /// restart or <code>RebootDBInstance</code> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group cannot be deleted because it is in use.
        /// </exception>
        ResetDBParameterGroupResponse ResetDBParameterGroup(ResetDBParameterGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ResetDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ResetDBParameterGroupResponse> ResetDBParameterGroupAsync(ResetDBParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RestoreDBClusterFromSnapshot


        /// <summary>
        /// Creates a new DB cluster from a DB cluster snapshot. The target DB cluster is created
        /// from the source DB cluster restore point with the same configuration as the original
        /// source DB cluster, except that the new DB cluster is created with the default security
        /// group.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreDBClusterFromSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// User already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// User attempted to create a new DB cluster and the user has already reached the maximum
        /// allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBClusterCapacityException">
        /// The DB cluster does not have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You may be able to
        /// resolve this error by updating your subnet group to use different Availability Zones
        /// that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidRestoreException">
        /// Cannot restore from vpc backup to non-vpc DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        RestoreDBClusterFromSnapshotResponse RestoreDBClusterFromSnapshot(RestoreDBClusterFromSnapshotRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBClusterFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RestoreDBClusterFromSnapshotResponse> RestoreDBClusterFromSnapshotAsync(RestoreDBClusterFromSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RestoreDBClusterToPointInTime


        /// <summary>
        /// Restores a DB cluster to an arbitrary point in time. Users can restore to any point
        /// in time before <code>LatestRestorableTime</code> for up to <code>BackupRetentionPeriod</code>
        /// days. The target DB cluster is created from the source DB cluster with the same configuration
        /// as the original DB cluster, except that the new DB cluster is created with the default
        /// DB security group. 
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon RDS</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterToPointInTime service method.</param>
        /// 
        /// <returns>The response from the RestoreDBClusterToPointInTime service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// User already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// User attempted to create a new DB cluster and the user has already reached the maximum
        /// allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBClusterCapacityException">
        /// The DB cluster does not have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidRestoreException">
        /// Cannot restore from vpc backup to non-vpc DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        RestoreDBClusterToPointInTimeResponse RestoreDBClusterToPointInTime(RestoreDBClusterToPointInTimeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBClusterToPointInTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterToPointInTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RestoreDBClusterToPointInTimeResponse> RestoreDBClusterToPointInTimeAsync(RestoreDBClusterToPointInTimeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RestoreDBInstanceFromDBSnapshot


        /// <summary>
        /// Creates a new DB instance from a DB snapshot. The target database is created from
        /// the source database restore point with the most of original configuration with the
        /// default security group and the default DB parameter group. By default, the new DB
        /// instance is created as a single-AZ deployment except when the instance is a SQL Server
        /// instance that has an option group that is associated with mirroring; in this case,
        /// the instance becomes a mirrored AZ deployment and not a single-AZ deployment.
        /// 
        ///  
        /// <para>
        /// If your intent is to replace your original DB instance with the new, restored DB instance,
        /// then rename your original DB instance before you call the RestoreDBInstanceFromDBSnapshot
        /// action. RDS does not allow two DB instances with the same name. Once you have renamed
        /// your original DB instance with a different identifier, then you can pass the original
        /// name of the DB instance as the DBInstanceIdentifier in the call to the RestoreDBInstanceFromDBSnapshot
        /// action. The result is that you will replace the original DB instance with the DB instance
        /// created from the snapshot.
        /// </para>
        ///  
        /// <para>
        /// If you are restoring from a shared manual DB snapshot, the <code>DBSnapshotIdentifier</code>
        /// must be the ARN of the shared DB snapshot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreDBInstanceFromDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// Specified CIDRIP or EC2 security group is not authorized for the specified DB security
        /// group.
        /// 
        ///  
        /// <para>
        /// RDS may not also be authorized via IAM to perform necessary actions on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// User already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <i>Domain</i> does not refer to an existing Active Directory Domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InstanceQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// Specified DB instance class is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidRestoreException">
        /// Cannot restore from vpc backup to non-vpc DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// <i>StorageType</i> specified cannot be associated with the DB Instance.
        /// </exception>
        RestoreDBInstanceFromDBSnapshotResponse RestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceFromDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RestoreDBInstanceFromDBSnapshotResponse> RestoreDBInstanceFromDBSnapshotAsync(RestoreDBInstanceFromDBSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RestoreDBInstanceToPointInTime


        /// <summary>
        /// Restores a DB instance to an arbitrary point in time. You can restore to any point
        /// in time before the time identified by the LatestRestorableTime property. You can restore
        /// to a point up to the number of days specified by the BackupRetentionPeriod property.
        /// 
        ///  
        /// <para>
        /// The target database is created with most of the original configuration, but in a system-selected
        /// availability zone, with the default security group, the default subnet group, and
        /// the default DB parameter group. By default, the new DB instance is created as a single-AZ
        /// deployment except when the instance is a SQL Server instance that has an option group
        /// that is associated with mirroring; in this case, the instance becomes a mirrored deployment
        /// and not a single-AZ deployment.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceToPointInTime service method.</param>
        /// 
        /// <returns>The response from the RestoreDBInstanceToPointInTime service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// Specified CIDRIP or EC2 security group is not authorized for the specified DB security
        /// group.
        /// 
        ///  
        /// <para>
        /// RDS may not also be authorized via IAM to perform necessary actions on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// User already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <i>Domain</i> does not refer to an existing Active Directory Domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InstanceQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// Specified DB instance class is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidRestoreException">
        /// Cannot restore from vpc backup to non-vpc DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.PointInTimeRestoreNotEnabledException">
        /// <i>SourceDBInstanceIdentifier</i> refers to a DB instance with <i>BackupRetentionPeriod</i>
        /// equal to 0.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// <i>StorageType</i> specified cannot be associated with the DB Instance.
        /// </exception>
        RestoreDBInstanceToPointInTimeResponse RestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceToPointInTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceToPointInTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RestoreDBInstanceToPointInTimeResponse> RestoreDBInstanceToPointInTimeAsync(RestoreDBInstanceToPointInTimeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RevokeDBSecurityGroupIngress


        /// <summary>
        /// Revokes ingress from a DBSecurityGroup for previously authorized IP ranges or EC2
        /// or VPC Security Groups. Required parameters for this API are one of CIDRIP, EC2SecurityGroupId
        /// for VPC, or (EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeDBSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the RevokeDBSecurityGroupIngress service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// Specified CIDRIP or EC2 security group is not authorized for the specified DB security
        /// group.
        /// 
        ///  
        /// <para>
        /// RDS may not also be authorized via IAM to perform necessary actions on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group does not allow deletion.
        /// </exception>
        RevokeDBSecurityGroupIngressResponse RevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeDBSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeDBSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RevokeDBSecurityGroupIngressResponse> RevokeDBSecurityGroupIngressAsync(RevokeDBSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}