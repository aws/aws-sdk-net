/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.TimestreamInfluxDB.Model;

#pragma warning disable CS1570

namespace Amazon.TimestreamInfluxDB
{
    /// <summary>
    /// <para>Interface for accessing TimestreamInfluxDB</para>
    ///
    /// Amazon Timestream for InfluxDB is a managed time-series database engine that makes
    /// it easy for application developers and DevOps teams to run InfluxDB databases on Amazon
    /// Web Services for near real-time time-series applications using open-source APIs. With
    /// Amazon Timestream for InfluxDB, it is easy to set up, operate, and scale time-series
    /// workloads that can answer queries with single-digit millisecond query response time.
    /// </summary>
    public partial interface IAmazonTimestreamInfluxDB : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ITimestreamInfluxDBPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new on-demand backup of a Timestream for InfluxDB resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDbBackup service method.</param>
        /// <returns>The response from the CreateDbBackup service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbBackup">REST API Reference for CreateDbBackup Operation</seealso>
        CreateDbBackupResponse CreateDbBackup(CreateDbBackupRequest request);
#endif

        /// <summary>
        /// Creates a new on-demand backup of a Timestream for InfluxDB resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDbBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateDbBackup service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbBackup">REST API Reference for CreateDbBackup Operation</seealso>
        Task<CreateDbBackupResponse> CreateDbBackupAsync(CreateDbBackupRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new Timestream for InfluxDB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDbCluster service method.</param>
        /// <returns>The response from the CreateDbCluster service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbCluster">REST API Reference for CreateDbCluster Operation</seealso>
        CreateDbClusterResponse CreateDbCluster(CreateDbClusterRequest request);
#endif

        /// <summary>
        /// Creates a new Timestream for InfluxDB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDbCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateDbCluster service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbCluster">REST API Reference for CreateDbCluster Operation</seealso>
        Task<CreateDbClusterResponse> CreateDbClusterAsync(CreateDbClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new Timestream for InfluxDB DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDbInstance service method.</param>
        /// <returns>The response from the CreateDbInstance service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbInstance">REST API Reference for CreateDbInstance Operation</seealso>
        CreateDbInstanceResponse CreateDbInstance(CreateDbInstanceRequest request);
#endif

        /// <summary>
        /// Creates a new Timestream for InfluxDB DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDbInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateDbInstance service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbInstance">REST API Reference for CreateDbInstance Operation</seealso>
        Task<CreateDbInstanceResponse> CreateDbInstanceAsync(CreateDbInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new Timestream for InfluxDB DB parameter group to associate with DB instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDbParameterGroup service method.</param>
        /// <returns>The response from the CreateDbParameterGroup service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbParameterGroup">REST API Reference for CreateDbParameterGroup Operation</seealso>
        CreateDbParameterGroupResponse CreateDbParameterGroup(CreateDbParameterGroupRequest request);
#endif

        /// <summary>
        /// Creates a new Timestream for InfluxDB DB parameter group to associate with DB instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDbParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateDbParameterGroup service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/CreateDbParameterGroup">REST API Reference for CreateDbParameterGroup Operation</seealso>
        Task<CreateDbParameterGroupResponse> CreateDbParameterGroupAsync(CreateDbParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a Timestream for InfluxDB backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDbBackup service method.</param>
        /// <returns>The response from the DeleteDbBackup service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/DeleteDbBackup">REST API Reference for DeleteDbBackup Operation</seealso>
        DeleteDbBackupResponse DeleteDbBackup(DeleteDbBackupRequest request);
#endif

        /// <summary>
        /// Deletes a Timestream for InfluxDB backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDbBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteDbBackup service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/DeleteDbBackup">REST API Reference for DeleteDbBackup Operation</seealso>
        Task<DeleteDbBackupResponse> DeleteDbBackupAsync(DeleteDbBackupRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a Timestream for InfluxDB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDbCluster service method.</param>
        /// <returns>The response from the DeleteDbCluster service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/DeleteDbCluster">REST API Reference for DeleteDbCluster Operation</seealso>
        DeleteDbClusterResponse DeleteDbCluster(DeleteDbClusterRequest request);
#endif

        /// <summary>
        /// Deletes a Timestream for InfluxDB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDbCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteDbCluster service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/DeleteDbCluster">REST API Reference for DeleteDbCluster Operation</seealso>
        Task<DeleteDbClusterResponse> DeleteDbClusterAsync(DeleteDbClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a Timestream for InfluxDB DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDbInstance service method.</param>
        /// <returns>The response from the DeleteDbInstance service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/DeleteDbInstance">REST API Reference for DeleteDbInstance Operation</seealso>
        DeleteDbInstanceResponse DeleteDbInstance(DeleteDbInstanceRequest request);
#endif

        /// <summary>
        /// Deletes a Timestream for InfluxDB DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDbInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteDbInstance service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/DeleteDbInstance">REST API Reference for DeleteDbInstance Operation</seealso>
        Task<DeleteDbInstanceResponse> DeleteDbInstanceAsync(DeleteDbInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about a specific Timestream for InfluxDB backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbBackup service method.</param>
        /// <returns>The response from the GetDbBackup service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbBackup">REST API Reference for GetDbBackup Operation</seealso>
        GetDbBackupResponse GetDbBackup(GetDbBackupRequest request);
#endif

        /// <summary>
        /// Returns information about a specific Timestream for InfluxDB backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDbBackup service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbBackup">REST API Reference for GetDbBackup Operation</seealso>
        Task<GetDbBackupResponse> GetDbBackupAsync(GetDbBackupRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about a Timestream for InfluxDB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbCluster service method.</param>
        /// <returns>The response from the GetDbCluster service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbCluster">REST API Reference for GetDbCluster Operation</seealso>
        GetDbClusterResponse GetDbCluster(GetDbClusterRequest request);
#endif

        /// <summary>
        /// Retrieves information about a Timestream for InfluxDB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDbCluster service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbCluster">REST API Reference for GetDbCluster Operation</seealso>
        Task<GetDbClusterResponse> GetDbClusterAsync(GetDbClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a Timestream for InfluxDB DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbInstance service method.</param>
        /// <returns>The response from the GetDbInstance service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbInstance">REST API Reference for GetDbInstance Operation</seealso>
        GetDbInstanceResponse GetDbInstance(GetDbInstanceRequest request);
#endif

        /// <summary>
        /// Returns a Timestream for InfluxDB DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDbInstance service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbInstance">REST API Reference for GetDbInstance Operation</seealso>
        Task<GetDbInstanceResponse> GetDbInstanceAsync(GetDbInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a Timestream for InfluxDB DB parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbParameterGroup service method.</param>
        /// <returns>The response from the GetDbParameterGroup service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbParameterGroup">REST API Reference for GetDbParameterGroup Operation</seealso>
        GetDbParameterGroupResponse GetDbParameterGroup(GetDbParameterGroupRequest request);
#endif

        /// <summary>
        /// Returns a Timestream for InfluxDB DB parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDbParameterGroup service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/GetDbParameterGroup">REST API Reference for GetDbParameterGroup Operation</seealso>
        Task<GetDbParameterGroupResponse> GetDbParameterGroupAsync(GetDbParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of Timestream for InfluxDB backups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbBackups service method.</param>
        /// <returns>The response from the ListDbBackups service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbBackups">REST API Reference for ListDbBackups Operation</seealso>
        ListDbBackupsResponse ListDbBackups(ListDbBackupsRequest request);
#endif

        /// <summary>
        /// Returns a list of Timestream for InfluxDB backups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbBackups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDbBackups service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbBackups">REST API Reference for ListDbBackups Operation</seealso>
        Task<ListDbBackupsResponse> ListDbBackupsAsync(ListDbBackupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of Timestream for InfluxDB DB clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbClusters service method.</param>
        /// <returns>The response from the ListDbClusters service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbClusters">REST API Reference for ListDbClusters Operation</seealso>
        ListDbClustersResponse ListDbClusters(ListDbClustersRequest request);
#endif

        /// <summary>
        /// Returns a list of Timestream for InfluxDB DB clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDbClusters service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbClusters">REST API Reference for ListDbClusters Operation</seealso>
        Task<ListDbClustersResponse> ListDbClustersAsync(ListDbClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of Timestream for InfluxDB DB instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbInstances service method.</param>
        /// <returns>The response from the ListDbInstances service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbInstances">REST API Reference for ListDbInstances Operation</seealso>
        ListDbInstancesResponse ListDbInstances(ListDbInstancesRequest request);
#endif

        /// <summary>
        /// Returns a list of Timestream for InfluxDB DB instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDbInstances service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbInstances">REST API Reference for ListDbInstances Operation</seealso>
        Task<ListDbInstancesResponse> ListDbInstancesAsync(ListDbInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of Timestream for InfluxDB clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbInstancesForCluster service method.</param>
        /// <returns>The response from the ListDbInstancesForCluster service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbInstancesForCluster">REST API Reference for ListDbInstancesForCluster Operation</seealso>
        ListDbInstancesForClusterResponse ListDbInstancesForCluster(ListDbInstancesForClusterRequest request);
#endif

        /// <summary>
        /// Returns a list of Timestream for InfluxDB clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbInstancesForCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDbInstancesForCluster service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbInstancesForCluster">REST API Reference for ListDbInstancesForCluster Operation</seealso>
        Task<ListDbInstancesForClusterResponse> ListDbInstancesForClusterAsync(ListDbInstancesForClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of Timestream for InfluxDB DB parameter groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbParameterGroups service method.</param>
        /// <returns>The response from the ListDbParameterGroups service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbParameterGroups">REST API Reference for ListDbParameterGroups Operation</seealso>
        ListDbParameterGroupsResponse ListDbParameterGroups(ListDbParameterGroupsRequest request);
#endif

        /// <summary>
        /// Returns a list of Timestream for InfluxDB DB parameter groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbParameterGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDbParameterGroups service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListDbParameterGroups">REST API Reference for ListDbParameterGroups Operation</seealso>
        Task<ListDbParameterGroupsResponse> ListDbParameterGroupsAsync(ListDbParameterGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// A list of tags applied to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// A list of tags applied to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Reboots a Timestream for InfluxDB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDbCluster service method.</param>
        /// <returns>The response from the RebootDbCluster service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/RebootDbCluster">REST API Reference for RebootDbCluster Operation</seealso>
        RebootDbClusterResponse RebootDbCluster(RebootDbClusterRequest request);
#endif

        /// <summary>
        /// Reboots a Timestream for InfluxDB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDbCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RebootDbCluster service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/RebootDbCluster">REST API Reference for RebootDbCluster Operation</seealso>
        Task<RebootDbClusterResponse> RebootDbClusterAsync(RebootDbClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Reboots a Timestream for InfluxDB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDbInstance service method.</param>
        /// <returns>The response from the RebootDbInstance service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/RebootDbInstance">REST API Reference for RebootDbInstance Operation</seealso>
        RebootDbInstanceResponse RebootDbInstance(RebootDbInstanceRequest request);
#endif

        /// <summary>
        /// Reboots a Timestream for InfluxDB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDbInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RebootDbInstance service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/RebootDbInstance">REST API Reference for RebootDbInstance Operation</seealso>
        Task<RebootDbInstanceResponse> RebootDbInstanceAsync(RebootDbInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Restores a Timestream for InfluxDB resource from a backup. By default, a new resource
        /// is created. You can optionally restore to the same resource using the REPLACE_EXISTING
        /// restore mode.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromDbBackup service method.</param>
        /// <returns>The response from the RestoreFromDbBackup service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/RestoreFromDbBackup">REST API Reference for RestoreFromDbBackup Operation</seealso>
        RestoreFromDbBackupResponse RestoreFromDbBackup(RestoreFromDbBackupRequest request);
#endif

        /// <summary>
        /// Restores a Timestream for InfluxDB resource from a backup. By default, a new resource
        /// is created. You can optionally restore to the same resource using the REPLACE_EXISTING
        /// restore mode.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromDbBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RestoreFromDbBackup service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/RestoreFromDbBackup">REST API Reference for RestoreFromDbBackup Operation</seealso>
        Task<RestoreFromDbBackupResponse> RestoreFromDbBackupAsync(RestoreFromDbBackupRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Tags are composed of a Key/Value pairs. You can use tags to categorize and track your
        /// Timestream for InfluxDB resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// Tags are composed of a Key/Value pairs. You can use tags to categorize and track your
        /// Timestream for InfluxDB resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes the tag from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// Removes the tag from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a Timestream for InfluxDB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDbCluster service method.</param>
        /// <returns>The response from the UpdateDbCluster service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/UpdateDbCluster">REST API Reference for UpdateDbCluster Operation</seealso>
        UpdateDbClusterResponse UpdateDbCluster(UpdateDbClusterRequest request);
#endif

        /// <summary>
        /// Updates a Timestream for InfluxDB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDbCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateDbCluster service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/UpdateDbCluster">REST API Reference for UpdateDbCluster Operation</seealso>
        Task<UpdateDbClusterResponse> UpdateDbClusterAsync(UpdateDbClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a Timestream for InfluxDB DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDbInstance service method.</param>
        /// <returns>The response from the UpdateDbInstance service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/UpdateDbInstance">REST API Reference for UpdateDbInstance Operation</seealso>
        UpdateDbInstanceResponse UpdateDbInstance(UpdateDbInstanceRequest request);
#endif

        /// <summary>
        /// Updates a Timestream for InfluxDB DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDbInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateDbInstance service method, as returned by TimestreamInfluxDB.</returns>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ConflictException">
        /// The request conflicts with an existing resource in Timestream for InfluxDB.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ResourceNotFoundException">
        /// The requested resource was not found or does not exist.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamInfluxDB.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Timestream for InfluxDB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-influxdb-2023-01-27/UpdateDbInstance">REST API Reference for UpdateDbInstance Operation</seealso>
        Task<UpdateDbInstanceResponse> UpdateDbInstanceAsync(UpdateDbInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonTimestreamInfluxDBConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonTimestreamInfluxDBConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonTimestreamInfluxDBConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonTimestreamInfluxDBConfig to create AmazonTimestreamInfluxDBClient");
            }

            return awsCredentials == null ?
                    new AmazonTimestreamInfluxDBClient(serviceClientConfig) :
                    new AmazonTimestreamInfluxDBClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
