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
    ///  Amazon Relational Database Service (Amazon RDS) is a web service that makes it easier
    /// to set up, operate, and scale a relational database in the cloud. It provides cost-efficient,
    /// resizeable capacity for an industry-standard relational database and manages common
    /// database administration tasks, freeing up developers to focus on what makes their
    /// applications and businesses unique. 
    /// </para>
    ///  
    /// <para>
    ///  Amazon RDS gives you access to the capabilities of a MySQL, MariaDB, PostgreSQL,
    /// Microsoft SQL Server, Oracle, or Amazon Aurora database server. These capabilities
    /// mean that the code, applications, and tools you already use today with your existing
    /// databases work with Amazon RDS without modification. Amazon RDS automatically backs
    /// up your database and maintains the database software that powers your DB instance.
    /// Amazon RDS is flexible: you can scale your database instance's compute resources and
    /// storage capacity to meet your application's demand. As with all Amazon Web Services,
    /// there are no up-front investments, and you pay only for the resources you use. 
    /// </para>
    ///  
    /// <para>
    ///  This interface reference for Amazon RDS contains documentation for a programming
    /// or command line interface you can use to manage Amazon RDS. Note that Amazon RDS is
    /// asynchronous, which means that some interfaces might require techniques such as polling
    /// or callback functions to determine when a command has been applied. In this reference,
    /// the parameter descriptions indicate whether a command is applied immediately, on the
    /// next instance reboot, or during the maintenance window. The reference structure is
    /// as follows, and we list following some related topics from the user guide. 
    /// </para>
    ///  
    /// <para>
    /// <b>Amazon RDS API Reference</b>
    /// </para>
    ///  <ul> <li>
    /// <para>
    /// For the alphabetical list of API actions, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_Operations.html">API
    /// Actions</a>.
    /// </para>
    /// </li> <li>
    /// <para>
    /// For the alphabetical list of data types, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_Types.html">Data
    /// Types</a>.
    /// </para>
    /// </li> <li>
    /// <para>
    /// For a list of common query parameters, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/APIReference/CommonParameters.html">Common
    /// Parameters</a>.
    /// </para>
    /// </li> <li>
    /// <para>
    /// For descriptions of the error codes, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/APIReference/CommonErrors.html">Common
    /// Errors</a>.
    /// </para>
    /// </li> </ul> 
    /// <para>
    /// <b>Amazon RDS User Guide</b>
    /// </para>
    ///  <ul> <li>
    /// <para>
    /// For a summary of the Amazon RDS interfaces, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Welcome.html#Welcome.Interfaces">Available
    /// RDS Interfaces</a>.
    /// </para>
    /// </li> <li>
    /// <para>
    /// For more information about how to use the Query API, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Using_the_Query_API.html">Using
    /// the Query API</a>.
    /// </para>
    /// </li> </ul>
    /// </summary>
    public partial interface IAmazonRDS : IDisposable
    {
                
        #region  AddSourceIdentifierToSubscription


        /// <summary>
        /// Initiates the asynchronous execution of the AddSourceIdentifierToSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddSourceIdentifierToSubscriptionResponse> AddSourceIdentifierToSubscriptionAsync(AddSourceIdentifierToSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AddTagsToResource


        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ApplyPendingMaintenanceAction


        /// <summary>
        /// Initiates the asynchronous execution of the ApplyPendingMaintenanceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ApplyPendingMaintenanceActionResponse> ApplyPendingMaintenanceActionAsync(ApplyPendingMaintenanceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AuthorizeDBSecurityGroupIngress


        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeDBSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeDBSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AuthorizeDBSecurityGroupIngressResponse> AuthorizeDBSecurityGroupIngressAsync(AuthorizeDBSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CopyDBClusterSnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CopyDBClusterSnapshotResponse> CopyDBClusterSnapshotAsync(CopyDBClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CopyDBParameterGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CopyDBParameterGroupResponse> CopyDBParameterGroupAsync(CopyDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CopyDBSnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CopyDBSnapshotResponse> CopyDBSnapshotAsync(CopyDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CopyOptionGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CopyOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CopyOptionGroupResponse> CopyOptionGroupAsync(CopyOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDBCluster


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDBClusterResponse> CreateDBClusterAsync(CreateDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDBClusterParameterGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDBClusterParameterGroupResponse> CreateDBClusterParameterGroupAsync(CreateDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDBClusterSnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDBClusterSnapshotResponse> CreateDBClusterSnapshotAsync(CreateDBClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDBInstance


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDBInstanceResponse> CreateDBInstanceAsync(CreateDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDBInstanceReadReplica


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstanceReadReplica operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstanceReadReplica operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDBInstanceReadReplicaResponse> CreateDBInstanceReadReplicaAsync(CreateDBInstanceReadReplicaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDBParameterGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDBParameterGroupResponse> CreateDBParameterGroupAsync(CreateDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDBSecurityGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDBSecurityGroupResponse> CreateDBSecurityGroupAsync(CreateDBSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDBSnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDBSnapshotResponse> CreateDBSnapshotAsync(CreateDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDBSubnetGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDBSubnetGroupResponse> CreateDBSubnetGroupAsync(CreateDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEventSubscription


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateOptionGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateOptionGroupResponse> CreateOptionGroupAsync(CreateOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDBCluster


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDBClusterResponse> DeleteDBClusterAsync(DeleteDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDBClusterParameterGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDBClusterParameterGroupResponse> DeleteDBClusterParameterGroupAsync(DeleteDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDBClusterSnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDBClusterSnapshotResponse> DeleteDBClusterSnapshotAsync(DeleteDBClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDBInstance


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDBInstanceResponse> DeleteDBInstanceAsync(DeleteDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDBParameterGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDBParameterGroupResponse> DeleteDBParameterGroupAsync(DeleteDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDBSecurityGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDBSecurityGroupResponse> DeleteDBSecurityGroupAsync(DeleteDBSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDBSnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDBSnapshotResponse> DeleteDBSnapshotAsync(DeleteDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDBSubnetGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDBSubnetGroupResponse> DeleteDBSubnetGroupAsync(DeleteDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEventSubscription


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteOptionGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteOptionGroupResponse> DeleteOptionGroupAsync(DeleteOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCertificates


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeCertificatesResponse> DescribeCertificatesAsync(DescribeCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBClusterParameterGroups


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBClusterParameterGroupsResponse> DescribeDBClusterParameterGroupsAsync(DescribeDBClusterParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBClusterParameters


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBClusterParametersResponse> DescribeDBClusterParametersAsync(DescribeDBClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBClusters


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBClustersResponse> DescribeDBClustersAsync(DescribeDBClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBClusterSnapshots


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBClusterSnapshotsResponse> DescribeDBClusterSnapshotsAsync(DescribeDBClusterSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBEngineVersions


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
        Task<DescribeDBEngineVersionsResponse> DescribeDBEngineVersionsAsync(DescribeDBEngineVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBInstances


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
        Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(DescribeDBInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBLogFiles


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBLogFiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBLogFiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBLogFilesResponse> DescribeDBLogFilesAsync(DescribeDBLogFilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBParameterGroups


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
        Task<DescribeDBParameterGroupsResponse> DescribeDBParameterGroupsAsync(DescribeDBParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBParameters


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBParametersResponse> DescribeDBParametersAsync(DescribeDBParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBSecurityGroups


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
        Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroupsAsync(DescribeDBSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBSnapshotAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSnapshotAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshotAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBSnapshotAttributesResponse> DescribeDBSnapshotAttributesAsync(DescribeDBSnapshotAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBSnapshots


        /// <summary>
        /// Returns information about DB snapshots. This API supports pagination.
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
        Task<DescribeDBSnapshotsResponse> DescribeDBSnapshotsAsync(DescribeDBSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DescribeDBSubnetGroupsResponse> DescribeDBSubnetGroupsAsync(DescribeDBSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEngineDefaultClusterParameters


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultClusterParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEngineDefaultClusterParametersResponse> DescribeEngineDefaultClusterParametersAsync(DescribeEngineDefaultClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEngineDefaultParameters


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEventCategories


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
        Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEvents


        /// <summary>
        /// Returns events related to DB instances, DB security groups, DB snapshots, and DB
        /// parameter groups for the past 14 days. Events specific to a particular DB instance,
        /// DB security group, database snapshot, or DB parameter group can be obtained by providing
        /// the name as a parameter. By default, the past hour of events are returned.
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
        Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeOptionGroupOptions


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOptionGroupOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroupOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeOptionGroupOptionsResponse> DescribeOptionGroupOptionsAsync(DescribeOptionGroupOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeOptionGroups


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
        Task<DescribeOptionGroupsResponse> DescribeOptionGroupsAsync(DescribeOptionGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeOrderableDBInstanceOptions


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableDBInstanceOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeOrderableDBInstanceOptionsResponse> DescribeOrderableDBInstanceOptionsAsync(DescribeOrderableDBInstanceOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePendingMaintenanceActions


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePendingMaintenanceActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingMaintenanceActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribePendingMaintenanceActionsResponse> DescribePendingMaintenanceActionsAsync(DescribePendingMaintenanceActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReservedDBInstances


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
        Task<DescribeReservedDBInstancesResponse> DescribeReservedDBInstancesAsync(DescribeReservedDBInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReservedDBInstancesOfferings


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
        Task<DescribeReservedDBInstancesOfferingsResponse> DescribeReservedDBInstancesOfferingsAsync(DescribeReservedDBInstancesOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DownloadDBLogFilePortion


        /// <summary>
        /// Initiates the asynchronous execution of the DownloadDBLogFilePortion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DownloadDBLogFilePortion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DownloadDBLogFilePortionResponse> DownloadDBLogFilePortionAsync(DownloadDBLogFilePortionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  FailoverDBCluster


        /// <summary>
        /// Initiates the asynchronous execution of the FailoverDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FailoverDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<FailoverDBClusterResponse> FailoverDBClusterAsync(FailoverDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyDBCluster


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyDBClusterResponse> ModifyDBClusterAsync(ModifyDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyDBClusterParameterGroup


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyDBClusterParameterGroupResponse> ModifyDBClusterParameterGroupAsync(ModifyDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyDBInstance


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyDBInstanceResponse> ModifyDBInstanceAsync(ModifyDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyDBParameterGroup


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyDBParameterGroupResponse> ModifyDBParameterGroupAsync(ModifyDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyDBSnapshotAttribute


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyDBSnapshotAttributeResponse> ModifyDBSnapshotAttributeAsync(ModifyDBSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyDBSubnetGroup


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyDBSubnetGroupResponse> ModifyDBSubnetGroupAsync(ModifyDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyEventSubscription


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyOptionGroup


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyOptionGroupResponse> ModifyOptionGroupAsync(ModifyOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PromoteReadReplica


        /// <summary>
        /// Initiates the asynchronous execution of the PromoteReadReplica operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplica operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PromoteReadReplicaResponse> PromoteReadReplicaAsync(PromoteReadReplicaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PurchaseReservedDBInstancesOffering


        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedDBInstancesOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedDBInstancesOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PurchaseReservedDBInstancesOfferingResponse> PurchaseReservedDBInstancesOfferingAsync(PurchaseReservedDBInstancesOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RebootDBInstance


        /// <summary>
        /// Initiates the asynchronous execution of the RebootDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RebootDBInstanceResponse> RebootDBInstanceAsync(RebootDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveSourceIdentifierFromSubscription


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveSourceIdentifierFromSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RemoveSourceIdentifierFromSubscriptionResponse> RemoveSourceIdentifierFromSubscriptionAsync(RemoveSourceIdentifierFromSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveTagsFromResource


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetDBClusterParameterGroup


        /// <summary>
        /// Initiates the asynchronous execution of the ResetDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetDBClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ResetDBClusterParameterGroupResponse> ResetDBClusterParameterGroupAsync(ResetDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetDBParameterGroup


        /// <summary>
        /// Initiates the asynchronous execution of the ResetDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ResetDBParameterGroupResponse> ResetDBParameterGroupAsync(ResetDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreDBClusterFromSnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBClusterFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RestoreDBClusterFromSnapshotResponse> RestoreDBClusterFromSnapshotAsync(RestoreDBClusterFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreDBClusterToPointInTime


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBClusterToPointInTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterToPointInTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RestoreDBClusterToPointInTimeResponse> RestoreDBClusterToPointInTimeAsync(RestoreDBClusterToPointInTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreDBInstanceFromDBSnapshot


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceFromDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RestoreDBInstanceFromDBSnapshotResponse> RestoreDBInstanceFromDBSnapshotAsync(RestoreDBInstanceFromDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreDBInstanceToPointInTime


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceToPointInTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceToPointInTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RestoreDBInstanceToPointInTimeResponse> RestoreDBInstanceToPointInTimeAsync(RestoreDBInstanceToPointInTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeDBSecurityGroupIngress


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeDBSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeDBSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RevokeDBSecurityGroupIngressResponse> RevokeDBSecurityGroupIngressAsync(RevokeDBSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}