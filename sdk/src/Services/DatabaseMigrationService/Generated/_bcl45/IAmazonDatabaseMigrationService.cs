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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.DatabaseMigrationService.Model;

namespace Amazon.DatabaseMigrationService
{
    /// <summary>
    /// Interface for accessing DatabaseMigrationService
    ///
    /// AWS Database Migration Service 
    /// <para>
    ///  AWS Database Migration Service (AWS DMS) can migrate your data to and from the most
    /// widely used commercial and open-source databases such as Oracle, PostgreSQL, Microsoft
    /// SQL Server, MariaDB, Amazon Aurora, and MySQL. The service supports homogeneous migrations
    /// such as Oracle to Oracle, as well as heterogeneous migrations between different database
    /// platforms, such as Oracle to MySQL or SQL Server to PostgreSQL. 
    /// </para>
    /// </summary>
    public partial interface IAmazonDatabaseMigrationService : IDisposable
    {

        
        #region  AddTagsToResource


        /// <summary>
        /// For internal use only
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
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
        
        #region  CreateEndpoint


        /// <summary>
        /// Creates an endpoint using the provided settings.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateEndpoint service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// 
        /// </exception>
        CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateReplicationInstance


        /// <summary>
        /// Creates the replication instance using the specified parameters.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationInstance service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationInstance service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InsufficientResourceCapacityException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidSubnetException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ReplicationSubnetGroupDoesNotCoverEnoughAZsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.StorageQuotaExceededException">
        /// 
        /// </exception>
        CreateReplicationInstanceResponse CreateReplicationInstance(CreateReplicationInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateReplicationInstanceResponse> CreateReplicationInstanceAsync(CreateReplicationInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateReplicationSubnetGroup


        /// <summary>
        /// Creates a replication subnet group given a list of the subnet IDs in a VPC.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationSubnetGroup service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidSubnetException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ReplicationSubnetGroupDoesNotCoverEnoughAZsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// 
        /// </exception>
        CreateReplicationSubnetGroupResponse CreateReplicationSubnetGroup(CreateReplicationSubnetGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateReplicationSubnetGroupResponse> CreateReplicationSubnetGroupAsync(CreateReplicationSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateReplicationTask


        /// <summary>
        /// Creates a replication task using the specified parameters.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationTask service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// 
        /// </exception>
        CreateReplicationTaskResponse CreateReplicationTask(CreateReplicationTaskRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateReplicationTaskResponse> CreateReplicationTaskAsync(CreateReplicationTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEndpoint


        /// <summary>
        /// Deletes the specified endpoint. 
        /// 
        ///  <note>All tasks associated with the endpoint must be deleted before you can delete
        /// the endpoint.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteReplicationInstance


        /// <summary>
        /// Deletes the specified replication instance. 
        /// 
        ///  <note>You must delete any migration tasks that are associated with the replication
        /// instance before you can delete it.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationInstance service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        DeleteReplicationInstanceResponse DeleteReplicationInstance(DeleteReplicationInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteReplicationInstanceResponse> DeleteReplicationInstanceAsync(DeleteReplicationInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteReplicationSubnetGroup


        /// <summary>
        /// Deletes a subnet group.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationSubnetGroup service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        DeleteReplicationSubnetGroupResponse DeleteReplicationSubnetGroup(DeleteReplicationSubnetGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteReplicationSubnetGroupResponse> DeleteReplicationSubnetGroupAsync(DeleteReplicationSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteReplicationTask


        /// <summary>
        /// Deletes the specified replication task.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationTask service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        DeleteReplicationTaskResponse DeleteReplicationTask(DeleteReplicationTaskRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteReplicationTaskResponse> DeleteReplicationTaskAsync(DeleteReplicationTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAccountAttributes


        /// <summary>
        /// Lists all of the AWS DMS attributes for a customer account. The attributes include
        /// AWS DMS quotas for the account, such as the number of replication instances allowed.
        /// The description for a quota includes the quota name, current usage toward that quota,
        /// and the quota's maximum value. 
        /// 
        ///  
        /// <para>
        /// This command does not take any parameters.
        /// </para>
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by DatabaseMigrationService.</returns>
        DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request);


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
        
        #region  DescribeConnections


        /// <summary>
        /// Describes the status of the connections that have been made between the replication
        /// instance and an endpoint. Connections are created when you test an endpoint.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        DescribeConnectionsResponse DescribeConnections(DescribeConnectionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeConnectionsResponse> DescribeConnectionsAsync(DescribeConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEndpoints


        /// <summary>
        /// Returns information about the endpoints for your account in the current region.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpoints service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        DescribeEndpointsResponse DescribeEndpoints(DescribeEndpointsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEndpointsResponse> DescribeEndpointsAsync(DescribeEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEndpointTypes


        /// <summary>
        /// Returns information about the type of endpoints available.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpointTypes service method, as returned by DatabaseMigrationService.</returns>
        DescribeEndpointTypesResponse DescribeEndpointTypes(DescribeEndpointTypesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpointTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEndpointTypesResponse> DescribeEndpointTypesAsync(DescribeEndpointTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeOrderableReplicationInstances


        /// <summary>
        /// Returns information about the replication instance types that can be created in the
        /// specified region.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableReplicationInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeOrderableReplicationInstances service method, as returned by DatabaseMigrationService.</returns>
        DescribeOrderableReplicationInstancesResponse DescribeOrderableReplicationInstances(DescribeOrderableReplicationInstancesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableReplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableReplicationInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeOrderableReplicationInstancesResponse> DescribeOrderableReplicationInstancesAsync(DescribeOrderableReplicationInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRefreshSchemasStatus


        /// <summary>
        /// Returns the status of the RefreshSchemas operation.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRefreshSchemasStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeRefreshSchemasStatus service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        DescribeRefreshSchemasStatusResponse DescribeRefreshSchemasStatus(DescribeRefreshSchemasStatusRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRefreshSchemasStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRefreshSchemasStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeRefreshSchemasStatusResponse> DescribeRefreshSchemasStatusAsync(DescribeRefreshSchemasStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReplicationInstances


        /// <summary>
        /// Returns information about replication instances for your account in the current region.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationInstances service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        DescribeReplicationInstancesResponse DescribeReplicationInstances(DescribeReplicationInstancesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeReplicationInstancesResponse> DescribeReplicationInstancesAsync(DescribeReplicationInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReplicationSubnetGroups


        /// <summary>
        /// Returns information about the replication subnet groups.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationSubnetGroups service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        DescribeReplicationSubnetGroupsResponse DescribeReplicationSubnetGroups(DescribeReplicationSubnetGroupsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeReplicationSubnetGroupsResponse> DescribeReplicationSubnetGroupsAsync(DescribeReplicationSubnetGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReplicationTasks


        /// <summary>
        /// Returns information about replication tasks for your account in the current region.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationTasks service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        DescribeReplicationTasksResponse DescribeReplicationTasks(DescribeReplicationTasksRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeReplicationTasksResponse> DescribeReplicationTasksAsync(DescribeReplicationTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSchemas


        /// <summary>
        /// Returns information about the schema for the specified endpoint.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchemas service method.</param>
        /// 
        /// <returns>The response from the DescribeSchemas service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        DescribeSchemasResponse DescribeSchemas(DescribeSchemasRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchemas operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeSchemasResponse> DescribeSchemasAsync(DescribeSchemasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTableStatistics


        /// <summary>
        /// Returns table statistics on the database migration task, including table name, rows
        /// inserted, rows updated, and rows deleted.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableStatistics service method.</param>
        /// 
        /// <returns>The response from the DescribeTableStatistics service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        DescribeTableStatisticsResponse DescribeTableStatistics(DescribeTableStatisticsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTableStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableStatistics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTableStatisticsResponse> DescribeTableStatisticsAsync(DescribeTableStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// For internal use only
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
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
        
        #region  ModifyEndpoint


        /// <summary>
        /// Modifies the specified endpoint.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEndpoint service method.</param>
        /// 
        /// <returns>The response from the ModifyEndpoint service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        ModifyEndpointResponse ModifyEndpoint(ModifyEndpointRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyEndpointResponse> ModifyEndpointAsync(ModifyEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyReplicationInstance


        /// <summary>
        /// Modifies the replication instance to apply new settings. You can change one or more
        /// parameters by specifying these parameters and the new values in the request.
        /// 
        ///  <note>Some settings are applied during the maintenance window.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationInstance service method.</param>
        /// 
        /// <returns>The response from the ModifyReplicationInstance service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InsufficientResourceCapacityException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.StorageQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.UpgradeDependencyFailureException">
        /// 
        /// </exception>
        ModifyReplicationInstanceResponse ModifyReplicationInstance(ModifyReplicationInstanceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyReplicationInstanceResponse> ModifyReplicationInstanceAsync(ModifyReplicationInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyReplicationSubnetGroup


        /// <summary>
        /// Modifies the settings for the specified replication subnet group.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyReplicationSubnetGroup service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidSubnetException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ReplicationSubnetGroupDoesNotCoverEnoughAZsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.SubnetAlreadyInUseException">
        /// 
        /// </exception>
        ModifyReplicationSubnetGroupResponse ModifyReplicationSubnetGroup(ModifyReplicationSubnetGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyReplicationSubnetGroupResponse> ModifyReplicationSubnetGroupAsync(ModifyReplicationSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RefreshSchemas


        /// <summary>
        /// Populates the schema for the specified endpoint. This is an asynchronous operation
        /// and can take several minutes. You can check the status of this operation by calling
        /// the DescribeRefreshSchemasStatus operation.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RefreshSchemas service method.</param>
        /// 
        /// <returns>The response from the RefreshSchemas service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// 
        /// </exception>
        RefreshSchemasResponse RefreshSchemas(RefreshSchemasRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RefreshSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RefreshSchemas operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RefreshSchemasResponse> RefreshSchemasAsync(RefreshSchemasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveTagsFromResource


        /// <summary>
        /// For internal use only
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
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
        
        #region  StartReplicationTask


        /// <summary>
        /// Starts the replication task.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplicationTask service method.</param>
        /// 
        /// <returns>The response from the StartReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        StartReplicationTaskResponse StartReplicationTask(StartReplicationTaskRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StartReplicationTaskResponse> StartReplicationTaskAsync(StartReplicationTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopReplicationTask


        /// <summary>
        /// Stops the replication task.
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopReplicationTask service method.</param>
        /// 
        /// <returns>The response from the StopReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        StopReplicationTaskResponse StopReplicationTask(StopReplicationTaskRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StopReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StopReplicationTaskResponse> StopReplicationTaskAsync(StopReplicationTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TestConnection


        /// <summary>
        /// Tests the connection between the replication instance and the endpoint. 
        /// 
        ///  <note/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestConnection service method.</param>
        /// 
        /// <returns>The response from the TestConnection service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// 
        /// </exception>
        TestConnectionResponse TestConnection(TestConnectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the TestConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TestConnectionResponse> TestConnectionAsync(TestConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}