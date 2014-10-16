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
 * Do not modify this file. This file is generated from the rds-2014-09-01.normal.json service model.
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
    /// resizable capacity for an industry-standard relational database and manages common
    /// database administration tasks, freeing up developers to focus on what makes their
    /// applications and businesses unique. 
    /// </para>
    ///  
    /// <para>
    ///  Amazon RDS gives you access to the capabilities of a MySQL, PostgreSQL, Microsoft
    /// SQL Server, or Oracle database server. This means the code, applications, and tools
    /// you already use today with your existing databases work with Amazon RDS without modification.
    /// Amazon RDS automatically backs up your database and maintains the database software
    /// that powers your DB instance. Amazon RDS is flexible: you can scale your database
    /// instance's compute resources and storage capacity to meet your application's demand.
    /// As with all Amazon Web Services, there are no up-front investments, and you pay only
    /// for the resources you use. 
    /// </para>
    ///  
    /// <para>
    ///  This is an interface reference for Amazon RDS. It contains documentation for a programming
    /// or command line interface you can use to manage Amazon RDS. Note that Amazon RDS is
    /// asynchronous, which means that some interfaces may require techniques such as polling
    /// or callback functions to determine when a command has been applied. In this reference,
    /// the parameter descriptions indicate whether a command is applied immediately, on the
    /// next instance reboot, or during the maintenance window. For a summary of the Amazon
    /// RDS interfaces, go to <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Welcome.html#Welcome.Interfaces">Available
    /// RDS Interfaces</a>. 
    /// </para>
    /// </summary>
    public partial interface IAmazonRDS : IDisposable
    {
                
        #region  AddSourceIdentifierToSubscription

        /// <summary>
        /// Initiates the asynchronous execution of the AddSourceIdentifierToSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AuthorizeDBSecurityGroupIngress

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeDBSecurityGroupIngress operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeDBSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AuthorizeDBSecurityGroupIngressResponse> AuthorizeDBSecurityGroupIngressAsync(AuthorizeDBSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CopyDBParameterGroup

        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the CopyDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the CopyOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CopyOptionGroupResponse> CopyOptionGroupAsync(CopyOptionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDBInstance

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the CreateDBInstanceReadReplica operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the CreateDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the CreateDBSecurityGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the CreateDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the CreateDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the CreateOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateOptionGroupResponse> CreateOptionGroupAsync(CreateOptionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDBInstance

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DeleteDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DeleteDBSecurityGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DeleteDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DeleteDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DeleteOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteOptionGroupResponse> DeleteOptionGroupAsync(DeleteOptionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBEngineVersions

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBEngineVersions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DescribeDBInstances operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DescribeDBLogFiles operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DescribeDBParameterGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DescribeDBParameters operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DescribeDBSecurityGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroupsAsync(DescribeDBSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDBSnapshots

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSnapshots operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DescribeDBSubnetGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDBSubnetGroupsResponse> DescribeDBSubnetGroupsAsync(DescribeDBSubnetGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEngineDefaultParameters

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DescribeOptionGroupOptions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DescribeOptionGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DescribeOrderableDBInstanceOptions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeOrderableDBInstanceOptionsResponse> DescribeOrderableDBInstanceOptionsAsync(DescribeOrderableDBInstanceOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReservedDBInstances

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedDBInstances operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DescribeReservedDBInstancesOfferings operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the DownloadDBLogFilePortion operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DownloadDBLogFilePortion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DownloadDBLogFilePortionResponse> DownloadDBLogFilePortionAsync(DownloadDBLogFilePortionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyDBInstance

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the ModifyDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyDBParameterGroupResponse> ModifyDBParameterGroupAsync(ModifyDBParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyDBSubnetGroup

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the ModifyOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the PromoteReadReplica operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplica operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PromoteReadReplicaResponse> PromoteReadReplicaAsync(PromoteReadReplicaRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PurchaseReservedDBInstancesOffering

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedDBInstancesOffering operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the RebootDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the RemoveSourceIdentifierFromSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetDBParameterGroup

        /// <summary>
        /// Initiates the asynchronous execution of the ResetDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ResetDBParameterGroupResponse> ResetDBParameterGroupAsync(ResetDBParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreDBInstanceFromDBSnapshot

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceFromDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the RestoreDBInstanceToPointInTime operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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
        /// Initiates the asynchronous execution of the RevokeDBSecurityGroupIngress operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
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