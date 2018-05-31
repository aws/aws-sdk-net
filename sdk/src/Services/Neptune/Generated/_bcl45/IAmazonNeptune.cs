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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Neptune.Model;

namespace Amazon.Neptune
{
    /// <summary>
    /// Interface for accessing Neptune
    ///
    /// Amazon Neptune 
    /// <para>
    ///  
    /// </para>
    ///  
    /// <para>
    ///  Amazon Neptune is a fast, reliable, fully-managed graph database service that makes
    /// it easy to build and run applications that work with highly connected datasets. The
    /// core of Amazon Neptune is a purpose-built, high-performance graph database engine
    /// optimized for storing billions of relationships and querying the graph with milliseconds
    /// latency. Amazon Neptune supports popular graph models Property Graph and W3C's RDF,
    /// and their respective query languages Apache TinkerPop Gremlin and SPARQL, allowing
    /// you to easily build queries that efficiently navigate highly connected datasets. Neptune
    /// powers graph use cases such as recommendation engines, fraud detection, knowledge
    /// graphs, drug discovery, and network security. 
    /// </para>
    ///  
    /// <para>
    /// This interface reference for Amazon Neptune contains documentation for a programming
    /// or command line interface you can use to manage Amazon Neptune. Note that Amazon Neptune
    /// is asynchronous, which means that some interfaces might require techniques such as
    /// polling or callback functions to determine when a command has been applied. In this
    /// reference, the parameter descriptions indicate whether a command is applied immediately,
    /// on the next instance reboot, or during the maintenance window. The reference structure
    /// is as follows, and we list following some related topics from the user guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>Amazon Neptune API Reference</b> 
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
    ///  <b>Amazon Neptune User Guide</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For a summary of the Amazon Neptune interfaces, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Welcome.html#Welcome.Interfaces">Available
    /// RDS Interfaces</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For more information about how to use the Query API, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Using_the_Query_API.html">Using
    /// the Query API</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonNeptune : IAmazonService, IDisposable
    {

        
        #region  AddRoleToDBCluster


        /// <summary>
        /// Associates an Identity and Access Management (IAM) role from an Neptune DB cluster.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Aurora.Authorizing.AWSServices.html">Authorizing
        /// Amazon Neptune to Access Other AWS Services On Your Behalf</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToDBCluster service method.</param>
        /// 
        /// <returns>The response from the AddRoleToDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterRoleAlreadyExistsException">
        /// The specified IAM role Amazon Resource Name (ARN) is already associated with the specified
        /// DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterRoleQuotaExceededException">
        /// You have exceeded the maximum number of IAM roles that can be associated with the
        /// specified DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/AddRoleToDBCluster">REST API Reference for AddRoleToDBCluster Operation</seealso>
        AddRoleToDBClusterResponse AddRoleToDBCluster(AddRoleToDBClusterRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AddRoleToDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/AddRoleToDBCluster">REST API Reference for AddRoleToDBCluster Operation</seealso>
        Task<AddRoleToDBClusterResponse> AddRoleToDBClusterAsync(AddRoleToDBClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddSourceIdentifierToSubscription


        /// <summary>
        /// Adds a source identifier to an existing RDS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription service method.</param>
        /// 
        /// <returns>The response from the AddSourceIdentifierToSubscription service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.SourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/AddSourceIdentifierToSubscription">REST API Reference for AddSourceIdentifierToSubscription Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/AddSourceIdentifierToSubscription">REST API Reference for AddSourceIdentifierToSubscription Operation</seealso>
        Task<AddSourceIdentifierToSubscriptionResponse> AddSourceIdentifierToSubscriptionAsync(AddSourceIdentifierToSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddTagsToResource


        /// <summary>
        /// Adds metadata tags to an Amazon Neptune resource. These tags can also be used with
        /// cost allocation reporting to track cost associated with Amazon Neptune resources,
        /// or used in a Condition statement in an IAM policy for Amazon Neptune.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging Amazon Neptune resources, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging
        /// Amazon Neptune Resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ApplyPendingMaintenanceAction


        /// <summary>
        /// Applies a pending maintenance action to a resource (for example, to a DB instance).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction service method.</param>
        /// 
        /// <returns>The response from the ApplyPendingMaintenanceAction service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        Task<ApplyPendingMaintenanceActionResponse> ApplyPendingMaintenanceActionAsync(ApplyPendingMaintenanceActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CopyDBClusterParameterGroup


        /// <summary>
        /// Copies the specified DB cluster parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CopyDBClusterParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB parameter groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CopyDBClusterParameterGroup">REST API Reference for CopyDBClusterParameterGroup Operation</seealso>
        CopyDBClusterParameterGroupResponse CopyDBClusterParameterGroup(CopyDBClusterParameterGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CopyDBClusterParameterGroup">REST API Reference for CopyDBClusterParameterGroup Operation</seealso>
        Task<CopyDBClusterParameterGroupResponse> CopyDBClusterParameterGroupAsync(CopyDBClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CopyDBClusterSnapshot


        /// <summary>
        /// Copies a snapshot of a DB cluster.
        /// 
        ///  
        /// <para>
        /// To copy a DB cluster snapshot from a shared manual DB cluster snapshot, <code>SourceDBClusterSnapshotIdentifier</code>
        /// must be the Amazon Resource Name (ARN) of the shared DB cluster snapshot.
        /// </para>
        ///  
        /// <para>
        /// You can copy an encrypted DB cluster snapshot from another AWS Region. In that case,
        /// the AWS Region where you call the <code>CopyDBClusterSnapshot</code> action is the
        /// destination AWS Region for the encrypted DB cluster snapshot to be copied to. To copy
        /// an encrypted DB cluster snapshot from another AWS Region, you must provide the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>KmsKeyId</code> - The AWS Key Management System (AWS KMS) key identifier for
        /// the key to use to encrypt the copy of the DB cluster snapshot in the destination AWS
        /// Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PreSignedUrl</code> - A URL that contains a Signature Version 4 signed request
        /// for the <code>CopyDBClusterSnapshot</code> action to be called in the source AWS Region
        /// where the DB cluster snapshot is copied from. The pre-signed URL must be a valid request
        /// for the <code>CopyDBClusterSnapshot</code> API action that can be executed in the
        /// source AWS Region that contains the encrypted DB cluster snapshot to be copied.
        /// </para>
        ///  
        /// <para>
        /// The pre-signed URL request must contain the following parameter values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>KmsKeyId</code> - The KMS key identifier for the key to use to encrypt the
        /// copy of the DB cluster snapshot in the destination AWS Region. This is the same identifier
        /// for both the <code>CopyDBClusterSnapshot</code> action that is called in the destination
        /// AWS Region, and the action contained in the pre-signed URL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DestinationRegion</code> - The name of the AWS Region that the DB cluster snapshot
        /// will be created in.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SourceDBClusterSnapshotIdentifier</code> - The DB cluster snapshot identifier
        /// for the encrypted DB cluster snapshot to be copied. This identifier must be in the
        /// Amazon Resource Name (ARN) format for the source AWS Region. For example, if you are
        /// copying an encrypted DB cluster snapshot from the us-west-2 AWS Region, then your
        /// <code>SourceDBClusterSnapshotIdentifier</code> looks like the following example: <code>arn:aws:rds:us-west-2:123456789012:cluster-snapshot:aurora-cluster1-snapshot-20161115</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn how to generate a Signature Version 4 signed request, see <a href="http://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">
        /// Authenticating Requests: Using Query Parameters (AWS Signature Version 4)</a> and
        /// <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html"> Signature
        /// Version 4 Signing Process</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TargetDBClusterSnapshotIdentifier</code> - The identifier for the new copy
        /// of the DB cluster snapshot in the destination AWS Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SourceDBClusterSnapshotIdentifier</code> - The DB cluster snapshot identifier
        /// for the encrypted DB cluster snapshot to be copied. This identifier must be in the
        /// ARN format for the source AWS Region and is the same value as the <code>SourceDBClusterSnapshotIdentifier</code>
        /// in the pre-signed URL. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To cancel the copy operation once it is in progress, delete the target DB cluster
        /// snapshot identified by <code>TargetDBClusterSnapshotIdentifier</code> while that DB
        /// cluster snapshot is in "copying" status.
        /// </para>
        ///  
        /// <para>
        /// For more information on copying encrypted DB cluster snapshots from one AWS Region
        /// to another, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_CopySnapshot.html#USER_CopyDBClusterSnapshot.CrossRegion">
        /// Copying a DB Cluster Snapshot in the Same Account, Either in the Same Region or Across
        /// Regions</a> in the Amazon Neptune User Guide.
        /// </para>
        ///  
        /// <para>
        /// For more information on Amazon Neptune, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Amazon
        /// Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CopyDBClusterSnapshot service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotAlreadyExistsException">
        /// User already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CopyDBClusterSnapshot">REST API Reference for CopyDBClusterSnapshot Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CopyDBClusterSnapshot">REST API Reference for CopyDBClusterSnapshot Operation</seealso>
        Task<CopyDBClusterSnapshotResponse> CopyDBClusterSnapshotAsync(CopyDBClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CopyDBParameterGroup


        /// <summary>
        /// Copies the specified DB parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CopyDBParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB parameter groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CopyDBParameterGroup">REST API Reference for CopyDBParameterGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CopyDBParameterGroup">REST API Reference for CopyDBParameterGroup Operation</seealso>
        Task<CopyDBParameterGroupResponse> CopyDBParameterGroupAsync(CopyDBParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDBCluster


        /// <summary>
        /// Creates a new Amazon Aurora DB cluster.
        /// 
        ///  
        /// <para>
        /// You can use the <code>ReplicationSourceIdentifier</code> parameter to create the DB
        /// cluster as a Read Replica of another DB cluster or Amazon Neptune MySQL DB instance.
        /// For cross-region replication where the DB cluster identified by <code>ReplicationSourceIdentifier</code>
        /// is encrypted, you must also specify the <code>PreSignedUrl</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBCluster service method.</param>
        /// 
        /// <returns>The response from the CreateDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterAlreadyExistsException">
        /// User already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterParameterGroupNotFoundException">
        /// <i>DBClusterParameterGroupName</i> does not refer to an existing DB Cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterQuotaExceededException">
        /// User attempted to create a new DB cluster and the user has already reached the maximum
        /// allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You may be able to
        /// resolve this error by updating your subnet group to use different Availability Zones
        /// that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CreateDBCluster">REST API Reference for CreateDBCluster Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CreateDBCluster">REST API Reference for CreateDBCluster Operation</seealso>
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
        /// the default parameter group. This allows Amazon Neptune to fully complete the create
        /// action before the DB cluster parameter group is used as the default for a new DB cluster.
        /// This is especially important for parameters that are critical when creating the default
        /// database for a DB cluster, such as the character set for the default database defined
        /// by the <code>character_set_database</code> parameter. You can use the <i>Parameter
        /// Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon Neptune
        /// console</a> or the <a>DescribeDBClusterParameters</a> command to verify that your
        /// DB cluster parameter group has been created or modified.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBClusterParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB parameter groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CreateDBClusterParameterGroup">REST API Reference for CreateDBClusterParameterGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CreateDBClusterParameterGroup">REST API Reference for CreateDBClusterParameterGroup Operation</seealso>
        Task<CreateDBClusterParameterGroupResponse> CreateDBClusterParameterGroupAsync(CreateDBClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDBClusterSnapshot


        /// <summary>
        /// Creates a snapshot of a DB cluster. For more information on Amazon Aurora, see <a
        /// href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateDBClusterSnapshot service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotAlreadyExistsException">
        /// User already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CreateDBClusterSnapshot">REST API Reference for CreateDBClusterSnapshot Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CreateDBClusterSnapshot">REST API Reference for CreateDBClusterSnapshot Operation</seealso>
        Task<CreateDBClusterSnapshotResponse> CreateDBClusterSnapshotAsync(CreateDBClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDBInstance


        /// <summary>
        /// Creates a new DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstance service method.</param>
        /// 
        /// <returns>The response from the CreateDBInstance service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.AuthorizationNotFoundException">
        /// Specified CIDRIP or EC2 security group is not authorized for the specified DB security
        /// group.
        /// 
        ///  
        /// <para>
        /// Neptune may not also be authorized via IAM to perform necessary actions on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceAlreadyExistsException">
        /// User already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DomainNotFoundException">
        /// <i>Domain</i> does not refer to an existing Active Directory Domain.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InstanceQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientDBInstanceCapacityException">
        /// Specified DB instance class is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.OptionGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageTypeNotSupportedException">
        /// <i>StorageType</i> specified cannot be associated with the DB Instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CreateDBInstance">REST API Reference for CreateDBInstance Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CreateDBInstance">REST API Reference for CreateDBInstance Operation</seealso>
        Task<CreateDBInstanceResponse> CreateDBInstanceAsync(CreateDBInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// group. This allows Amazon Neptune to fully complete the create action before the parameter
        /// group is used as the default for a new DB instance. This is especially important for
        /// parameters that are critical when creating the default database for a DB instance,
        /// such as the character set for the default database defined by the <code>character_set_database</code>
        /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
        /// Neptune console</a> or the <i>DescribeDBParameters</i> command to verify that your
        /// DB parameter group has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB parameter groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CreateDBParameterGroup">REST API Reference for CreateDBParameterGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CreateDBParameterGroup">REST API Reference for CreateDBParameterGroup Operation</seealso>
        Task<CreateDBParameterGroupResponse> CreateDBParameterGroupAsync(CreateDBParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDBSubnetGroup


        /// <summary>
        /// Creates a new DB subnet group. DB subnet groups must contain at least one subnet in
        /// at least two AZs in the AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBSubnetGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupAlreadyExistsException">
        /// <i>DBSubnetGroupName</i> is already used by an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB subnet groups.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetQuotaExceededException">
        /// Request would result in user exceeding the allowed number of subnets in a DB subnet
        /// groups.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CreateDBSubnetGroup">REST API Reference for CreateDBSubnetGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CreateDBSubnetGroup">REST API Reference for CreateDBSubnetGroup Operation</seealso>
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
        /// and SourceIdentifier = myDBInstance1, you are notified of all the db-instance events
        /// for the specified source. If you specify a SourceType but do not specify a SourceIdentifier,
        /// you receive notice of the events for that source type for all your RDS sources. If
        /// you do not specify either the SourceType nor the SourceIdentifier, you are notified
        /// of events generated from all RDS sources belonging to your customer account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.EventSubscriptionQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SNSInvalidTopicException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SNSNoAuthorizationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SNSTopicArnNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionAlreadyExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionCategoryNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDBCluster


        /// <summary>
        /// The DeleteDBCluster action deletes a previously provisioned DB cluster. When you delete
        /// a DB cluster, all automated backups for that DB cluster are deleted and can't be recovered.
        /// Manual DB cluster snapshots of the specified DB cluster are not deleted.
        /// 
        ///   
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotAlreadyExistsException">
        /// User already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DeleteDBCluster">REST API Reference for DeleteDBCluster Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DeleteDBCluster">REST API Reference for DeleteDBCluster Operation</seealso>
        Task<DeleteDBClusterResponse> DeleteDBClusterAsync(DeleteDBClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDBClusterParameterGroup


        /// <summary>
        /// Deletes a specified DB cluster parameter group. The DB cluster parameter group to
        /// be deleted can't be associated with any DB clusters.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBClusterParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you cannot delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DeleteDBClusterParameterGroup">REST API Reference for DeleteDBClusterParameterGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DeleteDBClusterParameterGroup">REST API Reference for DeleteDBClusterParameterGroup Operation</seealso>
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
        /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteDBClusterSnapshot service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DeleteDBClusterSnapshot">REST API Reference for DeleteDBClusterSnapshot Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DeleteDBClusterSnapshot">REST API Reference for DeleteDBClusterSnapshot Operation</seealso>
        Task<DeleteDBClusterSnapshotResponse> DeleteDBClusterSnapshotAsync(DeleteDBClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDBInstance


        /// <summary>
        /// The DeleteDBInstance action deletes a previously provisioned DB instance. When you
        /// delete a DB instance, all automated backups for that instance are deleted and can't
        /// be recovered. Manual DB snapshots of the DB instance to be deleted by <code>DeleteDBInstance</code>
        /// are not deleted.
        /// 
        ///  
        /// <para>
        ///  If you request a final DB snapshot the status of the Amazon Neptune DB instance is
        /// <code>deleting</code> until the DB snapshot is created. The API action <code>DescribeDBInstance</code>
        /// is used to monitor the status of this operation. The action can't be canceled or reverted
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
        /// If the specified DB instance is part of an Amazon Aurora DB cluster, you can't delete
        /// the DB instance if both of the following conditions are true:
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
        /// <returns>The response from the DeleteDBInstance service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSnapshotAlreadyExistsException">
        /// <i>DBSnapshotIdentifier</i> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DeleteDBInstance">REST API Reference for DeleteDBInstance Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DeleteDBInstance">REST API Reference for DeleteDBInstance Operation</seealso>
        Task<DeleteDBInstanceResponse> DeleteDBInstanceAsync(DeleteDBInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDBParameterGroup


        /// <summary>
        /// Deletes a specified DBParameterGroup. The DBParameterGroup to be deleted can't be
        /// associated with any DB instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you cannot delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DeleteDBParameterGroup">REST API Reference for DeleteDBParameterGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DeleteDBParameterGroup">REST API Reference for DeleteDBParameterGroup Operation</seealso>
        Task<DeleteDBParameterGroupResponse> DeleteDBParameterGroupAsync(DeleteDBParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <returns>The response from the DeleteDBSubnetGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSubnetStateException">
        /// The DB subnet is not in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DeleteDBSubnetGroup">REST API Reference for DeleteDBSubnetGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DeleteDBSubnetGroup">REST API Reference for DeleteDBSubnetGroup Operation</seealso>
        Task<DeleteDBSubnetGroupResponse> DeleteDBSubnetGroupAsync(DeleteDBSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEventSubscription


        /// <summary>
        /// Deletes an RDS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.InvalidEventSubscriptionStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameterGroups service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBClusterParameterGroups">REST API Reference for DescribeDBClusterParameterGroups Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBClusterParameterGroups">REST API Reference for DescribeDBClusterParameterGroups Operation</seealso>
        Task<DescribeDBClusterParameterGroupsResponse> DescribeDBClusterParameterGroupsAsync(DescribeDBClusterParameterGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBClusterParameters


        /// <summary>
        /// Returns the detailed parameter list for a particular DB cluster parameter group.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameters service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBClusterParameters">REST API Reference for DescribeDBClusterParameters Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBClusterParameters">REST API Reference for DescribeDBClusterParameters Operation</seealso>
        Task<DescribeDBClusterParametersResponse> DescribeDBClusterParametersAsync(DescribeDBClusterParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBClusters


        /// <summary>
        /// Returns information about provisioned Aurora DB clusters. This API supports pagination.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusters service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBClusters">REST API Reference for DescribeDBClusters Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBClusters">REST API Reference for DescribeDBClusters Operation</seealso>
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
        /// <returns>The response from the DescribeDBClusterSnapshotAttributes service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBClusterSnapshotAttributes">REST API Reference for DescribeDBClusterSnapshotAttributes Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBClusterSnapshotAttributes">REST API Reference for DescribeDBClusterSnapshotAttributes Operation</seealso>
        Task<DescribeDBClusterSnapshotAttributesResponse> DescribeDBClusterSnapshotAttributesAsync(DescribeDBClusterSnapshotAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBClusterSnapshots


        /// <summary>
        /// Returns information about DB cluster snapshots. This API action supports pagination.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshots service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBClusterSnapshots">REST API Reference for DescribeDBClusterSnapshots Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBClusterSnapshots">REST API Reference for DescribeDBClusterSnapshots Operation</seealso>
        Task<DescribeDBClusterSnapshotsResponse> DescribeDBClusterSnapshotsAsync(DescribeDBClusterSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBEngineVersions


        /// <summary>
        /// Returns a list of the available DB engines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        DescribeDBEngineVersionsResponse DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBEngineVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        Task<DescribeDBEngineVersionsResponse> DescribeDBEngineVersionsAsync(DescribeDBEngineVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBInstances


        /// <summary>
        /// Returns information about provisioned RDS instances. This API supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(DescribeDBInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBParameterGroups


        /// <summary>
        /// Returns a list of <code>DBParameterGroup</code> descriptions. If a <code>DBParameterGroupName</code>
        /// is specified, the list will contain only the description of the specified DB parameter
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBParameterGroups">REST API Reference for DescribeDBParameterGroups Operation</seealso>
        DescribeDBParameterGroupsResponse DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBParameterGroups">REST API Reference for DescribeDBParameterGroups Operation</seealso>
        Task<DescribeDBParameterGroupsResponse> DescribeDBParameterGroupsAsync(DescribeDBParameterGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDBParameters


        /// <summary>
        /// Returns the detailed parameter list for a particular DB parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeDBParameters service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBParameters">REST API Reference for DescribeDBParameters Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBParameters">REST API Reference for DescribeDBParameters Operation</seealso>
        Task<DescribeDBParametersResponse> DescribeDBParametersAsync(DescribeDBParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
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
        /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultClusterParameters service method, as returned by Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeEngineDefaultClusterParameters">REST API Reference for DescribeEngineDefaultClusterParameters Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeEngineDefaultClusterParameters">REST API Reference for DescribeEngineDefaultClusterParameters Operation</seealso>
        Task<DescribeEngineDefaultClusterParametersResponse> DescribeEngineDefaultClusterParametersAsync(DescribeEngineDefaultClusterParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEngineDefaultParameters


        /// <summary>
        /// Returns the default engine and system parameter information for the specified database
        /// engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeEngineDefaultParameters">REST API Reference for DescribeEngineDefaultParameters Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeEngineDefaultParameters">REST API Reference for DescribeEngineDefaultParameters Operation</seealso>
        Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEventCategories


        /// <summary>
        /// Displays a list of categories for all event source types, or, if specified, for a
        /// specified source type. You can see a list of the event categories and source types
        /// in the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">
        /// Events</a> topic in the <i>Amazon Neptune User Guide.</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEvents


        /// <summary>
        /// Returns events related to DB instances, DB security groups, DB snapshots, and DB parameter
        /// groups for the past 14 days. Events specific to a particular DB instance, DB security
        /// group, database snapshot, or DB parameter group can be obtained by providing the name
        /// as a parameter. By default, the past hour of events are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeOrderableDBInstanceOptions


        /// <summary>
        /// Returns a list of orderable DB instance options for the specified engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeOrderableDBInstanceOptions service method, as returned by Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeOrderableDBInstanceOptions">REST API Reference for DescribeOrderableDBInstanceOptions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeOrderableDBInstanceOptions">REST API Reference for DescribeOrderableDBInstanceOptions Operation</seealso>
        Task<DescribeOrderableDBInstanceOptionsResponse> DescribeOrderableDBInstanceOptionsAsync(DescribeOrderableDBInstanceOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePendingMaintenanceActions


        /// <summary>
        /// Returns a list of resources (for example, DB instances) that have at least one pending
        /// maintenance action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingMaintenanceActions service method.</param>
        /// 
        /// <returns>The response from the DescribePendingMaintenanceActions service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        Task<DescribePendingMaintenanceActionsResponse> DescribePendingMaintenanceActionsAsync(DescribePendingMaintenanceActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeValidDBInstanceModifications


        /// <summary>
        /// You can call <a>DescribeValidDBInstanceModifications</a> to learn what modifications
        /// you can make to your DB instance. You can use this information when you call <a>ModifyDBInstance</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeValidDBInstanceModifications service method.</param>
        /// 
        /// <returns>The response from the DescribeValidDBInstanceModifications service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeValidDBInstanceModifications">REST API Reference for DescribeValidDBInstanceModifications Operation</seealso>
        DescribeValidDBInstanceModificationsResponse DescribeValidDBInstanceModifications(DescribeValidDBInstanceModificationsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeValidDBInstanceModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeValidDBInstanceModifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/DescribeValidDBInstanceModifications">REST API Reference for DescribeValidDBInstanceModifications Operation</seealso>
        Task<DescribeValidDBInstanceModificationsResponse> DescribeValidDBInstanceModificationsAsync(DescribeValidDBInstanceModificationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  FailoverDBCluster


        /// <summary>
        /// Forces a failover for a DB cluster.
        /// 
        ///  
        /// <para>
        /// A failover for a DB cluster promotes one of the Aurora Replicas (read-only instances)
        /// in the DB cluster to be the primary instance (the cluster writer).
        /// </para>
        ///  
        /// <para>
        /// Amazon Aurora will automatically fail over to an Aurora Replica, if one exists, when
        /// the primary instance fails. You can force a failover when you want to simulate a failure
        /// of a primary instance for testing. Because each instance in a DB cluster has its own
        /// endpoint address, you will need to clean up and re-establish any existing connections
        /// that use those endpoint addresses when the failover is complete.
        /// </para>
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverDBCluster service method.</param>
        /// 
        /// <returns>The response from the FailoverDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/FailoverDBCluster">REST API Reference for FailoverDBCluster Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/FailoverDBCluster">REST API Reference for FailoverDBCluster Operation</seealso>
        Task<FailoverDBClusterResponse> FailoverDBClusterAsync(FailoverDBClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags on an Amazon Neptune resource.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging an Amazon Neptune resource, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging
        /// Amazon Neptune Resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyDBCluster


        /// <summary>
        /// Modify a setting for an Amazon Aurora DB cluster. You can change one or more database
        /// configuration parameters by specifying these parameters and the new values in the
        /// request. For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterAlreadyExistsException">
        /// User already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterParameterGroupNotFoundException">
        /// <i>DBClusterParameterGroupName</i> does not refer to an existing DB Cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ModifyDBCluster">REST API Reference for ModifyDBCluster Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ModifyDBCluster">REST API Reference for ModifyDBCluster Operation</seealso>
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
        /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
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
        /// the default parameter group. This allows Amazon Neptune to fully complete the create
        /// action before the parameter group is used as the default for a new DB cluster. This
        /// is especially important for parameters that are critical when creating the default
        /// database for a DB cluster, such as the character set for the default database defined
        /// by the <code>character_set_database</code> parameter. You can use the <i>Parameter
        /// Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon Neptune
        /// console</a> or the <a>DescribeDBClusterParameters</a> command to verify that your
        /// DB cluster parameter group has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBClusterParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you cannot delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ModifyDBClusterParameterGroup">REST API Reference for ModifyDBClusterParameterGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ModifyDBClusterParameterGroup">REST API Reference for ModifyDBClusterParameterGroup Operation</seealso>
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
        /// information that you don't want available to all AWS accounts. If a manual DB cluster
        /// snapshot is encrypted, it can be shared, but only by specifying a list of authorized
        /// AWS account IDs for the <code>ValuesToAdd</code> parameter. You can't use <code>all</code>
        /// as a value for that parameter in this case.
        /// </para>
        ///  
        /// <para>
        /// To view which AWS accounts have access to copy or restore a manual DB cluster snapshot,
        /// or whether a manual DB cluster snapshot public or private, use the <a>DescribeDBClusterSnapshotAttributes</a>
        /// API action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterSnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyDBClusterSnapshotAttribute service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SharedSnapshotQuotaExceededException">
        /// You have exceeded the maximum number of accounts that you can share a manual DB snapshot
        /// with.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ModifyDBClusterSnapshotAttribute">REST API Reference for ModifyDBClusterSnapshotAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ModifyDBClusterSnapshotAttribute">REST API Reference for ModifyDBClusterSnapshotAttribute Operation</seealso>
        Task<ModifyDBClusterSnapshotAttributeResponse> ModifyDBClusterSnapshotAttributeAsync(ModifyDBClusterSnapshotAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyDBInstance


        /// <summary>
        /// Modifies settings for a DB instance. You can change one or more database configuration
        /// parameters by specifying these parameters and the new values in the request. To learn
        /// what modifications you can make to your DB instance, call <a>DescribeValidDBInstanceModifications</a>
        /// before you call <a>ModifyDBInstance</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance service method.</param>
        /// 
        /// <returns>The response from the ModifyDBInstance service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.AuthorizationNotFoundException">
        /// Specified CIDRIP or EC2 security group is not authorized for the specified DB security
        /// group.
        /// 
        ///  
        /// <para>
        /// Neptune may not also be authorized via IAM to perform necessary actions on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.CertificateNotFoundException">
        /// <i>CertificateIdentifier</i> does not refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceAlreadyExistsException">
        /// User already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBUpgradeDependencyFailureException">
        /// The DB upgrade failed because a resource the DB depends on could not be modified.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DomainNotFoundException">
        /// <i>Domain</i> does not refer to an existing Active Directory Domain.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientDBInstanceCapacityException">
        /// Specified DB instance class is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.OptionGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageTypeNotSupportedException">
        /// <i>StorageType</i> specified cannot be associated with the DB Instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ModifyDBInstance">REST API Reference for ModifyDBInstance Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ModifyDBInstance">REST API Reference for ModifyDBInstance Operation</seealso>
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
        /// group. This allows Amazon Neptune to fully complete the modify action before the parameter
        /// group is used as the default for a new DB instance. This is especially important for
        /// parameters that are critical when creating the default database for a DB instance,
        /// such as the character set for the default database defined by the <code>character_set_database</code>
        /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
        /// Neptune console</a> or the <i>DescribeDBParameters</i> command to verify that your
        /// DB parameter group has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you cannot delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ModifyDBParameterGroup">REST API Reference for ModifyDBParameterGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ModifyDBParameterGroup">REST API Reference for ModifyDBParameterGroup Operation</seealso>
        Task<ModifyDBParameterGroupResponse> ModifyDBParameterGroupAsync(ModifyDBParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyDBSubnetGroup


        /// <summary>
        /// Modifies an existing DB subnet group. DB subnet groups must contain at least one subnet
        /// in at least two AZs in the AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBSubnetGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetQuotaExceededException">
        /// Request would result in user exceeding the allowed number of subnets in a DB subnet
        /// groups.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubnetAlreadyInUseException">
        /// The DB subnet is already in use in the Availability Zone.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ModifyDBSubnetGroup">REST API Reference for ModifyDBSubnetGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ModifyDBSubnetGroup">REST API Reference for ModifyDBSubnetGroup Operation</seealso>
        Task<ModifyDBSubnetGroupResponse> ModifyDBSubnetGroupAsync(ModifyDBSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyEventSubscription


        /// <summary>
        /// Modifies an existing RDS event notification subscription. Note that you can't modify
        /// the source identifiers using this call; to change source identifiers for a subscription,
        /// use the <a>AddSourceIdentifierToSubscription</a> and <a>RemoveSourceIdentifierFromSubscription</a>
        /// calls.
        /// 
        ///  
        /// <para>
        /// You can see a list of the event categories for a given SourceType in the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">Events</a>
        /// topic in the Amazon Neptune User Guide or by using the <b>DescribeEventCategories</b>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.EventSubscriptionQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SNSInvalidTopicException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SNSNoAuthorizationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SNSTopicArnNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionCategoryNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PromoteReadReplicaDBCluster


        /// <summary>
        /// Promotes a Read Replica DB cluster to a standalone DB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplicaDBCluster service method.</param>
        /// 
        /// <returns>The response from the PromoteReadReplicaDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/PromoteReadReplicaDBCluster">REST API Reference for PromoteReadReplicaDBCluster Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/PromoteReadReplicaDBCluster">REST API Reference for PromoteReadReplicaDBCluster Operation</seealso>
        Task<PromoteReadReplicaDBClusterResponse> PromoteReadReplicaDBClusterAsync(PromoteReadReplicaDBClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RebootDBInstance


        /// <summary>
        /// You might need to reboot your DB instance, usually for maintenance reasons. For example,
        /// if you make certain modifications, or if you change the DB parameter group associated
        /// with the DB instance, you must reboot the instance for the changes to take effect.
        /// 
        /// 
        ///  
        /// <para>
        /// Rebooting a DB instance restarts the database engine service. Rebooting a DB instance
        /// results in a momentary outage, during which the DB instance status is set to rebooting.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information about rebooting, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_RebootInstance.html">Rebooting
        /// a DB Instance</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance service method.</param>
        /// 
        /// <returns>The response from the RebootDBInstance service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/RebootDBInstance">REST API Reference for RebootDBInstance Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/RebootDBInstance">REST API Reference for RebootDBInstance Operation</seealso>
        Task<RebootDBInstanceResponse> RebootDBInstanceAsync(RebootDBInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveRoleFromDBCluster


        /// <summary>
        /// Disassociates an Identity and Access Management (IAM) role from an Aurora DB cluster.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Aurora.Authorizing.AWSServices.html">Authorizing
        /// Amazon Aurora to Access Other AWS Services On Your Behalf</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromDBCluster service method.</param>
        /// 
        /// <returns>The response from the RemoveRoleFromDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterRoleNotFoundException">
        /// The specified IAM role Amazon Resource Name (ARN) is not associated with the specified
        /// DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/RemoveRoleFromDBCluster">REST API Reference for RemoveRoleFromDBCluster Operation</seealso>
        RemoveRoleFromDBClusterResponse RemoveRoleFromDBCluster(RemoveRoleFromDBClusterRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveRoleFromDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/RemoveRoleFromDBCluster">REST API Reference for RemoveRoleFromDBCluster Operation</seealso>
        Task<RemoveRoleFromDBClusterResponse> RemoveRoleFromDBClusterAsync(RemoveRoleFromDBClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveSourceIdentifierFromSubscription


        /// <summary>
        /// Removes a source identifier from an existing RDS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription service method.</param>
        /// 
        /// <returns>The response from the RemoveSourceIdentifierFromSubscription service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.SourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/RemoveSourceIdentifierFromSubscription">REST API Reference for RemoveSourceIdentifierFromSubscription Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/RemoveSourceIdentifierFromSubscription">REST API Reference for RemoveSourceIdentifierFromSubscription Operation</seealso>
        Task<RemoveSourceIdentifierFromSubscriptionResponse> RemoveSourceIdentifierFromSubscriptionAsync(RemoveSourceIdentifierFromSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveTagsFromResource


        /// <summary>
        /// Removes metadata tags from an Amazon Neptune resource.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging an Amazon Neptune resource, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging
        /// Amazon Neptune Resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
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
        /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetDBClusterParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you cannot delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ResetDBClusterParameterGroup">REST API Reference for ResetDBClusterParameterGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ResetDBClusterParameterGroup">REST API Reference for ResetDBClusterParameterGroup Operation</seealso>
        Task<ResetDBClusterParameterGroupResponse> ResetDBClusterParameterGroupAsync(ResetDBClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResetDBParameterGroup


        /// <summary>
        /// Modifies the parameters of a DB parameter group to the engine/system default value.
        /// To reset specific parameters, provide a list of the following: <code>ParameterName</code>
        /// and <code>ApplyMethod</code>. To reset the entire DB parameter group, specify the
        /// <code>DBParameterGroup</code> name and <code>ResetAllParameters</code> parameters.
        /// When resetting the entire group, dynamic parameters are updated immediately and static
        /// parameters are set to <code>pending-reboot</code> to take effect on the next DB instance
        /// restart or <code>RebootDBInstance</code> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetDBParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you cannot delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ResetDBParameterGroup">REST API Reference for ResetDBParameterGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/ResetDBParameterGroup">REST API Reference for ResetDBParameterGroup Operation</seealso>
        Task<ResetDBParameterGroupResponse> ResetDBParameterGroupAsync(ResetDBParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RestoreDBClusterFromS3


        /// <summary>
        /// Creates an Amazon Aurora DB cluster from data stored in an Amazon S3 bucket. Amazon
        /// Neptune must be authorized to access the Amazon S3 bucket and the data must be created
        /// using the Percona XtraBackup utility as described in <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Aurora.Migrate.MySQL.html#Aurora.Migrate.MySQL.S3">Migrating
        /// Data from MySQL by Using an Amazon S3 Bucket</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromS3 service method.</param>
        /// 
        /// <returns>The response from the RestoreDBClusterFromS3 service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterAlreadyExistsException">
        /// User already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterParameterGroupNotFoundException">
        /// <i>DBClusterParameterGroupName</i> does not refer to an existing DB Cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterQuotaExceededException">
        /// User attempted to create a new DB cluster and the user has already reached the maximum
        /// allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You may be able to
        /// resolve this error by updating your subnet group to use different Availability Zones
        /// that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidS3BucketException">
        /// The specified Amazon S3 bucket name could not be found or Amazon Neptune is not authorized
        /// to access the specified Amazon S3 bucket. Verify the <b>SourceS3BucketName</b> and
        /// <b>S3IngestionRoleArn</b> values and try again.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/RestoreDBClusterFromS3">REST API Reference for RestoreDBClusterFromS3 Operation</seealso>
        RestoreDBClusterFromS3Response RestoreDBClusterFromS3(RestoreDBClusterFromS3Request request);


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBClusterFromS3 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromS3 operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/RestoreDBClusterFromS3">REST API Reference for RestoreDBClusterFromS3 Operation</seealso>
        Task<RestoreDBClusterFromS3Response> RestoreDBClusterFromS3Async(RestoreDBClusterFromS3Request request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RestoreDBClusterFromSnapshot


        /// <summary>
        /// Creates a new DB cluster from a DB snapshot or DB cluster snapshot.
        /// 
        ///  
        /// <para>
        /// If a DB snapshot is specified, the target DB cluster is created from the source DB
        /// snapshot with a default configuration and default security group.
        /// </para>
        ///  
        /// <para>
        /// If a DB cluster snapshot is specified, the target DB cluster is created from the source
        /// DB cluster restore point with the same configuration as the original source DB cluster,
        /// except that the new DB cluster is created with the default security group.
        /// </para>
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreDBClusterFromSnapshot service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterAlreadyExistsException">
        /// User already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterQuotaExceededException">
        /// User attempted to create a new DB cluster and the user has already reached the maximum
        /// allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientDBClusterCapacityException">
        /// The DB cluster does not have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You may be able to
        /// resolve this error by updating your subnet group to use different Availability Zones
        /// that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidRestoreException">
        /// Cannot restore from vpc backup to non-vpc DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.OptionGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/RestoreDBClusterFromSnapshot">REST API Reference for RestoreDBClusterFromSnapshot Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/RestoreDBClusterFromSnapshot">REST API Reference for RestoreDBClusterFromSnapshot Operation</seealso>
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
        ///  <note> 
        /// <para>
        /// This action only restores the DB cluster, not the DB instances for that DB cluster.
        /// You must invoke the <a>CreateDBInstance</a> action to create DB instances for the
        /// restored DB cluster, specifying the identifier of the restored DB cluster in <code>DBClusterIdentifier</code>.
        /// You can create DB instances only after the <code>RestoreDBClusterToPointInTime</code>
        /// action has completed and the DB cluster is available.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
        /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterToPointInTime service method.</param>
        /// 
        /// <returns>The response from the RestoreDBClusterToPointInTime service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterAlreadyExistsException">
        /// User already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterQuotaExceededException">
        /// User attempted to create a new DB cluster and the user has already reached the maximum
        /// allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientDBClusterCapacityException">
        /// The DB cluster does not have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You may be able to
        /// resolve this error by updating your subnet group to use different Availability Zones
        /// that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidRestoreException">
        /// Cannot restore from vpc backup to non-vpc DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.OptionGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/RestoreDBClusterToPointInTime">REST API Reference for RestoreDBClusterToPointInTime Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2018-05-15/RestoreDBClusterToPointInTime">REST API Reference for RestoreDBClusterToPointInTime Operation</seealso>
        Task<RestoreDBClusterToPointInTimeResponse> RestoreDBClusterToPointInTimeAsync(RestoreDBClusterToPointInTimeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}